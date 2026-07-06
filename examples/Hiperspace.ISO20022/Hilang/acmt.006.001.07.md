# acmt.006.001.07
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Acmt006001.AcceptedStatusReason1Choice {
        + Prtry  : ISO20022.Acmt006001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Acmt006001.AcceptedStatusReason1Choice *-- ISO20022.Acmt006001.GenericIdentification36
    class ISO20022.Acmt006001.AcceptedStatusReason1Code {
        SECT = 1
        PLAC = 2
    }
    class ISO20022.Acmt006001.Account23 {
        + RltdAcctDtls  : ISO20022.Acmt006001.GenericIdentification1
        + AcctId  : String
    }
    ISO20022.Acmt006001.Account23 *-- ISO20022.Acmt006001.GenericIdentification1
    class ISO20022.Acmt006001.AccountManagementStatus1Code {
        STNP = 1
        EXEC = 2
        ACCP = 3
        RECE = 4
    }
    class ISO20022.Acmt006001.AccountManagementStatusAndReason5 {
        + CRSRptgDt  : DateTime
        + FATCARptgDt  : DateTime
        + BlckdSts  : ISO20022.Acmt006001.BlockedStatusReason2Choice
        + AcctSts  : ISO20022.Acmt006001.AccountStatus2
        + AcctId  : String
        + ExstgAcctId  : global::System.Collections.Generic.List~ISO20022.Acmt006001.Account23~
        + AcctApplId  : String
        + StsRsn  : global::System.Collections.Generic.List~ISO20022.Acmt006001.AcceptedStatusReason1Choice~
        + Sts  : ISO20022.Acmt006001.Status25Choice
    }
    ISO20022.Acmt006001.AccountManagementStatusAndReason5 *-- ISO20022.Acmt006001.BlockedStatusReason2Choice
    ISO20022.Acmt006001.AccountManagementStatusAndReason5 *-- ISO20022.Acmt006001.AccountStatus2
    ISO20022.Acmt006001.AccountManagementStatusAndReason5 *-- ISO20022.Acmt006001.Account23
    ISO20022.Acmt006001.AccountManagementStatusAndReason5 *-- ISO20022.Acmt006001.AcceptedStatusReason1Choice
    ISO20022.Acmt006001.AccountManagementStatusAndReason5 *-- ISO20022.Acmt006001.Status25Choice
    class ISO20022.Acmt006001.AccountManagementStatusReportV07 {
        + Xtnsn  : global::System.Collections.Generic.List~ISO20022.Acmt006001.Extension1~
        + MktPrctcVrsn  : ISO20022.Acmt006001.MarketPracticeVersion1
        + StsRpt  : ISO20022.Acmt006001.AccountManagementStatusAndReason5
        + RltdRef  : global::System.Collections.Generic.List~ISO20022.Acmt006001.AdditionalReference13~
        + MsgId  : ISO20022.Acmt006001.MessageIdentification1
    }
    ISO20022.Acmt006001.AccountManagementStatusReportV07 *-- ISO20022.Acmt006001.Extension1
    ISO20022.Acmt006001.AccountManagementStatusReportV07 *-- ISO20022.Acmt006001.MarketPracticeVersion1
    ISO20022.Acmt006001.AccountManagementStatusReportV07 *-- ISO20022.Acmt006001.AccountManagementStatusAndReason5
    ISO20022.Acmt006001.AccountManagementStatusReportV07 *-- ISO20022.Acmt006001.AdditionalReference13
    ISO20022.Acmt006001.AccountManagementStatusReportV07 *-- ISO20022.Acmt006001.MessageIdentification1
    class ISO20022.Acmt006001.AccountStatus2 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Acmt006001.OtherAccountStatus1~
        + ClsrPdg  : ISO20022.Acmt006001.ClosurePendingStatusReason1Choice
        + Clsd  : ISO20022.Acmt006001.ClosedStatusReason1Choice
        + Profrm  : ISO20022.Acmt006001.ProformaStatusReason1Choice
        + PdgOpng  : ISO20022.Acmt006001.PendingOpeningStatusReason1Choice
        + Pdg  : ISO20022.Acmt006001.PendingStatusReason1Choice
        + Dsbld  : ISO20022.Acmt006001.DisabledStatusReason1Choice
        + Nbld  : ISO20022.Acmt006001.EnabledStatusReason1Choice
    }
    ISO20022.Acmt006001.AccountStatus2 *-- ISO20022.Acmt006001.OtherAccountStatus1
    ISO20022.Acmt006001.AccountStatus2 *-- ISO20022.Acmt006001.ClosurePendingStatusReason1Choice
    ISO20022.Acmt006001.AccountStatus2 *-- ISO20022.Acmt006001.ClosedStatusReason1Choice
    ISO20022.Acmt006001.AccountStatus2 *-- ISO20022.Acmt006001.ProformaStatusReason1Choice
    ISO20022.Acmt006001.AccountStatus2 *-- ISO20022.Acmt006001.PendingOpeningStatusReason1Choice
    ISO20022.Acmt006001.AccountStatus2 *-- ISO20022.Acmt006001.PendingStatusReason1Choice
    ISO20022.Acmt006001.AccountStatus2 *-- ISO20022.Acmt006001.DisabledStatusReason1Choice
    ISO20022.Acmt006001.AccountStatus2 *-- ISO20022.Acmt006001.EnabledStatusReason1Choice
    class ISO20022.Acmt006001.AdditionalReference13 {
        + MsgNm  : String
        + RefIssr  : ISO20022.Acmt006001.PartyIdentification125Choice
        + Ref  : String
    }
    ISO20022.Acmt006001.AdditionalReference13 *-- ISO20022.Acmt006001.PartyIdentification125Choice
    class ISO20022.Acmt006001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Acmt006001.BlockedReason2Choice {
        + Prtry  : ISO20022.Acmt006001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt006001.BlockedReason2Choice *-- ISO20022.Acmt006001.GenericIdentification47
    class ISO20022.Acmt006001.BlockedReason2Code {
        TRAN = 1
        SANC = 2
        TRPE = 3
        PLDG = 4
        PCOM = 5
        MORT = 6
        CNFS = 7
        CMMT = 8
        BKRP = 9
    }
    class ISO20022.Acmt006001.BlockedStatusReason2 {
        + AddtlInf  : String
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Acmt006001.BlockedReason2Choice~
        + Blckd  : String
        + TxTp  : ISO20022.Acmt006001.TransactionType5Choice
    }
    ISO20022.Acmt006001.BlockedStatusReason2 *-- ISO20022.Acmt006001.BlockedReason2Choice
    ISO20022.Acmt006001.BlockedStatusReason2 *-- ISO20022.Acmt006001.TransactionType5Choice
    class ISO20022.Acmt006001.BlockedStatusReason2Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Acmt006001.BlockedStatusReason2~
        + NoSpcfdRsn  : String
    }
    ISO20022.Acmt006001.BlockedStatusReason2Choice *-- ISO20022.Acmt006001.BlockedStatusReason2
    class ISO20022.Acmt006001.ClosedStatusReason1 {
        + AddtlInf  : String
        + Cd  : ISO20022.Acmt006001.ClosedStatusReason2Choice
    }
    ISO20022.Acmt006001.ClosedStatusReason1 *-- ISO20022.Acmt006001.ClosedStatusReason2Choice
    class ISO20022.Acmt006001.ClosedStatusReason1Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Acmt006001.ClosedStatusReason1~
        + NoSpcfdRsn  : String
    }
    ISO20022.Acmt006001.ClosedStatusReason1Choice *-- ISO20022.Acmt006001.ClosedStatusReason1
    class ISO20022.Acmt006001.ClosedStatusReason1Code {
        CLIN = 1
        ASIN = 2
    }
    class ISO20022.Acmt006001.ClosedStatusReason2Choice {
        + Prtry  : ISO20022.Acmt006001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Acmt006001.ClosedStatusReason2Choice *-- ISO20022.Acmt006001.GenericIdentification36
    class ISO20022.Acmt006001.ClosurePendingStatusReason1 {
        + AddtlInf  : String
        + Cd  : ISO20022.Acmt006001.ClosurePendingStatusReason2Choice
    }
    ISO20022.Acmt006001.ClosurePendingStatusReason1 *-- ISO20022.Acmt006001.ClosurePendingStatusReason2Choice
    class ISO20022.Acmt006001.ClosurePendingStatusReason1Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Acmt006001.ClosurePendingStatusReason1~
        + NoSpcfdRsn  : String
    }
    ISO20022.Acmt006001.ClosurePendingStatusReason1Choice *-- ISO20022.Acmt006001.ClosurePendingStatusReason1
    class ISO20022.Acmt006001.ClosurePendingStatusReason1Code {
        PEND = 1
        CLOS = 2
    }
    class ISO20022.Acmt006001.ClosurePendingStatusReason2Choice {
        + Prtry  : ISO20022.Acmt006001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Acmt006001.ClosurePendingStatusReason2Choice *-- ISO20022.Acmt006001.GenericIdentification36
    class ISO20022.Acmt006001.DisabledReason2Code {
        REJT = 1
        TRAN = 2
        SANC = 3
        TRPE = 4
        PLDG = 5
        PCOM = 6
        MORT = 7
        CNFS = 8
        CMMT = 9
        BKRP = 10
        CLOS = 11
    }
    class ISO20022.Acmt006001.DisabledStatusReason1 {
        + AddtlInf  : String
        + Cd  : ISO20022.Acmt006001.DisabledStatusReason2Choice
    }
    ISO20022.Acmt006001.DisabledStatusReason1 *-- ISO20022.Acmt006001.DisabledStatusReason2Choice
    class ISO20022.Acmt006001.DisabledStatusReason1Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Acmt006001.DisabledStatusReason1~
        + NoSpcfdRsn  : String
    }
    ISO20022.Acmt006001.DisabledStatusReason1Choice *-- ISO20022.Acmt006001.DisabledStatusReason1
    class ISO20022.Acmt006001.DisabledStatusReason2Choice {
        + Prtry  : ISO20022.Acmt006001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Acmt006001.DisabledStatusReason2Choice *-- ISO20022.Acmt006001.GenericIdentification36
    class ISO20022.Acmt006001.EnabledStatusReason1 {
        + AddtlInf  : String
        + Cd  : ISO20022.Acmt006001.EnabledStatusReason2Choice
    }
    ISO20022.Acmt006001.EnabledStatusReason1 *-- ISO20022.Acmt006001.EnabledStatusReason2Choice
    class ISO20022.Acmt006001.EnabledStatusReason1Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Acmt006001.EnabledStatusReason1~
        + NoSpcfdRsn  : String
    }
    ISO20022.Acmt006001.EnabledStatusReason1Choice *-- ISO20022.Acmt006001.EnabledStatusReason1
    class ISO20022.Acmt006001.EnabledStatusReason1Code {
        MODI = 1
    }
    class ISO20022.Acmt006001.EnabledStatusReason2Choice {
        + Prtry  : ISO20022.Acmt006001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Acmt006001.EnabledStatusReason2Choice *-- ISO20022.Acmt006001.GenericIdentification36
    class ISO20022.Acmt006001.Extension1 {
        + Txt  : String
        + PlcAndNm  : String
    }
    class ISO20022.Acmt006001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Acmt006001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Acmt006001.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Acmt006001.InvestmentFundTransactionType1Code {
        SUAA = 1
        SSPL = 2
        RDIV = 3
        RWPL = 4
        REAA = 5
        OTHR = 6
        INSP = 7
        DIVI = 8
        CROO = 9
        CROI = 10
        CAEV = 11
        DIVP = 12
        CWIT = 13
        CDEP = 14
        REDM = 15
        SUBS = 16
        TOUT = 17
        TRIN = 18
        SWIO = 19
        BUYI = 20
        SELL = 21
        ALLL = 22
    }
    class ISO20022.Acmt006001.MarketPracticeVersion1 {
        + Nb  : String
        + Dt  : String
        + Nm  : String
    }
    class ISO20022.Acmt006001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Acmt006001.NameAndAddress5 {
        + Adr  : ISO20022.Acmt006001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Acmt006001.NameAndAddress5 *-- ISO20022.Acmt006001.PostalAddress1
    class ISO20022.Acmt006001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Acmt006001.OtherAccountStatus1 {
        + Rsn  : ISO20022.Acmt006001.GenericIdentification36
        + Sts  : ISO20022.Acmt006001.GenericIdentification36
    }
    ISO20022.Acmt006001.OtherAccountStatus1 *-- ISO20022.Acmt006001.GenericIdentification36
    ISO20022.Acmt006001.OtherAccountStatus1 *-- ISO20022.Acmt006001.GenericIdentification36
    class ISO20022.Acmt006001.PartyIdentification125Choice {
        + NmAndAdr  : ISO20022.Acmt006001.NameAndAddress5
        + PrtryId  : ISO20022.Acmt006001.GenericIdentification1
        + AnyBIC  : String
    }
    ISO20022.Acmt006001.PartyIdentification125Choice *-- ISO20022.Acmt006001.NameAndAddress5
    ISO20022.Acmt006001.PartyIdentification125Choice *-- ISO20022.Acmt006001.GenericIdentification1
    class ISO20022.Acmt006001.PendingOpeningStatusReason1 {
        + AddtlInf  : String
        + Cd  : ISO20022.Acmt006001.PendingOpeningStatusReason2Choice
    }
    ISO20022.Acmt006001.PendingOpeningStatusReason1 *-- ISO20022.Acmt006001.PendingOpeningStatusReason2Choice
    class ISO20022.Acmt006001.PendingOpeningStatusReason1Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Acmt006001.PendingOpeningStatusReason1~
        + NoSpcfdRsn  : String
    }
    ISO20022.Acmt006001.PendingOpeningStatusReason1Choice *-- ISO20022.Acmt006001.PendingOpeningStatusReason1
    class ISO20022.Acmt006001.PendingOpeningStatusReason1Code {
        RIGH = 1
        REST = 2
        NOTO = 3
        KYCM = 4
        FRDM = 5
        ATHP = 6
        ATHR = 7
    }
    class ISO20022.Acmt006001.PendingOpeningStatusReason2Choice {
        + Prtry  : ISO20022.Acmt006001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Acmt006001.PendingOpeningStatusReason2Choice *-- ISO20022.Acmt006001.GenericIdentification36
    class ISO20022.Acmt006001.PendingStatusReason14 {
        + AddtlInf  : String
        + Cd  : ISO20022.Acmt006001.PendingStatusReason2Choice
    }
    ISO20022.Acmt006001.PendingStatusReason14 *-- ISO20022.Acmt006001.PendingStatusReason2Choice
    class ISO20022.Acmt006001.PendingStatusReason1Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Acmt006001.PendingStatusReason14~
        + NoSpcfdRsn  : String
    }
    ISO20022.Acmt006001.PendingStatusReason1Choice *-- ISO20022.Acmt006001.PendingStatusReason14
    class ISO20022.Acmt006001.PendingStatusReason1Code {
        MODI = 1
        ATHP = 2
        ATHR = 3
        RIGH = 4
        FRDM = 5
        KYCM = 6
    }
    class ISO20022.Acmt006001.PendingStatusReason2Choice {
        + Prtry  : ISO20022.Acmt006001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Acmt006001.PendingStatusReason2Choice *-- ISO20022.Acmt006001.GenericIdentification36
    class ISO20022.Acmt006001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Acmt006001.ProformaStatusReason1 {
        + AddtlInf  : String
        + Cd  : ISO20022.Acmt006001.ProformaStatusReason2Choice
    }
    ISO20022.Acmt006001.ProformaStatusReason1 *-- ISO20022.Acmt006001.ProformaStatusReason2Choice
    class ISO20022.Acmt006001.ProformaStatusReason1Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Acmt006001.ProformaStatusReason1~
        + NoSpcfdRsn  : String
    }
    ISO20022.Acmt006001.ProformaStatusReason1Choice *-- ISO20022.Acmt006001.ProformaStatusReason1
    class ISO20022.Acmt006001.ProformaStatusReason1Code {
        RIGH = 1
        MODI = 2
    }
    class ISO20022.Acmt006001.ProformaStatusReason2Choice {
        + Prtry  : ISO20022.Acmt006001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Acmt006001.ProformaStatusReason2Choice *-- ISO20022.Acmt006001.GenericIdentification36
    class ISO20022.Acmt006001.RejectedReason16Choice {
        + Prtry  : ISO20022.Acmt006001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Acmt006001.RejectedReason16Choice *-- ISO20022.Acmt006001.GenericIdentification36
    class ISO20022.Acmt006001.RejectedStatusReason6Code {
        NSLA = 1
        SAFE = 2
    }
    class ISO20022.Acmt006001.RejectionReason31 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Acmt006001.RejectedReason16Choice
    }
    ISO20022.Acmt006001.RejectionReason31 *-- ISO20022.Acmt006001.RejectedReason16Choice
    class ISO20022.Acmt006001.Status25Choice {
        + Rjctd  : global::System.Collections.Generic.List~ISO20022.Acmt006001.RejectionReason31~
        + Sts  : String
    }
    ISO20022.Acmt006001.Status25Choice *-- ISO20022.Acmt006001.RejectionReason31
    class ISO20022.Acmt006001.TransactionType5Choice {
        + Prtry  : ISO20022.Acmt006001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt006001.TransactionType5Choice *-- ISO20022.Acmt006001.GenericIdentification47
    class Hiperspace.Node {
        # SKey  : String
        + TypeName  : String
        + Name  : String
        + Froms (From = this) : Hiperspace.Edge
        + Tos (To = this) : Hiperspace.Edge
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## View Hiperspace.Edge
edge between nodes

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Hiperspace.Node||||
|#|To|Hiperspace.Node||||
|#|TypeName|String||||
|+|Name|String||||

---

## Value ISO20022.Acmt006001.AcceptedStatusReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt006001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt006001.AcceptedStatusReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SECT|Int32||XmlEnum("""SECT""")|1|
||PLAC|Int32||XmlEnum("""PLAC""")|2|

---

## Value ISO20022.Acmt006001.Account23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltdAcctDtls|ISO20022.Acmt006001.GenericIdentification1||XmlElement()||
|+|AcctId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RltdAcctDtls))|

---

## Enum ISO20022.Acmt006001.AccountManagementStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||STNP|Int32||XmlEnum("""STNP""")|1|
||EXEC|Int32||XmlEnum("""EXEC""")|2|
||ACCP|Int32||XmlEnum("""ACCP""")|3|
||RECE|Int32||XmlEnum("""RECE""")|4|

---

## Value ISO20022.Acmt006001.AccountManagementStatusAndReason5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CRSRptgDt|DateTime||XmlElement()||
|+|FATCARptgDt|DateTime||XmlElement()||
|+|BlckdSts|ISO20022.Acmt006001.BlockedStatusReason2Choice||XmlElement()||
|+|AcctSts|ISO20022.Acmt006001.AccountStatus2||XmlElement()||
|+|AcctId|String||XmlElement()||
|+|ExstgAcctId|global::System.Collections.Generic.List<ISO20022.Acmt006001.Account23>||XmlElement()||
|+|AcctApplId|String||XmlElement()||
|+|StsRsn|global::System.Collections.Generic.List<ISO20022.Acmt006001.AcceptedStatusReason1Choice>||XmlElement()||
|+|Sts|ISO20022.Acmt006001.Status25Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BlckdSts),validElement(AcctSts),validList("""ExstgAcctId""",ExstgAcctId),validElement(ExstgAcctId),validList("""StsRsn""",StsRsn),validElement(StsRsn),validElement(Sts))|

---

## Aspect ISO20022.Acmt006001.AccountManagementStatusReportV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Xtnsn|global::System.Collections.Generic.List<ISO20022.Acmt006001.Extension1>||XmlElement()||
|+|MktPrctcVrsn|ISO20022.Acmt006001.MarketPracticeVersion1||XmlElement()||
|+|StsRpt|ISO20022.Acmt006001.AccountManagementStatusAndReason5||XmlElement()||
|+|RltdRef|global::System.Collections.Generic.List<ISO20022.Acmt006001.AdditionalReference13>||XmlElement()||
|+|MsgId|ISO20022.Acmt006001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validElement(MktPrctcVrsn),validElement(StsRpt),validRequired("""RltdRef""",RltdRef),validList("""RltdRef""",RltdRef),validListMax("""RltdRef""",RltdRef,2),validElement(RltdRef),validElement(MsgId))|

---

## Value ISO20022.Acmt006001.AccountStatus2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Acmt006001.OtherAccountStatus1>||XmlElement()||
|+|ClsrPdg|ISO20022.Acmt006001.ClosurePendingStatusReason1Choice||XmlElement()||
|+|Clsd|ISO20022.Acmt006001.ClosedStatusReason1Choice||XmlElement()||
|+|Profrm|ISO20022.Acmt006001.ProformaStatusReason1Choice||XmlElement()||
|+|PdgOpng|ISO20022.Acmt006001.PendingOpeningStatusReason1Choice||XmlElement()||
|+|Pdg|ISO20022.Acmt006001.PendingStatusReason1Choice||XmlElement()||
|+|Dsbld|ISO20022.Acmt006001.DisabledStatusReason1Choice||XmlElement()||
|+|Nbld|ISO20022.Acmt006001.EnabledStatusReason1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(ClsrPdg),validElement(Clsd),validElement(Profrm),validElement(PdgOpng),validElement(Pdg),validElement(Dsbld),validElement(Nbld))|

---

## Value ISO20022.Acmt006001.AdditionalReference13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|ISO20022.Acmt006001.PartyIdentification125Choice||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefIssr))|

---

## Enum ISO20022.Acmt006001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Acmt006001.BlockedReason2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt006001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt006001.BlockedReason2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRAN|Int32||XmlEnum("""TRAN""")|1|
||SANC|Int32||XmlEnum("""SANC""")|2|
||TRPE|Int32||XmlEnum("""TRPE""")|3|
||PLDG|Int32||XmlEnum("""PLDG""")|4|
||PCOM|Int32||XmlEnum("""PCOM""")|5|
||MORT|Int32||XmlEnum("""MORT""")|6|
||CNFS|Int32||XmlEnum("""CNFS""")|7|
||CMMT|Int32||XmlEnum("""CMMT""")|8|
||BKRP|Int32||XmlEnum("""BKRP""")|9|

---

## Value ISO20022.Acmt006001.BlockedStatusReason2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Acmt006001.BlockedReason2Choice>||XmlElement()||
|+|Blckd|String||XmlElement()||
|+|TxTp|ISO20022.Acmt006001.TransactionType5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rsn""",Rsn),validElement(Rsn),validElement(TxTp))|

---

## Value ISO20022.Acmt006001.BlockedStatusReason2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Acmt006001.BlockedStatusReason2>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Acmt006001.ClosedStatusReason1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Cd|ISO20022.Acmt006001.ClosedStatusReason2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Acmt006001.ClosedStatusReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Acmt006001.ClosedStatusReason1>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Acmt006001.ClosedStatusReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CLIN|Int32||XmlEnum("""CLIN""")|1|
||ASIN|Int32||XmlEnum("""ASIN""")|2|

---

## Value ISO20022.Acmt006001.ClosedStatusReason2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt006001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt006001.ClosurePendingStatusReason1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Cd|ISO20022.Acmt006001.ClosurePendingStatusReason2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Acmt006001.ClosurePendingStatusReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Acmt006001.ClosurePendingStatusReason1>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Acmt006001.ClosurePendingStatusReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PEND|Int32||XmlEnum("""PEND""")|1|
||CLOS|Int32||XmlEnum("""CLOS""")|2|

---

## Value ISO20022.Acmt006001.ClosurePendingStatusReason2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt006001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt006001.DisabledReason2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REJT|Int32||XmlEnum("""REJT""")|1|
||TRAN|Int32||XmlEnum("""TRAN""")|2|
||SANC|Int32||XmlEnum("""SANC""")|3|
||TRPE|Int32||XmlEnum("""TRPE""")|4|
||PLDG|Int32||XmlEnum("""PLDG""")|5|
||PCOM|Int32||XmlEnum("""PCOM""")|6|
||MORT|Int32||XmlEnum("""MORT""")|7|
||CNFS|Int32||XmlEnum("""CNFS""")|8|
||CMMT|Int32||XmlEnum("""CMMT""")|9|
||BKRP|Int32||XmlEnum("""BKRP""")|10|
||CLOS|Int32||XmlEnum("""CLOS""")|11|

---

## Value ISO20022.Acmt006001.DisabledStatusReason1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Cd|ISO20022.Acmt006001.DisabledStatusReason2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Acmt006001.DisabledStatusReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Acmt006001.DisabledStatusReason1>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Acmt006001.DisabledStatusReason2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt006001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Type ISO20022.Acmt006001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctMgmtStsRpt|ISO20022.Acmt006001.AccountManagementStatusReportV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctMgmtStsRpt))|

---

## Value ISO20022.Acmt006001.EnabledStatusReason1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Cd|ISO20022.Acmt006001.EnabledStatusReason2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Acmt006001.EnabledStatusReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Acmt006001.EnabledStatusReason1>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Acmt006001.EnabledStatusReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MODI|Int32||XmlEnum("""MODI""")|1|

---

## Value ISO20022.Acmt006001.EnabledStatusReason2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt006001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt006001.Extension1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txt|String||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt006001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt006001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt006001.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Enum ISO20022.Acmt006001.InvestmentFundTransactionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SUAA|Int32||XmlEnum("""SUAA""")|1|
||SSPL|Int32||XmlEnum("""SSPL""")|2|
||RDIV|Int32||XmlEnum("""RDIV""")|3|
||RWPL|Int32||XmlEnum("""RWPL""")|4|
||REAA|Int32||XmlEnum("""REAA""")|5|
||OTHR|Int32||XmlEnum("""OTHR""")|6|
||INSP|Int32||XmlEnum("""INSP""")|7|
||DIVI|Int32||XmlEnum("""DIVI""")|8|
||CROO|Int32||XmlEnum("""CROO""")|9|
||CROI|Int32||XmlEnum("""CROI""")|10|
||CAEV|Int32||XmlEnum("""CAEV""")|11|
||DIVP|Int32||XmlEnum("""DIVP""")|12|
||CWIT|Int32||XmlEnum("""CWIT""")|13|
||CDEP|Int32||XmlEnum("""CDEP""")|14|
||REDM|Int32||XmlEnum("""REDM""")|15|
||SUBS|Int32||XmlEnum("""SUBS""")|16|
||TOUT|Int32||XmlEnum("""TOUT""")|17|
||TRIN|Int32||XmlEnum("""TRIN""")|18|
||SWIO|Int32||XmlEnum("""SWIO""")|19|
||BUYI|Int32||XmlEnum("""BUYI""")|20|
||SELL|Int32||XmlEnum("""SELL""")|21|
||ALLL|Int32||XmlEnum("""ALLL""")|22|

---

## Value ISO20022.Acmt006001.MarketPracticeVersion1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nb|String||XmlElement()||
|+|Dt|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt006001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt006001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Acmt006001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Acmt006001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Acmt006001.OtherAccountStatus1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|ISO20022.Acmt006001.GenericIdentification36||XmlElement()||
|+|Sts|ISO20022.Acmt006001.GenericIdentification36||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn),validElement(Sts))|

---

## Value ISO20022.Acmt006001.PartyIdentification125Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Acmt006001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Acmt006001.GenericIdentification1||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Acmt006001.PendingOpeningStatusReason1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Cd|ISO20022.Acmt006001.PendingOpeningStatusReason2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Acmt006001.PendingOpeningStatusReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Acmt006001.PendingOpeningStatusReason1>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Acmt006001.PendingOpeningStatusReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RIGH|Int32||XmlEnum("""RIGH""")|1|
||REST|Int32||XmlEnum("""REST""")|2|
||NOTO|Int32||XmlEnum("""NOTO""")|3|
||KYCM|Int32||XmlEnum("""KYCM""")|4|
||FRDM|Int32||XmlEnum("""FRDM""")|5|
||ATHP|Int32||XmlEnum("""ATHP""")|6|
||ATHR|Int32||XmlEnum("""ATHR""")|7|

---

## Value ISO20022.Acmt006001.PendingOpeningStatusReason2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt006001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt006001.PendingStatusReason14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Cd|ISO20022.Acmt006001.PendingStatusReason2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Acmt006001.PendingStatusReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Acmt006001.PendingStatusReason14>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Acmt006001.PendingStatusReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MODI|Int32||XmlEnum("""MODI""")|1|
||ATHP|Int32||XmlEnum("""ATHP""")|2|
||ATHR|Int32||XmlEnum("""ATHR""")|3|
||RIGH|Int32||XmlEnum("""RIGH""")|4|
||FRDM|Int32||XmlEnum("""FRDM""")|5|
||KYCM|Int32||XmlEnum("""KYCM""")|6|

---

## Value ISO20022.Acmt006001.PendingStatusReason2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt006001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt006001.PostalAddress1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AdrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validListMax("""AdrLine""",AdrLine,5))|

---

## Value ISO20022.Acmt006001.ProformaStatusReason1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Cd|ISO20022.Acmt006001.ProformaStatusReason2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Acmt006001.ProformaStatusReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Acmt006001.ProformaStatusReason1>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Acmt006001.ProformaStatusReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RIGH|Int32||XmlEnum("""RIGH""")|1|
||MODI|Int32||XmlEnum("""MODI""")|2|

---

## Value ISO20022.Acmt006001.ProformaStatusReason2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt006001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt006001.RejectedReason16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt006001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt006001.RejectedStatusReason6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NSLA|Int32||XmlEnum("""NSLA""")|1|
||SAFE|Int32||XmlEnum("""SAFE""")|2|

---

## Value ISO20022.Acmt006001.RejectionReason31


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Acmt006001.RejectedReason16Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Value ISO20022.Acmt006001.Status25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rjctd|global::System.Collections.Generic.List<ISO20022.Acmt006001.RejectionReason31>||XmlElement()||
|+|Sts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rjctd""",Rjctd),validList("""Rjctd""",Rjctd),validListMax("""Rjctd""",Rjctd,10),validElement(Rjctd),validChoice(Rjctd,Sts))|

---

## Value ISO20022.Acmt006001.TransactionType5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt006001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## View Hiperspace.Node
node in a graph view of data

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|SKey|String||||
|+|TypeName|String||||
|+|Name|String||||
||Froms|Hiperspace.Edge|||From = this|
||Tos|Hiperspace.Edge|||To = this|

