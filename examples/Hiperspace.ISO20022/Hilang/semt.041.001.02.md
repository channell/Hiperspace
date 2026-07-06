# semt.041.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Semt041001.AccountSubLevel11 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt041001.SupplementaryData1~
        + AcctSubLvl2Diff  : global::System.Collections.Generic.List~ISO20022.Semt041001.AggregateHoldingBalance2~
        + AcctSubLvl2  : global::System.Collections.Generic.List~ISO20022.Semt041001.AccountSubLevel12~
        + BalDtls  : global::System.Collections.Generic.List~ISO20022.Semt041001.AggregateHoldingBalance3~
        + BnfclOwnr  : global::System.Collections.Generic.List~ISO20022.Semt041001.BeneficialOwner2~
        + AcctSvcr  : ISO20022.Semt041001.PartyIdentification100
        + AcctOwnr  : ISO20022.Semt041001.PartyIdentification100
        + AcctId  : ISO20022.Semt041001.SecuritiesAccount19
    }
    ISO20022.Semt041001.AccountSubLevel11 *-- ISO20022.Semt041001.SupplementaryData1
    ISO20022.Semt041001.AccountSubLevel11 *-- ISO20022.Semt041001.AggregateHoldingBalance2
    ISO20022.Semt041001.AccountSubLevel11 *-- ISO20022.Semt041001.AccountSubLevel12
    ISO20022.Semt041001.AccountSubLevel11 *-- ISO20022.Semt041001.AggregateHoldingBalance3
    ISO20022.Semt041001.AccountSubLevel11 *-- ISO20022.Semt041001.BeneficialOwner2
    ISO20022.Semt041001.AccountSubLevel11 *-- ISO20022.Semt041001.PartyIdentification100
    ISO20022.Semt041001.AccountSubLevel11 *-- ISO20022.Semt041001.PartyIdentification100
    ISO20022.Semt041001.AccountSubLevel11 *-- ISO20022.Semt041001.SecuritiesAccount19
    class ISO20022.Semt041001.AccountSubLevel12 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt041001.SupplementaryData1~
        + AcctSubLvl3Diff  : global::System.Collections.Generic.List~ISO20022.Semt041001.AggregateHoldingBalance2~
        + AcctSubLvl3  : global::System.Collections.Generic.List~ISO20022.Semt041001.AccountSubLevel13~
        + BalDtls  : global::System.Collections.Generic.List~ISO20022.Semt041001.AggregateHoldingBalance3~
        + BnfclOwnr  : global::System.Collections.Generic.List~ISO20022.Semt041001.BeneficialOwner2~
        + AcctSvcr  : ISO20022.Semt041001.PartyIdentification100
        + AcctOwnr  : ISO20022.Semt041001.PartyIdentification100
        + AcctId  : ISO20022.Semt041001.SecuritiesAccount19
    }
    ISO20022.Semt041001.AccountSubLevel12 *-- ISO20022.Semt041001.SupplementaryData1
    ISO20022.Semt041001.AccountSubLevel12 *-- ISO20022.Semt041001.AggregateHoldingBalance2
    ISO20022.Semt041001.AccountSubLevel12 *-- ISO20022.Semt041001.AccountSubLevel13
    ISO20022.Semt041001.AccountSubLevel12 *-- ISO20022.Semt041001.AggregateHoldingBalance3
    ISO20022.Semt041001.AccountSubLevel12 *-- ISO20022.Semt041001.BeneficialOwner2
    ISO20022.Semt041001.AccountSubLevel12 *-- ISO20022.Semt041001.PartyIdentification100
    ISO20022.Semt041001.AccountSubLevel12 *-- ISO20022.Semt041001.PartyIdentification100
    ISO20022.Semt041001.AccountSubLevel12 *-- ISO20022.Semt041001.SecuritiesAccount19
    class ISO20022.Semt041001.AccountSubLevel13 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt041001.SupplementaryData1~
        + AcctSubLvl4Diff  : global::System.Collections.Generic.List~ISO20022.Semt041001.AggregateHoldingBalance2~
        + AcctSubLvl4  : global::System.Collections.Generic.List~ISO20022.Semt041001.AccountSubLevel14~
        + BalDtls  : global::System.Collections.Generic.List~ISO20022.Semt041001.AggregateHoldingBalance3~
        + BnfclOwnr  : global::System.Collections.Generic.List~ISO20022.Semt041001.BeneficialOwner2~
        + AcctSvcr  : ISO20022.Semt041001.PartyIdentification100
        + AcctOwnr  : ISO20022.Semt041001.PartyIdentification100
        + AcctId  : ISO20022.Semt041001.SecuritiesAccount19
    }
    ISO20022.Semt041001.AccountSubLevel13 *-- ISO20022.Semt041001.SupplementaryData1
    ISO20022.Semt041001.AccountSubLevel13 *-- ISO20022.Semt041001.AggregateHoldingBalance2
    ISO20022.Semt041001.AccountSubLevel13 *-- ISO20022.Semt041001.AccountSubLevel14
    ISO20022.Semt041001.AccountSubLevel13 *-- ISO20022.Semt041001.AggregateHoldingBalance3
    ISO20022.Semt041001.AccountSubLevel13 *-- ISO20022.Semt041001.BeneficialOwner2
    ISO20022.Semt041001.AccountSubLevel13 *-- ISO20022.Semt041001.PartyIdentification100
    ISO20022.Semt041001.AccountSubLevel13 *-- ISO20022.Semt041001.PartyIdentification100
    ISO20022.Semt041001.AccountSubLevel13 *-- ISO20022.Semt041001.SecuritiesAccount19
    class ISO20022.Semt041001.AccountSubLevel14 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt041001.SupplementaryData1~
        + AcctSubLvl5Diff  : global::System.Collections.Generic.List~ISO20022.Semt041001.AggregateHoldingBalance2~
        + AcctSubLvl5  : global::System.Collections.Generic.List~ISO20022.Semt041001.AccountSubLevel15~
        + BalDtls  : global::System.Collections.Generic.List~ISO20022.Semt041001.AggregateHoldingBalance3~
        + BnfclOwnr  : global::System.Collections.Generic.List~ISO20022.Semt041001.BeneficialOwner2~
        + AcctSvcr  : ISO20022.Semt041001.PartyIdentification100
        + AcctOwnr  : ISO20022.Semt041001.PartyIdentification100
        + AcctId  : ISO20022.Semt041001.SecuritiesAccount19
    }
    ISO20022.Semt041001.AccountSubLevel14 *-- ISO20022.Semt041001.SupplementaryData1
    ISO20022.Semt041001.AccountSubLevel14 *-- ISO20022.Semt041001.AggregateHoldingBalance2
    ISO20022.Semt041001.AccountSubLevel14 *-- ISO20022.Semt041001.AccountSubLevel15
    ISO20022.Semt041001.AccountSubLevel14 *-- ISO20022.Semt041001.AggregateHoldingBalance3
    ISO20022.Semt041001.AccountSubLevel14 *-- ISO20022.Semt041001.BeneficialOwner2
    ISO20022.Semt041001.AccountSubLevel14 *-- ISO20022.Semt041001.PartyIdentification100
    ISO20022.Semt041001.AccountSubLevel14 *-- ISO20022.Semt041001.PartyIdentification100
    ISO20022.Semt041001.AccountSubLevel14 *-- ISO20022.Semt041001.SecuritiesAccount19
    class ISO20022.Semt041001.AccountSubLevel15 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt041001.SupplementaryData1~
        + AcctSubLvl6Diff  : global::System.Collections.Generic.List~ISO20022.Semt041001.AggregateHoldingBalance2~
        + AcctSubLvl6  : global::System.Collections.Generic.List~ISO20022.Semt041001.AccountSubLevel16~
        + BalDtls  : global::System.Collections.Generic.List~ISO20022.Semt041001.AggregateHoldingBalance3~
        + BnfclOwnr  : global::System.Collections.Generic.List~ISO20022.Semt041001.BeneficialOwner2~
        + AcctSvcr  : ISO20022.Semt041001.PartyIdentification100
        + AcctOwnr  : ISO20022.Semt041001.PartyIdentification100
        + AcctId  : ISO20022.Semt041001.SecuritiesAccount19
    }
    ISO20022.Semt041001.AccountSubLevel15 *-- ISO20022.Semt041001.SupplementaryData1
    ISO20022.Semt041001.AccountSubLevel15 *-- ISO20022.Semt041001.AggregateHoldingBalance2
    ISO20022.Semt041001.AccountSubLevel15 *-- ISO20022.Semt041001.AccountSubLevel16
    ISO20022.Semt041001.AccountSubLevel15 *-- ISO20022.Semt041001.AggregateHoldingBalance3
    ISO20022.Semt041001.AccountSubLevel15 *-- ISO20022.Semt041001.BeneficialOwner2
    ISO20022.Semt041001.AccountSubLevel15 *-- ISO20022.Semt041001.PartyIdentification100
    ISO20022.Semt041001.AccountSubLevel15 *-- ISO20022.Semt041001.PartyIdentification100
    ISO20022.Semt041001.AccountSubLevel15 *-- ISO20022.Semt041001.SecuritiesAccount19
    class ISO20022.Semt041001.AccountSubLevel16 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt041001.SupplementaryData1~
        + AcctSubLvl7Diff  : global::System.Collections.Generic.List~ISO20022.Semt041001.AggregateHoldingBalance2~
        + AcctSubLvl7  : global::System.Collections.Generic.List~ISO20022.Semt041001.AccountSubLevel17~
        + BalDtls  : global::System.Collections.Generic.List~ISO20022.Semt041001.AggregateHoldingBalance3~
        + BnfclOwnr  : global::System.Collections.Generic.List~ISO20022.Semt041001.BeneficialOwner2~
        + AcctSvcr  : ISO20022.Semt041001.PartyIdentification100
        + AcctOwnr  : ISO20022.Semt041001.PartyIdentification100
        + AcctId  : ISO20022.Semt041001.SecuritiesAccount19
    }
    ISO20022.Semt041001.AccountSubLevel16 *-- ISO20022.Semt041001.SupplementaryData1
    ISO20022.Semt041001.AccountSubLevel16 *-- ISO20022.Semt041001.AggregateHoldingBalance2
    ISO20022.Semt041001.AccountSubLevel16 *-- ISO20022.Semt041001.AccountSubLevel17
    ISO20022.Semt041001.AccountSubLevel16 *-- ISO20022.Semt041001.AggregateHoldingBalance3
    ISO20022.Semt041001.AccountSubLevel16 *-- ISO20022.Semt041001.BeneficialOwner2
    ISO20022.Semt041001.AccountSubLevel16 *-- ISO20022.Semt041001.PartyIdentification100
    ISO20022.Semt041001.AccountSubLevel16 *-- ISO20022.Semt041001.PartyIdentification100
    ISO20022.Semt041001.AccountSubLevel16 *-- ISO20022.Semt041001.SecuritiesAccount19
    class ISO20022.Semt041001.AccountSubLevel17 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt041001.SupplementaryData1~
        + AcctSubLvl8Diff  : global::System.Collections.Generic.List~ISO20022.Semt041001.AggregateHoldingBalance2~
        + AcctSubLvl8  : global::System.Collections.Generic.List~ISO20022.Semt041001.AccountSubLevel18~
        + BalDtls  : global::System.Collections.Generic.List~ISO20022.Semt041001.AggregateHoldingBalance3~
        + BnfclOwnr  : global::System.Collections.Generic.List~ISO20022.Semt041001.BeneficialOwner2~
        + AcctSvcr  : ISO20022.Semt041001.PartyIdentification100
        + AcctOwnr  : ISO20022.Semt041001.PartyIdentification100
        + AcctId  : ISO20022.Semt041001.SecuritiesAccount19
    }
    ISO20022.Semt041001.AccountSubLevel17 *-- ISO20022.Semt041001.SupplementaryData1
    ISO20022.Semt041001.AccountSubLevel17 *-- ISO20022.Semt041001.AggregateHoldingBalance2
    ISO20022.Semt041001.AccountSubLevel17 *-- ISO20022.Semt041001.AccountSubLevel18
    ISO20022.Semt041001.AccountSubLevel17 *-- ISO20022.Semt041001.AggregateHoldingBalance3
    ISO20022.Semt041001.AccountSubLevel17 *-- ISO20022.Semt041001.BeneficialOwner2
    ISO20022.Semt041001.AccountSubLevel17 *-- ISO20022.Semt041001.PartyIdentification100
    ISO20022.Semt041001.AccountSubLevel17 *-- ISO20022.Semt041001.PartyIdentification100
    ISO20022.Semt041001.AccountSubLevel17 *-- ISO20022.Semt041001.SecuritiesAccount19
    class ISO20022.Semt041001.AccountSubLevel18 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt041001.SupplementaryData1~
        + AcctSubLvl9Diff  : global::System.Collections.Generic.List~ISO20022.Semt041001.AggregateHoldingBalance2~
        + AcctSubLvl9  : global::System.Collections.Generic.List~ISO20022.Semt041001.AccountSubLevel19~
        + BalDtls  : global::System.Collections.Generic.List~ISO20022.Semt041001.AggregateHoldingBalance3~
        + BnfclOwnr  : global::System.Collections.Generic.List~ISO20022.Semt041001.BeneficialOwner2~
        + AcctSvcr  : ISO20022.Semt041001.PartyIdentification100
        + AcctOwnr  : ISO20022.Semt041001.PartyIdentification100
        + AcctId  : ISO20022.Semt041001.SecuritiesAccount19
    }
    ISO20022.Semt041001.AccountSubLevel18 *-- ISO20022.Semt041001.SupplementaryData1
    ISO20022.Semt041001.AccountSubLevel18 *-- ISO20022.Semt041001.AggregateHoldingBalance2
    ISO20022.Semt041001.AccountSubLevel18 *-- ISO20022.Semt041001.AccountSubLevel19
    ISO20022.Semt041001.AccountSubLevel18 *-- ISO20022.Semt041001.AggregateHoldingBalance3
    ISO20022.Semt041001.AccountSubLevel18 *-- ISO20022.Semt041001.BeneficialOwner2
    ISO20022.Semt041001.AccountSubLevel18 *-- ISO20022.Semt041001.PartyIdentification100
    ISO20022.Semt041001.AccountSubLevel18 *-- ISO20022.Semt041001.PartyIdentification100
    ISO20022.Semt041001.AccountSubLevel18 *-- ISO20022.Semt041001.SecuritiesAccount19
    class ISO20022.Semt041001.AccountSubLevel19 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt041001.SupplementaryData1~
        + BalDtls  : global::System.Collections.Generic.List~ISO20022.Semt041001.AggregateHoldingBalance3~
        + BnfclOwnr  : global::System.Collections.Generic.List~ISO20022.Semt041001.BeneficialOwner2~
        + AcctSvcr  : ISO20022.Semt041001.PartyIdentification100
        + AcctOwnr  : ISO20022.Semt041001.PartyIdentification100
        + AcctId  : ISO20022.Semt041001.SecuritiesAccount19
    }
    ISO20022.Semt041001.AccountSubLevel19 *-- ISO20022.Semt041001.SupplementaryData1
    ISO20022.Semt041001.AccountSubLevel19 *-- ISO20022.Semt041001.AggregateHoldingBalance3
    ISO20022.Semt041001.AccountSubLevel19 *-- ISO20022.Semt041001.BeneficialOwner2
    ISO20022.Semt041001.AccountSubLevel19 *-- ISO20022.Semt041001.PartyIdentification100
    ISO20022.Semt041001.AccountSubLevel19 *-- ISO20022.Semt041001.PartyIdentification100
    ISO20022.Semt041001.AccountSubLevel19 *-- ISO20022.Semt041001.SecuritiesAccount19
    class ISO20022.Semt041001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt041001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Semt041001.AggregateHoldingBalance1 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt041001.SupplementaryData1~
        + BalForFinInstrm  : global::System.Collections.Generic.List~ISO20022.Semt041001.FinancialInstrumentAggregateBalance1~
        + HldgPhysTp  : String
        + HldgForm  : String
        + FinInstrmId  : ISO20022.Semt041001.SecurityIdentification19
    }
    ISO20022.Semt041001.AggregateHoldingBalance1 *-- ISO20022.Semt041001.SupplementaryData1
    ISO20022.Semt041001.AggregateHoldingBalance1 *-- ISO20022.Semt041001.FinancialInstrumentAggregateBalance1
    ISO20022.Semt041001.AggregateHoldingBalance1 *-- ISO20022.Semt041001.SecurityIdentification19
    class ISO20022.Semt041001.AggregateHoldingBalance2 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt041001.SupplementaryData1~
        + BalForFinInstrm  : global::System.Collections.Generic.List~ISO20022.Semt041001.FinancialInstrumentAggregateBalance1~
        + FinInstrmId  : ISO20022.Semt041001.SecurityIdentification19
    }
    ISO20022.Semt041001.AggregateHoldingBalance2 *-- ISO20022.Semt041001.SupplementaryData1
    ISO20022.Semt041001.AggregateHoldingBalance2 *-- ISO20022.Semt041001.FinancialInstrumentAggregateBalance1
    ISO20022.Semt041001.AggregateHoldingBalance2 *-- ISO20022.Semt041001.SecurityIdentification19
    class ISO20022.Semt041001.AggregateHoldingBalance3 {
        + Agt  : global::System.Collections.Generic.List~ISO20022.Semt041001.Intermediary29~
        + BalForAcct  : global::System.Collections.Generic.List~ISO20022.Semt041001.AggregateHoldingBalance1~
    }
    ISO20022.Semt041001.AggregateHoldingBalance3 *-- ISO20022.Semt041001.Intermediary29
    ISO20022.Semt041001.AggregateHoldingBalance3 *-- ISO20022.Semt041001.AggregateHoldingBalance1
    class ISO20022.Semt041001.AlternateIdentification4 {
        + IssrCtry  : String
        + XpryDt  : DateTime
        + IsseDt  : DateTime
        + Issr  : String
        + Tp  : ISO20022.Semt041001.OtherIdentification4Choice
        + Id  : String
    }
    ISO20022.Semt041001.AlternateIdentification4 *-- ISO20022.Semt041001.OtherIdentification4Choice
    class ISO20022.Semt041001.BeneficialOwner2 {
        + DclrtnDtls  : String
        + CertfctnTp  : ISO20022.Semt041001.BeneficiaryCertificationType9Choice
        + CertfctnInd  : String
        + NonDmclCtry  : String
        + DmclCtry  : String
        + Ntlty  : String
        + AddtlId  : ISO20022.Semt041001.AlternateIdentification4
        + BnfclOwnrId  : ISO20022.Semt041001.PartyIdentification100
    }
    ISO20022.Semt041001.BeneficialOwner2 *-- ISO20022.Semt041001.BeneficiaryCertificationType9Choice
    ISO20022.Semt041001.BeneficialOwner2 *-- ISO20022.Semt041001.AlternateIdentification4
    ISO20022.Semt041001.BeneficialOwner2 *-- ISO20022.Semt041001.PartyIdentification100
    class ISO20022.Semt041001.BeneficiaryCertificationType4Code {
        FRAC = 1
        PABD = 2
        PAPW = 3
        TRBD = 4
        QIBB = 5
        NCOM = 6
        FULL = 7
        NDOM = 8
        DOMI = 9
        ACCI = 10
    }
    class ISO20022.Semt041001.BeneficiaryCertificationType9Choice {
        + Prtry  : ISO20022.Semt041001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt041001.BeneficiaryCertificationType9Choice *-- ISO20022.Semt041001.GenericIdentification30
    class ISO20022.Semt041001.DateAndDateTimeChoice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Semt041001.DatePeriod1Choice {
        + FrDtToDt  : ISO20022.Semt041001.Period2
        + DtMnth  : String
        + Dt  : DateTime
    }
    ISO20022.Semt041001.DatePeriod1Choice *-- ISO20022.Semt041001.Period2
    class ISO20022.Semt041001.EventFrequency7Code {
        ONDE = 1
        OVNG = 2
        TWMN = 3
        TOWK = 4
        TOMN = 5
        QUTR = 6
        SEMI = 7
        WEEK = 8
        INDA = 9
        DAIL = 10
        MNTH = 11
        ADHO = 12
        YEAR = 13
    }
    class ISO20022.Semt041001.FinancialInstrumentAggregateBalance1 {
        + Pric  : global::System.Collections.Generic.List~ISO20022.Semt041001.Price6~
        + Hldgs  : ISO20022.Semt041001.FinancialInstrumentAggregateBalance1Choice
        + ItmDt  : DateTime
    }
    ISO20022.Semt041001.FinancialInstrumentAggregateBalance1 *-- ISO20022.Semt041001.Price6
    ISO20022.Semt041001.FinancialInstrumentAggregateBalance1 *-- ISO20022.Semt041001.FinancialInstrumentAggregateBalance1Choice
    class ISO20022.Semt041001.FinancialInstrumentAggregateBalance1Choice {
        + HldgBal  : ISO20022.Semt041001.FinancialInstrumentAggregateBalance2
        + HldgsInd  : String
    }
    ISO20022.Semt041001.FinancialInstrumentAggregateBalance1Choice *-- ISO20022.Semt041001.FinancialInstrumentAggregateBalance2
    class ISO20022.Semt041001.FinancialInstrumentAggregateBalance2 {
        + BalBrkdwn  : global::System.Collections.Generic.List~ISO20022.Semt041001.SubBalanceBreakdown1~
        + TraddBal  : ISO20022.Semt041001.FinancialInstrumentQuantity1Choice
        + SttldBal  : ISO20022.Semt041001.FinancialInstrumentQuantity1Choice
    }
    ISO20022.Semt041001.FinancialInstrumentAggregateBalance2 *-- ISO20022.Semt041001.SubBalanceBreakdown1
    ISO20022.Semt041001.FinancialInstrumentAggregateBalance2 *-- ISO20022.Semt041001.FinancialInstrumentQuantity1Choice
    ISO20022.Semt041001.FinancialInstrumentAggregateBalance2 *-- ISO20022.Semt041001.FinancialInstrumentQuantity1Choice
    class ISO20022.Semt041001.FinancialInstrumentQuantity1Choice {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Semt041001.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Semt041001.Frequency22Choice {
        + Prtry  : ISO20022.Semt041001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt041001.Frequency22Choice *-- ISO20022.Semt041001.GenericIdentification30
    class ISO20022.Semt041001.FrequencyGranularityType1Code {
        ENDY = 1
        EDAY = 2
        EFRT = 3
        EQRT = 4
        ESEM = 5
        EWEK = 6
        EMON = 7
    }
    class ISO20022.Semt041001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt041001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt041001.GenericIdentification56 {
        + Bal  : Decimal
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt041001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Semt041001.Intermediary29 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt041001.SupplementaryData1~
        + OrdrOrgtrElgblty  : String
        + Role  : ISO20022.Semt041001.Role5Choice
        + Id  : ISO20022.Semt041001.PartyIdentification100
    }
    ISO20022.Semt041001.Intermediary29 *-- ISO20022.Semt041001.SupplementaryData1
    ISO20022.Semt041001.Intermediary29 *-- ISO20022.Semt041001.Role5Choice
    ISO20022.Semt041001.Intermediary29 *-- ISO20022.Semt041001.PartyIdentification100
    class ISO20022.Semt041001.InvestmentFundRole2Code {
        TRAN = 1
        UCL2 = 2
        UCL1 = 3
        CONC = 4
        DIST = 5
        INTR = 6
        TRAG = 7
        REGI = 8
        FMCO = 9
    }
    class ISO20022.Semt041001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Semt041001.NameAndAddress5 {
        + Adr  : ISO20022.Semt041001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Semt041001.NameAndAddress5 *-- ISO20022.Semt041001.PostalAddress1
    class ISO20022.Semt041001.Number3Choice {
        + Lng  : String
        + Shrt  : String
    }
    class ISO20022.Semt041001.OrderOriginatorEligibility1Code {
        PROF = 1
        RETL = 2
        ELIG = 3
    }
    class ISO20022.Semt041001.OtherIdentification1 {
        + Tp  : ISO20022.Semt041001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Semt041001.OtherIdentification1 *-- ISO20022.Semt041001.IdentificationSource3Choice
    class ISO20022.Semt041001.OtherIdentification4Choice {
        + Prtry  : ISO20022.Semt041001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Semt041001.OtherIdentification4Choice *-- ISO20022.Semt041001.GenericIdentification36
    class ISO20022.Semt041001.Pagination {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Semt041001.PartyIdentification100 {
        + LEI  : String
        + Id  : ISO20022.Semt041001.PartyIdentification71Choice
    }
    ISO20022.Semt041001.PartyIdentification100 *-- ISO20022.Semt041001.PartyIdentification71Choice
    class ISO20022.Semt041001.PartyIdentification71Choice {
        + NmAndAdr  : ISO20022.Semt041001.NameAndAddress5
        + PrtryId  : ISO20022.Semt041001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Semt041001.PartyIdentification71Choice *-- ISO20022.Semt041001.NameAndAddress5
    ISO20022.Semt041001.PartyIdentification71Choice *-- ISO20022.Semt041001.GenericIdentification36
    class ISO20022.Semt041001.Period2 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Semt041001.PersonIdentificationType6Code {
        ITIN = 1
        GTIN = 2
        ATIN = 3
        GUNL = 4
        SRSA = 5
        SOCS = 6
        POCD = 7
        PASS = 8
        OTHR = 9
        NRIN = 10
        IDCD = 11
        EMID = 12
        DRLC = 13
        CPFA = 14
        AREG = 15
    }
    class ISO20022.Semt041001.PhysicalTransferType1Code {
        PHYS = 1
        DEMT = 2
    }
    class ISO20022.Semt041001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Semt041001.Price6 {
        + Src  : String
        + Tp  : String
        + RateOrAmt  : ISO20022.Semt041001.PriceRateOrAmountChoice
    }
    ISO20022.Semt041001.Price6 *-- ISO20022.Semt041001.PriceRateOrAmountChoice
    class ISO20022.Semt041001.PriceRateOrAmountChoice {
        + Amt  : ISO20022.Semt041001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Semt041001.PriceRateOrAmountChoice *-- ISO20022.Semt041001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Semt041001.PriceSource2Code {
        EXCH = 1
        VEND = 2
        THEO = 3
        FUND = 4
    }
    class ISO20022.Semt041001.Role5Choice {
        + Prtry  : ISO20022.Semt041001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Semt041001.Role5Choice *-- ISO20022.Semt041001.GenericIdentification36
    class ISO20022.Semt041001.SafekeepingAccount7 {
        + AcctSubLvl1Diff  : global::System.Collections.Generic.List~ISO20022.Semt041001.AggregateHoldingBalance2~
        + AcctSubLvl1  : global::System.Collections.Generic.List~ISO20022.Semt041001.AccountSubLevel11~
        + BalDtls  : global::System.Collections.Generic.List~ISO20022.Semt041001.AggregateHoldingBalance3~
        + BnfclOwnr  : global::System.Collections.Generic.List~ISO20022.Semt041001.BeneficialOwner2~
        + AcctSvcr  : ISO20022.Semt041001.PartyIdentification100
        + AcctOwnr  : ISO20022.Semt041001.PartyIdentification100
        + AcctId  : ISO20022.Semt041001.SecuritiesAccount19
    }
    ISO20022.Semt041001.SafekeepingAccount7 *-- ISO20022.Semt041001.AggregateHoldingBalance2
    ISO20022.Semt041001.SafekeepingAccount7 *-- ISO20022.Semt041001.AccountSubLevel11
    ISO20022.Semt041001.SafekeepingAccount7 *-- ISO20022.Semt041001.AggregateHoldingBalance3
    ISO20022.Semt041001.SafekeepingAccount7 *-- ISO20022.Semt041001.BeneficialOwner2
    ISO20022.Semt041001.SafekeepingAccount7 *-- ISO20022.Semt041001.PartyIdentification100
    ISO20022.Semt041001.SafekeepingAccount7 *-- ISO20022.Semt041001.PartyIdentification100
    ISO20022.Semt041001.SafekeepingAccount7 *-- ISO20022.Semt041001.SecuritiesAccount19
    class ISO20022.Semt041001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Semt041001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Semt041001.SecuritiesAccount19 *-- ISO20022.Semt041001.GenericIdentification30
    class ISO20022.Semt041001.SecuritiesBalanceTransparencyReportV02 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt041001.SupplementaryData1~
        + SfkpgAcctAndHldgs  : global::System.Collections.Generic.List~ISO20022.Semt041001.SafekeepingAccount7~
        + StmtGnlDtls  : ISO20022.Semt041001.Statement59
        + Pgntn  : ISO20022.Semt041001.Pagination
        + RcvrId  : ISO20022.Semt041001.PartyIdentification100
        + SndrId  : ISO20022.Semt041001.PartyIdentification100
        + MsgId  : ISO20022.Semt041001.MessageIdentification1
    }
    ISO20022.Semt041001.SecuritiesBalanceTransparencyReportV02 *-- ISO20022.Semt041001.SupplementaryData1
    ISO20022.Semt041001.SecuritiesBalanceTransparencyReportV02 *-- ISO20022.Semt041001.SafekeepingAccount7
    ISO20022.Semt041001.SecuritiesBalanceTransparencyReportV02 *-- ISO20022.Semt041001.Statement59
    ISO20022.Semt041001.SecuritiesBalanceTransparencyReportV02 *-- ISO20022.Semt041001.Pagination
    ISO20022.Semt041001.SecuritiesBalanceTransparencyReportV02 *-- ISO20022.Semt041001.PartyIdentification100
    ISO20022.Semt041001.SecuritiesBalanceTransparencyReportV02 *-- ISO20022.Semt041001.PartyIdentification100
    ISO20022.Semt041001.SecuritiesBalanceTransparencyReportV02 *-- ISO20022.Semt041001.MessageIdentification1
    class ISO20022.Semt041001.SecuritiesBalanceType14Code {
        GRP2 = 1
        GRP1 = 2
        WDOC = 3
        OTHR = 4
        RSTR = 5
        PLED = 6
        PENR = 7
        LORE = 8
        LODE = 9
        PEND = 10
        PECA = 11
        PEDA = 12
        BORE = 13
        BODE = 14
        REGO = 15
        LOAN = 16
        TRAN = 17
        DRAW = 18
        MARG = 19
        COLO = 20
        COLI = 21
        PNET = 22
        OPNT = 23
        BORR = 24
        BLOT = 25
        BLCA = 26
        BLOV = 27
        BLOK = 28
        BTRA = 29
        AWAS = 30
    }
    class ISO20022.Semt041001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Semt041001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Semt041001.SecurityIdentification19 *-- ISO20022.Semt041001.OtherIdentification1
    class ISO20022.Semt041001.SenderBusinessRole1Code {
        ASER = 1
        AOWN = 2
    }
    class ISO20022.Semt041001.Statement59 {
        + ActvtyInd  : String
        + UpdTp  : ISO20022.Semt041001.UpdateType4Choice
        + FrqcyGrnlrty  : String
        + Frqcy  : ISO20022.Semt041001.Frequency22Choice
        + StmtPrd  : ISO20022.Semt041001.DatePeriod1Choice
        + StmtDtTm  : ISO20022.Semt041001.DateAndDateTimeChoice
        + StmtId  : String
        + QryRef  : String
        + StmtNb  : ISO20022.Semt041001.Number3Choice
        + SndrBizRole  : String
    }
    ISO20022.Semt041001.Statement59 *-- ISO20022.Semt041001.UpdateType4Choice
    ISO20022.Semt041001.Statement59 *-- ISO20022.Semt041001.Frequency22Choice
    ISO20022.Semt041001.Statement59 *-- ISO20022.Semt041001.DatePeriod1Choice
    ISO20022.Semt041001.Statement59 *-- ISO20022.Semt041001.DateAndDateTimeChoice
    ISO20022.Semt041001.Statement59 *-- ISO20022.Semt041001.Number3Choice
    class ISO20022.Semt041001.StatementUpdateType1Code {
        DELT = 1
        COMP = 2
    }
    class ISO20022.Semt041001.SubBalanceBreakdown1 {
        + Qty  : ISO20022.Semt041001.SubBalanceQuantity5Choice
        + SubBalTp  : ISO20022.Semt041001.SubBalanceType9Choice
    }
    ISO20022.Semt041001.SubBalanceBreakdown1 *-- ISO20022.Semt041001.SubBalanceQuantity5Choice
    ISO20022.Semt041001.SubBalanceBreakdown1 *-- ISO20022.Semt041001.SubBalanceType9Choice
    class ISO20022.Semt041001.SubBalanceQuantity5Choice {
        + Prtry  : ISO20022.Semt041001.GenericIdentification56
        + Qty  : ISO20022.Semt041001.FinancialInstrumentQuantity1Choice
    }
    ISO20022.Semt041001.SubBalanceQuantity5Choice *-- ISO20022.Semt041001.GenericIdentification56
    ISO20022.Semt041001.SubBalanceQuantity5Choice *-- ISO20022.Semt041001.FinancialInstrumentQuantity1Choice
    class ISO20022.Semt041001.SubBalanceType9Choice {
        + Prtry  : ISO20022.Semt041001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt041001.SubBalanceType9Choice *-- ISO20022.Semt041001.GenericIdentification30
    class ISO20022.Semt041001.SupplementaryData1 {
        + Envlp  : ISO20022.Semt041001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Semt041001.SupplementaryData1 *-- ISO20022.Semt041001.SupplementaryDataEnvelope1
    class ISO20022.Semt041001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Semt041001.TypeOfPrice13Code {
        EGAV = 1
        ACTU = 2
        DDVR = 3
        GAVL = 4
        SWIC = 5
        NAVS = 6
        RINV = 7
        MIDD = 8
        SWNG = 9
        INTE = 10
        CANC = 11
        CREA = 12
        NAVL = 13
        OFFR = 14
        BIDE = 15
    }
    class ISO20022.Semt041001.UpdateType4Choice {
        + Prtry  : ISO20022.Semt041001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt041001.UpdateType4Choice *-- ISO20022.Semt041001.GenericIdentification30
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

## Value ISO20022.Semt041001.AccountSubLevel11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt041001.SupplementaryData1>||XmlElement()||
|+|AcctSubLvl2Diff|global::System.Collections.Generic.List<ISO20022.Semt041001.AggregateHoldingBalance2>||XmlElement()||
|+|AcctSubLvl2|global::System.Collections.Generic.List<ISO20022.Semt041001.AccountSubLevel12>||XmlElement()||
|+|BalDtls|global::System.Collections.Generic.List<ISO20022.Semt041001.AggregateHoldingBalance3>||XmlElement()||
|+|BnfclOwnr|global::System.Collections.Generic.List<ISO20022.Semt041001.BeneficialOwner2>||XmlElement()||
|+|AcctSvcr|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
|+|AcctOwnr|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
|+|AcctId|ISO20022.Semt041001.SecuritiesAccount19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""AcctSubLvl2Diff""",AcctSubLvl2Diff),validElement(AcctSubLvl2Diff),validList("""AcctSubLvl2""",AcctSubLvl2),validElement(AcctSubLvl2),validList("""BalDtls""",BalDtls),validElement(BalDtls),validList("""BnfclOwnr""",BnfclOwnr),validElement(BnfclOwnr),validElement(AcctSvcr),validElement(AcctOwnr),validElement(AcctId))|

---

## Value ISO20022.Semt041001.AccountSubLevel12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt041001.SupplementaryData1>||XmlElement()||
|+|AcctSubLvl3Diff|global::System.Collections.Generic.List<ISO20022.Semt041001.AggregateHoldingBalance2>||XmlElement()||
|+|AcctSubLvl3|global::System.Collections.Generic.List<ISO20022.Semt041001.AccountSubLevel13>||XmlElement()||
|+|BalDtls|global::System.Collections.Generic.List<ISO20022.Semt041001.AggregateHoldingBalance3>||XmlElement()||
|+|BnfclOwnr|global::System.Collections.Generic.List<ISO20022.Semt041001.BeneficialOwner2>||XmlElement()||
|+|AcctSvcr|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
|+|AcctOwnr|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
|+|AcctId|ISO20022.Semt041001.SecuritiesAccount19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""AcctSubLvl3Diff""",AcctSubLvl3Diff),validElement(AcctSubLvl3Diff),validList("""AcctSubLvl3""",AcctSubLvl3),validElement(AcctSubLvl3),validList("""BalDtls""",BalDtls),validElement(BalDtls),validList("""BnfclOwnr""",BnfclOwnr),validElement(BnfclOwnr),validElement(AcctSvcr),validElement(AcctOwnr),validElement(AcctId))|

---

## Value ISO20022.Semt041001.AccountSubLevel13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt041001.SupplementaryData1>||XmlElement()||
|+|AcctSubLvl4Diff|global::System.Collections.Generic.List<ISO20022.Semt041001.AggregateHoldingBalance2>||XmlElement()||
|+|AcctSubLvl4|global::System.Collections.Generic.List<ISO20022.Semt041001.AccountSubLevel14>||XmlElement()||
|+|BalDtls|global::System.Collections.Generic.List<ISO20022.Semt041001.AggregateHoldingBalance3>||XmlElement()||
|+|BnfclOwnr|global::System.Collections.Generic.List<ISO20022.Semt041001.BeneficialOwner2>||XmlElement()||
|+|AcctSvcr|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
|+|AcctOwnr|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
|+|AcctId|ISO20022.Semt041001.SecuritiesAccount19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""AcctSubLvl4Diff""",AcctSubLvl4Diff),validElement(AcctSubLvl4Diff),validList("""AcctSubLvl4""",AcctSubLvl4),validElement(AcctSubLvl4),validList("""BalDtls""",BalDtls),validElement(BalDtls),validList("""BnfclOwnr""",BnfclOwnr),validElement(BnfclOwnr),validElement(AcctSvcr),validElement(AcctOwnr),validElement(AcctId))|

---

## Value ISO20022.Semt041001.AccountSubLevel14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt041001.SupplementaryData1>||XmlElement()||
|+|AcctSubLvl5Diff|global::System.Collections.Generic.List<ISO20022.Semt041001.AggregateHoldingBalance2>||XmlElement()||
|+|AcctSubLvl5|global::System.Collections.Generic.List<ISO20022.Semt041001.AccountSubLevel15>||XmlElement()||
|+|BalDtls|global::System.Collections.Generic.List<ISO20022.Semt041001.AggregateHoldingBalance3>||XmlElement()||
|+|BnfclOwnr|global::System.Collections.Generic.List<ISO20022.Semt041001.BeneficialOwner2>||XmlElement()||
|+|AcctSvcr|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
|+|AcctOwnr|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
|+|AcctId|ISO20022.Semt041001.SecuritiesAccount19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""AcctSubLvl5Diff""",AcctSubLvl5Diff),validElement(AcctSubLvl5Diff),validList("""AcctSubLvl5""",AcctSubLvl5),validElement(AcctSubLvl5),validList("""BalDtls""",BalDtls),validElement(BalDtls),validList("""BnfclOwnr""",BnfclOwnr),validElement(BnfclOwnr),validElement(AcctSvcr),validElement(AcctOwnr),validElement(AcctId))|

---

## Value ISO20022.Semt041001.AccountSubLevel15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt041001.SupplementaryData1>||XmlElement()||
|+|AcctSubLvl6Diff|global::System.Collections.Generic.List<ISO20022.Semt041001.AggregateHoldingBalance2>||XmlElement()||
|+|AcctSubLvl6|global::System.Collections.Generic.List<ISO20022.Semt041001.AccountSubLevel16>||XmlElement()||
|+|BalDtls|global::System.Collections.Generic.List<ISO20022.Semt041001.AggregateHoldingBalance3>||XmlElement()||
|+|BnfclOwnr|global::System.Collections.Generic.List<ISO20022.Semt041001.BeneficialOwner2>||XmlElement()||
|+|AcctSvcr|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
|+|AcctOwnr|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
|+|AcctId|ISO20022.Semt041001.SecuritiesAccount19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""AcctSubLvl6Diff""",AcctSubLvl6Diff),validElement(AcctSubLvl6Diff),validList("""AcctSubLvl6""",AcctSubLvl6),validElement(AcctSubLvl6),validList("""BalDtls""",BalDtls),validElement(BalDtls),validList("""BnfclOwnr""",BnfclOwnr),validElement(BnfclOwnr),validElement(AcctSvcr),validElement(AcctOwnr),validElement(AcctId))|

---

## Value ISO20022.Semt041001.AccountSubLevel16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt041001.SupplementaryData1>||XmlElement()||
|+|AcctSubLvl7Diff|global::System.Collections.Generic.List<ISO20022.Semt041001.AggregateHoldingBalance2>||XmlElement()||
|+|AcctSubLvl7|global::System.Collections.Generic.List<ISO20022.Semt041001.AccountSubLevel17>||XmlElement()||
|+|BalDtls|global::System.Collections.Generic.List<ISO20022.Semt041001.AggregateHoldingBalance3>||XmlElement()||
|+|BnfclOwnr|global::System.Collections.Generic.List<ISO20022.Semt041001.BeneficialOwner2>||XmlElement()||
|+|AcctSvcr|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
|+|AcctOwnr|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
|+|AcctId|ISO20022.Semt041001.SecuritiesAccount19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""AcctSubLvl7Diff""",AcctSubLvl7Diff),validElement(AcctSubLvl7Diff),validList("""AcctSubLvl7""",AcctSubLvl7),validElement(AcctSubLvl7),validList("""BalDtls""",BalDtls),validElement(BalDtls),validList("""BnfclOwnr""",BnfclOwnr),validElement(BnfclOwnr),validElement(AcctSvcr),validElement(AcctOwnr),validElement(AcctId))|

---

## Value ISO20022.Semt041001.AccountSubLevel17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt041001.SupplementaryData1>||XmlElement()||
|+|AcctSubLvl8Diff|global::System.Collections.Generic.List<ISO20022.Semt041001.AggregateHoldingBalance2>||XmlElement()||
|+|AcctSubLvl8|global::System.Collections.Generic.List<ISO20022.Semt041001.AccountSubLevel18>||XmlElement()||
|+|BalDtls|global::System.Collections.Generic.List<ISO20022.Semt041001.AggregateHoldingBalance3>||XmlElement()||
|+|BnfclOwnr|global::System.Collections.Generic.List<ISO20022.Semt041001.BeneficialOwner2>||XmlElement()||
|+|AcctSvcr|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
|+|AcctOwnr|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
|+|AcctId|ISO20022.Semt041001.SecuritiesAccount19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""AcctSubLvl8Diff""",AcctSubLvl8Diff),validElement(AcctSubLvl8Diff),validList("""AcctSubLvl8""",AcctSubLvl8),validElement(AcctSubLvl8),validList("""BalDtls""",BalDtls),validElement(BalDtls),validList("""BnfclOwnr""",BnfclOwnr),validElement(BnfclOwnr),validElement(AcctSvcr),validElement(AcctOwnr),validElement(AcctId))|

---

## Value ISO20022.Semt041001.AccountSubLevel18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt041001.SupplementaryData1>||XmlElement()||
|+|AcctSubLvl9Diff|global::System.Collections.Generic.List<ISO20022.Semt041001.AggregateHoldingBalance2>||XmlElement()||
|+|AcctSubLvl9|global::System.Collections.Generic.List<ISO20022.Semt041001.AccountSubLevel19>||XmlElement()||
|+|BalDtls|global::System.Collections.Generic.List<ISO20022.Semt041001.AggregateHoldingBalance3>||XmlElement()||
|+|BnfclOwnr|global::System.Collections.Generic.List<ISO20022.Semt041001.BeneficialOwner2>||XmlElement()||
|+|AcctSvcr|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
|+|AcctOwnr|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
|+|AcctId|ISO20022.Semt041001.SecuritiesAccount19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""AcctSubLvl9Diff""",AcctSubLvl9Diff),validElement(AcctSubLvl9Diff),validList("""AcctSubLvl9""",AcctSubLvl9),validElement(AcctSubLvl9),validList("""BalDtls""",BalDtls),validElement(BalDtls),validList("""BnfclOwnr""",BnfclOwnr),validElement(BnfclOwnr),validElement(AcctSvcr),validElement(AcctOwnr),validElement(AcctId))|

---

## Value ISO20022.Semt041001.AccountSubLevel19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt041001.SupplementaryData1>||XmlElement()||
|+|BalDtls|global::System.Collections.Generic.List<ISO20022.Semt041001.AggregateHoldingBalance3>||XmlElement()||
|+|BnfclOwnr|global::System.Collections.Generic.List<ISO20022.Semt041001.BeneficialOwner2>||XmlElement()||
|+|AcctSvcr|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
|+|AcctOwnr|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
|+|AcctId|ISO20022.Semt041001.SecuritiesAccount19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""BalDtls""",BalDtls),validElement(BalDtls),validList("""BnfclOwnr""",BnfclOwnr),validElement(BnfclOwnr),validElement(AcctSvcr),validElement(AcctOwnr),validElement(AcctId))|

---

## Value ISO20022.Semt041001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Semt041001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Semt041001.AggregateHoldingBalance1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt041001.SupplementaryData1>||XmlElement()||
|+|BalForFinInstrm|global::System.Collections.Generic.List<ISO20022.Semt041001.FinancialInstrumentAggregateBalance1>||XmlElement()||
|+|HldgPhysTp|String||XmlElement()||
|+|HldgForm|String||XmlElement()||
|+|FinInstrmId|ISO20022.Semt041001.SecurityIdentification19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""BalForFinInstrm""",BalForFinInstrm),validList("""BalForFinInstrm""",BalForFinInstrm),validElement(BalForFinInstrm),validElement(FinInstrmId))|

---

## Value ISO20022.Semt041001.AggregateHoldingBalance2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt041001.SupplementaryData1>||XmlElement()||
|+|BalForFinInstrm|global::System.Collections.Generic.List<ISO20022.Semt041001.FinancialInstrumentAggregateBalance1>||XmlElement()||
|+|FinInstrmId|ISO20022.Semt041001.SecurityIdentification19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""BalForFinInstrm""",BalForFinInstrm),validList("""BalForFinInstrm""",BalForFinInstrm),validElement(BalForFinInstrm),validElement(FinInstrmId))|

---

## Value ISO20022.Semt041001.AggregateHoldingBalance3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Agt|global::System.Collections.Generic.List<ISO20022.Semt041001.Intermediary29>||XmlElement()||
|+|BalForAcct|global::System.Collections.Generic.List<ISO20022.Semt041001.AggregateHoldingBalance1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Agt""",Agt),validElement(Agt),validRequired("""BalForAcct""",BalForAcct),validList("""BalForAcct""",BalForAcct),validElement(BalForAcct))|

---

## Value ISO20022.Semt041001.AlternateIdentification4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IssrCtry|String||XmlElement()||
|+|XpryDt|DateTime||XmlElement()||
|+|IsseDt|DateTime||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Tp|ISO20022.Semt041001.OtherIdentification4Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""IssrCtry""",IssrCtry,"""[A-Z]{2,2}"""),validElement(Tp))|

---

## Value ISO20022.Semt041001.BeneficialOwner2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DclrtnDtls|String||XmlElement()||
|+|CertfctnTp|ISO20022.Semt041001.BeneficiaryCertificationType9Choice||XmlElement()||
|+|CertfctnInd|String||XmlElement()||
|+|NonDmclCtry|String||XmlElement()||
|+|DmclCtry|String||XmlElement()||
|+|Ntlty|String||XmlElement()||
|+|AddtlId|ISO20022.Semt041001.AlternateIdentification4||XmlElement()||
|+|BnfclOwnrId|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CertfctnTp),validPattern("""NonDmclCtry""",NonDmclCtry,"""[A-Z]{2,2}"""),validPattern("""DmclCtry""",DmclCtry,"""[A-Z]{2,2}"""),validPattern("""Ntlty""",Ntlty,"""[A-Z]{2,2}"""),validElement(AddtlId),validElement(BnfclOwnrId))|

---

## Enum ISO20022.Semt041001.BeneficiaryCertificationType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRAC|Int32||XmlEnum("""FRAC""")|1|
||PABD|Int32||XmlEnum("""PABD""")|2|
||PAPW|Int32||XmlEnum("""PAPW""")|3|
||TRBD|Int32||XmlEnum("""TRBD""")|4|
||QIBB|Int32||XmlEnum("""QIBB""")|5|
||NCOM|Int32||XmlEnum("""NCOM""")|6|
||FULL|Int32||XmlEnum("""FULL""")|7|
||NDOM|Int32||XmlEnum("""NDOM""")|8|
||DOMI|Int32||XmlEnum("""DOMI""")|9|
||ACCI|Int32||XmlEnum("""ACCI""")|10|

---

## Value ISO20022.Semt041001.BeneficiaryCertificationType9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt041001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt041001.DateAndDateTimeChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Semt041001.DatePeriod1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrDtToDt|ISO20022.Semt041001.Period2||XmlElement()||
|+|DtMnth|String||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrDtToDt),validChoice(FrDtToDt,DtMnth,Dt))|

---

## Type ISO20022.Semt041001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesBalTrnsprncyRpt|ISO20022.Semt041001.SecuritiesBalanceTransparencyReportV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesBalTrnsprncyRpt))|

---

## Enum ISO20022.Semt041001.EventFrequency7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONDE|Int32||XmlEnum("""ONDE""")|1|
||OVNG|Int32||XmlEnum("""OVNG""")|2|
||TWMN|Int32||XmlEnum("""TWMN""")|3|
||TOWK|Int32||XmlEnum("""TOWK""")|4|
||TOMN|Int32||XmlEnum("""TOMN""")|5|
||QUTR|Int32||XmlEnum("""QUTR""")|6|
||SEMI|Int32||XmlEnum("""SEMI""")|7|
||WEEK|Int32||XmlEnum("""WEEK""")|8|
||INDA|Int32||XmlEnum("""INDA""")|9|
||DAIL|Int32||XmlEnum("""DAIL""")|10|
||MNTH|Int32||XmlEnum("""MNTH""")|11|
||ADHO|Int32||XmlEnum("""ADHO""")|12|
||YEAR|Int32||XmlEnum("""YEAR""")|13|

---

## Value ISO20022.Semt041001.FinancialInstrumentAggregateBalance1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pric|global::System.Collections.Generic.List<ISO20022.Semt041001.Price6>||XmlElement()||
|+|Hldgs|ISO20022.Semt041001.FinancialInstrumentAggregateBalance1Choice||XmlElement()||
|+|ItmDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Pric""",Pric),validElement(Pric),validElement(Hldgs))|

---

## Value ISO20022.Semt041001.FinancialInstrumentAggregateBalance1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HldgBal|ISO20022.Semt041001.FinancialInstrumentAggregateBalance2||XmlElement()||
|+|HldgsInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(HldgBal),validChoice(HldgBal,HldgsInd))|

---

## Value ISO20022.Semt041001.FinancialInstrumentAggregateBalance2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BalBrkdwn|global::System.Collections.Generic.List<ISO20022.Semt041001.SubBalanceBreakdown1>||XmlElement()||
|+|TraddBal|ISO20022.Semt041001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|SttldBal|ISO20022.Semt041001.FinancialInstrumentQuantity1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""BalBrkdwn""",BalBrkdwn),validElement(BalBrkdwn),validElement(TraddBal),validElement(SttldBal))|

---

## Value ISO20022.Semt041001.FinancialInstrumentQuantity1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(AmtsdVal,FaceAmt,Unit))|

---

## Enum ISO20022.Semt041001.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Semt041001.Frequency22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt041001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt041001.FrequencyGranularityType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ENDY|Int32||XmlEnum("""ENDY""")|1|
||EDAY|Int32||XmlEnum("""EDAY""")|2|
||EFRT|Int32||XmlEnum("""EFRT""")|3|
||EQRT|Int32||XmlEnum("""EQRT""")|4|
||ESEM|Int32||XmlEnum("""ESEM""")|5|
||EWEK|Int32||XmlEnum("""EWEK""")|6|
||EMON|Int32||XmlEnum("""EMON""")|7|

---

## Value ISO20022.Semt041001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Semt041001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt041001.GenericIdentification56


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bal|Decimal||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Semt041001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt041001.Intermediary29


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt041001.SupplementaryData1>||XmlElement()||
|+|OrdrOrgtrElgblty|String||XmlElement()||
|+|Role|ISO20022.Semt041001.Role5Choice||XmlElement()||
|+|Id|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Role),validElement(Id))|

---

## Enum ISO20022.Semt041001.InvestmentFundRole2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRAN|Int32||XmlEnum("""TRAN""")|1|
||UCL2|Int32||XmlEnum("""UCL2""")|2|
||UCL1|Int32||XmlEnum("""UCL1""")|3|
||CONC|Int32||XmlEnum("""CONC""")|4|
||DIST|Int32||XmlEnum("""DIST""")|5|
||INTR|Int32||XmlEnum("""INTR""")|6|
||TRAG|Int32||XmlEnum("""TRAG""")|7|
||REGI|Int32||XmlEnum("""REGI""")|8|
||FMCO|Int32||XmlEnum("""FMCO""")|9|

---

## Value ISO20022.Semt041001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt041001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Semt041001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Semt041001.Number3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|String||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lng""",Lng,"""[0-9]{5}"""),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Enum ISO20022.Semt041001.OrderOriginatorEligibility1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PROF|Int32||XmlEnum("""PROF""")|1|
||RETL|Int32||XmlEnum("""RETL""")|2|
||ELIG|Int32||XmlEnum("""ELIG""")|3|

---

## Value ISO20022.Semt041001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Semt041001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Semt041001.OtherIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt041001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt041001.Pagination


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Semt041001.PartyIdentification100


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Semt041001.PartyIdentification71Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Semt041001.PartyIdentification71Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Semt041001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Semt041001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Semt041001.Period2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Semt041001.PersonIdentificationType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ITIN|Int32||XmlEnum("""ITIN""")|1|
||GTIN|Int32||XmlEnum("""GTIN""")|2|
||ATIN|Int32||XmlEnum("""ATIN""")|3|
||GUNL|Int32||XmlEnum("""GUNL""")|4|
||SRSA|Int32||XmlEnum("""SRSA""")|5|
||SOCS|Int32||XmlEnum("""SOCS""")|6|
||POCD|Int32||XmlEnum("""POCD""")|7|
||PASS|Int32||XmlEnum("""PASS""")|8|
||OTHR|Int32||XmlEnum("""OTHR""")|9|
||NRIN|Int32||XmlEnum("""NRIN""")|10|
||IDCD|Int32||XmlEnum("""IDCD""")|11|
||EMID|Int32||XmlEnum("""EMID""")|12|
||DRLC|Int32||XmlEnum("""DRLC""")|13|
||CPFA|Int32||XmlEnum("""CPFA""")|14|
||AREG|Int32||XmlEnum("""AREG""")|15|

---

## Enum ISO20022.Semt041001.PhysicalTransferType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHYS|Int32||XmlEnum("""PHYS""")|1|
||DEMT|Int32||XmlEnum("""DEMT""")|2|

---

## Value ISO20022.Semt041001.PostalAddress1


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

## Value ISO20022.Semt041001.Price6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Src|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|RateOrAmt|ISO20022.Semt041001.PriceRateOrAmountChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateOrAmt))|

---

## Value ISO20022.Semt041001.PriceRateOrAmountChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Semt041001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Enum ISO20022.Semt041001.PriceSource2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXCH|Int32||XmlEnum("""EXCH""")|1|
||VEND|Int32||XmlEnum("""VEND""")|2|
||THEO|Int32||XmlEnum("""THEO""")|3|
||FUND|Int32||XmlEnum("""FUND""")|4|

---

## Value ISO20022.Semt041001.Role5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt041001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt041001.SafekeepingAccount7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctSubLvl1Diff|global::System.Collections.Generic.List<ISO20022.Semt041001.AggregateHoldingBalance2>||XmlElement()||
|+|AcctSubLvl1|global::System.Collections.Generic.List<ISO20022.Semt041001.AccountSubLevel11>||XmlElement()||
|+|BalDtls|global::System.Collections.Generic.List<ISO20022.Semt041001.AggregateHoldingBalance3>||XmlElement()||
|+|BnfclOwnr|global::System.Collections.Generic.List<ISO20022.Semt041001.BeneficialOwner2>||XmlElement()||
|+|AcctSvcr|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
|+|AcctOwnr|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
|+|AcctId|ISO20022.Semt041001.SecuritiesAccount19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AcctSubLvl1Diff""",AcctSubLvl1Diff),validElement(AcctSubLvl1Diff),validList("""AcctSubLvl1""",AcctSubLvl1),validElement(AcctSubLvl1),validList("""BalDtls""",BalDtls),validElement(BalDtls),validList("""BnfclOwnr""",BnfclOwnr),validElement(BnfclOwnr),validElement(AcctSvcr),validElement(AcctOwnr),validElement(AcctId))|

---

## Value ISO20022.Semt041001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt041001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Aspect ISO20022.Semt041001.SecuritiesBalanceTransparencyReportV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt041001.SupplementaryData1>||XmlElement()||
|+|SfkpgAcctAndHldgs|global::System.Collections.Generic.List<ISO20022.Semt041001.SafekeepingAccount7>||XmlElement()||
|+|StmtGnlDtls|ISO20022.Semt041001.Statement59||XmlElement()||
|+|Pgntn|ISO20022.Semt041001.Pagination||XmlElement()||
|+|RcvrId|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
|+|SndrId|ISO20022.Semt041001.PartyIdentification100||XmlElement()||
|+|MsgId|ISO20022.Semt041001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""SfkpgAcctAndHldgs""",SfkpgAcctAndHldgs),validElement(SfkpgAcctAndHldgs),validElement(StmtGnlDtls),validElement(Pgntn),validElement(RcvrId),validElement(SndrId),validElement(MsgId))|

---

## Enum ISO20022.Semt041001.SecuritiesBalanceType14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GRP2|Int32||XmlEnum("""GRP2""")|1|
||GRP1|Int32||XmlEnum("""GRP1""")|2|
||WDOC|Int32||XmlEnum("""WDOC""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||RSTR|Int32||XmlEnum("""RSTR""")|5|
||PLED|Int32||XmlEnum("""PLED""")|6|
||PENR|Int32||XmlEnum("""PENR""")|7|
||LORE|Int32||XmlEnum("""LORE""")|8|
||LODE|Int32||XmlEnum("""LODE""")|9|
||PEND|Int32||XmlEnum("""PEND""")|10|
||PECA|Int32||XmlEnum("""PECA""")|11|
||PEDA|Int32||XmlEnum("""PEDA""")|12|
||BORE|Int32||XmlEnum("""BORE""")|13|
||BODE|Int32||XmlEnum("""BODE""")|14|
||REGO|Int32||XmlEnum("""REGO""")|15|
||LOAN|Int32||XmlEnum("""LOAN""")|16|
||TRAN|Int32||XmlEnum("""TRAN""")|17|
||DRAW|Int32||XmlEnum("""DRAW""")|18|
||MARG|Int32||XmlEnum("""MARG""")|19|
||COLO|Int32||XmlEnum("""COLO""")|20|
||COLI|Int32||XmlEnum("""COLI""")|21|
||PNET|Int32||XmlEnum("""PNET""")|22|
||OPNT|Int32||XmlEnum("""OPNT""")|23|
||BORR|Int32||XmlEnum("""BORR""")|24|
||BLOT|Int32||XmlEnum("""BLOT""")|25|
||BLCA|Int32||XmlEnum("""BLCA""")|26|
||BLOV|Int32||XmlEnum("""BLOV""")|27|
||BLOK|Int32||XmlEnum("""BLOK""")|28|
||BTRA|Int32||XmlEnum("""BTRA""")|29|
||AWAS|Int32||XmlEnum("""AWAS""")|30|

---

## Value ISO20022.Semt041001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Semt041001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Enum ISO20022.Semt041001.SenderBusinessRole1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ASER|Int32||XmlEnum("""ASER""")|1|
||AOWN|Int32||XmlEnum("""AOWN""")|2|

---

## Value ISO20022.Semt041001.Statement59


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ActvtyInd|String||XmlElement()||
|+|UpdTp|ISO20022.Semt041001.UpdateType4Choice||XmlElement()||
|+|FrqcyGrnlrty|String||XmlElement()||
|+|Frqcy|ISO20022.Semt041001.Frequency22Choice||XmlElement()||
|+|StmtPrd|ISO20022.Semt041001.DatePeriod1Choice||XmlElement()||
|+|StmtDtTm|ISO20022.Semt041001.DateAndDateTimeChoice||XmlElement()||
|+|StmtId|String||XmlElement()||
|+|QryRef|String||XmlElement()||
|+|StmtNb|ISO20022.Semt041001.Number3Choice||XmlElement()||
|+|SndrBizRole|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UpdTp),validElement(Frqcy),validElement(StmtPrd),validElement(StmtDtTm),validElement(StmtNb))|

---

## Enum ISO20022.Semt041001.StatementUpdateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DELT|Int32||XmlEnum("""DELT""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|

---

## Value ISO20022.Semt041001.SubBalanceBreakdown1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Semt041001.SubBalanceQuantity5Choice||XmlElement()||
|+|SubBalTp|ISO20022.Semt041001.SubBalanceType9Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty),validElement(SubBalTp))|

---

## Value ISO20022.Semt041001.SubBalanceQuantity5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt041001.GenericIdentification56||XmlElement()||
|+|Qty|ISO20022.Semt041001.FinancialInstrumentQuantity1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Qty),validChoice(Prtry,Qty))|

---

## Value ISO20022.Semt041001.SubBalanceType9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt041001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt041001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Semt041001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Semt041001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Semt041001.TypeOfPrice13Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EGAV|Int32||XmlEnum("""EGAV""")|1|
||ACTU|Int32||XmlEnum("""ACTU""")|2|
||DDVR|Int32||XmlEnum("""DDVR""")|3|
||GAVL|Int32||XmlEnum("""GAVL""")|4|
||SWIC|Int32||XmlEnum("""SWIC""")|5|
||NAVS|Int32||XmlEnum("""NAVS""")|6|
||RINV|Int32||XmlEnum("""RINV""")|7|
||MIDD|Int32||XmlEnum("""MIDD""")|8|
||SWNG|Int32||XmlEnum("""SWNG""")|9|
||INTE|Int32||XmlEnum("""INTE""")|10|
||CANC|Int32||XmlEnum("""CANC""")|11|
||CREA|Int32||XmlEnum("""CREA""")|12|
||NAVL|Int32||XmlEnum("""NAVL""")|13|
||OFFR|Int32||XmlEnum("""OFFR""")|14|
||BIDE|Int32||XmlEnum("""BIDE""")|15|

---

## Value ISO20022.Semt041001.UpdateType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt041001.GenericIdentification30||XmlElement()||
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

