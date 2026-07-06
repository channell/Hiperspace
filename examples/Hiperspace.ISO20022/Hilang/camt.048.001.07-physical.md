# camt.048.001.07-physical
```mermaid
classDiagram
    class ISO20022.Camt048001.Document {
        # Uri  : String
        + ModfyRsvatn () : ISO20022.Camt048001.ModifyReservationV07
        + Validation () = validation(validElement(ModfyRsvatn))
    }
    class ISO20022.Camt048001.ModifyReservationV07 {
        # owner  : ISO20022.Camt048001.Document
        + SplmtryData  : List~ISO20022.Camt048001.SupplementaryData1~
        + NewRsvatnValSet  : ISO20022.Camt048001.Reservation4
        + RsvatnId  : ISO20022.Camt048001.CurrentOrDefaultReservation4Choice
        + MsgHdr  : ISO20022.Camt048001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(NewRsvatnValSet),validElement(RsvatnId),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt048001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ModfyRsvatn|ISO20022.Camt048001.ModifyReservationV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ModfyRsvatn))|

---

## AspectImpl ISO20022.Camt048001.ModifyReservationV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt048001.Document||||
|+|SplmtryData|List<ISO20022.Camt048001.SupplementaryData1>||XmlElement()||
|+|NewRsvatnValSet|ISO20022.Camt048001.Reservation4||XmlElement()||
|+|RsvatnId|ISO20022.Camt048001.CurrentOrDefaultReservation4Choice||XmlElement()||
|+|MsgHdr|ISO20022.Camt048001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(NewRsvatnValSet),validElement(RsvatnId),validElement(MsgHdr))|

