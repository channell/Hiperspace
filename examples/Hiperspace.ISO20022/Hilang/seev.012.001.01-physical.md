# seev.012.001.01-physical
```mermaid
classDiagram
    class ISO20022.Seev012001.Document {
        # Uri  : String
        + AgtCAElctnAdvc () : ISO20022.Seev012001.AgentCAElectionAdviceV01
        + Validation () = validation(validElement(AgtCAElctnAdvc))
    }
    class ISO20022.Seev012001.AgentCAElectionAdviceV01 {
        # owner  : ISO20022.Seev012001.Document
        + CtctDtls  : ISO20022.Seev012001.ContactPerson1
        + AddtlInf  : ISO20022.Seev012001.CorporateActionAdditionalInformation1
        + ElctnDtls  : ISO20022.Seev012001.CorporateActionElection3
        + CorpActnGnlInf  : ISO20022.Seev012001.CorporateActionInformation1
        + ElctnAdvcTpAndLkg  : ISO20022.Seev012001.ElectionAdviceFunction1
        + Id  : ISO20022.Seev012001.DocumentIdentification8
        + Validation () = validation(validElement(CtctDtls),validElement(AddtlInf),validElement(ElctnDtls),validElement(CorpActnGnlInf),validElement(ElctnAdvcTpAndLkg),validElement(Id))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Seev012001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AgtCAElctnAdvc|ISO20022.Seev012001.AgentCAElectionAdviceV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AgtCAElctnAdvc))|

---

## AspectImpl ISO20022.Seev012001.AgentCAElectionAdviceV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Seev012001.Document||||
|+|CtctDtls|ISO20022.Seev012001.ContactPerson1||XmlElement()||
|+|AddtlInf|ISO20022.Seev012001.CorporateActionAdditionalInformation1||XmlElement()||
|+|ElctnDtls|ISO20022.Seev012001.CorporateActionElection3||XmlElement()||
|+|CorpActnGnlInf|ISO20022.Seev012001.CorporateActionInformation1||XmlElement()||
|+|ElctnAdvcTpAndLkg|ISO20022.Seev012001.ElectionAdviceFunction1||XmlElement()||
|+|Id|ISO20022.Seev012001.DocumentIdentification8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validElement(AddtlInf),validElement(ElctnDtls),validElement(CorpActnGnlInf),validElement(ElctnAdvcTpAndLkg),validElement(Id))|

