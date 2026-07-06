# secl.009.001.03-physical
```mermaid
classDiagram
    class ISO20022.Secl009001.Document {
        # Uri  : String
        + BuyInConf () : ISO20022.Secl009001.BuyInConfirmationV03
        + Validation () = validation(validElement(BuyInConf))
    }
    class ISO20022.Secl009001.BuyInConfirmationV03 {
        # owner  : ISO20022.Secl009001.Document
        + SplmtryData  : List~ISO20022.Secl009001.SupplementaryData1~
        + OrgnlSttlmOblgtn  : ISO20022.Secl009001.SettlementObligation7
        + BuyInDtls  : ISO20022.Secl009001.BuyIn2
        + ClrMmb  : ISO20022.Secl009001.PartyIdentification35Choice
        + TxId  : String
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(OrgnlSttlmOblgtn),validElement(BuyInDtls),validElement(ClrMmb))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Secl009001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|BuyInConf|ISO20022.Secl009001.BuyInConfirmationV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BuyInConf))|

---

## AspectImpl ISO20022.Secl009001.BuyInConfirmationV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Secl009001.Document||||
|+|SplmtryData|List<ISO20022.Secl009001.SupplementaryData1>||XmlElement()||
|+|OrgnlSttlmOblgtn|ISO20022.Secl009001.SettlementObligation7||XmlElement()||
|+|BuyInDtls|ISO20022.Secl009001.BuyIn2||XmlElement()||
|+|ClrMmb|ISO20022.Secl009001.PartyIdentification35Choice||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(OrgnlSttlmOblgtn),validElement(BuyInDtls),validElement(ClrMmb))|

