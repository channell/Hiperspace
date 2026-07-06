# cafr.001.001.03
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Cafr001001.AdditionalData1 {
        + Val  : String
        + Tp  : String
    }
    class ISO20022.Cafr001001.AdditionalData2 {
        + Dtls  : global::System.Collections.Generic.List~ISO20022.Cafr001001.AdditionalData1~
        + Tp  : String
    }
    ISO20022.Cafr001001.AdditionalData2 *-- ISO20022.Cafr001001.AdditionalData1
    class ISO20022.Cafr001001.AdditionalFee3 {
        + Desc  : String
        + OthrAssgnr  : String
        + Assgnr  : String
        + RcncltnFctvXchgRate  : Decimal
        + RcncltnCcy  : String
        + RcncltnAmt  : Decimal
        + Ccy  : String
        + Amt  : Decimal
        + CdtDbt  : String
        + Dscrptr  : String
        + Prgm  : String
        + OthrTp  : String
        + Tp  : String
    }
    class ISO20022.Cafr001001.AdditionalInformation22 {
        + Val  : String
        + Tp  : String
        + Frmt  : String
        + Trgt  : global::System.Collections.Generic.List~String~
        + Rcpt  : String
    }
    class ISO20022.Cafr001001.Address2 {
        + Ctry  : String
        + CtrySubDvsnMnrNm  : String
        + CtrySubDvsnMjrNm  : String
        + CtrySubDvsnMjr  : String
        + CtrySubDvsnMnr  : String
        + TwnNm  : String
        + PstlCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine2  : String
        + AdrLine1  : String
    }
    class ISO20022.Cafr001001.Algorithm13Code {
        EA5C = 1
        EA9C = 2
        UKA1 = 3
        UKPT = 4
        DKP9 = 5
        E3DC = 6
        EA2C = 7
    }
    class ISO20022.Cafr001001.Algorithm20Code {
        HS51 = 1
        HS38 = 2
        HS25 = 3
    }
    class ISO20022.Cafr001001.Algorithm23Code {
        SD5C = 1
        E36R = 2
        E36C = 3
        E3DR = 4
        EA5R = 5
        EA9R = 6
        EA2R = 7
        EA5C = 8
        EA9C = 9
        E3DC = 10
        EA2C = 11
    }
    class ISO20022.Cafr001001.Algorithm5Code {
        HS51 = 1
        HS38 = 2
        HS25 = 3
    }
    class ISO20022.Cafr001001.Algorithm7Code {
        RSAO = 1
        ERSA = 2
    }
    class ISO20022.Cafr001001.Algorithm8Code {
        MGF1 = 1
    }
    class ISO20022.Cafr001001.AlgorithmIdentification25 {
        + Param  : ISO20022.Cafr001001.Parameter7
        + Algo  : String
    }
    ISO20022.Cafr001001.AlgorithmIdentification25 *-- ISO20022.Cafr001001.Parameter7
    class ISO20022.Cafr001001.AlgorithmIdentification26 {
        + Param  : String
        + Algo  : String
    }
    class ISO20022.Cafr001001.AlgorithmIdentification27 {
        + Param  : ISO20022.Cafr001001.Parameter13
        + Algo  : String
    }
    ISO20022.Cafr001001.AlgorithmIdentification27 *-- ISO20022.Cafr001001.Parameter13
    class ISO20022.Cafr001001.AlgorithmIdentification28 {
        + Param  : ISO20022.Cafr001001.Parameter14
        + Algo  : String
    }
    ISO20022.Cafr001001.AlgorithmIdentification28 *-- ISO20022.Cafr001001.Parameter14
    class ISO20022.Cafr001001.AttributeType1Code {
        CATT = 1
        OUAT = 2
        OATT = 3
        LATT = 4
        CNAT = 5
    }
    class ISO20022.Cafr001001.AuthenticationMethod12Code {
        CHSN = 1
        ACSN = 2
        NTID = 3
        FPIN = 4
        MOBL = 5
        BIOM = 6
        CRYP = 7
        CSCV = 8
        ADDS = 9
        ADDB = 10
        THDS = 11
        PWOR = 12
        PHOM = 13
        QWAC = 14
        TOKN = 15
        CDHI = 16
        TOKA = 17
        TXIN = 18
        SSNB = 19
        CPSG = 20
        SHAT = 21
        SHAF = 22
        CSEC = 23
        SCNL = 24
        SCRT = 25
        PCDV = 26
        PLOB = 27
        PKIS = 28
        TOKP = 29
        PSWD = 30
        PASN = 31
        PSVE = 32
        PPSG = 33
        OTHP = 34
        OTHN = 35
        OCHI = 36
        NPIN = 37
        NBIG = 38
        OTPW = 39
        FCPN = 40
        OFPE = 41
        OLDS = 42
        OLDA = 43
        FBIO = 44
        FBIG = 45
        NVSC = 46
        MANU = 47
        IDCN = 48
        EMRN = 49
        EMIN = 50
        EMAL = 51
        DRLN = 52
        DRVI = 53
        CUID = 54
        CHDN = 55
        CHSA = 56
        BTHD = 57
        ATCC = 58
        ARQC = 59
        ARPC = 60
        ARNB = 61
        ADVF = 62
        APKI = 63
    }
    class ISO20022.Cafr001001.Authority1 {
        + Nm  : String
        + CtrySubDvsnMnrNm  : String
        + CtrySubDvsnMjrNm  : String
        + CtrySubDvsnMnr  : String
        + CtrySubDvsnMjr  : String
        + Ctry  : String
    }
    class ISO20022.Cafr001001.BatchManagementInformation1 {
        + MsgChcksmInptVal  : String
        + MsgSeqNb  : String
        + BtchId  : String
        + ColltnId  : String
    }
    class ISO20022.Cafr001001.BytePadding1Code {
        RAND = 1
        NULL = 2
        NULG = 3
        NUL8 = 4
        LNGT = 5
    }
    class ISO20022.Cafr001001.CardData15 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cafr001001.AdditionalData1~
        + PrtflIdr  : String
        + PdctSubTp  : String
        + PdctTp  : String
        + Ctry  : String
        + PANAcctRg  : String
        + PANRefIdr  : String
        + PmtAcctRef  : String
        + XpryDt  : String
        + FctvDt  : String
        + CardSeqNb  : String
        + PrtctdPAN  : String
        + PAN  : String
    }
    ISO20022.Cafr001001.CardData15 *-- ISO20022.Cafr001001.AdditionalData1
    class ISO20022.Cafr001001.CardNotReceivedDetails3 {
        + CardSctyCpblty  : global::System.Collections.Generic.List~ISO20022.Cafr001001.CardSecurityCapability1~
        + CardSctyCd  : String
        + VldFr  : DateTime
        + MldFrPstlCd  : String
        + MlngAdrUstrd  : String
        + MlngAdr  : ISO20022.Cafr001001.Address2
        + DtMld  : DateTime
    }
    ISO20022.Cafr001001.CardNotReceivedDetails3 *-- ISO20022.Cafr001001.CardSecurityCapability1
    ISO20022.Cafr001001.CardNotReceivedDetails3 *-- ISO20022.Cafr001001.Address2
    class ISO20022.Cafr001001.CardSecurityCapability1 {
        + OthrCpblty  : String
        + Cpblty  : String
    }
    class ISO20022.Cafr001001.CardSecurityCapability1Code {
        OLPN = 1
        OTHP = 2
        OTHN = 3
        MSWS = 4
        MWOS = 5
        ICCD = 6
    }
    class ISO20022.Cafr001001.Cardholder22 {
        + LclData  : ISO20022.Cafr001001.LocalData13
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cafr001001.AdditionalData1~
        + HghVal  : String
        + DtOfBirth  : DateTime
        + CtctInf  : ISO20022.Cafr001001.ContactPersonal1
        + Adr  : ISO20022.Cafr001001.Address2
        + Id  : global::System.Collections.Generic.List~ISO20022.Cafr001001.Credentials3~
        + Nm  : ISO20022.Cafr001001.CardholderName3
    }
    ISO20022.Cafr001001.Cardholder22 *-- ISO20022.Cafr001001.LocalData13
    ISO20022.Cafr001001.Cardholder22 *-- ISO20022.Cafr001001.AdditionalData1
    ISO20022.Cafr001001.Cardholder22 *-- ISO20022.Cafr001001.ContactPersonal1
    ISO20022.Cafr001001.Cardholder22 *-- ISO20022.Cafr001001.Address2
    ISO20022.Cafr001001.Cardholder22 *-- ISO20022.Cafr001001.Credentials3
    ISO20022.Cafr001001.Cardholder22 *-- ISO20022.Cafr001001.CardholderName3
    class ISO20022.Cafr001001.CardholderName2 {
        + LastNm  : String
        + MddlNm  : String
        + GvnNm  : String
        + Nm  : String
    }
    class ISO20022.Cafr001001.CardholderName3 {
        + LastNm  : String
        + MddlNm  : String
        + GvnNm  : String
        + Nm  : String
    }
    class ISO20022.Cafr001001.CertificateIssuer1 {
        + RltvDstngshdNm  : global::System.Collections.Generic.List~ISO20022.Cafr001001.RelativeDistinguishedName1~
    }
    ISO20022.Cafr001001.CertificateIssuer1 *-- ISO20022.Cafr001001.RelativeDistinguishedName1
    class ISO20022.Cafr001001.ContactPersonal1 {
        + Lang  : String
        + URL  : String
        + BizFax  : String
        + HomeFax  : String
        + OthrEmail  : String
        + BizEmail  : String
        + PrsnlEmail  : String
        + OthrPhne  : String
        + MobPhne  : String
        + BizPhne  : String
        + HomePhne  : String
        + LastNm  : String
        + MddlNm  : String
        + GvnNm  : String
        + Nm  : String
    }
    class ISO20022.Cafr001001.ContentInformationType41 {
        + MAC  : String
        + MACData  : ISO20022.Cafr001001.MACData1
    }
    ISO20022.Cafr001001.ContentInformationType41 *-- ISO20022.Cafr001001.MACData1
    class ISO20022.Cafr001001.ContentType2Code {
        AUTH = 1
        DGST = 2
        EVLP = 3
        SIGN = 4
        DATA = 5
    }
    class ISO20022.Cafr001001.ContentType3Code {
        IFSE = 1
        EVLP = 2
    }
    class ISO20022.Cafr001001.Credentials3 {
        + Assgnr  : ISO20022.Cafr001001.Authority1
        + XpryDt  : String
        + Val  : String
        + SubTp  : String
        + OthrTp  : String
        + Tp  : String
    }
    ISO20022.Cafr001001.Credentials3 *-- ISO20022.Cafr001001.Authority1
    class ISO20022.Cafr001001.CreditDebit3Code {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Cafr001001.DisputeIdentification1 {
        + Id  : String
        + Tp  : String
    }
    class ISO20022.Cafr001001.DisputeReference1 {
        + DsptId  : global::System.Collections.Generic.List~ISO20022.Cafr001001.DisputeIdentification1~
        + OthrAssgnrNtty  : String
        + AssgnrNtty  : String
    }
    ISO20022.Cafr001001.DisputeReference1 *-- ISO20022.Cafr001001.DisputeIdentification1
    class ISO20022.Cafr001001.EncryptedContent8 {
        + NcrptdDataElmt  : global::System.Collections.Generic.List~ISO20022.Cafr001001.EncryptedDataElement2~
        + CnttNcrptnAlgo  : ISO20022.Cafr001001.AlgorithmIdentification25
        + CnttTp  : String
    }
    ISO20022.Cafr001001.EncryptedContent8 *-- ISO20022.Cafr001001.EncryptedDataElement2
    ISO20022.Cafr001001.EncryptedContent8 *-- ISO20022.Cafr001001.AlgorithmIdentification25
    class ISO20022.Cafr001001.EncryptedData2 {
        + NcrptdElmt  : global::System.Collections.Generic.List~ISO20022.Cafr001001.EncryptedDataElement2~
        + NcrptdFrmt  : String
        + PddgMtd  : String
        + KeyIndx  : String
        + KeyPrtcn  : String
        + KeyLngth  : String
        + Algo  : String
        + DrvdInf  : String
        + KeySetIdr  : String
        + Ctrl  : String
    }
    ISO20022.Cafr001001.EncryptedData2 *-- ISO20022.Cafr001001.EncryptedDataElement2
    class ISO20022.Cafr001001.EncryptedData2Choice {
        + HexBinry  : String
        + Binry  : String
    }
    class ISO20022.Cafr001001.EncryptedDataElement2 {
        + OthrClearTxtFrmt  : String
        + ClearTxtFrmt  : String
        + Data  : ISO20022.Cafr001001.EncryptedData2Choice
        + Id  : String
    }
    ISO20022.Cafr001001.EncryptedDataElement2 *-- ISO20022.Cafr001001.EncryptedData2Choice
    class ISO20022.Cafr001001.EncryptedDataFormat1Code {
        OTHP = 1
        OTHN = 2
        HEXF = 3
        EBCD = 4
        BINF = 5
        ASCI = 6
    }
    class ISO20022.Cafr001001.EncryptionFormat3Code {
        CBCE = 1
        CTCE = 2
        TR31 = 3
        TR34 = 4
    }
    class ISO20022.Cafr001001.EnvelopedData12 {
        + NcrptdCntt  : ISO20022.Cafr001001.EncryptedContent8
        + Rcpt  : global::System.Collections.Generic.List~ISO20022.Cafr001001.Recipient7Choice~
        + Vrsn  : Decimal
    }
    ISO20022.Cafr001001.EnvelopedData12 *-- ISO20022.Cafr001001.EncryptedContent8
    ISO20022.Cafr001001.EnvelopedData12 *-- ISO20022.Cafr001001.Recipient7Choice
    class ISO20022.Cafr001001.FraudReportingAction1Code {
        UPDT = 1
        REOP = 2
        OTHP = 3
        OTHN = 4
        NEWF = 5
        CLSE = 6
        DUPL = 7
    }
    class ISO20022.Cafr001001.FraudReportingInitiationV03 {
        + SctyTrlr  : ISO20022.Cafr001001.ContentInformationType41
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Cafr001001.SupplementaryData1~
        + PrtctdData  : global::System.Collections.Generic.List~ISO20022.Cafr001001.ProtectedData2~
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cafr001001.AdditionalData2~
        + Rcncltn  : ISO20022.Cafr001001.Reconciliation4
        + AddtlFee  : global::System.Collections.Generic.List~ISO20022.Cafr001001.AdditionalFee3~
        + SttlmSvc  : ISO20022.Cafr001001.SettlementService6
        + Jursdctn  : ISO20022.Cafr001001.Jurisdiction2
        + Crdhldr  : ISO20022.Cafr001001.Cardholder22
        + Tkn  : ISO20022.Cafr001001.Token2
        + LclData  : ISO20022.Cafr001001.LocalData16
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Cafr001001.AdditionalInformation22~
        + TxCrdhldrNm  : ISO20022.Cafr001001.CardholderName3
        + CardNotRcvdDtls  : ISO20022.Cafr001001.CardNotReceivedDetails3
        + FrdTxId  : String
        + Prgrmm  : ISO20022.Cafr001001.ProgrammeMode5
        + Dstn  : ISO20022.Cafr001001.PartyIdentification286
        + Issr  : ISO20022.Cafr001001.PartyIdentification286
        + Rcvr  : ISO20022.Cafr001001.PartyIdentification286
        + FrdlntTxData  : ISO20022.Cafr001001.FraudulentTransactionData3
        + Card  : ISO20022.Cafr001001.CardData15
        + Sndr  : ISO20022.Cafr001001.PartyIdentification286
        + Acqrr  : ISO20022.Cafr001001.PartyIdentification286
        + Orgtr  : ISO20022.Cafr001001.PartyIdentification286
        + RptdFrd  : ISO20022.Cafr001001.ReportedFraud4
        + Hdr  : ISO20022.Cafr001001.Header71
    }
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.ContentInformationType41
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.SupplementaryData1
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.ProtectedData2
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.AdditionalData2
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.Reconciliation4
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.AdditionalFee3
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.SettlementService6
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.Jurisdiction2
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.Cardholder22
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.Token2
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.LocalData16
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.AdditionalInformation22
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.CardholderName3
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.CardNotReceivedDetails3
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.ProgrammeMode5
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.PartyIdentification286
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.PartyIdentification286
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.PartyIdentification286
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.FraudulentTransactionData3
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.CardData15
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.PartyIdentification286
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.PartyIdentification286
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.PartyIdentification286
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.ReportedFraud4
    ISO20022.Cafr001001.FraudReportingInitiationV03 *-- ISO20022.Cafr001001.Header71
    class ISO20022.Cafr001001.FraudType1Code {
        COSN = 1
        MUFD = 2
        CNPA = 3
        CRDS = 4
        OTHP = 5
        OTHN = 6
        MISC = 7
        CRDL = 8
        CWKA = 9
        FRAP = 10
        FRAC = 11
        CRNT = 12
        CWUI = 13
        ACTO = 14
    }
    class ISO20022.Cafr001001.FraudulentTransactionData3 {
        + FrdlntMsg  : String
        + AltrnMsgRsn  : global::System.Collections.Generic.List~String~
        + MsgRsn  : global::System.Collections.Generic.List~String~
        + DsptRef  : global::System.Collections.Generic.List~ISO20022.Cafr001001.DisputeReference1~
        + DsptCond  : String
        + PresntmntCycl  : String
        + OthrAuthstnNtty  : String
        + AuthstnNtty  : String
        + Authstn  : String
    }
    ISO20022.Cafr001001.FraudulentTransactionData3 *-- ISO20022.Cafr001001.DisputeReference1
    class ISO20022.Cafr001001.GenericIdentification183 {
        + ShrtNm  : String
        + Ctry  : String
        + Assgnr  : String
        + OthrTp  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Cafr001001.Header71 {
        + Tracblt  : global::System.Collections.Generic.List~ISO20022.Cafr001001.Traceability10~
        + TracData  : global::System.Collections.Generic.List~ISO20022.Cafr001001.AdditionalData1~
        + RcptPty  : ISO20022.Cafr001001.GenericIdentification183
        + InitgPty  : ISO20022.Cafr001001.GenericIdentification183
        + BtchMgmtInf  : ISO20022.Cafr001001.BatchManagementInformation1
        + CreDtTm  : DateTime
        + ReTrnsmssnCntr  : String
        + XchgId  : String
        + PrtcolVrsn  : String
        + MsgFctn  : String
    }
    ISO20022.Cafr001001.Header71 *-- ISO20022.Cafr001001.Traceability10
    ISO20022.Cafr001001.Header71 *-- ISO20022.Cafr001001.AdditionalData1
    ISO20022.Cafr001001.Header71 *-- ISO20022.Cafr001001.GenericIdentification183
    ISO20022.Cafr001001.Header71 *-- ISO20022.Cafr001001.GenericIdentification183
    ISO20022.Cafr001001.Header71 *-- ISO20022.Cafr001001.BatchManagementInformation1
    class ISO20022.Cafr001001.IssuerAndSerialNumber1 {
        + SrlNb  : String
        + Issr  : ISO20022.Cafr001001.CertificateIssuer1
    }
    ISO20022.Cafr001001.IssuerAndSerialNumber1 *-- ISO20022.Cafr001001.CertificateIssuer1
    class ISO20022.Cafr001001.Jurisdiction2 {
        + DmstQlfctn  : String
        + DmstInd  : String
    }
    class ISO20022.Cafr001001.KEK6 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Cafr001001.AlgorithmIdentification28
        + KEKId  : ISO20022.Cafr001001.KEKIdentifier6
        + Vrsn  : Decimal
    }
    ISO20022.Cafr001001.KEK6 *-- ISO20022.Cafr001001.AlgorithmIdentification28
    ISO20022.Cafr001001.KEK6 *-- ISO20022.Cafr001001.KEKIdentifier6
    class ISO20022.Cafr001001.KEKIdentifier2 {
        + DerivtnId  : String
        + SeqNb  : Decimal
        + KeyVrsn  : String
        + KeyId  : String
    }
    class ISO20022.Cafr001001.KEKIdentifier6 {
        + DerivtnId  : String
        + SeqNb  : Decimal
        + KeyVrsn  : String
        + KeyId  : String
    }
    class ISO20022.Cafr001001.KeyTransport6 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Cafr001001.AlgorithmIdentification27
        + RcptId  : ISO20022.Cafr001001.Recipient5Choice
        + Vrsn  : Decimal
    }
    ISO20022.Cafr001001.KeyTransport6 *-- ISO20022.Cafr001001.AlgorithmIdentification27
    ISO20022.Cafr001001.KeyTransport6 *-- ISO20022.Cafr001001.Recipient5Choice
    class ISO20022.Cafr001001.LocalAddress1 {
        + CtrySubDvsnMjrNm  : String
        + CtrySubDvsnMnrNm  : String
        + TwnNm  : String
        + PstlCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine2  : String
        + AdrLine1  : String
    }
    class ISO20022.Cafr001001.LocalData13 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cafr001001.AdditionalData1~
        + Adr  : ISO20022.Cafr001001.LocalAddress1
        + Nm  : ISO20022.Cafr001001.CardholderName2
        + NcodgFrmt  : String
        + Lang  : String
    }
    ISO20022.Cafr001001.LocalData13 *-- ISO20022.Cafr001001.AdditionalData1
    ISO20022.Cafr001001.LocalData13 *-- ISO20022.Cafr001001.LocalAddress1
    ISO20022.Cafr001001.LocalData13 *-- ISO20022.Cafr001001.CardholderName2
    class ISO20022.Cafr001001.LocalData14 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cafr001001.AdditionalData1~
        + LglCorpNm  : String
        + ShrtNm  : String
        + NcodgFrmt  : String
        + Lang  : String
    }
    ISO20022.Cafr001001.LocalData14 *-- ISO20022.Cafr001001.AdditionalData1
    class ISO20022.Cafr001001.LocalData16 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cafr001001.AdditionalData1~
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Cafr001001.AdditionalInformation22~
        + CrdhldrNm  : ISO20022.Cafr001001.CardholderName2
        + MldFrPstlCd  : String
        + MlngAdrUstrd  : String
        + MlngAdr  : ISO20022.Cafr001001.LocalAddress1
        + NcodgFrmt  : String
        + Lang  : String
    }
    ISO20022.Cafr001001.LocalData16 *-- ISO20022.Cafr001001.AdditionalData1
    ISO20022.Cafr001001.LocalData16 *-- ISO20022.Cafr001001.AdditionalInformation22
    ISO20022.Cafr001001.LocalData16 *-- ISO20022.Cafr001001.CardholderName2
    ISO20022.Cafr001001.LocalData16 *-- ISO20022.Cafr001001.LocalAddress1
    class ISO20022.Cafr001001.MACData1 {
        + InitlstnVctr  : String
        + PddgMtd  : String
        + KeyIndx  : String
        + KeyPrtcn  : String
        + KeyLngth  : String
        + Algo  : String
        + DrvdInf  : String
        + KeySetIdr  : String
        + Ctrl  : String
    }
    class ISO20022.Cafr001001.OutputFormat4Code {
        HTML = 1
        URLI = 2
        TEXT = 3
        SMSI = 4
        OTHP = 5
        OTHN = 6
        MREF = 7
        FLNM = 8
    }
    class ISO20022.Cafr001001.Parameter13 {
        + MskGnrtrAlgo  : ISO20022.Cafr001001.AlgorithmIdentification26
        + DgstAlgo  : String
    }
    ISO20022.Cafr001001.Parameter13 *-- ISO20022.Cafr001001.AlgorithmIdentification26
    class ISO20022.Cafr001001.Parameter14 {
        + BPddg  : String
        + InitlstnVctr  : String
        + NcrptnFrmt  : String
    }
    class ISO20022.Cafr001001.Parameter7 {
        + BPddg  : String
        + InitlstnVctr  : String
    }
    class ISO20022.Cafr001001.PartyIdentification286 {
        + LclData  : ISO20022.Cafr001001.LocalData14
        + AddtlId  : global::System.Collections.Generic.List~ISO20022.Cafr001001.AdditionalData1~
        + LglCorpNm  : String
        + ShrtNm  : String
        + Ctry  : String
        + Assgnr  : String
        + Id  : String
    }
    ISO20022.Cafr001001.PartyIdentification286 *-- ISO20022.Cafr001001.LocalData14
    ISO20022.Cafr001001.PartyIdentification286 *-- ISO20022.Cafr001001.AdditionalData1
    class ISO20022.Cafr001001.PartyType17Code {
        AGNT = 1
        CISP = 2
        CISS = 3
        ACQP = 4
        ACQR = 5
        OTHP = 6
        OTHN = 7
    }
    class ISO20022.Cafr001001.PartyType18Code {
        AGNT = 1
        CSCH = 2
        CISS = 3
        ACQR = 4
    }
    class ISO20022.Cafr001001.PartyType19Code {
        OTHP = 1
        OTHN = 2
        AGNT = 3
        CISP = 4
        CISS = 5
        ACQP = 6
        ACQR = 7
        ACCP = 8
    }
    class ISO20022.Cafr001001.PartyType26Code {
        OTHP = 1
        OTHN = 2
        AGNT = 3
        DLIS = 4
        CISS = 5
        ICCA = 6
        ACQR = 7
        ACCP = 8
    }
    class ISO20022.Cafr001001.PartyType32Code {
        OTHP = 1
        OTHN = 2
        ISUR = 3
        AGNT = 4
        ACQR = 5
    }
    class ISO20022.Cafr001001.ProgrammeMode5 {
        + AddtlId  : global::System.Collections.Generic.List~ISO20022.Cafr001001.AdditionalData1~
        + ApldId  : String
    }
    ISO20022.Cafr001001.ProgrammeMode5 *-- ISO20022.Cafr001001.AdditionalData1
    class ISO20022.Cafr001001.ProtectedData2 {
        + NcrptdData  : ISO20022.Cafr001001.EncryptedData2
        + EnvlpdData  : ISO20022.Cafr001001.EnvelopedData12
        + CnttTp  : String
    }
    ISO20022.Cafr001001.ProtectedData2 *-- ISO20022.Cafr001001.EncryptedData2
    ISO20022.Cafr001001.ProtectedData2 *-- ISO20022.Cafr001001.EnvelopedData12
    class ISO20022.Cafr001001.ProtectionMethod1Code {
        TEEN = 1
        SOFT = 2
        SNCL = 3
        SELM = 4
        OTHP = 5
        OTHN = 6
    }
    class ISO20022.Cafr001001.Recipient5Choice {
        + KeyIdr  : ISO20022.Cafr001001.KEKIdentifier2
        + IssrAndSrlNb  : ISO20022.Cafr001001.IssuerAndSerialNumber1
    }
    ISO20022.Cafr001001.Recipient5Choice *-- ISO20022.Cafr001001.KEKIdentifier2
    ISO20022.Cafr001001.Recipient5Choice *-- ISO20022.Cafr001001.IssuerAndSerialNumber1
    class ISO20022.Cafr001001.Recipient7Choice {
        + KeyIdr  : ISO20022.Cafr001001.KEKIdentifier6
        + KEK  : ISO20022.Cafr001001.KEK6
        + KeyTrnsprt  : ISO20022.Cafr001001.KeyTransport6
    }
    ISO20022.Cafr001001.Recipient7Choice *-- ISO20022.Cafr001001.KEKIdentifier6
    ISO20022.Cafr001001.Recipient7Choice *-- ISO20022.Cafr001001.KEK6
    ISO20022.Cafr001001.Recipient7Choice *-- ISO20022.Cafr001001.KeyTransport6
    class ISO20022.Cafr001001.Reconciliation4 {
        + ChckptRef  : String
        + Dt  : DateTime
        + Id  : String
    }
    class ISO20022.Cafr001001.RelativeDistinguishedName1 {
        + AttrVal  : String
        + AttrTp  : String
    }
    class ISO20022.Cafr001001.ReportedFraud4 {
        + InvstgtnSts  : String
        + Arrst  : String
        + CaseRef  : String
        + CaseLctrNb  : String
        + MktSgmt  : String
        + SubmitrCaseRef  : String
        + ConfRptgDt  : DateTime
        + CrdhldrRptgDt  : DateTime
        + CmprmsdCrdntl  : global::System.Collections.Generic.List~String~
        + OthrRptgNtty  : String
        + RptgNtty  : String
        + OthrActn  : String
        + Actn  : String
        + OthrTp  : String
        + Tp  : String
    }
    class ISO20022.Cafr001001.SettlementService6 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Cafr001001.AdditionalData1~
        + RptgNttyId  : String
        + RptgNttyTp  : String
        + CutOffTm  : DateTime
        + Prd  : String
        + Tm  : DateTime
        + Dt  : DateTime
        + Dfrrd  : String
        + ReqdDt  : DateTime
        + Id  : String
        + Tp  : String
    }
    ISO20022.Cafr001001.SettlementService6 *-- ISO20022.Cafr001001.AdditionalData1
    class ISO20022.Cafr001001.StorageLocation1Code {
        TPWL = 1
        OTHP = 2
        OTHN = 3
        ONFL = 4
        ISWL = 5
        DVCE = 6
        CAWL = 7
    }
    class ISO20022.Cafr001001.SupplementaryData1 {
        + Envlp  : ISO20022.Cafr001001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Cafr001001.SupplementaryData1 *-- ISO20022.Cafr001001.SupplementaryDataEnvelope1
    class ISO20022.Cafr001001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Cafr001001.Token2 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cafr001001.AdditionalData1~
        + OthrPrtcnMtd  : String
        + PrtcnMtd  : String
        + OthrStorgLctn  : String
        + StorgLctn  : String
        + TknInittdInd  : String
        + TknAssrncMtd  : String
        + TknAssrncData  : String
        + TknRqstrId  : String
        + TknXpryDt  : String
        + PmtTkn  : String
    }
    ISO20022.Cafr001001.Token2 *-- ISO20022.Cafr001001.AdditionalData1
    class ISO20022.Cafr001001.Traceability10 {
        + DtTmOut  : DateTime
        + DtTmIn  : DateTime
        + ShrtNm  : String
        + Ctry  : String
        + Assgnr  : String
        + OthrTp  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Cafr001001.TypeOfAmount21Code {
        MNIF = 1
        MXIF = 2
        CSIF = 3
        FEEA = 4
        OTHP = 5
        OTHN = 6
        FEEP = 7
        INTC = 8
    }
    class ISO20022.Cafr001001.UserInterface8Code {
        OTHN = 1
        OTHP = 2
        LOGF = 3
        FILE = 4
        DSPU = 5
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

## Value ISO20022.Cafr001001.AdditionalData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cafr001001.AdditionalData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dtls|global::System.Collections.Generic.List<ISO20022.Cafr001001.AdditionalData1>||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Dtls""",Dtls),validElement(Dtls))|

---

## Value ISO20022.Cafr001001.AdditionalFee3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrAssgnr|String||XmlElement()||
|+|Assgnr|String||XmlElement()||
|+|RcncltnFctvXchgRate|Decimal||XmlElement()||
|+|RcncltnCcy|String||XmlElement()||
|+|RcncltnAmt|Decimal||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
|+|CdtDbt|String||XmlElement()||
|+|Dscrptr|String||XmlElement()||
|+|Prgm|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""RcncltnCcy""",RcncltnCcy,"""[0-9]{3,3}"""),validPattern("""Ccy""",Ccy,"""[0-9]{3,3}"""))|

---

## Value ISO20022.Cafr001001.AdditionalInformation22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Frmt|String||XmlElement()||
|+|Trgt|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Rcpt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cafr001001.Address2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsnMnrNm|String||XmlElement()||
|+|CtrySubDvsnMjrNm|String||XmlElement()||
|+|CtrySubDvsnMjr|String||XmlElement()||
|+|CtrySubDvsnMnr|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstlCd|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|AdrLine2|String||XmlElement()||
|+|AdrLine1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,3}"""),validPattern("""CtrySubDvsnMjr""",CtrySubDvsnMjr,"""[A-Z]{2,3}"""),validPattern("""CtrySubDvsnMnr""",CtrySubDvsnMnr,"""[A-Z]{2,3}"""))|

---

## Enum ISO20022.Cafr001001.Algorithm13Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EA5C|Int32||XmlEnum("""EA5C""")|1|
||EA9C|Int32||XmlEnum("""EA9C""")|2|
||UKA1|Int32||XmlEnum("""UKA1""")|3|
||UKPT|Int32||XmlEnum("""UKPT""")|4|
||DKP9|Int32||XmlEnum("""DKP9""")|5|
||E3DC|Int32||XmlEnum("""E3DC""")|6|
||EA2C|Int32||XmlEnum("""EA2C""")|7|

---

## Enum ISO20022.Cafr001001.Algorithm20Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HS51|Int32||XmlEnum("""HS51""")|1|
||HS38|Int32||XmlEnum("""HS38""")|2|
||HS25|Int32||XmlEnum("""HS25""")|3|

---

## Enum ISO20022.Cafr001001.Algorithm23Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SD5C|Int32||XmlEnum("""SD5C""")|1|
||E36R|Int32||XmlEnum("""E36R""")|2|
||E36C|Int32||XmlEnum("""E36C""")|3|
||E3DR|Int32||XmlEnum("""E3DR""")|4|
||EA5R|Int32||XmlEnum("""EA5R""")|5|
||EA9R|Int32||XmlEnum("""EA9R""")|6|
||EA2R|Int32||XmlEnum("""EA2R""")|7|
||EA5C|Int32||XmlEnum("""EA5C""")|8|
||EA9C|Int32||XmlEnum("""EA9C""")|9|
||E3DC|Int32||XmlEnum("""E3DC""")|10|
||EA2C|Int32||XmlEnum("""EA2C""")|11|

---

## Enum ISO20022.Cafr001001.Algorithm5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HS51|Int32||XmlEnum("""HS51""")|1|
||HS38|Int32||XmlEnum("""HS38""")|2|
||HS25|Int32||XmlEnum("""HS25""")|3|

---

## Enum ISO20022.Cafr001001.Algorithm7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSAO|Int32||XmlEnum("""RSAO""")|1|
||ERSA|Int32||XmlEnum("""ERSA""")|2|

---

## Enum ISO20022.Cafr001001.Algorithm8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MGF1|Int32||XmlEnum("""MGF1""")|1|

---

## Value ISO20022.Cafr001001.AlgorithmIdentification25


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Cafr001001.Parameter7||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Cafr001001.AlgorithmIdentification26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|String||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cafr001001.AlgorithmIdentification27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Cafr001001.Parameter13||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Cafr001001.AlgorithmIdentification28


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Cafr001001.Parameter14||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Enum ISO20022.Cafr001001.AttributeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CATT|Int32||XmlEnum("""CATT""")|1|
||OUAT|Int32||XmlEnum("""OUAT""")|2|
||OATT|Int32||XmlEnum("""OATT""")|3|
||LATT|Int32||XmlEnum("""LATT""")|4|
||CNAT|Int32||XmlEnum("""CNAT""")|5|

---

## Enum ISO20022.Cafr001001.AuthenticationMethod12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CHSN|Int32||XmlEnum("""CHSN""")|1|
||ACSN|Int32||XmlEnum("""ACSN""")|2|
||NTID|Int32||XmlEnum("""NTID""")|3|
||FPIN|Int32||XmlEnum("""FPIN""")|4|
||MOBL|Int32||XmlEnum("""MOBL""")|5|
||BIOM|Int32||XmlEnum("""BIOM""")|6|
||CRYP|Int32||XmlEnum("""CRYP""")|7|
||CSCV|Int32||XmlEnum("""CSCV""")|8|
||ADDS|Int32||XmlEnum("""ADDS""")|9|
||ADDB|Int32||XmlEnum("""ADDB""")|10|
||THDS|Int32||XmlEnum("""THDS""")|11|
||PWOR|Int32||XmlEnum("""PWOR""")|12|
||PHOM|Int32||XmlEnum("""PHOM""")|13|
||QWAC|Int32||XmlEnum("""QWAC""")|14|
||TOKN|Int32||XmlEnum("""TOKN""")|15|
||CDHI|Int32||XmlEnum("""CDHI""")|16|
||TOKA|Int32||XmlEnum("""TOKA""")|17|
||TXIN|Int32||XmlEnum("""TXIN""")|18|
||SSNB|Int32||XmlEnum("""SSNB""")|19|
||CPSG|Int32||XmlEnum("""CPSG""")|20|
||SHAT|Int32||XmlEnum("""SHAT""")|21|
||SHAF|Int32||XmlEnum("""SHAF""")|22|
||CSEC|Int32||XmlEnum("""CSEC""")|23|
||SCNL|Int32||XmlEnum("""SCNL""")|24|
||SCRT|Int32||XmlEnum("""SCRT""")|25|
||PCDV|Int32||XmlEnum("""PCDV""")|26|
||PLOB|Int32||XmlEnum("""PLOB""")|27|
||PKIS|Int32||XmlEnum("""PKIS""")|28|
||TOKP|Int32||XmlEnum("""TOKP""")|29|
||PSWD|Int32||XmlEnum("""PSWD""")|30|
||PASN|Int32||XmlEnum("""PASN""")|31|
||PSVE|Int32||XmlEnum("""PSVE""")|32|
||PPSG|Int32||XmlEnum("""PPSG""")|33|
||OTHP|Int32||XmlEnum("""OTHP""")|34|
||OTHN|Int32||XmlEnum("""OTHN""")|35|
||OCHI|Int32||XmlEnum("""OCHI""")|36|
||NPIN|Int32||XmlEnum("""NPIN""")|37|
||NBIG|Int32||XmlEnum("""NBIG""")|38|
||OTPW|Int32||XmlEnum("""OTPW""")|39|
||FCPN|Int32||XmlEnum("""FCPN""")|40|
||OFPE|Int32||XmlEnum("""OFPE""")|41|
||OLDS|Int32||XmlEnum("""OLDS""")|42|
||OLDA|Int32||XmlEnum("""OLDA""")|43|
||FBIO|Int32||XmlEnum("""FBIO""")|44|
||FBIG|Int32||XmlEnum("""FBIG""")|45|
||NVSC|Int32||XmlEnum("""NVSC""")|46|
||MANU|Int32||XmlEnum("""MANU""")|47|
||IDCN|Int32||XmlEnum("""IDCN""")|48|
||EMRN|Int32||XmlEnum("""EMRN""")|49|
||EMIN|Int32||XmlEnum("""EMIN""")|50|
||EMAL|Int32||XmlEnum("""EMAL""")|51|
||DRLN|Int32||XmlEnum("""DRLN""")|52|
||DRVI|Int32||XmlEnum("""DRVI""")|53|
||CUID|Int32||XmlEnum("""CUID""")|54|
||CHDN|Int32||XmlEnum("""CHDN""")|55|
||CHSA|Int32||XmlEnum("""CHSA""")|56|
||BTHD|Int32||XmlEnum("""BTHD""")|57|
||ATCC|Int32||XmlEnum("""ATCC""")|58|
||ARQC|Int32||XmlEnum("""ARQC""")|59|
||ARPC|Int32||XmlEnum("""ARPC""")|60|
||ARNB|Int32||XmlEnum("""ARNB""")|61|
||ADVF|Int32||XmlEnum("""ADVF""")|62|
||APKI|Int32||XmlEnum("""APKI""")|63|

---

## Value ISO20022.Cafr001001.Authority1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|CtrySubDvsnMnrNm|String||XmlElement()||
|+|CtrySubDvsnMjrNm|String||XmlElement()||
|+|CtrySubDvsnMnr|String||XmlElement()||
|+|CtrySubDvsnMjr|String||XmlElement()||
|+|Ctry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtrySubDvsnMnr""",CtrySubDvsnMnr,"""[A-Z]{2,3}"""),validPattern("""CtrySubDvsnMjr""",CtrySubDvsnMjr,"""[A-Z]{2,3}"""),validPattern("""Ctry""",Ctry,"""[0-9]{3,3}"""))|

---

## Value ISO20022.Cafr001001.BatchManagementInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgChcksmInptVal|String||XmlElement()||
|+|MsgSeqNb|String||XmlElement()||
|+|BtchId|String||XmlElement()||
|+|ColltnId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MsgSeqNb""",MsgSeqNb,"""[0-9]{1,15}"""))|

---

## Enum ISO20022.Cafr001001.BytePadding1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RAND|Int32||XmlEnum("""RAND""")|1|
||NULL|Int32||XmlEnum("""NULL""")|2|
||NULG|Int32||XmlEnum("""NULG""")|3|
||NUL8|Int32||XmlEnum("""NUL8""")|4|
||LNGT|Int32||XmlEnum("""LNGT""")|5|

---

## Value ISO20022.Cafr001001.CardData15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cafr001001.AdditionalData1>||XmlElement()||
|+|PrtflIdr|String||XmlElement()||
|+|PdctSubTp|String||XmlElement()||
|+|PdctTp|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|PANAcctRg|String||XmlElement()||
|+|PANRefIdr|String||XmlElement()||
|+|PmtAcctRef|String||XmlElement()||
|+|XpryDt|String||XmlElement()||
|+|FctvDt|String||XmlElement()||
|+|CardSeqNb|String||XmlElement()||
|+|PrtctdPAN|String||XmlElement()||
|+|PAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validPattern("""Ctry""",Ctry,"""[0-9]{3,3}"""),validPattern("""PANAcctRg""",PANAcctRg,"""[0-9]{1,19}"""),validPattern("""CardSeqNb""",CardSeqNb,"""[0-9]{2,3}"""),validPattern("""PAN""",PAN,"""[0-9]{1,19}"""))|

---

## Value ISO20022.Cafr001001.CardNotReceivedDetails3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CardSctyCpblty|global::System.Collections.Generic.List<ISO20022.Cafr001001.CardSecurityCapability1>||XmlElement()||
|+|CardSctyCd|String||XmlElement()||
|+|VldFr|DateTime||XmlElement()||
|+|MldFrPstlCd|String||XmlElement()||
|+|MlngAdrUstrd|String||XmlElement()||
|+|MlngAdr|ISO20022.Cafr001001.Address2||XmlElement()||
|+|DtMld|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CardSctyCpblty""",CardSctyCpblty),validElement(CardSctyCpblty),validElement(MlngAdr))|

---

## Value ISO20022.Cafr001001.CardSecurityCapability1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrCpblty|String||XmlElement()||
|+|Cpblty|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Cafr001001.CardSecurityCapability1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OLPN|Int32||XmlEnum("""OLPN""")|1|
||OTHP|Int32||XmlEnum("""OTHP""")|2|
||OTHN|Int32||XmlEnum("""OTHN""")|3|
||MSWS|Int32||XmlEnum("""MSWS""")|4|
||MWOS|Int32||XmlEnum("""MWOS""")|5|
||ICCD|Int32||XmlEnum("""ICCD""")|6|

---

## Value ISO20022.Cafr001001.Cardholder22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LclData|ISO20022.Cafr001001.LocalData13||XmlElement()||
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cafr001001.AdditionalData1>||XmlElement()||
|+|HghVal|String||XmlElement()||
|+|DtOfBirth|DateTime||XmlElement()||
|+|CtctInf|ISO20022.Cafr001001.ContactPersonal1||XmlElement()||
|+|Adr|ISO20022.Cafr001001.Address2||XmlElement()||
|+|Id|global::System.Collections.Generic.List<ISO20022.Cafr001001.Credentials3>||XmlElement()||
|+|Nm|ISO20022.Cafr001001.CardholderName3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LclData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(CtctInf),validElement(Adr),validList("""Id""",Id),validElement(Id),validElement(Nm))|

---

## Value ISO20022.Cafr001001.CardholderName2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastNm|String||XmlElement()||
|+|MddlNm|String||XmlElement()||
|+|GvnNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cafr001001.CardholderName3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastNm|String||XmlElement()||
|+|MddlNm|String||XmlElement()||
|+|GvnNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cafr001001.CertificateIssuer1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltvDstngshdNm|global::System.Collections.Generic.List<ISO20022.Cafr001001.RelativeDistinguishedName1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""RltvDstngshdNm""",RltvDstngshdNm),validList("""RltvDstngshdNm""",RltvDstngshdNm),validElement(RltvDstngshdNm))|

---

## Value ISO20022.Cafr001001.ContactPersonal1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lang|String||XmlElement()||
|+|URL|String||XmlElement()||
|+|BizFax|String||XmlElement()||
|+|HomeFax|String||XmlElement()||
|+|OthrEmail|String||XmlElement()||
|+|BizEmail|String||XmlElement()||
|+|PrsnlEmail|String||XmlElement()||
|+|OthrPhne|String||XmlElement()||
|+|MobPhne|String||XmlElement()||
|+|BizPhne|String||XmlElement()||
|+|HomePhne|String||XmlElement()||
|+|LastNm|String||XmlElement()||
|+|MddlNm|String||XmlElement()||
|+|GvnNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lang""",Lang,"""[a-z]{2,2}"""),validPattern("""BizFax""",BizFax,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""HomeFax""",HomeFax,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""OthrPhne""",OthrPhne,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""MobPhne""",MobPhne,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""BizPhne""",BizPhne,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""HomePhne""",HomePhne,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Value ISO20022.Cafr001001.ContentInformationType41


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MAC|String||XmlElement()||
|+|MACData|ISO20022.Cafr001001.MACData1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MAC""",MAC,"""([0-9A-F][0-9A-F]){1,8}"""),validElement(MACData))|

---

## Enum ISO20022.Cafr001001.ContentType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AUTH|Int32||XmlEnum("""AUTH""")|1|
||DGST|Int32||XmlEnum("""DGST""")|2|
||EVLP|Int32||XmlEnum("""EVLP""")|3|
||SIGN|Int32||XmlEnum("""SIGN""")|4|
||DATA|Int32||XmlEnum("""DATA""")|5|

---

## Enum ISO20022.Cafr001001.ContentType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||IFSE|Int32||XmlEnum("""IFSE""")|1|
||EVLP|Int32||XmlEnum("""EVLP""")|2|

---

## Value ISO20022.Cafr001001.Credentials3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Assgnr|ISO20022.Cafr001001.Authority1||XmlElement()||
|+|XpryDt|String||XmlElement()||
|+|Val|String||XmlElement()||
|+|SubTp|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Assgnr))|

---

## Enum ISO20022.Cafr001001.CreditDebit3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Cafr001001.DisputeIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cafr001001.DisputeReference1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DsptId|global::System.Collections.Generic.List<ISO20022.Cafr001001.DisputeIdentification1>||XmlElement()||
|+|OthrAssgnrNtty|String||XmlElement()||
|+|AssgnrNtty|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""DsptId""",DsptId),validList("""DsptId""",DsptId),validElement(DsptId))|

---

## Type ISO20022.Cafr001001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrdRptgInitn|ISO20022.Cafr001001.FraudReportingInitiationV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrdRptgInitn))|

---

## Value ISO20022.Cafr001001.EncryptedContent8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdDataElmt|global::System.Collections.Generic.List<ISO20022.Cafr001001.EncryptedDataElement2>||XmlElement()||
|+|CnttNcrptnAlgo|ISO20022.Cafr001001.AlgorithmIdentification25||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""NcrptdDataElmt""",NcrptdDataElmt),validList("""NcrptdDataElmt""",NcrptdDataElmt),validElement(NcrptdDataElmt),validElement(CnttNcrptnAlgo))|

---

## Value ISO20022.Cafr001001.EncryptedData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdElmt|global::System.Collections.Generic.List<ISO20022.Cafr001001.EncryptedDataElement2>||XmlElement()||
|+|NcrptdFrmt|String||XmlElement()||
|+|PddgMtd|String||XmlElement()||
|+|KeyIndx|String||XmlElement()||
|+|KeyPrtcn|String||XmlElement()||
|+|KeyLngth|String||XmlElement()||
|+|Algo|String||XmlElement()||
|+|DrvdInf|String||XmlElement()||
|+|KeySetIdr|String||XmlElement()||
|+|Ctrl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""NcrptdElmt""",NcrptdElmt),validList("""NcrptdElmt""",NcrptdElmt),validElement(NcrptdElmt),validPattern("""NcrptdFrmt""",NcrptdFrmt,"""[0-9]{1,2}"""),validPattern("""PddgMtd""",PddgMtd,"""[0-9]{1,2}"""),validPattern("""KeyIndx""",KeyIndx,"""[0-9]{1,5}"""),validPattern("""KeyPrtcn""",KeyPrtcn,"""[0-9]{1,2}"""),validPattern("""KeyLngth""",KeyLngth,"""[0-9]{1,4}"""),validPattern("""Algo""",Algo,"""[0-9]{1,2}"""),validPattern("""DrvdInf""",DrvdInf,"""([0-9A-F][0-9A-F]){1,32}"""),validPattern("""KeySetIdr""",KeySetIdr,"""[0-9]{1,8}"""),validPattern("""Ctrl""",Ctrl,"""([0-9A-F][0-9A-F]){1}"""))|

---

## Value ISO20022.Cafr001001.EncryptedData2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HexBinry|String||XmlElement()||
|+|Binry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""HexBinry""",HexBinry,"""([0-9A-F][0-9A-F]){1,9999}"""),validChoice(HexBinry,Binry))|

---

## Value ISO20022.Cafr001001.EncryptedDataElement2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrClearTxtFrmt|String||XmlElement()||
|+|ClearTxtFrmt|String||XmlElement()||
|+|Data|ISO20022.Cafr001001.EncryptedData2Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Data))|

---

## Enum ISO20022.Cafr001001.EncryptedDataFormat1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHP|Int32||XmlEnum("""OTHP""")|1|
||OTHN|Int32||XmlEnum("""OTHN""")|2|
||HEXF|Int32||XmlEnum("""HEXF""")|3|
||EBCD|Int32||XmlEnum("""EBCD""")|4|
||BINF|Int32||XmlEnum("""BINF""")|5|
||ASCI|Int32||XmlEnum("""ASCI""")|6|

---

## Enum ISO20022.Cafr001001.EncryptionFormat3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CBCE|Int32||XmlEnum("""CBCE""")|1|
||CTCE|Int32||XmlEnum("""CTCE""")|2|
||TR31|Int32||XmlEnum("""TR31""")|3|
||TR34|Int32||XmlEnum("""TR34""")|4|

---

## Value ISO20022.Cafr001001.EnvelopedData12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdCntt|ISO20022.Cafr001001.EncryptedContent8||XmlElement()||
|+|Rcpt|global::System.Collections.Generic.List<ISO20022.Cafr001001.Recipient7Choice>||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcrptdCntt),validRequired("""Rcpt""",Rcpt),validList("""Rcpt""",Rcpt),validElement(Rcpt))|

---

## Enum ISO20022.Cafr001001.FraudReportingAction1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UPDT|Int32||XmlEnum("""UPDT""")|1|
||REOP|Int32||XmlEnum("""REOP""")|2|
||OTHP|Int32||XmlEnum("""OTHP""")|3|
||OTHN|Int32||XmlEnum("""OTHN""")|4|
||NEWF|Int32||XmlEnum("""NEWF""")|5|
||CLSE|Int32||XmlEnum("""CLSE""")|6|
||DUPL|Int32||XmlEnum("""DUPL""")|7|

---

## Aspect ISO20022.Cafr001001.FraudReportingInitiationV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyTrlr|ISO20022.Cafr001001.ContentInformationType41||XmlElement()||
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Cafr001001.SupplementaryData1>||XmlElement()||
|+|PrtctdData|global::System.Collections.Generic.List<ISO20022.Cafr001001.ProtectedData2>||XmlElement()||
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cafr001001.AdditionalData2>||XmlElement()||
|+|Rcncltn|ISO20022.Cafr001001.Reconciliation4||XmlElement()||
|+|AddtlFee|global::System.Collections.Generic.List<ISO20022.Cafr001001.AdditionalFee3>||XmlElement()||
|+|SttlmSvc|ISO20022.Cafr001001.SettlementService6||XmlElement()||
|+|Jursdctn|ISO20022.Cafr001001.Jurisdiction2||XmlElement()||
|+|Crdhldr|ISO20022.Cafr001001.Cardholder22||XmlElement()||
|+|Tkn|ISO20022.Cafr001001.Token2||XmlElement()||
|+|LclData|ISO20022.Cafr001001.LocalData16||XmlElement()||
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Cafr001001.AdditionalInformation22>||XmlElement()||
|+|TxCrdhldrNm|ISO20022.Cafr001001.CardholderName3||XmlElement()||
|+|CardNotRcvdDtls|ISO20022.Cafr001001.CardNotReceivedDetails3||XmlElement()||
|+|FrdTxId|String||XmlElement()||
|+|Prgrmm|ISO20022.Cafr001001.ProgrammeMode5||XmlElement()||
|+|Dstn|ISO20022.Cafr001001.PartyIdentification286||XmlElement()||
|+|Issr|ISO20022.Cafr001001.PartyIdentification286||XmlElement()||
|+|Rcvr|ISO20022.Cafr001001.PartyIdentification286||XmlElement()||
|+|FrdlntTxData|ISO20022.Cafr001001.FraudulentTransactionData3||XmlElement()||
|+|Card|ISO20022.Cafr001001.CardData15||XmlElement()||
|+|Sndr|ISO20022.Cafr001001.PartyIdentification286||XmlElement()||
|+|Acqrr|ISO20022.Cafr001001.PartyIdentification286||XmlElement()||
|+|Orgtr|ISO20022.Cafr001001.PartyIdentification286||XmlElement()||
|+|RptdFrd|ISO20022.Cafr001001.ReportedFraud4||XmlElement()||
|+|Hdr|ISO20022.Cafr001001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validElement(Crdhldr),validElement(Tkn),validElement(LclData),validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(TxCrdhldrNm),validElement(CardNotRcvdDtls),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(FrdlntTxData),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(RptdFrd),validElement(Hdr))|

---

## Enum ISO20022.Cafr001001.FraudType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||COSN|Int32||XmlEnum("""COSN""")|1|
||MUFD|Int32||XmlEnum("""MUFD""")|2|
||CNPA|Int32||XmlEnum("""CNPA""")|3|
||CRDS|Int32||XmlEnum("""CRDS""")|4|
||OTHP|Int32||XmlEnum("""OTHP""")|5|
||OTHN|Int32||XmlEnum("""OTHN""")|6|
||MISC|Int32||XmlEnum("""MISC""")|7|
||CRDL|Int32||XmlEnum("""CRDL""")|8|
||CWKA|Int32||XmlEnum("""CWKA""")|9|
||FRAP|Int32||XmlEnum("""FRAP""")|10|
||FRAC|Int32||XmlEnum("""FRAC""")|11|
||CRNT|Int32||XmlEnum("""CRNT""")|12|
||CWUI|Int32||XmlEnum("""CWUI""")|13|
||ACTO|Int32||XmlEnum("""ACTO""")|14|

---

## Value ISO20022.Cafr001001.FraudulentTransactionData3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrdlntMsg|String||XmlElement()||
|+|AltrnMsgRsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|MsgRsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|DsptRef|global::System.Collections.Generic.List<ISO20022.Cafr001001.DisputeReference1>||XmlElement()||
|+|DsptCond|String||XmlElement()||
|+|PresntmntCycl|String||XmlElement()||
|+|OthrAuthstnNtty|String||XmlElement()||
|+|AuthstnNtty|String||XmlElement()||
|+|Authstn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MsgRsn""",MsgRsn,"""[0-9]{4,4}"""),validList("""DsptRef""",DsptRef),validElement(DsptRef),validPattern("""PresntmntCycl""",PresntmntCycl,"""[0-9]"""))|

---

## Value ISO20022.Cafr001001.GenericIdentification183


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Assgnr|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,3}"""))|

---

## Value ISO20022.Cafr001001.Header71


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tracblt|global::System.Collections.Generic.List<ISO20022.Cafr001001.Traceability10>||XmlElement()||
|+|TracData|global::System.Collections.Generic.List<ISO20022.Cafr001001.AdditionalData1>||XmlElement()||
|+|RcptPty|ISO20022.Cafr001001.GenericIdentification183||XmlElement()||
|+|InitgPty|ISO20022.Cafr001001.GenericIdentification183||XmlElement()||
|+|BtchMgmtInf|ISO20022.Cafr001001.BatchManagementInformation1||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|ReTrnsmssnCntr|String||XmlElement()||
|+|XchgId|String||XmlElement()||
|+|PrtcolVrsn|String||XmlElement()||
|+|MsgFctn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Tracblt""",Tracblt),validElement(Tracblt),validList("""TracData""",TracData),validElement(TracData),validElement(RcptPty),validElement(InitgPty),validElement(BtchMgmtInf),validPattern("""ReTrnsmssnCntr""",ReTrnsmssnCntr,"""[0-9]{1,3}"""))|

---

## Value ISO20022.Cafr001001.IssuerAndSerialNumber1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrlNb|String||XmlElement()||
|+|Issr|ISO20022.Cafr001001.CertificateIssuer1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Issr))|

---

## Value ISO20022.Cafr001001.Jurisdiction2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DmstQlfctn|String||XmlElement()||
|+|DmstInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cafr001001.KEK6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Cafr001001.AlgorithmIdentification28||XmlElement()||
|+|KEKId|ISO20022.Cafr001001.KEKIdentifier6||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(KEKId))|

---

## Value ISO20022.Cafr001001.KEKIdentifier2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivtnId|String||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|KeyVrsn|String||XmlElement()||
|+|KeyId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cafr001001.KEKIdentifier6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivtnId|String||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|KeyVrsn|String||XmlElement()||
|+|KeyId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cafr001001.KeyTransport6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Cafr001001.AlgorithmIdentification27||XmlElement()||
|+|RcptId|ISO20022.Cafr001001.Recipient5Choice||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(RcptId))|

---

## Value ISO20022.Cafr001001.LocalAddress1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtrySubDvsnMjrNm|String||XmlElement()||
|+|CtrySubDvsnMnrNm|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstlCd|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|AdrLine2|String||XmlElement()||
|+|AdrLine1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cafr001001.LocalData13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cafr001001.AdditionalData1>||XmlElement()||
|+|Adr|ISO20022.Cafr001001.LocalAddress1||XmlElement()||
|+|Nm|ISO20022.Cafr001001.CardholderName2||XmlElement()||
|+|NcodgFrmt|String||XmlElement()||
|+|Lang|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(Adr),validElement(Nm),validPattern("""Lang""",Lang,"""[a-z]{2,3}"""))|

---

## Value ISO20022.Cafr001001.LocalData14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cafr001001.AdditionalData1>||XmlElement()||
|+|LglCorpNm|String||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|NcodgFrmt|String||XmlElement()||
|+|Lang|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validPattern("""Lang""",Lang,"""[a-z]{2,3}"""))|

---

## Value ISO20022.Cafr001001.LocalData16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cafr001001.AdditionalData1>||XmlElement()||
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Cafr001001.AdditionalInformation22>||XmlElement()||
|+|CrdhldrNm|ISO20022.Cafr001001.CardholderName2||XmlElement()||
|+|MldFrPstlCd|String||XmlElement()||
|+|MlngAdrUstrd|String||XmlElement()||
|+|MlngAdr|ISO20022.Cafr001001.LocalAddress1||XmlElement()||
|+|NcodgFrmt|String||XmlElement()||
|+|Lang|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(CrdhldrNm),validElement(MlngAdr),validPattern("""Lang""",Lang,"""[a-z]{2,3}"""))|

---

## Value ISO20022.Cafr001001.MACData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InitlstnVctr|String||XmlElement()||
|+|PddgMtd|String||XmlElement()||
|+|KeyIndx|String||XmlElement()||
|+|KeyPrtcn|String||XmlElement()||
|+|KeyLngth|String||XmlElement()||
|+|Algo|String||XmlElement()||
|+|DrvdInf|String||XmlElement()||
|+|KeySetIdr|String||XmlElement()||
|+|Ctrl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""InitlstnVctr""",InitlstnVctr,"""([0-9A-F][0-9A-F]){1,32}"""),validPattern("""PddgMtd""",PddgMtd,"""[0-9]{1,2}"""),validPattern("""KeyIndx""",KeyIndx,"""[0-9]{1,5}"""),validPattern("""KeyPrtcn""",KeyPrtcn,"""[0-9]{1,2}"""),validPattern("""KeyLngth""",KeyLngth,"""[0-9]{1,4}"""),validPattern("""Algo""",Algo,"""[0-9]{1,2}"""),validPattern("""DrvdInf""",DrvdInf,"""([0-9A-F][0-9A-F]){1,32}"""),validPattern("""KeySetIdr""",KeySetIdr,"""[0-9]{1,8}"""),validPattern("""Ctrl""",Ctrl,"""([0-9A-F][0-9A-F]){1}"""))|

---

## Enum ISO20022.Cafr001001.OutputFormat4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HTML|Int32||XmlEnum("""HTML""")|1|
||URLI|Int32||XmlEnum("""URLI""")|2|
||TEXT|Int32||XmlEnum("""TEXT""")|3|
||SMSI|Int32||XmlEnum("""SMSI""")|4|
||OTHP|Int32||XmlEnum("""OTHP""")|5|
||OTHN|Int32||XmlEnum("""OTHN""")|6|
||MREF|Int32||XmlEnum("""MREF""")|7|
||FLNM|Int32||XmlEnum("""FLNM""")|8|

---

## Value ISO20022.Cafr001001.Parameter13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MskGnrtrAlgo|ISO20022.Cafr001001.AlgorithmIdentification26||XmlElement()||
|+|DgstAlgo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MskGnrtrAlgo))|

---

## Value ISO20022.Cafr001001.Parameter14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
|+|NcrptnFrmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cafr001001.Parameter7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cafr001001.PartyIdentification286


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LclData|ISO20022.Cafr001001.LocalData14||XmlElement()||
|+|AddtlId|global::System.Collections.Generic.List<ISO20022.Cafr001001.AdditionalData1>||XmlElement()||
|+|LglCorpNm|String||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Assgnr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LclData),validList("""AddtlId""",AddtlId),validElement(AddtlId),validPattern("""Ctry""",Ctry,"""[0-9]{3,3}"""),validPattern("""Id""",Id,"""[0-9]{1,11}"""))|

---

## Enum ISO20022.Cafr001001.PartyType17Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGNT|Int32||XmlEnum("""AGNT""")|1|
||CISP|Int32||XmlEnum("""CISP""")|2|
||CISS|Int32||XmlEnum("""CISS""")|3|
||ACQP|Int32||XmlEnum("""ACQP""")|4|
||ACQR|Int32||XmlEnum("""ACQR""")|5|
||OTHP|Int32||XmlEnum("""OTHP""")|6|
||OTHN|Int32||XmlEnum("""OTHN""")|7|

---

## Enum ISO20022.Cafr001001.PartyType18Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGNT|Int32||XmlEnum("""AGNT""")|1|
||CSCH|Int32||XmlEnum("""CSCH""")|2|
||CISS|Int32||XmlEnum("""CISS""")|3|
||ACQR|Int32||XmlEnum("""ACQR""")|4|

---

## Enum ISO20022.Cafr001001.PartyType19Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHP|Int32||XmlEnum("""OTHP""")|1|
||OTHN|Int32||XmlEnum("""OTHN""")|2|
||AGNT|Int32||XmlEnum("""AGNT""")|3|
||CISP|Int32||XmlEnum("""CISP""")|4|
||CISS|Int32||XmlEnum("""CISS""")|5|
||ACQP|Int32||XmlEnum("""ACQP""")|6|
||ACQR|Int32||XmlEnum("""ACQR""")|7|
||ACCP|Int32||XmlEnum("""ACCP""")|8|

---

## Enum ISO20022.Cafr001001.PartyType26Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHP|Int32||XmlEnum("""OTHP""")|1|
||OTHN|Int32||XmlEnum("""OTHN""")|2|
||AGNT|Int32||XmlEnum("""AGNT""")|3|
||DLIS|Int32||XmlEnum("""DLIS""")|4|
||CISS|Int32||XmlEnum("""CISS""")|5|
||ICCA|Int32||XmlEnum("""ICCA""")|6|
||ACQR|Int32||XmlEnum("""ACQR""")|7|
||ACCP|Int32||XmlEnum("""ACCP""")|8|

---

## Enum ISO20022.Cafr001001.PartyType32Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHP|Int32||XmlEnum("""OTHP""")|1|
||OTHN|Int32||XmlEnum("""OTHN""")|2|
||ISUR|Int32||XmlEnum("""ISUR""")|3|
||AGNT|Int32||XmlEnum("""AGNT""")|4|
||ACQR|Int32||XmlEnum("""ACQR""")|5|

---

## Value ISO20022.Cafr001001.ProgrammeMode5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlId|global::System.Collections.Generic.List<ISO20022.Cafr001001.AdditionalData1>||XmlElement()||
|+|ApldId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlId""",AddtlId),validElement(AddtlId))|

---

## Value ISO20022.Cafr001001.ProtectedData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdData|ISO20022.Cafr001001.EncryptedData2||XmlElement()||
|+|EnvlpdData|ISO20022.Cafr001001.EnvelopedData12||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcrptdData),validElement(EnvlpdData))|

---

## Enum ISO20022.Cafr001001.ProtectionMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TEEN|Int32||XmlEnum("""TEEN""")|1|
||SOFT|Int32||XmlEnum("""SOFT""")|2|
||SNCL|Int32||XmlEnum("""SNCL""")|3|
||SELM|Int32||XmlEnum("""SELM""")|4|
||OTHP|Int32||XmlEnum("""OTHP""")|5|
||OTHN|Int32||XmlEnum("""OTHN""")|6|

---

## Value ISO20022.Cafr001001.Recipient5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeyIdr|ISO20022.Cafr001001.KEKIdentifier2||XmlElement()||
|+|IssrAndSrlNb|ISO20022.Cafr001001.IssuerAndSerialNumber1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyIdr),validElement(IssrAndSrlNb),validChoice(KeyIdr,IssrAndSrlNb))|

---

## Value ISO20022.Cafr001001.Recipient7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeyIdr|ISO20022.Cafr001001.KEKIdentifier6||XmlElement()||
|+|KEK|ISO20022.Cafr001001.KEK6||XmlElement()||
|+|KeyTrnsprt|ISO20022.Cafr001001.KeyTransport6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyIdr),validElement(KEK),validElement(KeyTrnsprt),validChoice(KeyIdr,KEK,KeyTrnsprt))|

---

## Value ISO20022.Cafr001001.Reconciliation4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ChckptRef|String||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cafr001001.RelativeDistinguishedName1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AttrVal|String||XmlElement()||
|+|AttrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cafr001001.ReportedFraud4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InvstgtnSts|String||XmlElement()||
|+|Arrst|String||XmlElement()||
|+|CaseRef|String||XmlElement()||
|+|CaseLctrNb|String||XmlElement()||
|+|MktSgmt|String||XmlElement()||
|+|SubmitrCaseRef|String||XmlElement()||
|+|ConfRptgDt|DateTime||XmlElement()||
|+|CrdhldrRptgDt|DateTime||XmlElement()||
|+|CmprmsdCrdntl|global::System.Collections.Generic.List<String>||XmlElement()||
|+|OthrRptgNtty|String||XmlElement()||
|+|RptgNtty|String||XmlElement()||
|+|OthrActn|String||XmlElement()||
|+|Actn|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cafr001001.SettlementService6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Cafr001001.AdditionalData1>||XmlElement()||
|+|RptgNttyId|String||XmlElement()||
|+|RptgNttyTp|String||XmlElement()||
|+|CutOffTm|DateTime||XmlElement()||
|+|Prd|String||XmlElement()||
|+|Tm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|Dfrrd|String||XmlElement()||
|+|ReqdDt|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf))|

---

## Enum ISO20022.Cafr001001.StorageLocation1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TPWL|Int32||XmlEnum("""TPWL""")|1|
||OTHP|Int32||XmlEnum("""OTHP""")|2|
||OTHN|Int32||XmlEnum("""OTHN""")|3|
||ONFL|Int32||XmlEnum("""ONFL""")|4|
||ISWL|Int32||XmlEnum("""ISWL""")|5|
||DVCE|Int32||XmlEnum("""DVCE""")|6|
||CAWL|Int32||XmlEnum("""CAWL""")|7|

---

## Value ISO20022.Cafr001001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Cafr001001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Cafr001001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cafr001001.Token2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cafr001001.AdditionalData1>||XmlElement()||
|+|OthrPrtcnMtd|String||XmlElement()||
|+|PrtcnMtd|String||XmlElement()||
|+|OthrStorgLctn|String||XmlElement()||
|+|StorgLctn|String||XmlElement()||
|+|TknInittdInd|String||XmlElement()||
|+|TknAssrncMtd|String||XmlElement()||
|+|TknAssrncData|String||XmlElement()||
|+|TknRqstrId|String||XmlElement()||
|+|TknXpryDt|String||XmlElement()||
|+|PmtTkn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validPattern("""TknAssrncMtd""",TknAssrncMtd,"""[0-9]{1,2}"""),validPattern("""TknRqstrId""",TknRqstrId,"""[0-9]{1,11}"""),validPattern("""PmtTkn""",PmtTkn,"""[0-9]{1,19}"""))|

---

## Value ISO20022.Cafr001001.Traceability10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTmOut|DateTime||XmlElement()||
|+|DtTmIn|DateTime||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Assgnr|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,3}"""))|

---

## Enum ISO20022.Cafr001001.TypeOfAmount21Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MNIF|Int32||XmlEnum("""MNIF""")|1|
||MXIF|Int32||XmlEnum("""MXIF""")|2|
||CSIF|Int32||XmlEnum("""CSIF""")|3|
||FEEA|Int32||XmlEnum("""FEEA""")|4|
||OTHP|Int32||XmlEnum("""OTHP""")|5|
||OTHN|Int32||XmlEnum("""OTHN""")|6|
||FEEP|Int32||XmlEnum("""FEEP""")|7|
||INTC|Int32||XmlEnum("""INTC""")|8|

---

## Enum ISO20022.Cafr001001.UserInterface8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHN|Int32||XmlEnum("""OTHN""")|1|
||OTHP|Int32||XmlEnum("""OTHP""")|2|
||LOGF|Int32||XmlEnum("""LOGF""")|3|
||FILE|Int32||XmlEnum("""FILE""")|4|
||DSPU|Int32||XmlEnum("""DSPU""")|5|

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

