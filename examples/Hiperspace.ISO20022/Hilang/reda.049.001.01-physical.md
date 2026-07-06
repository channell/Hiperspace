# reda.049.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda049001.Document {
        # Uri  : String
        + AcctLkCreReq () : ISO20022.Reda049001.AccountLinkCreationRequestV01
        + Validation () = validation(validElement(AcctLkCreReq))
    }
    class ISO20022.Reda049001.AccountLinkCreationRequestV01 {
        # owner  : ISO20022.Reda049001.Document
        + SplmtryData  : List~ISO20022.Reda049001.SupplementaryData1~
        + AcctLk  : List~ISO20022.Reda049001.AccountLink7~
        + MsgHdr  : ISO20022.Reda049001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""AcctLk""",AcctLk),validList("""AcctLk""",AcctLk),validElement(AcctLk),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda049001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AcctLkCreReq|ISO20022.Reda049001.AccountLinkCreationRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctLkCreReq))|

---

## AspectImpl ISO20022.Reda049001.AccountLinkCreationRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda049001.Document||||
|+|SplmtryData|List<ISO20022.Reda049001.SupplementaryData1>||XmlElement()||
|+|AcctLk|List<ISO20022.Reda049001.AccountLink7>||XmlElement()||
|+|MsgHdr|ISO20022.Reda049001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""AcctLk""",AcctLk),validList("""AcctLk""",AcctLk),validElement(AcctLk),validElement(MsgHdr))|

