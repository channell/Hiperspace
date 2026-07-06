# colr.016.001.05
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Colr016001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Colr016001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Colr016001.Agreement4 {
        + AgrmtFrmwk  : ISO20022.Colr016001.AgreementFramework1Choice
        + BaseCcy  : String
        + AgrmtDt  : DateTime
        + AgrmtId  : String
        + AgrmtDtls  : String
    }
    ISO20022.Colr016001.Agreement4 *-- ISO20022.Colr016001.AgreementFramework1Choice
    class ISO20022.Colr016001.AgreementFramework1Choice {
        + PrtryId  : ISO20022.Colr016001.GenericIdentification30
        + AgrmtFrmwk  : String
    }
    ISO20022.Colr016001.AgreementFramework1Choice *-- ISO20022.Colr016001.GenericIdentification30
    class ISO20022.Colr016001.AgreementFramework1Code {
        NONR = 1
        ISDA = 2
        DERV = 3
        BBAA = 4
        FBAA = 5
    }
    class ISO20022.Colr016001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Colr016001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Colr016001.BlockChainAddressWallet3 *-- ISO20022.Colr016001.GenericIdentification30
    class ISO20022.Colr016001.BlockChainAddressWallet5 {
        + Nm  : String
        + Tp  : ISO20022.Colr016001.CollateralAccountIdentificationType3Choice
        + Id  : String
    }
    ISO20022.Colr016001.BlockChainAddressWallet5 *-- ISO20022.Colr016001.CollateralAccountIdentificationType3Choice
    class ISO20022.Colr016001.CCPMemberType1Code {
        SCMB = 1
        GCMB = 2
        FCMC = 3
        DCMB = 4
        CCPX = 5
        ACMB = 6
    }
    class ISO20022.Colr016001.CashCollateral4 {
        + Hrcut  : Decimal
        + CollVal  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + ValDt  : DateTime
        + MtrtyDt  : DateTime
        + BlckdAmt  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + DpstTp  : String
        + DpstAmt  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + AsstNb  : String
    }
    ISO20022.Colr016001.CashCollateral4 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.CashCollateral4 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.CashCollateral4 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    class ISO20022.Colr016001.Collateral53 {
        + CollValtn  : global::System.Collections.Generic.List~ISO20022.Colr016001.CollateralValuation13~
        + RptSummry  : ISO20022.Colr016001.Summary3
        + BlckChainAdrOrWllt  : ISO20022.Colr016001.BlockChainAddressWallet5
        + AcctId  : ISO20022.Colr016001.CollateralAccount3
    }
    ISO20022.Colr016001.Collateral53 *-- ISO20022.Colr016001.CollateralValuation13
    ISO20022.Colr016001.Collateral53 *-- ISO20022.Colr016001.Summary3
    ISO20022.Colr016001.Collateral53 *-- ISO20022.Colr016001.BlockChainAddressWallet5
    ISO20022.Colr016001.Collateral53 *-- ISO20022.Colr016001.CollateralAccount3
    class ISO20022.Colr016001.CollateralAccount3 {
        + Nm  : String
        + Tp  : ISO20022.Colr016001.CollateralAccountIdentificationType3Choice
        + Id  : String
    }
    ISO20022.Colr016001.CollateralAccount3 *-- ISO20022.Colr016001.CollateralAccountIdentificationType3Choice
    class ISO20022.Colr016001.CollateralAccountIdentificationType3Choice {
        + Prtry  : ISO20022.Colr016001.GenericIdentification36
        + Tp  : String
    }
    ISO20022.Colr016001.CollateralAccountIdentificationType3Choice *-- ISO20022.Colr016001.GenericIdentification36
    class ISO20022.Colr016001.CollateralAccountType1Code {
        DFLT = 1
        MGIN = 2
        LIPR = 3
        CLIE = 4
        HOUS = 5
    }
    class ISO20022.Colr016001.CollateralAmount1 {
        + FeesAndComssns  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + AcrdIntrstAmt  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + MktValAmt  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + RptdCcyAndAmt  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + CollAmt  : ISO20022.Colr016001.ActiveCurrencyAndAmount
    }
    ISO20022.Colr016001.CollateralAmount1 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.CollateralAmount1 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.CollateralAmount1 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.CollateralAmount1 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.CollateralAmount1 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    class ISO20022.Colr016001.CollateralAndExposureReportV05 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Colr016001.SupplementaryData1~
        + CollRpt  : global::System.Collections.Generic.List~ISO20022.Colr016001.Collateral53~
        + Agrmt  : ISO20022.Colr016001.Agreement4
        + Oblgtn  : ISO20022.Colr016001.Obligation11
        + Pgntn  : ISO20022.Colr016001.Pagination1
        + RptParams  : ISO20022.Colr016001.ReportParameters6
    }
    ISO20022.Colr016001.CollateralAndExposureReportV05 *-- ISO20022.Colr016001.SupplementaryData1
    ISO20022.Colr016001.CollateralAndExposureReportV05 *-- ISO20022.Colr016001.Collateral53
    ISO20022.Colr016001.CollateralAndExposureReportV05 *-- ISO20022.Colr016001.Agreement4
    ISO20022.Colr016001.CollateralAndExposureReportV05 *-- ISO20022.Colr016001.Obligation11
    ISO20022.Colr016001.CollateralAndExposureReportV05 *-- ISO20022.Colr016001.Pagination1
    ISO20022.Colr016001.CollateralAndExposureReportV05 *-- ISO20022.Colr016001.ReportParameters6
    class ISO20022.Colr016001.CollateralAppliedExcess1Code {
        EXCS = 1
        APLD = 2
    }
    class ISO20022.Colr016001.CollateralDirection1Code {
        CDPB = 1
        CDPA = 2
    }
    class ISO20022.Colr016001.CollateralOwnership3 {
        + ClntNm  : ISO20022.Colr016001.PartyIdentification178Choice
        + Prtry  : String
    }
    ISO20022.Colr016001.CollateralOwnership3 *-- ISO20022.Colr016001.PartyIdentification178Choice
    class ISO20022.Colr016001.CollateralType8Code {
        CCVR = 1
        CTCO = 2
        SECU = 3
        OTHR = 4
        LCRE = 5
        CASH = 6
        CTRC = 7
        CFTI = 8
        CFTD = 9
        CXCC = 10
        CEMC = 11
        CCCL = 12
        COMO = 13
    }
    class ISO20022.Colr016001.CollateralValuation13 {
        + OthrColl  : ISO20022.Colr016001.OtherCollateral10
        + CshColl  : ISO20022.Colr016001.CashCollateral4
        + SctiesColl  : ISO20022.Colr016001.SecuritiesCollateral13
        + AdjstdRate  : Decimal
        + CcyHrcut  : Decimal
        + XchgRate  : Decimal
        + DayCntBsis  : String
        + ValtnAmts  : ISO20022.Colr016001.CollateralAmount1
        + NbOfDaysAcrd  : Decimal
        + ApldXcssInd  : String
        + SttlmSts  : String
        + CollDrctn  : String
        + CollTp  : String
        + CollId  : String
    }
    ISO20022.Colr016001.CollateralValuation13 *-- ISO20022.Colr016001.OtherCollateral10
    ISO20022.Colr016001.CollateralValuation13 *-- ISO20022.Colr016001.CashCollateral4
    ISO20022.Colr016001.CollateralValuation13 *-- ISO20022.Colr016001.SecuritiesCollateral13
    ISO20022.Colr016001.CollateralValuation13 *-- ISO20022.Colr016001.CollateralAmount1
    class ISO20022.Colr016001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Colr016001.DateCode9Choice {
        + Prtry  : ISO20022.Colr016001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr016001.DateCode9Choice *-- ISO20022.Colr016001.GenericIdentification30
    class ISO20022.Colr016001.DateFormat14Choice {
        + DtCd  : ISO20022.Colr016001.DateCode9Choice
        + Dt  : DateTime
    }
    ISO20022.Colr016001.DateFormat14Choice *-- ISO20022.Colr016001.DateCode9Choice
    class ISO20022.Colr016001.DateType2Code {
        OPEN = 1
    }
    class ISO20022.Colr016001.DepositType1Code {
        CALL = 1
        FITE = 2
    }
    class ISO20022.Colr016001.EventFrequency6Code {
        ONDE = 1
        INDA = 2
        DAIL = 3
    }
    class ISO20022.Colr016001.ExposureType11Code {
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
    class ISO20022.Colr016001.ExposureType13Code {
        UDMS = 1
        TRCP = 2
        CBCO = 3
        EOMO = 4
        CRSP = 5
        CRTL = 6
        CRDS = 7
        COMM = 8
        CCPC = 9
        PAYM = 10
        BFWD = 11
        TRBD = 12
        EOMI = 13
        EOIM = 14
        EMLI = 15
        EMLO = 16
        ECFR = 17
        ECRT = 18
        TBAS = 19
        SWPT = 20
        ESCL = 21
        SCIE = 22
        SCIR = 23
        SHSL = 24
        SLEB = 25
        SCRP = 26
        SBSC = 27
        SLOA = 28
        RVPO = 29
        REPO = 30
        OTCD = 31
        MGLD = 32
        LIQU = 33
        OPTN = 34
        FUTR = 35
        FORW = 36
        FORX = 37
        FIXI = 38
        EXPT = 39
        EXTD = 40
        EQUS = 41
        EQPT = 42
        EQUI = 43
        CRPR = 44
        CCIR = 45
    }
    class ISO20022.Colr016001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Colr016001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Colr016001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Colr016001.GenericIdentification78 {
        + Id  : String
        + Tp  : ISO20022.Colr016001.GenericIdentification30
    }
    ISO20022.Colr016001.GenericIdentification78 *-- ISO20022.Colr016001.GenericIdentification30
    class ISO20022.Colr016001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Colr016001.InterestComputationMethod2Code {
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
    class ISO20022.Colr016001.NameAndAddress6 {
        + Adr  : ISO20022.Colr016001.PostalAddress2
        + Nm  : String
    }
    ISO20022.Colr016001.NameAndAddress6 *-- ISO20022.Colr016001.PostalAddress2
    class ISO20022.Colr016001.Obligation11 {
        + ValtnDt  : ISO20022.Colr016001.DateAndDateTime2Choice
        + XpsrTp  : String
        + BlckChainAdrOrWllt  : ISO20022.Colr016001.BlockChainAddressWallet5
        + CollAcctId  : ISO20022.Colr016001.CollateralAccount3
        + SvcgPtyB  : ISO20022.Colr016001.PartyIdentification178Choice
        + PtyB  : ISO20022.Colr016001.PartyIdentification242
        + SvcgPtyA  : ISO20022.Colr016001.PartyIdentification178Choice
        + PtyA  : ISO20022.Colr016001.PartyIdentification242
    }
    ISO20022.Colr016001.Obligation11 *-- ISO20022.Colr016001.DateAndDateTime2Choice
    ISO20022.Colr016001.Obligation11 *-- ISO20022.Colr016001.BlockChainAddressWallet5
    ISO20022.Colr016001.Obligation11 *-- ISO20022.Colr016001.CollateralAccount3
    ISO20022.Colr016001.Obligation11 *-- ISO20022.Colr016001.PartyIdentification178Choice
    ISO20022.Colr016001.Obligation11 *-- ISO20022.Colr016001.PartyIdentification242
    ISO20022.Colr016001.Obligation11 *-- ISO20022.Colr016001.PartyIdentification178Choice
    ISO20022.Colr016001.Obligation11 *-- ISO20022.Colr016001.PartyIdentification242
    class ISO20022.Colr016001.OtherCollateral10 {
        + BlckChainAdrOrWllt  : ISO20022.Colr016001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Colr016001.SecuritiesAccount19
        + SfkpgPlc  : ISO20022.Colr016001.SafekeepingPlaceFormat29Choice
        + CollVal  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + Hrcut  : Decimal
        + MktVal  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + ValDt  : DateTime
        + BlckdQty  : ISO20022.Colr016001.FinancialInstrumentQuantity33Choice
        + Issr  : ISO20022.Colr016001.PartyIdentification178Choice
        + LtdCvrgInd  : String
        + XpryDt  : ISO20022.Colr016001.DateFormat14Choice
        + IsseDt  : ISO20022.Colr016001.DateFormat14Choice
        + CollOwnrsh  : ISO20022.Colr016001.CollateralOwnership3
        + OthrTpOfColl  : ISO20022.Colr016001.OtherTypeOfCollateral3
        + GrntAmt  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + LttrOfCdtAmt  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + LttrOfCdtId  : String
        + AsstNb  : String
    }
    ISO20022.Colr016001.OtherCollateral10 *-- ISO20022.Colr016001.BlockChainAddressWallet3
    ISO20022.Colr016001.OtherCollateral10 *-- ISO20022.Colr016001.SecuritiesAccount19
    ISO20022.Colr016001.OtherCollateral10 *-- ISO20022.Colr016001.SafekeepingPlaceFormat29Choice
    ISO20022.Colr016001.OtherCollateral10 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.OtherCollateral10 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.OtherCollateral10 *-- ISO20022.Colr016001.FinancialInstrumentQuantity33Choice
    ISO20022.Colr016001.OtherCollateral10 *-- ISO20022.Colr016001.PartyIdentification178Choice
    ISO20022.Colr016001.OtherCollateral10 *-- ISO20022.Colr016001.DateFormat14Choice
    ISO20022.Colr016001.OtherCollateral10 *-- ISO20022.Colr016001.DateFormat14Choice
    ISO20022.Colr016001.OtherCollateral10 *-- ISO20022.Colr016001.CollateralOwnership3
    ISO20022.Colr016001.OtherCollateral10 *-- ISO20022.Colr016001.OtherTypeOfCollateral3
    ISO20022.Colr016001.OtherCollateral10 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.OtherCollateral10 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    class ISO20022.Colr016001.OtherIdentification1 {
        + Tp  : ISO20022.Colr016001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Colr016001.OtherIdentification1 *-- ISO20022.Colr016001.IdentificationSource3Choice
    class ISO20022.Colr016001.OtherTypeOfCollateral3 {
        + Qty  : ISO20022.Colr016001.FinancialInstrumentQuantity33Choice
        + Desc  : String
    }
    ISO20022.Colr016001.OtherTypeOfCollateral3 *-- ISO20022.Colr016001.FinancialInstrumentQuantity33Choice
    class ISO20022.Colr016001.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Colr016001.PartyIdentification178Choice {
        + NmAndAdr  : ISO20022.Colr016001.NameAndAddress6
        + PrtryId  : ISO20022.Colr016001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Colr016001.PartyIdentification178Choice *-- ISO20022.Colr016001.NameAndAddress6
    ISO20022.Colr016001.PartyIdentification178Choice *-- ISO20022.Colr016001.GenericIdentification36
    class ISO20022.Colr016001.PartyIdentification242 {
        + CCPMmbTp  : String
        + Id  : ISO20022.Colr016001.PartyIdentification178Choice
    }
    ISO20022.Colr016001.PartyIdentification242 *-- ISO20022.Colr016001.PartyIdentification178Choice
    class ISO20022.Colr016001.PostalAddress2 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCdId  : String
        + StrtNm  : String
    }
    class ISO20022.Colr016001.Price7 {
        + Val  : ISO20022.Colr016001.PriceRateOrAmount3Choice
        + Tp  : ISO20022.Colr016001.YieldedOrValueType1Choice
    }
    ISO20022.Colr016001.Price7 *-- ISO20022.Colr016001.PriceRateOrAmount3Choice
    ISO20022.Colr016001.Price7 *-- ISO20022.Colr016001.YieldedOrValueType1Choice
    class ISO20022.Colr016001.PriceRateOrAmount3Choice {
        + Amt  : ISO20022.Colr016001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Colr016001.PriceRateOrAmount3Choice *-- ISO20022.Colr016001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Colr016001.PriceValueType1Code {
        PARV = 1
        PREM = 2
        DISC = 3
    }
    class ISO20022.Colr016001.ReportParameters6 {
        + ClctnDt  : DateTime
        + RptCcy  : String
        + Frqcy  : String
        + RptDtAndTm  : ISO20022.Colr016001.DateAndDateTime2Choice
        + RptId  : String
    }
    ISO20022.Colr016001.ReportParameters6 *-- ISO20022.Colr016001.DateAndDateTime2Choice
    class ISO20022.Colr016001.ReturnExcessCash1 {
        + CshCollCcy  : String
        + RtrXcssCshTp  : ISO20022.Colr016001.ReturnExcessCash1Choice
    }
    ISO20022.Colr016001.ReturnExcessCash1 *-- ISO20022.Colr016001.ReturnExcessCash1Choice
    class ISO20022.Colr016001.ReturnExcessCash1Choice {
        + Prtry  : ISO20022.Colr016001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr016001.ReturnExcessCash1Choice *-- ISO20022.Colr016001.GenericIdentification30
    class ISO20022.Colr016001.ReturnExcessCash1Code {
        SSPD = 1
        RTDN = 2
        RTND = 3
    }
    class ISO20022.Colr016001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Colr016001.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Colr016001.SafekeepingPlaceFormat29Choice {
        + Prtry  : ISO20022.Colr016001.GenericIdentification78
        + TpAndId  : ISO20022.Colr016001.SafekeepingPlaceTypeAndIdentification1
        + Ctry  : String
        + Id  : ISO20022.Colr016001.SafekeepingPlaceTypeAndText8
    }
    ISO20022.Colr016001.SafekeepingPlaceFormat29Choice *-- ISO20022.Colr016001.GenericIdentification78
    ISO20022.Colr016001.SafekeepingPlaceFormat29Choice *-- ISO20022.Colr016001.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Colr016001.SafekeepingPlaceFormat29Choice *-- ISO20022.Colr016001.SafekeepingPlaceTypeAndText8
    class ISO20022.Colr016001.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Colr016001.SafekeepingPlaceTypeAndText8 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Colr016001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Colr016001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Colr016001.SecuritiesAccount19 *-- ISO20022.Colr016001.GenericIdentification30
    class ISO20022.Colr016001.SecuritiesCollateral13 {
        + SfkpgPlc  : ISO20022.Colr016001.SafekeepingPlaceFormat29Choice
        + BlckChainAdrOrWllt  : ISO20022.Colr016001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Colr016001.SecuritiesAccount19
        + ValDt  : DateTime
        + CollVal  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + Hrcut  : Decimal
        + MktVal  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + Pric  : ISO20022.Colr016001.Price7
        + BlckdQty  : ISO20022.Colr016001.FinancialInstrumentQuantity33Choice
        + Qty  : ISO20022.Colr016001.FinancialInstrumentQuantity33Choice
        + LtdCvrgInd  : String
        + CollOwnrsh  : ISO20022.Colr016001.CollateralOwnership3
        + MtrtyDt  : ISO20022.Colr016001.DateAndDateTime2Choice
        + SctyId  : ISO20022.Colr016001.SecurityIdentification19
        + AsstNb  : String
    }
    ISO20022.Colr016001.SecuritiesCollateral13 *-- ISO20022.Colr016001.SafekeepingPlaceFormat29Choice
    ISO20022.Colr016001.SecuritiesCollateral13 *-- ISO20022.Colr016001.BlockChainAddressWallet3
    ISO20022.Colr016001.SecuritiesCollateral13 *-- ISO20022.Colr016001.SecuritiesAccount19
    ISO20022.Colr016001.SecuritiesCollateral13 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.SecuritiesCollateral13 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.SecuritiesCollateral13 *-- ISO20022.Colr016001.Price7
    ISO20022.Colr016001.SecuritiesCollateral13 *-- ISO20022.Colr016001.FinancialInstrumentQuantity33Choice
    ISO20022.Colr016001.SecuritiesCollateral13 *-- ISO20022.Colr016001.FinancialInstrumentQuantity33Choice
    ISO20022.Colr016001.SecuritiesCollateral13 *-- ISO20022.Colr016001.CollateralOwnership3
    ISO20022.Colr016001.SecuritiesCollateral13 *-- ISO20022.Colr016001.DateAndDateTime2Choice
    ISO20022.Colr016001.SecuritiesCollateral13 *-- ISO20022.Colr016001.SecurityIdentification19
    class ISO20022.Colr016001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Colr016001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Colr016001.SecurityIdentification19 *-- ISO20022.Colr016001.OtherIdentification1
    class ISO20022.Colr016001.SettlementStatus3Code {
        NMAT = 1
        SPLT = 2
        STCR = 3
        STLD = 4
        RJCT = 5
        PSTL = 6
        MTCH = 7
        ARCF = 8
        ACCF = 9
        AAUT = 10
        ASTL = 11
    }
    class ISO20022.Colr016001.ShortLong1Code {
        LONG = 1
        SHOR = 2
    }
    class ISO20022.Colr016001.Summary3 {
        + SummryDtls  : ISO20022.Colr016001.SummaryAmounts2
        + ReqdSttlmDt  : DateTime
        + ValtnDtTm  : DateTime
        + NetXcssDfcitInd  : String
        + NetXcssDfcit  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + TtlValOfColl  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + XpsrTp  : String
        + XpsdAmtPtyB  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + XpsdAmtPtyA  : ISO20022.Colr016001.ActiveCurrencyAndAmount
    }
    ISO20022.Colr016001.Summary3 *-- ISO20022.Colr016001.SummaryAmounts2
    ISO20022.Colr016001.Summary3 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.Summary3 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.Summary3 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.Summary3 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    class ISO20022.Colr016001.SummaryAmounts2 {
        + TtlFees  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + TtlAcrdIntrstAmt  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + TtlPdgOutgngColl  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + TtlPdgIncmgColl  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + PrvsCollVal  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + PrvsXpsrVal  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + RndgAmt  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + MinTrfAmt  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + RtrXcssCshAndCollCcy  : global::System.Collections.Generic.List~ISO20022.Colr016001.ReturnExcessCash1~
        + CollReqrd  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + AdjstdXpsr  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + PreHrcutCollVal  : ISO20022.Colr016001.ActiveCurrencyAndAmount
        + ThrshldTp  : String
        + ThrshldAmt  : ISO20022.Colr016001.ActiveCurrencyAndAmount
    }
    ISO20022.Colr016001.SummaryAmounts2 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.SummaryAmounts2 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.SummaryAmounts2 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.SummaryAmounts2 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.SummaryAmounts2 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.SummaryAmounts2 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.SummaryAmounts2 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.SummaryAmounts2 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.SummaryAmounts2 *-- ISO20022.Colr016001.ReturnExcessCash1
    ISO20022.Colr016001.SummaryAmounts2 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.SummaryAmounts2 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.SummaryAmounts2 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    ISO20022.Colr016001.SummaryAmounts2 *-- ISO20022.Colr016001.ActiveCurrencyAndAmount
    class ISO20022.Colr016001.SupplementaryData1 {
        + Envlp  : ISO20022.Colr016001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Colr016001.SupplementaryData1 *-- ISO20022.Colr016001.SupplementaryDataEnvelope1
    class ISO20022.Colr016001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Colr016001.ThresholdType1Code {
        UNSE = 1
        SECU = 2
    }
    class ISO20022.Colr016001.YieldedOrValueType1Choice {
        + ValTp  : String
        + Yldd  : String
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

## Value ISO20022.Colr016001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Colr016001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Colr016001.Agreement4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AgrmtFrmwk|ISO20022.Colr016001.AgreementFramework1Choice||XmlElement()||
|+|BaseCcy|String||XmlElement()||
|+|AgrmtDt|DateTime||XmlElement()||
|+|AgrmtId|String||XmlElement()||
|+|AgrmtDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AgrmtFrmwk),validPattern("""BaseCcy""",BaseCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Colr016001.AgreementFramework1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Colr016001.GenericIdentification30||XmlElement()||
|+|AgrmtFrmwk|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validChoice(PrtryId,AgrmtFrmwk))|

---

## Enum ISO20022.Colr016001.AgreementFramework1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NONR|Int32||XmlEnum("""NONR""")|1|
||ISDA|Int32||XmlEnum("""ISDA""")|2|
||DERV|Int32||XmlEnum("""DERV""")|3|
||BBAA|Int32||XmlEnum("""BBAA""")|4|
||FBAA|Int32||XmlEnum("""FBAA""")|5|

---

## Value ISO20022.Colr016001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Colr016001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr016001.BlockChainAddressWallet5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Colr016001.CollateralAccountIdentificationType3Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Enum ISO20022.Colr016001.CCPMemberType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SCMB|Int32||XmlEnum("""SCMB""")|1|
||GCMB|Int32||XmlEnum("""GCMB""")|2|
||FCMC|Int32||XmlEnum("""FCMC""")|3|
||DCMB|Int32||XmlEnum("""DCMB""")|4|
||CCPX|Int32||XmlEnum("""CCPX""")|5|
||ACMB|Int32||XmlEnum("""ACMB""")|6|

---

## Value ISO20022.Colr016001.CashCollateral4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Hrcut|Decimal||XmlElement()||
|+|CollVal|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|BlckdAmt|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|DpstTp|String||XmlElement()||
|+|DpstAmt|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|AsstNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollVal),validElement(BlckdAmt),validElement(DpstAmt))|

---

## Value ISO20022.Colr016001.Collateral53


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CollValtn|global::System.Collections.Generic.List<ISO20022.Colr016001.CollateralValuation13>||XmlElement()||
|+|RptSummry|ISO20022.Colr016001.Summary3||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Colr016001.BlockChainAddressWallet5||XmlElement()||
|+|AcctId|ISO20022.Colr016001.CollateralAccount3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CollValtn""",CollValtn),validElement(CollValtn),validElement(RptSummry),validElement(BlckChainAdrOrWllt),validElement(AcctId))|

---

## Value ISO20022.Colr016001.CollateralAccount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Colr016001.CollateralAccountIdentificationType3Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr016001.CollateralAccountIdentificationType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr016001.GenericIdentification36||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Tp))|

---

## Enum ISO20022.Colr016001.CollateralAccountType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DFLT|Int32||XmlEnum("""DFLT""")|1|
||MGIN|Int32||XmlEnum("""MGIN""")|2|
||LIPR|Int32||XmlEnum("""LIPR""")|3|
||CLIE|Int32||XmlEnum("""CLIE""")|4|
||HOUS|Int32||XmlEnum("""HOUS""")|5|

---

## Value ISO20022.Colr016001.CollateralAmount1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FeesAndComssns|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|MktValAmt|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|RptdCcyAndAmt|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|CollAmt|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FeesAndComssns),validElement(AcrdIntrstAmt),validElement(MktValAmt),validElement(RptdCcyAndAmt),validElement(CollAmt))|

---

## Aspect ISO20022.Colr016001.CollateralAndExposureReportV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Colr016001.SupplementaryData1>||XmlElement()||
|+|CollRpt|global::System.Collections.Generic.List<ISO20022.Colr016001.Collateral53>||XmlElement()||
|+|Agrmt|ISO20022.Colr016001.Agreement4||XmlElement()||
|+|Oblgtn|ISO20022.Colr016001.Obligation11||XmlElement()||
|+|Pgntn|ISO20022.Colr016001.Pagination1||XmlElement()||
|+|RptParams|ISO20022.Colr016001.ReportParameters6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""CollRpt""",CollRpt),validList("""CollRpt""",CollRpt),validElement(CollRpt),validElement(Agrmt),validElement(Oblgtn),validElement(Pgntn),validElement(RptParams))|

---

## Enum ISO20022.Colr016001.CollateralAppliedExcess1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXCS|Int32||XmlEnum("""EXCS""")|1|
||APLD|Int32||XmlEnum("""APLD""")|2|

---

## Enum ISO20022.Colr016001.CollateralDirection1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CDPB|Int32||XmlEnum("""CDPB""")|1|
||CDPA|Int32||XmlEnum("""CDPA""")|2|

---

## Value ISO20022.Colr016001.CollateralOwnership3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClntNm|ISO20022.Colr016001.PartyIdentification178Choice||XmlElement()||
|+|Prtry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClntNm))|

---

## Enum ISO20022.Colr016001.CollateralType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CCVR|Int32||XmlEnum("""CCVR""")|1|
||CTCO|Int32||XmlEnum("""CTCO""")|2|
||SECU|Int32||XmlEnum("""SECU""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||LCRE|Int32||XmlEnum("""LCRE""")|5|
||CASH|Int32||XmlEnum("""CASH""")|6|
||CTRC|Int32||XmlEnum("""CTRC""")|7|
||CFTI|Int32||XmlEnum("""CFTI""")|8|
||CFTD|Int32||XmlEnum("""CFTD""")|9|
||CXCC|Int32||XmlEnum("""CXCC""")|10|
||CEMC|Int32||XmlEnum("""CEMC""")|11|
||CCCL|Int32||XmlEnum("""CCCL""")|12|
||COMO|Int32||XmlEnum("""COMO""")|13|

---

## Value ISO20022.Colr016001.CollateralValuation13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrColl|ISO20022.Colr016001.OtherCollateral10||XmlElement()||
|+|CshColl|ISO20022.Colr016001.CashCollateral4||XmlElement()||
|+|SctiesColl|ISO20022.Colr016001.SecuritiesCollateral13||XmlElement()||
|+|AdjstdRate|Decimal||XmlElement()||
|+|CcyHrcut|Decimal||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|DayCntBsis|String||XmlElement()||
|+|ValtnAmts|ISO20022.Colr016001.CollateralAmount1||XmlElement()||
|+|NbOfDaysAcrd|Decimal||XmlElement()||
|+|ApldXcssInd|String||XmlElement()||
|+|SttlmSts|String||XmlElement()||
|+|CollDrctn|String||XmlElement()||
|+|CollTp|String||XmlElement()||
|+|CollId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrColl),validElement(CshColl),validElement(SctiesColl),validElement(ValtnAmts))|

---

## Value ISO20022.Colr016001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Colr016001.DateCode9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr016001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr016001.DateFormat14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Colr016001.DateCode9Choice||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validChoice(DtCd,Dt))|

---

## Enum ISO20022.Colr016001.DateType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPEN|Int32||XmlEnum("""OPEN""")|1|

---

## Enum ISO20022.Colr016001.DepositType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CALL|Int32||XmlEnum("""CALL""")|1|
||FITE|Int32||XmlEnum("""FITE""")|2|

---

## Type ISO20022.Colr016001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CollAndXpsrRpt|ISO20022.Colr016001.CollateralAndExposureReportV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollAndXpsrRpt))|

---

## Enum ISO20022.Colr016001.EventFrequency6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONDE|Int32||XmlEnum("""ONDE""")|1|
||INDA|Int32||XmlEnum("""INDA""")|2|
||DAIL|Int32||XmlEnum("""DAIL""")|3|

---

## Enum ISO20022.Colr016001.ExposureType11Code


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

## Enum ISO20022.Colr016001.ExposureType13Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UDMS|Int32||XmlEnum("""UDMS""")|1|
||TRCP|Int32||XmlEnum("""TRCP""")|2|
||CBCO|Int32||XmlEnum("""CBCO""")|3|
||EOMO|Int32||XmlEnum("""EOMO""")|4|
||CRSP|Int32||XmlEnum("""CRSP""")|5|
||CRTL|Int32||XmlEnum("""CRTL""")|6|
||CRDS|Int32||XmlEnum("""CRDS""")|7|
||COMM|Int32||XmlEnum("""COMM""")|8|
||CCPC|Int32||XmlEnum("""CCPC""")|9|
||PAYM|Int32||XmlEnum("""PAYM""")|10|
||BFWD|Int32||XmlEnum("""BFWD""")|11|
||TRBD|Int32||XmlEnum("""TRBD""")|12|
||EOMI|Int32||XmlEnum("""EOMI""")|13|
||EOIM|Int32||XmlEnum("""EOIM""")|14|
||EMLI|Int32||XmlEnum("""EMLI""")|15|
||EMLO|Int32||XmlEnum("""EMLO""")|16|
||ECFR|Int32||XmlEnum("""ECFR""")|17|
||ECRT|Int32||XmlEnum("""ECRT""")|18|
||TBAS|Int32||XmlEnum("""TBAS""")|19|
||SWPT|Int32||XmlEnum("""SWPT""")|20|
||ESCL|Int32||XmlEnum("""ESCL""")|21|
||SCIE|Int32||XmlEnum("""SCIE""")|22|
||SCIR|Int32||XmlEnum("""SCIR""")|23|
||SHSL|Int32||XmlEnum("""SHSL""")|24|
||SLEB|Int32||XmlEnum("""SLEB""")|25|
||SCRP|Int32||XmlEnum("""SCRP""")|26|
||SBSC|Int32||XmlEnum("""SBSC""")|27|
||SLOA|Int32||XmlEnum("""SLOA""")|28|
||RVPO|Int32||XmlEnum("""RVPO""")|29|
||REPO|Int32||XmlEnum("""REPO""")|30|
||OTCD|Int32||XmlEnum("""OTCD""")|31|
||MGLD|Int32||XmlEnum("""MGLD""")|32|
||LIQU|Int32||XmlEnum("""LIQU""")|33|
||OPTN|Int32||XmlEnum("""OPTN""")|34|
||FUTR|Int32||XmlEnum("""FUTR""")|35|
||FORW|Int32||XmlEnum("""FORW""")|36|
||FORX|Int32||XmlEnum("""FORX""")|37|
||FIXI|Int32||XmlEnum("""FIXI""")|38|
||EXPT|Int32||XmlEnum("""EXPT""")|39|
||EXTD|Int32||XmlEnum("""EXTD""")|40|
||EQUS|Int32||XmlEnum("""EQUS""")|41|
||EQPT|Int32||XmlEnum("""EQPT""")|42|
||EQUI|Int32||XmlEnum("""EQUI""")|43|
||CRPR|Int32||XmlEnum("""CRPR""")|44|
||CCIR|Int32||XmlEnum("""CCIR""")|45|

---

## Value ISO20022.Colr016001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Colr016001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Colr016001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr016001.GenericIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Colr016001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr016001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Colr016001.InterestComputationMethod2Code


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

## Value ISO20022.Colr016001.NameAndAddress6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Colr016001.PostalAddress2||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Colr016001.Obligation11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValtnDt|ISO20022.Colr016001.DateAndDateTime2Choice||XmlElement()||
|+|XpsrTp|String||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Colr016001.BlockChainAddressWallet5||XmlElement()||
|+|CollAcctId|ISO20022.Colr016001.CollateralAccount3||XmlElement()||
|+|SvcgPtyB|ISO20022.Colr016001.PartyIdentification178Choice||XmlElement()||
|+|PtyB|ISO20022.Colr016001.PartyIdentification242||XmlElement()||
|+|SvcgPtyA|ISO20022.Colr016001.PartyIdentification178Choice||XmlElement()||
|+|PtyA|ISO20022.Colr016001.PartyIdentification242||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ValtnDt),validElement(BlckChainAdrOrWllt),validElement(CollAcctId),validElement(SvcgPtyB),validElement(PtyB),validElement(SvcgPtyA),validElement(PtyA))|

---

## Value ISO20022.Colr016001.OtherCollateral10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BlckChainAdrOrWllt|ISO20022.Colr016001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Colr016001.SecuritiesAccount19||XmlElement()||
|+|SfkpgPlc|ISO20022.Colr016001.SafekeepingPlaceFormat29Choice||XmlElement()||
|+|CollVal|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|Hrcut|Decimal||XmlElement()||
|+|MktVal|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|BlckdQty|ISO20022.Colr016001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|Issr|ISO20022.Colr016001.PartyIdentification178Choice||XmlElement()||
|+|LtdCvrgInd|String||XmlElement()||
|+|XpryDt|ISO20022.Colr016001.DateFormat14Choice||XmlElement()||
|+|IsseDt|ISO20022.Colr016001.DateFormat14Choice||XmlElement()||
|+|CollOwnrsh|ISO20022.Colr016001.CollateralOwnership3||XmlElement()||
|+|OthrTpOfColl|ISO20022.Colr016001.OtherTypeOfCollateral3||XmlElement()||
|+|GrntAmt|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|LttrOfCdtAmt|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|LttrOfCdtId|String||XmlElement()||
|+|AsstNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(SfkpgPlc),validElement(CollVal),validElement(MktVal),validElement(BlckdQty),validElement(Issr),validElement(XpryDt),validElement(IsseDt),validElement(CollOwnrsh),validElement(OthrTpOfColl),validElement(GrntAmt),validElement(LttrOfCdtAmt))|

---

## Value ISO20022.Colr016001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Colr016001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr016001.OtherTypeOfCollateral3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Colr016001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|Desc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Colr016001.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Colr016001.PartyIdentification178Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Colr016001.NameAndAddress6||XmlElement()||
|+|PrtryId|ISO20022.Colr016001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Colr016001.PartyIdentification242


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CCPMmbTp|String||XmlElement()||
|+|Id|ISO20022.Colr016001.PartyIdentification178Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Colr016001.PostalAddress2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCdId|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Colr016001.Price7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Colr016001.PriceRateOrAmount3Choice||XmlElement()||
|+|Tp|ISO20022.Colr016001.YieldedOrValueType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Colr016001.PriceRateOrAmount3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Colr016001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Enum ISO20022.Colr016001.PriceValueType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARV|Int32||XmlEnum("""PARV""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|

---

## Value ISO20022.Colr016001.ReportParameters6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClctnDt|DateTime||XmlElement()||
|+|RptCcy|String||XmlElement()||
|+|Frqcy|String||XmlElement()||
|+|RptDtAndTm|ISO20022.Colr016001.DateAndDateTime2Choice||XmlElement()||
|+|RptId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""RptCcy""",RptCcy,"""[A-Z]{3,3}"""),validElement(RptDtAndTm))|

---

## Value ISO20022.Colr016001.ReturnExcessCash1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshCollCcy|String||XmlElement()||
|+|RtrXcssCshTp|ISO20022.Colr016001.ReturnExcessCash1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CshCollCcy""",CshCollCcy,"""[A-Z]{3,3}"""),validElement(RtrXcssCshTp))|

---

## Value ISO20022.Colr016001.ReturnExcessCash1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr016001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Colr016001.ReturnExcessCash1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SSPD|Int32||XmlEnum("""SSPD""")|1|
||RTDN|Int32||XmlEnum("""RTDN""")|2|
||RTND|Int32||XmlEnum("""RTND""")|3|

---

## Enum ISO20022.Colr016001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Colr016001.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Colr016001.SafekeepingPlaceFormat29Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr016001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Colr016001.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Colr016001.SafekeepingPlaceTypeAndText8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,Ctry,Id))|

---

## Value ISO20022.Colr016001.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Colr016001.SafekeepingPlaceTypeAndText8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr016001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Colr016001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr016001.SecuritiesCollateral13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SfkpgPlc|ISO20022.Colr016001.SafekeepingPlaceFormat29Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Colr016001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Colr016001.SecuritiesAccount19||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|CollVal|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|Hrcut|Decimal||XmlElement()||
|+|MktVal|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|Pric|ISO20022.Colr016001.Price7||XmlElement()||
|+|BlckdQty|ISO20022.Colr016001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|Qty|ISO20022.Colr016001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|LtdCvrgInd|String||XmlElement()||
|+|CollOwnrsh|ISO20022.Colr016001.CollateralOwnership3||XmlElement()||
|+|MtrtyDt|ISO20022.Colr016001.DateAndDateTime2Choice||XmlElement()||
|+|SctyId|ISO20022.Colr016001.SecurityIdentification19||XmlElement()||
|+|AsstNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SfkpgPlc),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(CollVal),validElement(MktVal),validElement(Pric),validElement(BlckdQty),validElement(Qty),validElement(CollOwnrsh),validElement(MtrtyDt),validElement(SctyId))|

---

## Value ISO20022.Colr016001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Colr016001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Enum ISO20022.Colr016001.SettlementStatus3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NMAT|Int32||XmlEnum("""NMAT""")|1|
||SPLT|Int32||XmlEnum("""SPLT""")|2|
||STCR|Int32||XmlEnum("""STCR""")|3|
||STLD|Int32||XmlEnum("""STLD""")|4|
||RJCT|Int32||XmlEnum("""RJCT""")|5|
||PSTL|Int32||XmlEnum("""PSTL""")|6|
||MTCH|Int32||XmlEnum("""MTCH""")|7|
||ARCF|Int32||XmlEnum("""ARCF""")|8|
||ACCF|Int32||XmlEnum("""ACCF""")|9|
||AAUT|Int32||XmlEnum("""AAUT""")|10|
||ASTL|Int32||XmlEnum("""ASTL""")|11|

---

## Enum ISO20022.Colr016001.ShortLong1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LONG|Int32||XmlEnum("""LONG""")|1|
||SHOR|Int32||XmlEnum("""SHOR""")|2|

---

## Value ISO20022.Colr016001.Summary3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SummryDtls|ISO20022.Colr016001.SummaryAmounts2||XmlElement()||
|+|ReqdSttlmDt|DateTime||XmlElement()||
|+|ValtnDtTm|DateTime||XmlElement()||
|+|NetXcssDfcitInd|String||XmlElement()||
|+|NetXcssDfcit|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|TtlValOfColl|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|XpsrTp|String||XmlElement()||
|+|XpsdAmtPtyB|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|XpsdAmtPtyA|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SummryDtls),validElement(NetXcssDfcit),validElement(TtlValOfColl),validElement(XpsdAmtPtyB),validElement(XpsdAmtPtyA))|

---

## Value ISO20022.Colr016001.SummaryAmounts2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlFees|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|TtlAcrdIntrstAmt|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|TtlPdgOutgngColl|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|TtlPdgIncmgColl|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|PrvsCollVal|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|PrvsXpsrVal|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|RndgAmt|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|MinTrfAmt|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|RtrXcssCshAndCollCcy|global::System.Collections.Generic.List<ISO20022.Colr016001.ReturnExcessCash1>||XmlElement()||
|+|CollReqrd|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|AdjstdXpsr|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|PreHrcutCollVal|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|ThrshldTp|String||XmlElement()||
|+|ThrshldAmt|ISO20022.Colr016001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlFees),validElement(TtlAcrdIntrstAmt),validElement(TtlPdgOutgngColl),validElement(TtlPdgIncmgColl),validElement(PrvsCollVal),validElement(PrvsXpsrVal),validElement(RndgAmt),validElement(MinTrfAmt),validList("""RtrXcssCshAndCollCcy""",RtrXcssCshAndCollCcy),validElement(RtrXcssCshAndCollCcy),validElement(CollReqrd),validElement(AdjstdXpsr),validElement(PreHrcutCollVal),validElement(ThrshldAmt))|

---

## Value ISO20022.Colr016001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Colr016001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Colr016001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Colr016001.ThresholdType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNSE|Int32||XmlEnum("""UNSE""")|1|
||SECU|Int32||XmlEnum("""SECU""")|2|

---

## Value ISO20022.Colr016001.YieldedOrValueType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValTp|String||XmlElement()||
|+|Yldd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(ValTp,Yldd))|

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

