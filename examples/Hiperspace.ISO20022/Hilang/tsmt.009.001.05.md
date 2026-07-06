# tsmt.009.001.05
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Tsmt009001.AccountIdentification4Choice {
        + Othr  : ISO20022.Tsmt009001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Tsmt009001.AccountIdentification4Choice *-- ISO20022.Tsmt009001.GenericAccountIdentification1
    class ISO20022.Tsmt009001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Tsmt009001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Tsmt009001.Adjustment7 {
        + Drctn  : String
        + AmtOrPctg  : ISO20022.Tsmt009001.AmountOrPercentage2Choice
        + Tp  : ISO20022.Tsmt009001.AdjustmentType1Choice
    }
    ISO20022.Tsmt009001.Adjustment7 *-- ISO20022.Tsmt009001.AmountOrPercentage2Choice
    ISO20022.Tsmt009001.Adjustment7 *-- ISO20022.Tsmt009001.AdjustmentType1Choice
    class ISO20022.Tsmt009001.AdjustmentDirection1Code {
        SUBS = 1
        ADDD = 2
    }
    class ISO20022.Tsmt009001.AdjustmentType1Choice {
        + OthrAdjstmntTp  : String
        + Tp  : String
    }
    class ISO20022.Tsmt009001.AdjustmentType2Code {
        SURC = 1
        CREN = 2
        DISC = 3
        REBA = 4
    }
    class ISO20022.Tsmt009001.AirportDescription1 {
        + AirprtNm  : String
        + Twn  : String
    }
    class ISO20022.Tsmt009001.AirportName1Choice {
        + OthrAirprtDesc  : ISO20022.Tsmt009001.AirportDescription1
        + AirprtCd  : String
    }
    ISO20022.Tsmt009001.AirportName1Choice *-- ISO20022.Tsmt009001.AirportDescription1
    class ISO20022.Tsmt009001.AmountOrPercentage2Choice {
        + Pctg  : Decimal
        + Amt  : ISO20022.Tsmt009001.ActiveCurrencyAndAmount
    }
    ISO20022.Tsmt009001.AmountOrPercentage2Choice *-- ISO20022.Tsmt009001.ActiveCurrencyAndAmount
    class ISO20022.Tsmt009001.AssuredType1Code {
        SEBA = 1
        BUBA = 2
        SELL = 3
        BUYE = 4
    }
    class ISO20022.Tsmt009001.BICIdentification1 {
        + BIC  : String
    }
    class ISO20022.Tsmt009001.BPOApplicableRules1Choice {
        + OthrRulesAndVrsn  : String
        + URBPOVrsn  : Decimal
    }
    class ISO20022.Tsmt009001.BankRole1Code {
        SELB = 1
        RECB = 2
        OBLB = 3
        BUYB = 4
    }
    class ISO20022.Tsmt009001.Baseline5 {
        + InttToPayXpctd  : String
        + OthrCertDataSetReqrd  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.RequiredSubmission6~
        + CertDataSetReqrd  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.RequiredSubmission4~
        + InsrncDataSetReqrd  : ISO20022.Tsmt009001.RequiredSubmission3
        + TrnsprtDataSetReqrd  : ISO20022.Tsmt009001.RequiredSubmission2
        + ComrclDataSetReqrd  : ISO20022.Tsmt009001.RequiredSubmission2
        + LatstMtchDt  : DateTime
        + PmtOblgtn  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.PaymentObligation2~
        + SttlmTerms  : ISO20022.Tsmt009001.SettlementTerms3
        + PmtTerms  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.PaymentTerms5~
        + Goods  : ISO20022.Tsmt009001.LineItem13
        + Consgn  : ISO20022.Tsmt009001.PartyIdentification26
        + ShipTo  : ISO20022.Tsmt009001.PartyIdentification26
        + BllTo  : ISO20022.Tsmt009001.PartyIdentification26
        + SellrSdSubmitgBk  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.BICIdentification1~
        + BuyrSdSubmitgBk  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.BICIdentification1~
        + SellrBk  : ISO20022.Tsmt009001.BICIdentification1
        + BuyrBk  : ISO20022.Tsmt009001.BICIdentification1
        + Sellr  : ISO20022.Tsmt009001.PartyIdentification26
        + Buyr  : ISO20022.Tsmt009001.PartyIdentification26
        + PurchsOrdrRef  : ISO20022.Tsmt009001.DocumentIdentification7
        + SvcCd  : String
        + SubmitrBaselnId  : ISO20022.Tsmt009001.DocumentIdentification1
    }
    ISO20022.Tsmt009001.Baseline5 *-- ISO20022.Tsmt009001.RequiredSubmission6
    ISO20022.Tsmt009001.Baseline5 *-- ISO20022.Tsmt009001.RequiredSubmission4
    ISO20022.Tsmt009001.Baseline5 *-- ISO20022.Tsmt009001.RequiredSubmission3
    ISO20022.Tsmt009001.Baseline5 *-- ISO20022.Tsmt009001.RequiredSubmission2
    ISO20022.Tsmt009001.Baseline5 *-- ISO20022.Tsmt009001.RequiredSubmission2
    ISO20022.Tsmt009001.Baseline5 *-- ISO20022.Tsmt009001.PaymentObligation2
    ISO20022.Tsmt009001.Baseline5 *-- ISO20022.Tsmt009001.SettlementTerms3
    ISO20022.Tsmt009001.Baseline5 *-- ISO20022.Tsmt009001.PaymentTerms5
    ISO20022.Tsmt009001.Baseline5 *-- ISO20022.Tsmt009001.LineItem13
    ISO20022.Tsmt009001.Baseline5 *-- ISO20022.Tsmt009001.PartyIdentification26
    ISO20022.Tsmt009001.Baseline5 *-- ISO20022.Tsmt009001.PartyIdentification26
    ISO20022.Tsmt009001.Baseline5 *-- ISO20022.Tsmt009001.PartyIdentification26
    ISO20022.Tsmt009001.Baseline5 *-- ISO20022.Tsmt009001.BICIdentification1
    ISO20022.Tsmt009001.Baseline5 *-- ISO20022.Tsmt009001.BICIdentification1
    ISO20022.Tsmt009001.Baseline5 *-- ISO20022.Tsmt009001.BICIdentification1
    ISO20022.Tsmt009001.Baseline5 *-- ISO20022.Tsmt009001.BICIdentification1
    ISO20022.Tsmt009001.Baseline5 *-- ISO20022.Tsmt009001.PartyIdentification26
    ISO20022.Tsmt009001.Baseline5 *-- ISO20022.Tsmt009001.PartyIdentification26
    ISO20022.Tsmt009001.Baseline5 *-- ISO20022.Tsmt009001.DocumentIdentification7
    ISO20022.Tsmt009001.Baseline5 *-- ISO20022.Tsmt009001.DocumentIdentification1
    class ISO20022.Tsmt009001.BaselineAmendmentRequestV05 {
        + OthrBkCtctPrsn  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.ContactIdentification3~
        + SellrBkCtctPrsn  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.ContactIdentification1~
        + BuyrBkCtctPrsn  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.ContactIdentification1~
        + SellrCtctPrsn  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.ContactIdentification1~
        + BuyrCtctPrsn  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.ContactIdentification1~
        + Baseln  : ISO20022.Tsmt009001.Baseline5
        + SubmitrTxRef  : ISO20022.Tsmt009001.SimpleIdentificationInformation
        + TxId  : ISO20022.Tsmt009001.SimpleIdentificationInformation
        + ReqId  : ISO20022.Tsmt009001.MessageIdentification1
    }
    ISO20022.Tsmt009001.BaselineAmendmentRequestV05 *-- ISO20022.Tsmt009001.ContactIdentification3
    ISO20022.Tsmt009001.BaselineAmendmentRequestV05 *-- ISO20022.Tsmt009001.ContactIdentification1
    ISO20022.Tsmt009001.BaselineAmendmentRequestV05 *-- ISO20022.Tsmt009001.ContactIdentification1
    ISO20022.Tsmt009001.BaselineAmendmentRequestV05 *-- ISO20022.Tsmt009001.ContactIdentification1
    ISO20022.Tsmt009001.BaselineAmendmentRequestV05 *-- ISO20022.Tsmt009001.ContactIdentification1
    ISO20022.Tsmt009001.BaselineAmendmentRequestV05 *-- ISO20022.Tsmt009001.Baseline5
    ISO20022.Tsmt009001.BaselineAmendmentRequestV05 *-- ISO20022.Tsmt009001.SimpleIdentificationInformation
    ISO20022.Tsmt009001.BaselineAmendmentRequestV05 *-- ISO20022.Tsmt009001.SimpleIdentificationInformation
    ISO20022.Tsmt009001.BaselineAmendmentRequestV05 *-- ISO20022.Tsmt009001.MessageIdentification1
    class ISO20022.Tsmt009001.CashAccount24 {
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Tsmt009001.CashAccountType2Choice
        + Id  : ISO20022.Tsmt009001.AccountIdentification4Choice
    }
    ISO20022.Tsmt009001.CashAccount24 *-- ISO20022.Tsmt009001.CashAccountType2Choice
    ISO20022.Tsmt009001.CashAccount24 *-- ISO20022.Tsmt009001.AccountIdentification4Choice
    class ISO20022.Tsmt009001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Tsmt009001.Charge24 {
        + Chrgs  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.ChargesDetails3~
        + Tp  : String
    }
    ISO20022.Tsmt009001.Charge24 *-- ISO20022.Tsmt009001.ChargesDetails3
    class ISO20022.Tsmt009001.ChargeType8Code {
        TRPT = 1
        AIRF = 2
        CHDE = 3
        CHOR = 4
        COLF = 5
        INSU = 6
        SECU = 7
        DNGR = 8
        PICK = 9
        PACK = 10
        STOR = 11
        STDE = 12
        SIGN = 13
    }
    class ISO20022.Tsmt009001.Charges5 {
        + Tp  : String
        + Pctg  : Decimal
        + Amt  : ISO20022.Tsmt009001.CurrencyAndAmount
        + ChrgsPyee  : String
        + ChrgsPyer  : String
    }
    ISO20022.Tsmt009001.Charges5 *-- ISO20022.Tsmt009001.CurrencyAndAmount
    class ISO20022.Tsmt009001.ChargesDetails3 {
        + AmtOrPctg  : ISO20022.Tsmt009001.AmountOrPercentage2Choice
        + Tp  : ISO20022.Tsmt009001.ChargesType1Choice
    }
    ISO20022.Tsmt009001.ChargesDetails3 *-- ISO20022.Tsmt009001.AmountOrPercentage2Choice
    ISO20022.Tsmt009001.ChargesDetails3 *-- ISO20022.Tsmt009001.ChargesType1Choice
    class ISO20022.Tsmt009001.ChargesType1Choice {
        + OthrChrgsTp  : String
        + Tp  : String
    }
    class ISO20022.Tsmt009001.ContactIdentification1 {
        + EmailAdr  : String
        + FaxNb  : String
        + PhneNb  : String
        + Role  : String
        + GvnNm  : String
        + NmPrfx  : String
        + Nm  : String
    }
    class ISO20022.Tsmt009001.ContactIdentification3 {
        + EmailAdr  : String
        + FaxNb  : String
        + PhneNb  : String
        + Role  : String
        + GvnNm  : String
        + NmPrfx  : String
        + Nm  : String
        + BIC  : String
    }
    class ISO20022.Tsmt009001.CountrySubdivision1Choice {
        + Prtry  : ISO20022.Tsmt009001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Tsmt009001.CountrySubdivision1Choice *-- ISO20022.Tsmt009001.GenericIdentification1
    class ISO20022.Tsmt009001.CurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Tsmt009001.DocumentIdentification1 {
        + Submitr  : ISO20022.Tsmt009001.BICIdentification1
        + Vrsn  : Decimal
        + Id  : String
    }
    ISO20022.Tsmt009001.DocumentIdentification1 *-- ISO20022.Tsmt009001.BICIdentification1
    class ISO20022.Tsmt009001.DocumentIdentification7 {
        + DtOfIsse  : DateTime
        + Id  : String
    }
    class ISO20022.Tsmt009001.FinancialInstitutionIdentification4Choice {
        + NmAndAdr  : ISO20022.Tsmt009001.NameAndAddress6
        + BIC  : String
    }
    ISO20022.Tsmt009001.FinancialInstitutionIdentification4Choice *-- ISO20022.Tsmt009001.NameAndAddress6
    class ISO20022.Tsmt009001.FreightCharges1Code {
        PRPD = 1
        CLCT = 2
    }
    class ISO20022.Tsmt009001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Tsmt009001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Tsmt009001.GenericAccountIdentification1 *-- ISO20022.Tsmt009001.AccountSchemeName1Choice
    class ISO20022.Tsmt009001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Tsmt009001.GenericIdentification13 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Tsmt009001.GenericIdentification4 {
        + IdTp  : String
        + Id  : String
    }
    class ISO20022.Tsmt009001.Incoterms4 {
        + Lctn  : String
        + IncotrmsCd  : ISO20022.Tsmt009001.Incoterms4Choice
    }
    ISO20022.Tsmt009001.Incoterms4 *-- ISO20022.Tsmt009001.Incoterms4Choice
    class ISO20022.Tsmt009001.Incoterms4Choice {
        + Prtry  : ISO20022.Tsmt009001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Tsmt009001.Incoterms4Choice *-- ISO20022.Tsmt009001.GenericIdentification13
    class ISO20022.Tsmt009001.InsuranceClauses1Code {
        IRCE = 1
        CMCC = 2
        ISMC = 3
        ICLC = 4
        IREC = 5
        ISCC = 6
        IWCC = 7
        ICAI = 8
        ICCC = 9
        ICCB = 10
        ICCA = 11
    }
    class ISO20022.Tsmt009001.LineItem13 {
        + SellrDfndInf  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.UserDefinedInformation1~
        + BuyrDfndInf  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.UserDefinedInformation1~
        + TtlNetAmt  : ISO20022.Tsmt009001.CurrencyAndAmount
        + Tax  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.Tax23~
        + FrghtChrgs  : ISO20022.Tsmt009001.Charge24
        + Adjstmnt  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.Adjustment7~
        + Incotrms  : ISO20022.Tsmt009001.Incoterms4
        + RtgSummry  : ISO20022.Tsmt009001.TransportMeans5
        + LineItmsTtlAmt  : ISO20022.Tsmt009001.CurrencyAndAmount
        + LineItmDtls  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.LineItemDetails13~
        + ShipmntDtRg  : ISO20022.Tsmt009001.ShipmentDateRange1
        + TrnsShipmnt  : String
        + PrtlShipmnt  : String
        + GoodsAndOrSvcsDesc  : String
    }
    ISO20022.Tsmt009001.LineItem13 *-- ISO20022.Tsmt009001.UserDefinedInformation1
    ISO20022.Tsmt009001.LineItem13 *-- ISO20022.Tsmt009001.UserDefinedInformation1
    ISO20022.Tsmt009001.LineItem13 *-- ISO20022.Tsmt009001.CurrencyAndAmount
    ISO20022.Tsmt009001.LineItem13 *-- ISO20022.Tsmt009001.Tax23
    ISO20022.Tsmt009001.LineItem13 *-- ISO20022.Tsmt009001.Charge24
    ISO20022.Tsmt009001.LineItem13 *-- ISO20022.Tsmt009001.Adjustment7
    ISO20022.Tsmt009001.LineItem13 *-- ISO20022.Tsmt009001.Incoterms4
    ISO20022.Tsmt009001.LineItem13 *-- ISO20022.Tsmt009001.TransportMeans5
    ISO20022.Tsmt009001.LineItem13 *-- ISO20022.Tsmt009001.CurrencyAndAmount
    ISO20022.Tsmt009001.LineItem13 *-- ISO20022.Tsmt009001.LineItemDetails13
    ISO20022.Tsmt009001.LineItem13 *-- ISO20022.Tsmt009001.ShipmentDateRange1
    class ISO20022.Tsmt009001.LineItemDetails13 {
        + Incotrms  : ISO20022.Tsmt009001.Incoterms4
        + TtlAmt  : ISO20022.Tsmt009001.CurrencyAndAmount
        + Tax  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.Tax23~
        + FrghtChrgs  : ISO20022.Tsmt009001.Charge24
        + Adjstmnt  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.Adjustment7~
        + RtgSummry  : ISO20022.Tsmt009001.TransportMeans5
        + ShipmntSchdl  : ISO20022.Tsmt009001.ShipmentSchedule2Choice
        + PdctOrgn  : global::System.Collections.Generic.List~String~
        + PdctCtgy  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.ProductCategory1Choice~
        + PdctChrtcs  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.ProductCharacteristics1Choice~
        + PdctIdr  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.ProductIdentifier2Choice~
        + PdctNm  : String
        + PricTlrnce  : ISO20022.Tsmt009001.PercentageTolerance1
        + UnitPric  : ISO20022.Tsmt009001.UnitPrice18
        + QtyTlrnce  : ISO20022.Tsmt009001.PercentageTolerance1
        + Qty  : ISO20022.Tsmt009001.Quantity9
        + LineItmId  : String
    }
    ISO20022.Tsmt009001.LineItemDetails13 *-- ISO20022.Tsmt009001.Incoterms4
    ISO20022.Tsmt009001.LineItemDetails13 *-- ISO20022.Tsmt009001.CurrencyAndAmount
    ISO20022.Tsmt009001.LineItemDetails13 *-- ISO20022.Tsmt009001.Tax23
    ISO20022.Tsmt009001.LineItemDetails13 *-- ISO20022.Tsmt009001.Charge24
    ISO20022.Tsmt009001.LineItemDetails13 *-- ISO20022.Tsmt009001.Adjustment7
    ISO20022.Tsmt009001.LineItemDetails13 *-- ISO20022.Tsmt009001.TransportMeans5
    ISO20022.Tsmt009001.LineItemDetails13 *-- ISO20022.Tsmt009001.ShipmentSchedule2Choice
    ISO20022.Tsmt009001.LineItemDetails13 *-- ISO20022.Tsmt009001.ProductCategory1Choice
    ISO20022.Tsmt009001.LineItemDetails13 *-- ISO20022.Tsmt009001.ProductCharacteristics1Choice
    ISO20022.Tsmt009001.LineItemDetails13 *-- ISO20022.Tsmt009001.ProductIdentifier2Choice
    ISO20022.Tsmt009001.LineItemDetails13 *-- ISO20022.Tsmt009001.PercentageTolerance1
    ISO20022.Tsmt009001.LineItemDetails13 *-- ISO20022.Tsmt009001.UnitPrice18
    ISO20022.Tsmt009001.LineItemDetails13 *-- ISO20022.Tsmt009001.PercentageTolerance1
    ISO20022.Tsmt009001.LineItemDetails13 *-- ISO20022.Tsmt009001.Quantity9
    class ISO20022.Tsmt009001.Location2 {
        + Txt  : String
        + CtrySubDvsn  : ISO20022.Tsmt009001.CountrySubdivision1Choice
        + Ctry  : String
    }
    ISO20022.Tsmt009001.Location2 *-- ISO20022.Tsmt009001.CountrySubdivision1Choice
    class ISO20022.Tsmt009001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Tsmt009001.MultimodalTransport3 {
        + PlcOfFnlDstn  : String
        + TakngInChrg  : String
    }
    class ISO20022.Tsmt009001.NameAndAddress6 {
        + Adr  : ISO20022.Tsmt009001.PostalAddress2
        + Nm  : String
    }
    ISO20022.Tsmt009001.NameAndAddress6 *-- ISO20022.Tsmt009001.PostalAddress2
    class ISO20022.Tsmt009001.NamePrefix1Code {
        MADM = 1
        MISS = 2
        MIST = 3
        DOCT = 4
    }
    class ISO20022.Tsmt009001.PartyIdentification26 {
        + PstlAdr  : ISO20022.Tsmt009001.PostalAddress5
        + PrtryId  : ISO20022.Tsmt009001.GenericIdentification4
        + Nm  : String
    }
    ISO20022.Tsmt009001.PartyIdentification26 *-- ISO20022.Tsmt009001.PostalAddress5
    ISO20022.Tsmt009001.PartyIdentification26 *-- ISO20022.Tsmt009001.GenericIdentification4
    class ISO20022.Tsmt009001.PartyIdentification27 {
        + Ctry  : String
        + PrtryId  : ISO20022.Tsmt009001.GenericIdentification4
        + Nm  : String
    }
    ISO20022.Tsmt009001.PartyIdentification27 *-- ISO20022.Tsmt009001.GenericIdentification4
    class ISO20022.Tsmt009001.PaymentCodeOrOther1Choice {
        + OthrPmtTerms  : String
        + PmtDueDt  : DateTime
        + PmtCd  : ISO20022.Tsmt009001.PaymentPeriod3
    }
    ISO20022.Tsmt009001.PaymentCodeOrOther1Choice *-- ISO20022.Tsmt009001.PaymentPeriod3
    class ISO20022.Tsmt009001.PaymentCodeOrOther2Choice {
        + OthrPmtTerms  : String
        + PmtDueDt  : DateTime
        + PmtCd  : ISO20022.Tsmt009001.PaymentPeriod4
    }
    ISO20022.Tsmt009001.PaymentCodeOrOther2Choice *-- ISO20022.Tsmt009001.PaymentPeriod4
    class ISO20022.Tsmt009001.PaymentObligation2 {
        + SttlmTerms  : ISO20022.Tsmt009001.SettlementTerms3
        + PmtTerms  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.PaymentTerms4~
        + PlcOfJursdctn  : ISO20022.Tsmt009001.Location2
        + AplblLaw  : String
        + AplblRules  : ISO20022.Tsmt009001.BPOApplicableRules1Choice
        + XpryDt  : DateTime
        + Chrgs  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.Charges5~
        + PmtOblgtnAmt  : ISO20022.Tsmt009001.AmountOrPercentage2Choice
        + RcptBk  : ISO20022.Tsmt009001.BICIdentification1
        + OblgrBk  : ISO20022.Tsmt009001.BICIdentification1
    }
    ISO20022.Tsmt009001.PaymentObligation2 *-- ISO20022.Tsmt009001.SettlementTerms3
    ISO20022.Tsmt009001.PaymentObligation2 *-- ISO20022.Tsmt009001.PaymentTerms4
    ISO20022.Tsmt009001.PaymentObligation2 *-- ISO20022.Tsmt009001.Location2
    ISO20022.Tsmt009001.PaymentObligation2 *-- ISO20022.Tsmt009001.BPOApplicableRules1Choice
    ISO20022.Tsmt009001.PaymentObligation2 *-- ISO20022.Tsmt009001.Charges5
    ISO20022.Tsmt009001.PaymentObligation2 *-- ISO20022.Tsmt009001.AmountOrPercentage2Choice
    ISO20022.Tsmt009001.PaymentObligation2 *-- ISO20022.Tsmt009001.BICIdentification1
    ISO20022.Tsmt009001.PaymentObligation2 *-- ISO20022.Tsmt009001.BICIdentification1
    class ISO20022.Tsmt009001.PaymentPeriod3 {
        + NbOfDays  : Decimal
        + Cd  : String
    }
    class ISO20022.Tsmt009001.PaymentPeriod4 {
        + NbOfDays  : Decimal
        + Cd  : String
    }
    class ISO20022.Tsmt009001.PaymentTerms4 {
        + AmtOrPctg  : ISO20022.Tsmt009001.AmountOrPercentage2Choice
        + PmtTerms  : ISO20022.Tsmt009001.PaymentCodeOrOther1Choice
    }
    ISO20022.Tsmt009001.PaymentTerms4 *-- ISO20022.Tsmt009001.AmountOrPercentage2Choice
    ISO20022.Tsmt009001.PaymentTerms4 *-- ISO20022.Tsmt009001.PaymentCodeOrOther1Choice
    class ISO20022.Tsmt009001.PaymentTerms5 {
        + AmtOrPctg  : ISO20022.Tsmt009001.AmountOrPercentage2Choice
        + PmtTerms  : ISO20022.Tsmt009001.PaymentCodeOrOther2Choice
    }
    ISO20022.Tsmt009001.PaymentTerms5 *-- ISO20022.Tsmt009001.AmountOrPercentage2Choice
    ISO20022.Tsmt009001.PaymentTerms5 *-- ISO20022.Tsmt009001.PaymentCodeOrOther2Choice
    class ISO20022.Tsmt009001.PaymentTime3Code {
        IREC = 1
        CASH = 2
        EPSD = 3
        EPRR = 4
        EPPO = 5
        EPAM = 6
        EPIN = 7
        PRMR = 8
        PRMD = 9
        EPRD = 10
        EPBE = 11
        EMTR = 12
        EMTD = 13
    }
    class ISO20022.Tsmt009001.PaymentTime4Code {
        EMTD = 1
        EMTR = 2
        EPBE = 3
        EPRD = 4
        PRMD = 5
        PRMR = 6
        EPIN = 7
        EPPO = 8
        EPRR = 9
        EPSD = 10
        CASH = 11
        IREC = 12
    }
    class ISO20022.Tsmt009001.PercentageTolerance1 {
        + MnsPct  : Decimal
        + PlusPct  : Decimal
    }
    class ISO20022.Tsmt009001.PostalAddress2 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCdId  : String
        + StrtNm  : String
    }
    class ISO20022.Tsmt009001.PostalAddress5 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCdId  : String
        + StrtNm  : String
    }
    class ISO20022.Tsmt009001.ProductCategory1 {
        + Ctgy  : String
        + Tp  : String
    }
    class ISO20022.Tsmt009001.ProductCategory1Choice {
        + OthrPdctCtgy  : ISO20022.Tsmt009001.GenericIdentification4
        + StrdPdctCtgy  : ISO20022.Tsmt009001.ProductCategory1
    }
    ISO20022.Tsmt009001.ProductCategory1Choice *-- ISO20022.Tsmt009001.GenericIdentification4
    ISO20022.Tsmt009001.ProductCategory1Choice *-- ISO20022.Tsmt009001.ProductCategory1
    class ISO20022.Tsmt009001.ProductCategory1Code {
        GNDR = 1
        LOBU = 2
        PRGP = 3
        QOTA = 4
        HRTR = 5
    }
    class ISO20022.Tsmt009001.ProductCharacteristics1 {
        + Chrtcs  : String
        + Tp  : String
    }
    class ISO20022.Tsmt009001.ProductCharacteristics1Choice {
        + OthrPdctChrtcs  : ISO20022.Tsmt009001.GenericIdentification4
        + StrdPdctChrtcs  : ISO20022.Tsmt009001.ProductCharacteristics1
    }
    ISO20022.Tsmt009001.ProductCharacteristics1Choice *-- ISO20022.Tsmt009001.GenericIdentification4
    ISO20022.Tsmt009001.ProductCharacteristics1Choice *-- ISO20022.Tsmt009001.ProductCharacteristics1
    class ISO20022.Tsmt009001.ProductCharacteristics1Code {
        VINR = 1
        STOR = 2
        SPRM = 3
        SZRG = 4
        SIZE = 5
        SISP = 6
        PCTV = 7
        ORCR = 8
        OPTN = 9
        ENNR = 10
        EDSP = 11
        CLOR = 12
        CHNR = 13
        BISP = 14
    }
    class ISO20022.Tsmt009001.ProductIdentifier2 {
        + Idr  : String
        + Tp  : String
    }
    class ISO20022.Tsmt009001.ProductIdentifier2Choice {
        + OthrPdctIdr  : ISO20022.Tsmt009001.GenericIdentification4
        + StrdPdctIdr  : ISO20022.Tsmt009001.ProductIdentifier2
    }
    ISO20022.Tsmt009001.ProductIdentifier2Choice *-- ISO20022.Tsmt009001.GenericIdentification4
    ISO20022.Tsmt009001.ProductIdentifier2Choice *-- ISO20022.Tsmt009001.ProductIdentifier2
    class ISO20022.Tsmt009001.ProductIdentifier2Code {
        UPCC = 1
        SUPI = 2
        STYL = 3
        QOTA = 4
        PART = 5
        MODL = 6
        MANI = 7
        HRTR = 8
        EANC = 9
        COMD = 10
        BINR = 11
    }
    class ISO20022.Tsmt009001.Quantity9 {
        + Fctr  : String
        + Val  : Decimal
        + UnitOfMeasr  : ISO20022.Tsmt009001.UnitOfMeasure3Choice
    }
    ISO20022.Tsmt009001.Quantity9 *-- ISO20022.Tsmt009001.UnitOfMeasure3Choice
    class ISO20022.Tsmt009001.RequiredSubmission2 {
        + Submitr  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.BICIdentification1~
    }
    ISO20022.Tsmt009001.RequiredSubmission2 *-- ISO20022.Tsmt009001.BICIdentification1
    class ISO20022.Tsmt009001.RequiredSubmission3 {
        + MtchAssrdPty  : String
        + ClausesReqrd  : global::System.Collections.Generic.List~String~
        + MtchAmt  : String
        + MtchTrnsprt  : String
        + MtchIsseDt  : String
        + MtchIssr  : ISO20022.Tsmt009001.PartyIdentification27
        + Submitr  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.BICIdentification1~
    }
    ISO20022.Tsmt009001.RequiredSubmission3 *-- ISO20022.Tsmt009001.PartyIdentification27
    ISO20022.Tsmt009001.RequiredSubmission3 *-- ISO20022.Tsmt009001.BICIdentification1
    class ISO20022.Tsmt009001.RequiredSubmission4 {
        + LineItmId  : global::System.Collections.Generic.List~String~
        + MtchManfctr  : ISO20022.Tsmt009001.PartyIdentification27
        + MtchConsgn  : String
        + AuthrsdInspctrInd  : String
        + MtchInspctnDt  : String
        + MtchIsseDt  : String
        + MtchIssr  : ISO20022.Tsmt009001.PartyIdentification27
        + CertTp  : String
        + Submitr  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.BICIdentification1~
    }
    ISO20022.Tsmt009001.RequiredSubmission4 *-- ISO20022.Tsmt009001.PartyIdentification27
    ISO20022.Tsmt009001.RequiredSubmission4 *-- ISO20022.Tsmt009001.PartyIdentification27
    ISO20022.Tsmt009001.RequiredSubmission4 *-- ISO20022.Tsmt009001.BICIdentification1
    class ISO20022.Tsmt009001.RequiredSubmission6 {
        + CertTpDesc  : String
        + CertTp  : String
        + Submitr  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.BICIdentification1~
    }
    ISO20022.Tsmt009001.RequiredSubmission6 *-- ISO20022.Tsmt009001.BICIdentification1
    class ISO20022.Tsmt009001.SettlementTerms3 {
        + CdtrAcct  : ISO20022.Tsmt009001.CashAccount24
        + CdtrAgt  : ISO20022.Tsmt009001.FinancialInstitutionIdentification4Choice
    }
    ISO20022.Tsmt009001.SettlementTerms3 *-- ISO20022.Tsmt009001.CashAccount24
    ISO20022.Tsmt009001.SettlementTerms3 *-- ISO20022.Tsmt009001.FinancialInstitutionIdentification4Choice
    class ISO20022.Tsmt009001.ShipmentDateRange1 {
        + LatstShipmntDt  : DateTime
        + EarlstShipmntDt  : DateTime
    }
    class ISO20022.Tsmt009001.ShipmentDateRange2 {
        + LatstShipmntDt  : DateTime
        + EarlstShipmntDt  : DateTime
        + SubQtyVal  : Decimal
    }
    class ISO20022.Tsmt009001.ShipmentSchedule2Choice {
        + ShipmntSubSchdl  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.ShipmentDateRange2~
        + ShipmntDtRg  : ISO20022.Tsmt009001.ShipmentDateRange1
    }
    ISO20022.Tsmt009001.ShipmentSchedule2Choice *-- ISO20022.Tsmt009001.ShipmentDateRange2
    ISO20022.Tsmt009001.ShipmentSchedule2Choice *-- ISO20022.Tsmt009001.ShipmentDateRange1
    class ISO20022.Tsmt009001.SimpleIdentificationInformation {
        + Id  : String
    }
    class ISO20022.Tsmt009001.SingleTransport7 {
        + TrnsprtByRail  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.TransportByRail5~
        + TrnsprtByRoad  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.TransportByRoad5~
        + TrnsprtBySea  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.TransportBySea6~
        + TrnsprtByAir  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.TransportByAir5~
    }
    ISO20022.Tsmt009001.SingleTransport7 *-- ISO20022.Tsmt009001.TransportByRail5
    ISO20022.Tsmt009001.SingleTransport7 *-- ISO20022.Tsmt009001.TransportByRoad5
    ISO20022.Tsmt009001.SingleTransport7 *-- ISO20022.Tsmt009001.TransportBySea6
    ISO20022.Tsmt009001.SingleTransport7 *-- ISO20022.Tsmt009001.TransportByAir5
    class ISO20022.Tsmt009001.Tax23 {
        + AmtOrPctg  : ISO20022.Tsmt009001.AmountOrPercentage2Choice
        + Tp  : ISO20022.Tsmt009001.TaxType2Choice
    }
    ISO20022.Tsmt009001.Tax23 *-- ISO20022.Tsmt009001.AmountOrPercentage2Choice
    ISO20022.Tsmt009001.Tax23 *-- ISO20022.Tsmt009001.TaxType2Choice
    class ISO20022.Tsmt009001.TaxType2Choice {
        + OthrTaxTp  : String
        + Tp  : String
    }
    class ISO20022.Tsmt009001.TaxType9Code {
        CUST = 1
        VATA = 2
        COAX = 3
        STAM = 4
        WITH = 5
        STAT = 6
        NATI = 7
        PROV = 8
    }
    class ISO20022.Tsmt009001.TradeCertificateType1Code {
        PHYT = 1
        HEAL = 2
        ORIG = 3
        WEIG = 4
        QUAN = 5
        QUAL = 6
        ANLY = 7
    }
    class ISO20022.Tsmt009001.TradeFinanceService2Code {
        LEV3 = 1
        LEV2 = 2
        LEV1 = 3
    }
    class ISO20022.Tsmt009001.TransportByAir5 {
        + CrrierAgtCtry  : String
        + CrrierAgtNm  : String
        + AirCrrierCtry  : String
        + AirCrrierNm  : String
        + DstnAirprt  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.AirportName1Choice~
        + DprtureAirprt  : global::System.Collections.Generic.List~ISO20022.Tsmt009001.AirportName1Choice~
    }
    ISO20022.Tsmt009001.TransportByAir5 *-- ISO20022.Tsmt009001.AirportName1Choice
    ISO20022.Tsmt009001.TransportByAir5 *-- ISO20022.Tsmt009001.AirportName1Choice
    class ISO20022.Tsmt009001.TransportByRail5 {
        + CrrierAgtCtry  : String
        + CrrierAgtNm  : String
        + RailCrrierCtry  : String
        + RailCrrierNm  : String
        + PlcOfDlvry  : global::System.Collections.Generic.List~String~
        + PlcOfRct  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Tsmt009001.TransportByRoad5 {
        + CrrierAgtCtry  : String
        + CrrierAgtNm  : String
        + RoadCrrierCtry  : String
        + RoadCrrierNm  : String
        + PlcOfDlvry  : global::System.Collections.Generic.List~String~
        + PlcOfRct  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Tsmt009001.TransportBySea6 {
        + CrrierAgtCtry  : String
        + CrrierAgtNm  : String
        + SeaCrrierCtry  : String
        + SeaCrrierNm  : String
        + VsslNm  : String
        + PortOfDschrge  : global::System.Collections.Generic.List~String~
        + PortOfLoadng  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Tsmt009001.TransportMeans5 {
        + MltmdlTrnsprt  : ISO20022.Tsmt009001.MultimodalTransport3
        + IndvTrnsprt  : ISO20022.Tsmt009001.SingleTransport7
    }
    ISO20022.Tsmt009001.TransportMeans5 *-- ISO20022.Tsmt009001.MultimodalTransport3
    ISO20022.Tsmt009001.TransportMeans5 *-- ISO20022.Tsmt009001.SingleTransport7
    class ISO20022.Tsmt009001.UnitOfMeasure3Choice {
        + OthrUnitOfMeasr  : String
        + UnitOfMeasrCd  : String
    }
    class ISO20022.Tsmt009001.UnitOfMeasure4Code {
        TNE = 1
        BL = 2
        BG = 3
        OZA = 4
        OZI = 5
        MTQ = 6
        INQ = 7
        CR = 8
        CH = 9
        CT = 10
        BO = 11
        BX = 12
        BLL = 13
        STN = 14
        LBR = 15
        LTR = 16
        CLT = 17
        MMQ = 18
        KMK = 19
        CMK = 20
        MMK = 21
        YDK = 22
        KTM = 23
        MMT = 24
        GLL = 25
        QT = 26
        QTI = 27
        PT = 28
        PTI = 29
        ONZ = 30
        MIK = 31
        FTK = 32
        INK = 33
        E1A = 34
        FOT = 35
        MTK = 36
        CMT = 37
        GRM = 38
        GLI = 39
        LY = 40
        INH = 41
        MTR = 42
        LTN = 43
        EA = 44
        KGM = 45
    }
    class ISO20022.Tsmt009001.UnitPrice18 {
        + Fctr  : String
        + Amt  : ISO20022.Tsmt009001.CurrencyAndAmount
        + UnitPric  : ISO20022.Tsmt009001.UnitOfMeasure3Choice
    }
    ISO20022.Tsmt009001.UnitPrice18 *-- ISO20022.Tsmt009001.CurrencyAndAmount
    ISO20022.Tsmt009001.UnitPrice18 *-- ISO20022.Tsmt009001.UnitOfMeasure3Choice
    class ISO20022.Tsmt009001.UserDefinedInformation1 {
        + Inf  : String
        + Labl  : String
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

## Value ISO20022.Tsmt009001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Tsmt009001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Tsmt009001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsmt009001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Tsmt009001.Adjustment7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Drctn|String||XmlElement()||
|+|AmtOrPctg|ISO20022.Tsmt009001.AmountOrPercentage2Choice||XmlElement()||
|+|Tp|ISO20022.Tsmt009001.AdjustmentType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtOrPctg),validElement(Tp))|

---

## Enum ISO20022.Tsmt009001.AdjustmentDirection1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SUBS|Int32||XmlEnum("""SUBS""")|1|
||ADDD|Int32||XmlEnum("""ADDD""")|2|

---

## Value ISO20022.Tsmt009001.AdjustmentType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrAdjstmntTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(OthrAdjstmntTp,Tp))|

---

## Enum ISO20022.Tsmt009001.AdjustmentType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SURC|Int32||XmlEnum("""SURC""")|1|
||CREN|Int32||XmlEnum("""CREN""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|
||REBA|Int32||XmlEnum("""REBA""")|4|

---

## Value ISO20022.Tsmt009001.AirportDescription1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AirprtNm|String||XmlElement()||
|+|Twn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt009001.AirportName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrAirprtDesc|ISO20022.Tsmt009001.AirportDescription1||XmlElement()||
|+|AirprtCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrAirprtDesc),validChoice(OthrAirprtDesc,AirprtCd))|

---

## Value ISO20022.Tsmt009001.AmountOrPercentage2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pctg|Decimal||XmlElement()||
|+|Amt|ISO20022.Tsmt009001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Pctg,Amt))|

---

## Enum ISO20022.Tsmt009001.AssuredType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SEBA|Int32||XmlEnum("""SEBA""")|1|
||BUBA|Int32||XmlEnum("""BUBA""")|2|
||SELL|Int32||XmlEnum("""SELL""")|3|
||BUYE|Int32||XmlEnum("""BUYE""")|4|

---

## Value ISO20022.Tsmt009001.BICIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""BIC""",BIC,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Tsmt009001.BPOApplicableRules1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrRulesAndVrsn|String||XmlElement()||
|+|URBPOVrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(OthrRulesAndVrsn,URBPOVrsn))|

---

## Enum ISO20022.Tsmt009001.BankRole1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SELB|Int32||XmlEnum("""SELB""")|1|
||RECB|Int32||XmlEnum("""RECB""")|2|
||OBLB|Int32||XmlEnum("""OBLB""")|3|
||BUYB|Int32||XmlEnum("""BUYB""")|4|

---

## Value ISO20022.Tsmt009001.Baseline5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InttToPayXpctd|String||XmlElement()||
|+|OthrCertDataSetReqrd|global::System.Collections.Generic.List<ISO20022.Tsmt009001.RequiredSubmission6>||XmlElement()||
|+|CertDataSetReqrd|global::System.Collections.Generic.List<ISO20022.Tsmt009001.RequiredSubmission4>||XmlElement()||
|+|InsrncDataSetReqrd|ISO20022.Tsmt009001.RequiredSubmission3||XmlElement()||
|+|TrnsprtDataSetReqrd|ISO20022.Tsmt009001.RequiredSubmission2||XmlElement()||
|+|ComrclDataSetReqrd|ISO20022.Tsmt009001.RequiredSubmission2||XmlElement()||
|+|LatstMtchDt|DateTime||XmlElement()||
|+|PmtOblgtn|global::System.Collections.Generic.List<ISO20022.Tsmt009001.PaymentObligation2>||XmlElement()||
|+|SttlmTerms|ISO20022.Tsmt009001.SettlementTerms3||XmlElement()||
|+|PmtTerms|global::System.Collections.Generic.List<ISO20022.Tsmt009001.PaymentTerms5>||XmlElement()||
|+|Goods|ISO20022.Tsmt009001.LineItem13||XmlElement()||
|+|Consgn|ISO20022.Tsmt009001.PartyIdentification26||XmlElement()||
|+|ShipTo|ISO20022.Tsmt009001.PartyIdentification26||XmlElement()||
|+|BllTo|ISO20022.Tsmt009001.PartyIdentification26||XmlElement()||
|+|SellrSdSubmitgBk|global::System.Collections.Generic.List<ISO20022.Tsmt009001.BICIdentification1>||XmlElement()||
|+|BuyrSdSubmitgBk|global::System.Collections.Generic.List<ISO20022.Tsmt009001.BICIdentification1>||XmlElement()||
|+|SellrBk|ISO20022.Tsmt009001.BICIdentification1||XmlElement()||
|+|BuyrBk|ISO20022.Tsmt009001.BICIdentification1||XmlElement()||
|+|Sellr|ISO20022.Tsmt009001.PartyIdentification26||XmlElement()||
|+|Buyr|ISO20022.Tsmt009001.PartyIdentification26||XmlElement()||
|+|PurchsOrdrRef|ISO20022.Tsmt009001.DocumentIdentification7||XmlElement()||
|+|SvcCd|String||XmlElement()||
|+|SubmitrBaselnId|ISO20022.Tsmt009001.DocumentIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrCertDataSetReqrd""",OthrCertDataSetReqrd),validElement(OthrCertDataSetReqrd),validList("""CertDataSetReqrd""",CertDataSetReqrd),validElement(CertDataSetReqrd),validElement(InsrncDataSetReqrd),validElement(TrnsprtDataSetReqrd),validElement(ComrclDataSetReqrd),validList("""PmtOblgtn""",PmtOblgtn),validElement(PmtOblgtn),validElement(SttlmTerms),validRequired("""PmtTerms""",PmtTerms),validList("""PmtTerms""",PmtTerms),validElement(PmtTerms),validElement(Goods),validElement(Consgn),validElement(ShipTo),validElement(BllTo),validList("""SellrSdSubmitgBk""",SellrSdSubmitgBk),validElement(SellrSdSubmitgBk),validList("""BuyrSdSubmitgBk""",BuyrSdSubmitgBk),validElement(BuyrSdSubmitgBk),validElement(SellrBk),validElement(BuyrBk),validElement(Sellr),validElement(Buyr),validElement(PurchsOrdrRef),validElement(SubmitrBaselnId))|

---

## Aspect ISO20022.Tsmt009001.BaselineAmendmentRequestV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrBkCtctPrsn|global::System.Collections.Generic.List<ISO20022.Tsmt009001.ContactIdentification3>||XmlElement()||
|+|SellrBkCtctPrsn|global::System.Collections.Generic.List<ISO20022.Tsmt009001.ContactIdentification1>||XmlElement()||
|+|BuyrBkCtctPrsn|global::System.Collections.Generic.List<ISO20022.Tsmt009001.ContactIdentification1>||XmlElement()||
|+|SellrCtctPrsn|global::System.Collections.Generic.List<ISO20022.Tsmt009001.ContactIdentification1>||XmlElement()||
|+|BuyrCtctPrsn|global::System.Collections.Generic.List<ISO20022.Tsmt009001.ContactIdentification1>||XmlElement()||
|+|Baseln|ISO20022.Tsmt009001.Baseline5||XmlElement()||
|+|SubmitrTxRef|ISO20022.Tsmt009001.SimpleIdentificationInformation||XmlElement()||
|+|TxId|ISO20022.Tsmt009001.SimpleIdentificationInformation||XmlElement()||
|+|ReqId|ISO20022.Tsmt009001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrBkCtctPrsn""",OthrBkCtctPrsn),validElement(OthrBkCtctPrsn),validList("""SellrBkCtctPrsn""",SellrBkCtctPrsn),validElement(SellrBkCtctPrsn),validList("""BuyrBkCtctPrsn""",BuyrBkCtctPrsn),validElement(BuyrBkCtctPrsn),validList("""SellrCtctPrsn""",SellrCtctPrsn),validElement(SellrCtctPrsn),validList("""BuyrCtctPrsn""",BuyrCtctPrsn),validElement(BuyrCtctPrsn),validElement(Baseln),validElement(SubmitrTxRef),validElement(TxId),validElement(ReqId))|

---

## Value ISO20022.Tsmt009001.CashAccount24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Tsmt009001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Tsmt009001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Tsmt009001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsmt009001.Charge24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Chrgs|global::System.Collections.Generic.List<ISO20022.Tsmt009001.ChargesDetails3>||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Chrgs""",Chrgs),validElement(Chrgs))|

---

## Enum ISO20022.Tsmt009001.ChargeType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRPT|Int32||XmlEnum("""TRPT""")|1|
||AIRF|Int32||XmlEnum("""AIRF""")|2|
||CHDE|Int32||XmlEnum("""CHDE""")|3|
||CHOR|Int32||XmlEnum("""CHOR""")|4|
||COLF|Int32||XmlEnum("""COLF""")|5|
||INSU|Int32||XmlEnum("""INSU""")|6|
||SECU|Int32||XmlEnum("""SECU""")|7|
||DNGR|Int32||XmlEnum("""DNGR""")|8|
||PICK|Int32||XmlEnum("""PICK""")|9|
||PACK|Int32||XmlEnum("""PACK""")|10|
||STOR|Int32||XmlEnum("""STOR""")|11|
||STDE|Int32||XmlEnum("""STDE""")|12|
||SIGN|Int32||XmlEnum("""SIGN""")|13|

---

## Value ISO20022.Tsmt009001.Charges5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|String||XmlElement()||
|+|Pctg|Decimal||XmlElement()||
|+|Amt|ISO20022.Tsmt009001.CurrencyAndAmount||XmlElement()||
|+|ChrgsPyee|String||XmlElement()||
|+|ChrgsPyer|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Tsmt009001.ChargesDetails3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtOrPctg|ISO20022.Tsmt009001.AmountOrPercentage2Choice||XmlElement()||
|+|Tp|ISO20022.Tsmt009001.ChargesType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtOrPctg),validElement(Tp))|

---

## Value ISO20022.Tsmt009001.ChargesType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrChrgsTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(OthrChrgsTp,Tp))|

---

## Value ISO20022.Tsmt009001.ContactIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EmailAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|Role|String||XmlElement()||
|+|GvnNm|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""PhneNb""",PhneNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Value ISO20022.Tsmt009001.ContactIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EmailAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|Role|String||XmlElement()||
|+|GvnNm|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|BIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""PhneNb""",PhneNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""BIC""",BIC,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Tsmt009001.CountrySubdivision1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Tsmt009001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsmt009001.CurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Type ISO20022.Tsmt009001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BaselnAmdmntReq|ISO20022.Tsmt009001.BaselineAmendmentRequestV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BaselnAmdmntReq))|

---

## Value ISO20022.Tsmt009001.DocumentIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Submitr|ISO20022.Tsmt009001.BICIdentification1||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Submitr))|

---

## Value ISO20022.Tsmt009001.DocumentIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtOfIsse|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt009001.FinancialInstitutionIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Tsmt009001.NameAndAddress6||XmlElement()||
|+|BIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validPattern("""BIC""",BIC,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,BIC))|

---

## Enum ISO20022.Tsmt009001.FreightCharges1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRPD|Int32||XmlEnum("""PRPD""")|1|
||CLCT|Int32||XmlEnum("""CLCT""")|2|

---

## Value ISO20022.Tsmt009001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Tsmt009001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Tsmt009001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt009001.GenericIdentification13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{1,4}"""))|

---

## Value ISO20022.Tsmt009001.GenericIdentification4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdTp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt009001.Incoterms4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lctn|String||XmlElement()||
|+|IncotrmsCd|ISO20022.Tsmt009001.Incoterms4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IncotrmsCd))|

---

## Value ISO20022.Tsmt009001.Incoterms4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Tsmt009001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Tsmt009001.InsuranceClauses1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||IRCE|Int32||XmlEnum("""IRCE""")|1|
||CMCC|Int32||XmlEnum("""CMCC""")|2|
||ISMC|Int32||XmlEnum("""ISMC""")|3|
||ICLC|Int32||XmlEnum("""ICLC""")|4|
||IREC|Int32||XmlEnum("""IREC""")|5|
||ISCC|Int32||XmlEnum("""ISCC""")|6|
||IWCC|Int32||XmlEnum("""IWCC""")|7|
||ICAI|Int32||XmlEnum("""ICAI""")|8|
||ICCC|Int32||XmlEnum("""ICCC""")|9|
||ICCB|Int32||XmlEnum("""ICCB""")|10|
||ICCA|Int32||XmlEnum("""ICCA""")|11|

---

## Value ISO20022.Tsmt009001.LineItem13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SellrDfndInf|global::System.Collections.Generic.List<ISO20022.Tsmt009001.UserDefinedInformation1>||XmlElement()||
|+|BuyrDfndInf|global::System.Collections.Generic.List<ISO20022.Tsmt009001.UserDefinedInformation1>||XmlElement()||
|+|TtlNetAmt|ISO20022.Tsmt009001.CurrencyAndAmount||XmlElement()||
|+|Tax|global::System.Collections.Generic.List<ISO20022.Tsmt009001.Tax23>||XmlElement()||
|+|FrghtChrgs|ISO20022.Tsmt009001.Charge24||XmlElement()||
|+|Adjstmnt|global::System.Collections.Generic.List<ISO20022.Tsmt009001.Adjustment7>||XmlElement()||
|+|Incotrms|ISO20022.Tsmt009001.Incoterms4||XmlElement()||
|+|RtgSummry|ISO20022.Tsmt009001.TransportMeans5||XmlElement()||
|+|LineItmsTtlAmt|ISO20022.Tsmt009001.CurrencyAndAmount||XmlElement()||
|+|LineItmDtls|global::System.Collections.Generic.List<ISO20022.Tsmt009001.LineItemDetails13>||XmlElement()||
|+|ShipmntDtRg|ISO20022.Tsmt009001.ShipmentDateRange1||XmlElement()||
|+|TrnsShipmnt|String||XmlElement()||
|+|PrtlShipmnt|String||XmlElement()||
|+|GoodsAndOrSvcsDesc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SellrDfndInf""",SellrDfndInf),validElement(SellrDfndInf),validList("""BuyrDfndInf""",BuyrDfndInf),validElement(BuyrDfndInf),validElement(TtlNetAmt),validList("""Tax""",Tax),validElement(Tax),validElement(FrghtChrgs),validList("""Adjstmnt""",Adjstmnt),validElement(Adjstmnt),validElement(Incotrms),validElement(RtgSummry),validElement(LineItmsTtlAmt),validRequired("""LineItmDtls""",LineItmDtls),validList("""LineItmDtls""",LineItmDtls),validElement(LineItmDtls),validElement(ShipmntDtRg))|

---

## Value ISO20022.Tsmt009001.LineItemDetails13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Incotrms|ISO20022.Tsmt009001.Incoterms4||XmlElement()||
|+|TtlAmt|ISO20022.Tsmt009001.CurrencyAndAmount||XmlElement()||
|+|Tax|global::System.Collections.Generic.List<ISO20022.Tsmt009001.Tax23>||XmlElement()||
|+|FrghtChrgs|ISO20022.Tsmt009001.Charge24||XmlElement()||
|+|Adjstmnt|global::System.Collections.Generic.List<ISO20022.Tsmt009001.Adjustment7>||XmlElement()||
|+|RtgSummry|ISO20022.Tsmt009001.TransportMeans5||XmlElement()||
|+|ShipmntSchdl|ISO20022.Tsmt009001.ShipmentSchedule2Choice||XmlElement()||
|+|PdctOrgn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PdctCtgy|global::System.Collections.Generic.List<ISO20022.Tsmt009001.ProductCategory1Choice>||XmlElement()||
|+|PdctChrtcs|global::System.Collections.Generic.List<ISO20022.Tsmt009001.ProductCharacteristics1Choice>||XmlElement()||
|+|PdctIdr|global::System.Collections.Generic.List<ISO20022.Tsmt009001.ProductIdentifier2Choice>||XmlElement()||
|+|PdctNm|String||XmlElement()||
|+|PricTlrnce|ISO20022.Tsmt009001.PercentageTolerance1||XmlElement()||
|+|UnitPric|ISO20022.Tsmt009001.UnitPrice18||XmlElement()||
|+|QtyTlrnce|ISO20022.Tsmt009001.PercentageTolerance1||XmlElement()||
|+|Qty|ISO20022.Tsmt009001.Quantity9||XmlElement()||
|+|LineItmId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Incotrms),validElement(TtlAmt),validList("""Tax""",Tax),validElement(Tax),validElement(FrghtChrgs),validList("""Adjstmnt""",Adjstmnt),validElement(Adjstmnt),validElement(RtgSummry),validElement(ShipmntSchdl),validPattern("""PdctOrgn""",PdctOrgn,"""[A-Z]{2,2}"""),validList("""PdctCtgy""",PdctCtgy),validElement(PdctCtgy),validList("""PdctChrtcs""",PdctChrtcs),validElement(PdctChrtcs),validList("""PdctIdr""",PdctIdr),validElement(PdctIdr),validElement(PricTlrnce),validElement(UnitPric),validElement(QtyTlrnce),validElement(Qty))|

---

## Value ISO20022.Tsmt009001.Location2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txt|String||XmlElement()||
|+|CtrySubDvsn|ISO20022.Tsmt009001.CountrySubdivision1Choice||XmlElement()||
|+|Ctry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtrySubDvsn),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Tsmt009001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt009001.MultimodalTransport3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PlcOfFnlDstn|String||XmlElement()||
|+|TakngInChrg|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt009001.NameAndAddress6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Tsmt009001.PostalAddress2||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Tsmt009001.NamePrefix1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MADM|Int32||XmlEnum("""MADM""")|1|
||MISS|Int32||XmlEnum("""MISS""")|2|
||MIST|Int32||XmlEnum("""MIST""")|3|
||DOCT|Int32||XmlEnum("""DOCT""")|4|

---

## Value ISO20022.Tsmt009001.PartyIdentification26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Tsmt009001.PostalAddress5||XmlElement()||
|+|PrtryId|ISO20022.Tsmt009001.GenericIdentification4||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validElement(PrtryId))|

---

## Value ISO20022.Tsmt009001.PartyIdentification27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|PrtryId|ISO20022.Tsmt009001.GenericIdentification4||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(PrtryId))|

---

## Value ISO20022.Tsmt009001.PaymentCodeOrOther1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPmtTerms|String||XmlElement()||
|+|PmtDueDt|DateTime||XmlElement()||
|+|PmtCd|ISO20022.Tsmt009001.PaymentPeriod3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PmtCd),validChoice(OthrPmtTerms,PmtDueDt,PmtCd))|

---

## Value ISO20022.Tsmt009001.PaymentCodeOrOther2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPmtTerms|String||XmlElement()||
|+|PmtDueDt|DateTime||XmlElement()||
|+|PmtCd|ISO20022.Tsmt009001.PaymentPeriod4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PmtCd),validChoice(OthrPmtTerms,PmtDueDt,PmtCd))|

---

## Value ISO20022.Tsmt009001.PaymentObligation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmTerms|ISO20022.Tsmt009001.SettlementTerms3||XmlElement()||
|+|PmtTerms|global::System.Collections.Generic.List<ISO20022.Tsmt009001.PaymentTerms4>||XmlElement()||
|+|PlcOfJursdctn|ISO20022.Tsmt009001.Location2||XmlElement()||
|+|AplblLaw|String||XmlElement()||
|+|AplblRules|ISO20022.Tsmt009001.BPOApplicableRules1Choice||XmlElement()||
|+|XpryDt|DateTime||XmlElement()||
|+|Chrgs|global::System.Collections.Generic.List<ISO20022.Tsmt009001.Charges5>||XmlElement()||
|+|PmtOblgtnAmt|ISO20022.Tsmt009001.AmountOrPercentage2Choice||XmlElement()||
|+|RcptBk|ISO20022.Tsmt009001.BICIdentification1||XmlElement()||
|+|OblgrBk|ISO20022.Tsmt009001.BICIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SttlmTerms),validList("""PmtTerms""",PmtTerms),validElement(PmtTerms),validElement(PlcOfJursdctn),validPattern("""AplblLaw""",AplblLaw,"""[A-Z]{2,2}"""),validElement(AplblRules),validList("""Chrgs""",Chrgs),validElement(Chrgs),validElement(PmtOblgtnAmt),validElement(RcptBk),validElement(OblgrBk))|

---

## Value ISO20022.Tsmt009001.PaymentPeriod3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NbOfDays|Decimal||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt009001.PaymentPeriod4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NbOfDays|Decimal||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt009001.PaymentTerms4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtOrPctg|ISO20022.Tsmt009001.AmountOrPercentage2Choice||XmlElement()||
|+|PmtTerms|ISO20022.Tsmt009001.PaymentCodeOrOther1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtOrPctg),validElement(PmtTerms))|

---

## Value ISO20022.Tsmt009001.PaymentTerms5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtOrPctg|ISO20022.Tsmt009001.AmountOrPercentage2Choice||XmlElement()||
|+|PmtTerms|ISO20022.Tsmt009001.PaymentCodeOrOther2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtOrPctg),validElement(PmtTerms))|

---

## Enum ISO20022.Tsmt009001.PaymentTime3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||IREC|Int32||XmlEnum("""IREC""")|1|
||CASH|Int32||XmlEnum("""CASH""")|2|
||EPSD|Int32||XmlEnum("""EPSD""")|3|
||EPRR|Int32||XmlEnum("""EPRR""")|4|
||EPPO|Int32||XmlEnum("""EPPO""")|5|
||EPAM|Int32||XmlEnum("""EPAM""")|6|
||EPIN|Int32||XmlEnum("""EPIN""")|7|
||PRMR|Int32||XmlEnum("""PRMR""")|8|
||PRMD|Int32||XmlEnum("""PRMD""")|9|
||EPRD|Int32||XmlEnum("""EPRD""")|10|
||EPBE|Int32||XmlEnum("""EPBE""")|11|
||EMTR|Int32||XmlEnum("""EMTR""")|12|
||EMTD|Int32||XmlEnum("""EMTD""")|13|

---

## Enum ISO20022.Tsmt009001.PaymentTime4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EMTD|Int32||XmlEnum("""EMTD""")|1|
||EMTR|Int32||XmlEnum("""EMTR""")|2|
||EPBE|Int32||XmlEnum("""EPBE""")|3|
||EPRD|Int32||XmlEnum("""EPRD""")|4|
||PRMD|Int32||XmlEnum("""PRMD""")|5|
||PRMR|Int32||XmlEnum("""PRMR""")|6|
||EPIN|Int32||XmlEnum("""EPIN""")|7|
||EPPO|Int32||XmlEnum("""EPPO""")|8|
||EPRR|Int32||XmlEnum("""EPRR""")|9|
||EPSD|Int32||XmlEnum("""EPSD""")|10|
||CASH|Int32||XmlEnum("""CASH""")|11|
||IREC|Int32||XmlEnum("""IREC""")|12|

---

## Value ISO20022.Tsmt009001.PercentageTolerance1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MnsPct|Decimal||XmlElement()||
|+|PlusPct|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt009001.PostalAddress2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCdId|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Tsmt009001.PostalAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCdId|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Tsmt009001.ProductCategory1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctgy|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt009001.ProductCategory1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPdctCtgy|ISO20022.Tsmt009001.GenericIdentification4||XmlElement()||
|+|StrdPdctCtgy|ISO20022.Tsmt009001.ProductCategory1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrPdctCtgy),validElement(StrdPdctCtgy),validChoice(OthrPdctCtgy,StrdPdctCtgy))|

---

## Enum ISO20022.Tsmt009001.ProductCategory1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GNDR|Int32||XmlEnum("""GNDR""")|1|
||LOBU|Int32||XmlEnum("""LOBU""")|2|
||PRGP|Int32||XmlEnum("""PRGP""")|3|
||QOTA|Int32||XmlEnum("""QOTA""")|4|
||HRTR|Int32||XmlEnum("""HRTR""")|5|

---

## Value ISO20022.Tsmt009001.ProductCharacteristics1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Chrtcs|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt009001.ProductCharacteristics1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPdctChrtcs|ISO20022.Tsmt009001.GenericIdentification4||XmlElement()||
|+|StrdPdctChrtcs|ISO20022.Tsmt009001.ProductCharacteristics1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrPdctChrtcs),validElement(StrdPdctChrtcs),validChoice(OthrPdctChrtcs,StrdPdctChrtcs))|

---

## Enum ISO20022.Tsmt009001.ProductCharacteristics1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VINR|Int32||XmlEnum("""VINR""")|1|
||STOR|Int32||XmlEnum("""STOR""")|2|
||SPRM|Int32||XmlEnum("""SPRM""")|3|
||SZRG|Int32||XmlEnum("""SZRG""")|4|
||SIZE|Int32||XmlEnum("""SIZE""")|5|
||SISP|Int32||XmlEnum("""SISP""")|6|
||PCTV|Int32||XmlEnum("""PCTV""")|7|
||ORCR|Int32||XmlEnum("""ORCR""")|8|
||OPTN|Int32||XmlEnum("""OPTN""")|9|
||ENNR|Int32||XmlEnum("""ENNR""")|10|
||EDSP|Int32||XmlEnum("""EDSP""")|11|
||CLOR|Int32||XmlEnum("""CLOR""")|12|
||CHNR|Int32||XmlEnum("""CHNR""")|13|
||BISP|Int32||XmlEnum("""BISP""")|14|

---

## Value ISO20022.Tsmt009001.ProductIdentifier2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Idr|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt009001.ProductIdentifier2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPdctIdr|ISO20022.Tsmt009001.GenericIdentification4||XmlElement()||
|+|StrdPdctIdr|ISO20022.Tsmt009001.ProductIdentifier2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrPdctIdr),validElement(StrdPdctIdr),validChoice(OthrPdctIdr,StrdPdctIdr))|

---

## Enum ISO20022.Tsmt009001.ProductIdentifier2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UPCC|Int32||XmlEnum("""UPCC""")|1|
||SUPI|Int32||XmlEnum("""SUPI""")|2|
||STYL|Int32||XmlEnum("""STYL""")|3|
||QOTA|Int32||XmlEnum("""QOTA""")|4|
||PART|Int32||XmlEnum("""PART""")|5|
||MODL|Int32||XmlEnum("""MODL""")|6|
||MANI|Int32||XmlEnum("""MANI""")|7|
||HRTR|Int32||XmlEnum("""HRTR""")|8|
||EANC|Int32||XmlEnum("""EANC""")|9|
||COMD|Int32||XmlEnum("""COMD""")|10|
||BINR|Int32||XmlEnum("""BINR""")|11|

---

## Value ISO20022.Tsmt009001.Quantity9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Fctr|String||XmlElement()||
|+|Val|Decimal||XmlElement()||
|+|UnitOfMeasr|ISO20022.Tsmt009001.UnitOfMeasure3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Fctr""",Fctr,"""[0-9]{1,15}"""),validElement(UnitOfMeasr))|

---

## Value ISO20022.Tsmt009001.RequiredSubmission2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Submitr|global::System.Collections.Generic.List<ISO20022.Tsmt009001.BICIdentification1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Submitr""",Submitr),validList("""Submitr""",Submitr),validElement(Submitr))|

---

## Value ISO20022.Tsmt009001.RequiredSubmission3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MtchAssrdPty|String||XmlElement()||
|+|ClausesReqrd|global::System.Collections.Generic.List<String>||XmlElement()||
|+|MtchAmt|String||XmlElement()||
|+|MtchTrnsprt|String||XmlElement()||
|+|MtchIsseDt|String||XmlElement()||
|+|MtchIssr|ISO20022.Tsmt009001.PartyIdentification27||XmlElement()||
|+|Submitr|global::System.Collections.Generic.List<ISO20022.Tsmt009001.BICIdentification1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MtchIssr),validRequired("""Submitr""",Submitr),validList("""Submitr""",Submitr),validElement(Submitr))|

---

## Value ISO20022.Tsmt009001.RequiredSubmission4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LineItmId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|MtchManfctr|ISO20022.Tsmt009001.PartyIdentification27||XmlElement()||
|+|MtchConsgn|String||XmlElement()||
|+|AuthrsdInspctrInd|String||XmlElement()||
|+|MtchInspctnDt|String||XmlElement()||
|+|MtchIsseDt|String||XmlElement()||
|+|MtchIssr|ISO20022.Tsmt009001.PartyIdentification27||XmlElement()||
|+|CertTp|String||XmlElement()||
|+|Submitr|global::System.Collections.Generic.List<ISO20022.Tsmt009001.BICIdentification1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MtchManfctr),validElement(MtchIssr),validRequired("""Submitr""",Submitr),validList("""Submitr""",Submitr),validElement(Submitr))|

---

## Value ISO20022.Tsmt009001.RequiredSubmission6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CertTpDesc|String||XmlElement()||
|+|CertTp|String||XmlElement()||
|+|Submitr|global::System.Collections.Generic.List<ISO20022.Tsmt009001.BICIdentification1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CertTp""",CertTp,"""[a-zA-Z0-9]{4}"""),validRequired("""Submitr""",Submitr),validList("""Submitr""",Submitr),validElement(Submitr))|

---

## Value ISO20022.Tsmt009001.SettlementTerms3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtrAcct|ISO20022.Tsmt009001.CashAccount24||XmlElement()||
|+|CdtrAgt|ISO20022.Tsmt009001.FinancialInstitutionIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdtrAcct),validElement(CdtrAgt))|

---

## Value ISO20022.Tsmt009001.ShipmentDateRange1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LatstShipmntDt|DateTime||XmlElement()||
|+|EarlstShipmntDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt009001.ShipmentDateRange2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LatstShipmntDt|DateTime||XmlElement()||
|+|EarlstShipmntDt|DateTime||XmlElement()||
|+|SubQtyVal|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt009001.ShipmentSchedule2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ShipmntSubSchdl|global::System.Collections.Generic.List<ISO20022.Tsmt009001.ShipmentDateRange2>||XmlElement()||
|+|ShipmntDtRg|ISO20022.Tsmt009001.ShipmentDateRange1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""ShipmntSubSchdl""",ShipmntSubSchdl),validListMin("""ShipmntSubSchdl""",ShipmntSubSchdl,2),validElement(ShipmntSubSchdl),validElement(ShipmntDtRg),validChoice(ShipmntSubSchdl,ShipmntDtRg))|

---

## Value ISO20022.Tsmt009001.SimpleIdentificationInformation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt009001.SingleTransport7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrnsprtByRail|global::System.Collections.Generic.List<ISO20022.Tsmt009001.TransportByRail5>||XmlElement()||
|+|TrnsprtByRoad|global::System.Collections.Generic.List<ISO20022.Tsmt009001.TransportByRoad5>||XmlElement()||
|+|TrnsprtBySea|global::System.Collections.Generic.List<ISO20022.Tsmt009001.TransportBySea6>||XmlElement()||
|+|TrnsprtByAir|global::System.Collections.Generic.List<ISO20022.Tsmt009001.TransportByAir5>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TrnsprtByRail""",TrnsprtByRail),validElement(TrnsprtByRail),validList("""TrnsprtByRoad""",TrnsprtByRoad),validElement(TrnsprtByRoad),validList("""TrnsprtBySea""",TrnsprtBySea),validElement(TrnsprtBySea),validList("""TrnsprtByAir""",TrnsprtByAir),validElement(TrnsprtByAir))|

---

## Value ISO20022.Tsmt009001.Tax23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtOrPctg|ISO20022.Tsmt009001.AmountOrPercentage2Choice||XmlElement()||
|+|Tp|ISO20022.Tsmt009001.TaxType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtOrPctg),validElement(Tp))|

---

## Value ISO20022.Tsmt009001.TaxType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrTaxTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(OthrTaxTp,Tp))|

---

## Enum ISO20022.Tsmt009001.TaxType9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CUST|Int32||XmlEnum("""CUST""")|1|
||VATA|Int32||XmlEnum("""VATA""")|2|
||COAX|Int32||XmlEnum("""COAX""")|3|
||STAM|Int32||XmlEnum("""STAM""")|4|
||WITH|Int32||XmlEnum("""WITH""")|5|
||STAT|Int32||XmlEnum("""STAT""")|6|
||NATI|Int32||XmlEnum("""NATI""")|7|
||PROV|Int32||XmlEnum("""PROV""")|8|

---

## Enum ISO20022.Tsmt009001.TradeCertificateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHYT|Int32||XmlEnum("""PHYT""")|1|
||HEAL|Int32||XmlEnum("""HEAL""")|2|
||ORIG|Int32||XmlEnum("""ORIG""")|3|
||WEIG|Int32||XmlEnum("""WEIG""")|4|
||QUAN|Int32||XmlEnum("""QUAN""")|5|
||QUAL|Int32||XmlEnum("""QUAL""")|6|
||ANLY|Int32||XmlEnum("""ANLY""")|7|

---

## Enum ISO20022.Tsmt009001.TradeFinanceService2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LEV3|Int32||XmlEnum("""LEV3""")|1|
||LEV2|Int32||XmlEnum("""LEV2""")|2|
||LEV1|Int32||XmlEnum("""LEV1""")|3|

---

## Value ISO20022.Tsmt009001.TransportByAir5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CrrierAgtCtry|String||XmlElement()||
|+|CrrierAgtNm|String||XmlElement()||
|+|AirCrrierCtry|String||XmlElement()||
|+|AirCrrierNm|String||XmlElement()||
|+|DstnAirprt|global::System.Collections.Generic.List<ISO20022.Tsmt009001.AirportName1Choice>||XmlElement()||
|+|DprtureAirprt|global::System.Collections.Generic.List<ISO20022.Tsmt009001.AirportName1Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CrrierAgtCtry""",CrrierAgtCtry,"""[A-Z]{2,2}"""),validPattern("""AirCrrierCtry""",AirCrrierCtry,"""[A-Z]{2,2}"""),validRequired("""DstnAirprt""",DstnAirprt),validList("""DstnAirprt""",DstnAirprt),validElement(DstnAirprt),validList("""DprtureAirprt""",DprtureAirprt),validElement(DprtureAirprt))|

---

## Value ISO20022.Tsmt009001.TransportByRail5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CrrierAgtCtry|String||XmlElement()||
|+|CrrierAgtNm|String||XmlElement()||
|+|RailCrrierCtry|String||XmlElement()||
|+|RailCrrierNm|String||XmlElement()||
|+|PlcOfDlvry|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PlcOfRct|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CrrierAgtCtry""",CrrierAgtCtry,"""[A-Z]{2,2}"""),validPattern("""RailCrrierCtry""",RailCrrierCtry,"""[A-Z]{2,2}"""),validRequired("""PlcOfDlvry""",PlcOfDlvry))|

---

## Value ISO20022.Tsmt009001.TransportByRoad5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CrrierAgtCtry|String||XmlElement()||
|+|CrrierAgtNm|String||XmlElement()||
|+|RoadCrrierCtry|String||XmlElement()||
|+|RoadCrrierNm|String||XmlElement()||
|+|PlcOfDlvry|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PlcOfRct|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CrrierAgtCtry""",CrrierAgtCtry,"""[A-Z]{2,2}"""),validPattern("""RoadCrrierCtry""",RoadCrrierCtry,"""[A-Z]{2,2}"""),validRequired("""PlcOfDlvry""",PlcOfDlvry))|

---

## Value ISO20022.Tsmt009001.TransportBySea6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CrrierAgtCtry|String||XmlElement()||
|+|CrrierAgtNm|String||XmlElement()||
|+|SeaCrrierCtry|String||XmlElement()||
|+|SeaCrrierNm|String||XmlElement()||
|+|VsslNm|String||XmlElement()||
|+|PortOfDschrge|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PortOfLoadng|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CrrierAgtCtry""",CrrierAgtCtry,"""[A-Z]{2,2}"""),validPattern("""SeaCrrierCtry""",SeaCrrierCtry,"""[A-Z]{2,2}"""),validRequired("""PortOfDschrge""",PortOfDschrge))|

---

## Value ISO20022.Tsmt009001.TransportMeans5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MltmdlTrnsprt|ISO20022.Tsmt009001.MultimodalTransport3||XmlElement()||
|+|IndvTrnsprt|ISO20022.Tsmt009001.SingleTransport7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MltmdlTrnsprt),validElement(IndvTrnsprt))|

---

## Value ISO20022.Tsmt009001.UnitOfMeasure3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrUnitOfMeasr|String||XmlElement()||
|+|UnitOfMeasrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(OthrUnitOfMeasr,UnitOfMeasrCd))|

---

## Enum ISO20022.Tsmt009001.UnitOfMeasure4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TNE|Int32||XmlEnum("""TNE""")|1|
||BL|Int32||XmlEnum("""BL""")|2|
||BG|Int32||XmlEnum("""BG""")|3|
||OZA|Int32||XmlEnum("""OZA""")|4|
||OZI|Int32||XmlEnum("""OZI""")|5|
||MTQ|Int32||XmlEnum("""MTQ""")|6|
||INQ|Int32||XmlEnum("""INQ""")|7|
||CR|Int32||XmlEnum("""CR""")|8|
||CH|Int32||XmlEnum("""CH""")|9|
||CT|Int32||XmlEnum("""CT""")|10|
||BO|Int32||XmlEnum("""BO""")|11|
||BX|Int32||XmlEnum("""BX""")|12|
||BLL|Int32||XmlEnum("""BLL""")|13|
||STN|Int32||XmlEnum("""STN""")|14|
||LBR|Int32||XmlEnum("""LBR""")|15|
||LTR|Int32||XmlEnum("""LTR""")|16|
||CLT|Int32||XmlEnum("""CLT""")|17|
||MMQ|Int32||XmlEnum("""MMQ""")|18|
||KMK|Int32||XmlEnum("""KMK""")|19|
||CMK|Int32||XmlEnum("""CMK""")|20|
||MMK|Int32||XmlEnum("""MMK""")|21|
||YDK|Int32||XmlEnum("""YDK""")|22|
||KTM|Int32||XmlEnum("""KTM""")|23|
||MMT|Int32||XmlEnum("""MMT""")|24|
||GLL|Int32||XmlEnum("""GLL""")|25|
||QT|Int32||XmlEnum("""QT""")|26|
||QTI|Int32||XmlEnum("""QTI""")|27|
||PT|Int32||XmlEnum("""PT""")|28|
||PTI|Int32||XmlEnum("""PTI""")|29|
||ONZ|Int32||XmlEnum("""ONZ""")|30|
||MIK|Int32||XmlEnum("""MIK""")|31|
||FTK|Int32||XmlEnum("""FTK""")|32|
||INK|Int32||XmlEnum("""INK""")|33|
||E1A|Int32||XmlEnum("""1A""")|34|
||FOT|Int32||XmlEnum("""FOT""")|35|
||MTK|Int32||XmlEnum("""MTK""")|36|
||CMT|Int32||XmlEnum("""CMT""")|37|
||GRM|Int32||XmlEnum("""GRM""")|38|
||GLI|Int32||XmlEnum("""GLI""")|39|
||LY|Int32||XmlEnum("""LY""")|40|
||INH|Int32||XmlEnum("""INH""")|41|
||MTR|Int32||XmlEnum("""MTR""")|42|
||LTN|Int32||XmlEnum("""LTN""")|43|
||EA|Int32||XmlEnum("""EA""")|44|
||KGM|Int32||XmlEnum("""KGM""")|45|

---

## Value ISO20022.Tsmt009001.UnitPrice18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Fctr|String||XmlElement()||
|+|Amt|ISO20022.Tsmt009001.CurrencyAndAmount||XmlElement()||
|+|UnitPric|ISO20022.Tsmt009001.UnitOfMeasure3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Fctr""",Fctr,"""[0-9]{1,15}"""),validElement(Amt),validElement(UnitPric))|

---

## Value ISO20022.Tsmt009001.UserDefinedInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Inf|String||XmlElement()||
|+|Labl|String||XmlElement()||
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

