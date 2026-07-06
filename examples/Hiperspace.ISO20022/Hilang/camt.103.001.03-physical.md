# camt.103.001.03-physical
```mermaid
classDiagram
    class ISO20022.Camt103001.Document {
        # Uri  : String
        + CretRsvatn () : ISO20022.Camt103001.CreateReservationV03
        + Validation () = validation(validElement(CretRsvatn))
    }
    class ISO20022.Camt103001.CreateReservationV03 {
        # owner  : ISO20022.Camt103001.Document
        + SplmtryData  : List~ISO20022.Camt103001.SupplementaryData1~
        + ValSet  : ISO20022.Camt103001.Reservation4
        + RsvatnId  : ISO20022.Camt103001.ReservationIdentification4
        + MsgHdr  : ISO20022.Camt103001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(ValSet),validElement(RsvatnId),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt103001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CretRsvatn|ISO20022.Camt103001.CreateReservationV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CretRsvatn))|

---

## AspectImpl ISO20022.Camt103001.CreateReservationV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt103001.Document||||
|+|SplmtryData|List<ISO20022.Camt103001.SupplementaryData1>||XmlElement()||
|+|ValSet|ISO20022.Camt103001.Reservation4||XmlElement()||
|+|RsvatnId|ISO20022.Camt103001.ReservationIdentification4||XmlElement()||
|+|MsgHdr|ISO20022.Camt103001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(ValSet),validElement(RsvatnId),validElement(MsgHdr))|

