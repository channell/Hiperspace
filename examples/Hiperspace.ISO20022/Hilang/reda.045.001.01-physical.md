# reda.045.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda045001.Document {
        # Uri  : String
        + SctyCSDLkCreReq () : ISO20022.Reda045001.SecurityCSDLinkCreationRequestV01
        + Validation () = validation(validElement(SctyCSDLkCreReq))
    }
    class ISO20022.Reda045001.SecurityCSDLinkCreationRequestV01 {
        # owner  : ISO20022.Reda045001.Document
        + SplmtryData  : List~ISO20022.Reda045001.SupplementaryData1~
        + SctyCSDLk  : List~ISO20022.Reda045001.SecurityCSDLink12~
        + MsgHdr  : ISO20022.Reda045001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""SctyCSDLk""",SctyCSDLk),validList("""SctyCSDLk""",SctyCSDLk),validElement(SctyCSDLk),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda045001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SctyCSDLkCreReq|ISO20022.Reda045001.SecurityCSDLinkCreationRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyCSDLkCreReq))|

---

## AspectImpl ISO20022.Reda045001.SecurityCSDLinkCreationRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda045001.Document||||
|+|SplmtryData|List<ISO20022.Reda045001.SupplementaryData1>||XmlElement()||
|+|SctyCSDLk|List<ISO20022.Reda045001.SecurityCSDLink12>||XmlElement()||
|+|MsgHdr|ISO20022.Reda045001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""SctyCSDLk""",SctyCSDLk),validList("""SctyCSDLk""",SctyCSDLk),validElement(SctyCSDLk),validElement(MsgHdr))|

