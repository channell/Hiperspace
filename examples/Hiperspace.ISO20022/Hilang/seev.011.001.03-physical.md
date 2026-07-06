# seev.011.001.03-physical
```mermaid
classDiagram
    class ISO20022.Seev011001.Document {
        # Uri  : String
        + AgtCANtfctnStsAdvc () : ISO20022.Seev011001.AgentCANotificationStatusAdviceV03
        + Validation () = validation(validElement(AgtCANtfctnStsAdvc))
    }
    class ISO20022.Seev011001.AgentCANotificationStatusAdviceV03 {
        # owner  : ISO20022.Seev011001.Document
        + CorpActnGnlInf  : ISO20022.Seev011001.CorporateActionGeneralInformation175
        + AgtDocIdAndSts  : ISO20022.Seev011001.AgentDocumentIdentificationAndStatus1Choice
        + Validation () = validation(validElement(CorpActnGnlInf),validElement(AgtDocIdAndSts))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Seev011001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AgtCANtfctnStsAdvc|ISO20022.Seev011001.AgentCANotificationStatusAdviceV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AgtCANtfctnStsAdvc))|

---

## AspectImpl ISO20022.Seev011001.AgentCANotificationStatusAdviceV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Seev011001.Document||||
|+|CorpActnGnlInf|ISO20022.Seev011001.CorporateActionGeneralInformation175||XmlElement()||
|+|AgtDocIdAndSts|ISO20022.Seev011001.AgentDocumentIdentificationAndStatus1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnGnlInf),validElement(AgtDocIdAndSts))|

