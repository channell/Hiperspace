# setr.006.001.05-physical
```mermaid
classDiagram
    class ISO20022.Setr006001.Document {
        # Uri  : String
        + RedOrdrConf () : ISO20022.Setr006001.RedemptionOrderConfirmationV05
        + Validation () = validation(validElement(RedOrdrConf))
    }
    class ISO20022.Setr006001.RedemptionOrderConfirmationV05 {
        # owner  : ISO20022.Setr006001.Document
        + Xtnsn  : List~ISO20022.Setr006001.Extension1~
        + CpyDtls  : ISO20022.Setr006001.CopyInformation5
        + MltplExctnDtls  : ISO20022.Setr006001.RedemptionMultipleExecution6
        + RltdRef  : ISO20022.Setr006001.AdditionalReference10
        + PrvsRef  : List~ISO20022.Setr006001.AdditionalReference10~
        + PoolRef  : ISO20022.Setr006001.AdditionalReference10
        + MsgId  : ISO20022.Setr006001.MessageIdentification1
        + Validation () = validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validElement(CpyDtls),validElement(MltplExctnDtls),validElement(RltdRef),validList("""PrvsRef""",PrvsRef),validElement(PrvsRef),validElement(PoolRef),validElement(MsgId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Setr006001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|RedOrdrConf|ISO20022.Setr006001.RedemptionOrderConfirmationV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RedOrdrConf))|

---

## AspectImpl ISO20022.Setr006001.RedemptionOrderConfirmationV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Setr006001.Document||||
|+|Xtnsn|List<ISO20022.Setr006001.Extension1>||XmlElement()||
|+|CpyDtls|ISO20022.Setr006001.CopyInformation5||XmlElement()||
|+|MltplExctnDtls|ISO20022.Setr006001.RedemptionMultipleExecution6||XmlElement()||
|+|RltdRef|ISO20022.Setr006001.AdditionalReference10||XmlElement()||
|+|PrvsRef|List<ISO20022.Setr006001.AdditionalReference10>||XmlElement()||
|+|PoolRef|ISO20022.Setr006001.AdditionalReference10||XmlElement()||
|+|MsgId|ISO20022.Setr006001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validElement(CpyDtls),validElement(MltplExctnDtls),validElement(RltdRef),validList("""PrvsRef""",PrvsRef),validElement(PrvsRef),validElement(PoolRef),validElement(MsgId))|

