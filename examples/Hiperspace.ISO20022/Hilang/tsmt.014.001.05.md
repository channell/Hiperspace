# tsmt.014.001.05
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Tsmt014001.AccountIdentification4Choice {
        + Othr  : ISO20022.Tsmt014001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Tsmt014001.AccountIdentification4Choice *-- ISO20022.Tsmt014001.GenericAccountIdentification1
    class ISO20022.Tsmt014001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Tsmt014001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Tsmt014001.Adjustment6 {
        + Amt  : ISO20022.Tsmt014001.CurrencyAndAmount
        + Drctn  : String
        + Tp  : ISO20022.Tsmt014001.AdjustmentType1Choice
    }
    ISO20022.Tsmt014001.Adjustment6 *-- ISO20022.Tsmt014001.CurrencyAndAmount
    ISO20022.Tsmt014001.Adjustment6 *-- ISO20022.Tsmt014001.AdjustmentType1Choice
    class ISO20022.Tsmt014001.AdjustmentDirection1Code {
        SUBS = 1
        ADDD = 2
    }
    class ISO20022.Tsmt014001.AdjustmentType1Choice {
        + OthrAdjstmntTp  : String
        + Tp  : String
    }
    class ISO20022.Tsmt014001.AdjustmentType2Code {
        SURC = 1
        CREN = 2
        DISC = 3
        REBA = 4
    }
    class ISO20022.Tsmt014001.AirportDescription1 {
        + AirprtNm  : String
        + Twn  : String
    }
    class ISO20022.Tsmt014001.AirportName1Choice {
        + OthrAirprtDesc  : ISO20022.Tsmt014001.AirportDescription1
        + AirprtCd  : String
    }
    ISO20022.Tsmt014001.AirportName1Choice *-- ISO20022.Tsmt014001.AirportDescription1
    class ISO20022.Tsmt014001.AmountOrPercentage2Choice {
        + Pctg  : Decimal
        + Amt  : ISO20022.Tsmt014001.ActiveCurrencyAndAmount
    }
    ISO20022.Tsmt014001.AmountOrPercentage2Choice *-- ISO20022.Tsmt014001.ActiveCurrencyAndAmount
    class ISO20022.Tsmt014001.BICIdentification1 {
        + BIC  : String
    }
    class ISO20022.Tsmt014001.CashAccount24 {
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Tsmt014001.CashAccountType2Choice
        + Id  : ISO20022.Tsmt014001.AccountIdentification4Choice
    }
    ISO20022.Tsmt014001.CashAccount24 *-- ISO20022.Tsmt014001.CashAccountType2Choice
    ISO20022.Tsmt014001.CashAccount24 *-- ISO20022.Tsmt014001.AccountIdentification4Choice
    class ISO20022.Tsmt014001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Tsmt014001.CertificateDataSet2 {
        + AddtlInf  : global::System.Collections.Generic.List~String~
        + Manfctr  : ISO20022.Tsmt014001.PartyIdentification26
        + Consgn  : ISO20022.Tsmt014001.PartyIdentification26
        + Consgnr  : ISO20022.Tsmt014001.PartyIdentification26
        + GoodsDesc  : String
        + Trnsprt  : ISO20022.Tsmt014001.SingleTransport3
        + CertId  : String
        + AuthrsdInspctrInd  : String
        + InspctnDt  : ISO20022.Tsmt014001.DatePeriodDetails
        + Issr  : ISO20022.Tsmt014001.PartyIdentification26
        + PlcOfIsse  : ISO20022.Tsmt014001.PostalAddress5
        + IsseDt  : DateTime
        + CertfdChrtcs  : ISO20022.Tsmt014001.CertifiedCharacteristics2Choice
        + LineItm  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.LineItemAndPOIdentification1~
        + CertTp  : String
        + DataSetId  : ISO20022.Tsmt014001.DocumentIdentification1
    }
    ISO20022.Tsmt014001.CertificateDataSet2 *-- ISO20022.Tsmt014001.PartyIdentification26
    ISO20022.Tsmt014001.CertificateDataSet2 *-- ISO20022.Tsmt014001.PartyIdentification26
    ISO20022.Tsmt014001.CertificateDataSet2 *-- ISO20022.Tsmt014001.PartyIdentification26
    ISO20022.Tsmt014001.CertificateDataSet2 *-- ISO20022.Tsmt014001.SingleTransport3
    ISO20022.Tsmt014001.CertificateDataSet2 *-- ISO20022.Tsmt014001.DatePeriodDetails
    ISO20022.Tsmt014001.CertificateDataSet2 *-- ISO20022.Tsmt014001.PartyIdentification26
    ISO20022.Tsmt014001.CertificateDataSet2 *-- ISO20022.Tsmt014001.PostalAddress5
    ISO20022.Tsmt014001.CertificateDataSet2 *-- ISO20022.Tsmt014001.CertifiedCharacteristics2Choice
    ISO20022.Tsmt014001.CertificateDataSet2 *-- ISO20022.Tsmt014001.LineItemAndPOIdentification1
    ISO20022.Tsmt014001.CertificateDataSet2 *-- ISO20022.Tsmt014001.DocumentIdentification1
    class ISO20022.Tsmt014001.CertifiedCharacteristics2Choice {
        + PhytosntryIndctn  : String
        + HlthIndctn  : String
        + Qty  : ISO20022.Tsmt014001.Quantity9
        + Wght  : ISO20022.Tsmt014001.Quantity9
        + Anlys  : String
        + Qlty  : String
        + Orgn  : String
    }
    ISO20022.Tsmt014001.CertifiedCharacteristics2Choice *-- ISO20022.Tsmt014001.Quantity9
    ISO20022.Tsmt014001.CertifiedCharacteristics2Choice *-- ISO20022.Tsmt014001.Quantity9
    class ISO20022.Tsmt014001.Charge25 {
        + Chrgs  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.ChargesDetails4~
        + Tp  : String
    }
    ISO20022.Tsmt014001.Charge25 *-- ISO20022.Tsmt014001.ChargesDetails4
    class ISO20022.Tsmt014001.ChargeType8Code {
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
    class ISO20022.Tsmt014001.ChargesDetails4 {
        + Amt  : ISO20022.Tsmt014001.CurrencyAndAmount
        + ChrgsTp  : ISO20022.Tsmt014001.ChargesType1Choice
    }
    ISO20022.Tsmt014001.ChargesDetails4 *-- ISO20022.Tsmt014001.CurrencyAndAmount
    ISO20022.Tsmt014001.ChargesDetails4 *-- ISO20022.Tsmt014001.ChargesType1Choice
    class ISO20022.Tsmt014001.ChargesType1Choice {
        + OthrChrgsTp  : String
        + Tp  : String
    }
    class ISO20022.Tsmt014001.CommercialDataSet5 {
        + SttlmTerms  : ISO20022.Tsmt014001.SettlementTerms3
        + PmtTerms  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.PaymentTerms4~
        + Goods  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.LineItem15~
        + BllTo  : ISO20022.Tsmt014001.PartyIdentification26
        + Sellr  : ISO20022.Tsmt014001.PartyIdentification26
        + Buyr  : ISO20022.Tsmt014001.PartyIdentification26
        + ComrclDocRef  : ISO20022.Tsmt014001.InvoiceIdentification1
        + DataSetId  : ISO20022.Tsmt014001.DocumentIdentification1
    }
    ISO20022.Tsmt014001.CommercialDataSet5 *-- ISO20022.Tsmt014001.SettlementTerms3
    ISO20022.Tsmt014001.CommercialDataSet5 *-- ISO20022.Tsmt014001.PaymentTerms4
    ISO20022.Tsmt014001.CommercialDataSet5 *-- ISO20022.Tsmt014001.LineItem15
    ISO20022.Tsmt014001.CommercialDataSet5 *-- ISO20022.Tsmt014001.PartyIdentification26
    ISO20022.Tsmt014001.CommercialDataSet5 *-- ISO20022.Tsmt014001.PartyIdentification26
    ISO20022.Tsmt014001.CommercialDataSet5 *-- ISO20022.Tsmt014001.PartyIdentification26
    ISO20022.Tsmt014001.CommercialDataSet5 *-- ISO20022.Tsmt014001.InvoiceIdentification1
    ISO20022.Tsmt014001.CommercialDataSet5 *-- ISO20022.Tsmt014001.DocumentIdentification1
    class ISO20022.Tsmt014001.Consignment3 {
        + TtlWght  : ISO20022.Tsmt014001.Quantity10
        + TtlVol  : ISO20022.Tsmt014001.Quantity10
        + TtlQty  : ISO20022.Tsmt014001.Quantity10
    }
    ISO20022.Tsmt014001.Consignment3 *-- ISO20022.Tsmt014001.Quantity10
    ISO20022.Tsmt014001.Consignment3 *-- ISO20022.Tsmt014001.Quantity10
    ISO20022.Tsmt014001.Consignment3 *-- ISO20022.Tsmt014001.Quantity10
    class ISO20022.Tsmt014001.CurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Tsmt014001.DataSetSubmissionReferences3 {
        + ForcdMtch  : String
        + SubmitrTxRef  : String
        + PurchsOrdrRef  : ISO20022.Tsmt014001.DocumentIdentification7
        + TxId  : String
    }
    ISO20022.Tsmt014001.DataSetSubmissionReferences3 *-- ISO20022.Tsmt014001.DocumentIdentification7
    class ISO20022.Tsmt014001.DataSetSubmissionV05 {
        + OthrCertDataSet  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.OtherCertificateDataSet2~
        + CertDataSet  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.CertificateDataSet2~
        + InsrncDataSet  : ISO20022.Tsmt014001.InsuranceDataSet1
        + TrnsprtDataSet  : ISO20022.Tsmt014001.TransportDataSet5
        + ComrclDataSet  : ISO20022.Tsmt014001.CommercialDataSet5
        + SellrBk  : ISO20022.Tsmt014001.BICIdentification1
        + BuyrBk  : ISO20022.Tsmt014001.BICIdentification1
        + Instr  : ISO20022.Tsmt014001.InstructionType3
        + CmonSubmissnRef  : ISO20022.Tsmt014001.SimpleIdentificationInformation
        + RltdTxRefs  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.DataSetSubmissionReferences3~
        + SubmissnId  : ISO20022.Tsmt014001.MessageIdentification1
    }
    ISO20022.Tsmt014001.DataSetSubmissionV05 *-- ISO20022.Tsmt014001.OtherCertificateDataSet2
    ISO20022.Tsmt014001.DataSetSubmissionV05 *-- ISO20022.Tsmt014001.CertificateDataSet2
    ISO20022.Tsmt014001.DataSetSubmissionV05 *-- ISO20022.Tsmt014001.InsuranceDataSet1
    ISO20022.Tsmt014001.DataSetSubmissionV05 *-- ISO20022.Tsmt014001.TransportDataSet5
    ISO20022.Tsmt014001.DataSetSubmissionV05 *-- ISO20022.Tsmt014001.CommercialDataSet5
    ISO20022.Tsmt014001.DataSetSubmissionV05 *-- ISO20022.Tsmt014001.BICIdentification1
    ISO20022.Tsmt014001.DataSetSubmissionV05 *-- ISO20022.Tsmt014001.BICIdentification1
    ISO20022.Tsmt014001.DataSetSubmissionV05 *-- ISO20022.Tsmt014001.InstructionType3
    ISO20022.Tsmt014001.DataSetSubmissionV05 *-- ISO20022.Tsmt014001.SimpleIdentificationInformation
    ISO20022.Tsmt014001.DataSetSubmissionV05 *-- ISO20022.Tsmt014001.DataSetSubmissionReferences3
    ISO20022.Tsmt014001.DataSetSubmissionV05 *-- ISO20022.Tsmt014001.MessageIdentification1
    class ISO20022.Tsmt014001.DatePeriodDetails {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Tsmt014001.DocumentIdentification1 {
        + Submitr  : ISO20022.Tsmt014001.BICIdentification1
        + Vrsn  : Decimal
        + Id  : String
    }
    ISO20022.Tsmt014001.DocumentIdentification1 *-- ISO20022.Tsmt014001.BICIdentification1
    class ISO20022.Tsmt014001.DocumentIdentification7 {
        + DtOfIsse  : DateTime
        + Id  : String
    }
    class ISO20022.Tsmt014001.FinancialInstitutionIdentification4Choice {
        + NmAndAdr  : ISO20022.Tsmt014001.NameAndAddress6
        + BIC  : String
    }
    ISO20022.Tsmt014001.FinancialInstitutionIdentification4Choice *-- ISO20022.Tsmt014001.NameAndAddress6
    class ISO20022.Tsmt014001.FreightCharges1Code {
        PRPD = 1
        CLCT = 2
    }
    class ISO20022.Tsmt014001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Tsmt014001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Tsmt014001.GenericAccountIdentification1 *-- ISO20022.Tsmt014001.AccountSchemeName1Choice
    class ISO20022.Tsmt014001.GenericIdentification13 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Tsmt014001.GenericIdentification4 {
        + IdTp  : String
        + Id  : String
    }
    class ISO20022.Tsmt014001.Incoterms4 {
        + Lctn  : String
        + IncotrmsCd  : ISO20022.Tsmt014001.Incoterms4Choice
    }
    ISO20022.Tsmt014001.Incoterms4 *-- ISO20022.Tsmt014001.Incoterms4Choice
    class ISO20022.Tsmt014001.Incoterms4Choice {
        + Prtry  : ISO20022.Tsmt014001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Tsmt014001.Incoterms4Choice *-- ISO20022.Tsmt014001.GenericIdentification13
    class ISO20022.Tsmt014001.InstructionType3 {
        + Tp  : String
    }
    class ISO20022.Tsmt014001.InstructionType3Code {
        PMTC = 1
        MTCH = 2
    }
    class ISO20022.Tsmt014001.InsuranceClauses1Code {
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
    class ISO20022.Tsmt014001.InsuranceDataSet1 {
        + ClmsPyblIn  : String
        + ClmsPyblAt  : ISO20022.Tsmt014001.PostalAddress5
        + Assrd  : ISO20022.Tsmt014001.PartyIdentification29Choice
        + InsrncClauses  : global::System.Collections.Generic.List~String~
        + InsrncConds  : global::System.Collections.Generic.List~String~
        + InsrdGoodsDesc  : String
        + InsrdAmt  : ISO20022.Tsmt014001.CurrencyAndAmount
        + Trnsprt  : ISO20022.Tsmt014001.SingleTransport3
        + InsrncDocId  : String
        + PlcOfIsse  : ISO20022.Tsmt014001.PostalAddress5
        + FctvDt  : DateTime
        + IsseDt  : DateTime
        + Issr  : ISO20022.Tsmt014001.PartyIdentification26
        + DataSetId  : ISO20022.Tsmt014001.DocumentIdentification1
    }
    ISO20022.Tsmt014001.InsuranceDataSet1 *-- ISO20022.Tsmt014001.PostalAddress5
    ISO20022.Tsmt014001.InsuranceDataSet1 *-- ISO20022.Tsmt014001.PartyIdentification29Choice
    ISO20022.Tsmt014001.InsuranceDataSet1 *-- ISO20022.Tsmt014001.CurrencyAndAmount
    ISO20022.Tsmt014001.InsuranceDataSet1 *-- ISO20022.Tsmt014001.SingleTransport3
    ISO20022.Tsmt014001.InsuranceDataSet1 *-- ISO20022.Tsmt014001.PostalAddress5
    ISO20022.Tsmt014001.InsuranceDataSet1 *-- ISO20022.Tsmt014001.PartyIdentification26
    ISO20022.Tsmt014001.InsuranceDataSet1 *-- ISO20022.Tsmt014001.DocumentIdentification1
    class ISO20022.Tsmt014001.InvoiceIdentification1 {
        + IsseDt  : DateTime
        + InvcNb  : String
    }
    class ISO20022.Tsmt014001.LineItem15 {
        + Incotrms  : ISO20022.Tsmt014001.Incoterms4
        + SellrDfndInf  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.UserDefinedInformation1~
        + BuyrDfndInf  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.UserDefinedInformation1~
        + TtlNetAmt  : ISO20022.Tsmt014001.CurrencyAndAmount
        + Tax  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.Tax22~
        + FrghtChrgs  : ISO20022.Tsmt014001.Charge25
        + Adjstmnt  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.Adjustment6~
        + LineItmsTtlAmt  : ISO20022.Tsmt014001.CurrencyAndAmount
        + ComrclLineItms  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.LineItemDetails14~
        + FnlSubmissn  : String
        + PurchsOrdrRef  : ISO20022.Tsmt014001.DocumentIdentification7
    }
    ISO20022.Tsmt014001.LineItem15 *-- ISO20022.Tsmt014001.Incoterms4
    ISO20022.Tsmt014001.LineItem15 *-- ISO20022.Tsmt014001.UserDefinedInformation1
    ISO20022.Tsmt014001.LineItem15 *-- ISO20022.Tsmt014001.UserDefinedInformation1
    ISO20022.Tsmt014001.LineItem15 *-- ISO20022.Tsmt014001.CurrencyAndAmount
    ISO20022.Tsmt014001.LineItem15 *-- ISO20022.Tsmt014001.Tax22
    ISO20022.Tsmt014001.LineItem15 *-- ISO20022.Tsmt014001.Charge25
    ISO20022.Tsmt014001.LineItem15 *-- ISO20022.Tsmt014001.Adjustment6
    ISO20022.Tsmt014001.LineItem15 *-- ISO20022.Tsmt014001.CurrencyAndAmount
    ISO20022.Tsmt014001.LineItem15 *-- ISO20022.Tsmt014001.LineItemDetails14
    ISO20022.Tsmt014001.LineItem15 *-- ISO20022.Tsmt014001.DocumentIdentification7
    class ISO20022.Tsmt014001.LineItemAndPOIdentification1 {
        + PurchsOrdrRef  : ISO20022.Tsmt014001.DocumentIdentification7
        + LineItmId  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Tsmt014001.LineItemAndPOIdentification1 *-- ISO20022.Tsmt014001.DocumentIdentification7
    class ISO20022.Tsmt014001.LineItemDetails14 {
        + TtlAmt  : ISO20022.Tsmt014001.CurrencyAndAmount
        + Tax  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.Tax22~
        + FrghtChrgs  : ISO20022.Tsmt014001.Charge25
        + Adjstmnt  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.Adjustment6~
        + PdctOrgn  : String
        + PdctCtgy  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.ProductCategory1Choice~
        + PdctChrtcs  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.ProductCharacteristics1Choice~
        + PdctIdr  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.ProductIdentifier2Choice~
        + PdctNm  : String
        + UnitPric  : ISO20022.Tsmt014001.UnitPrice18
        + Qty  : ISO20022.Tsmt014001.Quantity9
        + LineItmId  : String
    }
    ISO20022.Tsmt014001.LineItemDetails14 *-- ISO20022.Tsmt014001.CurrencyAndAmount
    ISO20022.Tsmt014001.LineItemDetails14 *-- ISO20022.Tsmt014001.Tax22
    ISO20022.Tsmt014001.LineItemDetails14 *-- ISO20022.Tsmt014001.Charge25
    ISO20022.Tsmt014001.LineItemDetails14 *-- ISO20022.Tsmt014001.Adjustment6
    ISO20022.Tsmt014001.LineItemDetails14 *-- ISO20022.Tsmt014001.ProductCategory1Choice
    ISO20022.Tsmt014001.LineItemDetails14 *-- ISO20022.Tsmt014001.ProductCharacteristics1Choice
    ISO20022.Tsmt014001.LineItemDetails14 *-- ISO20022.Tsmt014001.ProductIdentifier2Choice
    ISO20022.Tsmt014001.LineItemDetails14 *-- ISO20022.Tsmt014001.UnitPrice18
    ISO20022.Tsmt014001.LineItemDetails14 *-- ISO20022.Tsmt014001.Quantity9
    class ISO20022.Tsmt014001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Tsmt014001.MultimodalTransport3 {
        + PlcOfFnlDstn  : String
        + TakngInChrg  : String
    }
    class ISO20022.Tsmt014001.NameAndAddress6 {
        + Adr  : ISO20022.Tsmt014001.PostalAddress2
        + Nm  : String
    }
    ISO20022.Tsmt014001.NameAndAddress6 *-- ISO20022.Tsmt014001.PostalAddress2
    class ISO20022.Tsmt014001.OtherCertificateDataSet2 {
        + CertInf  : global::System.Collections.Generic.List~String~
        + Issr  : ISO20022.Tsmt014001.PartyIdentification26
        + IsseDt  : DateTime
        + CertTp  : String
        + CertId  : String
        + DataSetId  : ISO20022.Tsmt014001.DocumentIdentification1
    }
    ISO20022.Tsmt014001.OtherCertificateDataSet2 *-- ISO20022.Tsmt014001.PartyIdentification26
    ISO20022.Tsmt014001.OtherCertificateDataSet2 *-- ISO20022.Tsmt014001.DocumentIdentification1
    class ISO20022.Tsmt014001.PartyIdentification26 {
        + PstlAdr  : ISO20022.Tsmt014001.PostalAddress5
        + PrtryId  : ISO20022.Tsmt014001.GenericIdentification4
        + Nm  : String
    }
    ISO20022.Tsmt014001.PartyIdentification26 *-- ISO20022.Tsmt014001.PostalAddress5
    ISO20022.Tsmt014001.PartyIdentification26 *-- ISO20022.Tsmt014001.GenericIdentification4
    class ISO20022.Tsmt014001.PartyIdentification29Choice {
        + NmAndAdr  : ISO20022.Tsmt014001.PartyIdentification26
        + BIC  : String
    }
    ISO20022.Tsmt014001.PartyIdentification29Choice *-- ISO20022.Tsmt014001.PartyIdentification26
    class ISO20022.Tsmt014001.PaymentCodeOrOther1Choice {
        + OthrPmtTerms  : String
        + PmtDueDt  : DateTime
        + PmtCd  : ISO20022.Tsmt014001.PaymentPeriod3
    }
    ISO20022.Tsmt014001.PaymentCodeOrOther1Choice *-- ISO20022.Tsmt014001.PaymentPeriod3
    class ISO20022.Tsmt014001.PaymentPeriod3 {
        + NbOfDays  : Decimal
        + Cd  : String
    }
    class ISO20022.Tsmt014001.PaymentTerms4 {
        + AmtOrPctg  : ISO20022.Tsmt014001.AmountOrPercentage2Choice
        + PmtTerms  : ISO20022.Tsmt014001.PaymentCodeOrOther1Choice
    }
    ISO20022.Tsmt014001.PaymentTerms4 *-- ISO20022.Tsmt014001.AmountOrPercentage2Choice
    ISO20022.Tsmt014001.PaymentTerms4 *-- ISO20022.Tsmt014001.PaymentCodeOrOther1Choice
    class ISO20022.Tsmt014001.PaymentTime3Code {
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
    class ISO20022.Tsmt014001.PostalAddress2 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCdId  : String
        + StrtNm  : String
    }
    class ISO20022.Tsmt014001.PostalAddress5 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCdId  : String
        + StrtNm  : String
    }
    class ISO20022.Tsmt014001.ProductCategory1 {
        + Ctgy  : String
        + Tp  : String
    }
    class ISO20022.Tsmt014001.ProductCategory1Choice {
        + OthrPdctCtgy  : ISO20022.Tsmt014001.GenericIdentification4
        + StrdPdctCtgy  : ISO20022.Tsmt014001.ProductCategory1
    }
    ISO20022.Tsmt014001.ProductCategory1Choice *-- ISO20022.Tsmt014001.GenericIdentification4
    ISO20022.Tsmt014001.ProductCategory1Choice *-- ISO20022.Tsmt014001.ProductCategory1
    class ISO20022.Tsmt014001.ProductCategory1Code {
        GNDR = 1
        LOBU = 2
        PRGP = 3
        QOTA = 4
        HRTR = 5
    }
    class ISO20022.Tsmt014001.ProductCharacteristics1 {
        + Chrtcs  : String
        + Tp  : String
    }
    class ISO20022.Tsmt014001.ProductCharacteristics1Choice {
        + OthrPdctChrtcs  : ISO20022.Tsmt014001.GenericIdentification4
        + StrdPdctChrtcs  : ISO20022.Tsmt014001.ProductCharacteristics1
    }
    ISO20022.Tsmt014001.ProductCharacteristics1Choice *-- ISO20022.Tsmt014001.GenericIdentification4
    ISO20022.Tsmt014001.ProductCharacteristics1Choice *-- ISO20022.Tsmt014001.ProductCharacteristics1
    class ISO20022.Tsmt014001.ProductCharacteristics1Code {
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
    class ISO20022.Tsmt014001.ProductIdentifier2 {
        + Idr  : String
        + Tp  : String
    }
    class ISO20022.Tsmt014001.ProductIdentifier2Choice {
        + OthrPdctIdr  : ISO20022.Tsmt014001.GenericIdentification4
        + StrdPdctIdr  : ISO20022.Tsmt014001.ProductIdentifier2
    }
    ISO20022.Tsmt014001.ProductIdentifier2Choice *-- ISO20022.Tsmt014001.GenericIdentification4
    ISO20022.Tsmt014001.ProductIdentifier2Choice *-- ISO20022.Tsmt014001.ProductIdentifier2
    class ISO20022.Tsmt014001.ProductIdentifier2Code {
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
    class ISO20022.Tsmt014001.Quantity10 {
        + Val  : Decimal
        + UnitOfMeasr  : ISO20022.Tsmt014001.UnitOfMeasure3Choice
    }
    ISO20022.Tsmt014001.Quantity10 *-- ISO20022.Tsmt014001.UnitOfMeasure3Choice
    class ISO20022.Tsmt014001.Quantity9 {
        + Fctr  : String
        + Val  : Decimal
        + UnitOfMeasr  : ISO20022.Tsmt014001.UnitOfMeasure3Choice
    }
    ISO20022.Tsmt014001.Quantity9 *-- ISO20022.Tsmt014001.UnitOfMeasure3Choice
    class ISO20022.Tsmt014001.SettlementTerms3 {
        + CdtrAcct  : ISO20022.Tsmt014001.CashAccount24
        + CdtrAgt  : ISO20022.Tsmt014001.FinancialInstitutionIdentification4Choice
    }
    ISO20022.Tsmt014001.SettlementTerms3 *-- ISO20022.Tsmt014001.CashAccount24
    ISO20022.Tsmt014001.SettlementTerms3 *-- ISO20022.Tsmt014001.FinancialInstitutionIdentification4Choice
    class ISO20022.Tsmt014001.ShipmentDate1Choice {
        + ActlShipmntDt  : DateTime
        + PropsdShipmntDt  : DateTime
    }
    class ISO20022.Tsmt014001.SimpleIdentificationInformation {
        + Id  : String
    }
    class ISO20022.Tsmt014001.SingleTransport3 {
        + TrnsprtByRail  : ISO20022.Tsmt014001.TransportByRail2
        + TrnsprtByRoad  : ISO20022.Tsmt014001.TransportByRoad2
        + TrnsprtBySea  : ISO20022.Tsmt014001.TransportBySea4
        + TrnsprtByAir  : ISO20022.Tsmt014001.TransportByAir2
    }
    ISO20022.Tsmt014001.SingleTransport3 *-- ISO20022.Tsmt014001.TransportByRail2
    ISO20022.Tsmt014001.SingleTransport3 *-- ISO20022.Tsmt014001.TransportByRoad2
    ISO20022.Tsmt014001.SingleTransport3 *-- ISO20022.Tsmt014001.TransportBySea4
    ISO20022.Tsmt014001.SingleTransport3 *-- ISO20022.Tsmt014001.TransportByAir2
    class ISO20022.Tsmt014001.SingleTransport8 {
        + TrnsprtByRail  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.TransportByRail4~
        + TrnsprtByRoad  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.TransportByRoad4~
        + TrnsprtBySea  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.TransportBySea5~
        + TrnsprtByAir  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.TransportByAir4~
    }
    ISO20022.Tsmt014001.SingleTransport8 *-- ISO20022.Tsmt014001.TransportByRail4
    ISO20022.Tsmt014001.SingleTransport8 *-- ISO20022.Tsmt014001.TransportByRoad4
    ISO20022.Tsmt014001.SingleTransport8 *-- ISO20022.Tsmt014001.TransportBySea5
    ISO20022.Tsmt014001.SingleTransport8 *-- ISO20022.Tsmt014001.TransportByAir4
    class ISO20022.Tsmt014001.Tax22 {
        + Amt  : ISO20022.Tsmt014001.CurrencyAndAmount
        + Tp  : ISO20022.Tsmt014001.TaxType2Choice
    }
    ISO20022.Tsmt014001.Tax22 *-- ISO20022.Tsmt014001.CurrencyAndAmount
    ISO20022.Tsmt014001.Tax22 *-- ISO20022.Tsmt014001.TaxType2Choice
    class ISO20022.Tsmt014001.TaxType2Choice {
        + OthrTaxTp  : String
        + Tp  : String
    }
    class ISO20022.Tsmt014001.TaxType9Code {
        CUST = 1
        VATA = 2
        COAX = 3
        STAM = 4
        WITH = 5
        STAT = 6
        NATI = 7
        PROV = 8
    }
    class ISO20022.Tsmt014001.TradeCertificateType1Code {
        PHYT = 1
        HEAL = 2
        ORIG = 3
        WEIG = 4
        QUAN = 5
        QUAL = 6
        ANLY = 7
    }
    class ISO20022.Tsmt014001.TransportByAir2 {
        + AirCrrierNm  : String
        + DstnAirprt  : ISO20022.Tsmt014001.AirportName1Choice
        + DprtureAirprt  : ISO20022.Tsmt014001.AirportName1Choice
    }
    ISO20022.Tsmt014001.TransportByAir2 *-- ISO20022.Tsmt014001.AirportName1Choice
    ISO20022.Tsmt014001.TransportByAir2 *-- ISO20022.Tsmt014001.AirportName1Choice
    class ISO20022.Tsmt014001.TransportByAir4 {
        + CrrierAgtCtry  : String
        + CrrierAgtNm  : String
        + AirCrrierCtry  : String
        + AirCrrierNm  : String
        + FlghtNb  : String
        + DstnAirprt  : ISO20022.Tsmt014001.AirportName1Choice
        + DprtureAirprt  : ISO20022.Tsmt014001.AirportName1Choice
    }
    ISO20022.Tsmt014001.TransportByAir4 *-- ISO20022.Tsmt014001.AirportName1Choice
    ISO20022.Tsmt014001.TransportByAir4 *-- ISO20022.Tsmt014001.AirportName1Choice
    class ISO20022.Tsmt014001.TransportByRail2 {
        + RailCrrierNm  : String
        + PlcOfDlvry  : String
        + PlcOfRct  : String
    }
    class ISO20022.Tsmt014001.TransportByRail4 {
        + CrrierAgtCtry  : String
        + CrrierAgtNm  : String
        + RailCrrierCtry  : String
        + RailCrrierNm  : String
        + PlcOfDlvry  : String
        + PlcOfRct  : String
    }
    class ISO20022.Tsmt014001.TransportByRoad2 {
        + RoadCrrierNm  : String
        + PlcOfDlvry  : String
        + PlcOfRct  : String
    }
    class ISO20022.Tsmt014001.TransportByRoad4 {
        + CrrierAgtCtry  : String
        + CrrierAgtNm  : String
        + RoadCrrierCtry  : String
        + RoadCrrierNm  : String
        + PlcOfDlvry  : String
        + PlcOfRct  : String
    }
    class ISO20022.Tsmt014001.TransportBySea4 {
        + SeaCrrierNm  : String
        + VsslNm  : String
        + PortOfDschrge  : String
        + PortOfLoadng  : String
    }
    class ISO20022.Tsmt014001.TransportBySea5 {
        + VygNb  : String
        + IMONb  : String
        + OwnrNm  : String
        + ChrtrrNm  : String
        + MstrNm  : String
        + CrrierAgtCtry  : String
        + CrrierAgtNm  : String
        + SeaCrrierCtry  : String
        + SeaCrrierNm  : String
        + VsslNm  : String
        + PortOfDschrge  : String
        + PortOfLoadng  : String
    }
    class ISO20022.Tsmt014001.TransportDataSet5 {
        + TrnsprtInf  : ISO20022.Tsmt014001.TransportDetails4
        + ShipTo  : ISO20022.Tsmt014001.PartyIdentification26
        + Consgn  : ISO20022.Tsmt014001.PartyIdentification26
        + Consgnr  : ISO20022.Tsmt014001.PartyIdentification26
        + Sellr  : ISO20022.Tsmt014001.PartyIdentification26
        + Buyr  : ISO20022.Tsmt014001.PartyIdentification26
        + DataSetId  : ISO20022.Tsmt014001.DocumentIdentification1
    }
    ISO20022.Tsmt014001.TransportDataSet5 *-- ISO20022.Tsmt014001.TransportDetails4
    ISO20022.Tsmt014001.TransportDataSet5 *-- ISO20022.Tsmt014001.PartyIdentification26
    ISO20022.Tsmt014001.TransportDataSet5 *-- ISO20022.Tsmt014001.PartyIdentification26
    ISO20022.Tsmt014001.TransportDataSet5 *-- ISO20022.Tsmt014001.PartyIdentification26
    ISO20022.Tsmt014001.TransportDataSet5 *-- ISO20022.Tsmt014001.PartyIdentification26
    ISO20022.Tsmt014001.TransportDataSet5 *-- ISO20022.Tsmt014001.PartyIdentification26
    ISO20022.Tsmt014001.TransportDataSet5 *-- ISO20022.Tsmt014001.DocumentIdentification1
    class ISO20022.Tsmt014001.TransportDetails4 {
        + Incotrms  : ISO20022.Tsmt014001.Incoterms4
        + FrghtChrgs  : ISO20022.Tsmt014001.Charge25
        + ShipmntDt  : ISO20022.Tsmt014001.ShipmentDate1Choice
        + RtgSummry  : ISO20022.Tsmt014001.TransportMeans6
        + Consgnmt  : ISO20022.Tsmt014001.Consignment3
        + TrnsprtdGoods  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.TransportedGoods1~
        + TrnsprtDocRef  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.DocumentIdentification7~
    }
    ISO20022.Tsmt014001.TransportDetails4 *-- ISO20022.Tsmt014001.Incoterms4
    ISO20022.Tsmt014001.TransportDetails4 *-- ISO20022.Tsmt014001.Charge25
    ISO20022.Tsmt014001.TransportDetails4 *-- ISO20022.Tsmt014001.ShipmentDate1Choice
    ISO20022.Tsmt014001.TransportDetails4 *-- ISO20022.Tsmt014001.TransportMeans6
    ISO20022.Tsmt014001.TransportDetails4 *-- ISO20022.Tsmt014001.Consignment3
    ISO20022.Tsmt014001.TransportDetails4 *-- ISO20022.Tsmt014001.TransportedGoods1
    ISO20022.Tsmt014001.TransportDetails4 *-- ISO20022.Tsmt014001.DocumentIdentification7
    class ISO20022.Tsmt014001.TransportMeans6 {
        + MltmdlTrnsprt  : ISO20022.Tsmt014001.MultimodalTransport3
        + IndvTrnsprt  : ISO20022.Tsmt014001.SingleTransport8
    }
    ISO20022.Tsmt014001.TransportMeans6 *-- ISO20022.Tsmt014001.MultimodalTransport3
    ISO20022.Tsmt014001.TransportMeans6 *-- ISO20022.Tsmt014001.SingleTransport8
    class ISO20022.Tsmt014001.TransportedGoods1 {
        + SellrDfndInf  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.UserDefinedInformation1~
        + BuyrDfndInf  : global::System.Collections.Generic.List~ISO20022.Tsmt014001.UserDefinedInformation1~
        + GoodsDesc  : String
        + PurchsOrdrRef  : ISO20022.Tsmt014001.DocumentIdentification7
    }
    ISO20022.Tsmt014001.TransportedGoods1 *-- ISO20022.Tsmt014001.UserDefinedInformation1
    ISO20022.Tsmt014001.TransportedGoods1 *-- ISO20022.Tsmt014001.UserDefinedInformation1
    ISO20022.Tsmt014001.TransportedGoods1 *-- ISO20022.Tsmt014001.DocumentIdentification7
    class ISO20022.Tsmt014001.UnitOfMeasure3Choice {
        + OthrUnitOfMeasr  : String
        + UnitOfMeasrCd  : String
    }
    class ISO20022.Tsmt014001.UnitOfMeasure4Code {
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
    class ISO20022.Tsmt014001.UnitPrice18 {
        + Fctr  : String
        + Amt  : ISO20022.Tsmt014001.CurrencyAndAmount
        + UnitPric  : ISO20022.Tsmt014001.UnitOfMeasure3Choice
    }
    ISO20022.Tsmt014001.UnitPrice18 *-- ISO20022.Tsmt014001.CurrencyAndAmount
    ISO20022.Tsmt014001.UnitPrice18 *-- ISO20022.Tsmt014001.UnitOfMeasure3Choice
    class ISO20022.Tsmt014001.UserDefinedInformation1 {
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

## Value ISO20022.Tsmt014001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Tsmt014001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Tsmt014001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsmt014001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Tsmt014001.Adjustment6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Tsmt014001.CurrencyAndAmount||XmlElement()||
|+|Drctn|String||XmlElement()||
|+|Tp|ISO20022.Tsmt014001.AdjustmentType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Tp))|

---

## Enum ISO20022.Tsmt014001.AdjustmentDirection1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SUBS|Int32||XmlEnum("""SUBS""")|1|
||ADDD|Int32||XmlEnum("""ADDD""")|2|

---

## Value ISO20022.Tsmt014001.AdjustmentType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrAdjstmntTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(OthrAdjstmntTp,Tp))|

---

## Enum ISO20022.Tsmt014001.AdjustmentType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SURC|Int32||XmlEnum("""SURC""")|1|
||CREN|Int32||XmlEnum("""CREN""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|
||REBA|Int32||XmlEnum("""REBA""")|4|

---

## Value ISO20022.Tsmt014001.AirportDescription1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AirprtNm|String||XmlElement()||
|+|Twn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt014001.AirportName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrAirprtDesc|ISO20022.Tsmt014001.AirportDescription1||XmlElement()||
|+|AirprtCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrAirprtDesc),validChoice(OthrAirprtDesc,AirprtCd))|

---

## Value ISO20022.Tsmt014001.AmountOrPercentage2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pctg|Decimal||XmlElement()||
|+|Amt|ISO20022.Tsmt014001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Pctg,Amt))|

---

## Value ISO20022.Tsmt014001.BICIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""BIC""",BIC,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Tsmt014001.CashAccount24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Tsmt014001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Tsmt014001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Tsmt014001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsmt014001.CertificateDataSet2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Manfctr|ISO20022.Tsmt014001.PartyIdentification26||XmlElement()||
|+|Consgn|ISO20022.Tsmt014001.PartyIdentification26||XmlElement()||
|+|Consgnr|ISO20022.Tsmt014001.PartyIdentification26||XmlElement()||
|+|GoodsDesc|String||XmlElement()||
|+|Trnsprt|ISO20022.Tsmt014001.SingleTransport3||XmlElement()||
|+|CertId|String||XmlElement()||
|+|AuthrsdInspctrInd|String||XmlElement()||
|+|InspctnDt|ISO20022.Tsmt014001.DatePeriodDetails||XmlElement()||
|+|Issr|ISO20022.Tsmt014001.PartyIdentification26||XmlElement()||
|+|PlcOfIsse|ISO20022.Tsmt014001.PostalAddress5||XmlElement()||
|+|IsseDt|DateTime||XmlElement()||
|+|CertfdChrtcs|ISO20022.Tsmt014001.CertifiedCharacteristics2Choice||XmlElement()||
|+|LineItm|global::System.Collections.Generic.List<ISO20022.Tsmt014001.LineItemAndPOIdentification1>||XmlElement()||
|+|CertTp|String||XmlElement()||
|+|DataSetId|ISO20022.Tsmt014001.DocumentIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Manfctr),validElement(Consgn),validElement(Consgnr),validElement(Trnsprt),validElement(InspctnDt),validElement(Issr),validElement(PlcOfIsse),validElement(CertfdChrtcs),validList("""LineItm""",LineItm),validElement(LineItm),validElement(DataSetId))|

---

## Value ISO20022.Tsmt014001.CertifiedCharacteristics2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PhytosntryIndctn|String||XmlElement()||
|+|HlthIndctn|String||XmlElement()||
|+|Qty|ISO20022.Tsmt014001.Quantity9||XmlElement()||
|+|Wght|ISO20022.Tsmt014001.Quantity9||XmlElement()||
|+|Anlys|String||XmlElement()||
|+|Qlty|String||XmlElement()||
|+|Orgn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty),validElement(Wght),validPattern("""Orgn""",Orgn,"""[A-Z]{2,2}"""),validChoice(PhytosntryIndctn,HlthIndctn,Qty,Wght,Anlys,Qlty,Orgn))|

---

## Value ISO20022.Tsmt014001.Charge25


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Chrgs|global::System.Collections.Generic.List<ISO20022.Tsmt014001.ChargesDetails4>||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Chrgs""",Chrgs),validElement(Chrgs))|

---

## Enum ISO20022.Tsmt014001.ChargeType8Code


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

## Value ISO20022.Tsmt014001.ChargesDetails4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Tsmt014001.CurrencyAndAmount||XmlElement()||
|+|ChrgsTp|ISO20022.Tsmt014001.ChargesType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(ChrgsTp))|

---

## Value ISO20022.Tsmt014001.ChargesType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrChrgsTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(OthrChrgsTp,Tp))|

---

## Value ISO20022.Tsmt014001.CommercialDataSet5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmTerms|ISO20022.Tsmt014001.SettlementTerms3||XmlElement()||
|+|PmtTerms|global::System.Collections.Generic.List<ISO20022.Tsmt014001.PaymentTerms4>||XmlElement()||
|+|Goods|global::System.Collections.Generic.List<ISO20022.Tsmt014001.LineItem15>||XmlElement()||
|+|BllTo|ISO20022.Tsmt014001.PartyIdentification26||XmlElement()||
|+|Sellr|ISO20022.Tsmt014001.PartyIdentification26||XmlElement()||
|+|Buyr|ISO20022.Tsmt014001.PartyIdentification26||XmlElement()||
|+|ComrclDocRef|ISO20022.Tsmt014001.InvoiceIdentification1||XmlElement()||
|+|DataSetId|ISO20022.Tsmt014001.DocumentIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SttlmTerms),validRequired("""PmtTerms""",PmtTerms),validList("""PmtTerms""",PmtTerms),validElement(PmtTerms),validRequired("""Goods""",Goods),validList("""Goods""",Goods),validElement(Goods),validElement(BllTo),validElement(Sellr),validElement(Buyr),validElement(ComrclDocRef),validElement(DataSetId))|

---

## Value ISO20022.Tsmt014001.Consignment3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlWght|ISO20022.Tsmt014001.Quantity10||XmlElement()||
|+|TtlVol|ISO20022.Tsmt014001.Quantity10||XmlElement()||
|+|TtlQty|ISO20022.Tsmt014001.Quantity10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlWght),validElement(TtlVol),validElement(TtlQty))|

---

## Value ISO20022.Tsmt014001.CurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Tsmt014001.DataSetSubmissionReferences3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ForcdMtch|String||XmlElement()||
|+|SubmitrTxRef|String||XmlElement()||
|+|PurchsOrdrRef|ISO20022.Tsmt014001.DocumentIdentification7||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PurchsOrdrRef))|

---

## Aspect ISO20022.Tsmt014001.DataSetSubmissionV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrCertDataSet|global::System.Collections.Generic.List<ISO20022.Tsmt014001.OtherCertificateDataSet2>||XmlElement()||
|+|CertDataSet|global::System.Collections.Generic.List<ISO20022.Tsmt014001.CertificateDataSet2>||XmlElement()||
|+|InsrncDataSet|ISO20022.Tsmt014001.InsuranceDataSet1||XmlElement()||
|+|TrnsprtDataSet|ISO20022.Tsmt014001.TransportDataSet5||XmlElement()||
|+|ComrclDataSet|ISO20022.Tsmt014001.CommercialDataSet5||XmlElement()||
|+|SellrBk|ISO20022.Tsmt014001.BICIdentification1||XmlElement()||
|+|BuyrBk|ISO20022.Tsmt014001.BICIdentification1||XmlElement()||
|+|Instr|ISO20022.Tsmt014001.InstructionType3||XmlElement()||
|+|CmonSubmissnRef|ISO20022.Tsmt014001.SimpleIdentificationInformation||XmlElement()||
|+|RltdTxRefs|global::System.Collections.Generic.List<ISO20022.Tsmt014001.DataSetSubmissionReferences3>||XmlElement()||
|+|SubmissnId|ISO20022.Tsmt014001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrCertDataSet""",OthrCertDataSet),validElement(OthrCertDataSet),validList("""CertDataSet""",CertDataSet),validElement(CertDataSet),validElement(InsrncDataSet),validElement(TrnsprtDataSet),validElement(ComrclDataSet),validElement(SellrBk),validElement(BuyrBk),validElement(Instr),validElement(CmonSubmissnRef),validRequired("""RltdTxRefs""",RltdTxRefs),validList("""RltdTxRefs""",RltdTxRefs),validElement(RltdTxRefs),validElement(SubmissnId))|

---

## Value ISO20022.Tsmt014001.DatePeriodDetails


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Type ISO20022.Tsmt014001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DataSetSubmissn|ISO20022.Tsmt014001.DataSetSubmissionV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DataSetSubmissn))|

---

## Value ISO20022.Tsmt014001.DocumentIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Submitr|ISO20022.Tsmt014001.BICIdentification1||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Submitr))|

---

## Value ISO20022.Tsmt014001.DocumentIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtOfIsse|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt014001.FinancialInstitutionIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Tsmt014001.NameAndAddress6||XmlElement()||
|+|BIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validPattern("""BIC""",BIC,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,BIC))|

---

## Enum ISO20022.Tsmt014001.FreightCharges1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRPD|Int32||XmlEnum("""PRPD""")|1|
||CLCT|Int32||XmlEnum("""CLCT""")|2|

---

## Value ISO20022.Tsmt014001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Tsmt014001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Tsmt014001.GenericIdentification13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{1,4}"""))|

---

## Value ISO20022.Tsmt014001.GenericIdentification4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdTp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt014001.Incoterms4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lctn|String||XmlElement()||
|+|IncotrmsCd|ISO20022.Tsmt014001.Incoterms4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IncotrmsCd))|

---

## Value ISO20022.Tsmt014001.Incoterms4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Tsmt014001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsmt014001.InstructionType3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Tsmt014001.InstructionType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PMTC|Int32||XmlEnum("""PMTC""")|1|
||MTCH|Int32||XmlEnum("""MTCH""")|2|

---

## Enum ISO20022.Tsmt014001.InsuranceClauses1Code


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

## Value ISO20022.Tsmt014001.InsuranceDataSet1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClmsPyblIn|String||XmlElement()||
|+|ClmsPyblAt|ISO20022.Tsmt014001.PostalAddress5||XmlElement()||
|+|Assrd|ISO20022.Tsmt014001.PartyIdentification29Choice||XmlElement()||
|+|InsrncClauses|global::System.Collections.Generic.List<String>||XmlElement()||
|+|InsrncConds|global::System.Collections.Generic.List<String>||XmlElement()||
|+|InsrdGoodsDesc|String||XmlElement()||
|+|InsrdAmt|ISO20022.Tsmt014001.CurrencyAndAmount||XmlElement()||
|+|Trnsprt|ISO20022.Tsmt014001.SingleTransport3||XmlElement()||
|+|InsrncDocId|String||XmlElement()||
|+|PlcOfIsse|ISO20022.Tsmt014001.PostalAddress5||XmlElement()||
|+|FctvDt|DateTime||XmlElement()||
|+|IsseDt|DateTime||XmlElement()||
|+|Issr|ISO20022.Tsmt014001.PartyIdentification26||XmlElement()||
|+|DataSetId|ISO20022.Tsmt014001.DocumentIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""ClmsPyblIn""",ClmsPyblIn,"""[A-Z]{3,3}"""),validElement(ClmsPyblAt),validElement(Assrd),validElement(InsrdAmt),validElement(Trnsprt),validElement(PlcOfIsse),validElement(Issr),validElement(DataSetId))|

---

## Value ISO20022.Tsmt014001.InvoiceIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IsseDt|DateTime||XmlElement()||
|+|InvcNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt014001.LineItem15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Incotrms|ISO20022.Tsmt014001.Incoterms4||XmlElement()||
|+|SellrDfndInf|global::System.Collections.Generic.List<ISO20022.Tsmt014001.UserDefinedInformation1>||XmlElement()||
|+|BuyrDfndInf|global::System.Collections.Generic.List<ISO20022.Tsmt014001.UserDefinedInformation1>||XmlElement()||
|+|TtlNetAmt|ISO20022.Tsmt014001.CurrencyAndAmount||XmlElement()||
|+|Tax|global::System.Collections.Generic.List<ISO20022.Tsmt014001.Tax22>||XmlElement()||
|+|FrghtChrgs|ISO20022.Tsmt014001.Charge25||XmlElement()||
|+|Adjstmnt|global::System.Collections.Generic.List<ISO20022.Tsmt014001.Adjustment6>||XmlElement()||
|+|LineItmsTtlAmt|ISO20022.Tsmt014001.CurrencyAndAmount||XmlElement()||
|+|ComrclLineItms|global::System.Collections.Generic.List<ISO20022.Tsmt014001.LineItemDetails14>||XmlElement()||
|+|FnlSubmissn|String||XmlElement()||
|+|PurchsOrdrRef|ISO20022.Tsmt014001.DocumentIdentification7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Incotrms),validList("""SellrDfndInf""",SellrDfndInf),validElement(SellrDfndInf),validList("""BuyrDfndInf""",BuyrDfndInf),validElement(BuyrDfndInf),validElement(TtlNetAmt),validList("""Tax""",Tax),validElement(Tax),validElement(FrghtChrgs),validList("""Adjstmnt""",Adjstmnt),validElement(Adjstmnt),validElement(LineItmsTtlAmt),validRequired("""ComrclLineItms""",ComrclLineItms),validList("""ComrclLineItms""",ComrclLineItms),validElement(ComrclLineItms),validElement(PurchsOrdrRef))|

---

## Value ISO20022.Tsmt014001.LineItemAndPOIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PurchsOrdrRef|ISO20022.Tsmt014001.DocumentIdentification7||XmlElement()||
|+|LineItmId|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PurchsOrdrRef),validRequired("""LineItmId""",LineItmId))|

---

## Value ISO20022.Tsmt014001.LineItemDetails14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlAmt|ISO20022.Tsmt014001.CurrencyAndAmount||XmlElement()||
|+|Tax|global::System.Collections.Generic.List<ISO20022.Tsmt014001.Tax22>||XmlElement()||
|+|FrghtChrgs|ISO20022.Tsmt014001.Charge25||XmlElement()||
|+|Adjstmnt|global::System.Collections.Generic.List<ISO20022.Tsmt014001.Adjustment6>||XmlElement()||
|+|PdctOrgn|String||XmlElement()||
|+|PdctCtgy|global::System.Collections.Generic.List<ISO20022.Tsmt014001.ProductCategory1Choice>||XmlElement()||
|+|PdctChrtcs|global::System.Collections.Generic.List<ISO20022.Tsmt014001.ProductCharacteristics1Choice>||XmlElement()||
|+|PdctIdr|global::System.Collections.Generic.List<ISO20022.Tsmt014001.ProductIdentifier2Choice>||XmlElement()||
|+|PdctNm|String||XmlElement()||
|+|UnitPric|ISO20022.Tsmt014001.UnitPrice18||XmlElement()||
|+|Qty|ISO20022.Tsmt014001.Quantity9||XmlElement()||
|+|LineItmId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlAmt),validList("""Tax""",Tax),validElement(Tax),validElement(FrghtChrgs),validList("""Adjstmnt""",Adjstmnt),validElement(Adjstmnt),validPattern("""PdctOrgn""",PdctOrgn,"""[A-Z]{2,2}"""),validList("""PdctCtgy""",PdctCtgy),validElement(PdctCtgy),validList("""PdctChrtcs""",PdctChrtcs),validElement(PdctChrtcs),validList("""PdctIdr""",PdctIdr),validElement(PdctIdr),validElement(UnitPric),validElement(Qty))|

---

## Value ISO20022.Tsmt014001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt014001.MultimodalTransport3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PlcOfFnlDstn|String||XmlElement()||
|+|TakngInChrg|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt014001.NameAndAddress6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Tsmt014001.PostalAddress2||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Tsmt014001.OtherCertificateDataSet2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CertInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Issr|ISO20022.Tsmt014001.PartyIdentification26||XmlElement()||
|+|IsseDt|DateTime||XmlElement()||
|+|CertTp|String||XmlElement()||
|+|CertId|String||XmlElement()||
|+|DataSetId|ISO20022.Tsmt014001.DocumentIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Issr),validPattern("""CertTp""",CertTp,"""[a-zA-Z0-9]{4}"""),validElement(DataSetId))|

---

## Value ISO20022.Tsmt014001.PartyIdentification26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Tsmt014001.PostalAddress5||XmlElement()||
|+|PrtryId|ISO20022.Tsmt014001.GenericIdentification4||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validElement(PrtryId))|

---

## Value ISO20022.Tsmt014001.PartyIdentification29Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Tsmt014001.PartyIdentification26||XmlElement()||
|+|BIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validPattern("""BIC""",BIC,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,BIC))|

---

## Value ISO20022.Tsmt014001.PaymentCodeOrOther1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPmtTerms|String||XmlElement()||
|+|PmtDueDt|DateTime||XmlElement()||
|+|PmtCd|ISO20022.Tsmt014001.PaymentPeriod3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PmtCd),validChoice(OthrPmtTerms,PmtDueDt,PmtCd))|

---

## Value ISO20022.Tsmt014001.PaymentPeriod3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NbOfDays|Decimal||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt014001.PaymentTerms4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtOrPctg|ISO20022.Tsmt014001.AmountOrPercentage2Choice||XmlElement()||
|+|PmtTerms|ISO20022.Tsmt014001.PaymentCodeOrOther1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtOrPctg),validElement(PmtTerms))|

---

## Enum ISO20022.Tsmt014001.PaymentTime3Code


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

## Value ISO20022.Tsmt014001.PostalAddress2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCdId|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Tsmt014001.PostalAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCdId|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Tsmt014001.ProductCategory1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctgy|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt014001.ProductCategory1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPdctCtgy|ISO20022.Tsmt014001.GenericIdentification4||XmlElement()||
|+|StrdPdctCtgy|ISO20022.Tsmt014001.ProductCategory1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrPdctCtgy),validElement(StrdPdctCtgy),validChoice(OthrPdctCtgy,StrdPdctCtgy))|

---

## Enum ISO20022.Tsmt014001.ProductCategory1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GNDR|Int32||XmlEnum("""GNDR""")|1|
||LOBU|Int32||XmlEnum("""LOBU""")|2|
||PRGP|Int32||XmlEnum("""PRGP""")|3|
||QOTA|Int32||XmlEnum("""QOTA""")|4|
||HRTR|Int32||XmlEnum("""HRTR""")|5|

---

## Value ISO20022.Tsmt014001.ProductCharacteristics1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Chrtcs|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt014001.ProductCharacteristics1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPdctChrtcs|ISO20022.Tsmt014001.GenericIdentification4||XmlElement()||
|+|StrdPdctChrtcs|ISO20022.Tsmt014001.ProductCharacteristics1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrPdctChrtcs),validElement(StrdPdctChrtcs),validChoice(OthrPdctChrtcs,StrdPdctChrtcs))|

---

## Enum ISO20022.Tsmt014001.ProductCharacteristics1Code


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

## Value ISO20022.Tsmt014001.ProductIdentifier2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Idr|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt014001.ProductIdentifier2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPdctIdr|ISO20022.Tsmt014001.GenericIdentification4||XmlElement()||
|+|StrdPdctIdr|ISO20022.Tsmt014001.ProductIdentifier2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrPdctIdr),validElement(StrdPdctIdr),validChoice(OthrPdctIdr,StrdPdctIdr))|

---

## Enum ISO20022.Tsmt014001.ProductIdentifier2Code


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

## Value ISO20022.Tsmt014001.Quantity10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|Decimal||XmlElement()||
|+|UnitOfMeasr|ISO20022.Tsmt014001.UnitOfMeasure3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UnitOfMeasr))|

---

## Value ISO20022.Tsmt014001.Quantity9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Fctr|String||XmlElement()||
|+|Val|Decimal||XmlElement()||
|+|UnitOfMeasr|ISO20022.Tsmt014001.UnitOfMeasure3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Fctr""",Fctr,"""[0-9]{1,15}"""),validElement(UnitOfMeasr))|

---

## Value ISO20022.Tsmt014001.SettlementTerms3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtrAcct|ISO20022.Tsmt014001.CashAccount24||XmlElement()||
|+|CdtrAgt|ISO20022.Tsmt014001.FinancialInstitutionIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdtrAcct),validElement(CdtrAgt))|

---

## Value ISO20022.Tsmt014001.ShipmentDate1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ActlShipmntDt|DateTime||XmlElement()||
|+|PropsdShipmntDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(ActlShipmntDt,PropsdShipmntDt))|

---

## Value ISO20022.Tsmt014001.SimpleIdentificationInformation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt014001.SingleTransport3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrnsprtByRail|ISO20022.Tsmt014001.TransportByRail2||XmlElement()||
|+|TrnsprtByRoad|ISO20022.Tsmt014001.TransportByRoad2||XmlElement()||
|+|TrnsprtBySea|ISO20022.Tsmt014001.TransportBySea4||XmlElement()||
|+|TrnsprtByAir|ISO20022.Tsmt014001.TransportByAir2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TrnsprtByRail),validElement(TrnsprtByRoad),validElement(TrnsprtBySea),validElement(TrnsprtByAir))|

---

## Value ISO20022.Tsmt014001.SingleTransport8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrnsprtByRail|global::System.Collections.Generic.List<ISO20022.Tsmt014001.TransportByRail4>||XmlElement()||
|+|TrnsprtByRoad|global::System.Collections.Generic.List<ISO20022.Tsmt014001.TransportByRoad4>||XmlElement()||
|+|TrnsprtBySea|global::System.Collections.Generic.List<ISO20022.Tsmt014001.TransportBySea5>||XmlElement()||
|+|TrnsprtByAir|global::System.Collections.Generic.List<ISO20022.Tsmt014001.TransportByAir4>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TrnsprtByRail""",TrnsprtByRail),validElement(TrnsprtByRail),validList("""TrnsprtByRoad""",TrnsprtByRoad),validElement(TrnsprtByRoad),validList("""TrnsprtBySea""",TrnsprtBySea),validElement(TrnsprtBySea),validList("""TrnsprtByAir""",TrnsprtByAir),validElement(TrnsprtByAir))|

---

## Value ISO20022.Tsmt014001.Tax22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Tsmt014001.CurrencyAndAmount||XmlElement()||
|+|Tp|ISO20022.Tsmt014001.TaxType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Tp))|

---

## Value ISO20022.Tsmt014001.TaxType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrTaxTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(OthrTaxTp,Tp))|

---

## Enum ISO20022.Tsmt014001.TaxType9Code


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

## Enum ISO20022.Tsmt014001.TradeCertificateType1Code


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

## Value ISO20022.Tsmt014001.TransportByAir2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AirCrrierNm|String||XmlElement()||
|+|DstnAirprt|ISO20022.Tsmt014001.AirportName1Choice||XmlElement()||
|+|DprtureAirprt|ISO20022.Tsmt014001.AirportName1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DstnAirprt),validElement(DprtureAirprt))|

---

## Value ISO20022.Tsmt014001.TransportByAir4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CrrierAgtCtry|String||XmlElement()||
|+|CrrierAgtNm|String||XmlElement()||
|+|AirCrrierCtry|String||XmlElement()||
|+|AirCrrierNm|String||XmlElement()||
|+|FlghtNb|String||XmlElement()||
|+|DstnAirprt|ISO20022.Tsmt014001.AirportName1Choice||XmlElement()||
|+|DprtureAirprt|ISO20022.Tsmt014001.AirportName1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CrrierAgtCtry""",CrrierAgtCtry,"""[A-Z]{2,2}"""),validPattern("""AirCrrierCtry""",AirCrrierCtry,"""[A-Z]{2,2}"""),validElement(DstnAirprt),validElement(DprtureAirprt))|

---

## Value ISO20022.Tsmt014001.TransportByRail2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RailCrrierNm|String||XmlElement()||
|+|PlcOfDlvry|String||XmlElement()||
|+|PlcOfRct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt014001.TransportByRail4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CrrierAgtCtry|String||XmlElement()||
|+|CrrierAgtNm|String||XmlElement()||
|+|RailCrrierCtry|String||XmlElement()||
|+|RailCrrierNm|String||XmlElement()||
|+|PlcOfDlvry|String||XmlElement()||
|+|PlcOfRct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CrrierAgtCtry""",CrrierAgtCtry,"""[A-Z]{2,2}"""),validPattern("""RailCrrierCtry""",RailCrrierCtry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Tsmt014001.TransportByRoad2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RoadCrrierNm|String||XmlElement()||
|+|PlcOfDlvry|String||XmlElement()||
|+|PlcOfRct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt014001.TransportByRoad4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CrrierAgtCtry|String||XmlElement()||
|+|CrrierAgtNm|String||XmlElement()||
|+|RoadCrrierCtry|String||XmlElement()||
|+|RoadCrrierNm|String||XmlElement()||
|+|PlcOfDlvry|String||XmlElement()||
|+|PlcOfRct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CrrierAgtCtry""",CrrierAgtCtry,"""[A-Z]{2,2}"""),validPattern("""RoadCrrierCtry""",RoadCrrierCtry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Tsmt014001.TransportBySea4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SeaCrrierNm|String||XmlElement()||
|+|VsslNm|String||XmlElement()||
|+|PortOfDschrge|String||XmlElement()||
|+|PortOfLoadng|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt014001.TransportBySea5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|VygNb|String||XmlElement()||
|+|IMONb|String||XmlElement()||
|+|OwnrNm|String||XmlElement()||
|+|ChrtrrNm|String||XmlElement()||
|+|MstrNm|String||XmlElement()||
|+|CrrierAgtCtry|String||XmlElement()||
|+|CrrierAgtNm|String||XmlElement()||
|+|SeaCrrierCtry|String||XmlElement()||
|+|SeaCrrierNm|String||XmlElement()||
|+|VsslNm|String||XmlElement()||
|+|PortOfDschrge|String||XmlElement()||
|+|PortOfLoadng|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""IMONb""",IMONb,"""[0-9]{7}"""),validPattern("""CrrierAgtCtry""",CrrierAgtCtry,"""[A-Z]{2,2}"""),validPattern("""SeaCrrierCtry""",SeaCrrierCtry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Tsmt014001.TransportDataSet5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrnsprtInf|ISO20022.Tsmt014001.TransportDetails4||XmlElement()||
|+|ShipTo|ISO20022.Tsmt014001.PartyIdentification26||XmlElement()||
|+|Consgn|ISO20022.Tsmt014001.PartyIdentification26||XmlElement()||
|+|Consgnr|ISO20022.Tsmt014001.PartyIdentification26||XmlElement()||
|+|Sellr|ISO20022.Tsmt014001.PartyIdentification26||XmlElement()||
|+|Buyr|ISO20022.Tsmt014001.PartyIdentification26||XmlElement()||
|+|DataSetId|ISO20022.Tsmt014001.DocumentIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TrnsprtInf),validElement(ShipTo),validElement(Consgn),validElement(Consgnr),validElement(Sellr),validElement(Buyr),validElement(DataSetId))|

---

## Value ISO20022.Tsmt014001.TransportDetails4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Incotrms|ISO20022.Tsmt014001.Incoterms4||XmlElement()||
|+|FrghtChrgs|ISO20022.Tsmt014001.Charge25||XmlElement()||
|+|ShipmntDt|ISO20022.Tsmt014001.ShipmentDate1Choice||XmlElement()||
|+|RtgSummry|ISO20022.Tsmt014001.TransportMeans6||XmlElement()||
|+|Consgnmt|ISO20022.Tsmt014001.Consignment3||XmlElement()||
|+|TrnsprtdGoods|global::System.Collections.Generic.List<ISO20022.Tsmt014001.TransportedGoods1>||XmlElement()||
|+|TrnsprtDocRef|global::System.Collections.Generic.List<ISO20022.Tsmt014001.DocumentIdentification7>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Incotrms),validElement(FrghtChrgs),validElement(ShipmntDt),validElement(RtgSummry),validElement(Consgnmt),validRequired("""TrnsprtdGoods""",TrnsprtdGoods),validList("""TrnsprtdGoods""",TrnsprtdGoods),validElement(TrnsprtdGoods),validRequired("""TrnsprtDocRef""",TrnsprtDocRef),validList("""TrnsprtDocRef""",TrnsprtDocRef),validElement(TrnsprtDocRef))|

---

## Value ISO20022.Tsmt014001.TransportMeans6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MltmdlTrnsprt|ISO20022.Tsmt014001.MultimodalTransport3||XmlElement()||
|+|IndvTrnsprt|ISO20022.Tsmt014001.SingleTransport8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MltmdlTrnsprt),validElement(IndvTrnsprt))|

---

## Value ISO20022.Tsmt014001.TransportedGoods1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SellrDfndInf|global::System.Collections.Generic.List<ISO20022.Tsmt014001.UserDefinedInformation1>||XmlElement()||
|+|BuyrDfndInf|global::System.Collections.Generic.List<ISO20022.Tsmt014001.UserDefinedInformation1>||XmlElement()||
|+|GoodsDesc|String||XmlElement()||
|+|PurchsOrdrRef|ISO20022.Tsmt014001.DocumentIdentification7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SellrDfndInf""",SellrDfndInf),validElement(SellrDfndInf),validList("""BuyrDfndInf""",BuyrDfndInf),validElement(BuyrDfndInf),validElement(PurchsOrdrRef))|

---

## Value ISO20022.Tsmt014001.UnitOfMeasure3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrUnitOfMeasr|String||XmlElement()||
|+|UnitOfMeasrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(OthrUnitOfMeasr,UnitOfMeasrCd))|

---

## Enum ISO20022.Tsmt014001.UnitOfMeasure4Code


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

## Value ISO20022.Tsmt014001.UnitPrice18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Fctr|String||XmlElement()||
|+|Amt|ISO20022.Tsmt014001.CurrencyAndAmount||XmlElement()||
|+|UnitPric|ISO20022.Tsmt014001.UnitOfMeasure3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Fctr""",Fctr,"""[0-9]{1,15}"""),validElement(Amt),validElement(UnitPric))|

---

## Value ISO20022.Tsmt014001.UserDefinedInformation1


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

