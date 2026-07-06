# seev.024.001.01-physical
```mermaid
classDiagram
    class ISO20022.Seev024001.Document {
        # Uri  : String
        + AgtCAInfStsAdvc () : ISO20022.Seev024001.AgentCAInformationStatusAdviceV01
        + Validation () = validation(validElement(AgtCAInfStsAdvc))
    }
    class ISO20022.Seev024001.AgentCAInformationStatusAdviceV01 {
        # owner  : ISO20022.Seev024001.Document
        + InfStsDtls  : ISO20022.Seev024001.CorporateActionInformationStatus1Choice
        + CorpActnAddtlInf  : ISO20022.Seev024001.CorporateActionAdditionalInformation1
        + AgtCAInfAdvcId  : ISO20022.Seev024001.DocumentIdentification8
        + Id  : ISO20022.Seev024001.DocumentIdentification8
        + Validation () = validation(validElement(InfStsDtls),validElement(CorpActnAddtlInf),validElement(AgtCAInfAdvcId),validElement(Id))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Seev024001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AgtCAInfStsAdvc|ISO20022.Seev024001.AgentCAInformationStatusAdviceV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AgtCAInfStsAdvc))|

---

## AspectImpl ISO20022.Seev024001.AgentCAInformationStatusAdviceV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Seev024001.Document||||
|+|InfStsDtls|ISO20022.Seev024001.CorporateActionInformationStatus1Choice||XmlElement()||
|+|CorpActnAddtlInf|ISO20022.Seev024001.CorporateActionAdditionalInformation1||XmlElement()||
|+|AgtCAInfAdvcId|ISO20022.Seev024001.DocumentIdentification8||XmlElement()||
|+|Id|ISO20022.Seev024001.DocumentIdentification8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InfStsDtls),validElement(CorpActnAddtlInf),validElement(AgtCAInfAdvcId),validElement(Id))|

