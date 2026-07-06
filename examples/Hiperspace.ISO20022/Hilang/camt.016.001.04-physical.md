# camt.016.001.04-physical
```mermaid
classDiagram
    class ISO20022.Camt016001.Document {
        # Uri  : String
        + GetCcyXchgRate () : ISO20022.Camt016001.GetCurrencyExchangeRateV04
        + Validation () = validation(validElement(GetCcyXchgRate))
    }
    class ISO20022.Camt016001.GetCurrencyExchangeRateV04 {
        # owner  : ISO20022.Camt016001.Document
        + SplmtryData  : List~ISO20022.Camt016001.SupplementaryData1~
        + CcyQryDef  : ISO20022.Camt016001.CurrencyQueryDefinition3
        + MsgHdr  : ISO20022.Camt016001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(CcyQryDef),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt016001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|GetCcyXchgRate|ISO20022.Camt016001.GetCurrencyExchangeRateV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GetCcyXchgRate))|

---

## AspectImpl ISO20022.Camt016001.GetCurrencyExchangeRateV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt016001.Document||||
|+|SplmtryData|List<ISO20022.Camt016001.SupplementaryData1>||XmlElement()||
|+|CcyQryDef|ISO20022.Camt016001.CurrencyQueryDefinition3||XmlElement()||
|+|MsgHdr|ISO20022.Camt016001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(CcyQryDef),validElement(MsgHdr))|

