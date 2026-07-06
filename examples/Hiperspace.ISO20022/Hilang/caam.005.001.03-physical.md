# caam.005.001.03-physical
```mermaid
classDiagram
    class ISO20022.Caam005001.Document {
        # Uri  : String
        + ATMDgnstcReq () : ISO20022.Caam005001.ATMDiagnosticRequestV03
        + Validation () = validation(validElement(ATMDgnstcReq))
    }
    class ISO20022.Caam005001.ATMDiagnosticRequestV03 {
        # owner  : ISO20022.Caam005001.Document
        + SctyTrlr  : ISO20022.Caam005001.ContentInformationType15
        + ATMDgnstcReq  : ISO20022.Caam005001.ATMDiagnosticRequest3
        + PrtctdATMDgnstcReq  : ISO20022.Caam005001.ContentInformationType10
        + Hdr  : ISO20022.Caam005001.Header31
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMDgnstcReq),validElement(PrtctdATMDgnstcReq),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caam005001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMDgnstcReq|ISO20022.Caam005001.ATMDiagnosticRequestV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMDgnstcReq))|

---

## AspectImpl ISO20022.Caam005001.ATMDiagnosticRequestV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caam005001.Document||||
|+|SctyTrlr|ISO20022.Caam005001.ContentInformationType15||XmlElement()||
|+|ATMDgnstcReq|ISO20022.Caam005001.ATMDiagnosticRequest3||XmlElement()||
|+|PrtctdATMDgnstcReq|ISO20022.Caam005001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Caam005001.Header31||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMDgnstcReq),validElement(PrtctdATMDgnstcReq),validElement(Hdr))|

