# seev.047.001.03
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Seev047001.AccountOwnershipType5Code {
        BOWN = 1
        OWNR = 2
        USUF = 3
    }
    class ISO20022.Seev047001.AccountSubLevel24 {
        + Dsclsr  : global::System.Collections.Generic.List~ISO20022.Seev047001.AccountSubLevel25~
        + BlwThrshldShrhldgQty  : ISO20022.Seev047001.FinancialInstrumentQuantity18Choice
        + NonDscldShrhldgQty  : ISO20022.Seev047001.FinancialInstrumentQuantity18Choice
    }
    ISO20022.Seev047001.AccountSubLevel24 *-- ISO20022.Seev047001.AccountSubLevel25
    ISO20022.Seev047001.AccountSubLevel24 *-- ISO20022.Seev047001.FinancialInstrumentQuantity18Choice
    ISO20022.Seev047001.AccountSubLevel24 *-- ISO20022.Seev047001.FinancialInstrumentQuantity18Choice
    class ISO20022.Seev047001.AccountSubLevel25 {
        + ShrhldgBal  : global::System.Collections.Generic.List~ISO20022.Seev047001.ShareholdingBalance1~
        + AcctHldr  : ISO20022.Seev047001.PartyIdentification276
        + SfkpgAcct  : String
    }
    ISO20022.Seev047001.AccountSubLevel25 *-- ISO20022.Seev047001.ShareholdingBalance1
    ISO20022.Seev047001.AccountSubLevel25 *-- ISO20022.Seev047001.PartyIdentification276
    class ISO20022.Seev047001.ActivityIndicator1Choice {
        + PrtryInd  : ISO20022.Seev047001.GenericIdentification36
        + ISICIdr  : String
    }
    ISO20022.Seev047001.ActivityIndicator1Choice *-- ISO20022.Seev047001.GenericIdentification36
    class ISO20022.Seev047001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Seev047001.ContactIdentification2 {
        + EmailAdr  : String
        + FaxNb  : String
        + MobNb  : String
        + PhneNb  : String
        + Nm  : String
        + GvnNm  : String
        + NmPrfx  : String
    }
    class ISO20022.Seev047001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Seev047001.DateAndPlaceOfBirth2 {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Seev047001.DateCode20Choice {
        + Prtry  : ISO20022.Seev047001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev047001.DateCode20Choice *-- ISO20022.Seev047001.GenericIdentification30
    class ISO20022.Seev047001.DateFormat46Choice {
        + DtCd  : ISO20022.Seev047001.DateCode20Choice
        + Dt  : ISO20022.Seev047001.DateAndDateTime2Choice
    }
    ISO20022.Seev047001.DateFormat46Choice *-- ISO20022.Seev047001.DateCode20Choice
    ISO20022.Seev047001.DateFormat46Choice *-- ISO20022.Seev047001.DateAndDateTime2Choice
    class ISO20022.Seev047001.DateFormat57Choice {
        + DtCd  : ISO20022.Seev047001.DateCode20Choice
        + Dt  : DateTime
    }
    ISO20022.Seev047001.DateFormat57Choice *-- ISO20022.Seev047001.DateCode20Choice
    class ISO20022.Seev047001.DateType1Code {
        UKWN = 1
    }
    class ISO20022.Seev047001.Disclosure3Choice {
        + SfkpgAcctAndHldgs  : global::System.Collections.Generic.List~ISO20022.Seev047001.SafekeepingAccount17~
        + NoDsclsr  : String
    }
    ISO20022.Seev047001.Disclosure3Choice *-- ISO20022.Seev047001.SafekeepingAccount17
    class ISO20022.Seev047001.DisclosureRequestIdentification1 {
        + ShrhldrsDsclsrRcrdDt  : ISO20022.Seev047001.DateFormat46Choice
        + FinInstrmId  : ISO20022.Seev047001.SecurityIdentification19
        + IssrDsclsrReqId  : String
    }
    ISO20022.Seev047001.DisclosureRequestIdentification1 *-- ISO20022.Seev047001.DateFormat46Choice
    ISO20022.Seev047001.DisclosureRequestIdentification1 *-- ISO20022.Seev047001.SecurityIdentification19
    class ISO20022.Seev047001.Eligibility1Code {
        PROF = 1
        RETL = 2
        ELIG = 3
    }
    class ISO20022.Seev047001.FinancialInstrumentQuantity18Choice {
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev047001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev047001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev047001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Seev047001.IdentificationType45Choice {
        + Prtry  : ISO20022.Seev047001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev047001.IdentificationType45Choice *-- ISO20022.Seev047001.GenericIdentification30
    class ISO20022.Seev047001.InvestorType1Choice {
        + Prtry  : ISO20022.Seev047001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev047001.InvestorType1Choice *-- ISO20022.Seev047001.GenericIdentification30
    class ISO20022.Seev047001.NameAndAddress17 {
        + Adr  : ISO20022.Seev047001.PostalAddress26
        + Nm  : String
    }
    ISO20022.Seev047001.NameAndAddress17 *-- ISO20022.Seev047001.PostalAddress26
    class ISO20022.Seev047001.NamePrefix1Code {
        MADM = 1
        MISS = 2
        MIST = 3
        DOCT = 4
    }
    class ISO20022.Seev047001.NamePrefix2Code {
        MIKS = 1
        MIST = 2
        MISS = 3
        MADM = 4
        DOCT = 5
    }
    class ISO20022.Seev047001.NaturalPersonIdentification1 {
        + IdTp  : ISO20022.Seev047001.IdentificationType45Choice
        + Id  : String
    }
    ISO20022.Seev047001.NaturalPersonIdentification1 *-- ISO20022.Seev047001.IdentificationType45Choice
    class ISO20022.Seev047001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Seev047001.OtherIdentification1 {
        + Tp  : ISO20022.Seev047001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Seev047001.OtherIdentification1 *-- ISO20022.Seev047001.IdentificationSource3Choice
    class ISO20022.Seev047001.Ownership1 {
        + UsfrctPctg  : Decimal
        + OwnrshPctg  : Decimal
        + OwnrshTp  : ISO20022.Seev047001.OwnershipType3Choice
    }
    ISO20022.Seev047001.Ownership1 *-- ISO20022.Seev047001.OwnershipType3Choice
    class ISO20022.Seev047001.OwnershipType3Choice {
        + Prtry  : ISO20022.Seev047001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev047001.OwnershipType3Choice *-- ISO20022.Seev047001.GenericIdentification30
    class ISO20022.Seev047001.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Seev047001.PartyIdentification195Choice {
        + LEI  : String
        + PrtryId  : ISO20022.Seev047001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Seev047001.PartyIdentification195Choice *-- ISO20022.Seev047001.GenericIdentification36
    class ISO20022.Seev047001.PartyIdentification198Choice {
        + PrtryId  : ISO20022.Seev047001.GenericIdentification36
        + ClntId  : String
        + AnyBIC  : String
        + LEI  : String
        + NtlRegnNb  : String
    }
    ISO20022.Seev047001.PartyIdentification198Choice *-- ISO20022.Seev047001.GenericIdentification36
    class ISO20022.Seev047001.PartyIdentification201 {
        + Id  : ISO20022.Seev047001.PartyIdentification198Choice
        + NmAndAdr  : ISO20022.Seev047001.PersonName2
    }
    ISO20022.Seev047001.PartyIdentification201 *-- ISO20022.Seev047001.PartyIdentification198Choice
    ISO20022.Seev047001.PartyIdentification201 *-- ISO20022.Seev047001.PersonName2
    class ISO20022.Seev047001.PartyIdentification202 {
        + Id  : ISO20022.Seev047001.NaturalPersonIdentification1
        + NmAndAdr  : ISO20022.Seev047001.PersonName1
    }
    ISO20022.Seev047001.PartyIdentification202 *-- ISO20022.Seev047001.NaturalPersonIdentification1
    ISO20022.Seev047001.PartyIdentification202 *-- ISO20022.Seev047001.PersonName1
    class ISO20022.Seev047001.PartyIdentification205Choice {
        + NtrlPrsn  : ISO20022.Seev047001.PartyIdentification202
        + LglPrsn  : ISO20022.Seev047001.PartyIdentification201
    }
    ISO20022.Seev047001.PartyIdentification205Choice *-- ISO20022.Seev047001.PartyIdentification202
    ISO20022.Seev047001.PartyIdentification205Choice *-- ISO20022.Seev047001.PartyIdentification201
    class ISO20022.Seev047001.PartyIdentification217 {
        + Ownrsh  : ISO20022.Seev047001.Ownership1
        + InvstrTp  : ISO20022.Seev047001.InvestorType1Choice
        + DtAndPlcOfBirth  : ISO20022.Seev047001.DateAndPlaceOfBirth2
        + Ntlty  : String
        + Id  : ISO20022.Seev047001.NaturalPersonIdentification1
        + EmailAdr  : String
        + NmAndAdr  : ISO20022.Seev047001.PersonName3
    }
    ISO20022.Seev047001.PartyIdentification217 *-- ISO20022.Seev047001.Ownership1
    ISO20022.Seev047001.PartyIdentification217 *-- ISO20022.Seev047001.InvestorType1Choice
    ISO20022.Seev047001.PartyIdentification217 *-- ISO20022.Seev047001.DateAndPlaceOfBirth2
    ISO20022.Seev047001.PartyIdentification217 *-- ISO20022.Seev047001.NaturalPersonIdentification1
    ISO20022.Seev047001.PartyIdentification217 *-- ISO20022.Seev047001.PersonName3
    class ISO20022.Seev047001.PartyIdentification218 {
        + Id  : ISO20022.Seev047001.PartyIdentification205Choice
        + Role  : ISO20022.Seev047001.PartyRole6Choice
    }
    ISO20022.Seev047001.PartyIdentification218 *-- ISO20022.Seev047001.PartyIdentification205Choice
    ISO20022.Seev047001.PartyIdentification218 *-- ISO20022.Seev047001.PartyRole6Choice
    class ISO20022.Seev047001.PartyIdentification219 {
        + CtctPrsn  : ISO20022.Seev047001.ContactIdentification2
        + Id  : ISO20022.Seev047001.PartyIdentification195Choice
        + NmAndAdr  : ISO20022.Seev047001.PersonName2
    }
    ISO20022.Seev047001.PartyIdentification219 *-- ISO20022.Seev047001.ContactIdentification2
    ISO20022.Seev047001.PartyIdentification219 *-- ISO20022.Seev047001.PartyIdentification195Choice
    ISO20022.Seev047001.PartyIdentification219 *-- ISO20022.Seev047001.PersonName2
    class ISO20022.Seev047001.PartyIdentification275 {
        + Ownrsh  : ISO20022.Seev047001.Ownership1
        + InvstrTp  : ISO20022.Seev047001.InvestorType1Choice
        + ActvtyInd  : ISO20022.Seev047001.ActivityIndicator1Choice
        + YrOfIncorprtn  : Int32
        + CtryOfIncorprtn  : String
        + Id  : ISO20022.Seev047001.PartyIdentification198Choice
        + EmailAdr  : String
        + NmAndAdr  : ISO20022.Seev047001.NameAndAddress17
    }
    ISO20022.Seev047001.PartyIdentification275 *-- ISO20022.Seev047001.Ownership1
    ISO20022.Seev047001.PartyIdentification275 *-- ISO20022.Seev047001.InvestorType1Choice
    ISO20022.Seev047001.PartyIdentification275 *-- ISO20022.Seev047001.ActivityIndicator1Choice
    ISO20022.Seev047001.PartyIdentification275 *-- ISO20022.Seev047001.PartyIdentification198Choice
    ISO20022.Seev047001.PartyIdentification275 *-- ISO20022.Seev047001.NameAndAddress17
    class ISO20022.Seev047001.PartyIdentification276 {
        + NtrlPrsn  : global::System.Collections.Generic.List~ISO20022.Seev047001.PartyIdentification217~
        + LglPrsn  : global::System.Collections.Generic.List~ISO20022.Seev047001.PartyIdentification275~
    }
    ISO20022.Seev047001.PartyIdentification276 *-- ISO20022.Seev047001.PartyIdentification217
    ISO20022.Seev047001.PartyIdentification276 *-- ISO20022.Seev047001.PartyIdentification275
    class ISO20022.Seev047001.PartyRole2Code {
        DECM = 1
        LGRD = 2
        DIST = 3
    }
    class ISO20022.Seev047001.PartyRole6Choice {
        + Prtry  : ISO20022.Seev047001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev047001.PartyRole6Choice *-- ISO20022.Seev047001.GenericIdentification30
    class ISO20022.Seev047001.PersonName1 {
        + Adr  : ISO20022.Seev047001.PostalAddress26
        + Srnm  : String
        + FrstNm  : String
    }
    ISO20022.Seev047001.PersonName1 *-- ISO20022.Seev047001.PostalAddress26
    class ISO20022.Seev047001.PersonName2 {
        + Adr  : ISO20022.Seev047001.PostalAddress26
        + Nm  : String
    }
    ISO20022.Seev047001.PersonName2 *-- ISO20022.Seev047001.PostalAddress26
    class ISO20022.Seev047001.PersonName3 {
        + Adr  : ISO20022.Seev047001.PostalAddress26
        + Srnm  : String
        + FrstNm  : String
        + NmPrfx  : String
    }
    ISO20022.Seev047001.PersonName3 *-- ISO20022.Seev047001.PostalAddress26
    class ISO20022.Seev047001.PostalAddress26 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + PstBx  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Seev047001.SafekeepingAccount17 {
        + AcctSubLvl  : ISO20022.Seev047001.AccountSubLevel24
        + TtlShrhldgBal  : ISO20022.Seev047001.FinancialInstrumentQuantity18Choice
        + ShrhldgBalOnClntAcct  : ISO20022.Seev047001.FinancialInstrumentQuantity18Choice
        + ShrhldgBalOnOwnAcct  : ISO20022.Seev047001.FinancialInstrumentQuantity18Choice
        + AcctSvcr  : ISO20022.Seev047001.PartyIdentification195Choice
        + SfkpgAcct  : String
    }
    ISO20022.Seev047001.SafekeepingAccount17 *-- ISO20022.Seev047001.AccountSubLevel24
    ISO20022.Seev047001.SafekeepingAccount17 *-- ISO20022.Seev047001.FinancialInstrumentQuantity18Choice
    ISO20022.Seev047001.SafekeepingAccount17 *-- ISO20022.Seev047001.FinancialInstrumentQuantity18Choice
    ISO20022.Seev047001.SafekeepingAccount17 *-- ISO20022.Seev047001.FinancialInstrumentQuantity18Choice
    ISO20022.Seev047001.SafekeepingAccount17 *-- ISO20022.Seev047001.PartyIdentification195Choice
    class ISO20022.Seev047001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Seev047001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Seev047001.SecurityIdentification19 *-- ISO20022.Seev047001.OtherIdentification1
    class ISO20022.Seev047001.ShareholdersIdentificationDisclosureResponseV03 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Seev047001.SupplementaryData1~
        + DsclsrInf  : ISO20022.Seev047001.Disclosure3Choice
        + RspndgIntrmy  : ISO20022.Seev047001.PartyIdentification219
        + DsclsrRspnId  : String
        + IssrDsclsrReqRef  : ISO20022.Seev047001.DisclosureRequestIdentification1
        + Pgntn  : ISO20022.Seev047001.Pagination1
    }
    ISO20022.Seev047001.ShareholdersIdentificationDisclosureResponseV03 *-- ISO20022.Seev047001.SupplementaryData1
    ISO20022.Seev047001.ShareholdersIdentificationDisclosureResponseV03 *-- ISO20022.Seev047001.Disclosure3Choice
    ISO20022.Seev047001.ShareholdersIdentificationDisclosureResponseV03 *-- ISO20022.Seev047001.PartyIdentification219
    ISO20022.Seev047001.ShareholdersIdentificationDisclosureResponseV03 *-- ISO20022.Seev047001.DisclosureRequestIdentification1
    ISO20022.Seev047001.ShareholdersIdentificationDisclosureResponseV03 *-- ISO20022.Seev047001.Pagination1
    class ISO20022.Seev047001.ShareholdingBalance1 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Seev047001.SupplementaryData1~
        + ThrdPty  : global::System.Collections.Generic.List~ISO20022.Seev047001.PartyIdentification218~
        + InitlDtOfShrhldg  : ISO20022.Seev047001.DateFormat57Choice
        + Qty  : ISO20022.Seev047001.FinancialInstrumentQuantity18Choice
        + ShrhldgTp  : String
    }
    ISO20022.Seev047001.ShareholdingBalance1 *-- ISO20022.Seev047001.SupplementaryData1
    ISO20022.Seev047001.ShareholdingBalance1 *-- ISO20022.Seev047001.PartyIdentification218
    ISO20022.Seev047001.ShareholdingBalance1 *-- ISO20022.Seev047001.DateFormat57Choice
    ISO20022.Seev047001.ShareholdingBalance1 *-- ISO20022.Seev047001.FinancialInstrumentQuantity18Choice
    class ISO20022.Seev047001.ShareholdingType1Code {
        UKWN = 1
        OOAC = 2
        NOMI = 3
        BENE = 4
    }
    class ISO20022.Seev047001.SupplementaryData1 {
        + Envlp  : ISO20022.Seev047001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Seev047001.SupplementaryData1 *-- ISO20022.Seev047001.SupplementaryDataEnvelope1
    class ISO20022.Seev047001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Seev047001.TypeOfIdentification4Code {
        TXID = 1
        SOCS = 2
        CCPT = 3
        NRIN = 4
        IDCD = 5
        DRLC = 6
        CORP = 7
        CUST = 8
        ARNU = 9
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

## Enum ISO20022.Seev047001.AccountOwnershipType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BOWN|Int32||XmlEnum("""BOWN""")|1|
||OWNR|Int32||XmlEnum("""OWNR""")|2|
||USUF|Int32||XmlEnum("""USUF""")|3|

---

## Value ISO20022.Seev047001.AccountSubLevel24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dsclsr|global::System.Collections.Generic.List<ISO20022.Seev047001.AccountSubLevel25>||XmlElement()||
|+|BlwThrshldShrhldgQty|ISO20022.Seev047001.FinancialInstrumentQuantity18Choice||XmlElement()||
|+|NonDscldShrhldgQty|ISO20022.Seev047001.FinancialInstrumentQuantity18Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Dsclsr""",Dsclsr),validElement(Dsclsr),validElement(BlwThrshldShrhldgQty),validElement(NonDscldShrhldgQty))|

---

## Value ISO20022.Seev047001.AccountSubLevel25


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ShrhldgBal|global::System.Collections.Generic.List<ISO20022.Seev047001.ShareholdingBalance1>||XmlElement()||
|+|AcctHldr|ISO20022.Seev047001.PartyIdentification276||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""ShrhldgBal""",ShrhldgBal),validList("""ShrhldgBal""",ShrhldgBal),validElement(ShrhldgBal),validElement(AcctHldr))|

---

## Value ISO20022.Seev047001.ActivityIndicator1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryInd|ISO20022.Seev047001.GenericIdentification36||XmlElement()||
|+|ISICIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryInd),validPattern("""ISICIdr""",ISICIdr,"""[A-U]{1,1}[0-9]{0,4}"""),validChoice(PrtryInd,ISICIdr))|

---

## Enum ISO20022.Seev047001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Seev047001.ContactIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EmailAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|MobNb|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|GvnNm|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""MobNb""",MobNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""PhneNb""",PhneNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Value ISO20022.Seev047001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Seev047001.DateAndPlaceOfBirth2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Seev047001.DateCode20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev047001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev047001.DateFormat46Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev047001.DateCode20Choice||XmlElement()||
|+|Dt|ISO20022.Seev047001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Seev047001.DateFormat57Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev047001.DateCode20Choice||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validChoice(DtCd,Dt))|

---

## Enum ISO20022.Seev047001.DateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|

---

## Value ISO20022.Seev047001.Disclosure3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SfkpgAcctAndHldgs|global::System.Collections.Generic.List<ISO20022.Seev047001.SafekeepingAccount17>||XmlElement()||
|+|NoDsclsr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""SfkpgAcctAndHldgs""",SfkpgAcctAndHldgs),validList("""SfkpgAcctAndHldgs""",SfkpgAcctAndHldgs),validElement(SfkpgAcctAndHldgs),validChoice(SfkpgAcctAndHldgs,NoDsclsr))|

---

## Value ISO20022.Seev047001.DisclosureRequestIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ShrhldrsDsclsrRcrdDt|ISO20022.Seev047001.DateFormat46Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Seev047001.SecurityIdentification19||XmlElement()||
|+|IssrDsclsrReqId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ShrhldrsDsclsrRcrdDt),validElement(FinInstrmId))|

---

## Type ISO20022.Seev047001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ShrhldrsIdDsclsrRspn|ISO20022.Seev047001.ShareholdersIdentificationDisclosureResponseV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ShrhldrsIdDsclsrRspn))|

---

## Enum ISO20022.Seev047001.Eligibility1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PROF|Int32||XmlEnum("""PROF""")|1|
||RETL|Int32||XmlEnum("""RETL""")|2|
||ELIG|Int32||XmlEnum("""ELIG""")|3|

---

## Value ISO20022.Seev047001.FinancialInstrumentQuantity18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(FaceAmt,Unit))|

---

## Value ISO20022.Seev047001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev047001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev047001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev047001.IdentificationType45Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev047001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev047001.InvestorType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev047001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev047001.NameAndAddress17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Seev047001.PostalAddress26||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Seev047001.NamePrefix1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MADM|Int32||XmlEnum("""MADM""")|1|
||MISS|Int32||XmlEnum("""MISS""")|2|
||MIST|Int32||XmlEnum("""MIST""")|3|
||DOCT|Int32||XmlEnum("""DOCT""")|4|

---

## Enum ISO20022.Seev047001.NamePrefix2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MIKS|Int32||XmlEnum("""MIKS""")|1|
||MIST|Int32||XmlEnum("""MIST""")|2|
||MISS|Int32||XmlEnum("""MISS""")|3|
||MADM|Int32||XmlEnum("""MADM""")|4|
||DOCT|Int32||XmlEnum("""DOCT""")|5|

---

## Value ISO20022.Seev047001.NaturalPersonIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdTp|ISO20022.Seev047001.IdentificationType45Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IdTp))|

---

## Enum ISO20022.Seev047001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Seev047001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Seev047001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev047001.Ownership1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UsfrctPctg|Decimal||XmlElement()||
|+|OwnrshPctg|Decimal||XmlElement()||
|+|OwnrshTp|ISO20022.Seev047001.OwnershipType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OwnrshTp))|

---

## Value ISO20022.Seev047001.OwnershipType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev047001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev047001.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Seev047001.PartyIdentification195Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|PrtryId|ISO20022.Seev047001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(LEI,PrtryId,AnyBIC))|

---

## Value ISO20022.Seev047001.PartyIdentification198Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Seev047001.GenericIdentification36||XmlElement()||
|+|ClntId|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|NtlRegnNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validChoice(PrtryId,ClntId,AnyBIC,LEI,NtlRegnNb))|

---

## Value ISO20022.Seev047001.PartyIdentification201


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|ISO20022.Seev047001.PartyIdentification198Choice||XmlElement()||
|+|NmAndAdr|ISO20022.Seev047001.PersonName2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id),validElement(NmAndAdr))|

---

## Value ISO20022.Seev047001.PartyIdentification202


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|ISO20022.Seev047001.NaturalPersonIdentification1||XmlElement()||
|+|NmAndAdr|ISO20022.Seev047001.PersonName1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id),validElement(NmAndAdr))|

---

## Value ISO20022.Seev047001.PartyIdentification205Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NtrlPrsn|ISO20022.Seev047001.PartyIdentification202||XmlElement()||
|+|LglPrsn|ISO20022.Seev047001.PartyIdentification201||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NtrlPrsn),validElement(LglPrsn),validChoice(NtrlPrsn,LglPrsn))|

---

## Value ISO20022.Seev047001.PartyIdentification217


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ownrsh|ISO20022.Seev047001.Ownership1||XmlElement()||
|+|InvstrTp|ISO20022.Seev047001.InvestorType1Choice||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Seev047001.DateAndPlaceOfBirth2||XmlElement()||
|+|Ntlty|String||XmlElement()||
|+|Id|ISO20022.Seev047001.NaturalPersonIdentification1||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|NmAndAdr|ISO20022.Seev047001.PersonName3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ownrsh),validElement(InvstrTp),validElement(DtAndPlcOfBirth),validPattern("""Ntlty""",Ntlty,"""[A-Z]{2,2}"""),validElement(Id),validElement(NmAndAdr))|

---

## Value ISO20022.Seev047001.PartyIdentification218


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|ISO20022.Seev047001.PartyIdentification205Choice||XmlElement()||
|+|Role|ISO20022.Seev047001.PartyRole6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id),validElement(Role))|

---

## Value ISO20022.Seev047001.PartyIdentification219


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctPrsn|ISO20022.Seev047001.ContactIdentification2||XmlElement()||
|+|Id|ISO20022.Seev047001.PartyIdentification195Choice||XmlElement()||
|+|NmAndAdr|ISO20022.Seev047001.PersonName2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctPrsn),validElement(Id),validElement(NmAndAdr))|

---

## Value ISO20022.Seev047001.PartyIdentification275


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ownrsh|ISO20022.Seev047001.Ownership1||XmlElement()||
|+|InvstrTp|ISO20022.Seev047001.InvestorType1Choice||XmlElement()||
|+|ActvtyInd|ISO20022.Seev047001.ActivityIndicator1Choice||XmlElement()||
|+|YrOfIncorprtn|Int32||XmlElement()||
|+|CtryOfIncorprtn|String||XmlElement()||
|+|Id|ISO20022.Seev047001.PartyIdentification198Choice||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|NmAndAdr|ISO20022.Seev047001.NameAndAddress17||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ownrsh),validElement(InvstrTp),validElement(ActvtyInd),validPattern("""CtryOfIncorprtn""",CtryOfIncorprtn,"""[A-Z]{2,2}"""),validElement(Id),validElement(NmAndAdr))|

---

## Value ISO20022.Seev047001.PartyIdentification276


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NtrlPrsn|global::System.Collections.Generic.List<ISO20022.Seev047001.PartyIdentification217>||XmlElement()||
|+|LglPrsn|global::System.Collections.Generic.List<ISO20022.Seev047001.PartyIdentification275>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""NtrlPrsn""",NtrlPrsn),validElement(NtrlPrsn),validList("""LglPrsn""",LglPrsn),validElement(LglPrsn))|

---

## Enum ISO20022.Seev047001.PartyRole2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DECM|Int32||XmlEnum("""DECM""")|1|
||LGRD|Int32||XmlEnum("""LGRD""")|2|
||DIST|Int32||XmlEnum("""DIST""")|3|

---

## Value ISO20022.Seev047001.PartyRole6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev047001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev047001.PersonName1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Seev047001.PostalAddress26||XmlElement()||
|+|Srnm|String||XmlElement()||
|+|FrstNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Seev047001.PersonName2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Seev047001.PostalAddress26||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Seev047001.PersonName3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Seev047001.PostalAddress26||XmlElement()||
|+|Srnm|String||XmlElement()||
|+|FrstNm|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Seev047001.PostalAddress26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|PstBx|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AdrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validListMax("""AdrLine""",AdrLine,5))|

---

## Value ISO20022.Seev047001.SafekeepingAccount17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctSubLvl|ISO20022.Seev047001.AccountSubLevel24||XmlElement()||
|+|TtlShrhldgBal|ISO20022.Seev047001.FinancialInstrumentQuantity18Choice||XmlElement()||
|+|ShrhldgBalOnClntAcct|ISO20022.Seev047001.FinancialInstrumentQuantity18Choice||XmlElement()||
|+|ShrhldgBalOnOwnAcct|ISO20022.Seev047001.FinancialInstrumentQuantity18Choice||XmlElement()||
|+|AcctSvcr|ISO20022.Seev047001.PartyIdentification195Choice||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctSubLvl),validElement(TtlShrhldgBal),validElement(ShrhldgBalOnClntAcct),validElement(ShrhldgBalOnOwnAcct),validElement(AcctSvcr))|

---

## Value ISO20022.Seev047001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Seev047001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Aspect ISO20022.Seev047001.ShareholdersIdentificationDisclosureResponseV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Seev047001.SupplementaryData1>||XmlElement()||
|+|DsclsrInf|ISO20022.Seev047001.Disclosure3Choice||XmlElement()||
|+|RspndgIntrmy|ISO20022.Seev047001.PartyIdentification219||XmlElement()||
|+|DsclsrRspnId|String||XmlElement()||
|+|IssrDsclsrReqRef|ISO20022.Seev047001.DisclosureRequestIdentification1||XmlElement()||
|+|Pgntn|ISO20022.Seev047001.Pagination1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(DsclsrInf),validElement(RspndgIntrmy),validElement(IssrDsclsrReqRef),validElement(Pgntn))|

---

## Value ISO20022.Seev047001.ShareholdingBalance1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Seev047001.SupplementaryData1>||XmlElement()||
|+|ThrdPty|global::System.Collections.Generic.List<ISO20022.Seev047001.PartyIdentification218>||XmlElement()||
|+|InitlDtOfShrhldg|ISO20022.Seev047001.DateFormat57Choice||XmlElement()||
|+|Qty|ISO20022.Seev047001.FinancialInstrumentQuantity18Choice||XmlElement()||
|+|ShrhldgTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""ThrdPty""",ThrdPty),validElement(ThrdPty),validElement(InitlDtOfShrhldg),validElement(Qty))|

---

## Enum ISO20022.Seev047001.ShareholdingType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||OOAC|Int32||XmlEnum("""OOAC""")|2|
||NOMI|Int32||XmlEnum("""NOMI""")|3|
||BENE|Int32||XmlEnum("""BENE""")|4|

---

## Value ISO20022.Seev047001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Seev047001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Seev047001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Seev047001.TypeOfIdentification4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TXID|Int32||XmlEnum("""TXID""")|1|
||SOCS|Int32||XmlEnum("""SOCS""")|2|
||CCPT|Int32||XmlEnum("""CCPT""")|3|
||NRIN|Int32||XmlEnum("""NRIN""")|4|
||IDCD|Int32||XmlEnum("""IDCD""")|5|
||DRLC|Int32||XmlEnum("""DRLC""")|6|
||CORP|Int32||XmlEnum("""CORP""")|7|
||CUST|Int32||XmlEnum("""CUST""")|8|
||ARNU|Int32||XmlEnum("""ARNU""")|9|

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

