# reda.008.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda008001.Document {
        # Uri  : String
        + SctyCreStsAdvc () : ISO20022.Reda008001.SecurityCreationStatusAdviceV01
        + Validation () = validation(validElement(SctyCreStsAdvc))
    }
    class ISO20022.Reda008001.SecurityCreationStatusAdviceV01 {
        # owner  : ISO20022.Reda008001.Document
        + SplmtryData  : List~ISO20022.Reda008001.SupplementaryData1~
        + PrcgSts  : ISO20022.Reda008001.ProcessingStatus72Choice
        + FinInstrmId  : ISO20022.Reda008001.SecurityIdentification39
        + MsgHdr  : ISO20022.Reda008001.MessageHeader12
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(PrcgSts),validElement(FinInstrmId),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda008001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SctyCreStsAdvc|ISO20022.Reda008001.SecurityCreationStatusAdviceV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyCreStsAdvc))|

---

## AspectImpl ISO20022.Reda008001.SecurityCreationStatusAdviceV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda008001.Document||||
|+|SplmtryData|List<ISO20022.Reda008001.SupplementaryData1>||XmlElement()||
|+|PrcgSts|ISO20022.Reda008001.ProcessingStatus72Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Reda008001.SecurityIdentification39||XmlElement()||
|+|MsgHdr|ISO20022.Reda008001.MessageHeader12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(PrcgSts),validElement(FinInstrmId),validElement(MsgHdr))|

