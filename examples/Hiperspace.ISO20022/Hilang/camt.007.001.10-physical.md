# camt.007.001.10-physical
```mermaid
classDiagram
    class ISO20022.Camt007001.Document {
        # Uri  : String
        + ModfyTx () : ISO20022.Camt007001.ModifyTransactionV10
        + Validation () = validation(validElement(ModfyTx))
    }
    class ISO20022.Camt007001.ModifyTransactionV10 {
        # owner  : ISO20022.Camt007001.Document
        + SplmtryData  : List~ISO20022.Camt007001.SupplementaryData1~
        + Mod  : List~ISO20022.Camt007001.TransactionModification7~
        + MsgHdr  : ISO20022.Camt007001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Mod""",Mod),validList("""Mod""",Mod),validElement(Mod),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt007001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ModfyTx|ISO20022.Camt007001.ModifyTransactionV10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ModfyTx))|

---

## AspectImpl ISO20022.Camt007001.ModifyTransactionV10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt007001.Document||||
|+|SplmtryData|List<ISO20022.Camt007001.SupplementaryData1>||XmlElement()||
|+|Mod|List<ISO20022.Camt007001.TransactionModification7>||XmlElement()||
|+|MsgHdr|ISO20022.Camt007001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Mod""",Mod),validList("""Mod""",Mod),validElement(Mod),validElement(MsgHdr))|

