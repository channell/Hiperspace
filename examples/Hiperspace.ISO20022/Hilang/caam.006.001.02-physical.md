# caam.006.001.02-physical
```mermaid
classDiagram
    class ISO20022.Caam006001.Document {
        # Uri  : String
        + ATMDgnstcRspn () : ISO20022.Caam006001.ATMDiagnosticResponseV02
        + Validation () = validation(validElement(ATMDgnstcRspn))
    }
    class ISO20022.Caam006001.ATMDiagnosticResponseV02 {
        # owner  : ISO20022.Caam006001.Document
        + SctyTrlr  : ISO20022.Caam006001.ContentInformationType15
        + ATMDgnstcRspn  : ISO20022.Caam006001.ATMDiagnosticResponse2
        + PrtctdATMDgnstcRspn  : ISO20022.Caam006001.ContentInformationType10
        + Hdr  : ISO20022.Caam006001.Header31
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMDgnstcRspn),validElement(PrtctdATMDgnstcRspn),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caam006001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMDgnstcRspn|ISO20022.Caam006001.ATMDiagnosticResponseV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMDgnstcRspn))|

---

## AspectImpl ISO20022.Caam006001.ATMDiagnosticResponseV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caam006001.Document||||
|+|SctyTrlr|ISO20022.Caam006001.ContentInformationType15||XmlElement()||
|+|ATMDgnstcRspn|ISO20022.Caam006001.ATMDiagnosticResponse2||XmlElement()||
|+|PrtctdATMDgnstcRspn|ISO20022.Caam006001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Caam006001.Header31||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMDgnstcRspn),validElement(PrtctdATMDgnstcRspn),validElement(Hdr))|

