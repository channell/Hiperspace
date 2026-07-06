# tsmt.055.001.01-physical
```mermaid
classDiagram
    class ISO20022.Tsmt055001.Document {
        # Uri  : String
        + PtyEvtAdvc () : ISO20022.Tsmt055001.PartyEventAdviceV01
        + Validation () = validation(validElement(PtyEvtAdvc))
    }
    class ISO20022.Tsmt055001.PartyEventAdviceV01 {
        # owner  : ISO20022.Tsmt055001.Document
        + AttchdMsg  : List~ISO20022.Tsmt055001.EncapsulatedBusinessMessage1~
        + EvtCnt  : String
        + EvtNtce  : List~ISO20022.Tsmt055001.EventDescription1~
        + Hdr  : ISO20022.Tsmt055001.BusinessLetter1
        + Validation () = validation(validList("""AttchdMsg""",AttchdMsg),validElement(AttchdMsg),validPattern("""EvtCnt""",EvtCnt,"""[0-9]{1,15}"""),validRequired("""EvtNtce""",EvtNtce),validList("""EvtNtce""",EvtNtce),validElement(EvtNtce),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsmt055001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|PtyEvtAdvc|ISO20022.Tsmt055001.PartyEventAdviceV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyEvtAdvc))|

---

## AspectImpl ISO20022.Tsmt055001.PartyEventAdviceV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsmt055001.Document||||
|+|AttchdMsg|List<ISO20022.Tsmt055001.EncapsulatedBusinessMessage1>||XmlElement()||
|+|EvtCnt|String||XmlElement()||
|+|EvtNtce|List<ISO20022.Tsmt055001.EventDescription1>||XmlElement()||
|+|Hdr|ISO20022.Tsmt055001.BusinessLetter1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AttchdMsg""",AttchdMsg),validElement(AttchdMsg),validPattern("""EvtCnt""",EvtCnt,"""[0-9]{1,15}"""),validRequired("""EvtNtce""",EvtNtce),validList("""EvtNtce""",EvtNtce),validElement(EvtNtce),validElement(Hdr))|

