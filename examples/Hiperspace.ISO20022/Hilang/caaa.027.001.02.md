# caaa.027.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Caaa027001.AcceptorCancellationAdviceResponse13 {
        + TMSTrggr  : ISO20022.Caaa027001.TMSTrigger1
        + Tx  : ISO20022.Caaa027001.CardPaymentTransactionAdviceResponse8
        + Envt  : ISO20022.Caaa027001.CardPaymentEnvironment81
    }
    ISO20022.Caaa027001.AcceptorCancellationAdviceResponse13 *-- ISO20022.Caaa027001.TMSTrigger1
    ISO20022.Caaa027001.AcceptorCancellationAdviceResponse13 *-- ISO20022.Caaa027001.CardPaymentTransactionAdviceResponse8
    ISO20022.Caaa027001.AcceptorCancellationAdviceResponse13 *-- ISO20022.Caaa027001.CardPaymentEnvironment81
    class ISO20022.Caaa027001.AcceptorCompletionAdviceResponse13 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Caaa027001.SupplementaryData1~
        + TMSTrggr  : ISO20022.Caaa027001.TMSTrigger1
        + Tx  : ISO20022.Caaa027001.CardPaymentTransactionAdviceResponse8
        + Envt  : ISO20022.Caaa027001.CardPaymentEnvironment81
    }
    ISO20022.Caaa027001.AcceptorCompletionAdviceResponse13 *-- ISO20022.Caaa027001.SupplementaryData1
    ISO20022.Caaa027001.AcceptorCompletionAdviceResponse13 *-- ISO20022.Caaa027001.TMSTrigger1
    ISO20022.Caaa027001.AcceptorCompletionAdviceResponse13 *-- ISO20022.Caaa027001.CardPaymentTransactionAdviceResponse8
    ISO20022.Caaa027001.AcceptorCompletionAdviceResponse13 *-- ISO20022.Caaa027001.CardPaymentEnvironment81
    class ISO20022.Caaa027001.Acquirer10 {
        + ParamsVrsn  : String
        + Id  : ISO20022.Caaa027001.GenericIdentification177
    }
    ISO20022.Caaa027001.Acquirer10 *-- ISO20022.Caaa027001.GenericIdentification177
    class ISO20022.Caaa027001.AcquirerToAcceptorBatchFileExchangeV02 {
        + SctyTrlr  : ISO20022.Caaa027001.ContentInformationType38
        + Rspn  : ISO20022.Caaa027001.ResponseType11
        + BodyElmt  : global::System.Collections.Generic.List~ISO20022.Caaa027001.AcquirerToAcceptorFileBody2~
        + Hdr  : ISO20022.Caaa027001.Header56
    }
    ISO20022.Caaa027001.AcquirerToAcceptorBatchFileExchangeV02 *-- ISO20022.Caaa027001.ContentInformationType38
    ISO20022.Caaa027001.AcquirerToAcceptorBatchFileExchangeV02 *-- ISO20022.Caaa027001.ResponseType11
    ISO20022.Caaa027001.AcquirerToAcceptorBatchFileExchangeV02 *-- ISO20022.Caaa027001.AcquirerToAcceptorFileBody2
    ISO20022.Caaa027001.AcquirerToAcceptorBatchFileExchangeV02 *-- ISO20022.Caaa027001.Header56
    class ISO20022.Caaa027001.AcquirerToAcceptorFileBody2 {
        + BtchTrfRspn  : ISO20022.Caaa027001.CardPaymentBatchTransferResponse12
        + CxlRspn  : ISO20022.Caaa027001.AcceptorCancellationAdviceResponse13
        + CmpltnAdvcRspn  : ISO20022.Caaa027001.AcceptorCompletionAdviceResponse13
    }
    ISO20022.Caaa027001.AcquirerToAcceptorFileBody2 *-- ISO20022.Caaa027001.CardPaymentBatchTransferResponse12
    ISO20022.Caaa027001.AcquirerToAcceptorFileBody2 *-- ISO20022.Caaa027001.AcceptorCancellationAdviceResponse13
    ISO20022.Caaa027001.AcquirerToAcceptorFileBody2 *-- ISO20022.Caaa027001.AcceptorCompletionAdviceResponse13
    class ISO20022.Caaa027001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Caaa027001.AddressVerification1 {
        + PstlCdDgts  : String
        + AdrDgts  : String
    }
    class ISO20022.Caaa027001.Algorithm26Code {
        SMS3 = 1
        SHK2 = 2
        SHK1 = 3
        SH35 = 4
        SH33 = 5
        SH32 = 6
        SH31 = 7
        HS01 = 8
        HS51 = 9
        HS38 = 10
        HS25 = 11
    }
    class ISO20022.Caaa027001.Algorithm27Code {
        S34R = 1
        S34C = 2
        CCA3 = 3
        CCA2 = 4
        CCA1 = 5
        MCS3 = 6
        CM33 = 7
        CM32 = 8
        CM31 = 9
        CMA2 = 10
        CMA5 = 11
        CMA9 = 12
        MCC1 = 13
        CMA1 = 14
        MCCS = 15
        MACC = 16
    }
    class ISO20022.Caaa027001.Algorithm28Code {
        SM4R = 1
        SM4C = 2
        UKA3 = 3
        UKA1 = 4
        SD5C = 5
        E36R = 6
        E36C = 7
        E3DR = 8
        EA2R = 9
        EA9R = 10
        EA5R = 11
        N108 = 12
        DA25 = 13
        DA19 = 14
        DA12 = 15
        EA5C = 16
        EA9C = 17
        UKA2 = 18
        UKPT = 19
        DKP9 = 20
        E3DC = 21
        EA2C = 22
    }
    class ISO20022.Caaa027001.Algorithm29Code {
        S2S3 = 1
        SM25 = 2
        SM23 = 3
        SM35 = 4
        SM32 = 5
        SM33 = 6
        SM22 = 7
        DD25 = 8
        DD23 = 9
        DD35 = 10
        DD33 = 11
        DD32 = 12
        DD22 = 13
        EO25 = 14
        EO23 = 15
        EO35 = 16
        EO22 = 17
        EO32 = 18
        EF25 = 19
        EO33 = 20
        EF23 = 21
        EF35 = 22
        EF33 = 23
        EF22 = 24
        EF32 = 25
        ED22 = 26
        ES25 = 27
        ES23 = 28
        ES35 = 29
        ES33 = 30
        ES32 = 31
        ES22 = 32
        ED25 = 33
        ED23 = 34
        ED35 = 35
        ED33 = 36
        ED32 = 37
        ERS3 = 38
        RPSS = 39
        ERS1 = 40
        ERS2 = 41
    }
    class ISO20022.Caaa027001.Algorithm7Code {
        RSAO = 1
        ERSA = 2
    }
    class ISO20022.Caaa027001.Algorithm8Code {
        MGF1 = 1
    }
    class ISO20022.Caaa027001.AlgorithmIdentification31 {
        + Param  : ISO20022.Caaa027001.Parameter7
        + Algo  : String
    }
    ISO20022.Caaa027001.AlgorithmIdentification31 *-- ISO20022.Caaa027001.Parameter7
    class ISO20022.Caaa027001.AlgorithmIdentification32 {
        + Param  : ISO20022.Caaa027001.Parameter12
        + Algo  : String
    }
    ISO20022.Caaa027001.AlgorithmIdentification32 *-- ISO20022.Caaa027001.Parameter12
    class ISO20022.Caaa027001.AlgorithmIdentification33 {
        + Param  : ISO20022.Caaa027001.Parameter16
        + Algo  : String
    }
    ISO20022.Caaa027001.AlgorithmIdentification33 *-- ISO20022.Caaa027001.Parameter16
    class ISO20022.Caaa027001.AlgorithmIdentification34 {
        + Param  : ISO20022.Caaa027001.Parameter18
        + Algo  : String
    }
    ISO20022.Caaa027001.AlgorithmIdentification34 *-- ISO20022.Caaa027001.Parameter18
    class ISO20022.Caaa027001.AlgorithmIdentification35 {
        + Param  : ISO20022.Caaa027001.Parameter17
        + Algo  : String
    }
    ISO20022.Caaa027001.AlgorithmIdentification35 *-- ISO20022.Caaa027001.Parameter17
    class ISO20022.Caaa027001.AlgorithmIdentification36 {
        + Algo  : String
    }
    class ISO20022.Caaa027001.AmountUnit1Code {
        POIN = 1
        MONE = 2
    }
    class ISO20022.Caaa027001.AttributeType1Code {
        CATT = 1
        OUAT = 2
        OATT = 3
        LATT = 4
        CNAT = 5
    }
    class ISO20022.Caaa027001.AuthenticatedData10 {
        + MAC  : String
        + NcpsltdCntt  : ISO20022.Caaa027001.EncapsulatedContent3
        + MACAlgo  : ISO20022.Caaa027001.AlgorithmIdentification31
        + Rcpt  : global::System.Collections.Generic.List~ISO20022.Caaa027001.Recipient15Choice~
        + Vrsn  : Decimal
    }
    ISO20022.Caaa027001.AuthenticatedData10 *-- ISO20022.Caaa027001.EncapsulatedContent3
    ISO20022.Caaa027001.AuthenticatedData10 *-- ISO20022.Caaa027001.AlgorithmIdentification31
    ISO20022.Caaa027001.AuthenticatedData10 *-- ISO20022.Caaa027001.Recipient15Choice
    class ISO20022.Caaa027001.AuthenticationEntity2Code {
        TRML = 1
        ISSR = 2
        ACQR = 3
        MERC = 4
        AGNT = 5
        ICCD = 6
    }
    class ISO20022.Caaa027001.AuthenticationMethod6Code {
        TOKP = 1
        FPIN = 2
        MANU = 3
        ADDS = 4
        CSEC = 5
        PSVE = 6
        CSCV = 7
        CRYP = 8
        CDHI = 9
        BIOM = 10
        ADDB = 11
        CPSG = 12
        SNCT = 13
        SCNL = 14
        SCRT = 15
        PSWD = 16
        PPSG = 17
        NPIN = 18
    }
    class ISO20022.Caaa027001.AuthenticationMethod8Code {
        UKNW = 1
        TOKN = 2
        CPSG = 3
        ADDS = 4
        SNCT = 5
        CSEC = 6
        SCNL = 7
        SCRT = 8
        TOKP = 9
        PSWD = 10
        PSVE = 11
        PPSG = 12
        OTHR = 13
        NPIN = 14
        FPIN = 15
        MOBL = 16
        MERC = 17
        MANU = 18
        CSCV = 19
        CRYP = 20
        CDHI = 21
        BIOM = 22
        BYPS = 23
        ADDB = 24
        TOKA = 25
    }
    class ISO20022.Caaa027001.AuthenticationResult1Code {
        UCRP = 1
        CRPT = 2
        AUTH = 3
        CARD = 4
        MRCH = 5
        DENY = 6
    }
    class ISO20022.Caaa027001.BytePadding1Code {
        RAND = 1
        NULL = 2
        NULG = 3
        NUL8 = 4
        LNGT = 5
    }
    class ISO20022.Caaa027001.CardDataReading5Code {
        CDFL = 1
        ECTL = 2
        CTLS = 3
        DFLE = 4
        CICC = 5
        MGST = 6
        BRCD = 7
        PHYS = 8
        TAGC = 9
    }
    class ISO20022.Caaa027001.CardDataReading8Code {
        OPTC = 1
        QRCD = 2
        UNKW = 3
        SICC = 4
        CDFL = 5
        ECTL = 6
        CTLS = 7
        DFLE = 8
        CICC = 9
        MGST = 10
        BRCD = 11
        PHYS = 12
        TAGC = 13
    }
    class ISO20022.Caaa027001.CardIdentificationType1Code {
        UUID = 1
        PRIV = 2
        CPAN = 3
        PHON = 4
        ISO2 = 5
        BARC = 6
        ACCT = 7
    }
    class ISO20022.Caaa027001.CardPaymentBatchTransferResponse12 {
        + DataSet  : global::System.Collections.Generic.List~ISO20022.Caaa027001.CardPaymentDataSet39~
        + TxTtls  : global::System.Collections.Generic.List~ISO20022.Caaa027001.TransactionTotals12~
    }
    ISO20022.Caaa027001.CardPaymentBatchTransferResponse12 *-- ISO20022.Caaa027001.CardPaymentDataSet39
    ISO20022.Caaa027001.CardPaymentBatchTransferResponse12 *-- ISO20022.Caaa027001.TransactionTotals12
    class ISO20022.Caaa027001.CardPaymentDataSet38 {
        + Tx  : ISO20022.Caaa027001.CardPaymentTransactionAdviceResponse5
        + Envt  : ISO20022.Caaa027001.CardPaymentEnvironment81
        + TxRspn  : ISO20022.Caaa027001.ResponseType10
        + TxSeqCntr  : String
    }
    ISO20022.Caaa027001.CardPaymentDataSet38 *-- ISO20022.Caaa027001.CardPaymentTransactionAdviceResponse5
    ISO20022.Caaa027001.CardPaymentDataSet38 *-- ISO20022.Caaa027001.CardPaymentEnvironment81
    ISO20022.Caaa027001.CardPaymentDataSet38 *-- ISO20022.Caaa027001.ResponseType10
    class ISO20022.Caaa027001.CardPaymentDataSet39 {
        + RsmdRjctn  : global::System.Collections.Generic.List~ISO20022.Caaa027001.CardPaymentDataSet38~
        + RsmdApprvl  : global::System.Collections.Generic.List~ISO20022.Caaa027001.CardPaymentDataSet38~
        + SspdTx  : global::System.Collections.Generic.List~ISO20022.Caaa027001.CardPaymentDataSet38~
        + RjctdTx  : global::System.Collections.Generic.List~ISO20022.Caaa027001.CardPaymentDataSet38~
        + TxTtls  : global::System.Collections.Generic.List~ISO20022.Caaa027001.TransactionTotals12~
        + DataSetInitr  : ISO20022.Caaa027001.GenericIdentification176
        + RmvDataSet  : String
        + DataSetRslt  : ISO20022.Caaa027001.ResponseType10
        + DataSetId  : ISO20022.Caaa027001.DataSetIdentification5
    }
    ISO20022.Caaa027001.CardPaymentDataSet39 *-- ISO20022.Caaa027001.CardPaymentDataSet38
    ISO20022.Caaa027001.CardPaymentDataSet39 *-- ISO20022.Caaa027001.CardPaymentDataSet38
    ISO20022.Caaa027001.CardPaymentDataSet39 *-- ISO20022.Caaa027001.CardPaymentDataSet38
    ISO20022.Caaa027001.CardPaymentDataSet39 *-- ISO20022.Caaa027001.CardPaymentDataSet38
    ISO20022.Caaa027001.CardPaymentDataSet39 *-- ISO20022.Caaa027001.TransactionTotals12
    ISO20022.Caaa027001.CardPaymentDataSet39 *-- ISO20022.Caaa027001.GenericIdentification176
    ISO20022.Caaa027001.CardPaymentDataSet39 *-- ISO20022.Caaa027001.ResponseType10
    ISO20022.Caaa027001.CardPaymentDataSet39 *-- ISO20022.Caaa027001.DataSetIdentification5
    class ISO20022.Caaa027001.CardPaymentEnvironment81 {
        + SaleEnvt  : ISO20022.Caaa027001.RetailerSaleEnvironment2
        + PrtctdCrdhldrData  : ISO20022.Caaa027001.ContentInformationType40
        + Crdhldr  : ISO20022.Caaa027001.Cardholder21
        + MrchntTkn  : ISO20022.Caaa027001.MerchantToken2
        + PmtTkn  : ISO20022.Caaa027001.Token1
        + Wllt  : ISO20022.Caaa027001.CustomerDevice3
        + CstmrDvc  : ISO20022.Caaa027001.CustomerDevice3
        + LltyAcct  : global::System.Collections.Generic.List~ISO20022.Caaa027001.LoyaltyAccount3~
        + StordValAcct  : global::System.Collections.Generic.List~ISO20022.Caaa027001.StoredValueAccount2~
        + Chck  : ISO20022.Caaa027001.Check1
        + Card  : ISO20022.Caaa027001.PaymentCard35
        + POI  : ISO20022.Caaa027001.PointOfInteraction15
        + Mrchnt  : ISO20022.Caaa027001.Organisation41
        + SvcPrvdr  : ISO20022.Caaa027001.Acquirer10
        + Acqrr  : ISO20022.Caaa027001.Acquirer10
    }
    ISO20022.Caaa027001.CardPaymentEnvironment81 *-- ISO20022.Caaa027001.RetailerSaleEnvironment2
    ISO20022.Caaa027001.CardPaymentEnvironment81 *-- ISO20022.Caaa027001.ContentInformationType40
    ISO20022.Caaa027001.CardPaymentEnvironment81 *-- ISO20022.Caaa027001.Cardholder21
    ISO20022.Caaa027001.CardPaymentEnvironment81 *-- ISO20022.Caaa027001.MerchantToken2
    ISO20022.Caaa027001.CardPaymentEnvironment81 *-- ISO20022.Caaa027001.Token1
    ISO20022.Caaa027001.CardPaymentEnvironment81 *-- ISO20022.Caaa027001.CustomerDevice3
    ISO20022.Caaa027001.CardPaymentEnvironment81 *-- ISO20022.Caaa027001.CustomerDevice3
    ISO20022.Caaa027001.CardPaymentEnvironment81 *-- ISO20022.Caaa027001.LoyaltyAccount3
    ISO20022.Caaa027001.CardPaymentEnvironment81 *-- ISO20022.Caaa027001.StoredValueAccount2
    ISO20022.Caaa027001.CardPaymentEnvironment81 *-- ISO20022.Caaa027001.Check1
    ISO20022.Caaa027001.CardPaymentEnvironment81 *-- ISO20022.Caaa027001.PaymentCard35
    ISO20022.Caaa027001.CardPaymentEnvironment81 *-- ISO20022.Caaa027001.PointOfInteraction15
    ISO20022.Caaa027001.CardPaymentEnvironment81 *-- ISO20022.Caaa027001.Organisation41
    ISO20022.Caaa027001.CardPaymentEnvironment81 *-- ISO20022.Caaa027001.Acquirer10
    ISO20022.Caaa027001.CardPaymentEnvironment81 *-- ISO20022.Caaa027001.Acquirer10
    class ISO20022.Caaa027001.CardPaymentTransactionAdviceResponse5 {
        + Rspn  : String
        + TxId  : ISO20022.Caaa027001.TransactionIdentifier1
        + SaleRefId  : String
    }
    ISO20022.Caaa027001.CardPaymentTransactionAdviceResponse5 *-- ISO20022.Caaa027001.TransactionIdentifier1
    class ISO20022.Caaa027001.CardPaymentTransactionAdviceResponse8 {
        + Rspn  : String
        + RcncltnId  : String
        + RcptTxId  : String
        + InitrTxId  : String
        + TxId  : ISO20022.Caaa027001.TransactionIdentifier1
        + SaleRefId  : String
    }
    ISO20022.Caaa027001.CardPaymentTransactionAdviceResponse8 *-- ISO20022.Caaa027001.TransactionIdentifier1
    class ISO20022.Caaa027001.CardProductType1Code {
        CONS = 1
        COMM = 2
    }
    class ISO20022.Caaa027001.Cardholder21 {
        + MobData  : global::System.Collections.Generic.List~ISO20022.Caaa027001.MobileData6~
        + PrsnlData  : String
        + TxVrfctnRslt  : global::System.Collections.Generic.List~ISO20022.Caaa027001.TransactionVerificationResult4~
        + Authntcn  : global::System.Collections.Generic.List~ISO20022.Caaa027001.CardholderAuthentication17~
        + Vhcl  : ISO20022.Caaa027001.Vehicle1
        + TripNb  : String
        + ShppgAdr  : ISO20022.Caaa027001.PostalAddress22
        + BllgAdr  : ISO20022.Caaa027001.PostalAddress22
        + Lang  : String
        + Nm  : String
        + Id  : ISO20022.Caaa027001.PersonIdentification15
    }
    ISO20022.Caaa027001.Cardholder21 *-- ISO20022.Caaa027001.MobileData6
    ISO20022.Caaa027001.Cardholder21 *-- ISO20022.Caaa027001.TransactionVerificationResult4
    ISO20022.Caaa027001.Cardholder21 *-- ISO20022.Caaa027001.CardholderAuthentication17
    ISO20022.Caaa027001.Cardholder21 *-- ISO20022.Caaa027001.Vehicle1
    ISO20022.Caaa027001.Cardholder21 *-- ISO20022.Caaa027001.PostalAddress22
    ISO20022.Caaa027001.Cardholder21 *-- ISO20022.Caaa027001.PostalAddress22
    ISO20022.Caaa027001.Cardholder21 *-- ISO20022.Caaa027001.PersonIdentification15
    class ISO20022.Caaa027001.CardholderAuthentication17 {
        + AuthntcnAddtlInf  : ISO20022.Caaa027001.ExternallyDefinedData5
        + AuthntcnRslt  : String
        + AuthntcnLvl  : String
        + AuthntcnTp  : String
        + AdrVrfctn  : ISO20022.Caaa027001.AddressVerification1
        + CrdhldrId  : ISO20022.Caaa027001.PersonIdentification15
        + CrdhldrOnLinePIN  : ISO20022.Caaa027001.OnLinePIN11
        + PrtctdAuthntcnVal  : ISO20022.Caaa027001.ContentInformationType40
        + AuthntcnVal  : String
        + AuthntcnXmptn  : String
        + AuthntcnMtd  : String
    }
    ISO20022.Caaa027001.CardholderAuthentication17 *-- ISO20022.Caaa027001.ExternallyDefinedData5
    ISO20022.Caaa027001.CardholderAuthentication17 *-- ISO20022.Caaa027001.AddressVerification1
    ISO20022.Caaa027001.CardholderAuthentication17 *-- ISO20022.Caaa027001.PersonIdentification15
    ISO20022.Caaa027001.CardholderAuthentication17 *-- ISO20022.Caaa027001.OnLinePIN11
    ISO20022.Caaa027001.CardholderAuthentication17 *-- ISO20022.Caaa027001.ContentInformationType40
    class ISO20022.Caaa027001.CardholderVerificationCapability4Code {
        OTHR = 1
        NOVF = 2
        NBIO = 3
        SCEC = 4
        PKIS = 5
        NPIN = 6
        FEPN = 7
        FCPN = 8
        FDSG = 9
        FBIO = 10
        FBIG = 11
        MNVR = 12
        MNSG = 13
        CHDT = 14
        APKI = 15
    }
    class ISO20022.Caaa027001.CertificateIssuer1 {
        + RltvDstngshdNm  : global::System.Collections.Generic.List~ISO20022.Caaa027001.RelativeDistinguishedName1~
    }
    ISO20022.Caaa027001.CertificateIssuer1 *-- ISO20022.Caaa027001.RelativeDistinguishedName1
    class ISO20022.Caaa027001.Check1 {
        + Ctry  : String
        + ChckTp  : String
        + ChckTrckData2  : ISO20022.Caaa027001.TrackData2
        + ChckCardNb  : String
        + ChckNb  : String
        + AcctNb  : String
        + BkId  : String
    }
    ISO20022.Caaa027001.Check1 *-- ISO20022.Caaa027001.TrackData2
    class ISO20022.Caaa027001.CheckType1Code {
        PERS = 1
        PAYR = 2
        GOVC = 3
        BUSI = 4
        BANK = 5
    }
    class ISO20022.Caaa027001.CommunicationAddress9 {
        + AddtlCtctInf  : String
        + CstmrSvc  : String
        + Phne  : String
        + URLAdr  : String
        + Email  : String
        + PstlAdr  : ISO20022.Caaa027001.PostalAddress22
    }
    ISO20022.Caaa027001.CommunicationAddress9 *-- ISO20022.Caaa027001.PostalAddress22
    class ISO20022.Caaa027001.CommunicationCharacteristics5 {
        + PhysIntrfc  : ISO20022.Caaa027001.PhysicalInterfaceParameter1
        + Params  : ISO20022.Caaa027001.NetworkParameters7
        + Actv  : String
        + RmotPty  : global::System.Collections.Generic.List~String~
        + ComTp  : String
    }
    ISO20022.Caaa027001.CommunicationCharacteristics5 *-- ISO20022.Caaa027001.PhysicalInterfaceParameter1
    ISO20022.Caaa027001.CommunicationCharacteristics5 *-- ISO20022.Caaa027001.NetworkParameters7
    class ISO20022.Caaa027001.ContentInformationType38 {
        + SgndData  : ISO20022.Caaa027001.SignedData9
        + AuthntcdData  : ISO20022.Caaa027001.AuthenticatedData10
        + CnttTp  : String
    }
    ISO20022.Caaa027001.ContentInformationType38 *-- ISO20022.Caaa027001.SignedData9
    ISO20022.Caaa027001.ContentInformationType38 *-- ISO20022.Caaa027001.AuthenticatedData10
    class ISO20022.Caaa027001.ContentInformationType39 {
        + DgstdData  : ISO20022.Caaa027001.DigestedData6
        + SgndData  : ISO20022.Caaa027001.SignedData9
        + AuthntcdData  : ISO20022.Caaa027001.AuthenticatedData10
        + EnvlpdData  : ISO20022.Caaa027001.EnvelopedData11
        + CnttTp  : String
    }
    ISO20022.Caaa027001.ContentInformationType39 *-- ISO20022.Caaa027001.DigestedData6
    ISO20022.Caaa027001.ContentInformationType39 *-- ISO20022.Caaa027001.SignedData9
    ISO20022.Caaa027001.ContentInformationType39 *-- ISO20022.Caaa027001.AuthenticatedData10
    ISO20022.Caaa027001.ContentInformationType39 *-- ISO20022.Caaa027001.EnvelopedData11
    class ISO20022.Caaa027001.ContentInformationType40 {
        + EnvlpdData  : ISO20022.Caaa027001.EnvelopedData11
        + CnttTp  : String
    }
    ISO20022.Caaa027001.ContentInformationType40 *-- ISO20022.Caaa027001.EnvelopedData11
    class ISO20022.Caaa027001.ContentType2Code {
        AUTH = 1
        DGST = 2
        EVLP = 3
        SIGN = 4
        DATA = 5
    }
    class ISO20022.Caaa027001.CryptographicKey18 {
        + AddtlMgmtInf  : global::System.Collections.Generic.List~ISO20022.Caaa027001.GenericInformation1~
        + KeyChckVal  : String
        + PrtctdCmpntWthAuthrsdAccs  : global::System.Collections.Generic.List~ISO20022.Caaa027001.ContentInformationType39~
        + CmpntWthAuthrsdAccs  : global::System.Collections.Generic.List~ISO20022.Caaa027001.GenericIdentification186~
        + KeyVal  : ISO20022.Caaa027001.ContentInformationType39
        + DeactvtnDt  : DateTime
        + ActvtnDt  : DateTime
        + Fctn  : global::System.Collections.Generic.List~String~
        + Tp  : String
        + Vrsn  : String
        + ItmNb  : String
        + SctyPrfl  : String
        + Nm  : String
        + AddtlId  : String
        + Id  : String
    }
    ISO20022.Caaa027001.CryptographicKey18 *-- ISO20022.Caaa027001.GenericInformation1
    ISO20022.Caaa027001.CryptographicKey18 *-- ISO20022.Caaa027001.ContentInformationType39
    ISO20022.Caaa027001.CryptographicKey18 *-- ISO20022.Caaa027001.GenericIdentification186
    ISO20022.Caaa027001.CryptographicKey18 *-- ISO20022.Caaa027001.ContentInformationType39
    class ISO20022.Caaa027001.CryptographicKeyType3Code {
        EDE4 = 1
        AES5 = 2
        AES9 = 3
        DKP9 = 4
        EDE3 = 5
        AES2 = 6
    }
    class ISO20022.Caaa027001.CustomerDevice3 {
        + Prvdr  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Caaa027001.DataSetCategory8Code {
        RCLE = 1
        MGTP = 2
        DLGT = 3
        STRP = 4
        AKCP = 5
        TXCP = 6
        MRPR = 7
        AQPR = 8
        VDPR = 9
        SWPK = 10
    }
    class ISO20022.Caaa027001.DataSetIdentification5 {
        + CreDtTm  : DateTime
        + Vrsn  : String
        + Tp  : String
        + Nm  : String
    }
    class ISO20022.Caaa027001.DateAndPlaceOfBirth1 {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Caaa027001.DigestedData6 {
        + Dgst  : String
        + NcpsltdCntt  : ISO20022.Caaa027001.EncapsulatedContent3
        + DgstAlgo  : ISO20022.Caaa027001.AlgorithmIdentification36
        + Vrsn  : Decimal
    }
    ISO20022.Caaa027001.DigestedData6 *-- ISO20022.Caaa027001.EncapsulatedContent3
    ISO20022.Caaa027001.DigestedData6 *-- ISO20022.Caaa027001.AlgorithmIdentification36
    class ISO20022.Caaa027001.DisplayCapabilities4 {
        + AvlblLang  : global::System.Collections.Generic.List~String~
        + LineWidth  : Decimal
        + NbOfLines  : Decimal
        + AvlblFrmt  : global::System.Collections.Generic.List~String~
        + Dstn  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Caaa027001.EncapsulatedContent3 {
        + Cntt  : String
        + CnttTp  : String
    }
    class ISO20022.Caaa027001.EncryptedContent7 {
        + NcrptdData  : String
        + CnttNcrptnAlgo  : ISO20022.Caaa027001.AlgorithmIdentification32
        + CnttTp  : String
    }
    ISO20022.Caaa027001.EncryptedContent7 *-- ISO20022.Caaa027001.AlgorithmIdentification32
    class ISO20022.Caaa027001.EncryptionFormat2Code {
        I238 = 1
        TR34 = 2
        TR31 = 3
    }
    class ISO20022.Caaa027001.EnvelopedData11 {
        + NcrptdCntt  : ISO20022.Caaa027001.EncryptedContent7
        + Rcpt  : global::System.Collections.Generic.List~ISO20022.Caaa027001.Recipient15Choice~
        + OrgtrInf  : ISO20022.Caaa027001.OriginatorInformation1
        + Vrsn  : Decimal
    }
    ISO20022.Caaa027001.EnvelopedData11 *-- ISO20022.Caaa027001.EncryptedContent7
    ISO20022.Caaa027001.EnvelopedData11 *-- ISO20022.Caaa027001.Recipient15Choice
    ISO20022.Caaa027001.EnvelopedData11 *-- ISO20022.Caaa027001.OriginatorInformation1
    class ISO20022.Caaa027001.Exemption1Code {
        TMBE = 1
        PKGE = 2
        TRAE = 3
        SCAD = 4
        SCPE = 5
        RECP = 6
        MINT = 7
        LOWA = 8
    }
    class ISO20022.Caaa027001.ExternallyDefinedData5 {
        + Tp  : String
        + PrtctdVal  : ISO20022.Caaa027001.ContentInformationType39
        + Val  : String
        + Id  : String
    }
    ISO20022.Caaa027001.ExternallyDefinedData5 *-- ISO20022.Caaa027001.ContentInformationType39
    class ISO20022.Caaa027001.GenericIdentification176 {
        + ShrtNm  : String
        + Ctry  : String
        + Issr  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Caaa027001.GenericIdentification177 {
        + Glctn  : ISO20022.Caaa027001.Geolocation1
        + RmotAccs  : ISO20022.Caaa027001.NetworkParameters7
        + ShrtNm  : String
        + Ctry  : String
        + Issr  : String
        + Tp  : String
        + Id  : String
    }
    ISO20022.Caaa027001.GenericIdentification177 *-- ISO20022.Caaa027001.Geolocation1
    ISO20022.Caaa027001.GenericIdentification177 *-- ISO20022.Caaa027001.NetworkParameters7
    class ISO20022.Caaa027001.GenericIdentification186 {
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Caaa027001.GenericIdentification32 {
        + ShrtNm  : String
        + Issr  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Caaa027001.GenericIdentification4 {
        + IdTp  : String
        + Id  : String
    }
    class ISO20022.Caaa027001.GenericIdentification48 {
        + Issr  : String
        + Vrsn  : String
        + Id  : String
    }
    class ISO20022.Caaa027001.GenericInformation1 {
        + Val  : String
        + Nm  : String
    }
    class ISO20022.Caaa027001.Geolocation1 {
        + UTMCordints  : ISO20022.Caaa027001.GeolocationUTMCoordinates1
        + GeogcCordints  : ISO20022.Caaa027001.GeolocationGeographicCoordinates1
    }
    ISO20022.Caaa027001.Geolocation1 *-- ISO20022.Caaa027001.GeolocationUTMCoordinates1
    ISO20022.Caaa027001.Geolocation1 *-- ISO20022.Caaa027001.GeolocationGeographicCoordinates1
    class ISO20022.Caaa027001.GeolocationGeographicCoordinates1 {
        + Long  : String
        + Lat  : String
    }
    class ISO20022.Caaa027001.GeolocationUTMCoordinates1 {
        + UTMNrthwrd  : String
        + UTMEstwrd  : String
        + UTMZone  : String
    }
    class ISO20022.Caaa027001.Header56 {
        + RcptPty  : ISO20022.Caaa027001.GenericIdentification177
        + InitgPty  : ISO20022.Caaa027001.GenericIdentification176
        + CreDtTm  : DateTime
        + XchgId  : Decimal
        + FrmtVrsn  : String
        + DwnldTrf  : String
    }
    ISO20022.Caaa027001.Header56 *-- ISO20022.Caaa027001.GenericIdentification177
    ISO20022.Caaa027001.Header56 *-- ISO20022.Caaa027001.GenericIdentification176
    class ISO20022.Caaa027001.IssuerAndSerialNumber2 {
        + SrlNb  : String
        + Issr  : ISO20022.Caaa027001.CertificateIssuer1
    }
    ISO20022.Caaa027001.IssuerAndSerialNumber2 *-- ISO20022.Caaa027001.CertificateIssuer1
    class ISO20022.Caaa027001.KEK9 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Caaa027001.AlgorithmIdentification32
        + KEKId  : ISO20022.Caaa027001.KEKIdentifier7
        + Vrsn  : Decimal
    }
    ISO20022.Caaa027001.KEK9 *-- ISO20022.Caaa027001.AlgorithmIdentification32
    ISO20022.Caaa027001.KEK9 *-- ISO20022.Caaa027001.KEKIdentifier7
    class ISO20022.Caaa027001.KEKIdentifier7 {
        + DerivtnId  : String
        + SeqNb  : Decimal
        + KeyVrsn  : String
        + KeyId  : String
    }
    class ISO20022.Caaa027001.KeyTransport10 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Caaa027001.AlgorithmIdentification35
        + RcptId  : ISO20022.Caaa027001.Recipient13Choice
        + Vrsn  : Decimal
    }
    ISO20022.Caaa027001.KeyTransport10 *-- ISO20022.Caaa027001.AlgorithmIdentification35
    ISO20022.Caaa027001.KeyTransport10 *-- ISO20022.Caaa027001.Recipient13Choice
    class ISO20022.Caaa027001.KeyUsage1Code {
        KEYD = 1
        KEYX = 2
        KEYI = 3
        KEYG = 4
        PINV = 5
        PIND = 6
        PINE = 7
        SUGV = 8
        SIGG = 9
        MACV = 10
        MACG = 11
        TRNX = 12
        TRNI = 13
        DDEC = 14
        DENC = 15
        DCPT = 16
        ENCR = 17
    }
    class ISO20022.Caaa027001.LocationCategory3Code {
        VNDG = 1
        SSLE = 2
        MSLE = 3
        MPMP = 4
        MPOI = 5
        IPMP = 6
        INDR = 7
    }
    class ISO20022.Caaa027001.LocationCategory4Code {
        VIRT = 1
        FIXD = 2
        NMDC = 3
        ABRD = 4
    }
    class ISO20022.Caaa027001.LoyaltyAccount3 {
        + Bal  : Decimal
        + Ccy  : String
        + Unit  : String
        + OwnrNm  : String
        + Prvdr  : String
        + Brnd  : String
        + IdTp  : String
        + NtryMd  : String
        + LltyId  : String
    }
    class ISO20022.Caaa027001.LoyaltyHandling1Code {
        REQU = 1
        PROP = 2
        PRCS = 3
        DENY = 4
        ALLO = 5
    }
    class ISO20022.Caaa027001.MemoryCharacteristics1 {
        + Unit  : String
        + FreeSz  : Decimal
        + TtlSz  : Decimal
        + Id  : String
    }
    class ISO20022.Caaa027001.MemoryUnit1Code {
        TERA = 1
        PETA = 2
        MEGA = 3
        KILO = 4
        GIGA = 5
        EXAB = 6
        BYTE = 7
    }
    class ISO20022.Caaa027001.MerchantToken2 {
        + TknInittdInd  : String
        + TknAssrncMtd  : String
        + TknAssrncData  : String
        + TknAssrncLvl  : Decimal
        + TknRqstr  : ISO20022.Caaa027001.PaymentTokenIdentifiers1
        + TknChrtc  : global::System.Collections.Generic.List~String~
        + TknXpryDt  : String
        + Tkn  : String
    }
    ISO20022.Caaa027001.MerchantToken2 *-- ISO20022.Caaa027001.PaymentTokenIdentifiers1
    class ISO20022.Caaa027001.MobileData6 {
        + PrtctdMobData  : ISO20022.Caaa027001.ContentInformationType40
        + SnstvMobData  : ISO20022.Caaa027001.SensitiveMobileData1
        + Glctn  : ISO20022.Caaa027001.Geolocation1
        + MobMskdMSISDN  : String
        + MobNtwkCd  : String
        + MobCtryCd  : String
    }
    ISO20022.Caaa027001.MobileData6 *-- ISO20022.Caaa027001.ContentInformationType40
    ISO20022.Caaa027001.MobileData6 *-- ISO20022.Caaa027001.SensitiveMobileData1
    ISO20022.Caaa027001.MobileData6 *-- ISO20022.Caaa027001.Geolocation1
    class ISO20022.Caaa027001.NetworkParameters7 {
        + SctyPrfl  : String
        + ClntCert  : global::System.Collections.Generic.List~String~
        + SvrCertIdr  : global::System.Collections.Generic.List~String~
        + SvrCert  : global::System.Collections.Generic.List~String~
        + AccsCd  : String
        + UsrNm  : String
        + Adr  : global::System.Collections.Generic.List~ISO20022.Caaa027001.NetworkParameters9~
    }
    ISO20022.Caaa027001.NetworkParameters7 *-- ISO20022.Caaa027001.NetworkParameters9
    class ISO20022.Caaa027001.NetworkParameters9 {
        + AdrVal  : String
        + NtwkTp  : String
    }
    class ISO20022.Caaa027001.NetworkType1Code {
        PSTN = 1
        IPNW = 2
    }
    class ISO20022.Caaa027001.OnLineCapability1Code {
        SMON = 1
        ONLN = 2
        OFLN = 3
    }
    class ISO20022.Caaa027001.OnLinePIN11 {
        + AddtlInpt  : String
        + PINFrmt  : String
        + NcrptdPINBlck  : ISO20022.Caaa027001.ContentInformationType40
    }
    ISO20022.Caaa027001.OnLinePIN11 *-- ISO20022.Caaa027001.ContentInformationType40
    class ISO20022.Caaa027001.Organisation41 {
        + SchmeData  : String
        + LctnAndCtct  : ISO20022.Caaa027001.CommunicationAddress9
        + LctnCtgy  : String
        + CmonNm  : String
        + Id  : ISO20022.Caaa027001.GenericIdentification32
    }
    ISO20022.Caaa027001.Organisation41 *-- ISO20022.Caaa027001.CommunicationAddress9
    ISO20022.Caaa027001.Organisation41 *-- ISO20022.Caaa027001.GenericIdentification32
    class ISO20022.Caaa027001.OriginatorInformation1 {
        + Cert  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Caaa027001.OutputFormat1Code {
        HTML = 1
        TEXT = 2
        MREF = 3
    }
    class ISO20022.Caaa027001.PINFormat3Code {
        ISO5 = 1
        ISO4 = 2
        ISO3 = 3
        ISO2 = 4
        ISO1 = 5
        ISO0 = 6
    }
    class ISO20022.Caaa027001.POICommunicationType2Code {
        WT5G = 1
        WT4G = 2
        WT3G = 3
        WT2G = 4
        WIFI = 5
        USBH = 6
        USBD = 7
        RS23 = 8
        PSTN = 9
        GSMF = 10
        GPRS = 11
        ETHR = 12
        BLTH = 13
    }
    class ISO20022.Caaa027001.POIComponentAssessment1Code {
        EVAL = 1
        CERT = 2
        APPL = 3
    }
    class ISO20022.Caaa027001.POIComponentStatus1Code {
        DACT = 1
        OPER = 2
        OUTD = 3
        WAIT = 4
    }
    class ISO20022.Caaa027001.POIComponentType7Code {
        PROB = 1
        RPFL = 2
        CONF = 3
        SOFT = 4
        MDFL = 5
        LOGF = 6
        SAPR = 7
        SACP = 8
        TMSP = 9
        CRTF = 10
        MRPR = 11
        OPST = 12
        DRVR = 13
        MDWR = 14
        EMVO = 15
        EMVK = 16
        APLI = 17
        SECM = 18
        DVCE = 19
        TERM = 20
        SERV = 21
        SCPR = 22
        TLPR = 23
        APPR = 24
        AQPP = 25
    }
    class ISO20022.Caaa027001.PackageType5 {
        + PackgBlck  : global::System.Collections.Generic.List~ISO20022.Caaa027001.ExternallyDefinedData5~
        + OffsetEnd  : Decimal
        + OffsetStart  : Decimal
        + PackgLngth  : Decimal
        + PackgId  : ISO20022.Caaa027001.GenericIdentification176
    }
    ISO20022.Caaa027001.PackageType5 *-- ISO20022.Caaa027001.ExternallyDefinedData5
    ISO20022.Caaa027001.PackageType5 *-- ISO20022.Caaa027001.GenericIdentification176
    class ISO20022.Caaa027001.Parameter12 {
        + BPddg  : String
        + InitlstnVctr  : String
        + NcrptnFrmt  : String
    }
    class ISO20022.Caaa027001.Parameter16 {
        + OIDCrvNm  : String
        + TrlrFld  : Decimal
        + SaltLngth  : Decimal
        + MskGnrtrAlgo  : ISO20022.Caaa027001.AlgorithmIdentification34
        + DgstAlgo  : String
    }
    ISO20022.Caaa027001.Parameter16 *-- ISO20022.Caaa027001.AlgorithmIdentification34
    class ISO20022.Caaa027001.Parameter17 {
        + MskGnrtrAlgo  : ISO20022.Caaa027001.AlgorithmIdentification34
        + DgstAlgo  : String
        + NcrptnFrmt  : String
    }
    ISO20022.Caaa027001.Parameter17 *-- ISO20022.Caaa027001.AlgorithmIdentification34
    class ISO20022.Caaa027001.Parameter18 {
        + DgstAlgo  : String
    }
    class ISO20022.Caaa027001.Parameter7 {
        + BPddg  : String
        + InitlstnVctr  : String
    }
    class ISO20022.Caaa027001.PartyType33Code {
        TMGT = 1
        TAXH = 2
        MTMG = 3
        DLIS = 4
        CISS = 5
        ACQR = 6
        ITAG = 7
        ACCP = 8
        MERC = 9
        OPOI = 10
    }
    class ISO20022.Caaa027001.PartyType3Code {
        DLIS = 1
        CISS = 2
        ACQR = 3
        ITAG = 4
        ACCP = 5
        MERC = 6
        OPOI = 7
    }
    class ISO20022.Caaa027001.PartyType4Code {
        TAXH = 1
        CISS = 2
        ACQR = 3
        ITAG = 4
        ACCP = 5
        MERC = 6
    }
    class ISO20022.Caaa027001.PartyType7Code {
        SALE = 1
        TMGT = 2
        PCPT = 3
        ITAG = 4
        ACQR = 5
    }
    class ISO20022.Caaa027001.PaymentCard35 {
        + AddtlCardData  : String
        + SvcOptn  : String
        + AllwdPdct  : global::System.Collections.Generic.List~String~
        + IntrnlCard  : String
        + CardPdctSubTp  : String
        + CardPdctTp  : String
        + CardBrnd  : String
        + CardPdctPrfl  : String
        + CardCcyCd  : String
        + CardCtryCd  : String
        + IssrBIN  : String
        + MskdPAN  : String
        + PmtAcctRef  : String
        + PlainCardData  : ISO20022.Caaa027001.PlainCardData22
        + PrvtCardData  : String
        + PrtctdCardData  : ISO20022.Caaa027001.ContentInformationType40
    }
    ISO20022.Caaa027001.PaymentCard35 *-- ISO20022.Caaa027001.PlainCardData22
    ISO20022.Caaa027001.PaymentCard35 *-- ISO20022.Caaa027001.ContentInformationType40
    class ISO20022.Caaa027001.PaymentTokenIdentifiers1 {
        + RqstrId  : String
        + PrvdrId  : String
    }
    class ISO20022.Caaa027001.PersonIdentification15 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Caaa027001.GenericIdentification4~
        + DtAndPlcOfBirth  : ISO20022.Caaa027001.DateAndPlaceOfBirth1
        + EmailAdr  : String
        + Dept  : String
        + JobNb  : String
        + MplyeeIdNb  : String
        + MplyrIdNb  : String
        + IdntyCardNb  : String
        + TaxIdNb  : String
        + PsptNb  : String
        + AlnRegnNb  : String
        + SclSctyNb  : String
        + CstmrNb  : String
        + DrvrId  : String
        + DrvrLicNm  : String
        + DrvrLicLctn  : String
        + DrvrLicNb  : String
    }
    ISO20022.Caaa027001.PersonIdentification15 *-- ISO20022.Caaa027001.GenericIdentification4
    ISO20022.Caaa027001.PersonIdentification15 *-- ISO20022.Caaa027001.DateAndPlaceOfBirth1
    class ISO20022.Caaa027001.PhysicalInterfaceParameter1 {
        + AddtlParams  : String
        + SctyPrfl  : String
        + AccsCd  : String
        + UsrNm  : String
        + IntrfcTp  : String
        + IntrfcNm  : String
    }
    class ISO20022.Caaa027001.PlainCardData17 {
        + NtryMd  : String
        + AddtlCardData  : global::System.Collections.Generic.List~String~
        + Trck3  : String
        + Trck2  : String
        + Trck1  : String
        + PAN  : String
    }
    class ISO20022.Caaa027001.PlainCardData22 {
        + CrdhldrNm  : String
        + Trck3  : String
        + Trck2  : String
        + Trck1  : String
        + SvcCd  : String
        + XpryDt  : String
        + FctvDt  : String
        + CardSeqNb  : String
        + PAN  : String
    }
    class ISO20022.Caaa027001.PointOfInteraction15 {
        + Cmpnt  : global::System.Collections.Generic.List~ISO20022.Caaa027001.PointOfInteractionComponent17~
        + TermnlIntgtn  : String
        + TmZone  : String
        + Cpblties  : ISO20022.Caaa027001.PointOfInteractionCapabilities9
        + GrpId  : String
        + SysNm  : String
        + Id  : ISO20022.Caaa027001.GenericIdentification177
    }
    ISO20022.Caaa027001.PointOfInteraction15 *-- ISO20022.Caaa027001.PointOfInteractionComponent17
    ISO20022.Caaa027001.PointOfInteraction15 *-- ISO20022.Caaa027001.PointOfInteractionCapabilities9
    ISO20022.Caaa027001.PointOfInteraction15 *-- ISO20022.Caaa027001.GenericIdentification177
    class ISO20022.Caaa027001.PointOfInteractionCapabilities9 {
        + MsgCpblties  : global::System.Collections.Generic.List~ISO20022.Caaa027001.DisplayCapabilities4~
        + OnLineCpblties  : String
        + CardCaptrCpbl  : String
        + MxScrptLngth  : Decimal
        + ApprvlCdLngth  : Decimal
        + PINLngthCpblties  : Decimal
        + CrdhldrVrfctnCpblties  : global::System.Collections.Generic.List~String~
        + CardRdngCpblties  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Caaa027001.PointOfInteractionCapabilities9 *-- ISO20022.Caaa027001.DisplayCapabilities4
    class ISO20022.Caaa027001.PointOfInteractionComponent17 {
        + PrbVal  : String
        + Packg  : global::System.Collections.Generic.List~ISO20022.Caaa027001.PackageType5~
        + Assmnt  : global::System.Collections.Generic.List~ISO20022.Caaa027001.PointOfInteractionComponentAssessment1~
        + Chrtcs  : ISO20022.Caaa027001.PointOfInteractionComponentCharacteristics10
        + StdCmplc  : global::System.Collections.Generic.List~ISO20022.Caaa027001.GenericIdentification48~
        + Sts  : ISO20022.Caaa027001.PointOfInteractionComponentStatus3
        + Id  : ISO20022.Caaa027001.PointOfInteractionComponentIdentification2
        + SubTpInf  : String
        + Tp  : String
    }
    ISO20022.Caaa027001.PointOfInteractionComponent17 *-- ISO20022.Caaa027001.PackageType5
    ISO20022.Caaa027001.PointOfInteractionComponent17 *-- ISO20022.Caaa027001.PointOfInteractionComponentAssessment1
    ISO20022.Caaa027001.PointOfInteractionComponent17 *-- ISO20022.Caaa027001.PointOfInteractionComponentCharacteristics10
    ISO20022.Caaa027001.PointOfInteractionComponent17 *-- ISO20022.Caaa027001.GenericIdentification48
    ISO20022.Caaa027001.PointOfInteractionComponent17 *-- ISO20022.Caaa027001.PointOfInteractionComponentStatus3
    ISO20022.Caaa027001.PointOfInteractionComponent17 *-- ISO20022.Caaa027001.PointOfInteractionComponentIdentification2
    class ISO20022.Caaa027001.PointOfInteractionComponentAssessment1 {
        + Nb  : String
        + XprtnDt  : DateTime
        + DlvryDt  : DateTime
        + Assgnr  : global::System.Collections.Generic.List~String~
        + Tp  : String
    }
    class ISO20022.Caaa027001.PointOfInteractionComponentCharacteristics10 {
        + SctyElmt  : global::System.Collections.Generic.List~ISO20022.Caaa027001.CryptographicKey18~
        + SbcbrIdntyMdls  : Decimal
        + SctyAccsMdls  : Decimal
        + Com  : global::System.Collections.Generic.List~ISO20022.Caaa027001.CommunicationCharacteristics5~
        + Mmry  : global::System.Collections.Generic.List~ISO20022.Caaa027001.MemoryCharacteristics1~
    }
    ISO20022.Caaa027001.PointOfInteractionComponentCharacteristics10 *-- ISO20022.Caaa027001.CryptographicKey18
    ISO20022.Caaa027001.PointOfInteractionComponentCharacteristics10 *-- ISO20022.Caaa027001.CommunicationCharacteristics5
    ISO20022.Caaa027001.PointOfInteractionComponentCharacteristics10 *-- ISO20022.Caaa027001.MemoryCharacteristics1
    class ISO20022.Caaa027001.PointOfInteractionComponentIdentification2 {
        + SrlNb  : String
        + Id  : String
        + PrvdrId  : String
        + ItmNb  : String
    }
    class ISO20022.Caaa027001.PointOfInteractionComponentStatus3 {
        + XpryDt  : DateTime
        + Sts  : String
        + VrsnNb  : String
    }
    class ISO20022.Caaa027001.PostalAddress22 {
        + CtryCd  : String
        + CtrySubDvsn  : global::System.Collections.Generic.List~String~
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + SubDept  : String
        + Dept  : String
        + AdrTp  : String
    }
    class ISO20022.Caaa027001.Recipient13Choice {
        + SbjtKeyIdr  : String
        + IssrAndSrlNb  : ISO20022.Caaa027001.IssuerAndSerialNumber2
    }
    ISO20022.Caaa027001.Recipient13Choice *-- ISO20022.Caaa027001.IssuerAndSerialNumber2
    class ISO20022.Caaa027001.Recipient15Choice {
        + KeyIdr  : ISO20022.Caaa027001.KEKIdentifier7
        + KEK  : ISO20022.Caaa027001.KEK9
        + KeyTrnsprt  : ISO20022.Caaa027001.KeyTransport10
    }
    ISO20022.Caaa027001.Recipient15Choice *-- ISO20022.Caaa027001.KEKIdentifier7
    ISO20022.Caaa027001.Recipient15Choice *-- ISO20022.Caaa027001.KEK9
    ISO20022.Caaa027001.Recipient15Choice *-- ISO20022.Caaa027001.KeyTransport10
    class ISO20022.Caaa027001.RelativeDistinguishedName1 {
        + AttrVal  : String
        + AttrTp  : String
    }
    class ISO20022.Caaa027001.Response11Code {
        SUCC = 1
        FAIL = 2
        WARN = 3
    }
    class ISO20022.Caaa027001.Response1Code {
        TECH = 1
        PART = 2
        APPR = 3
        DECL = 4
    }
    class ISO20022.Caaa027001.Response9Code {
        TECH = 1
        SUSP = 2
        PART = 3
        DECL = 4
        APPR = 5
    }
    class ISO20022.Caaa027001.ResponseType10 {
        + AddtlRspnInf  : String
        + RspnRsn  : String
        + Rspn  : String
    }
    class ISO20022.Caaa027001.ResponseType11 {
        + AddtlRspnInf  : String
        + RspnRsn  : String
        + Rspn  : String
    }
    class ISO20022.Caaa027001.RetailerResultDetail1Code {
        WIPG = 1
        ICAR = 2
        IVCA = 3
        LOUT = 4
        NALW = 5
        TNFD = 6
        PAYR = 7
        REFU = 8
        UNVD = 9
        UNVS = 10
        NHOS = 11
        WPIN = 12
        DEVO = 13
        CANC = 14
        BUSY = 15
        ABRT = 16
    }
    class ISO20022.Caaa027001.RetailerSaleEnvironment2 {
        + LltyHdlg  : String
        + DbtPrefrdFlg  : String
        + MinSpltAmt  : Decimal
        + MaxCshBckAmt  : Decimal
        + MinAmtToDlvr  : Decimal
        + Ccy  : String
        + SaleCpblties  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Caaa027001.SaleCapabilities1Code {
        PRVC = 1
        PRRP = 2
        PRDC = 3
        POIR = 4
        CUIN = 5
        CUER = 6
        CUAS = 7
        CUDI = 8
        CHST = 9
        CHIN = 10
        CHER = 11
        CHDI = 12
    }
    class ISO20022.Caaa027001.SensitiveMobileData1 {
        + IMEI  : String
        + IMSI  : String
        + MSISDN  : String
    }
    class ISO20022.Caaa027001.SignedData9 {
        + Sgnr  : global::System.Collections.Generic.List~ISO20022.Caaa027001.Signer8~
        + Cert  : global::System.Collections.Generic.List~String~
        + NcpsltdCntt  : ISO20022.Caaa027001.EncapsulatedContent3
        + DgstAlgo  : global::System.Collections.Generic.List~ISO20022.Caaa027001.AlgorithmIdentification36~
        + Vrsn  : Decimal
    }
    ISO20022.Caaa027001.SignedData9 *-- ISO20022.Caaa027001.Signer8
    ISO20022.Caaa027001.SignedData9 *-- ISO20022.Caaa027001.EncapsulatedContent3
    ISO20022.Caaa027001.SignedData9 *-- ISO20022.Caaa027001.AlgorithmIdentification36
    class ISO20022.Caaa027001.Signer8 {
        + Sgntr  : String
        + SgntrAlgo  : ISO20022.Caaa027001.AlgorithmIdentification33
        + SgndAttrbts  : global::System.Collections.Generic.List~ISO20022.Caaa027001.GenericInformation1~
        + DgstAlgo  : ISO20022.Caaa027001.AlgorithmIdentification36
        + SgnrId  : ISO20022.Caaa027001.Recipient13Choice
        + Vrsn  : Decimal
    }
    ISO20022.Caaa027001.Signer8 *-- ISO20022.Caaa027001.AlgorithmIdentification33
    ISO20022.Caaa027001.Signer8 *-- ISO20022.Caaa027001.GenericInformation1
    ISO20022.Caaa027001.Signer8 *-- ISO20022.Caaa027001.AlgorithmIdentification36
    ISO20022.Caaa027001.Signer8 *-- ISO20022.Caaa027001.Recipient13Choice
    class ISO20022.Caaa027001.StoredValueAccount2 {
        + Bal  : Decimal
        + Ccy  : String
        + NtryMd  : String
        + XpryDt  : String
        + OwnrNm  : String
        + Prvdr  : String
        + Brnd  : String
        + Id  : String
        + IdTp  : String
        + AcctTp  : String
    }
    class ISO20022.Caaa027001.StoredValueAccountType1Code {
        TRVL = 1
        CARD = 2
        PHON = 3
        OTHR = 4
        MERC = 5
        OLVC = 6
        MLVC = 7
        GCER = 8
        GIFT = 9
        ELMY = 10
        CPYA = 11
        CWVC = 12
        BNKA = 13
    }
    class ISO20022.Caaa027001.SupplementaryData1 {
        + Envlp  : ISO20022.Caaa027001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Caaa027001.SupplementaryData1 *-- ISO20022.Caaa027001.SupplementaryDataEnvelope1
    class ISO20022.Caaa027001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Caaa027001.TMSContactLevel1Code {
        DTIM = 1
        ASAP = 2
        CRIT = 3
    }
    class ISO20022.Caaa027001.TMSTrigger1 {
        + TMSCtctDtTm  : DateTime
        + TMSId  : String
        + TMSCtctLvl  : String
    }
    class ISO20022.Caaa027001.Token1 {
        + TknInittdInd  : String
        + TknAssrncMtd  : String
        + TknAssrncData  : String
        + TknRqstrId  : String
        + TknXpryDt  : String
        + PmtTkn  : String
    }
    class ISO20022.Caaa027001.TrackData2 {
        + TrckVal  : String
        + TrckFrmt  : String
        + TrckNb  : Decimal
    }
    class ISO20022.Caaa027001.TrackFormat1Code {
        JIS2 = 1
        JIS1 = 2
        ISOF = 3
        E13B = 4
        CMC7 = 5
        AAMV = 6
    }
    class ISO20022.Caaa027001.TransactionIdentifier1 {
        + TxRef  : String
        + TxDtTm  : DateTime
    }
    class ISO20022.Caaa027001.TransactionTotals12 {
        + CmltvAmt  : Decimal
        + TtlNb  : Decimal
        + Tp  : String
        + Ccy  : String
        + CardPdctPrfl  : String
        + CardBrnd  : String
        + POIGrpId  : String
    }
    class ISO20022.Caaa027001.TransactionVerificationResult4 {
        + AddtlRslt  : String
        + Rslt  : String
        + VrfctnNtty  : String
        + Mtd  : String
    }
    class ISO20022.Caaa027001.TypeTransactionTotals2Code {
        FAIL = 1
        DECL = 2
        DBTR = 3
        DEBT = 4
        CRDR = 5
        CRDT = 6
    }
    class ISO20022.Caaa027001.UserInterface4Code {
        CRDO = 1
        MRCP = 2
        MDSP = 3
        CRCP = 4
        CDSP = 5
    }
    class ISO20022.Caaa027001.Vehicle1 {
        + AddtlVhclData  : global::System.Collections.Generic.List~ISO20022.Caaa027001.Vehicle2~
        + DrvrOrVhclCard  : ISO20022.Caaa027001.PlainCardData17
        + MntncId  : String
        + RefrHrs  : String
        + TrlrHrs  : String
        + Hbmtr  : Decimal
        + Odmtr  : Decimal
        + RplcmntCar  : String
        + UnitNb  : String
        + VhclTagNtryMd  : String
        + VhclTag  : String
        + TrlrNb  : String
        + VhclNb  : String
    }
    ISO20022.Caaa027001.Vehicle1 *-- ISO20022.Caaa027001.Vehicle2
    ISO20022.Caaa027001.Vehicle1 *-- ISO20022.Caaa027001.PlainCardData17
    class ISO20022.Caaa027001.Vehicle2 {
        + Data  : String
        + NtryMd  : String
        + Tp  : String
    }
    class ISO20022.Caaa027001.Verification1Code {
        ERRR = 1
        SUCC = 2
        PART = 3
        NOVF = 4
        MISS = 5
        FAIL = 6
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

## Value ISO20022.Caaa027001.AcceptorCancellationAdviceResponse13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TMSTrggr|ISO20022.Caaa027001.TMSTrigger1||XmlElement()||
|+|Tx|ISO20022.Caaa027001.CardPaymentTransactionAdviceResponse8||XmlElement()||
|+|Envt|ISO20022.Caaa027001.CardPaymentEnvironment81||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TMSTrggr),validElement(Tx),validElement(Envt))|

---

## Value ISO20022.Caaa027001.AcceptorCompletionAdviceResponse13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Caaa027001.SupplementaryData1>||XmlElement()||
|+|TMSTrggr|ISO20022.Caaa027001.TMSTrigger1||XmlElement()||
|+|Tx|ISO20022.Caaa027001.CardPaymentTransactionAdviceResponse8||XmlElement()||
|+|Envt|ISO20022.Caaa027001.CardPaymentEnvironment81||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TMSTrggr),validElement(Tx),validElement(Envt))|

---

## Value ISO20022.Caaa027001.Acquirer10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ParamsVrsn|String||XmlElement()||
|+|Id|ISO20022.Caaa027001.GenericIdentification177||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Aspect ISO20022.Caaa027001.AcquirerToAcceptorBatchFileExchangeV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyTrlr|ISO20022.Caaa027001.ContentInformationType38||XmlElement()||
|+|Rspn|ISO20022.Caaa027001.ResponseType11||XmlElement()||
|+|BodyElmt|global::System.Collections.Generic.List<ISO20022.Caaa027001.AcquirerToAcceptorFileBody2>||XmlElement()||
|+|Hdr|ISO20022.Caaa027001.Header56||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(Rspn),validList("""BodyElmt""",BodyElmt),validElement(BodyElmt),validElement(Hdr))|

---

## Value ISO20022.Caaa027001.AcquirerToAcceptorFileBody2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BtchTrfRspn|ISO20022.Caaa027001.CardPaymentBatchTransferResponse12||XmlElement()||
|+|CxlRspn|ISO20022.Caaa027001.AcceptorCancellationAdviceResponse13||XmlElement()||
|+|CmpltnAdvcRspn|ISO20022.Caaa027001.AcceptorCompletionAdviceResponse13||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BtchTrfRspn),validElement(CxlRspn),validElement(CmpltnAdvcRspn))|

---

## Enum ISO20022.Caaa027001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Caaa027001.AddressVerification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlCdDgts|String||XmlElement()||
|+|AdrDgts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PstlCdDgts""",PstlCdDgts,"""[0-9]{1,5}"""),validPattern("""AdrDgts""",AdrDgts,"""[0-9]{1,5}"""))|

---

## Enum ISO20022.Caaa027001.Algorithm26Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SMS3|Int32||XmlEnum("""SMS3""")|1|
||SHK2|Int32||XmlEnum("""SHK2""")|2|
||SHK1|Int32||XmlEnum("""SHK1""")|3|
||SH35|Int32||XmlEnum("""SH35""")|4|
||SH33|Int32||XmlEnum("""SH33""")|5|
||SH32|Int32||XmlEnum("""SH32""")|6|
||SH31|Int32||XmlEnum("""SH31""")|7|
||HS01|Int32||XmlEnum("""HS01""")|8|
||HS51|Int32||XmlEnum("""HS51""")|9|
||HS38|Int32||XmlEnum("""HS38""")|10|
||HS25|Int32||XmlEnum("""HS25""")|11|

---

## Enum ISO20022.Caaa027001.Algorithm27Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||S34R|Int32||XmlEnum("""S34R""")|1|
||S34C|Int32||XmlEnum("""S34C""")|2|
||CCA3|Int32||XmlEnum("""CCA3""")|3|
||CCA2|Int32||XmlEnum("""CCA2""")|4|
||CCA1|Int32||XmlEnum("""CCA1""")|5|
||MCS3|Int32||XmlEnum("""MCS3""")|6|
||CM33|Int32||XmlEnum("""CM33""")|7|
||CM32|Int32||XmlEnum("""CM32""")|8|
||CM31|Int32||XmlEnum("""CM31""")|9|
||CMA2|Int32||XmlEnum("""CMA2""")|10|
||CMA5|Int32||XmlEnum("""CMA5""")|11|
||CMA9|Int32||XmlEnum("""CMA9""")|12|
||MCC1|Int32||XmlEnum("""MCC1""")|13|
||CMA1|Int32||XmlEnum("""CMA1""")|14|
||MCCS|Int32||XmlEnum("""MCCS""")|15|
||MACC|Int32||XmlEnum("""MACC""")|16|

---

## Enum ISO20022.Caaa027001.Algorithm28Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SM4R|Int32||XmlEnum("""SM4R""")|1|
||SM4C|Int32||XmlEnum("""SM4C""")|2|
||UKA3|Int32||XmlEnum("""UKA3""")|3|
||UKA1|Int32||XmlEnum("""UKA1""")|4|
||SD5C|Int32||XmlEnum("""SD5C""")|5|
||E36R|Int32||XmlEnum("""E36R""")|6|
||E36C|Int32||XmlEnum("""E36C""")|7|
||E3DR|Int32||XmlEnum("""E3DR""")|8|
||EA2R|Int32||XmlEnum("""EA2R""")|9|
||EA9R|Int32||XmlEnum("""EA9R""")|10|
||EA5R|Int32||XmlEnum("""EA5R""")|11|
||N108|Int32||XmlEnum("""N108""")|12|
||DA25|Int32||XmlEnum("""DA25""")|13|
||DA19|Int32||XmlEnum("""DA19""")|14|
||DA12|Int32||XmlEnum("""DA12""")|15|
||EA5C|Int32||XmlEnum("""EA5C""")|16|
||EA9C|Int32||XmlEnum("""EA9C""")|17|
||UKA2|Int32||XmlEnum("""UKA2""")|18|
||UKPT|Int32||XmlEnum("""UKPT""")|19|
||DKP9|Int32||XmlEnum("""DKP9""")|20|
||E3DC|Int32||XmlEnum("""E3DC""")|21|
||EA2C|Int32||XmlEnum("""EA2C""")|22|

---

## Enum ISO20022.Caaa027001.Algorithm29Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||S2S3|Int32||XmlEnum("""S2S3""")|1|
||SM25|Int32||XmlEnum("""SM25""")|2|
||SM23|Int32||XmlEnum("""SM23""")|3|
||SM35|Int32||XmlEnum("""SM35""")|4|
||SM32|Int32||XmlEnum("""SM32""")|5|
||SM33|Int32||XmlEnum("""SM33""")|6|
||SM22|Int32||XmlEnum("""SM22""")|7|
||DD25|Int32||XmlEnum("""DD25""")|8|
||DD23|Int32||XmlEnum("""DD23""")|9|
||DD35|Int32||XmlEnum("""DD35""")|10|
||DD33|Int32||XmlEnum("""DD33""")|11|
||DD32|Int32||XmlEnum("""DD32""")|12|
||DD22|Int32||XmlEnum("""DD22""")|13|
||EO25|Int32||XmlEnum("""EO25""")|14|
||EO23|Int32||XmlEnum("""EO23""")|15|
||EO35|Int32||XmlEnum("""EO35""")|16|
||EO22|Int32||XmlEnum("""EO22""")|17|
||EO32|Int32||XmlEnum("""EO32""")|18|
||EF25|Int32||XmlEnum("""EF25""")|19|
||EO33|Int32||XmlEnum("""EO33""")|20|
||EF23|Int32||XmlEnum("""EF23""")|21|
||EF35|Int32||XmlEnum("""EF35""")|22|
||EF33|Int32||XmlEnum("""EF33""")|23|
||EF22|Int32||XmlEnum("""EF22""")|24|
||EF32|Int32||XmlEnum("""EF32""")|25|
||ED22|Int32||XmlEnum("""ED22""")|26|
||ES25|Int32||XmlEnum("""ES25""")|27|
||ES23|Int32||XmlEnum("""ES23""")|28|
||ES35|Int32||XmlEnum("""ES35""")|29|
||ES33|Int32||XmlEnum("""ES33""")|30|
||ES32|Int32||XmlEnum("""ES32""")|31|
||ES22|Int32||XmlEnum("""ES22""")|32|
||ED25|Int32||XmlEnum("""ED25""")|33|
||ED23|Int32||XmlEnum("""ED23""")|34|
||ED35|Int32||XmlEnum("""ED35""")|35|
||ED33|Int32||XmlEnum("""ED33""")|36|
||ED32|Int32||XmlEnum("""ED32""")|37|
||ERS3|Int32||XmlEnum("""ERS3""")|38|
||RPSS|Int32||XmlEnum("""RPSS""")|39|
||ERS1|Int32||XmlEnum("""ERS1""")|40|
||ERS2|Int32||XmlEnum("""ERS2""")|41|

---

## Enum ISO20022.Caaa027001.Algorithm7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSAO|Int32||XmlEnum("""RSAO""")|1|
||ERSA|Int32||XmlEnum("""ERSA""")|2|

---

## Enum ISO20022.Caaa027001.Algorithm8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MGF1|Int32||XmlEnum("""MGF1""")|1|

---

## Value ISO20022.Caaa027001.AlgorithmIdentification31


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caaa027001.Parameter7||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Caaa027001.AlgorithmIdentification32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caaa027001.Parameter12||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Caaa027001.AlgorithmIdentification33


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caaa027001.Parameter16||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Caaa027001.AlgorithmIdentification34


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caaa027001.Parameter18||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Caaa027001.AlgorithmIdentification35


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caaa027001.Parameter17||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Caaa027001.AlgorithmIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caaa027001.AmountUnit1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||POIN|Int32||XmlEnum("""POIN""")|1|
||MONE|Int32||XmlEnum("""MONE""")|2|

---

## Enum ISO20022.Caaa027001.AttributeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CATT|Int32||XmlEnum("""CATT""")|1|
||OUAT|Int32||XmlEnum("""OUAT""")|2|
||OATT|Int32||XmlEnum("""OATT""")|3|
||LATT|Int32||XmlEnum("""LATT""")|4|
||CNAT|Int32||XmlEnum("""CNAT""")|5|

---

## Value ISO20022.Caaa027001.AuthenticatedData10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MAC|String||XmlElement()||
|+|NcpsltdCntt|ISO20022.Caaa027001.EncapsulatedContent3||XmlElement()||
|+|MACAlgo|ISO20022.Caaa027001.AlgorithmIdentification31||XmlElement()||
|+|Rcpt|global::System.Collections.Generic.List<ISO20022.Caaa027001.Recipient15Choice>||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcpsltdCntt),validElement(MACAlgo),validRequired("""Rcpt""",Rcpt),validList("""Rcpt""",Rcpt),validElement(Rcpt))|

---

## Enum ISO20022.Caaa027001.AuthenticationEntity2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRML|Int32||XmlEnum("""TRML""")|1|
||ISSR|Int32||XmlEnum("""ISSR""")|2|
||ACQR|Int32||XmlEnum("""ACQR""")|3|
||MERC|Int32||XmlEnum("""MERC""")|4|
||AGNT|Int32||XmlEnum("""AGNT""")|5|
||ICCD|Int32||XmlEnum("""ICCD""")|6|

---

## Enum ISO20022.Caaa027001.AuthenticationMethod6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TOKP|Int32||XmlEnum("""TOKP""")|1|
||FPIN|Int32||XmlEnum("""FPIN""")|2|
||MANU|Int32||XmlEnum("""MANU""")|3|
||ADDS|Int32||XmlEnum("""ADDS""")|4|
||CSEC|Int32||XmlEnum("""CSEC""")|5|
||PSVE|Int32||XmlEnum("""PSVE""")|6|
||CSCV|Int32||XmlEnum("""CSCV""")|7|
||CRYP|Int32||XmlEnum("""CRYP""")|8|
||CDHI|Int32||XmlEnum("""CDHI""")|9|
||BIOM|Int32||XmlEnum("""BIOM""")|10|
||ADDB|Int32||XmlEnum("""ADDB""")|11|
||CPSG|Int32||XmlEnum("""CPSG""")|12|
||SNCT|Int32||XmlEnum("""SNCT""")|13|
||SCNL|Int32||XmlEnum("""SCNL""")|14|
||SCRT|Int32||XmlEnum("""SCRT""")|15|
||PSWD|Int32||XmlEnum("""PSWD""")|16|
||PPSG|Int32||XmlEnum("""PPSG""")|17|
||NPIN|Int32||XmlEnum("""NPIN""")|18|

---

## Enum ISO20022.Caaa027001.AuthenticationMethod8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKNW|Int32||XmlEnum("""UKNW""")|1|
||TOKN|Int32||XmlEnum("""TOKN""")|2|
||CPSG|Int32||XmlEnum("""CPSG""")|3|
||ADDS|Int32||XmlEnum("""ADDS""")|4|
||SNCT|Int32||XmlEnum("""SNCT""")|5|
||CSEC|Int32||XmlEnum("""CSEC""")|6|
||SCNL|Int32||XmlEnum("""SCNL""")|7|
||SCRT|Int32||XmlEnum("""SCRT""")|8|
||TOKP|Int32||XmlEnum("""TOKP""")|9|
||PSWD|Int32||XmlEnum("""PSWD""")|10|
||PSVE|Int32||XmlEnum("""PSVE""")|11|
||PPSG|Int32||XmlEnum("""PPSG""")|12|
||OTHR|Int32||XmlEnum("""OTHR""")|13|
||NPIN|Int32||XmlEnum("""NPIN""")|14|
||FPIN|Int32||XmlEnum("""FPIN""")|15|
||MOBL|Int32||XmlEnum("""MOBL""")|16|
||MERC|Int32||XmlEnum("""MERC""")|17|
||MANU|Int32||XmlEnum("""MANU""")|18|
||CSCV|Int32||XmlEnum("""CSCV""")|19|
||CRYP|Int32||XmlEnum("""CRYP""")|20|
||CDHI|Int32||XmlEnum("""CDHI""")|21|
||BIOM|Int32||XmlEnum("""BIOM""")|22|
||BYPS|Int32||XmlEnum("""BYPS""")|23|
||ADDB|Int32||XmlEnum("""ADDB""")|24|
||TOKA|Int32||XmlEnum("""TOKA""")|25|

---

## Enum ISO20022.Caaa027001.AuthenticationResult1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UCRP|Int32||XmlEnum("""UCRP""")|1|
||CRPT|Int32||XmlEnum("""CRPT""")|2|
||AUTH|Int32||XmlEnum("""AUTH""")|3|
||CARD|Int32||XmlEnum("""CARD""")|4|
||MRCH|Int32||XmlEnum("""MRCH""")|5|
||DENY|Int32||XmlEnum("""DENY""")|6|

---

## Enum ISO20022.Caaa027001.BytePadding1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RAND|Int32||XmlEnum("""RAND""")|1|
||NULL|Int32||XmlEnum("""NULL""")|2|
||NULG|Int32||XmlEnum("""NULG""")|3|
||NUL8|Int32||XmlEnum("""NUL8""")|4|
||LNGT|Int32||XmlEnum("""LNGT""")|5|

---

## Enum ISO20022.Caaa027001.CardDataReading5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CDFL|Int32||XmlEnum("""CDFL""")|1|
||ECTL|Int32||XmlEnum("""ECTL""")|2|
||CTLS|Int32||XmlEnum("""CTLS""")|3|
||DFLE|Int32||XmlEnum("""DFLE""")|4|
||CICC|Int32||XmlEnum("""CICC""")|5|
||MGST|Int32||XmlEnum("""MGST""")|6|
||BRCD|Int32||XmlEnum("""BRCD""")|7|
||PHYS|Int32||XmlEnum("""PHYS""")|8|
||TAGC|Int32||XmlEnum("""TAGC""")|9|

---

## Enum ISO20022.Caaa027001.CardDataReading8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPTC|Int32||XmlEnum("""OPTC""")|1|
||QRCD|Int32||XmlEnum("""QRCD""")|2|
||UNKW|Int32||XmlEnum("""UNKW""")|3|
||SICC|Int32||XmlEnum("""SICC""")|4|
||CDFL|Int32||XmlEnum("""CDFL""")|5|
||ECTL|Int32||XmlEnum("""ECTL""")|6|
||CTLS|Int32||XmlEnum("""CTLS""")|7|
||DFLE|Int32||XmlEnum("""DFLE""")|8|
||CICC|Int32||XmlEnum("""CICC""")|9|
||MGST|Int32||XmlEnum("""MGST""")|10|
||BRCD|Int32||XmlEnum("""BRCD""")|11|
||PHYS|Int32||XmlEnum("""PHYS""")|12|
||TAGC|Int32||XmlEnum("""TAGC""")|13|

---

## Enum ISO20022.Caaa027001.CardIdentificationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UUID|Int32||XmlEnum("""UUID""")|1|
||PRIV|Int32||XmlEnum("""PRIV""")|2|
||CPAN|Int32||XmlEnum("""CPAN""")|3|
||PHON|Int32||XmlEnum("""PHON""")|4|
||ISO2|Int32||XmlEnum("""ISO2""")|5|
||BARC|Int32||XmlEnum("""BARC""")|6|
||ACCT|Int32||XmlEnum("""ACCT""")|7|

---

## Value ISO20022.Caaa027001.CardPaymentBatchTransferResponse12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DataSet|global::System.Collections.Generic.List<ISO20022.Caaa027001.CardPaymentDataSet39>||XmlElement()||
|+|TxTtls|global::System.Collections.Generic.List<ISO20022.Caaa027001.TransactionTotals12>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""DataSet""",DataSet),validElement(DataSet),validList("""TxTtls""",TxTtls),validElement(TxTtls))|

---

## Value ISO20022.Caaa027001.CardPaymentDataSet38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tx|ISO20022.Caaa027001.CardPaymentTransactionAdviceResponse5||XmlElement()||
|+|Envt|ISO20022.Caaa027001.CardPaymentEnvironment81||XmlElement()||
|+|TxRspn|ISO20022.Caaa027001.ResponseType10||XmlElement()||
|+|TxSeqCntr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tx),validElement(Envt),validElement(TxRspn),validPattern("""TxSeqCntr""",TxSeqCntr,"""[0-9]{1,9}"""))|

---

## Value ISO20022.Caaa027001.CardPaymentDataSet39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsmdRjctn|global::System.Collections.Generic.List<ISO20022.Caaa027001.CardPaymentDataSet38>||XmlElement()||
|+|RsmdApprvl|global::System.Collections.Generic.List<ISO20022.Caaa027001.CardPaymentDataSet38>||XmlElement()||
|+|SspdTx|global::System.Collections.Generic.List<ISO20022.Caaa027001.CardPaymentDataSet38>||XmlElement()||
|+|RjctdTx|global::System.Collections.Generic.List<ISO20022.Caaa027001.CardPaymentDataSet38>||XmlElement()||
|+|TxTtls|global::System.Collections.Generic.List<ISO20022.Caaa027001.TransactionTotals12>||XmlElement()||
|+|DataSetInitr|ISO20022.Caaa027001.GenericIdentification176||XmlElement()||
|+|RmvDataSet|String||XmlElement()||
|+|DataSetRslt|ISO20022.Caaa027001.ResponseType10||XmlElement()||
|+|DataSetId|ISO20022.Caaa027001.DataSetIdentification5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""RsmdRjctn""",RsmdRjctn),validElement(RsmdRjctn),validList("""RsmdApprvl""",RsmdApprvl),validElement(RsmdApprvl),validList("""SspdTx""",SspdTx),validElement(SspdTx),validList("""RjctdTx""",RjctdTx),validElement(RjctdTx),validRequired("""TxTtls""",TxTtls),validList("""TxTtls""",TxTtls),validElement(TxTtls),validElement(DataSetInitr),validElement(DataSetRslt),validElement(DataSetId))|

---

## Value ISO20022.Caaa027001.CardPaymentEnvironment81


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SaleEnvt|ISO20022.Caaa027001.RetailerSaleEnvironment2||XmlElement()||
|+|PrtctdCrdhldrData|ISO20022.Caaa027001.ContentInformationType40||XmlElement()||
|+|Crdhldr|ISO20022.Caaa027001.Cardholder21||XmlElement()||
|+|MrchntTkn|ISO20022.Caaa027001.MerchantToken2||XmlElement()||
|+|PmtTkn|ISO20022.Caaa027001.Token1||XmlElement()||
|+|Wllt|ISO20022.Caaa027001.CustomerDevice3||XmlElement()||
|+|CstmrDvc|ISO20022.Caaa027001.CustomerDevice3||XmlElement()||
|+|LltyAcct|global::System.Collections.Generic.List<ISO20022.Caaa027001.LoyaltyAccount3>||XmlElement()||
|+|StordValAcct|global::System.Collections.Generic.List<ISO20022.Caaa027001.StoredValueAccount2>||XmlElement()||
|+|Chck|ISO20022.Caaa027001.Check1||XmlElement()||
|+|Card|ISO20022.Caaa027001.PaymentCard35||XmlElement()||
|+|POI|ISO20022.Caaa027001.PointOfInteraction15||XmlElement()||
|+|Mrchnt|ISO20022.Caaa027001.Organisation41||XmlElement()||
|+|SvcPrvdr|ISO20022.Caaa027001.Acquirer10||XmlElement()||
|+|Acqrr|ISO20022.Caaa027001.Acquirer10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SaleEnvt),validElement(PrtctdCrdhldrData),validElement(Crdhldr),validElement(MrchntTkn),validElement(PmtTkn),validElement(Wllt),validElement(CstmrDvc),validList("""LltyAcct""",LltyAcct),validElement(LltyAcct),validList("""StordValAcct""",StordValAcct),validElement(StordValAcct),validElement(Chck),validElement(Card),validElement(POI),validElement(Mrchnt),validElement(SvcPrvdr),validElement(Acqrr))|

---

## Value ISO20022.Caaa027001.CardPaymentTransactionAdviceResponse5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rspn|String||XmlElement()||
|+|TxId|ISO20022.Caaa027001.TransactionIdentifier1||XmlElement()||
|+|SaleRefId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TxId))|

---

## Value ISO20022.Caaa027001.CardPaymentTransactionAdviceResponse8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rspn|String||XmlElement()||
|+|RcncltnId|String||XmlElement()||
|+|RcptTxId|String||XmlElement()||
|+|InitrTxId|String||XmlElement()||
|+|TxId|ISO20022.Caaa027001.TransactionIdentifier1||XmlElement()||
|+|SaleRefId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TxId))|

---

## Enum ISO20022.Caaa027001.CardProductType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CONS|Int32||XmlEnum("""CONS""")|1|
||COMM|Int32||XmlEnum("""COMM""")|2|

---

## Value ISO20022.Caaa027001.Cardholder21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MobData|global::System.Collections.Generic.List<ISO20022.Caaa027001.MobileData6>||XmlElement()||
|+|PrsnlData|String||XmlElement()||
|+|TxVrfctnRslt|global::System.Collections.Generic.List<ISO20022.Caaa027001.TransactionVerificationResult4>||XmlElement()||
|+|Authntcn|global::System.Collections.Generic.List<ISO20022.Caaa027001.CardholderAuthentication17>||XmlElement()||
|+|Vhcl|ISO20022.Caaa027001.Vehicle1||XmlElement()||
|+|TripNb|String||XmlElement()||
|+|ShppgAdr|ISO20022.Caaa027001.PostalAddress22||XmlElement()||
|+|BllgAdr|ISO20022.Caaa027001.PostalAddress22||XmlElement()||
|+|Lang|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Caaa027001.PersonIdentification15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""MobData""",MobData),validElement(MobData),validList("""TxVrfctnRslt""",TxVrfctnRslt),validElement(TxVrfctnRslt),validList("""Authntcn""",Authntcn),validElement(Authntcn),validElement(Vhcl),validElement(ShppgAdr),validElement(BllgAdr),validElement(Id))|

---

## Value ISO20022.Caaa027001.CardholderAuthentication17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AuthntcnAddtlInf|ISO20022.Caaa027001.ExternallyDefinedData5||XmlElement()||
|+|AuthntcnRslt|String||XmlElement()||
|+|AuthntcnLvl|String||XmlElement()||
|+|AuthntcnTp|String||XmlElement()||
|+|AdrVrfctn|ISO20022.Caaa027001.AddressVerification1||XmlElement()||
|+|CrdhldrId|ISO20022.Caaa027001.PersonIdentification15||XmlElement()||
|+|CrdhldrOnLinePIN|ISO20022.Caaa027001.OnLinePIN11||XmlElement()||
|+|PrtctdAuthntcnVal|ISO20022.Caaa027001.ContentInformationType40||XmlElement()||
|+|AuthntcnVal|String||XmlElement()||
|+|AuthntcnXmptn|String||XmlElement()||
|+|AuthntcnMtd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AuthntcnAddtlInf),validElement(AdrVrfctn),validElement(CrdhldrId),validElement(CrdhldrOnLinePIN),validElement(PrtctdAuthntcnVal))|

---

## Enum ISO20022.Caaa027001.CardholderVerificationCapability4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||NOVF|Int32||XmlEnum("""NOVF""")|2|
||NBIO|Int32||XmlEnum("""NBIO""")|3|
||SCEC|Int32||XmlEnum("""SCEC""")|4|
||PKIS|Int32||XmlEnum("""PKIS""")|5|
||NPIN|Int32||XmlEnum("""NPIN""")|6|
||FEPN|Int32||XmlEnum("""FEPN""")|7|
||FCPN|Int32||XmlEnum("""FCPN""")|8|
||FDSG|Int32||XmlEnum("""FDSG""")|9|
||FBIO|Int32||XmlEnum("""FBIO""")|10|
||FBIG|Int32||XmlEnum("""FBIG""")|11|
||MNVR|Int32||XmlEnum("""MNVR""")|12|
||MNSG|Int32||XmlEnum("""MNSG""")|13|
||CHDT|Int32||XmlEnum("""CHDT""")|14|
||APKI|Int32||XmlEnum("""APKI""")|15|

---

## Value ISO20022.Caaa027001.CertificateIssuer1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltvDstngshdNm|global::System.Collections.Generic.List<ISO20022.Caaa027001.RelativeDistinguishedName1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""RltvDstngshdNm""",RltvDstngshdNm),validList("""RltvDstngshdNm""",RltvDstngshdNm),validElement(RltvDstngshdNm))|

---

## Value ISO20022.Caaa027001.Check1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|ChckTp|String||XmlElement()||
|+|ChckTrckData2|ISO20022.Caaa027001.TrackData2||XmlElement()||
|+|ChckCardNb|String||XmlElement()||
|+|ChckNb|String||XmlElement()||
|+|AcctNb|String||XmlElement()||
|+|BkId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ChckTrckData2))|

---

## Enum ISO20022.Caaa027001.CheckType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PERS|Int32||XmlEnum("""PERS""")|1|
||PAYR|Int32||XmlEnum("""PAYR""")|2|
||GOVC|Int32||XmlEnum("""GOVC""")|3|
||BUSI|Int32||XmlEnum("""BUSI""")|4|
||BANK|Int32||XmlEnum("""BANK""")|5|

---

## Value ISO20022.Caaa027001.CommunicationAddress9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlCtctInf|String||XmlElement()||
|+|CstmrSvc|String||XmlElement()||
|+|Phne|String||XmlElement()||
|+|URLAdr|String||XmlElement()||
|+|Email|String||XmlElement()||
|+|PstlAdr|ISO20022.Caaa027001.PostalAddress22||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CstmrSvc""",CstmrSvc,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""Phne""",Phne,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validElement(PstlAdr))|

---

## Value ISO20022.Caaa027001.CommunicationCharacteristics5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PhysIntrfc|ISO20022.Caaa027001.PhysicalInterfaceParameter1||XmlElement()||
|+|Params|ISO20022.Caaa027001.NetworkParameters7||XmlElement()||
|+|Actv|String||XmlElement()||
|+|RmotPty|global::System.Collections.Generic.List<String>||XmlElement()||
|+|ComTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PhysIntrfc),validElement(Params),validRequired("""RmotPty""",RmotPty))|

---

## Value ISO20022.Caaa027001.ContentInformationType38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SgndData|ISO20022.Caaa027001.SignedData9||XmlElement()||
|+|AuthntcdData|ISO20022.Caaa027001.AuthenticatedData10||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SgndData),validElement(AuthntcdData))|

---

## Value ISO20022.Caaa027001.ContentInformationType39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgstdData|ISO20022.Caaa027001.DigestedData6||XmlElement()||
|+|SgndData|ISO20022.Caaa027001.SignedData9||XmlElement()||
|+|AuthntcdData|ISO20022.Caaa027001.AuthenticatedData10||XmlElement()||
|+|EnvlpdData|ISO20022.Caaa027001.EnvelopedData11||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgstdData),validElement(SgndData),validElement(AuthntcdData),validElement(EnvlpdData))|

---

## Value ISO20022.Caaa027001.ContentInformationType40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EnvlpdData|ISO20022.Caaa027001.EnvelopedData11||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EnvlpdData))|

---

## Enum ISO20022.Caaa027001.ContentType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AUTH|Int32||XmlEnum("""AUTH""")|1|
||DGST|Int32||XmlEnum("""DGST""")|2|
||EVLP|Int32||XmlEnum("""EVLP""")|3|
||SIGN|Int32||XmlEnum("""SIGN""")|4|
||DATA|Int32||XmlEnum("""DATA""")|5|

---

## Value ISO20022.Caaa027001.CryptographicKey18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlMgmtInf|global::System.Collections.Generic.List<ISO20022.Caaa027001.GenericInformation1>||XmlElement()||
|+|KeyChckVal|String||XmlElement()||
|+|PrtctdCmpntWthAuthrsdAccs|global::System.Collections.Generic.List<ISO20022.Caaa027001.ContentInformationType39>||XmlElement()||
|+|CmpntWthAuthrsdAccs|global::System.Collections.Generic.List<ISO20022.Caaa027001.GenericIdentification186>||XmlElement()||
|+|KeyVal|ISO20022.Caaa027001.ContentInformationType39||XmlElement()||
|+|DeactvtnDt|DateTime||XmlElement()||
|+|ActvtnDt|DateTime||XmlElement()||
|+|Fctn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|ItmNb|String||XmlElement()||
|+|SctyPrfl|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|AddtlId|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlMgmtInf""",AddtlMgmtInf),validElement(AddtlMgmtInf),validList("""PrtctdCmpntWthAuthrsdAccs""",PrtctdCmpntWthAuthrsdAccs),validElement(PrtctdCmpntWthAuthrsdAccs),validList("""CmpntWthAuthrsdAccs""",CmpntWthAuthrsdAccs),validElement(CmpntWthAuthrsdAccs),validElement(KeyVal))|

---

## Enum ISO20022.Caaa027001.CryptographicKeyType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EDE4|Int32||XmlEnum("""EDE4""")|1|
||AES5|Int32||XmlEnum("""AES5""")|2|
||AES9|Int32||XmlEnum("""AES9""")|3|
||DKP9|Int32||XmlEnum("""DKP9""")|4|
||EDE3|Int32||XmlEnum("""EDE3""")|5|
||AES2|Int32||XmlEnum("""AES2""")|6|

---

## Value ISO20022.Caaa027001.CustomerDevice3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prvdr|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caaa027001.DataSetCategory8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RCLE|Int32||XmlEnum("""RCLE""")|1|
||MGTP|Int32||XmlEnum("""MGTP""")|2|
||DLGT|Int32||XmlEnum("""DLGT""")|3|
||STRP|Int32||XmlEnum("""STRP""")|4|
||AKCP|Int32||XmlEnum("""AKCP""")|5|
||TXCP|Int32||XmlEnum("""TXCP""")|6|
||MRPR|Int32||XmlEnum("""MRPR""")|7|
||AQPR|Int32||XmlEnum("""AQPR""")|8|
||VDPR|Int32||XmlEnum("""VDPR""")|9|
||SWPK|Int32||XmlEnum("""SWPK""")|10|

---

## Value ISO20022.Caaa027001.DataSetIdentification5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa027001.DateAndPlaceOfBirth1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Caaa027001.DigestedData6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dgst|String||XmlElement()||
|+|NcpsltdCntt|ISO20022.Caaa027001.EncapsulatedContent3||XmlElement()||
|+|DgstAlgo|ISO20022.Caaa027001.AlgorithmIdentification36||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcpsltdCntt),validElement(DgstAlgo))|

---

## Value ISO20022.Caaa027001.DisplayCapabilities4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AvlblLang|global::System.Collections.Generic.List<String>||XmlElement()||
|+|LineWidth|Decimal||XmlElement()||
|+|NbOfLines|Decimal||XmlElement()||
|+|AvlblFrmt|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Dstn|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Dstn""",Dstn))|

---

## Type ISO20022.Caaa027001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcqrrToAccptrBtchFileXchg|ISO20022.Caaa027001.AcquirerToAcceptorBatchFileExchangeV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcqrrToAccptrBtchFileXchg))|

---

## Value ISO20022.Caaa027001.EncapsulatedContent3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cntt|String||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa027001.EncryptedContent7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdData|String||XmlElement()||
|+|CnttNcrptnAlgo|ISO20022.Caaa027001.AlgorithmIdentification32||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CnttNcrptnAlgo))|

---

## Enum ISO20022.Caaa027001.EncryptionFormat2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||I238|Int32||XmlEnum("""I238""")|1|
||TR34|Int32||XmlEnum("""TR34""")|2|
||TR31|Int32||XmlEnum("""TR31""")|3|

---

## Value ISO20022.Caaa027001.EnvelopedData11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdCntt|ISO20022.Caaa027001.EncryptedContent7||XmlElement()||
|+|Rcpt|global::System.Collections.Generic.List<ISO20022.Caaa027001.Recipient15Choice>||XmlElement()||
|+|OrgtrInf|ISO20022.Caaa027001.OriginatorInformation1||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcrptdCntt),validRequired("""Rcpt""",Rcpt),validList("""Rcpt""",Rcpt),validElement(Rcpt),validElement(OrgtrInf))|

---

## Enum ISO20022.Caaa027001.Exemption1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TMBE|Int32||XmlEnum("""TMBE""")|1|
||PKGE|Int32||XmlEnum("""PKGE""")|2|
||TRAE|Int32||XmlEnum("""TRAE""")|3|
||SCAD|Int32||XmlEnum("""SCAD""")|4|
||SCPE|Int32||XmlEnum("""SCPE""")|5|
||RECP|Int32||XmlEnum("""RECP""")|6|
||MINT|Int32||XmlEnum("""MINT""")|7|
||LOWA|Int32||XmlEnum("""LOWA""")|8|

---

## Value ISO20022.Caaa027001.ExternallyDefinedData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|String||XmlElement()||
|+|PrtctdVal|ISO20022.Caaa027001.ContentInformationType39||XmlElement()||
|+|Val|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtctdVal))|

---

## Value ISO20022.Caaa027001.GenericIdentification176


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[a-zA-Z]{2,3}"""))|

---

## Value ISO20022.Caaa027001.GenericIdentification177


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Glctn|ISO20022.Caaa027001.Geolocation1||XmlElement()||
|+|RmotAccs|ISO20022.Caaa027001.NetworkParameters7||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Glctn),validElement(RmotAccs),validPattern("""Ctry""",Ctry,"""[a-zA-Z]{2,3}"""))|

---

## Value ISO20022.Caaa027001.GenericIdentification186


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa027001.GenericIdentification32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ShrtNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa027001.GenericIdentification4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdTp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa027001.GenericIdentification48


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa027001.GenericInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa027001.Geolocation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UTMCordints|ISO20022.Caaa027001.GeolocationUTMCoordinates1||XmlElement()||
|+|GeogcCordints|ISO20022.Caaa027001.GeolocationGeographicCoordinates1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UTMCordints),validElement(GeogcCordints))|

---

## Value ISO20022.Caaa027001.GeolocationGeographicCoordinates1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Long|String||XmlElement()||
|+|Lat|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa027001.GeolocationUTMCoordinates1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UTMNrthwrd|String||XmlElement()||
|+|UTMEstwrd|String||XmlElement()||
|+|UTMZone|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa027001.Header56


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RcptPty|ISO20022.Caaa027001.GenericIdentification177||XmlElement()||
|+|InitgPty|ISO20022.Caaa027001.GenericIdentification176||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|XchgId|Decimal||XmlElement()||
|+|FrmtVrsn|String||XmlElement()||
|+|DwnldTrf|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RcptPty),validElement(InitgPty))|

---

## Value ISO20022.Caaa027001.IssuerAndSerialNumber2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrlNb|String||XmlElement()||
|+|Issr|ISO20022.Caaa027001.CertificateIssuer1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Issr))|

---

## Value ISO20022.Caaa027001.KEK9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Caaa027001.AlgorithmIdentification32||XmlElement()||
|+|KEKId|ISO20022.Caaa027001.KEKIdentifier7||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(KEKId))|

---

## Value ISO20022.Caaa027001.KEKIdentifier7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivtnId|String||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|KeyVrsn|String||XmlElement()||
|+|KeyId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa027001.KeyTransport10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Caaa027001.AlgorithmIdentification35||XmlElement()||
|+|RcptId|ISO20022.Caaa027001.Recipient13Choice||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(RcptId))|

---

## Enum ISO20022.Caaa027001.KeyUsage1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||KEYD|Int32||XmlEnum("""KEYD""")|1|
||KEYX|Int32||XmlEnum("""KEYX""")|2|
||KEYI|Int32||XmlEnum("""KEYI""")|3|
||KEYG|Int32||XmlEnum("""KEYG""")|4|
||PINV|Int32||XmlEnum("""PINV""")|5|
||PIND|Int32||XmlEnum("""PIND""")|6|
||PINE|Int32||XmlEnum("""PINE""")|7|
||SUGV|Int32||XmlEnum("""SUGV""")|8|
||SIGG|Int32||XmlEnum("""SIGG""")|9|
||MACV|Int32||XmlEnum("""MACV""")|10|
||MACG|Int32||XmlEnum("""MACG""")|11|
||TRNX|Int32||XmlEnum("""TRNX""")|12|
||TRNI|Int32||XmlEnum("""TRNI""")|13|
||DDEC|Int32||XmlEnum("""DDEC""")|14|
||DENC|Int32||XmlEnum("""DENC""")|15|
||DCPT|Int32||XmlEnum("""DCPT""")|16|
||ENCR|Int32||XmlEnum("""ENCR""")|17|

---

## Enum ISO20022.Caaa027001.LocationCategory3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VNDG|Int32||XmlEnum("""VNDG""")|1|
||SSLE|Int32||XmlEnum("""SSLE""")|2|
||MSLE|Int32||XmlEnum("""MSLE""")|3|
||MPMP|Int32||XmlEnum("""MPMP""")|4|
||MPOI|Int32||XmlEnum("""MPOI""")|5|
||IPMP|Int32||XmlEnum("""IPMP""")|6|
||INDR|Int32||XmlEnum("""INDR""")|7|

---

## Enum ISO20022.Caaa027001.LocationCategory4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VIRT|Int32||XmlEnum("""VIRT""")|1|
||FIXD|Int32||XmlEnum("""FIXD""")|2|
||NMDC|Int32||XmlEnum("""NMDC""")|3|
||ABRD|Int32||XmlEnum("""ABRD""")|4|

---

## Value ISO20022.Caaa027001.LoyaltyAccount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bal|Decimal||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Unit|String||XmlElement()||
|+|OwnrNm|String||XmlElement()||
|+|Prvdr|String||XmlElement()||
|+|Brnd|String||XmlElement()||
|+|IdTp|String||XmlElement()||
|+|NtryMd|String||XmlElement()||
|+|LltyId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Caaa027001.LoyaltyHandling1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REQU|Int32||XmlEnum("""REQU""")|1|
||PROP|Int32||XmlEnum("""PROP""")|2|
||PRCS|Int32||XmlEnum("""PRCS""")|3|
||DENY|Int32||XmlEnum("""DENY""")|4|
||ALLO|Int32||XmlEnum("""ALLO""")|5|

---

## Value ISO20022.Caaa027001.MemoryCharacteristics1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Unit|String||XmlElement()||
|+|FreeSz|Decimal||XmlElement()||
|+|TtlSz|Decimal||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caaa027001.MemoryUnit1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TERA|Int32||XmlEnum("""TERA""")|1|
||PETA|Int32||XmlEnum("""PETA""")|2|
||MEGA|Int32||XmlEnum("""MEGA""")|3|
||KILO|Int32||XmlEnum("""KILO""")|4|
||GIGA|Int32||XmlEnum("""GIGA""")|5|
||EXAB|Int32||XmlEnum("""EXAB""")|6|
||BYTE|Int32||XmlEnum("""BYTE""")|7|

---

## Value ISO20022.Caaa027001.MerchantToken2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TknInittdInd|String||XmlElement()||
|+|TknAssrncMtd|String||XmlElement()||
|+|TknAssrncData|String||XmlElement()||
|+|TknAssrncLvl|Decimal||XmlElement()||
|+|TknRqstr|ISO20022.Caaa027001.PaymentTokenIdentifiers1||XmlElement()||
|+|TknChrtc|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TknXpryDt|String||XmlElement()||
|+|Tkn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""TknAssrncMtd""",TknAssrncMtd,"""[0-9]{1,2}"""),validElement(TknRqstr))|

---

## Value ISO20022.Caaa027001.MobileData6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtctdMobData|ISO20022.Caaa027001.ContentInformationType40||XmlElement()||
|+|SnstvMobData|ISO20022.Caaa027001.SensitiveMobileData1||XmlElement()||
|+|Glctn|ISO20022.Caaa027001.Geolocation1||XmlElement()||
|+|MobMskdMSISDN|String||XmlElement()||
|+|MobNtwkCd|String||XmlElement()||
|+|MobCtryCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtctdMobData),validElement(SnstvMobData),validElement(Glctn),validPattern("""MobNtwkCd""",MobNtwkCd,"""[0-9]{2,3}"""),validPattern("""MobCtryCd""",MobCtryCd,"""[a-zA-Z]{2,3}"""))|

---

## Value ISO20022.Caaa027001.NetworkParameters7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyPrfl|String||XmlElement()||
|+|ClntCert|global::System.Collections.Generic.List<String>||XmlElement()||
|+|SvrCertIdr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|SvrCert|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AccsCd|String||XmlElement()||
|+|UsrNm|String||XmlElement()||
|+|Adr|global::System.Collections.Generic.List<ISO20022.Caaa027001.NetworkParameters9>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Adr""",Adr),validList("""Adr""",Adr),validElement(Adr))|

---

## Value ISO20022.Caaa027001.NetworkParameters9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AdrVal|String||XmlElement()||
|+|NtwkTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caaa027001.NetworkType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PSTN|Int32||XmlEnum("""PSTN""")|1|
||IPNW|Int32||XmlEnum("""IPNW""")|2|

---

## Enum ISO20022.Caaa027001.OnLineCapability1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SMON|Int32||XmlEnum("""SMON""")|1|
||ONLN|Int32||XmlEnum("""ONLN""")|2|
||OFLN|Int32||XmlEnum("""OFLN""")|3|

---

## Value ISO20022.Caaa027001.OnLinePIN11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInpt|String||XmlElement()||
|+|PINFrmt|String||XmlElement()||
|+|NcrptdPINBlck|ISO20022.Caaa027001.ContentInformationType40||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcrptdPINBlck))|

---

## Value ISO20022.Caaa027001.Organisation41


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeData|String||XmlElement()||
|+|LctnAndCtct|ISO20022.Caaa027001.CommunicationAddress9||XmlElement()||
|+|LctnCtgy|String||XmlElement()||
|+|CmonNm|String||XmlElement()||
|+|Id|ISO20022.Caaa027001.GenericIdentification32||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LctnAndCtct),validElement(Id))|

---

## Value ISO20022.Caaa027001.OriginatorInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cert|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caaa027001.OutputFormat1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HTML|Int32||XmlEnum("""HTML""")|1|
||TEXT|Int32||XmlEnum("""TEXT""")|2|
||MREF|Int32||XmlEnum("""MREF""")|3|

---

## Enum ISO20022.Caaa027001.PINFormat3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ISO5|Int32||XmlEnum("""ISO5""")|1|
||ISO4|Int32||XmlEnum("""ISO4""")|2|
||ISO3|Int32||XmlEnum("""ISO3""")|3|
||ISO2|Int32||XmlEnum("""ISO2""")|4|
||ISO1|Int32||XmlEnum("""ISO1""")|5|
||ISO0|Int32||XmlEnum("""ISO0""")|6|

---

## Enum ISO20022.Caaa027001.POICommunicationType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WT5G|Int32||XmlEnum("""WT5G""")|1|
||WT4G|Int32||XmlEnum("""WT4G""")|2|
||WT3G|Int32||XmlEnum("""WT3G""")|3|
||WT2G|Int32||XmlEnum("""WT2G""")|4|
||WIFI|Int32||XmlEnum("""WIFI""")|5|
||USBH|Int32||XmlEnum("""USBH""")|6|
||USBD|Int32||XmlEnum("""USBD""")|7|
||RS23|Int32||XmlEnum("""RS23""")|8|
||PSTN|Int32||XmlEnum("""PSTN""")|9|
||GSMF|Int32||XmlEnum("""GSMF""")|10|
||GPRS|Int32||XmlEnum("""GPRS""")|11|
||ETHR|Int32||XmlEnum("""ETHR""")|12|
||BLTH|Int32||XmlEnum("""BLTH""")|13|

---

## Enum ISO20022.Caaa027001.POIComponentAssessment1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EVAL|Int32||XmlEnum("""EVAL""")|1|
||CERT|Int32||XmlEnum("""CERT""")|2|
||APPL|Int32||XmlEnum("""APPL""")|3|

---

## Enum ISO20022.Caaa027001.POIComponentStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DACT|Int32||XmlEnum("""DACT""")|1|
||OPER|Int32||XmlEnum("""OPER""")|2|
||OUTD|Int32||XmlEnum("""OUTD""")|3|
||WAIT|Int32||XmlEnum("""WAIT""")|4|

---

## Enum ISO20022.Caaa027001.POIComponentType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PROB|Int32||XmlEnum("""PROB""")|1|
||RPFL|Int32||XmlEnum("""RPFL""")|2|
||CONF|Int32||XmlEnum("""CONF""")|3|
||SOFT|Int32||XmlEnum("""SOFT""")|4|
||MDFL|Int32||XmlEnum("""MDFL""")|5|
||LOGF|Int32||XmlEnum("""LOGF""")|6|
||SAPR|Int32||XmlEnum("""SAPR""")|7|
||SACP|Int32||XmlEnum("""SACP""")|8|
||TMSP|Int32||XmlEnum("""TMSP""")|9|
||CRTF|Int32||XmlEnum("""CRTF""")|10|
||MRPR|Int32||XmlEnum("""MRPR""")|11|
||OPST|Int32||XmlEnum("""OPST""")|12|
||DRVR|Int32||XmlEnum("""DRVR""")|13|
||MDWR|Int32||XmlEnum("""MDWR""")|14|
||EMVO|Int32||XmlEnum("""EMVO""")|15|
||EMVK|Int32||XmlEnum("""EMVK""")|16|
||APLI|Int32||XmlEnum("""APLI""")|17|
||SECM|Int32||XmlEnum("""SECM""")|18|
||DVCE|Int32||XmlEnum("""DVCE""")|19|
||TERM|Int32||XmlEnum("""TERM""")|20|
||SERV|Int32||XmlEnum("""SERV""")|21|
||SCPR|Int32||XmlEnum("""SCPR""")|22|
||TLPR|Int32||XmlEnum("""TLPR""")|23|
||APPR|Int32||XmlEnum("""APPR""")|24|
||AQPP|Int32||XmlEnum("""AQPP""")|25|

---

## Value ISO20022.Caaa027001.PackageType5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PackgBlck|global::System.Collections.Generic.List<ISO20022.Caaa027001.ExternallyDefinedData5>||XmlElement()||
|+|OffsetEnd|Decimal||XmlElement()||
|+|OffsetStart|Decimal||XmlElement()||
|+|PackgLngth|Decimal||XmlElement()||
|+|PackgId|ISO20022.Caaa027001.GenericIdentification176||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PackgBlck""",PackgBlck),validElement(PackgBlck),validElement(PackgId))|

---

## Value ISO20022.Caaa027001.Parameter12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
|+|NcrptnFrmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa027001.Parameter16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OIDCrvNm|String||XmlElement()||
|+|TrlrFld|Decimal||XmlElement()||
|+|SaltLngth|Decimal||XmlElement()||
|+|MskGnrtrAlgo|ISO20022.Caaa027001.AlgorithmIdentification34||XmlElement()||
|+|DgstAlgo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MskGnrtrAlgo))|

---

## Value ISO20022.Caaa027001.Parameter17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MskGnrtrAlgo|ISO20022.Caaa027001.AlgorithmIdentification34||XmlElement()||
|+|DgstAlgo|String||XmlElement()||
|+|NcrptnFrmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MskGnrtrAlgo))|

---

## Value ISO20022.Caaa027001.Parameter18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgstAlgo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa027001.Parameter7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caaa027001.PartyType33Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TMGT|Int32||XmlEnum("""TMGT""")|1|
||TAXH|Int32||XmlEnum("""TAXH""")|2|
||MTMG|Int32||XmlEnum("""MTMG""")|3|
||DLIS|Int32||XmlEnum("""DLIS""")|4|
||CISS|Int32||XmlEnum("""CISS""")|5|
||ACQR|Int32||XmlEnum("""ACQR""")|6|
||ITAG|Int32||XmlEnum("""ITAG""")|7|
||ACCP|Int32||XmlEnum("""ACCP""")|8|
||MERC|Int32||XmlEnum("""MERC""")|9|
||OPOI|Int32||XmlEnum("""OPOI""")|10|

---

## Enum ISO20022.Caaa027001.PartyType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLIS|Int32||XmlEnum("""DLIS""")|1|
||CISS|Int32||XmlEnum("""CISS""")|2|
||ACQR|Int32||XmlEnum("""ACQR""")|3|
||ITAG|Int32||XmlEnum("""ITAG""")|4|
||ACCP|Int32||XmlEnum("""ACCP""")|5|
||MERC|Int32||XmlEnum("""MERC""")|6|
||OPOI|Int32||XmlEnum("""OPOI""")|7|

---

## Enum ISO20022.Caaa027001.PartyType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TAXH|Int32||XmlEnum("""TAXH""")|1|
||CISS|Int32||XmlEnum("""CISS""")|2|
||ACQR|Int32||XmlEnum("""ACQR""")|3|
||ITAG|Int32||XmlEnum("""ITAG""")|4|
||ACCP|Int32||XmlEnum("""ACCP""")|5|
||MERC|Int32||XmlEnum("""MERC""")|6|

---

## Enum ISO20022.Caaa027001.PartyType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SALE|Int32||XmlEnum("""SALE""")|1|
||TMGT|Int32||XmlEnum("""TMGT""")|2|
||PCPT|Int32||XmlEnum("""PCPT""")|3|
||ITAG|Int32||XmlEnum("""ITAG""")|4|
||ACQR|Int32||XmlEnum("""ACQR""")|5|

---

## Value ISO20022.Caaa027001.PaymentCard35


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlCardData|String||XmlElement()||
|+|SvcOptn|String||XmlElement()||
|+|AllwdPdct|global::System.Collections.Generic.List<String>||XmlElement()||
|+|IntrnlCard|String||XmlElement()||
|+|CardPdctSubTp|String||XmlElement()||
|+|CardPdctTp|String||XmlElement()||
|+|CardBrnd|String||XmlElement()||
|+|CardPdctPrfl|String||XmlElement()||
|+|CardCcyCd|String||XmlElement()||
|+|CardCtryCd|String||XmlElement()||
|+|IssrBIN|String||XmlElement()||
|+|MskdPAN|String||XmlElement()||
|+|PmtAcctRef|String||XmlElement()||
|+|PlainCardData|ISO20022.Caaa027001.PlainCardData22||XmlElement()||
|+|PrvtCardData|String||XmlElement()||
|+|PrtctdCardData|ISO20022.Caaa027001.ContentInformationType40||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CardCcyCd""",CardCcyCd,"""[a-zA-Z0-9]{3}"""),validPattern("""IssrBIN""",IssrBIN,"""[0-9]{1,15}"""),validElement(PlainCardData),validElement(PrtctdCardData))|

---

## Value ISO20022.Caaa027001.PaymentTokenIdentifiers1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RqstrId|String||XmlElement()||
|+|PrvdrId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa027001.PersonIdentification15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Caaa027001.GenericIdentification4>||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Caaa027001.DateAndPlaceOfBirth1||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|Dept|String||XmlElement()||
|+|JobNb|String||XmlElement()||
|+|MplyeeIdNb|String||XmlElement()||
|+|MplyrIdNb|String||XmlElement()||
|+|IdntyCardNb|String||XmlElement()||
|+|TaxIdNb|String||XmlElement()||
|+|PsptNb|String||XmlElement()||
|+|AlnRegnNb|String||XmlElement()||
|+|SclSctyNb|String||XmlElement()||
|+|CstmrNb|String||XmlElement()||
|+|DrvrId|String||XmlElement()||
|+|DrvrLicNm|String||XmlElement()||
|+|DrvrLicLctn|String||XmlElement()||
|+|DrvrLicNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(DtAndPlcOfBirth))|

---

## Value ISO20022.Caaa027001.PhysicalInterfaceParameter1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlParams|String||XmlElement()||
|+|SctyPrfl|String||XmlElement()||
|+|AccsCd|String||XmlElement()||
|+|UsrNm|String||XmlElement()||
|+|IntrfcTp|String||XmlElement()||
|+|IntrfcNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa027001.PlainCardData17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NtryMd|String||XmlElement()||
|+|AddtlCardData|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Trck3|String||XmlElement()||
|+|Trck2|String||XmlElement()||
|+|Trck1|String||XmlElement()||
|+|PAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PAN""",PAN,"""[0-9]{8,28}"""))|

---

## Value ISO20022.Caaa027001.PlainCardData22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CrdhldrNm|String||XmlElement()||
|+|Trck3|String||XmlElement()||
|+|Trck2|String||XmlElement()||
|+|Trck1|String||XmlElement()||
|+|SvcCd|String||XmlElement()||
|+|XpryDt|String||XmlElement()||
|+|FctvDt|String||XmlElement()||
|+|CardSeqNb|String||XmlElement()||
|+|PAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SvcCd""",SvcCd,"""[0-9]{3}"""),validPattern("""CardSeqNb""",CardSeqNb,"""[0-9]{2,3}"""),validPattern("""PAN""",PAN,"""[0-9]{8,28}"""))|

---

## Value ISO20022.Caaa027001.PointOfInteraction15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cmpnt|global::System.Collections.Generic.List<ISO20022.Caaa027001.PointOfInteractionComponent17>||XmlElement()||
|+|TermnlIntgtn|String||XmlElement()||
|+|TmZone|String||XmlElement()||
|+|Cpblties|ISO20022.Caaa027001.PointOfInteractionCapabilities9||XmlElement()||
|+|GrpId|String||XmlElement()||
|+|SysNm|String||XmlElement()||
|+|Id|ISO20022.Caaa027001.GenericIdentification177||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Cmpnt""",Cmpnt),validElement(Cmpnt),validElement(Cpblties),validElement(Id))|

---

## Value ISO20022.Caaa027001.PointOfInteractionCapabilities9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgCpblties|global::System.Collections.Generic.List<ISO20022.Caaa027001.DisplayCapabilities4>||XmlElement()||
|+|OnLineCpblties|String||XmlElement()||
|+|CardCaptrCpbl|String||XmlElement()||
|+|MxScrptLngth|Decimal||XmlElement()||
|+|ApprvlCdLngth|Decimal||XmlElement()||
|+|PINLngthCpblties|Decimal||XmlElement()||
|+|CrdhldrVrfctnCpblties|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CardRdngCpblties|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""MsgCpblties""",MsgCpblties),validElement(MsgCpblties))|

---

## Value ISO20022.Caaa027001.PointOfInteractionComponent17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrbVal|String||XmlElement()||
|+|Packg|global::System.Collections.Generic.List<ISO20022.Caaa027001.PackageType5>||XmlElement()||
|+|Assmnt|global::System.Collections.Generic.List<ISO20022.Caaa027001.PointOfInteractionComponentAssessment1>||XmlElement()||
|+|Chrtcs|ISO20022.Caaa027001.PointOfInteractionComponentCharacteristics10||XmlElement()||
|+|StdCmplc|global::System.Collections.Generic.List<ISO20022.Caaa027001.GenericIdentification48>||XmlElement()||
|+|Sts|ISO20022.Caaa027001.PointOfInteractionComponentStatus3||XmlElement()||
|+|Id|ISO20022.Caaa027001.PointOfInteractionComponentIdentification2||XmlElement()||
|+|SubTpInf|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Packg""",Packg),validElement(Packg),validList("""Assmnt""",Assmnt),validElement(Assmnt),validElement(Chrtcs),validList("""StdCmplc""",StdCmplc),validElement(StdCmplc),validElement(Sts),validElement(Id))|

---

## Value ISO20022.Caaa027001.PointOfInteractionComponentAssessment1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nb|String||XmlElement()||
|+|XprtnDt|DateTime||XmlElement()||
|+|DlvryDt|DateTime||XmlElement()||
|+|Assgnr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Assgnr""",Assgnr))|

---

## Value ISO20022.Caaa027001.PointOfInteractionComponentCharacteristics10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyElmt|global::System.Collections.Generic.List<ISO20022.Caaa027001.CryptographicKey18>||XmlElement()||
|+|SbcbrIdntyMdls|Decimal||XmlElement()||
|+|SctyAccsMdls|Decimal||XmlElement()||
|+|Com|global::System.Collections.Generic.List<ISO20022.Caaa027001.CommunicationCharacteristics5>||XmlElement()||
|+|Mmry|global::System.Collections.Generic.List<ISO20022.Caaa027001.MemoryCharacteristics1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SctyElmt""",SctyElmt),validElement(SctyElmt),validList("""Com""",Com),validElement(Com),validList("""Mmry""",Mmry),validElement(Mmry))|

---

## Value ISO20022.Caaa027001.PointOfInteractionComponentIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrlNb|String||XmlElement()||
|+|Id|String||XmlElement()||
|+|PrvdrId|String||XmlElement()||
|+|ItmNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa027001.PointOfInteractionComponentStatus3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XpryDt|DateTime||XmlElement()||
|+|Sts|String||XmlElement()||
|+|VrsnNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa027001.PostalAddress22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryCd|String||XmlElement()||
|+|CtrySubDvsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
|+|SubDept|String||XmlElement()||
|+|Dept|String||XmlElement()||
|+|AdrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryCd""",CtryCd,"""[a-zA-Z]{2,3}"""),validListMax("""CtrySubDvsn""",CtrySubDvsn,2),validListMax("""AdrLine""",AdrLine,2))|

---

## Value ISO20022.Caaa027001.Recipient13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SbjtKeyIdr|String||XmlElement()||
|+|IssrAndSrlNb|ISO20022.Caaa027001.IssuerAndSerialNumber2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IssrAndSrlNb),validChoice(SbjtKeyIdr,IssrAndSrlNb))|

---

## Value ISO20022.Caaa027001.Recipient15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeyIdr|ISO20022.Caaa027001.KEKIdentifier7||XmlElement()||
|+|KEK|ISO20022.Caaa027001.KEK9||XmlElement()||
|+|KeyTrnsprt|ISO20022.Caaa027001.KeyTransport10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyIdr),validElement(KEK),validElement(KeyTrnsprt),validChoice(KeyIdr,KEK,KeyTrnsprt))|

---

## Value ISO20022.Caaa027001.RelativeDistinguishedName1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AttrVal|String||XmlElement()||
|+|AttrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caaa027001.Response11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SUCC|Int32||XmlEnum("""SUCC""")|1|
||FAIL|Int32||XmlEnum("""FAIL""")|2|
||WARN|Int32||XmlEnum("""WARN""")|3|

---

## Enum ISO20022.Caaa027001.Response1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TECH|Int32||XmlEnum("""TECH""")|1|
||PART|Int32||XmlEnum("""PART""")|2|
||APPR|Int32||XmlEnum("""APPR""")|3|
||DECL|Int32||XmlEnum("""DECL""")|4|

---

## Enum ISO20022.Caaa027001.Response9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TECH|Int32||XmlEnum("""TECH""")|1|
||SUSP|Int32||XmlEnum("""SUSP""")|2|
||PART|Int32||XmlEnum("""PART""")|3|
||DECL|Int32||XmlEnum("""DECL""")|4|
||APPR|Int32||XmlEnum("""APPR""")|5|

---

## Value ISO20022.Caaa027001.ResponseType10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRspnInf|String||XmlElement()||
|+|RspnRsn|String||XmlElement()||
|+|Rspn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa027001.ResponseType11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRspnInf|String||XmlElement()||
|+|RspnRsn|String||XmlElement()||
|+|Rspn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caaa027001.RetailerResultDetail1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WIPG|Int32||XmlEnum("""WIPG""")|1|
||ICAR|Int32||XmlEnum("""ICAR""")|2|
||IVCA|Int32||XmlEnum("""IVCA""")|3|
||LOUT|Int32||XmlEnum("""LOUT""")|4|
||NALW|Int32||XmlEnum("""NALW""")|5|
||TNFD|Int32||XmlEnum("""TNFD""")|6|
||PAYR|Int32||XmlEnum("""PAYR""")|7|
||REFU|Int32||XmlEnum("""REFU""")|8|
||UNVD|Int32||XmlEnum("""UNVD""")|9|
||UNVS|Int32||XmlEnum("""UNVS""")|10|
||NHOS|Int32||XmlEnum("""NHOS""")|11|
||WPIN|Int32||XmlEnum("""WPIN""")|12|
||DEVO|Int32||XmlEnum("""DEVO""")|13|
||CANC|Int32||XmlEnum("""CANC""")|14|
||BUSY|Int32||XmlEnum("""BUSY""")|15|
||ABRT|Int32||XmlEnum("""ABRT""")|16|

---

## Value ISO20022.Caaa027001.RetailerSaleEnvironment2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LltyHdlg|String||XmlElement()||
|+|DbtPrefrdFlg|String||XmlElement()||
|+|MinSpltAmt|Decimal||XmlElement()||
|+|MaxCshBckAmt|Decimal||XmlElement()||
|+|MinAmtToDlvr|Decimal||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|SaleCpblties|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Caaa027001.SaleCapabilities1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRVC|Int32||XmlEnum("""PRVC""")|1|
||PRRP|Int32||XmlEnum("""PRRP""")|2|
||PRDC|Int32||XmlEnum("""PRDC""")|3|
||POIR|Int32||XmlEnum("""POIR""")|4|
||CUIN|Int32||XmlEnum("""CUIN""")|5|
||CUER|Int32||XmlEnum("""CUER""")|6|
||CUAS|Int32||XmlEnum("""CUAS""")|7|
||CUDI|Int32||XmlEnum("""CUDI""")|8|
||CHST|Int32||XmlEnum("""CHST""")|9|
||CHIN|Int32||XmlEnum("""CHIN""")|10|
||CHER|Int32||XmlEnum("""CHER""")|11|
||CHDI|Int32||XmlEnum("""CHDI""")|12|

---

## Value ISO20022.Caaa027001.SensitiveMobileData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IMEI|String||XmlElement()||
|+|IMSI|String||XmlElement()||
|+|MSISDN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""IMEI""",IMEI,"""[0-9]{1,35}"""),validPattern("""IMSI""",IMSI,"""[0-9]{1,35}"""),validPattern("""MSISDN""",MSISDN,"""[0-9]{1,35}"""))|

---

## Value ISO20022.Caaa027001.SignedData9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgnr|global::System.Collections.Generic.List<ISO20022.Caaa027001.Signer8>||XmlElement()||
|+|Cert|global::System.Collections.Generic.List<String>||XmlElement()||
|+|NcpsltdCntt|ISO20022.Caaa027001.EncapsulatedContent3||XmlElement()||
|+|DgstAlgo|global::System.Collections.Generic.List<ISO20022.Caaa027001.AlgorithmIdentification36>||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Sgnr""",Sgnr),validElement(Sgnr),validElement(NcpsltdCntt),validList("""DgstAlgo""",DgstAlgo),validElement(DgstAlgo))|

---

## Value ISO20022.Caaa027001.Signer8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgntr|String||XmlElement()||
|+|SgntrAlgo|ISO20022.Caaa027001.AlgorithmIdentification33||XmlElement()||
|+|SgndAttrbts|global::System.Collections.Generic.List<ISO20022.Caaa027001.GenericInformation1>||XmlElement()||
|+|DgstAlgo|ISO20022.Caaa027001.AlgorithmIdentification36||XmlElement()||
|+|SgnrId|ISO20022.Caaa027001.Recipient13Choice||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SgntrAlgo),validList("""SgndAttrbts""",SgndAttrbts),validElement(SgndAttrbts),validElement(DgstAlgo),validElement(SgnrId))|

---

## Value ISO20022.Caaa027001.StoredValueAccount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bal|Decimal||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|NtryMd|String||XmlElement()||
|+|XpryDt|String||XmlElement()||
|+|OwnrNm|String||XmlElement()||
|+|Prvdr|String||XmlElement()||
|+|Brnd|String||XmlElement()||
|+|Id|String||XmlElement()||
|+|IdTp|String||XmlElement()||
|+|AcctTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Caaa027001.StoredValueAccountType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRVL|Int32||XmlEnum("""TRVL""")|1|
||CARD|Int32||XmlEnum("""CARD""")|2|
||PHON|Int32||XmlEnum("""PHON""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||MERC|Int32||XmlEnum("""MERC""")|5|
||OLVC|Int32||XmlEnum("""OLVC""")|6|
||MLVC|Int32||XmlEnum("""MLVC""")|7|
||GCER|Int32||XmlEnum("""GCER""")|8|
||GIFT|Int32||XmlEnum("""GIFT""")|9|
||ELMY|Int32||XmlEnum("""ELMY""")|10|
||CPYA|Int32||XmlEnum("""CPYA""")|11|
||CWVC|Int32||XmlEnum("""CWVC""")|12|
||BNKA|Int32||XmlEnum("""BNKA""")|13|

---

## Value ISO20022.Caaa027001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Caaa027001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Caaa027001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caaa027001.TMSContactLevel1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DTIM|Int32||XmlEnum("""DTIM""")|1|
||ASAP|Int32||XmlEnum("""ASAP""")|2|
||CRIT|Int32||XmlEnum("""CRIT""")|3|

---

## Value ISO20022.Caaa027001.TMSTrigger1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TMSCtctDtTm|DateTime||XmlElement()||
|+|TMSId|String||XmlElement()||
|+|TMSCtctLvl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa027001.Token1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TknInittdInd|String||XmlElement()||
|+|TknAssrncMtd|String||XmlElement()||
|+|TknAssrncData|String||XmlElement()||
|+|TknRqstrId|String||XmlElement()||
|+|TknXpryDt|String||XmlElement()||
|+|PmtTkn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""TknAssrncMtd""",TknAssrncMtd,"""[0-9]{1,2}"""),validPattern("""TknRqstrId""",TknRqstrId,"""[0-9]{1,11}"""),validPattern("""TknXpryDt""",TknXpryDt,"""[0-9]{4}"""),validPattern("""PmtTkn""",PmtTkn,"""[0-9]{1,19}"""))|

---

## Value ISO20022.Caaa027001.TrackData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrckVal|String||XmlElement()||
|+|TrckFrmt|String||XmlElement()||
|+|TrckNb|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caaa027001.TrackFormat1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||JIS2|Int32||XmlEnum("""JIS2""")|1|
||JIS1|Int32||XmlEnum("""JIS1""")|2|
||ISOF|Int32||XmlEnum("""ISOF""")|3|
||E13B|Int32||XmlEnum("""E13B""")|4|
||CMC7|Int32||XmlEnum("""CMC7""")|5|
||AAMV|Int32||XmlEnum("""AAMV""")|6|

---

## Value ISO20022.Caaa027001.TransactionIdentifier1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxRef|String||XmlElement()||
|+|TxDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa027001.TransactionTotals12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CmltvAmt|Decimal||XmlElement()||
|+|TtlNb|Decimal||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|CardPdctPrfl|String||XmlElement()||
|+|CardBrnd|String||XmlElement()||
|+|POIGrpId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Caaa027001.TransactionVerificationResult4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRslt|String||XmlElement()||
|+|Rslt|String||XmlElement()||
|+|VrfctnNtty|String||XmlElement()||
|+|Mtd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caaa027001.TypeTransactionTotals2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FAIL|Int32||XmlEnum("""FAIL""")|1|
||DECL|Int32||XmlEnum("""DECL""")|2|
||DBTR|Int32||XmlEnum("""DBTR""")|3|
||DEBT|Int32||XmlEnum("""DEBT""")|4|
||CRDR|Int32||XmlEnum("""CRDR""")|5|
||CRDT|Int32||XmlEnum("""CRDT""")|6|

---

## Enum ISO20022.Caaa027001.UserInterface4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CRDO|Int32||XmlEnum("""CRDO""")|1|
||MRCP|Int32||XmlEnum("""MRCP""")|2|
||MDSP|Int32||XmlEnum("""MDSP""")|3|
||CRCP|Int32||XmlEnum("""CRCP""")|4|
||CDSP|Int32||XmlEnum("""CDSP""")|5|

---

## Value ISO20022.Caaa027001.Vehicle1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlVhclData|global::System.Collections.Generic.List<ISO20022.Caaa027001.Vehicle2>||XmlElement()||
|+|DrvrOrVhclCard|ISO20022.Caaa027001.PlainCardData17||XmlElement()||
|+|MntncId|String||XmlElement()||
|+|RefrHrs|String||XmlElement()||
|+|TrlrHrs|String||XmlElement()||
|+|Hbmtr|Decimal||XmlElement()||
|+|Odmtr|Decimal||XmlElement()||
|+|RplcmntCar|String||XmlElement()||
|+|UnitNb|String||XmlElement()||
|+|VhclTagNtryMd|String||XmlElement()||
|+|VhclTag|String||XmlElement()||
|+|TrlrNb|String||XmlElement()||
|+|VhclNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlVhclData""",AddtlVhclData),validElement(AddtlVhclData),validElement(DrvrOrVhclCard),validPattern("""UnitNb""",UnitNb,"""[0-9]{1,35}"""),validPattern("""TrlrNb""",TrlrNb,"""[0-9]{1,35}"""),validPattern("""VhclNb""",VhclNb,"""[0-9]{1,35}"""))|

---

## Value ISO20022.Caaa027001.Vehicle2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Data|String||XmlElement()||
|+|NtryMd|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caaa027001.Verification1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ERRR|Int32||XmlEnum("""ERRR""")|1|
||SUCC|Int32||XmlEnum("""SUCC""")|2|
||PART|Int32||XmlEnum("""PART""")|3|
||NOVF|Int32||XmlEnum("""NOVF""")|4|
||MISS|Int32||XmlEnum("""MISS""")|5|
||FAIL|Int32||XmlEnum("""FAIL""")|6|

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

