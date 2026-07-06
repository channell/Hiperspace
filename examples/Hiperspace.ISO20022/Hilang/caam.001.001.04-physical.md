# caam.001.001.04-physical
```mermaid
classDiagram
    class ISO20022.Caam001001.Document {
        # Uri  : String
        + ATMDvcRpt () : ISO20022.Caam001001.ATMDeviceReportV04
        + Validation () = validation(validElement(ATMDvcRpt))
    }
    class ISO20022.Caam001001.ATMDeviceReportV04 {
        # owner  : ISO20022.Caam001001.Document
        + SctyTrlr  : ISO20022.Caam001001.ContentInformationType13
        + ATMDvcRpt  : ISO20022.Caam001001.ATMDeviceReport4
        + PrtctdATMDvcRpt  : ISO20022.Caam001001.ContentInformationType10
        + Hdr  : ISO20022.Caam001001.Header31
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMDvcRpt),validElement(PrtctdATMDvcRpt),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caam001001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMDvcRpt|ISO20022.Caam001001.ATMDeviceReportV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMDvcRpt))|

---

## AspectImpl ISO20022.Caam001001.ATMDeviceReportV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caam001001.Document||||
|+|SctyTrlr|ISO20022.Caam001001.ContentInformationType13||XmlElement()||
|+|ATMDvcRpt|ISO20022.Caam001001.ATMDeviceReport4||XmlElement()||
|+|PrtctdATMDvcRpt|ISO20022.Caam001001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Caam001001.Header31||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMDvcRpt),validElement(PrtctdATMDvcRpt),validElement(Hdr))|

