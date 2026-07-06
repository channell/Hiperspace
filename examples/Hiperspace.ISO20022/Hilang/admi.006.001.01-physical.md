# admi.006.001.01-physical
```mermaid
classDiagram
    class ISO20022.Admi006001.Document {
        # Uri  : String
        + RsndReq () : ISO20022.Admi006001.ResendRequestV01
        + Validation () = validation(validElement(RsndReq))
    }
    class ISO20022.Admi006001.ResendRequestV01 {
        # owner  : ISO20022.Admi006001.Document
        + SplmtryData  : List~ISO20022.Admi006001.SupplementaryData1~
        + RsndSchCrit  : List~ISO20022.Admi006001.ResendSearchCriteria2~
        + MsgHdr  : ISO20022.Admi006001.MessageHeader7
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""RsndSchCrit""",RsndSchCrit),validList("""RsndSchCrit""",RsndSchCrit),validElement(RsndSchCrit),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Admi006001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|RsndReq|ISO20022.Admi006001.ResendRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsndReq))|

---

## AspectImpl ISO20022.Admi006001.ResendRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Admi006001.Document||||
|+|SplmtryData|List<ISO20022.Admi006001.SupplementaryData1>||XmlElement()||
|+|RsndSchCrit|List<ISO20022.Admi006001.ResendSearchCriteria2>||XmlElement()||
|+|MsgHdr|ISO20022.Admi006001.MessageHeader7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""RsndSchCrit""",RsndSchCrit),validList("""RsndSchCrit""",RsndSchCrit),validElement(RsndSchCrit),validElement(MsgHdr))|

