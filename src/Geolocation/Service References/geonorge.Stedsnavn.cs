﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://xml.statkart.no/tjenester/ssr_index_search", ConfigurationName="ssrIndexSearch")]
public interface ssrIndexSearch
{
    
    // CODEGEN: Parameter 'sokRes' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ssrRes))]
    [return: System.ServiceModel.MessageParameterAttribute(Name="sokRes")]
    sokResponse sok(sokRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    System.Threading.Tasks.Task<sokResponse> sokAsync(sokRequest request);
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xml.statkart.no/tjenester/ssr_index_search")]
public partial class sokReq
{
    
    private string brukeridField;
    
    private string passordField;
    
    private string aliasIdField;
    
    private int ssrIdField;
    
    private bool ssrIdFieldSpecified;
    
    private int objIdField;
    
    private bool objIdFieldSpecified;
    
    private string navnField;
    
    private string fylkeKommueListeField;
    
    private int nordLLField;
    
    private bool nordLLFieldSpecified;
    
    private int ostLLField;
    
    private bool ostLLFieldSpecified;
    
    private int nordURField;
    
    private bool nordURFieldSpecified;
    
    private int ostURField;
    
    private bool ostURFieldSpecified;
    
    private int antPerSideField;
    
    private bool antPerSideFieldSpecified;
    
    private int sideField;
    
    private bool sideFieldSpecified;
    
    private int epsgKodeField;
    
    private bool epsgKodeFieldSpecified;
    
    private bool eksakteForstField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
    public string brukerid
    {
        get
        {
            return this.brukeridField;
        }
        set
        {
            this.brukeridField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
    public string passord
    {
        get
        {
            return this.passordField;
        }
        set
        {
            this.passordField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
    public string aliasId
    {
        get
        {
            return this.aliasIdField;
        }
        set
        {
            this.aliasIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
    public int ssrId
    {
        get
        {
            return this.ssrIdField;
        }
        set
        {
            this.ssrIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ssrIdSpecified
    {
        get
        {
            return this.ssrIdFieldSpecified;
        }
        set
        {
            this.ssrIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
    public int objId
    {
        get
        {
            return this.objIdField;
        }
        set
        {
            this.objIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool objIdSpecified
    {
        get
        {
            return this.objIdFieldSpecified;
        }
        set
        {
            this.objIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
    public string navn
    {
        get
        {
            return this.navnField;
        }
        set
        {
            this.navnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
    public string fylkeKommueListe
    {
        get
        {
            return this.fylkeKommueListeField;
        }
        set
        {
            this.fylkeKommueListeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
    public int nordLL
    {
        get
        {
            return this.nordLLField;
        }
        set
        {
            this.nordLLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool nordLLSpecified
    {
        get
        {
            return this.nordLLFieldSpecified;
        }
        set
        {
            this.nordLLFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
    public int ostLL
    {
        get
        {
            return this.ostLLField;
        }
        set
        {
            this.ostLLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ostLLSpecified
    {
        get
        {
            return this.ostLLFieldSpecified;
        }
        set
        {
            this.ostLLFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
    public int nordUR
    {
        get
        {
            return this.nordURField;
        }
        set
        {
            this.nordURField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool nordURSpecified
    {
        get
        {
            return this.nordURFieldSpecified;
        }
        set
        {
            this.nordURFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
    public int ostUR
    {
        get
        {
            return this.ostURField;
        }
        set
        {
            this.ostURField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ostURSpecified
    {
        get
        {
            return this.ostURFieldSpecified;
        }
        set
        {
            this.ostURFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
    public int antPerSide
    {
        get
        {
            return this.antPerSideField;
        }
        set
        {
            this.antPerSideField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool antPerSideSpecified
    {
        get
        {
            return this.antPerSideFieldSpecified;
        }
        set
        {
            this.antPerSideFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
    public int side
    {
        get
        {
            return this.sideField;
        }
        set
        {
            this.sideField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sideSpecified
    {
        get
        {
            return this.sideFieldSpecified;
        }
        set
        {
            this.sideFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
    public int epsgKode
    {
        get
        {
            return this.epsgKodeField;
        }
        set
        {
            this.epsgKodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool epsgKodeSpecified
    {
        get
        {
            return this.epsgKodeFieldSpecified;
        }
        set
        {
            this.epsgKodeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
    public bool eksakteForst
    {
        get
        {
            return this.eksakteForstField;
        }
        set
        {
            this.eksakteForstField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xml.statkart.no/tjenester/ssr_index_search")]
public partial class Stedsnavn
{
    
    private int ssrIdField;
    
    private string navnetypeField;
    
    private string kommunenavnField;
    
    private string fylkesnavnField;
    
    private string stedsnavnField;
    
    private double austField;
    
    private bool austFieldSpecified;
    
    private double nordField;
    
    private bool nordFieldSpecified;
    
    private string duplikatField;
    
    private string viktigstedField;
    
    private string skrivemaatestatusField;
    
    private string spraakField;
    
    private string skrivemaatenavnField;
    
    private int epsgKodeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
    public int ssrId
    {
        get
        {
            return this.ssrIdField;
        }
        set
        {
            this.ssrIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
    public string navnetype
    {
        get
        {
            return this.navnetypeField;
        }
        set
        {
            this.navnetypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
    public string kommunenavn
    {
        get
        {
            return this.kommunenavnField;
        }
        set
        {
            this.kommunenavnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
    public string fylkesnavn
    {
        get
        {
            return this.fylkesnavnField;
        }
        set
        {
            this.fylkesnavnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
    public string stedsnavn
    {
        get
        {
            return this.stedsnavnField;
        }
        set
        {
            this.stedsnavnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
    public double aust
    {
        get
        {
            return this.austField;
        }
        set
        {
            this.austField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool austSpecified
    {
        get
        {
            return this.austFieldSpecified;
        }
        set
        {
            this.austFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
    public double nord
    {
        get
        {
            return this.nordField;
        }
        set
        {
            this.nordField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool nordSpecified
    {
        get
        {
            return this.nordFieldSpecified;
        }
        set
        {
            this.nordFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
    public string duplikat
    {
        get
        {
            return this.duplikatField;
        }
        set
        {
            this.duplikatField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
    public string viktigsted
    {
        get
        {
            return this.viktigstedField;
        }
        set
        {
            this.viktigstedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
    public string skrivemaatestatus
    {
        get
        {
            return this.skrivemaatestatusField;
        }
        set
        {
            this.skrivemaatestatusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
    public string spraak
    {
        get
        {
            return this.spraakField;
        }
        set
        {
            this.spraakField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
    public string skrivemaatenavn
    {
        get
        {
            return this.skrivemaatenavnField;
        }
        set
        {
            this.skrivemaatenavnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
    public int epsgKode
    {
        get
        {
            return this.epsgKodeField;
        }
        set
        {
            this.epsgKodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xml.statkart.no/tjenester/ssr_index_search")]
public partial class ssrSokStatus
{
    
    private bool okField;
    
    private string meldingField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
    public bool ok
    {
        get
        {
            return this.okField;
        }
        set
        {
            this.okField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
    public string melding
    {
        get
        {
            return this.meldingField;
        }
        set
        {
            this.meldingField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(sokRes))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xml.statkart.no/tjenester/ssr_index_search")]
public abstract partial class ssrRes
{
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xml.statkart.no/tjenester/ssr_index_search")]
public partial class sokRes : ssrRes
{
    
    private ssrSokStatus sokStatusField;
    
    private int totaltAntallTreffField;
    
    private Stedsnavn[] stedsnavnField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
    public ssrSokStatus sokStatus
    {
        get
        {
            return this.sokStatusField;
        }
        set
        {
            this.sokStatusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
    public int totaltAntallTreff
    {
        get
        {
            return this.totaltAntallTreffField;
        }
        set
        {
            this.totaltAntallTreffField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("stedsnavn", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=2)]
    public Stedsnavn[] stedsnavn
    {
        get
        {
            return this.stedsnavnField;
        }
        set
        {
            this.stedsnavnField = value;
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="sok", WrapperNamespace="http://xml.statkart.no/tjenester/ssr_index_search", IsWrapped=true)]
public partial class sokRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xml.statkart.no/tjenester/ssr_index_search", Order=0)]
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public sokReq sokReq;
    
    public sokRequest()
    {
    }
    
    public sokRequest(sokReq sokReq)
    {
        this.sokReq = sokReq;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="sokResponse", WrapperNamespace="http://xml.statkart.no/tjenester/ssr_index_search", IsWrapped=true)]
public partial class sokResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xml.statkart.no/tjenester/ssr_index_search", Order=0)]
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public sokRes sokRes;
    
    public sokResponse()
    {
    }
    
    public sokResponse(sokRes sokRes)
    {
        this.sokRes = sokRes;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ssrIndexSearchChannel : ssrIndexSearch, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class ssrIndexSearchClient : System.ServiceModel.ClientBase<ssrIndexSearch>, ssrIndexSearch
{
    
    public ssrIndexSearchClient()
    {
    }
    
    public ssrIndexSearchClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public ssrIndexSearchClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ssrIndexSearchClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ssrIndexSearchClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    sokResponse ssrIndexSearch.sok(sokRequest request)
    {
        return base.Channel.sok(request);
    }
    
    public sokRes sok(sokReq sokReq)
    {
        sokRequest inValue = new sokRequest();
        inValue.sokReq = sokReq;
        sokResponse retVal = ((ssrIndexSearch)(this)).sok(inValue);
        return retVal.sokRes;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<sokResponse> ssrIndexSearch.sokAsync(sokRequest request)
    {
        return base.Channel.sokAsync(request);
    }
    
    public System.Threading.Tasks.Task<sokResponse> sokAsync(sokReq sokReq)
    {
        sokRequest inValue = new sokRequest();
        inValue.sokReq = sokReq;
        return ((ssrIndexSearch)(this)).sokAsync(inValue);
    }
}