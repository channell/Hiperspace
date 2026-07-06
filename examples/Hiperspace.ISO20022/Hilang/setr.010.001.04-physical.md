# setr.010.001.04-physical
```mermaid
classDiagram
    class ISO20022.Setr010001.Document {
        # Uri  : String
        + SbcptOrdr () : ISO20022.Setr010001.SubscriptionOrderV04
        + Validation () = validation(validElement(SbcptOrdr))
    }
    class ISO20022.Setr010001.SubscriptionOrderV04 {
        # owner  : ISO20022.Setr010001.Document
        + Xtnsn  : List~ISO20022.Setr010001.Extension1~
        + CpyDtls  : ISO20022.Setr010001.CopyInformation4
        + MltplOrdrDtls  : ISO20022.Setr010001.SubscriptionMultipleOrder6
        + PrvsRef  : List~ISO20022.Setr010001.AdditionalReference8~
        + PoolRef  : ISO20022.Setr010001.AdditionalReference9
        + MsgId  : ISO20022.Setr010001.MessageIdentification1
        + Validation () = validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validElement(CpyDtls),validElement(MltplOrdrDtls),validList("""PrvsRef""",PrvsRef),validElement(PrvsRef),validElement(PoolRef),validElement(MsgId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Setr010001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SbcptOrdr|ISO20022.Setr010001.SubscriptionOrderV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SbcptOrdr))|

---

## AspectImpl ISO20022.Setr010001.SubscriptionOrderV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Setr010001.Document||||
|+|Xtnsn|List<ISO20022.Setr010001.Extension1>||XmlElement()||
|+|CpyDtls|ISO20022.Setr010001.CopyInformation4||XmlElement()||
|+|MltplOrdrDtls|ISO20022.Setr010001.SubscriptionMultipleOrder6||XmlElement()||
|+|PrvsRef|List<ISO20022.Setr010001.AdditionalReference8>||XmlElement()||
|+|PoolRef|ISO20022.Setr010001.AdditionalReference9||XmlElement()||
|+|MsgId|ISO20022.Setr010001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validElement(CpyDtls),validElement(MltplOrdrDtls),validList("""PrvsRef""",PrvsRef),validElement(PrvsRef),validElement(PoolRef),validElement(MsgId))|

