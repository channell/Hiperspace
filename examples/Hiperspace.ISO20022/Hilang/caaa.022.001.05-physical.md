# caaa.022.001.05-physical
```mermaid
classDiagram
    class ISO20022.Caaa022001.Document {
        # Uri  : String
        + AccptrNonFinReq () : ISO20022.Caaa022001.AcceptorNonFinancialRequestV05
        + Validation () = validation(validElement(AccptrNonFinReq))
    }
    class ISO20022.Caaa022001.AcceptorNonFinancialRequestV05 {
        # owner  : ISO20022.Caaa022001.Document
        + SctyTrlr  : ISO20022.Caaa022001.ContentInformationType37
        + NonFinReq  : ISO20022.Caaa022001.NonFinancialRequestComponent5
        + Hdr  : ISO20022.Caaa022001.Header70
        + Validation () = validation(validElement(SctyTrlr),validElement(NonFinReq),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caaa022001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AccptrNonFinReq|ISO20022.Caaa022001.AcceptorNonFinancialRequestV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AccptrNonFinReq))|

---

## AspectImpl ISO20022.Caaa022001.AcceptorNonFinancialRequestV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caaa022001.Document||||
|+|SctyTrlr|ISO20022.Caaa022001.ContentInformationType37||XmlElement()||
|+|NonFinReq|ISO20022.Caaa022001.NonFinancialRequestComponent5||XmlElement()||
|+|Hdr|ISO20022.Caaa022001.Header70||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(NonFinReq),validElement(Hdr))|

