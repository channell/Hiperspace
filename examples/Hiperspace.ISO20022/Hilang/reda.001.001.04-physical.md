# reda.001.001.04-physical
```mermaid
classDiagram
    class ISO20022.Reda001001.Document {
        # Uri  : String
        + PricRpt () : ISO20022.Reda001001.PriceReportV04
        + Validation () = validation(validElement(PricRpt))
    }
    class ISO20022.Reda001001.PriceReportV04 {
        # owner  : ISO20022.Reda001001.Document
        + Xtnsn  : List~ISO20022.Reda001001.Extension1~
        + PricValtnDtls  : List~ISO20022.Reda001001.PriceValuation4~
        + CxlId  : String
        + Fctn  : String
        + PricRptId  : String
        + MsgPgntn  : ISO20022.Reda001001.Pagination
        + RltdRef  : ISO20022.Reda001001.AdditionalReference3
        + PrvsRef  : List~ISO20022.Reda001001.AdditionalReference3~
        + PoolRef  : ISO20022.Reda001001.AdditionalReference3
        + MsgId  : ISO20022.Reda001001.MessageIdentification1
        + Validation () = validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validRequired("""PricValtnDtls""",PricValtnDtls),validList("""PricValtnDtls""",PricValtnDtls),validElement(PricValtnDtls),validElement(MsgPgntn),validElement(RltdRef),validList("""PrvsRef""",PrvsRef),validElement(PrvsRef),validElement(PoolRef),validElement(MsgId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda001001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|PricRpt|ISO20022.Reda001001.PriceReportV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricRpt))|

---

## AspectImpl ISO20022.Reda001001.PriceReportV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda001001.Document||||
|+|Xtnsn|List<ISO20022.Reda001001.Extension1>||XmlElement()||
|+|PricValtnDtls|List<ISO20022.Reda001001.PriceValuation4>||XmlElement()||
|+|CxlId|String||XmlElement()||
|+|Fctn|String||XmlElement()||
|+|PricRptId|String||XmlElement()||
|+|MsgPgntn|ISO20022.Reda001001.Pagination||XmlElement()||
|+|RltdRef|ISO20022.Reda001001.AdditionalReference3||XmlElement()||
|+|PrvsRef|List<ISO20022.Reda001001.AdditionalReference3>||XmlElement()||
|+|PoolRef|ISO20022.Reda001001.AdditionalReference3||XmlElement()||
|+|MsgId|ISO20022.Reda001001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validRequired("""PricValtnDtls""",PricValtnDtls),validList("""PricValtnDtls""",PricValtnDtls),validElement(PricValtnDtls),validElement(MsgPgntn),validElement(RltdRef),validList("""PrvsRef""",PrvsRef),validElement(PrvsRef),validElement(PoolRef),validElement(MsgId))|

