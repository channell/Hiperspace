# setr.014.001.04-physical
```mermaid
classDiagram
    class ISO20022.Setr014001.Document {
        # Uri  : String
        + SwtchOrdrCxlReq () : ISO20022.Setr014001.SwitchOrderCancellationRequestV04
        + Validation () = validation(validElement(SwtchOrdrCxlReq))
    }
    class ISO20022.Setr014001.SwitchOrderCancellationRequestV04 {
        # owner  : ISO20022.Setr014001.Document
        + CpyDtls  : ISO20022.Setr014001.CopyInformation4
        + OrdrRefs  : List~ISO20022.Setr014001.InvestmentFundOrder9~
        + MstrRef  : String
        + PrvsRef  : ISO20022.Setr014001.AdditionalReference8
        + PoolRef  : ISO20022.Setr014001.AdditionalReference9
        + MsgId  : ISO20022.Setr014001.MessageIdentification1
        + Validation () = validation(validElement(CpyDtls),validRequired("""OrdrRefs""",OrdrRefs),validList("""OrdrRefs""",OrdrRefs),validElement(OrdrRefs),validElement(PrvsRef),validElement(PoolRef),validElement(MsgId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Setr014001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SwtchOrdrCxlReq|ISO20022.Setr014001.SwitchOrderCancellationRequestV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SwtchOrdrCxlReq))|

---

## AspectImpl ISO20022.Setr014001.SwitchOrderCancellationRequestV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Setr014001.Document||||
|+|CpyDtls|ISO20022.Setr014001.CopyInformation4||XmlElement()||
|+|OrdrRefs|List<ISO20022.Setr014001.InvestmentFundOrder9>||XmlElement()||
|+|MstrRef|String||XmlElement()||
|+|PrvsRef|ISO20022.Setr014001.AdditionalReference8||XmlElement()||
|+|PoolRef|ISO20022.Setr014001.AdditionalReference9||XmlElement()||
|+|MsgId|ISO20022.Setr014001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CpyDtls),validRequired("""OrdrRefs""",OrdrRefs),validList("""OrdrRefs""",OrdrRefs),validElement(OrdrRefs),validElement(PrvsRef),validElement(PoolRef),validElement(MsgId))|

