# acmt.030.001.04
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Acmt030001.AccountIdentification4Choice {
        + Othr  : ISO20022.Acmt030001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Acmt030001.AccountIdentification4Choice *-- ISO20022.Acmt030001.GenericAccountIdentification1
    class ISO20022.Acmt030001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt030001.AccountSwitchDetails1 {
        + Rspn  : global::System.Collections.Generic.List~ISO20022.Acmt030001.ResponseDetails1~
        + BalTrfWndw  : String
        + SwtchSts  : String
        + SwtchTp  : String
        + SwtchDt  : DateTime
        + SwtchRcvdDtTm  : DateTime
        + RtgUnqRefNb  : String
        + UnqRefNb  : String
    }
    ISO20022.Acmt030001.AccountSwitchDetails1 *-- ISO20022.Acmt030001.ResponseDetails1
    class ISO20022.Acmt030001.AccountSwitchRequestRedirectionV04 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Acmt030001.SupplementaryData1~
        + OdAcct  : ISO20022.Acmt030001.CashAccount43
        + NewAcct  : ISO20022.Acmt030001.CashAccount43
        + AcctSwtchDtls  : ISO20022.Acmt030001.AccountSwitchDetails1
        + MsgId  : ISO20022.Acmt030001.MessageIdentification1
    }
    ISO20022.Acmt030001.AccountSwitchRequestRedirectionV04 *-- ISO20022.Acmt030001.SupplementaryData1
    ISO20022.Acmt030001.AccountSwitchRequestRedirectionV04 *-- ISO20022.Acmt030001.CashAccount43
    ISO20022.Acmt030001.AccountSwitchRequestRedirectionV04 *-- ISO20022.Acmt030001.CashAccount43
    ISO20022.Acmt030001.AccountSwitchRequestRedirectionV04 *-- ISO20022.Acmt030001.AccountSwitchDetails1
    ISO20022.Acmt030001.AccountSwitchRequestRedirectionV04 *-- ISO20022.Acmt030001.MessageIdentification1
    class ISO20022.Acmt030001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Acmt030001.AddressType3Choice {
        + Prtry  : ISO20022.Acmt030001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Acmt030001.AddressType3Choice *-- ISO20022.Acmt030001.GenericIdentification30
    class ISO20022.Acmt030001.BalanceTransferWindow1Code {
        EARL = 1
        DAYH = 2
    }
    class ISO20022.Acmt030001.BranchAndFinancialInstitutionIdentification8 {
        + BrnchId  : ISO20022.Acmt030001.BranchData5
        + FinInstnId  : ISO20022.Acmt030001.FinancialInstitutionIdentification23
    }
    ISO20022.Acmt030001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Acmt030001.BranchData5
    ISO20022.Acmt030001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Acmt030001.FinancialInstitutionIdentification23
    class ISO20022.Acmt030001.BranchData5 {
        + PstlAdr  : ISO20022.Acmt030001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Acmt030001.BranchData5 *-- ISO20022.Acmt030001.PostalAddress27
    class ISO20022.Acmt030001.CashAccount43 {
        + Svcr  : ISO20022.Acmt030001.BranchAndFinancialInstitutionIdentification8
        + Ownr  : ISO20022.Acmt030001.PartyIdentification272
        + Prxy  : ISO20022.Acmt030001.ProxyAccountIdentification1
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Acmt030001.CashAccountType2Choice
        + Id  : ISO20022.Acmt030001.AccountIdentification4Choice
    }
    ISO20022.Acmt030001.CashAccount43 *-- ISO20022.Acmt030001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Acmt030001.CashAccount43 *-- ISO20022.Acmt030001.PartyIdentification272
    ISO20022.Acmt030001.CashAccount43 *-- ISO20022.Acmt030001.ProxyAccountIdentification1
    ISO20022.Acmt030001.CashAccount43 *-- ISO20022.Acmt030001.CashAccountType2Choice
    ISO20022.Acmt030001.CashAccount43 *-- ISO20022.Acmt030001.AccountIdentification4Choice
    class ISO20022.Acmt030001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt030001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt030001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Acmt030001.ClearingSystemIdentification2Choice
    }
    ISO20022.Acmt030001.ClearingSystemMemberIdentification2 *-- ISO20022.Acmt030001.ClearingSystemIdentification2Choice
    class ISO20022.Acmt030001.Contact13 {
        + PrefrdMtd  : String
        + Othr  : global::System.Collections.Generic.List~ISO20022.Acmt030001.OtherContact1~
        + Dept  : String
        + Rspnsblty  : String
        + JobTitl  : String
        + EmailPurp  : String
        + EmailAdr  : String
        + URLAdr  : String
        + FaxNb  : String
        + MobNb  : String
        + PhneNb  : String
        + Nm  : String
        + NmPrfx  : String
    }
    ISO20022.Acmt030001.Contact13 *-- ISO20022.Acmt030001.OtherContact1
    class ISO20022.Acmt030001.DateAndPlaceOfBirth1 {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Acmt030001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt030001.FinancialInstitutionIdentification23 {
        + Othr  : ISO20022.Acmt030001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Acmt030001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Acmt030001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Acmt030001.FinancialInstitutionIdentification23 *-- ISO20022.Acmt030001.GenericFinancialIdentification1
    ISO20022.Acmt030001.FinancialInstitutionIdentification23 *-- ISO20022.Acmt030001.PostalAddress27
    ISO20022.Acmt030001.FinancialInstitutionIdentification23 *-- ISO20022.Acmt030001.ClearingSystemMemberIdentification2
    class ISO20022.Acmt030001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Acmt030001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Acmt030001.GenericAccountIdentification1 *-- ISO20022.Acmt030001.AccountSchemeName1Choice
    class ISO20022.Acmt030001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Acmt030001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Acmt030001.GenericFinancialIdentification1 *-- ISO20022.Acmt030001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Acmt030001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Acmt030001.GenericOrganisationIdentification3 {
        + Issr  : String
        + SchmeNm  : ISO20022.Acmt030001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Acmt030001.GenericOrganisationIdentification3 *-- ISO20022.Acmt030001.OrganisationIdentificationSchemeName1Choice
    class ISO20022.Acmt030001.GenericPersonIdentification2 {
        + Issr  : String
        + SchmeNm  : ISO20022.Acmt030001.PersonIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Acmt030001.GenericPersonIdentification2 *-- ISO20022.Acmt030001.PersonIdentificationSchemeName1Choice
    class ISO20022.Acmt030001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Acmt030001.NamePrefix2Code {
        MIKS = 1
        MIST = 2
        MISS = 3
        MADM = 4
        DOCT = 5
    }
    class ISO20022.Acmt030001.OrganisationIdentification39 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Acmt030001.GenericOrganisationIdentification3~
        + LEI  : String
        + AnyBIC  : String
    }
    ISO20022.Acmt030001.OrganisationIdentification39 *-- ISO20022.Acmt030001.GenericOrganisationIdentification3
    class ISO20022.Acmt030001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt030001.OtherContact1 {
        + Id  : String
        + ChanlTp  : String
    }
    class ISO20022.Acmt030001.Party52Choice {
        + PrvtId  : ISO20022.Acmt030001.PersonIdentification18
        + OrgId  : ISO20022.Acmt030001.OrganisationIdentification39
    }
    ISO20022.Acmt030001.Party52Choice *-- ISO20022.Acmt030001.PersonIdentification18
    ISO20022.Acmt030001.Party52Choice *-- ISO20022.Acmt030001.OrganisationIdentification39
    class ISO20022.Acmt030001.PartyIdentification272 {
        + CtctDtls  : ISO20022.Acmt030001.Contact13
        + CtryOfRes  : String
        + Id  : ISO20022.Acmt030001.Party52Choice
        + PstlAdr  : ISO20022.Acmt030001.PostalAddress27
        + Nm  : String
    }
    ISO20022.Acmt030001.PartyIdentification272 *-- ISO20022.Acmt030001.Contact13
    ISO20022.Acmt030001.PartyIdentification272 *-- ISO20022.Acmt030001.Party52Choice
    ISO20022.Acmt030001.PartyIdentification272 *-- ISO20022.Acmt030001.PostalAddress27
    class ISO20022.Acmt030001.PersonIdentification18 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Acmt030001.GenericPersonIdentification2~
        + DtAndPlcOfBirth  : ISO20022.Acmt030001.DateAndPlaceOfBirth1
    }
    ISO20022.Acmt030001.PersonIdentification18 *-- ISO20022.Acmt030001.GenericPersonIdentification2
    ISO20022.Acmt030001.PersonIdentification18 *-- ISO20022.Acmt030001.DateAndPlaceOfBirth1
    class ISO20022.Acmt030001.PersonIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt030001.PostalAddress27 {
        + AdrLine  : global::System.Collections.Generic.List~String~
        + Ctry  : String
        + CtrySubDvsn  : String
        + DstrctNm  : String
        + TwnLctnNm  : String
        + TwnNm  : String
        + PstCd  : String
        + Room  : String
        + PstBx  : String
        + UnitNb  : String
        + Flr  : String
        + BldgNm  : String
        + BldgNb  : String
        + StrtNm  : String
        + SubDept  : String
        + Dept  : String
        + CareOf  : String
        + AdrTp  : ISO20022.Acmt030001.AddressType3Choice
    }
    ISO20022.Acmt030001.PostalAddress27 *-- ISO20022.Acmt030001.AddressType3Choice
    class ISO20022.Acmt030001.PreferredContactMethod2Code {
        PHON = 1
        ONLI = 2
        CELL = 3
        LETT = 4
        FAXX = 5
        MAIL = 6
    }
    class ISO20022.Acmt030001.ProxyAccountIdentification1 {
        + Id  : String
        + Tp  : ISO20022.Acmt030001.ProxyAccountType1Choice
    }
    ISO20022.Acmt030001.ProxyAccountIdentification1 *-- ISO20022.Acmt030001.ProxyAccountType1Choice
    class ISO20022.Acmt030001.ProxyAccountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt030001.ResponseDetails1 {
        + AddtlDtls  : String
        + RspnCd  : String
    }
    class ISO20022.Acmt030001.SupplementaryData1 {
        + Envlp  : ISO20022.Acmt030001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Acmt030001.SupplementaryData1 *-- ISO20022.Acmt030001.SupplementaryDataEnvelope1
    class ISO20022.Acmt030001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Acmt030001.SwitchStatus1Code {
        TMTN = 1
        REQU = 2
        REJT = 3
        REDE = 4
        REDT = 5
        COMP = 6
        BTRS = 7
        BTRQ = 8
        ACPT = 9
    }
    class ISO20022.Acmt030001.SwitchType1Code {
        PART = 1
        FULL = 2
    }
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

## Value ISO20022.Acmt030001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Acmt030001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Acmt030001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt030001.AccountSwitchDetails1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rspn|global::System.Collections.Generic.List<ISO20022.Acmt030001.ResponseDetails1>||XmlElement()||
|+|BalTrfWndw|String||XmlElement()||
|+|SwtchSts|String||XmlElement()||
|+|SwtchTp|String||XmlElement()||
|+|SwtchDt|DateTime||XmlElement()||
|+|SwtchRcvdDtTm|DateTime||XmlElement()||
|+|RtgUnqRefNb|String||XmlElement()||
|+|UnqRefNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rspn""",Rspn),validElement(Rspn))|

---

## Aspect ISO20022.Acmt030001.AccountSwitchRequestRedirectionV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Acmt030001.SupplementaryData1>||XmlElement()||
|+|OdAcct|ISO20022.Acmt030001.CashAccount43||XmlElement()||
|+|NewAcct|ISO20022.Acmt030001.CashAccount43||XmlElement()||
|+|AcctSwtchDtls|ISO20022.Acmt030001.AccountSwitchDetails1||XmlElement()||
|+|MsgId|ISO20022.Acmt030001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(OdAcct),validElement(NewAcct),validElement(AcctSwtchDtls),validElement(MsgId))|

---

## Enum ISO20022.Acmt030001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Acmt030001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt030001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt030001.BalanceTransferWindow1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EARL|Int32||XmlEnum("""EARL""")|1|
||DAYH|Int32||XmlEnum("""DAYH""")|2|

---

## Value ISO20022.Acmt030001.BranchAndFinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Acmt030001.BranchData5||XmlElement()||
|+|FinInstnId|ISO20022.Acmt030001.FinancialInstitutionIdentification23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Acmt030001.BranchData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Acmt030001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Acmt030001.CashAccount43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Svcr|ISO20022.Acmt030001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|Ownr|ISO20022.Acmt030001.PartyIdentification272||XmlElement()||
|+|Prxy|ISO20022.Acmt030001.ProxyAccountIdentification1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Acmt030001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Acmt030001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Svcr),validElement(Ownr),validElement(Prxy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Acmt030001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt030001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt030001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Acmt030001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Value ISO20022.Acmt030001.Contact13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrefrdMtd|String||XmlElement()||
|+|Othr|global::System.Collections.Generic.List<ISO20022.Acmt030001.OtherContact1>||XmlElement()||
|+|Dept|String||XmlElement()||
|+|Rspnsblty|String||XmlElement()||
|+|JobTitl|String||XmlElement()||
|+|EmailPurp|String||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|URLAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|MobNb|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""MobNb""",MobNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""PhneNb""",PhneNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Value ISO20022.Acmt030001.DateAndPlaceOfBirth1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Type ISO20022.Acmt030001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctSwtchReqRdrctn|ISO20022.Acmt030001.AccountSwitchRequestRedirectionV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctSwtchReqRdrctn))|

---

## Value ISO20022.Acmt030001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt030001.FinancialInstitutionIdentification23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Acmt030001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Acmt030001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Acmt030001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Acmt030001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Acmt030001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Acmt030001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Acmt030001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Acmt030001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Acmt030001.GenericOrganisationIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Acmt030001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Acmt030001.GenericPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Acmt030001.PersonIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Acmt030001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Acmt030001.NamePrefix2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MIKS|Int32||XmlEnum("""MIKS""")|1|
||MIST|Int32||XmlEnum("""MIST""")|2|
||MISS|Int32||XmlEnum("""MISS""")|3|
||MADM|Int32||XmlEnum("""MADM""")|4|
||DOCT|Int32||XmlEnum("""DOCT""")|5|

---

## Value ISO20022.Acmt030001.OrganisationIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Acmt030001.GenericOrganisationIdentification3>||XmlElement()||
|+|LEI|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Acmt030001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt030001.OtherContact1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|ChanlTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt030001.Party52Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|ISO20022.Acmt030001.PersonIdentification18||XmlElement()||
|+|OrgId|ISO20022.Acmt030001.OrganisationIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvtId),validElement(OrgId),validChoice(PrvtId,OrgId))|

---

## Value ISO20022.Acmt030001.PartyIdentification272


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Acmt030001.Contact13||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Acmt030001.Party52Choice||XmlElement()||
|+|PstlAdr|ISO20022.Acmt030001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Value ISO20022.Acmt030001.PersonIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Acmt030001.GenericPersonIdentification2>||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Acmt030001.DateAndPlaceOfBirth1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(DtAndPlcOfBirth))|

---

## Value ISO20022.Acmt030001.PersonIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt030001.PostalAddress27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|DstrctNm|String||XmlElement()||
|+|TwnLctnNm|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|Room|String||XmlElement()||
|+|PstBx|String||XmlElement()||
|+|UnitNb|String||XmlElement()||
|+|Flr|String||XmlElement()||
|+|BldgNm|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|SubDept|String||XmlElement()||
|+|Dept|String||XmlElement()||
|+|CareOf|String||XmlElement()||
|+|AdrTp|ISO20022.Acmt030001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Enum ISO20022.Acmt030001.PreferredContactMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHON|Int32||XmlEnum("""PHON""")|1|
||ONLI|Int32||XmlEnum("""ONLI""")|2|
||CELL|Int32||XmlEnum("""CELL""")|3|
||LETT|Int32||XmlEnum("""LETT""")|4|
||FAXX|Int32||XmlEnum("""FAXX""")|5|
||MAIL|Int32||XmlEnum("""MAIL""")|6|

---

## Value ISO20022.Acmt030001.ProxyAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Acmt030001.ProxyAccountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Acmt030001.ProxyAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt030001.ResponseDetails1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlDtls|String||XmlElement()||
|+|RspnCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt030001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Acmt030001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Acmt030001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Acmt030001.SwitchStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TMTN|Int32||XmlEnum("""TMTN""")|1|
||REQU|Int32||XmlEnum("""REQU""")|2|
||REJT|Int32||XmlEnum("""REJT""")|3|
||REDE|Int32||XmlEnum("""REDE""")|4|
||REDT|Int32||XmlEnum("""REDT""")|5|
||COMP|Int32||XmlEnum("""COMP""")|6|
||BTRS|Int32||XmlEnum("""BTRS""")|7|
||BTRQ|Int32||XmlEnum("""BTRQ""")|8|
||ACPT|Int32||XmlEnum("""ACPT""")|9|

---

## Enum ISO20022.Acmt030001.SwitchType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PART|Int32||XmlEnum("""PART""")|1|
||FULL|Int32||XmlEnum("""FULL""")|2|

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

