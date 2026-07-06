# camt.047.001.08-physical
```mermaid
classDiagram
    class ISO20022.Camt047001.Document {
        # Uri  : String
        + RtrRsvatn () : ISO20022.Camt047001.ReturnReservationV08
        + Validation () = validation(validElement(RtrRsvatn))
    }
    class ISO20022.Camt047001.ReturnReservationV08 {
        # owner  : ISO20022.Camt047001.Document
        + SplmtryData  : List~ISO20022.Camt047001.SupplementaryData1~
        + RptOrErr  : ISO20022.Camt047001.ReservationOrError11Choice
        + MsgHdr  : ISO20022.Camt047001.MessageHeader7
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RptOrErr),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt047001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|RtrRsvatn|ISO20022.Camt047001.ReturnReservationV08||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RtrRsvatn))|

---

## AspectImpl ISO20022.Camt047001.ReturnReservationV08


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt047001.Document||||
|+|SplmtryData|List<ISO20022.Camt047001.SupplementaryData1>||XmlElement()||
|+|RptOrErr|ISO20022.Camt047001.ReservationOrError11Choice||XmlElement()||
|+|MsgHdr|ISO20022.Camt047001.MessageHeader7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RptOrErr),validElement(MsgHdr))|

