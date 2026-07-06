# acmt.003.001.08-physical
```mermaid
classDiagram
    class ISO20022.Acmt003001.Document {
        # Uri  : String
        + AcctModInstr () : ISO20022.Acmt003001.AccountModificationInstructionV08
        + Validation () = validation(validElement(AcctModInstr))
    }
    class ISO20022.Acmt003001.AccountModificationInstructionV08 {
        # owner  : ISO20022.Acmt003001.Document
        + Xtnsn  : List~ISO20022.Acmt003001.Extension1~
        + MktPrctcVrsn  : ISO20022.Acmt003001.MarketPracticeVersion1
        + ModfdAddtlInf  : List~ISO20022.Acmt003001.ModificationScope45~
        + ModfdSvcLvlAgrmt  : List~ISO20022.Acmt003001.ModificationScope44~
        + ModfdCshSttlm  : List~ISO20022.Acmt003001.CashSettlement4~
        + ModfdWdrwlInvstmtPlan  : List~ISO20022.Acmt003001.ModificationScope41~
        + ModfdSvgsInvstmtPlan  : List~ISO20022.Acmt003001.ModificationScope41~
        + ModfdIsseAllcn  : ISO20022.Acmt003001.ModificationScope21
        + ModfdPlcmnt  : ISO20022.Acmt003001.ModificationScope43
        + ModfdIntrmies  : List~ISO20022.Acmt003001.ModificationScope40~
        + ModfdAcctPties  : List~ISO20022.Acmt003001.AccountParties18~
        + ModfdInvstmtAcct  : ISO20022.Acmt003001.InvestmentAccount75
        + InvstmtAcctSelctn  : ISO20022.Acmt003001.AccountSelection3Choice
        + InstrDtls  : ISO20022.Acmt003001.InvestmentAccountModification4
        + PrvsRef  : ISO20022.Acmt003001.AdditionalReference13
        + MsgId  : ISO20022.Acmt003001.MessageIdentification1
        + Validation () = validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validElement(MktPrctcVrsn),validList("""ModfdAddtlInf""",ModfdAddtlInf),validElement(ModfdAddtlInf),validList("""ModfdSvcLvlAgrmt""",ModfdSvcLvlAgrmt),validListMax("""ModfdSvcLvlAgrmt""",ModfdSvcLvlAgrmt,30),validElement(ModfdSvcLvlAgrmt),validList("""ModfdCshSttlm""",ModfdCshSttlm),validListMax("""ModfdCshSttlm""",ModfdCshSttlm,8),validElement(ModfdCshSttlm),validList("""ModfdWdrwlInvstmtPlan""",ModfdWdrwlInvstmtPlan),validListMax("""ModfdWdrwlInvstmtPlan""",ModfdWdrwlInvstmtPlan,10),validElement(ModfdWdrwlInvstmtPlan),validList("""ModfdSvgsInvstmtPlan""",ModfdSvgsInvstmtPlan),validListMax("""ModfdSvgsInvstmtPlan""",ModfdSvgsInvstmtPlan,50),validElement(ModfdSvgsInvstmtPlan),validElement(ModfdIsseAllcn),validElement(ModfdPlcmnt),validList("""ModfdIntrmies""",ModfdIntrmies),validElement(ModfdIntrmies),validList("""ModfdAcctPties""",ModfdAcctPties),validElement(ModfdAcctPties),validElement(ModfdInvstmtAcct),validElement(InvstmtAcctSelctn),validElement(InstrDtls),validElement(PrvsRef),validElement(MsgId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Acmt003001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AcctModInstr|ISO20022.Acmt003001.AccountModificationInstructionV08||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctModInstr))|

---

## AspectImpl ISO20022.Acmt003001.AccountModificationInstructionV08


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Acmt003001.Document||||
|+|Xtnsn|List<ISO20022.Acmt003001.Extension1>||XmlElement()||
|+|MktPrctcVrsn|ISO20022.Acmt003001.MarketPracticeVersion1||XmlElement()||
|+|ModfdAddtlInf|List<ISO20022.Acmt003001.ModificationScope45>||XmlElement()||
|+|ModfdSvcLvlAgrmt|List<ISO20022.Acmt003001.ModificationScope44>||XmlElement()||
|+|ModfdCshSttlm|List<ISO20022.Acmt003001.CashSettlement4>||XmlElement()||
|+|ModfdWdrwlInvstmtPlan|List<ISO20022.Acmt003001.ModificationScope41>||XmlElement()||
|+|ModfdSvgsInvstmtPlan|List<ISO20022.Acmt003001.ModificationScope41>||XmlElement()||
|+|ModfdIsseAllcn|ISO20022.Acmt003001.ModificationScope21||XmlElement()||
|+|ModfdPlcmnt|ISO20022.Acmt003001.ModificationScope43||XmlElement()||
|+|ModfdIntrmies|List<ISO20022.Acmt003001.ModificationScope40>||XmlElement()||
|+|ModfdAcctPties|List<ISO20022.Acmt003001.AccountParties18>||XmlElement()||
|+|ModfdInvstmtAcct|ISO20022.Acmt003001.InvestmentAccount75||XmlElement()||
|+|InvstmtAcctSelctn|ISO20022.Acmt003001.AccountSelection3Choice||XmlElement()||
|+|InstrDtls|ISO20022.Acmt003001.InvestmentAccountModification4||XmlElement()||
|+|PrvsRef|ISO20022.Acmt003001.AdditionalReference13||XmlElement()||
|+|MsgId|ISO20022.Acmt003001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validElement(MktPrctcVrsn),validList("""ModfdAddtlInf""",ModfdAddtlInf),validElement(ModfdAddtlInf),validList("""ModfdSvcLvlAgrmt""",ModfdSvcLvlAgrmt),validListMax("""ModfdSvcLvlAgrmt""",ModfdSvcLvlAgrmt,30),validElement(ModfdSvcLvlAgrmt),validList("""ModfdCshSttlm""",ModfdCshSttlm),validListMax("""ModfdCshSttlm""",ModfdCshSttlm,8),validElement(ModfdCshSttlm),validList("""ModfdWdrwlInvstmtPlan""",ModfdWdrwlInvstmtPlan),validListMax("""ModfdWdrwlInvstmtPlan""",ModfdWdrwlInvstmtPlan,10),validElement(ModfdWdrwlInvstmtPlan),validList("""ModfdSvgsInvstmtPlan""",ModfdSvgsInvstmtPlan),validListMax("""ModfdSvgsInvstmtPlan""",ModfdSvgsInvstmtPlan,50),validElement(ModfdSvgsInvstmtPlan),validElement(ModfdIsseAllcn),validElement(ModfdPlcmnt),validList("""ModfdIntrmies""",ModfdIntrmies),validElement(ModfdIntrmies),validList("""ModfdAcctPties""",ModfdAcctPties),validElement(ModfdAcctPties),validElement(ModfdInvstmtAcct),validElement(InvstmtAcctSelctn),validElement(InstrDtls),validElement(PrvsRef),validElement(MsgId))|

