# camt.046.001.08-physical
```mermaid
classDiagram
    class ISO20022.Camt046001.Document {
        # Uri  : String
        + GetRsvatn () : ISO20022.Camt046001.GetReservationV08
        + Validation () = validation(validElement(GetRsvatn))
    }
    class ISO20022.Camt046001.GetReservationV08 {
        # owner  : ISO20022.Camt046001.Document
        + SplmtryData  : List~ISO20022.Camt046001.SupplementaryData1~
        + RsvatnQryDef  : ISO20022.Camt046001.ReservationQuery6
        + MsgHdr  : ISO20022.Camt046001.MessageHeader9
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RsvatnQryDef),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt046001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|GetRsvatn|ISO20022.Camt046001.GetReservationV08||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GetRsvatn))|

---

## AspectImpl ISO20022.Camt046001.GetReservationV08


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt046001.Document||||
|+|SplmtryData|List<ISO20022.Camt046001.SupplementaryData1>||XmlElement()||
|+|RsvatnQryDef|ISO20022.Camt046001.ReservationQuery6||XmlElement()||
|+|MsgHdr|ISO20022.Camt046001.MessageHeader9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RsvatnQryDef),validElement(MsgHdr))|

