# sese.025.001.12-physical
```mermaid
classDiagram
    class ISO20022.Sese025001.Document {
        # Uri  : String
        + SctiesSttlmTxConf  : ISO20022.Sese025001.SecuritiesSettlementTransactionConfirmationV12
        + Validation () = validation(validElement(SctiesSttlmTxConf))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Sese025001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SctiesSttlmTxConf|ISO20022.Sese025001.SecuritiesSettlementTransactionConfirmationV12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesSttlmTxConf))|

