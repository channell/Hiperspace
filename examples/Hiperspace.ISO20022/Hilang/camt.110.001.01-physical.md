# camt.110.001.01-physical
```mermaid
classDiagram
    class ISO20022.Camt110001.Document {
        # Uri  : String
        + InvstgtnReq () : ISO20022.Camt110001.InvestigationRequestV01
        + Validation () = validation(validElement(InvstgtnReq))
    }
    class ISO20022.Camt110001.InvestigationRequestV01 {
        # owner  : ISO20022.Camt110001.Document
        + SplmtryData  : List~ISO20022.Camt110001.SupplementaryData1~
        + InvstgtnData  : List~ISO20022.Camt110001.InvestigationReason2~
        + InvstgtnReq  : ISO20022.Camt110001.InvestigationRequest2
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""InvstgtnData""",InvstgtnData),validList("""InvstgtnData""",InvstgtnData),validElement(InvstgtnData),validElement(InvstgtnReq))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt110001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|InvstgtnReq|ISO20022.Camt110001.InvestigationRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InvstgtnReq))|

---

## AspectImpl ISO20022.Camt110001.InvestigationRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt110001.Document||||
|+|SplmtryData|List<ISO20022.Camt110001.SupplementaryData1>||XmlElement()||
|+|InvstgtnData|List<ISO20022.Camt110001.InvestigationReason2>||XmlElement()||
|+|InvstgtnReq|ISO20022.Camt110001.InvestigationRequest2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""InvstgtnData""",InvstgtnData),validList("""InvstgtnData""",InvstgtnData),validElement(InvstgtnData),validElement(InvstgtnReq))|

