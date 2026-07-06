# caam.002.001.04-physical
```mermaid
classDiagram
    class ISO20022.Caam002001.Document {
        # Uri  : String
        + ATMDvcCtrl () : ISO20022.Caam002001.ATMDeviceControlV04
        + Validation () = validation(validElement(ATMDvcCtrl))
    }
    class ISO20022.Caam002001.ATMDeviceControlV04 {
        # owner  : ISO20022.Caam002001.Document
        + SctyTrlr  : ISO20022.Caam002001.ContentInformationType13
        + ATMDvcCtrl  : ISO20022.Caam002001.ATMDeviceControl3
        + PrtctdATMDvcCtrl  : ISO20022.Caam002001.ContentInformationType10
        + Hdr  : ISO20022.Caam002001.Header31
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMDvcCtrl),validElement(PrtctdATMDvcCtrl),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caam002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMDvcCtrl|ISO20022.Caam002001.ATMDeviceControlV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMDvcCtrl))|

---

## AspectImpl ISO20022.Caam002001.ATMDeviceControlV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caam002001.Document||||
|+|SctyTrlr|ISO20022.Caam002001.ContentInformationType13||XmlElement()||
|+|ATMDvcCtrl|ISO20022.Caam002001.ATMDeviceControl3||XmlElement()||
|+|PrtctdATMDvcCtrl|ISO20022.Caam002001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Caam002001.Header31||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMDvcCtrl),validElement(PrtctdATMDvcCtrl),validElement(Hdr))|

