# caam.013.001.01-physical
```mermaid
classDiagram
    class ISO20022.Caam013001.Document {
        # Uri  : String
        + ATMCfgtnRpt () : ISO20022.Caam013001.ATMConfigurationReportV01
        + Validation () = validation(validElement(ATMCfgtnRpt))
    }
    class ISO20022.Caam013001.ATMConfigurationReportV01 {
        # owner  : ISO20022.Caam013001.Document
        + SctyTrlr  : ISO20022.Caam013001.ContentInformationType15
        + ATMCfgtnRpt  : ISO20022.Caam013001.ATMConfigurationReportComponent1
        + PrtctdATMCfgtnRpt  : ISO20022.Caam013001.ContentInformationType10
        + Hdr  : ISO20022.Caam013001.Header31
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMCfgtnRpt),validElement(PrtctdATMCfgtnRpt),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caam013001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMCfgtnRpt|ISO20022.Caam013001.ATMConfigurationReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMCfgtnRpt))|

---

## AspectImpl ISO20022.Caam013001.ATMConfigurationReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caam013001.Document||||
|+|SctyTrlr|ISO20022.Caam013001.ContentInformationType15||XmlElement()||
|+|ATMCfgtnRpt|ISO20022.Caam013001.ATMConfigurationReportComponent1||XmlElement()||
|+|PrtctdATMCfgtnRpt|ISO20022.Caam013001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Caam013001.Header31||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMCfgtnRpt),validElement(PrtctdATMCfgtnRpt),validElement(Hdr))|

