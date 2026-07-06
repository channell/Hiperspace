# secl.008.001.03-physical
```mermaid
classDiagram
    class ISO20022.Secl008001.Document {
        # Uri  : String
        + BuyInRspn () : ISO20022.Secl008001.BuyInResponseV03
        + Validation () = validation(validElement(BuyInRspn))
    }
    class ISO20022.Secl008001.BuyInResponseV03 {
        # owner  : ISO20022.Secl008001.Document
        + SplmtryData  : List~ISO20022.Secl008001.SupplementaryData1~
        + OrgnlSttlmOblgtnDtls  : ISO20022.Secl008001.SettlementObligation7
        + BuyInRspnDtls  : ISO20022.Secl008001.BuyIn3
        + TxId  : String
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(OrgnlSttlmOblgtnDtls),validElement(BuyInRspnDtls))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Secl008001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|BuyInRspn|ISO20022.Secl008001.BuyInResponseV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BuyInRspn))|

---

## AspectImpl ISO20022.Secl008001.BuyInResponseV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Secl008001.Document||||
|+|SplmtryData|List<ISO20022.Secl008001.SupplementaryData1>||XmlElement()||
|+|OrgnlSttlmOblgtnDtls|ISO20022.Secl008001.SettlementObligation7||XmlElement()||
|+|BuyInRspnDtls|ISO20022.Secl008001.BuyIn3||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(OrgnlSttlmOblgtnDtls),validElement(BuyInRspnDtls))|

