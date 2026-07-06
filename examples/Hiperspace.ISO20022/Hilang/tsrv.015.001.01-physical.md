# tsrv.015.001.01-physical
```mermaid
classDiagram
    class ISO20022.Tsrv015001.Document {
        # Uri  : String
        + XtndOrPayRspn () : ISO20022.Tsrv015001.ExtendOrPayResponseV01
        + Validation () = validation(validElement(XtndOrPayRspn))
    }
    class ISO20022.Tsrv015001.ExtendOrPayResponseV01 {
        # owner  : ISO20022.Tsrv015001.Document
        + DgtlSgntr  : ISO20022.Tsrv015001.PartyAndSignature2
        + XtndOrPayRspnDtls  : ISO20022.Tsrv015001.ExtendOrPayQuery2
        + Validation () = validation(validElement(DgtlSgntr),validElement(XtndOrPayRspnDtls))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsrv015001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|XtndOrPayRspn|ISO20022.Tsrv015001.ExtendOrPayResponseV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(XtndOrPayRspn))|

---

## AspectImpl ISO20022.Tsrv015001.ExtendOrPayResponseV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsrv015001.Document||||
|+|DgtlSgntr|ISO20022.Tsrv015001.PartyAndSignature2||XmlElement()||
|+|XtndOrPayRspnDtls|ISO20022.Tsrv015001.ExtendOrPayQuery2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgtlSgntr),validElement(XtndOrPayRspnDtls))|

