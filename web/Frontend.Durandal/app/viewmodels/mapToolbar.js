﻿define(['services/logger', "knockout", "services/application", "services/dataServices", "viewmodels/mapOl3", "services/layerConfig", "services/knockoutExtensions", 'viewmodels/shell'],
    function (logger, ko, application, dataServices, map, layerConfig, jqAutoComplete, shell) {
        "use strict";

        var bookmarkThumbCanvas;

        var vpstate = application.viewportState,
            isGBNr = function(searchTerm) {
                return searchTerm.match(/\d+\/\d+\/\d+/);
            },
            vm = {
                currentBaseLayer: ko.observable(),
                title: "Map toolbar",
                locations: ko.observableArray(),
                bookmarks: application.bookmarks,
                showRemoveBookmark: ko.observable(false),
                enableRemoveBookmark: function() {
                    vm.showRemoveBookmark(true);
                },
                disableRemoveBookmark: function() {
                    vm.showRemoveBookmark(false);
                },
                baseLayerList: ko.computed(function() {
                    return layerConfig.baseLayerPool.filter(function(e) {
                        return !e.needsToken || (!!e.needsToken && !!application.ndToken());
                    });
                }),
                overlayLayerList: layerConfig.overlayLayerPool,

                selectedLocation: ko.observable(),
                searchLocationWatermarkText: "Zoom til sted...",
                currentLocation: null,
                location: function(x, y, text, zoom) {
                    return {
                        name: ko.observable(text),
                        x: ko.observable(x),
                        y: ko.observable(y),
                        displayName: ko.observable(text),
                        zoom: zoom
                    };
                },
                setPosition: function (position) {
                    var coord = ol.proj.fromLonLat([position.coords.longitude, position.coords.latitude]);
                    vm.currentLocation = vm.location();
                    vm.currentLocation.x(coord[0]);
                    vm.currentLocation.y(coord[1]);
                    if (position.coords.accuracy > 40000) { vm.currentLocation.zoom = 10; }     // Todo: check values
                    else if (position.coords.accuracy > 20000) { vm.currentLocation.zoom = 11; }
                    else if (position.coords.accuracy > 10000) { vm.currentLocation.zoom = 12; }
                    else if (position.coords.accuracy > 5000) { vm.currentLocation.zoom = 13; }
                    else if (position.coords.accuracy > 2500) { vm.currentLocation.zoom = 14; }
                    else if (position.coords.accuracy > 1000) { vm.currentLocation.zoom = 15; }
                    else { vm.currentLocation.zoom = 16; }
                    vm.zoomToCurrentLocation();
                },
                zoomToCurrentLocation: function () {
                    if (vm.currentLocation) {
                        vpstate.center(vm.currentLocation.x() + "," + vm.currentLocation.y());
                        vpstate.zoom(vm.currentLocation.zoom);
                    } else {
                        if (navigator.geolocation) {
                            navigator.geolocation.getCurrentPosition(vm.setPosition);
                        }
                    }
                },
                setSelectedBaseLayerName: function (layerName) {
                    map.selectedBaseLayer(layerName);
                },
                toggleOverlayLayerName: function (layerName) {
                    map.toggleOverlayLayer(layerName);
                },
                getPositions: function (searchTerm, oarray) {
                    if (isGBNr(searchTerm)) {
                        var st = searchTerm.replace(/\//g, "_");
                        dataServices.getGbnrByTerm(st).then(function (data) {
                            var result = [];
                            data.forEach(function (place) {
                                var desc = "GBNr: " + searchTerm; // + " areal: " + place.Area;
                                result.push(vm.location(place.CoordinateList[0].X, place.CoordinateList[0].Y, desc, 17));
                            });
                            oarray(result);
                        });
                    } else {
                        dataServices.getLocationByTerm(searchTerm).then(function (data) {
                            var result = [];
                            data.forEach(function (place) {
                                var desc = place.Name + ", " + place.MunicipalityName + (place.CountyName ? ', ' + place.CountyName : '') + ', ' + place.Product;
                                result.push(vm.location(place.Coordinate.X, place.Coordinate.Y, desc, vm.getZoomByType(place.ProductTypeLevel)));
                            });
                            oarray(result);
                        });
                    }
                },
                createBookmark: function () {
                    var image;
                    var e;
                    try {
                        bookmarkThumbCanvas = bookmarkThumbCanvas || document.createElement('canvas');
                        bookmarkThumbCanvas.width = application.config.bookmarkThumbSize;
                        bookmarkThumbCanvas.height = application.config.bookmarkThumbSize;
                        bookmarkThumbCanvas.getContext('2d').drawImage(map.map.getViewport().children[0], 0, 0, application.config.bookmarkThumbSize, application.config.bookmarkThumbSize);

                        image = bookmarkThumbCanvas.toDataURL('image/png');
                    } catch (e) {
                        console.log(e);
                        // Probably tainted canvas (todo: resolve with CORS/proxy)
                        // for now, just fill
                        var canvas = document.createElement('canvas');
                        canvas.width = application.config.bookmarkThumbSize;
                        canvas.height = application.config.bookmarkThumbSize;
                        var ctx = canvas.getContext("2d");
                        ctx.fillStyle = "#AA0000";
                        ctx.fillRect(0, 0, canvas.width, canvas.height);

                        image = canvas.toDataURL('image/png');
                    }

                    application.bookmarks.unshift({
                        baseLayer: vm.currentBaseLayer(),
                        image: image,
                        url: window.location.href,
                        filter: ko.toJSON(application.filter),
                        grid: ko.toJSON(application.grid)
                    });

                    try {
                        window.localStorage.setItem(application.config.bookmarkLocalStorageKey, JSON.stringify(application.bookmarks()));
                    } catch (e) {
                        // TODO: handle this.
                        logger.log('local storage full?', e);
                    }
                },
                applyFilter: function (bookmark) {
                    var grid = JSON.parse(bookmark.grid);
                    application.applyFilter(bookmark);

                    if (grid.Grid) {
                        var checkNode = $('#gridtree').treeview('getNode', grid.Grid.nodeId);
                        if (checkNode.text === grid.Grid.text && checkNode.type === grid.Grid.type) {
                            $('#gridtree').treeview('selectNode', grid.Grid.nodeId);
                        } else {
                            // Set filter directly
                            map.applyGrid(grid.Grid);
                        }
                    } else {
                        // Unselect if selected
                        var selected = $('#gridtree').treeview('getSelected');
                        selected.forEach(function(node) {
                            $('#gridtree').treeview('unselectNode', node.nodeId);
                        });

                        map.applyGrid(false);
                    }

                    vm.currentBaseLayer(bookmark.baseLayer);
                    application.currentLayer(bookmark.baseLayer);
                    // Hack because the two way binding for value is broken in multiselect.
                    $('#basisLayerSelect + .btn-group input').prop('checked', false);
                    $('.multiselect-container input[value="' + bookmark.baseLayer + '"').prop("checked", true);

                    window.location.assign(bookmark.url);
                },
                removeBookmark: function () {
                    application.bookmarks.remove(this);
                    window.localStorage.setItem(application.config.bookmarkLocalStorageKey, JSON.stringify(application.bookmarks()));
                },
                toggleFullscreen: shell.toggleFullscreen,
                //toggle3d: function () {
                //    var ol3D = new olcs.OLCesium({ map: map.map });
                //    var scene = ol3D.getCesiumScene();
                //    scene.terrainProvider = new Cesium.CesiumTerrainProvider({
                //        url: 'https://assets.agi.com/stk-terrain/world'
                //    });
                //    ol3D.setEnabled(true);
                //},
                changeBasisLayer: function () {
                    map.SetBaseLayerVisible();
                },
                getZoomByType: function (productTypeLevel) {
                    var lev = Math.min(4, Math.max(1, productTypeLevel)),
                        result = (5 - lev) * 4;
                    return result;
                },
                dropdowntemplates: {
                    button: '<button type="button" class="multiselect dropdown-toggle glyphicon glyphicon-align-justify" data-toggle="dropdown"></button>',
                    ul: '<ul class="multiselect-container dropdown-menu"></ul>',
                    li: '<li><a href="javascript:void(0);"><label></label></a></li>'
                },
                dropdownOverlaytemplates: {
                    button: '<button type="button" class="multiselect dropdown-toggle glyphicon glyphicon-picture" data-toggle="dropdown"></button>',
                    ul: '<ul class="multiselect-container dropdown-menu"></ul>',
                    li: '<li><a href="javascript:void(0);"><label></label></a></li>'
                },
                compositionComplete: function () {
                    $('#overlayMulti').multiselect({
                        templates: vm.dropdownOverlaytemplates,
                        onChange: function (option, checked) {
                            vm.toggleOverlayLayerName(option.val());
                        }
                    });
                    $('#basisLayerSelect').multiselect({
                        templates: vm.dropdowntemplates,
                        onChange: function (option, checked) {
                            vm.setSelectedBaseLayerName(option.val());
                        }
                    });
                },

                // bookmarks menu stuff
                openBookmarks: ko.observable(false),
                toggleBookmarksContainer: function () {
                    vm.openBookmarks(!vm.openBookmarks());
                }
            };


        if (!vm.currentBaseLayer() && location.hash) {
            var baselayer = location.hash.replace(/^.*background\/(.*?)$/, '$1');
            vm.currentBaseLayer(baselayer);
            application.currentLayer(baselayer);
        }

        vm.tiledBookmarks = ko.computed(function () {
            var c = 0, r = [], b = application.bookmarks();
            while (c < b.length) {
                r.push(b.slice(c, c += 5));
            }
            return r;
        });

        application.initBookmarks();

        vm.selectedLocation.subscribe(function (newValue) {
            if (newValue && newValue.x()) {
                vm.currentLocation = newValue;
                vm.zoomToCurrentLocation();
            }
        });

        return vm;
    });
