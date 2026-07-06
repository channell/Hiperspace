# reda.077.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda077001.Document {
        # Uri  : String
        + ClsLkDeltnReq () : ISO20022.Reda077001.CloseLinkDeletionRequestV01
        + Validation () = validation(validElement(ClsLkDeltnReq))
    }
    class ISO20022.Reda077001.CloseLinkDeletionRequestV01 {
        # owner  : ISO20022.Reda077001.Document
        + SplmtryData  : List~ISO20022.Reda077001.SupplementaryData1~
        + ClsLk  : List~ISO20022.Reda077001.CloseLink5~
        + MsgHdr  : ISO20022.Reda077001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""ClsLk""",ClsLk),validList("""ClsLk""",ClsLk),validElement(ClsLk),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda077001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ClsLkDeltnReq|ISO20022.Reda077001.CloseLinkDeletionRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClsLkDeltnReq))|

---

## AspectImpl ISO20022.Reda077001.CloseLinkDeletionRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda077001.Document||||
|+|SplmtryData|List<ISO20022.Reda077001.SupplementaryData1>||XmlElement()||
|+|ClsLk|List<ISO20022.Reda077001.CloseLink5>||XmlElement()||
|+|MsgHdr|ISO20022.Reda077001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""ClsLk""",ClsLk),validList("""ClsLk""",ClsLk),validElement(ClsLk),validElement(MsgHdr))|

