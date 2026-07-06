# colr.014.001.05
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Colr014001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Colr014001.Agreement4 {
        + AgrmtFrmwk  : ISO20022.Colr014001.AgreementFramework1Choice
        + BaseCcy  : String
        + AgrmtDt  : DateTime
        + AgrmtId  : String
        + AgrmtDtls  : String
    }
    ISO20022.Colr014001.Agreement4 *-- ISO20022.Colr014001.AgreementFramework1Choice
    class ISO20022.Colr014001.AgreementFramework1Choice {
        + PrtryId  : ISO20022.Colr014001.GenericIdentification30
        + AgrmtFrmwk  : String
    }
    ISO20022.Colr014001.AgreementFramework1Choice *-- ISO20022.Colr014001.GenericIdentification30
    class ISO20022.Colr014001.AgreementFramework1Code {
        NONR = 1
        ISDA = 2
        DERV = 3
        BBAA = 4
        FBAA = 5
    }
    class ISO20022.Colr014001.BlockChainAddressWallet5 {
        + Nm  : String
        + Tp  : ISO20022.Colr014001.CollateralAccountIdentificationType3Choice
        + Id  : String
    }
    ISO20022.Colr014001.BlockChainAddressWallet5 *-- ISO20022.Colr014001.CollateralAccountIdentificationType3Choice
    class ISO20022.Colr014001.CalculationMethod1Code {
        COMP = 1
        SIMP = 2
    }
    class ISO20022.Colr014001.CollateralAccount3 {
        + Nm  : String
        + Tp  : ISO20022.Colr014001.CollateralAccountIdentificationType3Choice
        + Id  : String
    }
    ISO20022.Colr014001.CollateralAccount3 *-- ISO20022.Colr014001.CollateralAccountIdentificationType3Choice
    class ISO20022.Colr014001.CollateralAccountIdentificationType3Choice {
        + Prtry  : ISO20022.Colr014001.GenericIdentification36
        + Tp  : String
    }
    ISO20022.Colr014001.CollateralAccountIdentificationType3Choice *-- ISO20022.Colr014001.GenericIdentification36
    class ISO20022.Colr014001.CollateralAccountType1Code {
        DFLT = 1
        MGIN = 2
        LIPR = 3
        CLIE = 4
        HOUS = 5
    }
    class ISO20022.Colr014001.CollateralBalance1 {
        + HeldByPtyB  : ISO20022.Colr014001.ActiveCurrencyAndAmount
        + HeldByPtyA  : ISO20022.Colr014001.ActiveCurrencyAndAmount
    }
    ISO20022.Colr014001.CollateralBalance1 *-- ISO20022.Colr014001.ActiveCurrencyAndAmount
    ISO20022.Colr014001.CollateralBalance1 *-- ISO20022.Colr014001.ActiveCurrencyAndAmount
    class ISO20022.Colr014001.CollateralPurpose1Choice {
        + Prtry  : ISO20022.Colr014001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr014001.CollateralPurpose1Choice *-- ISO20022.Colr014001.GenericIdentification30
    class ISO20022.Colr014001.CollateralPurpose1Code {
        SINA = 1
        VAMA = 2
    }
    class ISO20022.Colr014001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Colr014001.DatePeriod2 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Colr014001.ExposureType11Code {
        SHSL = 1
        REPO = 2
        TRBD = 3
        EQUI = 4
        CCPC = 5
        UDMS = 6
        TRCP = 7
        TBAS = 8
        SWPT = 9
        SCIE = 10
        SCIR = 11
        SLEB = 12
        SCRP = 13
        SBSC = 14
        SLOA = 15
        RVPO = 16
        OTCD = 17
        LIQU = 18
        OPTN = 19
        FUTR = 20
        FORW = 21
        FORX = 22
        FIXI = 23
        EXPT = 24
        EXTD = 25
        EQUS = 26
        EQPT = 27
        CRPR = 28
        CCIR = 29
        CRSP = 30
        CRTL = 31
        CRDS = 32
        COMM = 33
        CBCO = 34
        PAYM = 35
        BFWD = 36
    }
    class ISO20022.Colr014001.Frequency1Code {
        INDA = 1
        ADHO = 2
        DAIL = 3
        WEEK = 4
        MIAN = 5
        QURT = 6
        MNTH = 7
        YEAR = 8
    }
    class ISO20022.Colr014001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Colr014001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Colr014001.InterestAmount3 {
        + AddtlInf  : String
        + StdSttlmInstrs  : String
        + ClsgCollBal  : ISO20022.Colr014001.CollateralBalance1
        + OpngCollBal  : ISO20022.Colr014001.CollateralBalance1
        + CollPurp  : ISO20022.Colr014001.CollateralPurpose1Choice
        + ClctnFrqcy  : String
        + ClctnMtd  : String
        + ApldWhldgTax  : String
        + DayCntBsis  : String
        + IntrstRate  : ISO20022.Colr014001.InterestRate1Choice
        + IntrstPrd  : ISO20022.Colr014001.DatePeriod2
        + IntrstMtd  : String
        + ValDt  : ISO20022.Colr014001.DateAndDateTime2Choice
        + AcrdIntrstAmt  : ISO20022.Colr014001.ActiveCurrencyAndAmount
    }
    ISO20022.Colr014001.InterestAmount3 *-- ISO20022.Colr014001.CollateralBalance1
    ISO20022.Colr014001.InterestAmount3 *-- ISO20022.Colr014001.CollateralBalance1
    ISO20022.Colr014001.InterestAmount3 *-- ISO20022.Colr014001.CollateralPurpose1Choice
    ISO20022.Colr014001.InterestAmount3 *-- ISO20022.Colr014001.InterestRate1Choice
    ISO20022.Colr014001.InterestAmount3 *-- ISO20022.Colr014001.DatePeriod2
    ISO20022.Colr014001.InterestAmount3 *-- ISO20022.Colr014001.DateAndDateTime2Choice
    ISO20022.Colr014001.InterestAmount3 *-- ISO20022.Colr014001.ActiveCurrencyAndAmount
    class ISO20022.Colr014001.InterestComputationMethod2Code {
        NARR = 1
        A014 = 2
        A013 = 3
        A012 = 4
        A011 = 5
        A010 = 6
        A009 = 7
        A008 = 8
        A007 = 9
        A006 = 10
        A005 = 11
        A004 = 12
        A003 = 13
        A002 = 14
        A001 = 15
    }
    class ISO20022.Colr014001.InterestMethod1Code {
        ROLL = 1
        PHYS = 2
    }
    class ISO20022.Colr014001.InterestPaymentResponseV05 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Colr014001.SupplementaryData1~
        + IntrstRspn  : ISO20022.Colr014001.InterestResponse1
        + IntrstDueToB  : ISO20022.Colr014001.InterestAmount3
        + IntrstDueToA  : ISO20022.Colr014001.InterestAmount3
        + Agrmt  : ISO20022.Colr014001.Agreement4
        + Oblgtn  : ISO20022.Colr014001.Obligation9
        + TxId  : String
    }
    ISO20022.Colr014001.InterestPaymentResponseV05 *-- ISO20022.Colr014001.SupplementaryData1
    ISO20022.Colr014001.InterestPaymentResponseV05 *-- ISO20022.Colr014001.InterestResponse1
    ISO20022.Colr014001.InterestPaymentResponseV05 *-- ISO20022.Colr014001.InterestAmount3
    ISO20022.Colr014001.InterestPaymentResponseV05 *-- ISO20022.Colr014001.InterestAmount3
    ISO20022.Colr014001.InterestPaymentResponseV05 *-- ISO20022.Colr014001.Agreement4
    ISO20022.Colr014001.InterestPaymentResponseV05 *-- ISO20022.Colr014001.Obligation9
    class ISO20022.Colr014001.InterestRate1Choice {
        + VarblIntrstRate  : ISO20022.Colr014001.VariableInterest1Rate
        + FxdIntrstRate  : Decimal
    }
    ISO20022.Colr014001.InterestRate1Choice *-- ISO20022.Colr014001.VariableInterest1Rate
    class ISO20022.Colr014001.InterestRejectionReason1Code {
        DIAM = 1
        VADA = 2
    }
    class ISO20022.Colr014001.InterestResponse1 {
        + IntrstPmtReqId  : String
        + RjctnRsnInf  : String
        + RjctnRsn  : ISO20022.Colr014001.RejectionReason21FormatChoice
        + RspnTp  : String
    }
    ISO20022.Colr014001.InterestResponse1 *-- ISO20022.Colr014001.RejectionReason21FormatChoice
    class ISO20022.Colr014001.NameAndAddress6 {
        + Adr  : ISO20022.Colr014001.PostalAddress2
        + Nm  : String
    }
    ISO20022.Colr014001.NameAndAddress6 *-- ISO20022.Colr014001.PostalAddress2
    class ISO20022.Colr014001.Obligation9 {
        + ValtnDt  : ISO20022.Colr014001.DateAndDateTime2Choice
        + XpsrTp  : String
        + BlckChainAdrOrWllt  : ISO20022.Colr014001.BlockChainAddressWallet5
        + CollAcctId  : ISO20022.Colr014001.CollateralAccount3
        + SvcgPtyB  : ISO20022.Colr014001.PartyIdentification178Choice
        + PtyB  : ISO20022.Colr014001.PartyIdentification178Choice
        + SvcgPtyA  : ISO20022.Colr014001.PartyIdentification178Choice
        + PtyA  : ISO20022.Colr014001.PartyIdentification178Choice
    }
    ISO20022.Colr014001.Obligation9 *-- ISO20022.Colr014001.DateAndDateTime2Choice
    ISO20022.Colr014001.Obligation9 *-- ISO20022.Colr014001.BlockChainAddressWallet5
    ISO20022.Colr014001.Obligation9 *-- ISO20022.Colr014001.CollateralAccount3
    ISO20022.Colr014001.Obligation9 *-- ISO20022.Colr014001.PartyIdentification178Choice
    ISO20022.Colr014001.Obligation9 *-- ISO20022.Colr014001.PartyIdentification178Choice
    ISO20022.Colr014001.Obligation9 *-- ISO20022.Colr014001.PartyIdentification178Choice
    ISO20022.Colr014001.Obligation9 *-- ISO20022.Colr014001.PartyIdentification178Choice
    class ISO20022.Colr014001.PartyIdentification178Choice {
        + NmAndAdr  : ISO20022.Colr014001.NameAndAddress6
        + PrtryId  : ISO20022.Colr014001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Colr014001.PartyIdentification178Choice *-- ISO20022.Colr014001.NameAndAddress6
    ISO20022.Colr014001.PartyIdentification178Choice *-- ISO20022.Colr014001.GenericIdentification36
    class ISO20022.Colr014001.PostalAddress2 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCdId  : String
        + StrtNm  : String
    }
    class ISO20022.Colr014001.RejectionReason21FormatChoice {
        + Prtry  : ISO20022.Colr014001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr014001.RejectionReason21FormatChoice *-- ISO20022.Colr014001.GenericIdentification30
    class ISO20022.Colr014001.Status4Code {
        PACK = 1
        REJT = 2
    }
    class ISO20022.Colr014001.SupplementaryData1 {
        + Envlp  : ISO20022.Colr014001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Colr014001.SupplementaryData1 *-- ISO20022.Colr014001.SupplementaryDataEnvelope1
    class ISO20022.Colr014001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Colr014001.VariableInterest1Rate {
        + BsisPtSprd  : Decimal
        + Indx  : String
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

## Value ISO20022.Colr014001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Colr014001.Agreement4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AgrmtFrmwk|ISO20022.Colr014001.AgreementFramework1Choice||XmlElement()||
|+|BaseCcy|String||XmlElement()||
|+|AgrmtDt|DateTime||XmlElement()||
|+|AgrmtId|String||XmlElement()||
|+|AgrmtDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AgrmtFrmwk),validPattern("""BaseCcy""",BaseCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Colr014001.AgreementFramework1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Colr014001.GenericIdentification30||XmlElement()||
|+|AgrmtFrmwk|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validChoice(PrtryId,AgrmtFrmwk))|

---

## Enum ISO20022.Colr014001.AgreementFramework1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NONR|Int32||XmlEnum("""NONR""")|1|
||ISDA|Int32||XmlEnum("""ISDA""")|2|
||DERV|Int32||XmlEnum("""DERV""")|3|
||BBAA|Int32||XmlEnum("""BBAA""")|4|
||FBAA|Int32||XmlEnum("""FBAA""")|5|

---

## Value ISO20022.Colr014001.BlockChainAddressWallet5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Colr014001.CollateralAccountIdentificationType3Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Enum ISO20022.Colr014001.CalculationMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||COMP|Int32||XmlEnum("""COMP""")|1|
||SIMP|Int32||XmlEnum("""SIMP""")|2|

---

## Value ISO20022.Colr014001.CollateralAccount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Colr014001.CollateralAccountIdentificationType3Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr014001.CollateralAccountIdentificationType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr014001.GenericIdentification36||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Tp))|

---

## Enum ISO20022.Colr014001.CollateralAccountType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DFLT|Int32||XmlEnum("""DFLT""")|1|
||MGIN|Int32||XmlEnum("""MGIN""")|2|
||LIPR|Int32||XmlEnum("""LIPR""")|3|
||CLIE|Int32||XmlEnum("""CLIE""")|4|
||HOUS|Int32||XmlEnum("""HOUS""")|5|

---

## Value ISO20022.Colr014001.CollateralBalance1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HeldByPtyB|ISO20022.Colr014001.ActiveCurrencyAndAmount||XmlElement()||
|+|HeldByPtyA|ISO20022.Colr014001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(HeldByPtyB),validElement(HeldByPtyA))|

---

## Value ISO20022.Colr014001.CollateralPurpose1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr014001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Colr014001.CollateralPurpose1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SINA|Int32||XmlEnum("""SINA""")|1|
||VAMA|Int32||XmlEnum("""VAMA""")|2|

---

## Value ISO20022.Colr014001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Colr014001.DatePeriod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Type ISO20022.Colr014001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IntrstPmtRspn|ISO20022.Colr014001.InterestPaymentResponseV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IntrstPmtRspn))|

---

## Enum ISO20022.Colr014001.ExposureType11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHSL|Int32||XmlEnum("""SHSL""")|1|
||REPO|Int32||XmlEnum("""REPO""")|2|
||TRBD|Int32||XmlEnum("""TRBD""")|3|
||EQUI|Int32||XmlEnum("""EQUI""")|4|
||CCPC|Int32||XmlEnum("""CCPC""")|5|
||UDMS|Int32||XmlEnum("""UDMS""")|6|
||TRCP|Int32||XmlEnum("""TRCP""")|7|
||TBAS|Int32||XmlEnum("""TBAS""")|8|
||SWPT|Int32||XmlEnum("""SWPT""")|9|
||SCIE|Int32||XmlEnum("""SCIE""")|10|
||SCIR|Int32||XmlEnum("""SCIR""")|11|
||SLEB|Int32||XmlEnum("""SLEB""")|12|
||SCRP|Int32||XmlEnum("""SCRP""")|13|
||SBSC|Int32||XmlEnum("""SBSC""")|14|
||SLOA|Int32||XmlEnum("""SLOA""")|15|
||RVPO|Int32||XmlEnum("""RVPO""")|16|
||OTCD|Int32||XmlEnum("""OTCD""")|17|
||LIQU|Int32||XmlEnum("""LIQU""")|18|
||OPTN|Int32||XmlEnum("""OPTN""")|19|
||FUTR|Int32||XmlEnum("""FUTR""")|20|
||FORW|Int32||XmlEnum("""FORW""")|21|
||FORX|Int32||XmlEnum("""FORX""")|22|
||FIXI|Int32||XmlEnum("""FIXI""")|23|
||EXPT|Int32||XmlEnum("""EXPT""")|24|
||EXTD|Int32||XmlEnum("""EXTD""")|25|
||EQUS|Int32||XmlEnum("""EQUS""")|26|
||EQPT|Int32||XmlEnum("""EQPT""")|27|
||CRPR|Int32||XmlEnum("""CRPR""")|28|
||CCIR|Int32||XmlEnum("""CCIR""")|29|
||CRSP|Int32||XmlEnum("""CRSP""")|30|
||CRTL|Int32||XmlEnum("""CRTL""")|31|
||CRDS|Int32||XmlEnum("""CRDS""")|32|
||COMM|Int32||XmlEnum("""COMM""")|33|
||CBCO|Int32||XmlEnum("""CBCO""")|34|
||PAYM|Int32||XmlEnum("""PAYM""")|35|
||BFWD|Int32||XmlEnum("""BFWD""")|36|

---

## Enum ISO20022.Colr014001.Frequency1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDA|Int32||XmlEnum("""INDA""")|1|
||ADHO|Int32||XmlEnum("""ADHO""")|2|
||DAIL|Int32||XmlEnum("""DAIL""")|3|
||WEEK|Int32||XmlEnum("""WEEK""")|4|
||MIAN|Int32||XmlEnum("""MIAN""")|5|
||QURT|Int32||XmlEnum("""QURT""")|6|
||MNTH|Int32||XmlEnum("""MNTH""")|7|
||YEAR|Int32||XmlEnum("""YEAR""")|8|

---

## Value ISO20022.Colr014001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Colr014001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr014001.InterestAmount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|StdSttlmInstrs|String||XmlElement()||
|+|ClsgCollBal|ISO20022.Colr014001.CollateralBalance1||XmlElement()||
|+|OpngCollBal|ISO20022.Colr014001.CollateralBalance1||XmlElement()||
|+|CollPurp|ISO20022.Colr014001.CollateralPurpose1Choice||XmlElement()||
|+|ClctnFrqcy|String||XmlElement()||
|+|ClctnMtd|String||XmlElement()||
|+|ApldWhldgTax|String||XmlElement()||
|+|DayCntBsis|String||XmlElement()||
|+|IntrstRate|ISO20022.Colr014001.InterestRate1Choice||XmlElement()||
|+|IntrstPrd|ISO20022.Colr014001.DatePeriod2||XmlElement()||
|+|IntrstMtd|String||XmlElement()||
|+|ValDt|ISO20022.Colr014001.DateAndDateTime2Choice||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Colr014001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClsgCollBal),validElement(OpngCollBal),validElement(CollPurp),validElement(IntrstRate),validElement(IntrstPrd),validElement(ValDt),validElement(AcrdIntrstAmt))|

---

## Enum ISO20022.Colr014001.InterestComputationMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NARR|Int32||XmlEnum("""NARR""")|1|
||A014|Int32||XmlEnum("""A014""")|2|
||A013|Int32||XmlEnum("""A013""")|3|
||A012|Int32||XmlEnum("""A012""")|4|
||A011|Int32||XmlEnum("""A011""")|5|
||A010|Int32||XmlEnum("""A010""")|6|
||A009|Int32||XmlEnum("""A009""")|7|
||A008|Int32||XmlEnum("""A008""")|8|
||A007|Int32||XmlEnum("""A007""")|9|
||A006|Int32||XmlEnum("""A006""")|10|
||A005|Int32||XmlEnum("""A005""")|11|
||A004|Int32||XmlEnum("""A004""")|12|
||A003|Int32||XmlEnum("""A003""")|13|
||A002|Int32||XmlEnum("""A002""")|14|
||A001|Int32||XmlEnum("""A001""")|15|

---

## Enum ISO20022.Colr014001.InterestMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ROLL|Int32||XmlEnum("""ROLL""")|1|
||PHYS|Int32||XmlEnum("""PHYS""")|2|

---

## Aspect ISO20022.Colr014001.InterestPaymentResponseV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Colr014001.SupplementaryData1>||XmlElement()||
|+|IntrstRspn|ISO20022.Colr014001.InterestResponse1||XmlElement()||
|+|IntrstDueToB|ISO20022.Colr014001.InterestAmount3||XmlElement()||
|+|IntrstDueToA|ISO20022.Colr014001.InterestAmount3||XmlElement()||
|+|Agrmt|ISO20022.Colr014001.Agreement4||XmlElement()||
|+|Oblgtn|ISO20022.Colr014001.Obligation9||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(IntrstRspn),validElement(IntrstDueToB),validElement(IntrstDueToA),validElement(Agrmt),validElement(Oblgtn))|

---

## Value ISO20022.Colr014001.InterestRate1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|VarblIntrstRate|ISO20022.Colr014001.VariableInterest1Rate||XmlElement()||
|+|FxdIntrstRate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(VarblIntrstRate),validChoice(VarblIntrstRate,FxdIntrstRate))|

---

## Enum ISO20022.Colr014001.InterestRejectionReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DIAM|Int32||XmlEnum("""DIAM""")|1|
||VADA|Int32||XmlEnum("""VADA""")|2|

---

## Value ISO20022.Colr014001.InterestResponse1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IntrstPmtReqId|String||XmlElement()||
|+|RjctnRsnInf|String||XmlElement()||
|+|RjctnRsn|ISO20022.Colr014001.RejectionReason21FormatChoice||XmlElement()||
|+|RspnTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RjctnRsn))|

---

## Value ISO20022.Colr014001.NameAndAddress6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Colr014001.PostalAddress2||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Colr014001.Obligation9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValtnDt|ISO20022.Colr014001.DateAndDateTime2Choice||XmlElement()||
|+|XpsrTp|String||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Colr014001.BlockChainAddressWallet5||XmlElement()||
|+|CollAcctId|ISO20022.Colr014001.CollateralAccount3||XmlElement()||
|+|SvcgPtyB|ISO20022.Colr014001.PartyIdentification178Choice||XmlElement()||
|+|PtyB|ISO20022.Colr014001.PartyIdentification178Choice||XmlElement()||
|+|SvcgPtyA|ISO20022.Colr014001.PartyIdentification178Choice||XmlElement()||
|+|PtyA|ISO20022.Colr014001.PartyIdentification178Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ValtnDt),validElement(BlckChainAdrOrWllt),validElement(CollAcctId),validElement(SvcgPtyB),validElement(PtyB),validElement(SvcgPtyA),validElement(PtyA))|

---

## Value ISO20022.Colr014001.PartyIdentification178Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Colr014001.NameAndAddress6||XmlElement()||
|+|PrtryId|ISO20022.Colr014001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Colr014001.PostalAddress2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCdId|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Colr014001.RejectionReason21FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr014001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Colr014001.Status4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PACK|Int32||XmlEnum("""PACK""")|1|
||REJT|Int32||XmlEnum("""REJT""")|2|

---

## Value ISO20022.Colr014001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Colr014001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Colr014001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr014001.VariableInterest1Rate


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BsisPtSprd|Decimal||XmlElement()||
|+|Indx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

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

