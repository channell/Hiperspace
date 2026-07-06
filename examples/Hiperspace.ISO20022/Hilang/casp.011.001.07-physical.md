# casp.011.001.07-physical
```mermaid
classDiagram
    class ISO20022.Casp011001.Document {
        # Uri  : String
        + SaleToPOIAbrt () : ISO20022.Casp011001.SaleToPOIAbortV07
        + Validation () = validation(validElement(SaleToPOIAbrt))
    }
    class ISO20022.Casp011001.SaleToPOIAbortV07 {
        # owner  : ISO20022.Casp011001.Document
        + SctyTrlr  : ISO20022.Casp011001.ContentInformationType38
        + Abrt  : ISO20022.Casp011001.SystemAbort8
        + Hdr  : ISO20022.Casp011001.Header41
        + Validation () = validation(validElement(SctyTrlr),validElement(Abrt),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Casp011001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SaleToPOIAbrt|ISO20022.Casp011001.SaleToPOIAbortV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SaleToPOIAbrt))|

---

## AspectImpl ISO20022.Casp011001.SaleToPOIAbortV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Casp011001.Document||||
|+|SctyTrlr|ISO20022.Casp011001.ContentInformationType38||XmlElement()||
|+|Abrt|ISO20022.Casp011001.SystemAbort8||XmlElement()||
|+|Hdr|ISO20022.Casp011001.Header41||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(Abrt),validElement(Hdr))|

