# camt.049.001.07-physical
```mermaid
classDiagram
    class ISO20022.Camt049001.Document {
        # Uri  : String
        + DelRsvatn () : ISO20022.Camt049001.DeleteReservationV07
        + Validation () = validation(validElement(DelRsvatn))
    }
    class ISO20022.Camt049001.DeleteReservationV07 {
        # owner  : ISO20022.Camt049001.Document
        + SplmtryData  : List~ISO20022.Camt049001.SupplementaryData1~
        + CurRsvatn  : ISO20022.Camt049001.ReservationIdentification4
        + MsgHdr  : ISO20022.Camt049001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(CurRsvatn),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt049001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|DelRsvatn|ISO20022.Camt049001.DeleteReservationV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DelRsvatn))|

---

## AspectImpl ISO20022.Camt049001.DeleteReservationV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt049001.Document||||
|+|SplmtryData|List<ISO20022.Camt049001.SupplementaryData1>||XmlElement()||
|+|CurRsvatn|ISO20022.Camt049001.ReservationIdentification4||XmlElement()||
|+|MsgHdr|ISO20022.Camt049001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(CurRsvatn),validElement(MsgHdr))|

