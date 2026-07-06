# seev.028.001.01-physical
```mermaid
classDiagram
    class ISO20022.Seev028001.Document {
        # Uri  : String
        + AgtCADeactvtnInstr () : ISO20022.Seev028001.AgentCADeactivationInstructionV01
        + Validation () = validation(validElement(AgtCADeactvtnInstr))
    }
    class ISO20022.Seev028001.AgentCADeactivationInstructionV01 {
        # owner  : ISO20022.Seev028001.Document
        + DeactvtnDtls  : ISO20022.Seev028001.CorporateActionDeactivationInstruction1
        + CorpActnGnlInf  : ISO20022.Seev028001.CorporateActionInformation1
        + Id  : ISO20022.Seev028001.DocumentIdentification8
        + Validation () = validation(validElement(DeactvtnDtls),validElement(CorpActnGnlInf),validElement(Id))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Seev028001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AgtCADeactvtnInstr|ISO20022.Seev028001.AgentCADeactivationInstructionV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AgtCADeactvtnInstr))|

---

## AspectImpl ISO20022.Seev028001.AgentCADeactivationInstructionV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Seev028001.Document||||
|+|DeactvtnDtls|ISO20022.Seev028001.CorporateActionDeactivationInstruction1||XmlElement()||
|+|CorpActnGnlInf|ISO20022.Seev028001.CorporateActionInformation1||XmlElement()||
|+|Id|ISO20022.Seev028001.DocumentIdentification8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DeactvtnDtls),validElement(CorpActnGnlInf),validElement(Id))|

