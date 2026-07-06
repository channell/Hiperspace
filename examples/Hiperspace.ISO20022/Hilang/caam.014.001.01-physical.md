# caam.014.001.01-physical
```mermaid
classDiagram
    class ISO20022.Caam014001.Document {
        # Uri  : String
        + ATMCfgtnCtrl () : ISO20022.Caam014001.ATMConfigurationControlV01
        + Validation () = validation(validElement(ATMCfgtnCtrl))
    }
    class ISO20022.Caam014001.ATMConfigurationControlV01 {
        # owner  : ISO20022.Caam014001.Document
        + SctyTrlr  : ISO20022.Caam014001.ContentInformationType15
        + ATMCfgtnCtrl  : ISO20022.Caam014001.ATMConfigurationControlComponent1
        + PrtctdATMCfgtnCtrl  : ISO20022.Caam014001.ContentInformationType10
        + Hdr  : ISO20022.Caam014001.Header31
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMCfgtnCtrl),validElement(PrtctdATMCfgtnCtrl),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caam014001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMCfgtnCtrl|ISO20022.Caam014001.ATMConfigurationControlV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMCfgtnCtrl))|

---

## AspectImpl ISO20022.Caam014001.ATMConfigurationControlV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caam014001.Document||||
|+|SctyTrlr|ISO20022.Caam014001.ContentInformationType15||XmlElement()||
|+|ATMCfgtnCtrl|ISO20022.Caam014001.ATMConfigurationControlComponent1||XmlElement()||
|+|PrtctdATMCfgtnCtrl|ISO20022.Caam014001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Caam014001.Header31||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMCfgtnCtrl),validElement(PrtctdATMCfgtnCtrl),validElement(Hdr))|

