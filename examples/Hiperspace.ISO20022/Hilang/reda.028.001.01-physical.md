# reda.028.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda028001.Document {
        # Uri  : String
        + CollDataStsAdvc () : ISO20022.Reda028001.CollateralDataStatusAdviceV01
        + Validation () = validation(validElement(CollDataStsAdvc))
    }
    class ISO20022.Reda028001.CollateralDataStatusAdviceV01 {
        # owner  : ISO20022.Reda028001.Document
        + SplmtryData  : List~ISO20022.Reda028001.SupplementaryData1~
        + StsRsnAndFinInstrm  : ISO20022.Reda028001.CollateralStatusReason2
        + StsRsn  : ISO20022.Reda028001.CollateralStatusReason1
        + MsgHdr  : ISO20022.Reda028001.MessageHeader12
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(StsRsnAndFinInstrm),validElement(StsRsn),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda028001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CollDataStsAdvc|ISO20022.Reda028001.CollateralDataStatusAdviceV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollDataStsAdvc))|

---

## AspectImpl ISO20022.Reda028001.CollateralDataStatusAdviceV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda028001.Document||||
|+|SplmtryData|List<ISO20022.Reda028001.SupplementaryData1>||XmlElement()||
|+|StsRsnAndFinInstrm|ISO20022.Reda028001.CollateralStatusReason2||XmlElement()||
|+|StsRsn|ISO20022.Reda028001.CollateralStatusReason1||XmlElement()||
|+|MsgHdr|ISO20022.Reda028001.MessageHeader12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(StsRsnAndFinInstrm),validElement(StsRsn),validElement(MsgHdr))|

