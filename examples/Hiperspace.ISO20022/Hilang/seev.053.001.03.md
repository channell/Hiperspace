# seev.053.001.03
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Seev053001.ActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev053001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev053001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Seev053001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Seev053001.BlockChainAddressWallet3 *-- ISO20022.Seev053001.GenericIdentification30
    class ISO20022.Seev053001.CancelledReason9Choice {
        + Prtry  : ISO20022.Seev053001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev053001.CancelledReason9Choice *-- ISO20022.Seev053001.GenericIdentification30
    class ISO20022.Seev053001.CancelledStatus11Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev053001.CancelledStatusReason12~
        + NoSpcfdRsn  : String
    }
    ISO20022.Seev053001.CancelledStatus11Choice *-- ISO20022.Seev053001.CancelledStatusReason12
    class ISO20022.Seev053001.CancelledStatusReason12 {
        + AddtlRsnInf  : String
        + RsnCd  : ISO20022.Seev053001.CancelledReason9Choice
    }
    ISO20022.Seev053001.CancelledStatusReason12 *-- ISO20022.Seev053001.CancelledReason9Choice
    class ISO20022.Seev053001.CancelledStatusReason5Code {
        OTHR = 1
        CANI = 2
    }
    class ISO20022.Seev053001.CashAccountIdentification9Choice {
        + Prtry  : String
        + BlckChainCshWllt  : ISO20022.Seev053001.BlockChainAddressWallet3
        + IBAN  : String
    }
    ISO20022.Seev053001.CashAccountIdentification9Choice *-- ISO20022.Seev053001.BlockChainAddressWallet3
    class ISO20022.Seev053001.CashOption106 {
        + PmtDt  : ISO20022.Seev053001.DateFormat43Choice
        + EarlstPmtDt  : ISO20022.Seev053001.DateAndDateTime2Choice
        + WhldgTaxAmt  : ISO20022.Seev053001.ActiveCurrencyAndAmount
        + WhldgTaxRate  : global::System.Collections.Generic.List~ISO20022.Seev053001.RateAndAmountFormat55Choice~
        + EntitldAmt  : ISO20022.Seev053001.ActiveCurrencyAndAmount
        + NetCshAmt  : ISO20022.Seev053001.ActiveCurrencyAndAmount
        + GrssCshAmt  : ISO20022.Seev053001.ActiveCurrencyAndAmount
        + CshAcctId  : ISO20022.Seev053001.CashAccountIdentification9Choice
        + CdtDbtInd  : String
    }
    ISO20022.Seev053001.CashOption106 *-- ISO20022.Seev053001.DateFormat43Choice
    ISO20022.Seev053001.CashOption106 *-- ISO20022.Seev053001.DateAndDateTime2Choice
    ISO20022.Seev053001.CashOption106 *-- ISO20022.Seev053001.ActiveCurrencyAndAmount
    ISO20022.Seev053001.CashOption106 *-- ISO20022.Seev053001.RateAndAmountFormat55Choice
    ISO20022.Seev053001.CashOption106 *-- ISO20022.Seev053001.ActiveCurrencyAndAmount
    ISO20022.Seev053001.CashOption106 *-- ISO20022.Seev053001.ActiveCurrencyAndAmount
    ISO20022.Seev053001.CashOption106 *-- ISO20022.Seev053001.ActiveCurrencyAndAmount
    ISO20022.Seev053001.CashOption106 *-- ISO20022.Seev053001.CashAccountIdentification9Choice
    class ISO20022.Seev053001.CorporateActionEventType111Choice {
        + Prtry  : ISO20022.Seev053001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev053001.CorporateActionEventType111Choice *-- ISO20022.Seev053001.GenericIdentification30
    class ISO20022.Seev053001.CorporateActionEventType39Code {
        WRTH = 1
        WTRC = 2
        EXWA = 3
        SUSP = 4
        DLST = 5
        TEND = 6
        TREC = 7
        SPLF = 8
        DVSE = 9
        SOFF = 10
        SMAL = 11
        SHPR = 12
        DVSC = 13
        RHTS = 14
        SPLR = 15
        BIDS = 16
        REMK = 17
        REDO = 18
        BPUT = 19
        PRIO = 20
        PDEF = 21
        PLAC = 22
        PINK = 23
        PRED = 24
        PCAL = 25
        PARI = 26
        OTHR = 27
        ODLT = 28
        CERT = 29
        NOOF = 30
        MRGR = 31
        EXTM = 32
        LIQU = 33
        RHDI = 34
        INTR = 35
        PPMT = 36
        INCR = 37
        MCAL = 38
        REDM = 39
        EXOF = 40
        DTCH = 41
        DRAW = 42
        DRIP = 43
        DVOP = 44
        DSCL = 45
        DETI = 46
        DECR = 47
        CREV = 48
        CONV = 49
        CONS = 50
        CLSA = 51
        COOP = 52
        CHAN = 53
        DVCA = 54
        DRCA = 55
        CAPI = 56
        CAPG = 57
        CAPD = 58
        EXRI = 59
        BONU = 60
        DFLT = 61
        BRUP = 62
        ATTI = 63
        ACTV = 64
    }
    class ISO20022.Seev053001.CorporateActionGeneralInformation181 {
        + FinInstrmId  : ISO20022.Seev053001.SecurityIdentification19
        + EvtTp  : ISO20022.Seev053001.CorporateActionEventType111Choice
        + OffclCorpActnEvtId  : String
        + CorpActnEvtId  : String
    }
    ISO20022.Seev053001.CorporateActionGeneralInformation181 *-- ISO20022.Seev053001.SecurityIdentification19
    ISO20022.Seev053001.CorporateActionGeneralInformation181 *-- ISO20022.Seev053001.CorporateActionEventType111Choice
    class ISO20022.Seev053001.CorporateActionOption11Code {
        PRUN = 1
        SLLE = 2
        SECU = 3
        QINV = 4
        OVER = 5
        OTHR = 6
        OFFR = 7
        NOQU = 8
        NOAC = 9
        MPUT = 10
        LAPS = 11
        EXER = 12
        CTEN = 13
        CONY = 14
        CONN = 15
        CEXC = 16
        CASH = 17
        CASE = 18
        BUYA = 19
        BSPL = 20
        ABST = 21
    }
    class ISO20022.Seev053001.CorporateActionOption234 {
        + CshMvmntDtls  : global::System.Collections.Generic.List~ISO20022.Seev053001.CashOption106~
        + SctiesMvmntDtls  : global::System.Collections.Generic.List~ISO20022.Seev053001.SecuritiesOption76~
        + OptnTp  : ISO20022.Seev053001.CorporateActionOption30Choice
        + OptnNb  : String
    }
    ISO20022.Seev053001.CorporateActionOption234 *-- ISO20022.Seev053001.CashOption106
    ISO20022.Seev053001.CorporateActionOption234 *-- ISO20022.Seev053001.SecuritiesOption76
    ISO20022.Seev053001.CorporateActionOption234 *-- ISO20022.Seev053001.CorporateActionOption30Choice
    class ISO20022.Seev053001.CorporateActionOption30Choice {
        + Prtry  : ISO20022.Seev053001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev053001.CorporateActionOption30Choice *-- ISO20022.Seev053001.GenericIdentification30
    class ISO20022.Seev053001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Seev053001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Seev053001.DateCode19Choice {
        + Prtry  : ISO20022.Seev053001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev053001.DateCode19Choice *-- ISO20022.Seev053001.GenericIdentification30
    class ISO20022.Seev053001.DateFormat43Choice {
        + DtCd  : ISO20022.Seev053001.DateCode19Choice
        + Dt  : ISO20022.Seev053001.DateAndDateTime2Choice
    }
    ISO20022.Seev053001.DateFormat43Choice *-- ISO20022.Seev053001.DateCode19Choice
    ISO20022.Seev053001.DateFormat43Choice *-- ISO20022.Seev053001.DateAndDateTime2Choice
    class ISO20022.Seev053001.DateFormat58Choice {
        + DtCd  : String
        + DtOrDtTm  : ISO20022.Seev053001.DateAndDateTime2Choice
    }
    ISO20022.Seev053001.DateFormat58Choice *-- ISO20022.Seev053001.DateAndDateTime2Choice
    class ISO20022.Seev053001.DateType1Code {
        UKWN = 1
    }
    class ISO20022.Seev053001.DateType8Code {
        ONGO = 1
        UKWN = 2
    }
    class ISO20022.Seev053001.DocumentIdentification9 {
        + Id  : String
    }
    class ISO20022.Seev053001.FinancialInstrumentQuantity1Choice {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev053001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev053001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Seev053001.MarketClaimCancellationRequestStatus2Choice {
        + PrtrySts  : ISO20022.Seev053001.ProprietaryStatusAndReason6
        + PdgCxl  : ISO20022.Seev053001.PendingCancellationStatus14Choice
        + Rjctd  : ISO20022.Seev053001.RejectedStatus38Choice
        + Accptd  : ISO20022.Seev053001.NoSpecifiedReason1
        + CxlCmpltd  : ISO20022.Seev053001.CancelledStatus11Choice
    }
    ISO20022.Seev053001.MarketClaimCancellationRequestStatus2Choice *-- ISO20022.Seev053001.ProprietaryStatusAndReason6
    ISO20022.Seev053001.MarketClaimCancellationRequestStatus2Choice *-- ISO20022.Seev053001.PendingCancellationStatus14Choice
    ISO20022.Seev053001.MarketClaimCancellationRequestStatus2Choice *-- ISO20022.Seev053001.RejectedStatus38Choice
    ISO20022.Seev053001.MarketClaimCancellationRequestStatus2Choice *-- ISO20022.Seev053001.NoSpecifiedReason1
    ISO20022.Seev053001.MarketClaimCancellationRequestStatus2Choice *-- ISO20022.Seev053001.CancelledStatus11Choice
    class ISO20022.Seev053001.MarketClaimCancellationRequestStatusAdviceV03 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Seev053001.SupplementaryData1~
        + MktClmDtls  : ISO20022.Seev053001.CorporateActionOption234
        + MktClmCxlReqSts  : ISO20022.Seev053001.MarketClaimCancellationRequestStatus2Choice
        + CorpActnGnlInf  : ISO20022.Seev053001.CorporateActionGeneralInformation181
        + TxRef  : ISO20022.Seev053001.References26
        + MktClmCxlReqId  : ISO20022.Seev053001.DocumentIdentification9
    }
    ISO20022.Seev053001.MarketClaimCancellationRequestStatusAdviceV03 *-- ISO20022.Seev053001.SupplementaryData1
    ISO20022.Seev053001.MarketClaimCancellationRequestStatusAdviceV03 *-- ISO20022.Seev053001.CorporateActionOption234
    ISO20022.Seev053001.MarketClaimCancellationRequestStatusAdviceV03 *-- ISO20022.Seev053001.MarketClaimCancellationRequestStatus2Choice
    ISO20022.Seev053001.MarketClaimCancellationRequestStatusAdviceV03 *-- ISO20022.Seev053001.CorporateActionGeneralInformation181
    ISO20022.Seev053001.MarketClaimCancellationRequestStatusAdviceV03 *-- ISO20022.Seev053001.References26
    ISO20022.Seev053001.MarketClaimCancellationRequestStatusAdviceV03 *-- ISO20022.Seev053001.DocumentIdentification9
    class ISO20022.Seev053001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Seev053001.NoSpecifiedReason1 {
        + NoSpcfdRsn  : String
    }
    class ISO20022.Seev053001.OriginalAndCurrentQuantities1 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Seev053001.OtherIdentification1 {
        + Tp  : ISO20022.Seev053001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Seev053001.OtherIdentification1 *-- ISO20022.Seev053001.IdentificationSource3Choice
    class ISO20022.Seev053001.PendingCancellationReason7Code {
        OTHR = 1
        CONF = 2
        ADEA = 3
    }
    class ISO20022.Seev053001.PendingCancellationReason8Choice {
        + Prtry  : ISO20022.Seev053001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev053001.PendingCancellationReason8Choice *-- ISO20022.Seev053001.GenericIdentification30
    class ISO20022.Seev053001.PendingCancellationStatus14Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev053001.PendingCancellationStatusReason11~
        + NoSpcfdRsn  : String
    }
    ISO20022.Seev053001.PendingCancellationStatus14Choice *-- ISO20022.Seev053001.PendingCancellationStatusReason11
    class ISO20022.Seev053001.PendingCancellationStatusReason11 {
        + AddtlRsnInf  : String
        + RsnCd  : ISO20022.Seev053001.PendingCancellationReason8Choice
    }
    ISO20022.Seev053001.PendingCancellationStatusReason11 *-- ISO20022.Seev053001.PendingCancellationReason8Choice
    class ISO20022.Seev053001.ProprietaryReason4 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Seev053001.GenericIdentification30
    }
    ISO20022.Seev053001.ProprietaryReason4 *-- ISO20022.Seev053001.GenericIdentification30
    class ISO20022.Seev053001.ProprietaryStatusAndReason6 {
        + PrtryRsn  : global::System.Collections.Generic.List~ISO20022.Seev053001.ProprietaryReason4~
        + PrtrySts  : ISO20022.Seev053001.GenericIdentification30
    }
    ISO20022.Seev053001.ProprietaryStatusAndReason6 *-- ISO20022.Seev053001.ProprietaryReason4
    ISO20022.Seev053001.ProprietaryStatusAndReason6 *-- ISO20022.Seev053001.GenericIdentification30
    class ISO20022.Seev053001.Quantity6Choice {
        + OrgnlAndCurFace  : ISO20022.Seev053001.OriginalAndCurrentQuantities1
        + Qty  : ISO20022.Seev053001.FinancialInstrumentQuantity1Choice
    }
    ISO20022.Seev053001.Quantity6Choice *-- ISO20022.Seev053001.OriginalAndCurrentQuantities1
    ISO20022.Seev053001.Quantity6Choice *-- ISO20022.Seev053001.FinancialInstrumentQuantity1Choice
    class ISO20022.Seev053001.RateAndAmountFormat55Choice {
        + RateTpAndRate  : ISO20022.Seev053001.RateTypeAndPercentageRate12
        + Amt  : ISO20022.Seev053001.ActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev053001.RateAndAmountFormat55Choice *-- ISO20022.Seev053001.RateTypeAndPercentageRate12
    ISO20022.Seev053001.RateAndAmountFormat55Choice *-- ISO20022.Seev053001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev053001.RateType42Choice {
        + Prtry  : ISO20022.Seev053001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev053001.RateType42Choice *-- ISO20022.Seev053001.GenericIdentification30
    class ISO20022.Seev053001.RateTypeAndPercentageRate12 {
        + Rate  : Decimal
        + RateTp  : ISO20022.Seev053001.RateType42Choice
    }
    ISO20022.Seev053001.RateTypeAndPercentageRate12 *-- ISO20022.Seev053001.RateType42Choice
    class ISO20022.Seev053001.References26 {
        + PrcrTxId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
    }
    class ISO20022.Seev053001.RejectedReason38Choice {
        + Prtry  : ISO20022.Seev053001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev053001.RejectedReason38Choice *-- ISO20022.Seev053001.GenericIdentification30
    class ISO20022.Seev053001.RejectedStatus38Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev053001.RejectedStatusReason36~
        + NoSpcfdRsn  : String
    }
    ISO20022.Seev053001.RejectedStatus38Choice *-- ISO20022.Seev053001.RejectedStatusReason36
    class ISO20022.Seev053001.RejectedStatusReason36 {
        + AddtlRsnInf  : String
        + RsnCd  : ISO20022.Seev053001.RejectedReason38Choice
    }
    ISO20022.Seev053001.RejectedStatusReason36 *-- ISO20022.Seev053001.RejectedReason38Choice
    class ISO20022.Seev053001.RejectionReason61Code {
        DPRG = 1
        DSET = 2
        DCAN = 3
        OTHR = 4
        LATE = 5
        ULNK = 6
        ADEA = 7
    }
    class ISO20022.Seev053001.SecuritiesOption76 {
        + PmtDt  : ISO20022.Seev053001.DateFormat58Choice
        + EntitldQty  : ISO20022.Seev053001.Quantity6Choice
        + CdtDbtInd  : String
        + FinInstrmId  : ISO20022.Seev053001.SecurityIdentification19
    }
    ISO20022.Seev053001.SecuritiesOption76 *-- ISO20022.Seev053001.DateFormat58Choice
    ISO20022.Seev053001.SecuritiesOption76 *-- ISO20022.Seev053001.Quantity6Choice
    ISO20022.Seev053001.SecuritiesOption76 *-- ISO20022.Seev053001.SecurityIdentification19
    class ISO20022.Seev053001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Seev053001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Seev053001.SecurityIdentification19 *-- ISO20022.Seev053001.OtherIdentification1
    class ISO20022.Seev053001.SupplementaryData1 {
        + Envlp  : ISO20022.Seev053001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Seev053001.SupplementaryData1 *-- ISO20022.Seev053001.SupplementaryDataEnvelope1
    class ISO20022.Seev053001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Seev053001.WithholdingTaxRateType1Code {
        NRAT = 1
        FTCA = 2
        BWIT = 3
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

## Value ISO20022.Seev053001.ActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Seev053001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Seev053001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Seev053001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev053001.CancelledReason9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev053001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev053001.CancelledStatus11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev053001.CancelledStatusReason12>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Seev053001.CancelledStatusReason12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|RsnCd|ISO20022.Seev053001.CancelledReason9Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsnCd))|

---

## Enum ISO20022.Seev053001.CancelledStatusReason5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||CANI|Int32||XmlEnum("""CANI""")|2|

---

## Value ISO20022.Seev053001.CashAccountIdentification9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|BlckChainCshWllt|ISO20022.Seev053001.BlockChainAddressWallet3||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BlckChainCshWllt),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,BlckChainCshWllt,IBAN))|

---

## Value ISO20022.Seev053001.CashOption106


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PmtDt|ISO20022.Seev053001.DateFormat43Choice||XmlElement()||
|+|EarlstPmtDt|ISO20022.Seev053001.DateAndDateTime2Choice||XmlElement()||
|+|WhldgTaxAmt|ISO20022.Seev053001.ActiveCurrencyAndAmount||XmlElement()||
|+|WhldgTaxRate|global::System.Collections.Generic.List<ISO20022.Seev053001.RateAndAmountFormat55Choice>||XmlElement()||
|+|EntitldAmt|ISO20022.Seev053001.ActiveCurrencyAndAmount||XmlElement()||
|+|NetCshAmt|ISO20022.Seev053001.ActiveCurrencyAndAmount||XmlElement()||
|+|GrssCshAmt|ISO20022.Seev053001.ActiveCurrencyAndAmount||XmlElement()||
|+|CshAcctId|ISO20022.Seev053001.CashAccountIdentification9Choice||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PmtDt),validElement(EarlstPmtDt),validElement(WhldgTaxAmt),validList("""WhldgTaxRate""",WhldgTaxRate),validElement(WhldgTaxRate),validElement(EntitldAmt),validElement(NetCshAmt),validElement(GrssCshAmt),validElement(CshAcctId))|

---

## Value ISO20022.Seev053001.CorporateActionEventType111Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev053001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev053001.CorporateActionEventType39Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WRTH|Int32||XmlEnum("""WRTH""")|1|
||WTRC|Int32||XmlEnum("""WTRC""")|2|
||EXWA|Int32||XmlEnum("""EXWA""")|3|
||SUSP|Int32||XmlEnum("""SUSP""")|4|
||DLST|Int32||XmlEnum("""DLST""")|5|
||TEND|Int32||XmlEnum("""TEND""")|6|
||TREC|Int32||XmlEnum("""TREC""")|7|
||SPLF|Int32||XmlEnum("""SPLF""")|8|
||DVSE|Int32||XmlEnum("""DVSE""")|9|
||SOFF|Int32||XmlEnum("""SOFF""")|10|
||SMAL|Int32||XmlEnum("""SMAL""")|11|
||SHPR|Int32||XmlEnum("""SHPR""")|12|
||DVSC|Int32||XmlEnum("""DVSC""")|13|
||RHTS|Int32||XmlEnum("""RHTS""")|14|
||SPLR|Int32||XmlEnum("""SPLR""")|15|
||BIDS|Int32||XmlEnum("""BIDS""")|16|
||REMK|Int32||XmlEnum("""REMK""")|17|
||REDO|Int32||XmlEnum("""REDO""")|18|
||BPUT|Int32||XmlEnum("""BPUT""")|19|
||PRIO|Int32||XmlEnum("""PRIO""")|20|
||PDEF|Int32||XmlEnum("""PDEF""")|21|
||PLAC|Int32||XmlEnum("""PLAC""")|22|
||PINK|Int32||XmlEnum("""PINK""")|23|
||PRED|Int32||XmlEnum("""PRED""")|24|
||PCAL|Int32||XmlEnum("""PCAL""")|25|
||PARI|Int32||XmlEnum("""PARI""")|26|
||OTHR|Int32||XmlEnum("""OTHR""")|27|
||ODLT|Int32||XmlEnum("""ODLT""")|28|
||CERT|Int32||XmlEnum("""CERT""")|29|
||NOOF|Int32||XmlEnum("""NOOF""")|30|
||MRGR|Int32||XmlEnum("""MRGR""")|31|
||EXTM|Int32||XmlEnum("""EXTM""")|32|
||LIQU|Int32||XmlEnum("""LIQU""")|33|
||RHDI|Int32||XmlEnum("""RHDI""")|34|
||INTR|Int32||XmlEnum("""INTR""")|35|
||PPMT|Int32||XmlEnum("""PPMT""")|36|
||INCR|Int32||XmlEnum("""INCR""")|37|
||MCAL|Int32||XmlEnum("""MCAL""")|38|
||REDM|Int32||XmlEnum("""REDM""")|39|
||EXOF|Int32||XmlEnum("""EXOF""")|40|
||DTCH|Int32||XmlEnum("""DTCH""")|41|
||DRAW|Int32||XmlEnum("""DRAW""")|42|
||DRIP|Int32||XmlEnum("""DRIP""")|43|
||DVOP|Int32||XmlEnum("""DVOP""")|44|
||DSCL|Int32||XmlEnum("""DSCL""")|45|
||DETI|Int32||XmlEnum("""DETI""")|46|
||DECR|Int32||XmlEnum("""DECR""")|47|
||CREV|Int32||XmlEnum("""CREV""")|48|
||CONV|Int32||XmlEnum("""CONV""")|49|
||CONS|Int32||XmlEnum("""CONS""")|50|
||CLSA|Int32||XmlEnum("""CLSA""")|51|
||COOP|Int32||XmlEnum("""COOP""")|52|
||CHAN|Int32||XmlEnum("""CHAN""")|53|
||DVCA|Int32||XmlEnum("""DVCA""")|54|
||DRCA|Int32||XmlEnum("""DRCA""")|55|
||CAPI|Int32||XmlEnum("""CAPI""")|56|
||CAPG|Int32||XmlEnum("""CAPG""")|57|
||CAPD|Int32||XmlEnum("""CAPD""")|58|
||EXRI|Int32||XmlEnum("""EXRI""")|59|
||BONU|Int32||XmlEnum("""BONU""")|60|
||DFLT|Int32||XmlEnum("""DFLT""")|61|
||BRUP|Int32||XmlEnum("""BRUP""")|62|
||ATTI|Int32||XmlEnum("""ATTI""")|63|
||ACTV|Int32||XmlEnum("""ACTV""")|64|

---

## Value ISO20022.Seev053001.CorporateActionGeneralInformation181


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmId|ISO20022.Seev053001.SecurityIdentification19||XmlElement()||
|+|EvtTp|ISO20022.Seev053001.CorporateActionEventType111Choice||XmlElement()||
|+|OffclCorpActnEvtId|String||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FinInstrmId),validElement(EvtTp))|

---

## Enum ISO20022.Seev053001.CorporateActionOption11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRUN|Int32||XmlEnum("""PRUN""")|1|
||SLLE|Int32||XmlEnum("""SLLE""")|2|
||SECU|Int32||XmlEnum("""SECU""")|3|
||QINV|Int32||XmlEnum("""QINV""")|4|
||OVER|Int32||XmlEnum("""OVER""")|5|
||OTHR|Int32||XmlEnum("""OTHR""")|6|
||OFFR|Int32||XmlEnum("""OFFR""")|7|
||NOQU|Int32||XmlEnum("""NOQU""")|8|
||NOAC|Int32||XmlEnum("""NOAC""")|9|
||MPUT|Int32||XmlEnum("""MPUT""")|10|
||LAPS|Int32||XmlEnum("""LAPS""")|11|
||EXER|Int32||XmlEnum("""EXER""")|12|
||CTEN|Int32||XmlEnum("""CTEN""")|13|
||CONY|Int32||XmlEnum("""CONY""")|14|
||CONN|Int32||XmlEnum("""CONN""")|15|
||CEXC|Int32||XmlEnum("""CEXC""")|16|
||CASH|Int32||XmlEnum("""CASH""")|17|
||CASE|Int32||XmlEnum("""CASE""")|18|
||BUYA|Int32||XmlEnum("""BUYA""")|19|
||BSPL|Int32||XmlEnum("""BSPL""")|20|
||ABST|Int32||XmlEnum("""ABST""")|21|

---

## Value ISO20022.Seev053001.CorporateActionOption234


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshMvmntDtls|global::System.Collections.Generic.List<ISO20022.Seev053001.CashOption106>||XmlElement()||
|+|SctiesMvmntDtls|global::System.Collections.Generic.List<ISO20022.Seev053001.SecuritiesOption76>||XmlElement()||
|+|OptnTp|ISO20022.Seev053001.CorporateActionOption30Choice||XmlElement()||
|+|OptnNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CshMvmntDtls""",CshMvmntDtls),validElement(CshMvmntDtls),validList("""SctiesMvmntDtls""",SctiesMvmntDtls),validElement(SctiesMvmntDtls),validElement(OptnTp),validPattern("""OptnNb""",OptnNb,"""[0-9]{3}"""))|

---

## Value ISO20022.Seev053001.CorporateActionOption30Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev053001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev053001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Seev053001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Seev053001.DateCode19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev053001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev053001.DateFormat43Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev053001.DateCode19Choice||XmlElement()||
|+|Dt|ISO20022.Seev053001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Seev053001.DateFormat58Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|String||XmlElement()||
|+|DtOrDtTm|ISO20022.Seev053001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtOrDtTm),validChoice(DtCd,DtOrDtTm))|

---

## Enum ISO20022.Seev053001.DateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|

---

## Enum ISO20022.Seev053001.DateType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONGO|Int32||XmlEnum("""ONGO""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|

---

## Type ISO20022.Seev053001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MktClmCxlReqStsAdvc|ISO20022.Seev053001.MarketClaimCancellationRequestStatusAdviceV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MktClmCxlReqStsAdvc))|

---

## Value ISO20022.Seev053001.DocumentIdentification9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev053001.FinancialInstrumentQuantity1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Seev053001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev053001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev053001.MarketClaimCancellationRequestStatus2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtrySts|ISO20022.Seev053001.ProprietaryStatusAndReason6||XmlElement()||
|+|PdgCxl|ISO20022.Seev053001.PendingCancellationStatus14Choice||XmlElement()||
|+|Rjctd|ISO20022.Seev053001.RejectedStatus38Choice||XmlElement()||
|+|Accptd|ISO20022.Seev053001.NoSpecifiedReason1||XmlElement()||
|+|CxlCmpltd|ISO20022.Seev053001.CancelledStatus11Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtrySts),validElement(PdgCxl),validElement(Rjctd),validElement(Accptd),validElement(CxlCmpltd),validChoice(PrtrySts,PdgCxl,Rjctd,Accptd,CxlCmpltd))|

---

## Aspect ISO20022.Seev053001.MarketClaimCancellationRequestStatusAdviceV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Seev053001.SupplementaryData1>||XmlElement()||
|+|MktClmDtls|ISO20022.Seev053001.CorporateActionOption234||XmlElement()||
|+|MktClmCxlReqSts|ISO20022.Seev053001.MarketClaimCancellationRequestStatus2Choice||XmlElement()||
|+|CorpActnGnlInf|ISO20022.Seev053001.CorporateActionGeneralInformation181||XmlElement()||
|+|TxRef|ISO20022.Seev053001.References26||XmlElement()||
|+|MktClmCxlReqId|ISO20022.Seev053001.DocumentIdentification9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(MktClmDtls),validElement(MktClmCxlReqSts),validElement(CorpActnGnlInf),validElement(TxRef),validElement(MktClmCxlReqId))|

---

## Enum ISO20022.Seev053001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Seev053001.NoSpecifiedReason1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev053001.OriginalAndCurrentQuantities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev053001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Seev053001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Enum ISO20022.Seev053001.PendingCancellationReason7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||CONF|Int32||XmlEnum("""CONF""")|2|
||ADEA|Int32||XmlEnum("""ADEA""")|3|

---

## Value ISO20022.Seev053001.PendingCancellationReason8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev053001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev053001.PendingCancellationStatus14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev053001.PendingCancellationStatusReason11>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Seev053001.PendingCancellationStatusReason11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|RsnCd|ISO20022.Seev053001.PendingCancellationReason8Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsnCd))|

---

## Value ISO20022.Seev053001.ProprietaryReason4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Seev053001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Value ISO20022.Seev053001.ProprietaryStatusAndReason6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryRsn|global::System.Collections.Generic.List<ISO20022.Seev053001.ProprietaryReason4>||XmlElement()||
|+|PrtrySts|ISO20022.Seev053001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrtryRsn""",PrtryRsn),validElement(PrtryRsn),validElement(PrtrySts))|

---

## Value ISO20022.Seev053001.Quantity6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Seev053001.OriginalAndCurrentQuantities1||XmlElement()||
|+|Qty|ISO20022.Seev053001.FinancialInstrumentQuantity1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Value ISO20022.Seev053001.RateAndAmountFormat55Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndRate|ISO20022.Seev053001.RateTypeAndPercentageRate12||XmlElement()||
|+|Amt|ISO20022.Seev053001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndRate),validElement(Amt),validChoice(RateTpAndRate,Amt,Rate))|

---

## Value ISO20022.Seev053001.RateType42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev053001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev053001.RateTypeAndPercentageRate12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|RateTp|ISO20022.Seev053001.RateType42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTp))|

---

## Value ISO20022.Seev053001.References26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev053001.RejectedReason38Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev053001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev053001.RejectedStatus38Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev053001.RejectedStatusReason36>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Seev053001.RejectedStatusReason36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|RsnCd|ISO20022.Seev053001.RejectedReason38Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsnCd))|

---

## Enum ISO20022.Seev053001.RejectionReason61Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DPRG|Int32||XmlEnum("""DPRG""")|1|
||DSET|Int32||XmlEnum("""DSET""")|2|
||DCAN|Int32||XmlEnum("""DCAN""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||LATE|Int32||XmlEnum("""LATE""")|5|
||ULNK|Int32||XmlEnum("""ULNK""")|6|
||ADEA|Int32||XmlEnum("""ADEA""")|7|

---

## Value ISO20022.Seev053001.SecuritiesOption76


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PmtDt|ISO20022.Seev053001.DateFormat58Choice||XmlElement()||
|+|EntitldQty|ISO20022.Seev053001.Quantity6Choice||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|FinInstrmId|ISO20022.Seev053001.SecurityIdentification19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PmtDt),validElement(EntitldQty),validElement(FinInstrmId))|

---

## Value ISO20022.Seev053001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Seev053001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Seev053001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Seev053001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Seev053001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Seev053001.WithholdingTaxRateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NRAT|Int32||XmlEnum("""NRAT""")|1|
||FTCA|Int32||XmlEnum("""FTCA""")|2|
||BWIT|Int32||XmlEnum("""BWIT""")|3|

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

