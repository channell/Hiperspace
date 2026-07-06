# cain.014.001.03
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Cain014001.AccountDetails4 {
        + Id  : String
        + Tp  : String
        + Nm  : String
    }
    class ISO20022.Cain014001.Action16 {
        + CertId  : String
        + Sgntr  : String
        + Lang  : String
        + Cntt  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + OthrFrmt  : String
        + Frmt  : String
        + Ctct  : ISO20022.Cain014001.ContactPersonal1
        + DstnAdr  : String
        + OthrDstnTp  : String
        + DstnTp  : String
        + OthrDstn  : String
        + Dstn  : String
        + OthrTp  : String
        + Tp  : String
    }
    ISO20022.Cain014001.Action16 *-- ISO20022.Cain014001.AdditionalData1
    ISO20022.Cain014001.Action16 *-- ISO20022.Cain014001.ContactPersonal1
    class ISO20022.Cain014001.ActionDestination1Code {
        POFS = 1
        PECR = 2
        OTHP = 3
        OTHN = 4
        MOBL = 5
        FILE = 6
    }
    class ISO20022.Cain014001.ActionType14Code {
        SNDM = 1
        PRNT = 2
        FUPD = 3
        DISP = 4
        DEAC = 5
        ACTV = 6
        SIGN = 7
        OTHP = 8
        OTHN = 9
        TRXR = 10
        TRCK = 11
        VIPM = 12
        CHDV = 13
        CPTR = 14
        CNAS = 15
        CNTA = 16
        CNIS = 17
        CNTI = 18
    }
    class ISO20022.Cain014001.ActionType8Code {
        STUA = 1
        OTHP = 2
        OTHN = 3
        RFRL = 4
        NDCL = 5
        RQID = 6
        DCLN = 7
        CPTR = 8
        BLCK = 9
        APPV = 10
    }
    class ISO20022.Cain014001.AdditionalAmounts4 {
        + Desc  : String
        + CdtDbt  : String
        + Ccy  : String
        + Amt  : Decimal
        + OthrTp  : String
        + Tp  : String
    }
    class ISO20022.Cain014001.AdditionalData1 {
        + Val  : String
        + Tp  : String
    }
    class ISO20022.Cain014001.AdditionalData2 {
        + Dtls  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + Tp  : String
    }
    ISO20022.Cain014001.AdditionalData2 *-- ISO20022.Cain014001.AdditionalData1
    class ISO20022.Cain014001.AdditionalFee3 {
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
    class ISO20022.Cain014001.AdditionalRiskData1 {
        + Val  : String
        + Tp  : String
    }
    class ISO20022.Cain014001.AdditionalService2 {
        + SvcDtl  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + OthrRslt  : String
        + Rslt  : String
        + OthrTp  : String
        + Tp  : String
    }
    ISO20022.Cain014001.AdditionalService2 *-- ISO20022.Cain014001.AdditionalData1
    class ISO20022.Cain014001.AdditionalServiceResult1Code {
        PERF = 1
        OTHP = 2
        OTHN = 3
        NOSP = 4
        NOPF = 5
    }
    class ISO20022.Cain014001.AdditionalServiceType2Code {
        BALC = 1
        PRST = 2
        OTHP = 3
        OTHN = 4
        LOYT = 5
        INTT = 6
        INTP = 7
        DCCV = 8
        CSHB = 9
        CACT = 10
    }
    class ISO20022.Cain014001.Address2 {
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
    class ISO20022.Cain014001.Algorithm13Code {
        EA5C = 1
        EA9C = 2
        UKA1 = 3
        UKPT = 4
        DKP9 = 5
        E3DC = 6
        EA2C = 7
    }
    class ISO20022.Cain014001.Algorithm20Code {
        HS51 = 1
        HS38 = 2
        HS25 = 3
    }
    class ISO20022.Cain014001.Algorithm23Code {
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
    class ISO20022.Cain014001.Algorithm5Code {
        HS51 = 1
        HS38 = 2
        HS25 = 3
    }
    class ISO20022.Cain014001.Algorithm7Code {
        RSAO = 1
        ERSA = 2
    }
    class ISO20022.Cain014001.Algorithm8Code {
        MGF1 = 1
    }
    class ISO20022.Cain014001.AlgorithmIdentification25 {
        + Param  : ISO20022.Cain014001.Parameter7
        + Algo  : String
    }
    ISO20022.Cain014001.AlgorithmIdentification25 *-- ISO20022.Cain014001.Parameter7
    class ISO20022.Cain014001.AlgorithmIdentification26 {
        + Param  : String
        + Algo  : String
    }
    class ISO20022.Cain014001.AlgorithmIdentification27 {
        + Param  : ISO20022.Cain014001.Parameter13
        + Algo  : String
    }
    ISO20022.Cain014001.AlgorithmIdentification27 *-- ISO20022.Cain014001.Parameter13
    class ISO20022.Cain014001.AlgorithmIdentification28 {
        + Param  : ISO20022.Cain014001.Parameter14
        + Algo  : String
    }
    ISO20022.Cain014001.AlgorithmIdentification28 *-- ISO20022.Cain014001.Parameter14
    class ISO20022.Cain014001.AttributeType1Code {
        CATT = 1
        OUAT = 2
        OATT = 3
        LATT = 4
        CNAT = 5
    }
    class ISO20022.Cain014001.Authority1 {
        + Nm  : String
        + CtrySubDvsnMnrNm  : String
        + CtrySubDvsnMjrNm  : String
        + CtrySubDvsnMnr  : String
        + CtrySubDvsnMjr  : String
        + Ctry  : String
    }
    class ISO20022.Cain014001.BatchManagementInformation1 {
        + MsgChcksmInptVal  : String
        + MsgSeqNb  : String
        + BtchId  : String
        + ColltnId  : String
    }
    class ISO20022.Cain014001.BytePadding1Code {
        RAND = 1
        NULL = 2
        NULG = 3
        NUL8 = 4
        LNGT = 5
    }
    class ISO20022.Cain014001.CardData13 {
        + AddtlCardData  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + PrtflIdr  : String
        + PdctSubTp  : String
        + PdctTp  : String
        + CtryCd  : String
        + PANAcctRg  : String
        + PmtAcctRef  : String
        + Trck2  : ISO20022.Cain014001.Track2Data1Choice
        + XpryDt  : String
        + FctvDt  : String
        + CardSeqNb  : String
        + PrtctdPAN  : String
        + PAN  : String
    }
    ISO20022.Cain014001.CardData13 *-- ISO20022.Cain014001.AdditionalData1
    ISO20022.Cain014001.CardData13 *-- ISO20022.Cain014001.Track2Data1Choice
    class ISO20022.Cain014001.CardDataReading10Code {
        DFLE = 1
        KEEN = 2
        OTHP = 3
        UNSP = 4
        RFID = 5
        OTHN = 6
        OPTC = 7
        MSIP = 8
        OCRR = 9
        MLEY = 10
        MICR = 11
        ICCY = 12
        MGST = 13
        ICPY = 14
    }
    class ISO20022.Cain014001.CardDataReading9Code {
        ICCY = 1
        TOKN = 2
        MBNK = 3
        CDFL = 4
        OPTC = 5
        ICPY = 6
        KEEN = 7
        CAMR = 8
        OTHP = 9
        OTHN = 10
        UNKW = 11
    }
    class ISO20022.Cain014001.CardDataWriting1Code {
        OTHP = 1
        UNSP = 2
        OTHN = 3
        MSIP = 4
        ICCY = 5
        MGST = 6
        ICPY = 7
    }
    class ISO20022.Cain014001.CardDepositType1Code {
        CASH = 1
        CHEC = 2
        ENVL = 3
        OTHN = 4
        OTHP = 5
    }
    class ISO20022.Cain014001.CardReadingCapabilities1 {
        + OthrCpblty  : String
        + Cpblty  : String
    }
    class ISO20022.Cain014001.CardWritingCapabilities1 {
        + OthrCpblty  : String
        + Cpblty  : String
    }
    class ISO20022.Cain014001.Cardholder22 {
        + LclData  : ISO20022.Cain014001.LocalData13
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + HghVal  : String
        + DtOfBirth  : DateTime
        + CtctInf  : ISO20022.Cain014001.ContactPersonal1
        + Adr  : ISO20022.Cain014001.Address2
        + Id  : global::System.Collections.Generic.List~ISO20022.Cain014001.Credentials3~
        + Nm  : ISO20022.Cain014001.CardholderName3
    }
    ISO20022.Cain014001.Cardholder22 *-- ISO20022.Cain014001.LocalData13
    ISO20022.Cain014001.Cardholder22 *-- ISO20022.Cain014001.AdditionalData1
    ISO20022.Cain014001.Cardholder22 *-- ISO20022.Cain014001.ContactPersonal1
    ISO20022.Cain014001.Cardholder22 *-- ISO20022.Cain014001.Address2
    ISO20022.Cain014001.Cardholder22 *-- ISO20022.Cain014001.Credentials3
    ISO20022.Cain014001.Cardholder22 *-- ISO20022.Cain014001.CardholderName3
    class ISO20022.Cain014001.CardholderName2 {
        + LastNm  : String
        + MddlNm  : String
        + GvnNm  : String
        + Nm  : String
    }
    class ISO20022.Cain014001.CardholderName3 {
        + LastNm  : String
        + MddlNm  : String
        + GvnNm  : String
        + Nm  : String
    }
    class ISO20022.Cain014001.CardholderVerificationCapabilities1 {
        + OthrCpblty  : String
        + Cpblty  : String
    }
    class ISO20022.Cain014001.CardholderVerificationCapability5Code {
        NOOP = 1
        NOPN = 2
        PKIS = 3
        VORN = 4
        UNSP = 5
        SIGN = 6
        OTHP = 7
        OTHN = 8
        NPIN = 9
        NBIO = 10
        FEPN = 11
        FCPN = 12
        FDSG = 13
        FBIO = 14
        FBIG = 15
        NOVF = 16
        APKI = 17
    }
    class ISO20022.Cain014001.CertificateIssuer1 {
        + RltvDstngshdNm  : global::System.Collections.Generic.List~ISO20022.Cain014001.RelativeDistinguishedName1~
    }
    ISO20022.Cain014001.CertificateIssuer1 *-- ISO20022.Cain014001.RelativeDistinguishedName1
    class ISO20022.Cain014001.ContactBusiness1 {
        + Lang  : String
        + URL  : String
        + Fax  : String
        + Email  : String
        + TollFreePhne  : String
        + PrprtyPhne  : String
        + Phne  : String
        + LastNm  : String
        + MddlNm  : String
        + GvnNm  : String
        + Nm  : String
    }
    class ISO20022.Cain014001.ContactPersonal1 {
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
    class ISO20022.Cain014001.ContentInformationType41 {
        + MAC  : String
        + MACData  : ISO20022.Cain014001.MACData1
    }
    ISO20022.Cain014001.ContentInformationType41 *-- ISO20022.Cain014001.MACData1
    class ISO20022.Cain014001.ContentType2Code {
        AUTH = 1
        DGST = 2
        EVLP = 3
        SIGN = 4
        DATA = 5
    }
    class ISO20022.Cain014001.ContentType3Code {
        IFSE = 1
        EVLP = 2
    }
    class ISO20022.Cain014001.Context19 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + RctDstn  : String
        + RctTp  : global::System.Collections.Generic.List~String~
        + RctReq  : String
        + OthrGoodAndSvcDlvrySchdl  : String
        + GoodAndSvcDlvrySchdl  : String
        + OthrGoodAndSvcDlvryChanl  : String
        + GoodAndSvcDlvryChanl  : String
        + GoodAndSvcsOthrSubTp  : String
        + GoodAndSvcsSubTp  : String
        + GoodsAndSvcsTp  : String
        + SaleRefNb  : String
        + ECRId  : String
        + DtAntcptd  : DateTime
        + CaptrDt  : DateTime
        + AuthntcnOutg  : String
        + MgntcStrpFllbck  : String
        + OthrICCFllbckRsnCd  : String
        + ICCFllbckRsnCd  : String
        + ICCFllbck  : String
        + PINNtryBpss  : String
        + PINPadInprtv  : String
        + PmtCrdntlMrchntRltsh  : String
        + StorgLctn  : String
        + TempScrCardDataReusd  : String
        + OthrSctyChrtcs  : String
        + SctyChrtcs  : global::System.Collections.Generic.List~String~
        + PrtlApprvlSpprtd  : String
        + SpltPmt  : String
        + PrtlShipmnt  : String
        + DfrrdDlvry  : String
        + LatePresntmnt  : String
        + DelydAuthstn  : String
        + ReSubmissn  : String
        + Reauthstn  : String
        + NoShow  : String
        + DelydChrgs  : String
        + TxInitr  : String
        + CstmrCnsnt  : String
        + FnlAuthstn  : String
        + MOTOCd  : String
        + EComrcData  : global::System.Collections.Generic.List~ISO20022.Cain014001.ECommerceData1~
        + EComrcIndApld  : String
        + EComrcIndPropsd  : String
        + EComrc  : String
        + UattnddLvlCtgy  : String
        + Attndd  : String
        + Trnst  : String
        + TrnspndrInittd  : String
        + CrdhldrActvtd  : String
        + CrdhldrPres  : String
        + CardPres  : String
        + OthrMrchntCtgy  : String
        + MrchntCtgySpcfcData  : String
        + MrchntCtgyCd  : String
        + OthrQRCdPresntmntMd  : String
        + QRCdPresntmntMd  : String
        + OthrCardDataNtryMd  : String
        + CardDataNtryMd  : String
    }
    ISO20022.Cain014001.Context19 *-- ISO20022.Cain014001.AdditionalData1
    ISO20022.Cain014001.Context19 *-- ISO20022.Cain014001.ECommerceData1
    class ISO20022.Cain014001.Context24 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + RctDstn  : String
        + RctTp  : global::System.Collections.Generic.List~String~
        + RctReq  : String
        + OthrGoodAndSvcDlvrySchdl  : String
        + GoodAndSvcDlvrySchdl  : String
        + OthrGoodAndSvcDlvryChanl  : String
        + GoodAndSvcDlvryChanl  : String
        + GoodAndSvcsOthrSubTp  : String
        + GoodAndSvcsSubTp  : String
        + GoodsAndSvcsTp  : String
        + SaleRefNb  : String
        + DtAntcptd  : DateTime
        + CaptrDt  : DateTime
        + PmtCrdntlMrchntRltsh  : String
        + AuthntcnOutg  : String
        + StorgLctn  : String
        + OthrSctyChrtcs  : String
        + SctyChrtcs  : global::System.Collections.Generic.List~String~
        + PrtlApprvlSpprtd  : String
        + SpltPmt  : String
        + PrtlShipmnt  : String
        + DfrrdDlvry  : String
        + LatePresntmnt  : String
        + DelydAuthstn  : String
        + ReSubmissn  : String
        + Reauthstn  : String
        + NoShow  : String
        + DelydChrgs  : String
        + TxInitr  : String
        + MOTOCd  : String
        + EComrcData  : global::System.Collections.Generic.List~ISO20022.Cain014001.ECommerceData1~
        + EComrcIndApld  : String
        + EComrcIndPropsd  : String
        + EComrc  : String
        + UattnddLvlCtgy  : String
        + Attndd  : String
        + Trnst  : String
        + TrnspndrInittd  : String
        + CrdhldrActvtd  : String
        + CrdhldrPres  : String
        + CardPres  : String
        + OthrMrchntCtgy  : String
        + MrchntCtgySpcfcData  : String
        + MrchntCtgyCd  : String
        + OthrQRCdPresntmntMd  : String
        + QRCdPresntmntMd  : String
        + OthrCardDataNtryMd  : String
        + CardDataNtryMd  : String
    }
    ISO20022.Cain014001.Context24 *-- ISO20022.Cain014001.AdditionalData1
    ISO20022.Cain014001.Context24 *-- ISO20022.Cain014001.ECommerceData1
    class ISO20022.Cain014001.CorporateTaxType1Code {
        CORP = 1
        OTHR = 2
        SMBS = 3
    }
    class ISO20022.Cain014001.Credentials3 {
        + Assgnr  : ISO20022.Cain014001.Authority1
        + XpryDt  : String
        + Val  : String
        + SubTp  : String
        + OthrTp  : String
        + Tp  : String
    }
    ISO20022.Cain014001.Credentials3 *-- ISO20022.Cain014001.Authority1
    class ISO20022.Cain014001.CreditDebit3Code {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Cain014001.CustomerDevice5 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + Prvdr  : String
        + OprgSysBld  : String
        + OprgSysVrsn  : String
        + OthrOprgSysTp  : String
        + OprgSysTp  : String
        + OprgSysId  : String
        + DvcId  : global::System.Collections.Generic.List~ISO20022.Cain014001.DeviceIdentification1~
        + DvcNmNrmlzd  : String
        + DvcNm  : String
        + Email  : String
        + IPAdr  : String
        + LctnCtryCd  : String
        + GeogcLctn  : String
        + Phne  : String
        + Lang  : String
        + OthrTp  : String
        + Tp  : String
        + ManfctrMdlId  : String
        + Manfctr  : String
    }
    ISO20022.Cain014001.CustomerDevice5 *-- ISO20022.Cain014001.AdditionalData1
    ISO20022.Cain014001.CustomerDevice5 *-- ISO20022.Cain014001.DeviceIdentification1
    class ISO20022.Cain014001.CustomerDeviceType2Code {
        UNKW = 1
        STIC = 2
        KFOB = 3
        JEWL = 4
        GAMB = 5
        WATC = 6
        WRBL = 7
        VHCL = 8
        EMBD = 9
        SECR = 10
        NSCR = 11
        TBLT = 12
        PECR = 13
        OTHP = 14
        OTHN = 15
        MOBL = 16
    }
    class ISO20022.Cain014001.DateTime2 {
        + Tm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Cain014001.DepositDetails3 {
        + CdtDbt  : String
        + Amt  : Decimal
        + OthrTp  : String
        + Tp  : String
    }
    class ISO20022.Cain014001.DetailedAmount22 {
        + Desc  : String
        + RcncltnAmt  : Decimal
        + CrdhldrBllgAmt  : Decimal
        + Amt  : Decimal
        + CdtDbt  : String
        + OthrTp  : String
        + Tp  : String
    }
    class ISO20022.Cain014001.DeviceIdentification1 {
        + Assgnr  : String
        + Id  : String
        + OthrTp  : String
        + Tp  : String
    }
    class ISO20022.Cain014001.DeviceIdentificationType1Code {
        SENU = 1
        SEID = 2
        OTHP = 3
        OTHN = 4
        IMEI = 5
    }
    class ISO20022.Cain014001.DisplayCapabilities6 {
        + AvlblLang  : global::System.Collections.Generic.List~String~
        + LineWidth  : Decimal
        + NbOfLines  : Decimal
        + AvlblFrmt  : global::System.Collections.Generic.List~String~
        + Dstn  : String
    }
    class ISO20022.Cain014001.DisputeData4 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + ChrgbckElgblty  : String
        + RjctRsn  : global::System.Collections.Generic.List~String~
        + DcmnttnSts  : String
        + Ref  : global::System.Collections.Generic.List~ISO20022.Cain014001.DisputeReference1~
        + Prtl  : String
        + Sts  : String
        + Cond  : String
        + Cycl  : String
    }
    ISO20022.Cain014001.DisputeData4 *-- ISO20022.Cain014001.AdditionalData1
    ISO20022.Cain014001.DisputeData4 *-- ISO20022.Cain014001.DisputeReference1
    class ISO20022.Cain014001.DisputeDocumentation1 {
        + Val  : String
        + Tp  : String
        + OthrFrmt  : String
        + Frmt  : String
    }
    class ISO20022.Cain014001.DisputeIdentification1 {
        + Id  : String
        + Tp  : String
    }
    class ISO20022.Cain014001.DisputeReference1 {
        + DsptId  : global::System.Collections.Generic.List~ISO20022.Cain014001.DisputeIdentification1~
        + OthrAssgnrNtty  : String
        + AssgnrNtty  : String
    }
    ISO20022.Cain014001.DisputeReference1 *-- ISO20022.Cain014001.DisputeIdentification1
    class ISO20022.Cain014001.ECommerceData1 {
        + Val  : String
        + Tp  : String
    }
    class ISO20022.Cain014001.EncryptedContent8 {
        + NcrptdDataElmt  : global::System.Collections.Generic.List~ISO20022.Cain014001.EncryptedDataElement2~
        + CnttNcrptnAlgo  : ISO20022.Cain014001.AlgorithmIdentification25
        + CnttTp  : String
    }
    ISO20022.Cain014001.EncryptedContent8 *-- ISO20022.Cain014001.EncryptedDataElement2
    ISO20022.Cain014001.EncryptedContent8 *-- ISO20022.Cain014001.AlgorithmIdentification25
    class ISO20022.Cain014001.EncryptedData2 {
        + NcrptdElmt  : global::System.Collections.Generic.List~ISO20022.Cain014001.EncryptedDataElement2~
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
    ISO20022.Cain014001.EncryptedData2 *-- ISO20022.Cain014001.EncryptedDataElement2
    class ISO20022.Cain014001.EncryptedData2Choice {
        + HexBinry  : String
        + Binry  : String
    }
    class ISO20022.Cain014001.EncryptedDataElement2 {
        + OthrClearTxtFrmt  : String
        + ClearTxtFrmt  : String
        + Data  : ISO20022.Cain014001.EncryptedData2Choice
        + Id  : String
    }
    ISO20022.Cain014001.EncryptedDataElement2 *-- ISO20022.Cain014001.EncryptedData2Choice
    class ISO20022.Cain014001.EncryptedDataFormat1Code {
        OTHP = 1
        OTHN = 2
        HEXF = 3
        EBCD = 4
        BINF = 5
        ASCI = 6
    }
    class ISO20022.Cain014001.EncryptionFormat3Code {
        CBCE = 1
        CTCE = 2
        TR31 = 3
        TR34 = 4
    }
    class ISO20022.Cain014001.Endpoint1Code {
        OTHN = 1
        OTHP = 2
        ORIG = 3
        DEST = 4
    }
    class ISO20022.Cain014001.EnvelopedData12 {
        + NcrptdCntt  : ISO20022.Cain014001.EncryptedContent8
        + Rcpt  : global::System.Collections.Generic.List~ISO20022.Cain014001.Recipient7Choice~
        + Vrsn  : Decimal
    }
    ISO20022.Cain014001.EnvelopedData12 *-- ISO20022.Cain014001.EncryptedContent8
    ISO20022.Cain014001.EnvelopedData12 *-- ISO20022.Cain014001.Recipient7Choice
    class ISO20022.Cain014001.ErrorDetails3 {
        + DataElmtInErr  : global::System.Collections.Generic.List~String~
        + Desc  : String
        + Cd  : String
        + OthrTp  : String
        + Tp  : String
    }
    class ISO20022.Cain014001.ExchangeRateAgreementType1Code {
        SPOT = 1
        OTHP = 2
        OTHN = 3
        NORM = 4
        FWCT = 5
    }
    class ISO20022.Cain014001.ExchangeRateInformation5 {
        + RateLckApld  : String
        + RateLckElgbl  : String
        + RateLckReqd  : String
        + OthrAgrmtTp  : String
        + AgrmtTp  : String
        + OthrRateTp  : String
        + RateTp  : String
        + Rate  : Decimal
        + BaseCcyCd  : String
        + CntrCcyCd  : String
        + OthrEndPt  : String
        + EndPt  : String
        + Tm  : DateTime
        + Dt  : DateTime
        + Id  : String
        + Prvdr  : String
    }
    class ISO20022.Cain014001.ExchangeRateType2Code {
        AGRD = 1
        BUYR = 2
        MIDL = 3
        OTHN = 4
        OTHP = 5
        SELL = 6
    }
    class ISO20022.Cain014001.FinancialInstitution8 {
        + LclData  : ISO20022.Cain014001.LocalData10
        + AddtlCtct  : String
        + CstmrSvc  : String
        + Phne  : String
        + URL  : String
        + Email  : String
        + Adr  : ISO20022.Cain014001.Address2
        + Nm  : String
        + Id  : String
    }
    ISO20022.Cain014001.FinancialInstitution8 *-- ISO20022.Cain014001.LocalData10
    ISO20022.Cain014001.FinancialInstitution8 *-- ISO20022.Cain014001.Address2
    class ISO20022.Cain014001.Frequency12Code {
        WEEK = 1
        TEND = 2
        MIAN = 3
        QURT = 4
        MNTH = 5
        FRTN = 6
        DAIL = 7
        YEAR = 8
    }
    class ISO20022.Cain014001.FundingService3 {
        + ClmAssgnr  : String
        + ClmCrdntls  : String
        + FndgSrc  : global::System.Collections.Generic.List~ISO20022.Cain014001.FundingSource4~
        + Desc  : String
        + BizPurp  : String
        + Ref  : String
        + Nm  : String
        + Prvdr  : String
    }
    ISO20022.Cain014001.FundingService3 *-- ISO20022.Cain014001.FundingSource4
    class ISO20022.Cain014001.FundingSource4 {
        + Ref  : String
        + OthrTp  : String
        + Tp  : String
    }
    class ISO20022.Cain014001.FundingSourceType3Code {
        LOYT = 1
        LCDT = 2
        PRPD = 3
        CHQE = 4
        CURR = 5
        DBAC = 6
        EPRS = 7
        CDBT = 8
        CRDT = 9
        CASH = 10
        UVRL = 11
        SVNG = 12
        OTHP = 13
        OTHN = 14
    }
    class ISO20022.Cain014001.GenericIdentification183 {
        + ShrtNm  : String
        + Ctry  : String
        + Assgnr  : String
        + OthrTp  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Cain014001.GoodAndServiceDeliveryChannel1Code {
        SCSA = 1
        SCBA = 2
        OTHP = 3
        OTHN = 4
        NDEL = 5
        PULC = 6
        EDEL = 7
    }
    class ISO20022.Cain014001.GoodAndServiceDeliverySchedule1Code {
        TDDL = 1
        SDDL = 2
        ONDL = 3
        OTHP = 4
        OTHN = 5
    }
    class ISO20022.Cain014001.GoodsAndServices1Code {
        ELPH = 1
        PHYS = 2
        ELEC = 3
    }
    class ISO20022.Cain014001.GoodsAndServicesSubType1Code {
        SECS = 1
        OTHP = 2
        OTHN = 3
        FORX = 4
        CRCU = 5
    }
    class ISO20022.Cain014001.Header71 {
        + Tracblt  : global::System.Collections.Generic.List~ISO20022.Cain014001.Traceability10~
        + TracData  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + RcptPty  : ISO20022.Cain014001.GenericIdentification183
        + InitgPty  : ISO20022.Cain014001.GenericIdentification183
        + BtchMgmtInf  : ISO20022.Cain014001.BatchManagementInformation1
        + CreDtTm  : DateTime
        + ReTrnsmssnCntr  : String
        + XchgId  : String
        + PrtcolVrsn  : String
        + MsgFctn  : String
    }
    ISO20022.Cain014001.Header71 *-- ISO20022.Cain014001.Traceability10
    ISO20022.Cain014001.Header71 *-- ISO20022.Cain014001.AdditionalData1
    ISO20022.Cain014001.Header71 *-- ISO20022.Cain014001.GenericIdentification183
    ISO20022.Cain014001.Header71 *-- ISO20022.Cain014001.GenericIdentification183
    ISO20022.Cain014001.Header71 *-- ISO20022.Cain014001.BatchManagementInformation1
    class ISO20022.Cain014001.ICCFallbackReason1Code {
        TERI = 1
        OTHP = 2
        OTHN = 3
        EDIP = 4
        CIIA = 5
    }
    class ISO20022.Cain014001.IssuerAndSerialNumber1 {
        + SrlNb  : String
        + Issr  : ISO20022.Cain014001.CertificateIssuer1
    }
    ISO20022.Cain014001.IssuerAndSerialNumber1 *-- ISO20022.Cain014001.CertificateIssuer1
    class ISO20022.Cain014001.Jurisdiction2 {
        + DmstQlfctn  : String
        + DmstInd  : String
    }
    class ISO20022.Cain014001.KEK6 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Cain014001.AlgorithmIdentification28
        + KEKId  : ISO20022.Cain014001.KEKIdentifier6
        + Vrsn  : Decimal
    }
    ISO20022.Cain014001.KEK6 *-- ISO20022.Cain014001.AlgorithmIdentification28
    ISO20022.Cain014001.KEK6 *-- ISO20022.Cain014001.KEKIdentifier6
    class ISO20022.Cain014001.KEKIdentifier2 {
        + DerivtnId  : String
        + SeqNb  : Decimal
        + KeyVrsn  : String
        + KeyId  : String
    }
    class ISO20022.Cain014001.KEKIdentifier6 {
        + DerivtnId  : String
        + SeqNb  : Decimal
        + KeyVrsn  : String
        + KeyId  : String
    }
    class ISO20022.Cain014001.KeyTransport6 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Cain014001.AlgorithmIdentification27
        + RcptId  : ISO20022.Cain014001.Recipient5Choice
        + Vrsn  : Decimal
    }
    ISO20022.Cain014001.KeyTransport6 *-- ISO20022.Cain014001.AlgorithmIdentification27
    ISO20022.Cain014001.KeyTransport6 *-- ISO20022.Cain014001.Recipient5Choice
    class ISO20022.Cain014001.LifeCycleSupport1Code {
        FINC = 1
        AUTH = 2
    }
    class ISO20022.Cain014001.LocalAddress1 {
        + CtrySubDvsnMjrNm  : String
        + CtrySubDvsnMnrNm  : String
        + TwnNm  : String
        + PstlCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine2  : String
        + AdrLine1  : String
    }
    class ISO20022.Cain014001.LocalData10 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + AddtlCtct  : String
        + Adr  : ISO20022.Cain014001.LocalAddress1
        + Nm  : String
        + NcodgFrmt  : String
        + Lang  : String
    }
    ISO20022.Cain014001.LocalData10 *-- ISO20022.Cain014001.AdditionalData1
    ISO20022.Cain014001.LocalData10 *-- ISO20022.Cain014001.LocalAddress1
    class ISO20022.Cain014001.LocalData11 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + AddtlCtct  : String
        + AddtlAdr  : String
        + Adr  : ISO20022.Cain014001.LocalAddress1
        + NmAndLctn  : String
        + LglCorpNm  : String
        + ShrtNm  : String
        + NcodgFrmt  : String
        + Lang  : String
    }
    ISO20022.Cain014001.LocalData11 *-- ISO20022.Cain014001.AdditionalData1
    ISO20022.Cain014001.LocalData11 *-- ISO20022.Cain014001.LocalAddress1
    class ISO20022.Cain014001.LocalData13 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + Adr  : ISO20022.Cain014001.LocalAddress1
        + Nm  : ISO20022.Cain014001.CardholderName2
        + NcodgFrmt  : String
        + Lang  : String
    }
    ISO20022.Cain014001.LocalData13 *-- ISO20022.Cain014001.AdditionalData1
    ISO20022.Cain014001.LocalData13 *-- ISO20022.Cain014001.LocalAddress1
    ISO20022.Cain014001.LocalData13 *-- ISO20022.Cain014001.CardholderName2
    class ISO20022.Cain014001.LocalData14 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + LglCorpNm  : String
        + ShrtNm  : String
        + NcodgFrmt  : String
        + Lang  : String
    }
    ISO20022.Cain014001.LocalData14 *-- ISO20022.Cain014001.AdditionalData1
    class ISO20022.Cain014001.LocalData15 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + Adr  : ISO20022.Cain014001.LocalAddress1
        + Nm  : ISO20022.Cain014001.CardholderName2
        + NcodgFrmt  : String
        + Lang  : String
    }
    ISO20022.Cain014001.LocalData15 *-- ISO20022.Cain014001.AdditionalData1
    ISO20022.Cain014001.LocalData15 *-- ISO20022.Cain014001.LocalAddress1
    ISO20022.Cain014001.LocalData15 *-- ISO20022.Cain014001.CardholderName2
    class ISO20022.Cain014001.MACData1 {
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
    class ISO20022.Cain014001.MOTO2Code {
        TPOR = 1
        MOTO = 2
        MAOR = 3
    }
    class ISO20022.Cain014001.MessageError1Code {
        ICOL = 1
        IBAT = 2
        IDRM = 3
        IDWM = 4
        DUME = 5
        ITDE = 6
        OTHN = 7
        UDFD = 8
        SECU = 9
        RDEM = 10
        PRVE = 11
        OTHP = 12
        MEPE = 13
        INMF = 14
        INME = 15
        IDEV = 16
        IDEL = 17
        IDEF = 18
    }
    class ISO20022.Cain014001.OnLineCapability2Code {
        BOTH = 1
        ONLN = 2
        OFLN = 3
    }
    class ISO20022.Cain014001.OriginalTransaction3 {
        + PrcgRslt  : ISO20022.Cain014001.ProcessingResult22
        + Dcmnttn  : global::System.Collections.Generic.List~ISO20022.Cain014001.DisputeDocumentation1~
        + DsptData  : global::System.Collections.Generic.List~ISO20022.Cain014001.DisputeData4~
        + Rcncltn  : ISO20022.Cain014001.Reconciliation4
        + AddtlFee  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalFee3~
        + SttlmSvc  : ISO20022.Cain014001.SettlementService6
        + Jursdctn  : ISO20022.Cain014001.Jurisdiction2
        + DpstDtls  : global::System.Collections.Generic.List~ISO20022.Cain014001.DepositDetails3~
        + FndsSvcs  : ISO20022.Cain014001.FundingService3
        + AddtlSvc  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalService2~
        + SpclPrgrmmQlfctn  : global::System.Collections.Generic.List~ISO20022.Cain014001.SpecialProgrammeQualification2~
        + Rsk  : global::System.Collections.Generic.List~ISO20022.Cain014001.RiskContext3~
        + Vrfctn  : global::System.Collections.Generic.List~ISO20022.Cain014001.Verification7~
        + Crdhldr  : ISO20022.Cain014001.Cardholder22
        + Wllt  : ISO20022.Cain014001.Wallet3
        + CstmrDvc  : ISO20022.Cain014001.CustomerDevice5
        + Tkn  : ISO20022.Cain014001.Token2
        + Pyee  : ISO20022.Cain014001.PartyIdentification287
        + Pyer  : ISO20022.Cain014001.PartyIdentification287
        + Cntxt  : ISO20022.Cain014001.Context19
        + POICmpnt  : global::System.Collections.Generic.List~ISO20022.Cain014001.PointOfInteractionComponent16~
        + Termnl  : ISO20022.Cain014001.Terminal9
        + Accptr  : ISO20022.Cain014001.PartyIdentification284
        + AddtlAmt  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalAmounts4~
        + TxAmts  : ISO20022.Cain014001.TransactionAmounts3
        + XchgRate  : global::System.Collections.Generic.List~ISO20022.Cain014001.ExchangeRateInformation5~
        + ConvsDtTm  : ISO20022.Cain014001.DateTime2
        + TxId  : ISO20022.Cain014001.TransactionIdentification54
        + Prgrmm  : ISO20022.Cain014001.ProgrammeMode4
        + Dstn  : ISO20022.Cain014001.PartyIdentification286
        + Issr  : ISO20022.Cain014001.PartyIdentification286
        + Rcvr  : ISO20022.Cain014001.PartyIdentification286
        + AcctTo  : ISO20022.Cain014001.AccountDetails4
        + AcctFr  : ISO20022.Cain014001.AccountDetails4
        + Card  : ISO20022.Cain014001.CardData13
        + Sndr  : ISO20022.Cain014001.PartyIdentification286
        + Acqrr  : ISO20022.Cain014001.PartyIdentification286
        + Orgtr  : ISO20022.Cain014001.PartyIdentification286
        + TxChrtcs  : ISO20022.Cain014001.OriginalTransactionCharacteristics1
    }
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.ProcessingResult22
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.DisputeDocumentation1
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.DisputeData4
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.Reconciliation4
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.AdditionalFee3
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.SettlementService6
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.Jurisdiction2
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.DepositDetails3
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.FundingService3
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.AdditionalService2
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.SpecialProgrammeQualification2
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.RiskContext3
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.Verification7
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.Cardholder22
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.Wallet3
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.CustomerDevice5
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.Token2
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.PartyIdentification287
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.PartyIdentification287
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.Context19
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.PointOfInteractionComponent16
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.Terminal9
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.PartyIdentification284
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.AdditionalAmounts4
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.TransactionAmounts3
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.ExchangeRateInformation5
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.DateTime2
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.TransactionIdentification54
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.ProgrammeMode4
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.PartyIdentification286
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.PartyIdentification286
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.PartyIdentification286
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.AccountDetails4
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.AccountDetails4
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.CardData13
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.PartyIdentification286
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.PartyIdentification286
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.PartyIdentification286
    ISO20022.Cain014001.OriginalTransaction3 *-- ISO20022.Cain014001.OriginalTransactionCharacteristics1
    class ISO20022.Cain014001.OriginalTransactionCharacteristics1 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + TxDesc  : String
        + PreAuthstnTmLmt  : String
        + AltrnMsgRsn  : global::System.Collections.Generic.List~String~
        + MsgRsn  : global::System.Collections.Generic.List~String~
        + OthrTxAttr  : String
        + TxAttr  : global::System.Collections.Generic.List~String~
        + TxSubTp  : String
        + TxTp  : String
    }
    ISO20022.Cain014001.OriginalTransactionCharacteristics1 *-- ISO20022.Cain014001.AdditionalData1
    class ISO20022.Cain014001.OutputFormat1Code {
        HTML = 1
        TEXT = 2
        MREF = 3
    }
    class ISO20022.Cain014001.OutputFormat4Code {
        HTML = 1
        URLI = 2
        TEXT = 3
        SMSI = 4
        OTHP = 5
        OTHN = 6
        MREF = 7
        FLNM = 8
    }
    class ISO20022.Cain014001.PINEntrySecurityCharacteristic1Code {
        SECH = 1
        SECS = 2
        OTHP = 3
        OTHN = 4
    }
    class ISO20022.Cain014001.POIComponentType5Code {
        SAPR = 1
        SACP = 2
        TMSP = 3
        CRTF = 4
        MRPR = 5
        OPST = 6
        DRVR = 7
        MDWR = 8
        EMVO = 9
        EMVK = 10
        APLI = 11
        SECM = 12
        DVCE = 13
        TERM = 14
        SERV = 15
        SCPR = 16
        TLPR = 17
        APPR = 18
        AQPP = 19
    }
    class ISO20022.Cain014001.Parameter13 {
        + MskGnrtrAlgo  : ISO20022.Cain014001.AlgorithmIdentification26
        + DgstAlgo  : String
    }
    ISO20022.Cain014001.Parameter13 *-- ISO20022.Cain014001.AlgorithmIdentification26
    class ISO20022.Cain014001.Parameter14 {
        + BPddg  : String
        + InitlstnVctr  : String
        + NcrptnFrmt  : String
    }
    class ISO20022.Cain014001.Parameter7 {
        + BPddg  : String
        + InitlstnVctr  : String
    }
    class ISO20022.Cain014001.PartyIdentification284 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + OwnrEthnctyTpPrvddBy  : String
        + OwnrEthnctyTp  : String
        + CertfctnTpPrvddBy  : String
        + CertfctnTp  : String
        + OwnrTpPrvddBy  : String
        + OwnrTp  : String
        + BizTpPrvddBy  : String
        + BizTp  : String
        + CorpTaxIdTp  : String
        + CorpTaxId  : String
        + LclData  : ISO20022.Cain014001.LocalData11
        + TaxRegnId  : String
        + AddtlCtct  : String
        + CstmrSvc  : String
        + PhneNb  : String
        + URLAdr  : String
        + Email  : String
        + GeogcLctn  : String
        + AddtlAdr  : String
        + Adr  : ISO20022.Cain014001.Address2
        + NmAndLctn  : String
        + AddtlId  : ISO20022.Cain014001.AdditionalData1
        + LglCorpNm  : String
        + ShrtNm  : String
        + Ctry  : String
        + Assgnr  : String
        + Id  : String
    }
    ISO20022.Cain014001.PartyIdentification284 *-- ISO20022.Cain014001.AdditionalData1
    ISO20022.Cain014001.PartyIdentification284 *-- ISO20022.Cain014001.LocalData11
    ISO20022.Cain014001.PartyIdentification284 *-- ISO20022.Cain014001.Address2
    ISO20022.Cain014001.PartyIdentification284 *-- ISO20022.Cain014001.AdditionalData1
    class ISO20022.Cain014001.PartyIdentification285 {
        + LclData  : global::System.Collections.Generic.List~ISO20022.Cain014001.LocalData14~
        + AddtlId  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + LglCorpNm  : String
        + ShrtNm  : String
        + Ctry  : String
        + Assgnr  : String
        + Id  : String
    }
    ISO20022.Cain014001.PartyIdentification285 *-- ISO20022.Cain014001.LocalData14
    ISO20022.Cain014001.PartyIdentification285 *-- ISO20022.Cain014001.AdditionalData1
    class ISO20022.Cain014001.PartyIdentification286 {
        + LclData  : ISO20022.Cain014001.LocalData14
        + AddtlId  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + LglCorpNm  : String
        + ShrtNm  : String
        + Ctry  : String
        + Assgnr  : String
        + Id  : String
    }
    ISO20022.Cain014001.PartyIdentification286 *-- ISO20022.Cain014001.LocalData14
    ISO20022.Cain014001.PartyIdentification286 *-- ISO20022.Cain014001.AdditionalData1
    class ISO20022.Cain014001.PartyIdentification287 {
        + LclData  : ISO20022.Cain014001.LocalData15
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + DtOfBirth  : DateTime
        + CtryOfBirth  : String
        + Ntlty  : String
        + Ctct  : ISO20022.Cain014001.ContactPersonal1
        + Adr  : ISO20022.Cain014001.Address2
        + Nm  : ISO20022.Cain014001.CardholderName3
        + Crdntls  : global::System.Collections.Generic.List~ISO20022.Cain014001.Credentials3~
        + Dsgnt  : String
        + Id  : String
        + FI  : ISO20022.Cain014001.FinancialInstitution8
    }
    ISO20022.Cain014001.PartyIdentification287 *-- ISO20022.Cain014001.LocalData15
    ISO20022.Cain014001.PartyIdentification287 *-- ISO20022.Cain014001.AdditionalData1
    ISO20022.Cain014001.PartyIdentification287 *-- ISO20022.Cain014001.ContactPersonal1
    ISO20022.Cain014001.PartyIdentification287 *-- ISO20022.Cain014001.Address2
    ISO20022.Cain014001.PartyIdentification287 *-- ISO20022.Cain014001.CardholderName3
    ISO20022.Cain014001.PartyIdentification287 *-- ISO20022.Cain014001.Credentials3
    ISO20022.Cain014001.PartyIdentification287 *-- ISO20022.Cain014001.FinancialInstitution8
    class ISO20022.Cain014001.PartyType17Code {
        AGNT = 1
        CISP = 2
        CISS = 3
        ACQP = 4
        ACQR = 5
        OTHP = 6
        OTHN = 7
    }
    class ISO20022.Cain014001.PartyType18Code {
        AGNT = 1
        CSCH = 2
        CISS = 3
        ACQR = 4
    }
    class ISO20022.Cain014001.PartyType19Code {
        OTHP = 1
        OTHN = 2
        AGNT = 3
        CISP = 4
        CISS = 5
        ACQP = 6
        ACQR = 7
        ACCP = 8
    }
    class ISO20022.Cain014001.PartyType20Code {
        AGNT = 1
        CISS = 2
        CRDH = 3
        ACQR = 4
        ACCP = 5
    }
    class ISO20022.Cain014001.PartyType26Code {
        OTHP = 1
        OTHN = 2
        AGNT = 3
        DLIS = 4
        CISS = 5
        ICCA = 6
        ACQR = 7
        ACCP = 8
    }
    class ISO20022.Cain014001.PartyType28Code {
        ISUR = 1
        WLPR = 2
        OTHP = 3
        OTHN = 4
        AGNT = 5
        ACQR = 6
        ACCP = 7
    }
    class ISO20022.Cain014001.PartyType32Code {
        OTHP = 1
        OTHN = 2
        ISUR = 3
        AGNT = 4
        ACQR = 5
    }
    class ISO20022.Cain014001.PartyType34Code {
        OTHP = 1
        OTHN = 2
        AGNT = 3
        CISS = 4
        CRDH = 5
        ACQR = 6
        ACCP = 7
    }
    class ISO20022.Cain014001.PartyType9Code {
        SCHP = 1
        CSCH = 2
        CISP = 3
        CISS = 4
        ACQP = 5
        ACQR = 6
    }
    class ISO20022.Cain014001.PointOfInteractionComponent16 {
        + SrlNb  : String
        + Id  : String
        + PrvdrId  : String
        + ItmNb  : String
        + Tp  : String
    }
    class ISO20022.Cain014001.ProcessingResult22 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + ErrDtl  : global::System.Collections.Generic.List~ISO20022.Cain014001.ErrorDetails3~
        + Actn  : global::System.Collections.Generic.List~ISO20022.Cain014001.Action16~
        + ActnReqrd  : String
        + TempScrCardDataReusePrtd  : String
        + ApprvlCd  : String
        + RspnCd  : String
        + RspnSrcShrtNm  : String
        + RspnSrcCtry  : String
        + RspnSrcAssgnr  : String
        + RspnSrcOthrTp  : String
        + RspnSrcTp  : String
        + RspnSrcId  : String
    }
    ISO20022.Cain014001.ProcessingResult22 *-- ISO20022.Cain014001.AdditionalData1
    ISO20022.Cain014001.ProcessingResult22 *-- ISO20022.Cain014001.ErrorDetails3
    ISO20022.Cain014001.ProcessingResult22 *-- ISO20022.Cain014001.Action16
    class ISO20022.Cain014001.ProcessingResult25 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + ApprvlCd  : String
        + RspnCd  : String
        + RspnSrcShrtNm  : String
        + RspnSrcCtry  : String
        + RspnSrcAssgnr  : String
        + RspnSrcOthrTp  : String
        + RspnSrcTp  : String
        + RspnSrcId  : String
    }
    ISO20022.Cain014001.ProcessingResult25 *-- ISO20022.Cain014001.AdditionalData1
    class ISO20022.Cain014001.ProgrammeMode4 {
        + IdSelctdBy  : String
        + AddtlId  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + ApldId  : String
        + PropsdId  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Cain014001.ProgrammeMode4 *-- ISO20022.Cain014001.AdditionalData1
    class ISO20022.Cain014001.ProgrammeMode5 {
        + AddtlId  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + ApldId  : String
    }
    ISO20022.Cain014001.ProgrammeMode5 *-- ISO20022.Cain014001.AdditionalData1
    class ISO20022.Cain014001.ProtectedData2 {
        + NcrptdData  : ISO20022.Cain014001.EncryptedData2
        + EnvlpdData  : ISO20022.Cain014001.EnvelopedData12
        + CnttTp  : String
    }
    ISO20022.Cain014001.ProtectedData2 *-- ISO20022.Cain014001.EncryptedData2
    ISO20022.Cain014001.ProtectedData2 *-- ISO20022.Cain014001.EnvelopedData12
    class ISO20022.Cain014001.ProtectionMethod1Code {
        TEEN = 1
        SOFT = 2
        SNCL = 3
        SELM = 4
        OTHP = 5
        OTHN = 6
    }
    class ISO20022.Cain014001.PurchaseIdentifierType2Code {
        TREF = 1
        TRNU = 2
        REAG = 3
        CUPO = 4
        CUOR = 5
        ORNU = 6
        PRNU = 7
        FONU = 8
        CONU = 9
        SUOR = 10
        TINU = 11
        RSNU = 12
        RENU = 13
        PUID = 14
        INNU = 15
        RELO = 16
        SUIN = 17
        OTHP = 18
        OTHN = 19
    }
    class ISO20022.Cain014001.QRCodePresentmentMode1Code {
        MPMD = 1
        OTHP = 2
        OTHN = 3
        CPMD = 4
    }
    class ISO20022.Cain014001.ReceiptType1Code {
        URID = 1
        SMSM = 2
        PAPR = 3
        OTHR = 4
        EMAL = 5
    }
    class ISO20022.Cain014001.Recipient5Choice {
        + KeyIdr  : ISO20022.Cain014001.KEKIdentifier2
        + IssrAndSrlNb  : ISO20022.Cain014001.IssuerAndSerialNumber1
    }
    ISO20022.Cain014001.Recipient5Choice *-- ISO20022.Cain014001.KEKIdentifier2
    ISO20022.Cain014001.Recipient5Choice *-- ISO20022.Cain014001.IssuerAndSerialNumber1
    class ISO20022.Cain014001.Recipient7Choice {
        + KeyIdr  : ISO20022.Cain014001.KEKIdentifier6
        + KEK  : ISO20022.Cain014001.KEK6
        + KeyTrnsprt  : ISO20022.Cain014001.KeyTransport6
    }
    ISO20022.Cain014001.Recipient7Choice *-- ISO20022.Cain014001.KEKIdentifier6
    ISO20022.Cain014001.Recipient7Choice *-- ISO20022.Cain014001.KEK6
    ISO20022.Cain014001.Recipient7Choice *-- ISO20022.Cain014001.KeyTransport6
    class ISO20022.Cain014001.RecommendationAction1 {
        + Dtls  : global::System.Collections.Generic.List~String~
        + OthrActn  : String
        + Actn  : String
    }
    class ISO20022.Cain014001.Reconciliation4 {
        + ChckptRef  : String
        + Dt  : DateTime
        + Id  : String
    }
    class ISO20022.Cain014001.RelativeDistinguishedName1 {
        + AttrVal  : String
        + AttrTp  : String
    }
    class ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 {
        + SctyTrlr  : ISO20022.Cain014001.ContentInformationType41
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Cain014001.SupplementaryData1~
        + PrtctdData  : global::System.Collections.Generic.List~ISO20022.Cain014001.ProtectedData2~
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData2~
        + PrcgRslt  : ISO20022.Cain014001.ProcessingResult25
        + RtrvlFlfmtInstrs  : global::System.Collections.Generic.List~ISO20022.Cain014001.RetrievalFulfilmentInstructions3~
        + OrgnlTx  : ISO20022.Cain014001.OriginalTransaction3
        + DsptData  : global::System.Collections.Generic.List~ISO20022.Cain014001.DisputeData4~
        + Rcncltn  : ISO20022.Cain014001.Reconciliation4
        + AddtlFee  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalFee3~
        + SttlmSvc  : ISO20022.Cain014001.SettlementService6
        + Jursdctn  : ISO20022.Cain014001.Jurisdiction2
        + SpclPrgrmmQlfctn  : global::System.Collections.Generic.List~ISO20022.Cain014001.SpecialProgrammeQualification2~
        + Wllt  : ISO20022.Cain014001.Wallet3
        + Tkn  : ISO20022.Cain014001.Token2
        + Pyee  : ISO20022.Cain014001.PartyIdentification287
        + Pyer  : ISO20022.Cain014001.PartyIdentification287
        + Cntxt  : ISO20022.Cain014001.Context24
        + Termnl  : ISO20022.Cain014001.Terminal8
        + Accptr  : ISO20022.Cain014001.PartyIdentification285
        + ConvsDtTm  : ISO20022.Cain014001.DateTime2
        + TxId  : ISO20022.Cain014001.TransactionIdentification54
        + Prgrmm  : global::System.Collections.Generic.List~ISO20022.Cain014001.ProgrammeMode5~
        + Dstn  : ISO20022.Cain014001.PartyIdentification286
        + Issr  : ISO20022.Cain014001.PartyIdentification286
        + Rcvr  : ISO20022.Cain014001.PartyIdentification286
        + Card  : ISO20022.Cain014001.CardData13
        + Sndr  : ISO20022.Cain014001.PartyIdentification286
        + Acqrr  : ISO20022.Cain014001.PartyIdentification286
        + Orgtr  : ISO20022.Cain014001.PartyIdentification286
        + TxChrtcs  : ISO20022.Cain014001.TransactionCharacteristics3
        + Hdr  : ISO20022.Cain014001.Header71
    }
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.ContentInformationType41
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.SupplementaryData1
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.ProtectedData2
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.AdditionalData2
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.ProcessingResult25
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.RetrievalFulfilmentInstructions3
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.OriginalTransaction3
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.DisputeData4
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.Reconciliation4
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.AdditionalFee3
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.SettlementService6
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.Jurisdiction2
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.SpecialProgrammeQualification2
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.Wallet3
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.Token2
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.PartyIdentification287
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.PartyIdentification287
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.Context24
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.Terminal8
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.PartyIdentification285
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.DateTime2
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.TransactionIdentification54
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.ProgrammeMode5
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.PartyIdentification286
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.PartyIdentification286
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.PartyIdentification286
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.CardData13
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.PartyIdentification286
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.PartyIdentification286
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.PartyIdentification286
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.TransactionCharacteristics3
    ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 *-- ISO20022.Cain014001.Header71
    class ISO20022.Cain014001.RetrievalFulfilmentInstructions3 {
        + Val  : String
        + Tp  : String
        + Frmt  : String
        + Trgt  : global::System.Collections.Generic.List~String~
        + Rcpt  : String
        + PstlAdr  : ISO20022.Cain014001.Address2
        + Ctct  : ISO20022.Cain014001.ContactBusiness1
        + ActlDlvryMtd  : String
        + EstblishdMtd  : global::System.Collections.Generic.List~String~
        + ReqdMtd  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Cain014001.RetrievalFulfilmentInstructions3 *-- ISO20022.Cain014001.Address2
    ISO20022.Cain014001.RetrievalFulfilmentInstructions3 *-- ISO20022.Cain014001.ContactBusiness1
    class ISO20022.Cain014001.RiskAssessment1Code {
        DONT = 1
        APPU = 2
        APPH = 3
        APPC = 4
    }
    class ISO20022.Cain014001.RiskAssessment3 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalRiskData1~
        + Rcmmndtn  : global::System.Collections.Generic.List~ISO20022.Cain014001.RecommendationAction1~
        + Cond  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + Rslt  : String
        + Rsn  : global::System.Collections.Generic.List~String~
        + HghRskTx  : String
        + Tp  : String
        + NttyShrtNm  : String
        + NttyCtry  : String
        + NttyAssgnr  : String
        + OthrNttyTp  : String
        + NttyTp  : String
        + NttyId  : String
    }
    ISO20022.Cain014001.RiskAssessment3 *-- ISO20022.Cain014001.AdditionalRiskData1
    ISO20022.Cain014001.RiskAssessment3 *-- ISO20022.Cain014001.RecommendationAction1
    ISO20022.Cain014001.RiskAssessment3 *-- ISO20022.Cain014001.AdditionalData1
    class ISO20022.Cain014001.RiskContext3 {
        + Assmnt  : global::System.Collections.Generic.List~ISO20022.Cain014001.RiskAssessment3~
        + InptData  : global::System.Collections.Generic.List~ISO20022.Cain014001.RiskInputData2~
    }
    ISO20022.Cain014001.RiskContext3 *-- ISO20022.Cain014001.RiskAssessment3
    ISO20022.Cain014001.RiskContext3 *-- ISO20022.Cain014001.RiskInputData2
    class ISO20022.Cain014001.RiskInputData2 {
        + Val  : String
        + Tp  : String
        + OthrNttyTp  : String
        + NttyTp  : String
    }
    class ISO20022.Cain014001.SecurityCharacteristics1Code {
        OTHP = 1
        OTHN = 2
        AETE = 3
        APTE = 4
        STAM = 5
        PRVN = 6
        PRAM = 7
        PRAE = 8
        PKIE = 9
        PMAC = 10
        OPNN = 11
        MPTE = 12
        METE = 13
        ETEE = 14
        CMAC = 15
        CENC = 16
        CPTE = 17
        CETE = 18
    }
    class ISO20022.Cain014001.SettlementService6 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
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
    ISO20022.Cain014001.SettlementService6 *-- ISO20022.Cain014001.AdditionalData1
    class ISO20022.Cain014001.Software1 {
        + Vrsn  : String
        + SubTp  : String
        + OthrTp  : String
        + Tp  : String
    }
    class ISO20022.Cain014001.SoftwareType1Code {
        OTHN = 1
        OTHP = 2
        APSW = 3
        MFSW = 4
        MFFW = 5
    }
    class ISO20022.Cain014001.SpecialProgrammeDetails2 {
        + Val  : String
        + Nm  : String
    }
    class ISO20022.Cain014001.SpecialProgrammeQualification2 {
        + Dtl  : global::System.Collections.Generic.List~ISO20022.Cain014001.SpecialProgrammeDetails2~
        + Prgrmm  : String
    }
    ISO20022.Cain014001.SpecialProgrammeQualification2 *-- ISO20022.Cain014001.SpecialProgrammeDetails2
    class ISO20022.Cain014001.StorageLocation1Code {
        TPWL = 1
        OTHP = 2
        OTHN = 3
        ONFL = 4
        ISWL = 5
        DVCE = 6
        CAWL = 7
    }
    class ISO20022.Cain014001.SupplementaryData1 {
        + Envlp  : ISO20022.Cain014001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Cain014001.SupplementaryData1 *-- ISO20022.Cain014001.SupplementaryDataEnvelope1
    class ISO20022.Cain014001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Cain014001.Terminal8 {
        + AddtlId  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + Id  : String
    }
    ISO20022.Cain014001.Terminal8 *-- ISO20022.Cain014001.AdditionalData1
    class ISO20022.Cain014001.Terminal9 {
        + CertfctnId  : String
        + Sftwr  : global::System.Collections.Generic.List~ISO20022.Cain014001.Software1~
        + SrlNb  : String
        + OnBrd  : String
        + OffPrmiss  : String
        + Outdr  : String
        + GeogcLctn  : String
        + IntgtnTp  : String
        + TempScrStorg  : String
        + CrdhldrVrfctnCpblty  : global::System.Collections.Generic.List~ISO20022.Cain014001.CardholderVerificationCapabilities1~
        + MsgCpblty  : global::System.Collections.Generic.List~ISO20022.Cain014001.DisplayCapabilities6~
        + OnLineCpblty  : String
        + CardCaptrCpbl  : String
        + MxScrptLngth  : Decimal
        + ApprvlCdLngth  : Decimal
        + OthrPINNtrySctyChrtc  : String
        + PINNtrySctyChrtc  : String
        + PINLngthCpblty  : Decimal
        + WrtgCpblty  : global::System.Collections.Generic.List~ISO20022.Cain014001.CardWritingCapabilities1~
        + RdngCpblty  : global::System.Collections.Generic.List~ISO20022.Cain014001.CardReadingCapabilities1~
        + OthrTp  : String
        + Tp  : String
        + AddtlId  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + Id  : String
    }
    ISO20022.Cain014001.Terminal9 *-- ISO20022.Cain014001.Software1
    ISO20022.Cain014001.Terminal9 *-- ISO20022.Cain014001.CardholderVerificationCapabilities1
    ISO20022.Cain014001.Terminal9 *-- ISO20022.Cain014001.DisplayCapabilities6
    ISO20022.Cain014001.Terminal9 *-- ISO20022.Cain014001.CardWritingCapabilities1
    ISO20022.Cain014001.Terminal9 *-- ISO20022.Cain014001.CardReadingCapabilities1
    ISO20022.Cain014001.Terminal9 *-- ISO20022.Cain014001.AdditionalData1
    class ISO20022.Cain014001.TerminalIntegrationCategory1Code {
        SSLE = 1
        MSLE = 2
        MPOI = 3
    }
    class ISO20022.Cain014001.TerminalType1Code {
        POST = 1
        OTHP = 2
        OTHN = 3
        MPOS = 4
        ATMT = 5
    }
    class ISO20022.Cain014001.Token2 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
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
    ISO20022.Cain014001.Token2 *-- ISO20022.Cain014001.AdditionalData1
    class ISO20022.Cain014001.Traceability10 {
        + DtTmOut  : DateTime
        + DtTmIn  : DateTime
        + ShrtNm  : String
        + Ctry  : String
        + Assgnr  : String
        + OthrTp  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Cain014001.Track2Data1Choice {
        + HexBinryVal  : String
        + TxtVal  : String
    }
    class ISO20022.Cain014001.TransactionAmounts3 {
        + DtldAmt  : global::System.Collections.Generic.List~ISO20022.Cain014001.DetailedAmount22~
        + RcncltnFctvXchgRate  : Decimal
        + RcncltnCcy  : String
        + RcncltnAmt  : Decimal
        + CrdhldrBllgFctvXchgRate  : Decimal
        + CrdhldrBllgCcy  : String
        + CrdhldrBllgAmt  : Decimal
        + Ccy  : String
        + Amt  : Decimal
        + AmtQlfr  : String
    }
    ISO20022.Cain014001.TransactionAmounts3 *-- ISO20022.Cain014001.DetailedAmount22
    class ISO20022.Cain014001.TransactionAttribute2Code {
        UCOF = 1
        TPUP = 2
        SUBR = 3
        RCPT = 4
        PPYT = 5
        PACP = 6
        PAUT = 7
        OTHP = 8
        OTHN = 9
        INST = 10
        FRCP = 11
        INCR = 12
        DFRD = 13
        DBRP = 14
        DBRC = 15
        CPLT = 16
        CADB = 17
        AGGR = 18
    }
    class ISO20022.Cain014001.TransactionCharacteristics3 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + TxDesc  : String
        + AltrnMsgRsn  : global::System.Collections.Generic.List~String~
        + MsgRsn  : global::System.Collections.Generic.List~String~
        + Cxl  : String
        + OthrTxAttr  : global::System.Collections.Generic.List~String~
        + TxAttr  : global::System.Collections.Generic.List~String~
        + TxSubTp  : String
        + TxTp  : String
    }
    ISO20022.Cain014001.TransactionCharacteristics3 *-- ISO20022.Cain014001.AdditionalData1
    class ISO20022.Cain014001.TransactionIdentification54 {
        + IssrRefData  : String
        + AcqrrRefNb  : String
        + AcqrrRefData  : String
        + LifeCyclIdMssng  : String
        + AuthntcnTkn  : String
        + PresntmntSeqCnt  : String
        + PresntmntSeqNb  : String
        + AuthstnSeqNb  : String
        + LifeCyclId  : String
        + LifeCyclSpprt  : String
        + RtrvlRefNb  : String
        + SysTracAudtNb  : String
        + TrnsmssnDtTm  : DateTime
        + PurchsIdr  : String
        + OthrPurchsIdrTp  : String
        + PurchsIdrTp  : String
        + TmZone  : String
        + LclTm  : DateTime
        + LclDt  : DateTime
    }
    class ISO20022.Cain014001.TransactionInitiator1Code {
        CUST = 1
        MERC = 2
    }
    class ISO20022.Cain014001.TypeOfAmount21Code {
        MNIF = 1
        MXIF = 2
        CSIF = 3
        FEEA = 4
        OTHP = 5
        OTHN = 6
        FEEP = 7
        INTC = 8
    }
    class ISO20022.Cain014001.TypeOfAmount22Code {
        RESD = 1
        PRXY = 2
        MAXI = 3
        ESTM = 4
        DPST = 5
        DFLT = 6
        ACTL = 7
    }
    class ISO20022.Cain014001.UserInterface1Code {
        MRCP = 1
        MDSP = 2
        CRCP = 3
        CDSP = 4
    }
    class ISO20022.Cain014001.UserInterface8Code {
        OTHN = 1
        OTHP = 2
        LOGF = 3
        FILE = 4
        DSPU = 5
    }
    class ISO20022.Cain014001.Verification3Code {
        ERRR = 1
        SUCC = 2
        PART = 3
        OTHP = 4
        OTHN = 5
        NOVF = 6
        NOSP = 7
        MISS = 8
        FUTA = 9
        FAIL = 10
    }
    class ISO20022.Cain014001.Verification7 {
        + AddtlInf  : String
        + RsltDtls  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + OthrRslt  : String
        + Rslt  : String
        + OthrNtty  : String
        + Ntty  : String
        + SubTp  : String
        + OthrTp  : String
        + Tp  : String
    }
    ISO20022.Cain014001.Verification7 *-- ISO20022.Cain014001.AdditionalData1
    class ISO20022.Cain014001.VerificationEntity2Code {
        ICCA = 1
        CDAD = 2
        OTHP = 3
        OTHN = 4
        ISSR = 5
        AGNT = 6
        ACQR = 7
        MERC = 8
    }
    class ISO20022.Cain014001.Wallet3 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Cain014001.AdditionalData1~
        + PrvdrAcctScore  : Decimal
        + PrvdrDvcScore  : Decimal
        + PrvdrPhneScore  : Decimal
        + PrvdrRskAssmntMdlVrsn  : String
        + PrvdrRskAssmnt  : String
        + AcctEmailAge  : Decimal
        + OthrCardDataNtryMd  : String
        + CardDataNtryMd  : String
        + AcctCtry  : String
        + SspdCrds  : Decimal
        + LastWlltChng  : Decimal
        + ActvtyIntrvl  : String
        + Actvty  : Decimal
        + DaysSncLastActvty  : Decimal
        + AcctAge  : Decimal
        + UsrAcctAge  : Decimal
        + PANAge  : Decimal
        + Prvdr  : ISO20022.Cain014001.PartyIdentification285
    }
    ISO20022.Cain014001.Wallet3 *-- ISO20022.Cain014001.AdditionalData1
    ISO20022.Cain014001.Wallet3 *-- ISO20022.Cain014001.PartyIdentification285
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

## Value ISO20022.Cain014001.AccountDetails4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Tp""",Tp,"""[0-9A-Z]{2,2}"""))|

---

## Value ISO20022.Cain014001.Action16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CertId|String||XmlElement()||
|+|Sgntr|String||XmlElement()||
|+|Lang|String||XmlElement()||
|+|Cntt|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|OthrFrmt|String||XmlElement()||
|+|Frmt|String||XmlElement()||
|+|Ctct|ISO20022.Cain014001.ContactPersonal1||XmlElement()||
|+|DstnAdr|String||XmlElement()||
|+|OthrDstnTp|String||XmlElement()||
|+|DstnTp|String||XmlElement()||
|+|OthrDstn|String||XmlElement()||
|+|Dstn|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lang""",Lang,"""[a-z]{2,3}"""),validList("""Cntt""",Cntt),validElement(Cntt),validElement(Ctct))|

---

## Enum ISO20022.Cain014001.ActionDestination1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||POFS|Int32||XmlEnum("""POFS""")|1|
||PECR|Int32||XmlEnum("""PECR""")|2|
||OTHP|Int32||XmlEnum("""OTHP""")|3|
||OTHN|Int32||XmlEnum("""OTHN""")|4|
||MOBL|Int32||XmlEnum("""MOBL""")|5|
||FILE|Int32||XmlEnum("""FILE""")|6|

---

## Enum ISO20022.Cain014001.ActionType14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SNDM|Int32||XmlEnum("""SNDM""")|1|
||PRNT|Int32||XmlEnum("""PRNT""")|2|
||FUPD|Int32||XmlEnum("""FUPD""")|3|
||DISP|Int32||XmlEnum("""DISP""")|4|
||DEAC|Int32||XmlEnum("""DEAC""")|5|
||ACTV|Int32||XmlEnum("""ACTV""")|6|
||SIGN|Int32||XmlEnum("""SIGN""")|7|
||OTHP|Int32||XmlEnum("""OTHP""")|8|
||OTHN|Int32||XmlEnum("""OTHN""")|9|
||TRXR|Int32||XmlEnum("""TRXR""")|10|
||TRCK|Int32||XmlEnum("""TRCK""")|11|
||VIPM|Int32||XmlEnum("""VIPM""")|12|
||CHDV|Int32||XmlEnum("""CHDV""")|13|
||CPTR|Int32||XmlEnum("""CPTR""")|14|
||CNAS|Int32||XmlEnum("""CNAS""")|15|
||CNTA|Int32||XmlEnum("""CNTA""")|16|
||CNIS|Int32||XmlEnum("""CNIS""")|17|
||CNTI|Int32||XmlEnum("""CNTI""")|18|

---

## Enum ISO20022.Cain014001.ActionType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||STUA|Int32||XmlEnum("""STUA""")|1|
||OTHP|Int32||XmlEnum("""OTHP""")|2|
||OTHN|Int32||XmlEnum("""OTHN""")|3|
||RFRL|Int32||XmlEnum("""RFRL""")|4|
||NDCL|Int32||XmlEnum("""NDCL""")|5|
||RQID|Int32||XmlEnum("""RQID""")|6|
||DCLN|Int32||XmlEnum("""DCLN""")|7|
||CPTR|Int32||XmlEnum("""CPTR""")|8|
||BLCK|Int32||XmlEnum("""BLCK""")|9|
||APPV|Int32||XmlEnum("""APPV""")|10|

---

## Value ISO20022.Cain014001.AdditionalAmounts4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|CdtDbt|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[0-9]{3,3}"""),validPattern("""Tp""",Tp,"""[0-9A-Z]{2,2}"""))|

---

## Value ISO20022.Cain014001.AdditionalData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain014001.AdditionalData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dtls|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Dtls""",Dtls),validElement(Dtls))|

---

## Value ISO20022.Cain014001.AdditionalFee3


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

## Value ISO20022.Cain014001.AdditionalRiskData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain014001.AdditionalService2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SvcDtl|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|OthrRslt|String||XmlElement()||
|+|Rslt|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SvcDtl""",SvcDtl),validElement(SvcDtl))|

---

## Enum ISO20022.Cain014001.AdditionalServiceResult1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PERF|Int32||XmlEnum("""PERF""")|1|
||OTHP|Int32||XmlEnum("""OTHP""")|2|
||OTHN|Int32||XmlEnum("""OTHN""")|3|
||NOSP|Int32||XmlEnum("""NOSP""")|4|
||NOPF|Int32||XmlEnum("""NOPF""")|5|

---

## Enum ISO20022.Cain014001.AdditionalServiceType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BALC|Int32||XmlEnum("""BALC""")|1|
||PRST|Int32||XmlEnum("""PRST""")|2|
||OTHP|Int32||XmlEnum("""OTHP""")|3|
||OTHN|Int32||XmlEnum("""OTHN""")|4|
||LOYT|Int32||XmlEnum("""LOYT""")|5|
||INTT|Int32||XmlEnum("""INTT""")|6|
||INTP|Int32||XmlEnum("""INTP""")|7|
||DCCV|Int32||XmlEnum("""DCCV""")|8|
||CSHB|Int32||XmlEnum("""CSHB""")|9|
||CACT|Int32||XmlEnum("""CACT""")|10|

---

## Value ISO20022.Cain014001.Address2


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

## Enum ISO20022.Cain014001.Algorithm13Code


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

## Enum ISO20022.Cain014001.Algorithm20Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HS51|Int32||XmlEnum("""HS51""")|1|
||HS38|Int32||XmlEnum("""HS38""")|2|
||HS25|Int32||XmlEnum("""HS25""")|3|

---

## Enum ISO20022.Cain014001.Algorithm23Code


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

## Enum ISO20022.Cain014001.Algorithm5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HS51|Int32||XmlEnum("""HS51""")|1|
||HS38|Int32||XmlEnum("""HS38""")|2|
||HS25|Int32||XmlEnum("""HS25""")|3|

---

## Enum ISO20022.Cain014001.Algorithm7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSAO|Int32||XmlEnum("""RSAO""")|1|
||ERSA|Int32||XmlEnum("""ERSA""")|2|

---

## Enum ISO20022.Cain014001.Algorithm8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MGF1|Int32||XmlEnum("""MGF1""")|1|

---

## Value ISO20022.Cain014001.AlgorithmIdentification25


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Cain014001.Parameter7||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Cain014001.AlgorithmIdentification26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|String||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain014001.AlgorithmIdentification27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Cain014001.Parameter13||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Cain014001.AlgorithmIdentification28


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Cain014001.Parameter14||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Enum ISO20022.Cain014001.AttributeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CATT|Int32||XmlEnum("""CATT""")|1|
||OUAT|Int32||XmlEnum("""OUAT""")|2|
||OATT|Int32||XmlEnum("""OATT""")|3|
||LATT|Int32||XmlEnum("""LATT""")|4|
||CNAT|Int32||XmlEnum("""CNAT""")|5|

---

## Value ISO20022.Cain014001.Authority1


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

## Value ISO20022.Cain014001.BatchManagementInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgChcksmInptVal|String||XmlElement()||
|+|MsgSeqNb|String||XmlElement()||
|+|BtchId|String||XmlElement()||
|+|ColltnId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MsgSeqNb""",MsgSeqNb,"""[0-9]{1,15}"""))|

---

## Enum ISO20022.Cain014001.BytePadding1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RAND|Int32||XmlEnum("""RAND""")|1|
||NULL|Int32||XmlEnum("""NULL""")|2|
||NULG|Int32||XmlEnum("""NULG""")|3|
||NUL8|Int32||XmlEnum("""NUL8""")|4|
||LNGT|Int32||XmlEnum("""LNGT""")|5|

---

## Value ISO20022.Cain014001.CardData13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlCardData|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|PrtflIdr|String||XmlElement()||
|+|PdctSubTp|String||XmlElement()||
|+|PdctTp|String||XmlElement()||
|+|CtryCd|String||XmlElement()||
|+|PANAcctRg|String||XmlElement()||
|+|PmtAcctRef|String||XmlElement()||
|+|Trck2|ISO20022.Cain014001.Track2Data1Choice||XmlElement()||
|+|XpryDt|String||XmlElement()||
|+|FctvDt|String||XmlElement()||
|+|CardSeqNb|String||XmlElement()||
|+|PrtctdPAN|String||XmlElement()||
|+|PAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlCardData""",AddtlCardData),validElement(AddtlCardData),validPattern("""CtryCd""",CtryCd,"""[0-9]{3,3}"""),validPattern("""PANAcctRg""",PANAcctRg,"""[0-9]{1,19}"""),validElement(Trck2),validPattern("""CardSeqNb""",CardSeqNb,"""[0-9]{2,3}"""),validPattern("""PAN""",PAN,"""[0-9]{1,19}"""))|

---

## Enum ISO20022.Cain014001.CardDataReading10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DFLE|Int32||XmlEnum("""DFLE""")|1|
||KEEN|Int32||XmlEnum("""KEEN""")|2|
||OTHP|Int32||XmlEnum("""OTHP""")|3|
||UNSP|Int32||XmlEnum("""UNSP""")|4|
||RFID|Int32||XmlEnum("""RFID""")|5|
||OTHN|Int32||XmlEnum("""OTHN""")|6|
||OPTC|Int32||XmlEnum("""OPTC""")|7|
||MSIP|Int32||XmlEnum("""MSIP""")|8|
||OCRR|Int32||XmlEnum("""OCRR""")|9|
||MLEY|Int32||XmlEnum("""MLEY""")|10|
||MICR|Int32||XmlEnum("""MICR""")|11|
||ICCY|Int32||XmlEnum("""ICCY""")|12|
||MGST|Int32||XmlEnum("""MGST""")|13|
||ICPY|Int32||XmlEnum("""ICPY""")|14|

---

## Enum ISO20022.Cain014001.CardDataReading9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ICCY|Int32||XmlEnum("""ICCY""")|1|
||TOKN|Int32||XmlEnum("""TOKN""")|2|
||MBNK|Int32||XmlEnum("""MBNK""")|3|
||CDFL|Int32||XmlEnum("""CDFL""")|4|
||OPTC|Int32||XmlEnum("""OPTC""")|5|
||ICPY|Int32||XmlEnum("""ICPY""")|6|
||KEEN|Int32||XmlEnum("""KEEN""")|7|
||CAMR|Int32||XmlEnum("""CAMR""")|8|
||OTHP|Int32||XmlEnum("""OTHP""")|9|
||OTHN|Int32||XmlEnum("""OTHN""")|10|
||UNKW|Int32||XmlEnum("""UNKW""")|11|

---

## Enum ISO20022.Cain014001.CardDataWriting1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHP|Int32||XmlEnum("""OTHP""")|1|
||UNSP|Int32||XmlEnum("""UNSP""")|2|
||OTHN|Int32||XmlEnum("""OTHN""")|3|
||MSIP|Int32||XmlEnum("""MSIP""")|4|
||ICCY|Int32||XmlEnum("""ICCY""")|5|
||MGST|Int32||XmlEnum("""MGST""")|6|
||ICPY|Int32||XmlEnum("""ICPY""")|7|

---

## Enum ISO20022.Cain014001.CardDepositType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CASH|Int32||XmlEnum("""CASH""")|1|
||CHEC|Int32||XmlEnum("""CHEC""")|2|
||ENVL|Int32||XmlEnum("""ENVL""")|3|
||OTHN|Int32||XmlEnum("""OTHN""")|4|
||OTHP|Int32||XmlEnum("""OTHP""")|5|

---

## Value ISO20022.Cain014001.CardReadingCapabilities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrCpblty|String||XmlElement()||
|+|Cpblty|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain014001.CardWritingCapabilities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrCpblty|String||XmlElement()||
|+|Cpblty|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain014001.Cardholder22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LclData|ISO20022.Cain014001.LocalData13||XmlElement()||
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|HghVal|String||XmlElement()||
|+|DtOfBirth|DateTime||XmlElement()||
|+|CtctInf|ISO20022.Cain014001.ContactPersonal1||XmlElement()||
|+|Adr|ISO20022.Cain014001.Address2||XmlElement()||
|+|Id|global::System.Collections.Generic.List<ISO20022.Cain014001.Credentials3>||XmlElement()||
|+|Nm|ISO20022.Cain014001.CardholderName3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LclData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(CtctInf),validElement(Adr),validList("""Id""",Id),validElement(Id),validElement(Nm))|

---

## Value ISO20022.Cain014001.CardholderName2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastNm|String||XmlElement()||
|+|MddlNm|String||XmlElement()||
|+|GvnNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain014001.CardholderName3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastNm|String||XmlElement()||
|+|MddlNm|String||XmlElement()||
|+|GvnNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain014001.CardholderVerificationCapabilities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrCpblty|String||XmlElement()||
|+|Cpblty|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Cain014001.CardholderVerificationCapability5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOOP|Int32||XmlEnum("""NOOP""")|1|
||NOPN|Int32||XmlEnum("""NOPN""")|2|
||PKIS|Int32||XmlEnum("""PKIS""")|3|
||VORN|Int32||XmlEnum("""VORN""")|4|
||UNSP|Int32||XmlEnum("""UNSP""")|5|
||SIGN|Int32||XmlEnum("""SIGN""")|6|
||OTHP|Int32||XmlEnum("""OTHP""")|7|
||OTHN|Int32||XmlEnum("""OTHN""")|8|
||NPIN|Int32||XmlEnum("""NPIN""")|9|
||NBIO|Int32||XmlEnum("""NBIO""")|10|
||FEPN|Int32||XmlEnum("""FEPN""")|11|
||FCPN|Int32||XmlEnum("""FCPN""")|12|
||FDSG|Int32||XmlEnum("""FDSG""")|13|
||FBIO|Int32||XmlEnum("""FBIO""")|14|
||FBIG|Int32||XmlEnum("""FBIG""")|15|
||NOVF|Int32||XmlEnum("""NOVF""")|16|
||APKI|Int32||XmlEnum("""APKI""")|17|

---

## Value ISO20022.Cain014001.CertificateIssuer1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltvDstngshdNm|global::System.Collections.Generic.List<ISO20022.Cain014001.RelativeDistinguishedName1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""RltvDstngshdNm""",RltvDstngshdNm),validList("""RltvDstngshdNm""",RltvDstngshdNm),validElement(RltvDstngshdNm))|

---

## Value ISO20022.Cain014001.ContactBusiness1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lang|String||XmlElement()||
|+|URL|String||XmlElement()||
|+|Fax|String||XmlElement()||
|+|Email|String||XmlElement()||
|+|TollFreePhne|String||XmlElement()||
|+|PrprtyPhne|String||XmlElement()||
|+|Phne|String||XmlElement()||
|+|LastNm|String||XmlElement()||
|+|MddlNm|String||XmlElement()||
|+|GvnNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lang""",Lang,"""[a-z]{2,2}"""),validPattern("""Fax""",Fax,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""TollFreePhne""",TollFreePhne,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""PrprtyPhne""",PrprtyPhne,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""Phne""",Phne,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Value ISO20022.Cain014001.ContactPersonal1


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

## Value ISO20022.Cain014001.ContentInformationType41


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MAC|String||XmlElement()||
|+|MACData|ISO20022.Cain014001.MACData1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MAC""",MAC,"""([0-9A-F][0-9A-F]){1,8}"""),validElement(MACData))|

---

## Enum ISO20022.Cain014001.ContentType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AUTH|Int32||XmlEnum("""AUTH""")|1|
||DGST|Int32||XmlEnum("""DGST""")|2|
||EVLP|Int32||XmlEnum("""EVLP""")|3|
||SIGN|Int32||XmlEnum("""SIGN""")|4|
||DATA|Int32||XmlEnum("""DATA""")|5|

---

## Enum ISO20022.Cain014001.ContentType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||IFSE|Int32||XmlEnum("""IFSE""")|1|
||EVLP|Int32||XmlEnum("""EVLP""")|2|

---

## Value ISO20022.Cain014001.Context19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|RctDstn|String||XmlElement()||
|+|RctTp|global::System.Collections.Generic.List<String>||XmlElement()||
|+|RctReq|String||XmlElement()||
|+|OthrGoodAndSvcDlvrySchdl|String||XmlElement()||
|+|GoodAndSvcDlvrySchdl|String||XmlElement()||
|+|OthrGoodAndSvcDlvryChanl|String||XmlElement()||
|+|GoodAndSvcDlvryChanl|String||XmlElement()||
|+|GoodAndSvcsOthrSubTp|String||XmlElement()||
|+|GoodAndSvcsSubTp|String||XmlElement()||
|+|GoodsAndSvcsTp|String||XmlElement()||
|+|SaleRefNb|String||XmlElement()||
|+|ECRId|String||XmlElement()||
|+|DtAntcptd|DateTime||XmlElement()||
|+|CaptrDt|DateTime||XmlElement()||
|+|AuthntcnOutg|String||XmlElement()||
|+|MgntcStrpFllbck|String||XmlElement()||
|+|OthrICCFllbckRsnCd|String||XmlElement()||
|+|ICCFllbckRsnCd|String||XmlElement()||
|+|ICCFllbck|String||XmlElement()||
|+|PINNtryBpss|String||XmlElement()||
|+|PINPadInprtv|String||XmlElement()||
|+|PmtCrdntlMrchntRltsh|String||XmlElement()||
|+|StorgLctn|String||XmlElement()||
|+|TempScrCardDataReusd|String||XmlElement()||
|+|OthrSctyChrtcs|String||XmlElement()||
|+|SctyChrtcs|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PrtlApprvlSpprtd|String||XmlElement()||
|+|SpltPmt|String||XmlElement()||
|+|PrtlShipmnt|String||XmlElement()||
|+|DfrrdDlvry|String||XmlElement()||
|+|LatePresntmnt|String||XmlElement()||
|+|DelydAuthstn|String||XmlElement()||
|+|ReSubmissn|String||XmlElement()||
|+|Reauthstn|String||XmlElement()||
|+|NoShow|String||XmlElement()||
|+|DelydChrgs|String||XmlElement()||
|+|TxInitr|String||XmlElement()||
|+|CstmrCnsnt|String||XmlElement()||
|+|FnlAuthstn|String||XmlElement()||
|+|MOTOCd|String||XmlElement()||
|+|EComrcData|global::System.Collections.Generic.List<ISO20022.Cain014001.ECommerceData1>||XmlElement()||
|+|EComrcIndApld|String||XmlElement()||
|+|EComrcIndPropsd|String||XmlElement()||
|+|EComrc|String||XmlElement()||
|+|UattnddLvlCtgy|String||XmlElement()||
|+|Attndd|String||XmlElement()||
|+|Trnst|String||XmlElement()||
|+|TrnspndrInittd|String||XmlElement()||
|+|CrdhldrActvtd|String||XmlElement()||
|+|CrdhldrPres|String||XmlElement()||
|+|CardPres|String||XmlElement()||
|+|OthrMrchntCtgy|String||XmlElement()||
|+|MrchntCtgySpcfcData|String||XmlElement()||
|+|MrchntCtgyCd|String||XmlElement()||
|+|OthrQRCdPresntmntMd|String||XmlElement()||
|+|QRCdPresntmntMd|String||XmlElement()||
|+|OthrCardDataNtryMd|String||XmlElement()||
|+|CardDataNtryMd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validList("""EComrcData""",EComrcData),validElement(EComrcData),validPattern("""UattnddLvlCtgy""",UattnddLvlCtgy,"""[0-9]{1,35}"""),validPattern("""MrchntCtgyCd""",MrchntCtgyCd,"""[0-9]{4,4}"""))|

---

## Value ISO20022.Cain014001.Context24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|RctDstn|String||XmlElement()||
|+|RctTp|global::System.Collections.Generic.List<String>||XmlElement()||
|+|RctReq|String||XmlElement()||
|+|OthrGoodAndSvcDlvrySchdl|String||XmlElement()||
|+|GoodAndSvcDlvrySchdl|String||XmlElement()||
|+|OthrGoodAndSvcDlvryChanl|String||XmlElement()||
|+|GoodAndSvcDlvryChanl|String||XmlElement()||
|+|GoodAndSvcsOthrSubTp|String||XmlElement()||
|+|GoodAndSvcsSubTp|String||XmlElement()||
|+|GoodsAndSvcsTp|String||XmlElement()||
|+|SaleRefNb|String||XmlElement()||
|+|DtAntcptd|DateTime||XmlElement()||
|+|CaptrDt|DateTime||XmlElement()||
|+|PmtCrdntlMrchntRltsh|String||XmlElement()||
|+|AuthntcnOutg|String||XmlElement()||
|+|StorgLctn|String||XmlElement()||
|+|OthrSctyChrtcs|String||XmlElement()||
|+|SctyChrtcs|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PrtlApprvlSpprtd|String||XmlElement()||
|+|SpltPmt|String||XmlElement()||
|+|PrtlShipmnt|String||XmlElement()||
|+|DfrrdDlvry|String||XmlElement()||
|+|LatePresntmnt|String||XmlElement()||
|+|DelydAuthstn|String||XmlElement()||
|+|ReSubmissn|String||XmlElement()||
|+|Reauthstn|String||XmlElement()||
|+|NoShow|String||XmlElement()||
|+|DelydChrgs|String||XmlElement()||
|+|TxInitr|String||XmlElement()||
|+|MOTOCd|String||XmlElement()||
|+|EComrcData|global::System.Collections.Generic.List<ISO20022.Cain014001.ECommerceData1>||XmlElement()||
|+|EComrcIndApld|String||XmlElement()||
|+|EComrcIndPropsd|String||XmlElement()||
|+|EComrc|String||XmlElement()||
|+|UattnddLvlCtgy|String||XmlElement()||
|+|Attndd|String||XmlElement()||
|+|Trnst|String||XmlElement()||
|+|TrnspndrInittd|String||XmlElement()||
|+|CrdhldrActvtd|String||XmlElement()||
|+|CrdhldrPres|String||XmlElement()||
|+|CardPres|String||XmlElement()||
|+|OthrMrchntCtgy|String||XmlElement()||
|+|MrchntCtgySpcfcData|String||XmlElement()||
|+|MrchntCtgyCd|String||XmlElement()||
|+|OthrQRCdPresntmntMd|String||XmlElement()||
|+|QRCdPresntmntMd|String||XmlElement()||
|+|OthrCardDataNtryMd|String||XmlElement()||
|+|CardDataNtryMd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validList("""EComrcData""",EComrcData),validElement(EComrcData),validPattern("""UattnddLvlCtgy""",UattnddLvlCtgy,"""[0-9]{1,35}"""),validPattern("""MrchntCtgyCd""",MrchntCtgyCd,"""[0-9]{4,4}"""))|

---

## Enum ISO20022.Cain014001.CorporateTaxType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CORP|Int32||XmlEnum("""CORP""")|1|
||OTHR|Int32||XmlEnum("""OTHR""")|2|
||SMBS|Int32||XmlEnum("""SMBS""")|3|

---

## Value ISO20022.Cain014001.Credentials3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Assgnr|ISO20022.Cain014001.Authority1||XmlElement()||
|+|XpryDt|String||XmlElement()||
|+|Val|String||XmlElement()||
|+|SubTp|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Assgnr))|

---

## Enum ISO20022.Cain014001.CreditDebit3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Cain014001.CustomerDevice5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|Prvdr|String||XmlElement()||
|+|OprgSysBld|String||XmlElement()||
|+|OprgSysVrsn|String||XmlElement()||
|+|OthrOprgSysTp|String||XmlElement()||
|+|OprgSysTp|String||XmlElement()||
|+|OprgSysId|String||XmlElement()||
|+|DvcId|global::System.Collections.Generic.List<ISO20022.Cain014001.DeviceIdentification1>||XmlElement()||
|+|DvcNmNrmlzd|String||XmlElement()||
|+|DvcNm|String||XmlElement()||
|+|Email|String||XmlElement()||
|+|IPAdr|String||XmlElement()||
|+|LctnCtryCd|String||XmlElement()||
|+|GeogcLctn|String||XmlElement()||
|+|Phne|String||XmlElement()||
|+|Lang|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|ManfctrMdlId|String||XmlElement()||
|+|Manfctr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validList("""DvcId""",DvcId),validElement(DvcId),validPattern("""LctnCtryCd""",LctnCtryCd,"""[0-9]{3,3}"""),validPattern("""GeogcLctn""",GeogcLctn,"""(\+\|-)?[\d]{1,3}(\.[\d]{1,8})?/(\+\|-)?[\d]{1,3}(\.[\d]{1,8})?"""),validPattern("""Phne""",Phne,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""Lang""",Lang,"""[a-z]{2,2}"""))|

---

## Enum ISO20022.Cain014001.CustomerDeviceType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNKW|Int32||XmlEnum("""UNKW""")|1|
||STIC|Int32||XmlEnum("""STIC""")|2|
||KFOB|Int32||XmlEnum("""KFOB""")|3|
||JEWL|Int32||XmlEnum("""JEWL""")|4|
||GAMB|Int32||XmlEnum("""GAMB""")|5|
||WATC|Int32||XmlEnum("""WATC""")|6|
||WRBL|Int32||XmlEnum("""WRBL""")|7|
||VHCL|Int32||XmlEnum("""VHCL""")|8|
||EMBD|Int32||XmlEnum("""EMBD""")|9|
||SECR|Int32||XmlEnum("""SECR""")|10|
||NSCR|Int32||XmlEnum("""NSCR""")|11|
||TBLT|Int32||XmlEnum("""TBLT""")|12|
||PECR|Int32||XmlEnum("""PECR""")|13|
||OTHP|Int32||XmlEnum("""OTHP""")|14|
||OTHN|Int32||XmlEnum("""OTHN""")|15|
||MOBL|Int32||XmlEnum("""MOBL""")|16|

---

## Value ISO20022.Cain014001.DateTime2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain014001.DepositDetails3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbt|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain014001.DetailedAmount22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|RcncltnAmt|Decimal||XmlElement()||
|+|CrdhldrBllgAmt|Decimal||XmlElement()||
|+|Amt|Decimal||XmlElement()||
|+|CdtDbt|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Tp""",Tp,"""[0-9A-Z]{2,2}"""))|

---

## Value ISO20022.Cain014001.DeviceIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Assgnr|String||XmlElement()||
|+|Id|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Cain014001.DeviceIdentificationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SENU|Int32||XmlEnum("""SENU""")|1|
||SEID|Int32||XmlEnum("""SEID""")|2|
||OTHP|Int32||XmlEnum("""OTHP""")|3|
||OTHN|Int32||XmlEnum("""OTHN""")|4|
||IMEI|Int32||XmlEnum("""IMEI""")|5|

---

## Value ISO20022.Cain014001.DisplayCapabilities6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AvlblLang|global::System.Collections.Generic.List<String>||XmlElement()||
|+|LineWidth|Decimal||XmlElement()||
|+|NbOfLines|Decimal||XmlElement()||
|+|AvlblFrmt|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Dstn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain014001.DisputeData4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|ChrgbckElgblty|String||XmlElement()||
|+|RjctRsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|DcmnttnSts|String||XmlElement()||
|+|Ref|global::System.Collections.Generic.List<ISO20022.Cain014001.DisputeReference1>||XmlElement()||
|+|Prtl|String||XmlElement()||
|+|Sts|String||XmlElement()||
|+|Cond|String||XmlElement()||
|+|Cycl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validList("""Ref""",Ref),validElement(Ref),validPattern("""Cycl""",Cycl,"""[0-9]"""))|

---

## Value ISO20022.Cain014001.DisputeDocumentation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|OthrFrmt|String||XmlElement()||
|+|Frmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain014001.DisputeIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain014001.DisputeReference1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DsptId|global::System.Collections.Generic.List<ISO20022.Cain014001.DisputeIdentification1>||XmlElement()||
|+|OthrAssgnrNtty|String||XmlElement()||
|+|AssgnrNtty|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""DsptId""",DsptId),validList("""DsptId""",DsptId),validElement(DsptId))|

---

## Type ISO20022.Cain014001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RtrvlFlfmtInitn|ISO20022.Cain014001.RetrievalFulfilmentInitiationV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RtrvlFlfmtInitn))|

---

## Value ISO20022.Cain014001.ECommerceData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain014001.EncryptedContent8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdDataElmt|global::System.Collections.Generic.List<ISO20022.Cain014001.EncryptedDataElement2>||XmlElement()||
|+|CnttNcrptnAlgo|ISO20022.Cain014001.AlgorithmIdentification25||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""NcrptdDataElmt""",NcrptdDataElmt),validList("""NcrptdDataElmt""",NcrptdDataElmt),validElement(NcrptdDataElmt),validElement(CnttNcrptnAlgo))|

---

## Value ISO20022.Cain014001.EncryptedData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdElmt|global::System.Collections.Generic.List<ISO20022.Cain014001.EncryptedDataElement2>||XmlElement()||
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

## Value ISO20022.Cain014001.EncryptedData2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HexBinry|String||XmlElement()||
|+|Binry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""HexBinry""",HexBinry,"""([0-9A-F][0-9A-F]){1,9999}"""),validChoice(HexBinry,Binry))|

---

## Value ISO20022.Cain014001.EncryptedDataElement2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrClearTxtFrmt|String||XmlElement()||
|+|ClearTxtFrmt|String||XmlElement()||
|+|Data|ISO20022.Cain014001.EncryptedData2Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Data))|

---

## Enum ISO20022.Cain014001.EncryptedDataFormat1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHP|Int32||XmlEnum("""OTHP""")|1|
||OTHN|Int32||XmlEnum("""OTHN""")|2|
||HEXF|Int32||XmlEnum("""HEXF""")|3|
||EBCD|Int32||XmlEnum("""EBCD""")|4|
||BINF|Int32||XmlEnum("""BINF""")|5|
||ASCI|Int32||XmlEnum("""ASCI""")|6|

---

## Enum ISO20022.Cain014001.EncryptionFormat3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CBCE|Int32||XmlEnum("""CBCE""")|1|
||CTCE|Int32||XmlEnum("""CTCE""")|2|
||TR31|Int32||XmlEnum("""TR31""")|3|
||TR34|Int32||XmlEnum("""TR34""")|4|

---

## Enum ISO20022.Cain014001.Endpoint1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHN|Int32||XmlEnum("""OTHN""")|1|
||OTHP|Int32||XmlEnum("""OTHP""")|2|
||ORIG|Int32||XmlEnum("""ORIG""")|3|
||DEST|Int32||XmlEnum("""DEST""")|4|

---

## Value ISO20022.Cain014001.EnvelopedData12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdCntt|ISO20022.Cain014001.EncryptedContent8||XmlElement()||
|+|Rcpt|global::System.Collections.Generic.List<ISO20022.Cain014001.Recipient7Choice>||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcrptdCntt),validRequired("""Rcpt""",Rcpt),validList("""Rcpt""",Rcpt),validElement(Rcpt))|

---

## Value ISO20022.Cain014001.ErrorDetails3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DataElmtInErr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Desc|String||XmlElement()||
|+|Cd|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Cain014001.ExchangeRateAgreementType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SPOT|Int32||XmlEnum("""SPOT""")|1|
||OTHP|Int32||XmlEnum("""OTHP""")|2|
||OTHN|Int32||XmlEnum("""OTHN""")|3|
||NORM|Int32||XmlEnum("""NORM""")|4|
||FWCT|Int32||XmlEnum("""FWCT""")|5|

---

## Value ISO20022.Cain014001.ExchangeRateInformation5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateLckApld|String||XmlElement()||
|+|RateLckElgbl|String||XmlElement()||
|+|RateLckReqd|String||XmlElement()||
|+|OthrAgrmtTp|String||XmlElement()||
|+|AgrmtTp|String||XmlElement()||
|+|OthrRateTp|String||XmlElement()||
|+|RateTp|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
|+|BaseCcyCd|String||XmlElement()||
|+|CntrCcyCd|String||XmlElement()||
|+|OthrEndPt|String||XmlElement()||
|+|EndPt|String||XmlElement()||
|+|Tm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
|+|Prvdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""BaseCcyCd""",BaseCcyCd,"""[0-9]{3,3}"""),validPattern("""CntrCcyCd""",CntrCcyCd,"""[0-9]{3,3}"""))|

---

## Enum ISO20022.Cain014001.ExchangeRateType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGRD|Int32||XmlEnum("""AGRD""")|1|
||BUYR|Int32||XmlEnum("""BUYR""")|2|
||MIDL|Int32||XmlEnum("""MIDL""")|3|
||OTHN|Int32||XmlEnum("""OTHN""")|4|
||OTHP|Int32||XmlEnum("""OTHP""")|5|
||SELL|Int32||XmlEnum("""SELL""")|6|

---

## Value ISO20022.Cain014001.FinancialInstitution8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LclData|ISO20022.Cain014001.LocalData10||XmlElement()||
|+|AddtlCtct|String||XmlElement()||
|+|CstmrSvc|String||XmlElement()||
|+|Phne|String||XmlElement()||
|+|URL|String||XmlElement()||
|+|Email|String||XmlElement()||
|+|Adr|ISO20022.Cain014001.Address2||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LclData),validElement(Adr))|

---

## Enum ISO20022.Cain014001.Frequency12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||TEND|Int32||XmlEnum("""TEND""")|2|
||MIAN|Int32||XmlEnum("""MIAN""")|3|
||QURT|Int32||XmlEnum("""QURT""")|4|
||MNTH|Int32||XmlEnum("""MNTH""")|5|
||FRTN|Int32||XmlEnum("""FRTN""")|6|
||DAIL|Int32||XmlEnum("""DAIL""")|7|
||YEAR|Int32||XmlEnum("""YEAR""")|8|

---

## Value ISO20022.Cain014001.FundingService3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClmAssgnr|String||XmlElement()||
|+|ClmCrdntls|String||XmlElement()||
|+|FndgSrc|global::System.Collections.Generic.List<ISO20022.Cain014001.FundingSource4>||XmlElement()||
|+|Desc|String||XmlElement()||
|+|BizPurp|String||XmlElement()||
|+|Ref|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Prvdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""FndgSrc""",FndgSrc),validElement(FndgSrc))|

---

## Value ISO20022.Cain014001.FundingSource4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ref|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Cain014001.FundingSourceType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LOYT|Int32||XmlEnum("""LOYT""")|1|
||LCDT|Int32||XmlEnum("""LCDT""")|2|
||PRPD|Int32||XmlEnum("""PRPD""")|3|
||CHQE|Int32||XmlEnum("""CHQE""")|4|
||CURR|Int32||XmlEnum("""CURR""")|5|
||DBAC|Int32||XmlEnum("""DBAC""")|6|
||EPRS|Int32||XmlEnum("""EPRS""")|7|
||CDBT|Int32||XmlEnum("""CDBT""")|8|
||CRDT|Int32||XmlEnum("""CRDT""")|9|
||CASH|Int32||XmlEnum("""CASH""")|10|
||UVRL|Int32||XmlEnum("""UVRL""")|11|
||SVNG|Int32||XmlEnum("""SVNG""")|12|
||OTHP|Int32||XmlEnum("""OTHP""")|13|
||OTHN|Int32||XmlEnum("""OTHN""")|14|

---

## Value ISO20022.Cain014001.GenericIdentification183


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

## Enum ISO20022.Cain014001.GoodAndServiceDeliveryChannel1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SCSA|Int32||XmlEnum("""SCSA""")|1|
||SCBA|Int32||XmlEnum("""SCBA""")|2|
||OTHP|Int32||XmlEnum("""OTHP""")|3|
||OTHN|Int32||XmlEnum("""OTHN""")|4|
||NDEL|Int32||XmlEnum("""NDEL""")|5|
||PULC|Int32||XmlEnum("""PULC""")|6|
||EDEL|Int32||XmlEnum("""EDEL""")|7|

---

## Enum ISO20022.Cain014001.GoodAndServiceDeliverySchedule1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TDDL|Int32||XmlEnum("""TDDL""")|1|
||SDDL|Int32||XmlEnum("""SDDL""")|2|
||ONDL|Int32||XmlEnum("""ONDL""")|3|
||OTHP|Int32||XmlEnum("""OTHP""")|4|
||OTHN|Int32||XmlEnum("""OTHN""")|5|

---

## Enum ISO20022.Cain014001.GoodsAndServices1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ELPH|Int32||XmlEnum("""ELPH""")|1|
||PHYS|Int32||XmlEnum("""PHYS""")|2|
||ELEC|Int32||XmlEnum("""ELEC""")|3|

---

## Enum ISO20022.Cain014001.GoodsAndServicesSubType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SECS|Int32||XmlEnum("""SECS""")|1|
||OTHP|Int32||XmlEnum("""OTHP""")|2|
||OTHN|Int32||XmlEnum("""OTHN""")|3|
||FORX|Int32||XmlEnum("""FORX""")|4|
||CRCU|Int32||XmlEnum("""CRCU""")|5|

---

## Value ISO20022.Cain014001.Header71


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tracblt|global::System.Collections.Generic.List<ISO20022.Cain014001.Traceability10>||XmlElement()||
|+|TracData|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|RcptPty|ISO20022.Cain014001.GenericIdentification183||XmlElement()||
|+|InitgPty|ISO20022.Cain014001.GenericIdentification183||XmlElement()||
|+|BtchMgmtInf|ISO20022.Cain014001.BatchManagementInformation1||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|ReTrnsmssnCntr|String||XmlElement()||
|+|XchgId|String||XmlElement()||
|+|PrtcolVrsn|String||XmlElement()||
|+|MsgFctn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Tracblt""",Tracblt),validElement(Tracblt),validList("""TracData""",TracData),validElement(TracData),validElement(RcptPty),validElement(InitgPty),validElement(BtchMgmtInf),validPattern("""ReTrnsmssnCntr""",ReTrnsmssnCntr,"""[0-9]{1,3}"""))|

---

## Enum ISO20022.Cain014001.ICCFallbackReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TERI|Int32||XmlEnum("""TERI""")|1|
||OTHP|Int32||XmlEnum("""OTHP""")|2|
||OTHN|Int32||XmlEnum("""OTHN""")|3|
||EDIP|Int32||XmlEnum("""EDIP""")|4|
||CIIA|Int32||XmlEnum("""CIIA""")|5|

---

## Value ISO20022.Cain014001.IssuerAndSerialNumber1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrlNb|String||XmlElement()||
|+|Issr|ISO20022.Cain014001.CertificateIssuer1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Issr))|

---

## Value ISO20022.Cain014001.Jurisdiction2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DmstQlfctn|String||XmlElement()||
|+|DmstInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain014001.KEK6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Cain014001.AlgorithmIdentification28||XmlElement()||
|+|KEKId|ISO20022.Cain014001.KEKIdentifier6||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(KEKId))|

---

## Value ISO20022.Cain014001.KEKIdentifier2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivtnId|String||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|KeyVrsn|String||XmlElement()||
|+|KeyId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain014001.KEKIdentifier6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivtnId|String||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|KeyVrsn|String||XmlElement()||
|+|KeyId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain014001.KeyTransport6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Cain014001.AlgorithmIdentification27||XmlElement()||
|+|RcptId|ISO20022.Cain014001.Recipient5Choice||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(RcptId))|

---

## Enum ISO20022.Cain014001.LifeCycleSupport1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FINC|Int32||XmlEnum("""FINC""")|1|
||AUTH|Int32||XmlEnum("""AUTH""")|2|

---

## Value ISO20022.Cain014001.LocalAddress1


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

## Value ISO20022.Cain014001.LocalData10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|AddtlCtct|String||XmlElement()||
|+|Adr|ISO20022.Cain014001.LocalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|NcodgFrmt|String||XmlElement()||
|+|Lang|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(Adr),validPattern("""Lang""",Lang,"""[a-z]{2,3}"""))|

---

## Value ISO20022.Cain014001.LocalData11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|AddtlCtct|String||XmlElement()||
|+|AddtlAdr|String||XmlElement()||
|+|Adr|ISO20022.Cain014001.LocalAddress1||XmlElement()||
|+|NmAndLctn|String||XmlElement()||
|+|LglCorpNm|String||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|NcodgFrmt|String||XmlElement()||
|+|Lang|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(Adr),validPattern("""Lang""",Lang,"""[a-z]{2,3}"""))|

---

## Value ISO20022.Cain014001.LocalData13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|Adr|ISO20022.Cain014001.LocalAddress1||XmlElement()||
|+|Nm|ISO20022.Cain014001.CardholderName2||XmlElement()||
|+|NcodgFrmt|String||XmlElement()||
|+|Lang|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(Adr),validElement(Nm),validPattern("""Lang""",Lang,"""[a-z]{2,3}"""))|

---

## Value ISO20022.Cain014001.LocalData14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|LglCorpNm|String||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|NcodgFrmt|String||XmlElement()||
|+|Lang|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validPattern("""Lang""",Lang,"""[a-z]{2,3}"""))|

---

## Value ISO20022.Cain014001.LocalData15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|Adr|ISO20022.Cain014001.LocalAddress1||XmlElement()||
|+|Nm|ISO20022.Cain014001.CardholderName2||XmlElement()||
|+|NcodgFrmt|String||XmlElement()||
|+|Lang|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(Adr),validElement(Nm),validPattern("""Lang""",Lang,"""[a-z]{2,3}"""))|

---

## Value ISO20022.Cain014001.MACData1


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

## Enum ISO20022.Cain014001.MOTO2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TPOR|Int32||XmlEnum("""TPOR""")|1|
||MOTO|Int32||XmlEnum("""MOTO""")|2|
||MAOR|Int32||XmlEnum("""MAOR""")|3|

---

## Enum ISO20022.Cain014001.MessageError1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ICOL|Int32||XmlEnum("""ICOL""")|1|
||IBAT|Int32||XmlEnum("""IBAT""")|2|
||IDRM|Int32||XmlEnum("""IDRM""")|3|
||IDWM|Int32||XmlEnum("""IDWM""")|4|
||DUME|Int32||XmlEnum("""DUME""")|5|
||ITDE|Int32||XmlEnum("""ITDE""")|6|
||OTHN|Int32||XmlEnum("""OTHN""")|7|
||UDFD|Int32||XmlEnum("""UDFD""")|8|
||SECU|Int32||XmlEnum("""SECU""")|9|
||RDEM|Int32||XmlEnum("""RDEM""")|10|
||PRVE|Int32||XmlEnum("""PRVE""")|11|
||OTHP|Int32||XmlEnum("""OTHP""")|12|
||MEPE|Int32||XmlEnum("""MEPE""")|13|
||INMF|Int32||XmlEnum("""INMF""")|14|
||INME|Int32||XmlEnum("""INME""")|15|
||IDEV|Int32||XmlEnum("""IDEV""")|16|
||IDEL|Int32||XmlEnum("""IDEL""")|17|
||IDEF|Int32||XmlEnum("""IDEF""")|18|

---

## Enum ISO20022.Cain014001.OnLineCapability2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BOTH|Int32||XmlEnum("""BOTH""")|1|
||ONLN|Int32||XmlEnum("""ONLN""")|2|
||OFLN|Int32||XmlEnum("""OFLN""")|3|

---

## Value ISO20022.Cain014001.OriginalTransaction3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgRslt|ISO20022.Cain014001.ProcessingResult22||XmlElement()||
|+|Dcmnttn|global::System.Collections.Generic.List<ISO20022.Cain014001.DisputeDocumentation1>||XmlElement()||
|+|DsptData|global::System.Collections.Generic.List<ISO20022.Cain014001.DisputeData4>||XmlElement()||
|+|Rcncltn|ISO20022.Cain014001.Reconciliation4||XmlElement()||
|+|AddtlFee|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalFee3>||XmlElement()||
|+|SttlmSvc|ISO20022.Cain014001.SettlementService6||XmlElement()||
|+|Jursdctn|ISO20022.Cain014001.Jurisdiction2||XmlElement()||
|+|DpstDtls|global::System.Collections.Generic.List<ISO20022.Cain014001.DepositDetails3>||XmlElement()||
|+|FndsSvcs|ISO20022.Cain014001.FundingService3||XmlElement()||
|+|AddtlSvc|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalService2>||XmlElement()||
|+|SpclPrgrmmQlfctn|global::System.Collections.Generic.List<ISO20022.Cain014001.SpecialProgrammeQualification2>||XmlElement()||
|+|Rsk|global::System.Collections.Generic.List<ISO20022.Cain014001.RiskContext3>||XmlElement()||
|+|Vrfctn|global::System.Collections.Generic.List<ISO20022.Cain014001.Verification7>||XmlElement()||
|+|Crdhldr|ISO20022.Cain014001.Cardholder22||XmlElement()||
|+|Wllt|ISO20022.Cain014001.Wallet3||XmlElement()||
|+|CstmrDvc|ISO20022.Cain014001.CustomerDevice5||XmlElement()||
|+|Tkn|ISO20022.Cain014001.Token2||XmlElement()||
|+|Pyee|ISO20022.Cain014001.PartyIdentification287||XmlElement()||
|+|Pyer|ISO20022.Cain014001.PartyIdentification287||XmlElement()||
|+|Cntxt|ISO20022.Cain014001.Context19||XmlElement()||
|+|POICmpnt|global::System.Collections.Generic.List<ISO20022.Cain014001.PointOfInteractionComponent16>||XmlElement()||
|+|Termnl|ISO20022.Cain014001.Terminal9||XmlElement()||
|+|Accptr|ISO20022.Cain014001.PartyIdentification284||XmlElement()||
|+|AddtlAmt|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalAmounts4>||XmlElement()||
|+|TxAmts|ISO20022.Cain014001.TransactionAmounts3||XmlElement()||
|+|XchgRate|global::System.Collections.Generic.List<ISO20022.Cain014001.ExchangeRateInformation5>||XmlElement()||
|+|ConvsDtTm|ISO20022.Cain014001.DateTime2||XmlElement()||
|+|TxId|ISO20022.Cain014001.TransactionIdentification54||XmlElement()||
|+|Prgrmm|ISO20022.Cain014001.ProgrammeMode4||XmlElement()||
|+|Dstn|ISO20022.Cain014001.PartyIdentification286||XmlElement()||
|+|Issr|ISO20022.Cain014001.PartyIdentification286||XmlElement()||
|+|Rcvr|ISO20022.Cain014001.PartyIdentification286||XmlElement()||
|+|AcctTo|ISO20022.Cain014001.AccountDetails4||XmlElement()||
|+|AcctFr|ISO20022.Cain014001.AccountDetails4||XmlElement()||
|+|Card|ISO20022.Cain014001.CardData13||XmlElement()||
|+|Sndr|ISO20022.Cain014001.PartyIdentification286||XmlElement()||
|+|Acqrr|ISO20022.Cain014001.PartyIdentification286||XmlElement()||
|+|Orgtr|ISO20022.Cain014001.PartyIdentification286||XmlElement()||
|+|TxChrtcs|ISO20022.Cain014001.OriginalTransactionCharacteristics1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrcgRslt),validList("""Dcmnttn""",Dcmnttn),validElement(Dcmnttn),validList("""DsptData""",DsptData),validElement(DsptData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validList("""DpstDtls""",DpstDtls),validElement(DpstDtls),validElement(FndsSvcs),validList("""AddtlSvc""",AddtlSvc),validElement(AddtlSvc),validList("""SpclPrgrmmQlfctn""",SpclPrgrmmQlfctn),validElement(SpclPrgrmmQlfctn),validList("""Rsk""",Rsk),validElement(Rsk),validList("""Vrfctn""",Vrfctn),validElement(Vrfctn),validElement(Crdhldr),validElement(Wllt),validElement(CstmrDvc),validElement(Tkn),validElement(Pyee),validElement(Pyer),validElement(Cntxt),validList("""POICmpnt""",POICmpnt),validElement(POICmpnt),validElement(Termnl),validElement(Accptr),validList("""AddtlAmt""",AddtlAmt),validElement(AddtlAmt),validElement(TxAmts),validList("""XchgRate""",XchgRate),validElement(XchgRate),validElement(ConvsDtTm),validElement(TxId),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(AcctTo),validElement(AcctFr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(TxChrtcs))|

---

## Value ISO20022.Cain014001.OriginalTransactionCharacteristics1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|TxDesc|String||XmlElement()||
|+|PreAuthstnTmLmt|String||XmlElement()||
|+|AltrnMsgRsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|MsgRsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|OthrTxAttr|String||XmlElement()||
|+|TxAttr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TxSubTp|String||XmlElement()||
|+|TxTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validPattern("""PreAuthstnTmLmt""",PreAuthstnTmLmt,"""[0-9]{1,6}"""),validPattern("""MsgRsn""",MsgRsn,"""[0-9]{4,4}"""),validPattern("""TxTp""",TxTp,"""[0-9A-Z]{2,2}"""))|

---

## Enum ISO20022.Cain014001.OutputFormat1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HTML|Int32||XmlEnum("""HTML""")|1|
||TEXT|Int32||XmlEnum("""TEXT""")|2|
||MREF|Int32||XmlEnum("""MREF""")|3|

---

## Enum ISO20022.Cain014001.OutputFormat4Code


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

## Enum ISO20022.Cain014001.PINEntrySecurityCharacteristic1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SECH|Int32||XmlEnum("""SECH""")|1|
||SECS|Int32||XmlEnum("""SECS""")|2|
||OTHP|Int32||XmlEnum("""OTHP""")|3|
||OTHN|Int32||XmlEnum("""OTHN""")|4|

---

## Enum ISO20022.Cain014001.POIComponentType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SAPR|Int32||XmlEnum("""SAPR""")|1|
||SACP|Int32||XmlEnum("""SACP""")|2|
||TMSP|Int32||XmlEnum("""TMSP""")|3|
||CRTF|Int32||XmlEnum("""CRTF""")|4|
||MRPR|Int32||XmlEnum("""MRPR""")|5|
||OPST|Int32||XmlEnum("""OPST""")|6|
||DRVR|Int32||XmlEnum("""DRVR""")|7|
||MDWR|Int32||XmlEnum("""MDWR""")|8|
||EMVO|Int32||XmlEnum("""EMVO""")|9|
||EMVK|Int32||XmlEnum("""EMVK""")|10|
||APLI|Int32||XmlEnum("""APLI""")|11|
||SECM|Int32||XmlEnum("""SECM""")|12|
||DVCE|Int32||XmlEnum("""DVCE""")|13|
||TERM|Int32||XmlEnum("""TERM""")|14|
||SERV|Int32||XmlEnum("""SERV""")|15|
||SCPR|Int32||XmlEnum("""SCPR""")|16|
||TLPR|Int32||XmlEnum("""TLPR""")|17|
||APPR|Int32||XmlEnum("""APPR""")|18|
||AQPP|Int32||XmlEnum("""AQPP""")|19|

---

## Value ISO20022.Cain014001.Parameter13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MskGnrtrAlgo|ISO20022.Cain014001.AlgorithmIdentification26||XmlElement()||
|+|DgstAlgo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MskGnrtrAlgo))|

---

## Value ISO20022.Cain014001.Parameter14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
|+|NcrptnFrmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain014001.Parameter7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain014001.PartyIdentification284


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|OwnrEthnctyTpPrvddBy|String||XmlElement()||
|+|OwnrEthnctyTp|String||XmlElement()||
|+|CertfctnTpPrvddBy|String||XmlElement()||
|+|CertfctnTp|String||XmlElement()||
|+|OwnrTpPrvddBy|String||XmlElement()||
|+|OwnrTp|String||XmlElement()||
|+|BizTpPrvddBy|String||XmlElement()||
|+|BizTp|String||XmlElement()||
|+|CorpTaxIdTp|String||XmlElement()||
|+|CorpTaxId|String||XmlElement()||
|+|LclData|ISO20022.Cain014001.LocalData11||XmlElement()||
|+|TaxRegnId|String||XmlElement()||
|+|AddtlCtct|String||XmlElement()||
|+|CstmrSvc|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|URLAdr|String||XmlElement()||
|+|Email|String||XmlElement()||
|+|GeogcLctn|String||XmlElement()||
|+|AddtlAdr|String||XmlElement()||
|+|Adr|ISO20022.Cain014001.Address2||XmlElement()||
|+|NmAndLctn|String||XmlElement()||
|+|AddtlId|ISO20022.Cain014001.AdditionalData1||XmlElement()||
|+|LglCorpNm|String||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Assgnr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(LclData),validPattern("""GeogcLctn""",GeogcLctn,"""(\+\|-)?[\d]{1,3}(\.[\d]{1,8})?/(\+\|-)?[\d]{1,3}(\.[\d]{1,8})?"""),validElement(Adr),validElement(AddtlId),validPattern("""Ctry""",Ctry,"""[0-9]{3,3}"""))|

---

## Value ISO20022.Cain014001.PartyIdentification285


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LclData|global::System.Collections.Generic.List<ISO20022.Cain014001.LocalData14>||XmlElement()||
|+|AddtlId|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|LglCorpNm|String||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Assgnr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""LclData""",LclData),validElement(LclData),validList("""AddtlId""",AddtlId),validElement(AddtlId),validPattern("""Ctry""",Ctry,"""[0-9]{3,3}"""))|

---

## Value ISO20022.Cain014001.PartyIdentification286


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LclData|ISO20022.Cain014001.LocalData14||XmlElement()||
|+|AddtlId|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|LglCorpNm|String||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Assgnr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LclData),validList("""AddtlId""",AddtlId),validElement(AddtlId),validPattern("""Ctry""",Ctry,"""[0-9]{3,3}"""),validPattern("""Id""",Id,"""[0-9]{1,11}"""))|

---

## Value ISO20022.Cain014001.PartyIdentification287


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LclData|ISO20022.Cain014001.LocalData15||XmlElement()||
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|DtOfBirth|DateTime||XmlElement()||
|+|CtryOfBirth|String||XmlElement()||
|+|Ntlty|String||XmlElement()||
|+|Ctct|ISO20022.Cain014001.ContactPersonal1||XmlElement()||
|+|Adr|ISO20022.Cain014001.Address2||XmlElement()||
|+|Nm|ISO20022.Cain014001.CardholderName3||XmlElement()||
|+|Crdntls|global::System.Collections.Generic.List<ISO20022.Cain014001.Credentials3>||XmlElement()||
|+|Dsgnt|String||XmlElement()||
|+|Id|String||XmlElement()||
|+|FI|ISO20022.Cain014001.FinancialInstitution8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LclData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,3}"""),validPattern("""Ntlty""",Ntlty,"""[A-Z]{2,3}"""),validElement(Ctct),validElement(Adr),validElement(Nm),validList("""Crdntls""",Crdntls),validElement(Crdntls),validPattern("""Dsgnt""",Dsgnt,"""[0-9]{1,2}"""),validElement(FI))|

---

## Enum ISO20022.Cain014001.PartyType17Code


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

## Enum ISO20022.Cain014001.PartyType18Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGNT|Int32||XmlEnum("""AGNT""")|1|
||CSCH|Int32||XmlEnum("""CSCH""")|2|
||CISS|Int32||XmlEnum("""CISS""")|3|
||ACQR|Int32||XmlEnum("""ACQR""")|4|

---

## Enum ISO20022.Cain014001.PartyType19Code


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

## Enum ISO20022.Cain014001.PartyType20Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGNT|Int32||XmlEnum("""AGNT""")|1|
||CISS|Int32||XmlEnum("""CISS""")|2|
||CRDH|Int32||XmlEnum("""CRDH""")|3|
||ACQR|Int32||XmlEnum("""ACQR""")|4|
||ACCP|Int32||XmlEnum("""ACCP""")|5|

---

## Enum ISO20022.Cain014001.PartyType26Code


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

## Enum ISO20022.Cain014001.PartyType28Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ISUR|Int32||XmlEnum("""ISUR""")|1|
||WLPR|Int32||XmlEnum("""WLPR""")|2|
||OTHP|Int32||XmlEnum("""OTHP""")|3|
||OTHN|Int32||XmlEnum("""OTHN""")|4|
||AGNT|Int32||XmlEnum("""AGNT""")|5|
||ACQR|Int32||XmlEnum("""ACQR""")|6|
||ACCP|Int32||XmlEnum("""ACCP""")|7|

---

## Enum ISO20022.Cain014001.PartyType32Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHP|Int32||XmlEnum("""OTHP""")|1|
||OTHN|Int32||XmlEnum("""OTHN""")|2|
||ISUR|Int32||XmlEnum("""ISUR""")|3|
||AGNT|Int32||XmlEnum("""AGNT""")|4|
||ACQR|Int32||XmlEnum("""ACQR""")|5|

---

## Enum ISO20022.Cain014001.PartyType34Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHP|Int32||XmlEnum("""OTHP""")|1|
||OTHN|Int32||XmlEnum("""OTHN""")|2|
||AGNT|Int32||XmlEnum("""AGNT""")|3|
||CISS|Int32||XmlEnum("""CISS""")|4|
||CRDH|Int32||XmlEnum("""CRDH""")|5|
||ACQR|Int32||XmlEnum("""ACQR""")|6|
||ACCP|Int32||XmlEnum("""ACCP""")|7|

---

## Enum ISO20022.Cain014001.PartyType9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SCHP|Int32||XmlEnum("""SCHP""")|1|
||CSCH|Int32||XmlEnum("""CSCH""")|2|
||CISP|Int32||XmlEnum("""CISP""")|3|
||CISS|Int32||XmlEnum("""CISS""")|4|
||ACQP|Int32||XmlEnum("""ACQP""")|5|
||ACQR|Int32||XmlEnum("""ACQR""")|6|

---

## Value ISO20022.Cain014001.PointOfInteractionComponent16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrlNb|String||XmlElement()||
|+|Id|String||XmlElement()||
|+|PrvdrId|String||XmlElement()||
|+|ItmNb|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain014001.ProcessingResult22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|ErrDtl|global::System.Collections.Generic.List<ISO20022.Cain014001.ErrorDetails3>||XmlElement()||
|+|Actn|global::System.Collections.Generic.List<ISO20022.Cain014001.Action16>||XmlElement()||
|+|ActnReqrd|String||XmlElement()||
|+|TempScrCardDataReusePrtd|String||XmlElement()||
|+|ApprvlCd|String||XmlElement()||
|+|RspnCd|String||XmlElement()||
|+|RspnSrcShrtNm|String||XmlElement()||
|+|RspnSrcCtry|String||XmlElement()||
|+|RspnSrcAssgnr|String||XmlElement()||
|+|RspnSrcOthrTp|String||XmlElement()||
|+|RspnSrcTp|String||XmlElement()||
|+|RspnSrcId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validList("""ErrDtl""",ErrDtl),validElement(ErrDtl),validList("""Actn""",Actn),validElement(Actn),validPattern("""ApprvlCd""",ApprvlCd,"""[a-zA-Z0-9\s]{6}"""),validPattern("""RspnCd""",RspnCd,"""[0-9A-Z]{2,2}"""),validPattern("""RspnSrcCtry""",RspnSrcCtry,"""[A-Z]{2,3}"""))|

---

## Value ISO20022.Cain014001.ProcessingResult25


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|ApprvlCd|String||XmlElement()||
|+|RspnCd|String||XmlElement()||
|+|RspnSrcShrtNm|String||XmlElement()||
|+|RspnSrcCtry|String||XmlElement()||
|+|RspnSrcAssgnr|String||XmlElement()||
|+|RspnSrcOthrTp|String||XmlElement()||
|+|RspnSrcTp|String||XmlElement()||
|+|RspnSrcId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validPattern("""ApprvlCd""",ApprvlCd,"""[a-zA-Z0-9\s]{6}"""),validPattern("""RspnCd""",RspnCd,"""[0-9A-Z]{2,2}"""),validPattern("""RspnSrcCtry""",RspnSrcCtry,"""[A-Z]{2,3}"""))|

---

## Value ISO20022.Cain014001.ProgrammeMode4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdSelctdBy|String||XmlElement()||
|+|AddtlId|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|ApldId|String||XmlElement()||
|+|PropsdId|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlId""",AddtlId),validElement(AddtlId))|

---

## Value ISO20022.Cain014001.ProgrammeMode5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlId|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|ApldId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlId""",AddtlId),validElement(AddtlId))|

---

## Value ISO20022.Cain014001.ProtectedData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdData|ISO20022.Cain014001.EncryptedData2||XmlElement()||
|+|EnvlpdData|ISO20022.Cain014001.EnvelopedData12||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcrptdData),validElement(EnvlpdData))|

---

## Enum ISO20022.Cain014001.ProtectionMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TEEN|Int32||XmlEnum("""TEEN""")|1|
||SOFT|Int32||XmlEnum("""SOFT""")|2|
||SNCL|Int32||XmlEnum("""SNCL""")|3|
||SELM|Int32||XmlEnum("""SELM""")|4|
||OTHP|Int32||XmlEnum("""OTHP""")|5|
||OTHN|Int32||XmlEnum("""OTHN""")|6|

---

## Enum ISO20022.Cain014001.PurchaseIdentifierType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TREF|Int32||XmlEnum("""TREF""")|1|
||TRNU|Int32||XmlEnum("""TRNU""")|2|
||REAG|Int32||XmlEnum("""REAG""")|3|
||CUPO|Int32||XmlEnum("""CUPO""")|4|
||CUOR|Int32||XmlEnum("""CUOR""")|5|
||ORNU|Int32||XmlEnum("""ORNU""")|6|
||PRNU|Int32||XmlEnum("""PRNU""")|7|
||FONU|Int32||XmlEnum("""FONU""")|8|
||CONU|Int32||XmlEnum("""CONU""")|9|
||SUOR|Int32||XmlEnum("""SUOR""")|10|
||TINU|Int32||XmlEnum("""TINU""")|11|
||RSNU|Int32||XmlEnum("""RSNU""")|12|
||RENU|Int32||XmlEnum("""RENU""")|13|
||PUID|Int32||XmlEnum("""PUID""")|14|
||INNU|Int32||XmlEnum("""INNU""")|15|
||RELO|Int32||XmlEnum("""RELO""")|16|
||SUIN|Int32||XmlEnum("""SUIN""")|17|
||OTHP|Int32||XmlEnum("""OTHP""")|18|
||OTHN|Int32||XmlEnum("""OTHN""")|19|

---

## Enum ISO20022.Cain014001.QRCodePresentmentMode1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MPMD|Int32||XmlEnum("""MPMD""")|1|
||OTHP|Int32||XmlEnum("""OTHP""")|2|
||OTHN|Int32||XmlEnum("""OTHN""")|3|
||CPMD|Int32||XmlEnum("""CPMD""")|4|

---

## Enum ISO20022.Cain014001.ReceiptType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||URID|Int32||XmlEnum("""URID""")|1|
||SMSM|Int32||XmlEnum("""SMSM""")|2|
||PAPR|Int32||XmlEnum("""PAPR""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||EMAL|Int32||XmlEnum("""EMAL""")|5|

---

## Value ISO20022.Cain014001.Recipient5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeyIdr|ISO20022.Cain014001.KEKIdentifier2||XmlElement()||
|+|IssrAndSrlNb|ISO20022.Cain014001.IssuerAndSerialNumber1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyIdr),validElement(IssrAndSrlNb),validChoice(KeyIdr,IssrAndSrlNb))|

---

## Value ISO20022.Cain014001.Recipient7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeyIdr|ISO20022.Cain014001.KEKIdentifier6||XmlElement()||
|+|KEK|ISO20022.Cain014001.KEK6||XmlElement()||
|+|KeyTrnsprt|ISO20022.Cain014001.KeyTransport6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyIdr),validElement(KEK),validElement(KeyTrnsprt),validChoice(KeyIdr,KEK,KeyTrnsprt))|

---

## Value ISO20022.Cain014001.RecommendationAction1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dtls|global::System.Collections.Generic.List<String>||XmlElement()||
|+|OthrActn|String||XmlElement()||
|+|Actn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain014001.Reconciliation4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ChckptRef|String||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain014001.RelativeDistinguishedName1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AttrVal|String||XmlElement()||
|+|AttrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Aspect ISO20022.Cain014001.RetrievalFulfilmentInitiationV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyTrlr|ISO20022.Cain014001.ContentInformationType41||XmlElement()||
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Cain014001.SupplementaryData1>||XmlElement()||
|+|PrtctdData|global::System.Collections.Generic.List<ISO20022.Cain014001.ProtectedData2>||XmlElement()||
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData2>||XmlElement()||
|+|PrcgRslt|ISO20022.Cain014001.ProcessingResult25||XmlElement()||
|+|RtrvlFlfmtInstrs|global::System.Collections.Generic.List<ISO20022.Cain014001.RetrievalFulfilmentInstructions3>||XmlElement()||
|+|OrgnlTx|ISO20022.Cain014001.OriginalTransaction3||XmlElement()||
|+|DsptData|global::System.Collections.Generic.List<ISO20022.Cain014001.DisputeData4>||XmlElement()||
|+|Rcncltn|ISO20022.Cain014001.Reconciliation4||XmlElement()||
|+|AddtlFee|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalFee3>||XmlElement()||
|+|SttlmSvc|ISO20022.Cain014001.SettlementService6||XmlElement()||
|+|Jursdctn|ISO20022.Cain014001.Jurisdiction2||XmlElement()||
|+|SpclPrgrmmQlfctn|global::System.Collections.Generic.List<ISO20022.Cain014001.SpecialProgrammeQualification2>||XmlElement()||
|+|Wllt|ISO20022.Cain014001.Wallet3||XmlElement()||
|+|Tkn|ISO20022.Cain014001.Token2||XmlElement()||
|+|Pyee|ISO20022.Cain014001.PartyIdentification287||XmlElement()||
|+|Pyer|ISO20022.Cain014001.PartyIdentification287||XmlElement()||
|+|Cntxt|ISO20022.Cain014001.Context24||XmlElement()||
|+|Termnl|ISO20022.Cain014001.Terminal8||XmlElement()||
|+|Accptr|ISO20022.Cain014001.PartyIdentification285||XmlElement()||
|+|ConvsDtTm|ISO20022.Cain014001.DateTime2||XmlElement()||
|+|TxId|ISO20022.Cain014001.TransactionIdentification54||XmlElement()||
|+|Prgrmm|global::System.Collections.Generic.List<ISO20022.Cain014001.ProgrammeMode5>||XmlElement()||
|+|Dstn|ISO20022.Cain014001.PartyIdentification286||XmlElement()||
|+|Issr|ISO20022.Cain014001.PartyIdentification286||XmlElement()||
|+|Rcvr|ISO20022.Cain014001.PartyIdentification286||XmlElement()||
|+|Card|ISO20022.Cain014001.CardData13||XmlElement()||
|+|Sndr|ISO20022.Cain014001.PartyIdentification286||XmlElement()||
|+|Acqrr|ISO20022.Cain014001.PartyIdentification286||XmlElement()||
|+|Orgtr|ISO20022.Cain014001.PartyIdentification286||XmlElement()||
|+|TxChrtcs|ISO20022.Cain014001.TransactionCharacteristics3||XmlElement()||
|+|Hdr|ISO20022.Cain014001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(PrcgRslt),validList("""RtrvlFlfmtInstrs""",RtrvlFlfmtInstrs),validElement(RtrvlFlfmtInstrs),validElement(OrgnlTx),validRequired("""DsptData""",DsptData),validList("""DsptData""",DsptData),validElement(DsptData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validList("""SpclPrgrmmQlfctn""",SpclPrgrmmQlfctn),validElement(SpclPrgrmmQlfctn),validElement(Wllt),validElement(Tkn),validElement(Pyee),validElement(Pyer),validElement(Cntxt),validElement(Termnl),validElement(Accptr),validElement(ConvsDtTm),validElement(TxId),validList("""Prgrmm""",Prgrmm),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(TxChrtcs),validElement(Hdr))|

---

## Value ISO20022.Cain014001.RetrievalFulfilmentInstructions3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Frmt|String||XmlElement()||
|+|Trgt|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Rcpt|String||XmlElement()||
|+|PstlAdr|ISO20022.Cain014001.Address2||XmlElement()||
|+|Ctct|ISO20022.Cain014001.ContactBusiness1||XmlElement()||
|+|ActlDlvryMtd|String||XmlElement()||
|+|EstblishdMtd|global::System.Collections.Generic.List<String>||XmlElement()||
|+|ReqdMtd|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validElement(Ctct))|

---

## Enum ISO20022.Cain014001.RiskAssessment1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DONT|Int32||XmlEnum("""DONT""")|1|
||APPU|Int32||XmlEnum("""APPU""")|2|
||APPH|Int32||XmlEnum("""APPH""")|3|
||APPC|Int32||XmlEnum("""APPC""")|4|

---

## Value ISO20022.Cain014001.RiskAssessment3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalRiskData1>||XmlElement()||
|+|Rcmmndtn|global::System.Collections.Generic.List<ISO20022.Cain014001.RecommendationAction1>||XmlElement()||
|+|Cond|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|Rslt|String||XmlElement()||
|+|Rsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|HghRskTx|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|NttyShrtNm|String||XmlElement()||
|+|NttyCtry|String||XmlElement()||
|+|NttyAssgnr|String||XmlElement()||
|+|OthrNttyTp|String||XmlElement()||
|+|NttyTp|String||XmlElement()||
|+|NttyId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validList("""Rcmmndtn""",Rcmmndtn),validElement(Rcmmndtn),validList("""Cond""",Cond),validElement(Cond),validPattern("""NttyCtry""",NttyCtry,"""[0-9]{3,3}"""))|

---

## Value ISO20022.Cain014001.RiskContext3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Assmnt|global::System.Collections.Generic.List<ISO20022.Cain014001.RiskAssessment3>||XmlElement()||
|+|InptData|global::System.Collections.Generic.List<ISO20022.Cain014001.RiskInputData2>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Assmnt""",Assmnt),validElement(Assmnt),validList("""InptData""",InptData),validElement(InptData))|

---

## Value ISO20022.Cain014001.RiskInputData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|OthrNttyTp|String||XmlElement()||
|+|NttyTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Cain014001.SecurityCharacteristics1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHP|Int32||XmlEnum("""OTHP""")|1|
||OTHN|Int32||XmlEnum("""OTHN""")|2|
||AETE|Int32||XmlEnum("""AETE""")|3|
||APTE|Int32||XmlEnum("""APTE""")|4|
||STAM|Int32||XmlEnum("""STAM""")|5|
||PRVN|Int32||XmlEnum("""PRVN""")|6|
||PRAM|Int32||XmlEnum("""PRAM""")|7|
||PRAE|Int32||XmlEnum("""PRAE""")|8|
||PKIE|Int32||XmlEnum("""PKIE""")|9|
||PMAC|Int32||XmlEnum("""PMAC""")|10|
||OPNN|Int32||XmlEnum("""OPNN""")|11|
||MPTE|Int32||XmlEnum("""MPTE""")|12|
||METE|Int32||XmlEnum("""METE""")|13|
||ETEE|Int32||XmlEnum("""ETEE""")|14|
||CMAC|Int32||XmlEnum("""CMAC""")|15|
||CENC|Int32||XmlEnum("""CENC""")|16|
||CPTE|Int32||XmlEnum("""CPTE""")|17|
||CETE|Int32||XmlEnum("""CETE""")|18|

---

## Value ISO20022.Cain014001.SettlementService6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
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

## Value ISO20022.Cain014001.Software1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Vrsn|String||XmlElement()||
|+|SubTp|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Cain014001.SoftwareType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHN|Int32||XmlEnum("""OTHN""")|1|
||OTHP|Int32||XmlEnum("""OTHP""")|2|
||APSW|Int32||XmlEnum("""APSW""")|3|
||MFSW|Int32||XmlEnum("""MFSW""")|4|
||MFFW|Int32||XmlEnum("""MFFW""")|5|

---

## Value ISO20022.Cain014001.SpecialProgrammeDetails2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain014001.SpecialProgrammeQualification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dtl|global::System.Collections.Generic.List<ISO20022.Cain014001.SpecialProgrammeDetails2>||XmlElement()||
|+|Prgrmm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Dtl""",Dtl),validElement(Dtl))|

---

## Enum ISO20022.Cain014001.StorageLocation1Code


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

## Value ISO20022.Cain014001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Cain014001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Cain014001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Cain014001.Terminal8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlId|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlId""",AddtlId),validElement(AddtlId))|

---

## Value ISO20022.Cain014001.Terminal9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CertfctnId|String||XmlElement()||
|+|Sftwr|global::System.Collections.Generic.List<ISO20022.Cain014001.Software1>||XmlElement()||
|+|SrlNb|String||XmlElement()||
|+|OnBrd|String||XmlElement()||
|+|OffPrmiss|String||XmlElement()||
|+|Outdr|String||XmlElement()||
|+|GeogcLctn|String||XmlElement()||
|+|IntgtnTp|String||XmlElement()||
|+|TempScrStorg|String||XmlElement()||
|+|CrdhldrVrfctnCpblty|global::System.Collections.Generic.List<ISO20022.Cain014001.CardholderVerificationCapabilities1>||XmlElement()||
|+|MsgCpblty|global::System.Collections.Generic.List<ISO20022.Cain014001.DisplayCapabilities6>||XmlElement()||
|+|OnLineCpblty|String||XmlElement()||
|+|CardCaptrCpbl|String||XmlElement()||
|+|MxScrptLngth|Decimal||XmlElement()||
|+|ApprvlCdLngth|Decimal||XmlElement()||
|+|OthrPINNtrySctyChrtc|String||XmlElement()||
|+|PINNtrySctyChrtc|String||XmlElement()||
|+|PINLngthCpblty|Decimal||XmlElement()||
|+|WrtgCpblty|global::System.Collections.Generic.List<ISO20022.Cain014001.CardWritingCapabilities1>||XmlElement()||
|+|RdngCpblty|global::System.Collections.Generic.List<ISO20022.Cain014001.CardReadingCapabilities1>||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|AddtlId|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Sftwr""",Sftwr),validElement(Sftwr),validPattern("""GeogcLctn""",GeogcLctn,"""(\+\|-)?[\d]{1,3}(\.[\d]{1,8})?/(\+\|-)?[\d]{1,3}(\.[\d]{1,8})?"""),validList("""CrdhldrVrfctnCpblty""",CrdhldrVrfctnCpblty),validElement(CrdhldrVrfctnCpblty),validList("""MsgCpblty""",MsgCpblty),validElement(MsgCpblty),validList("""WrtgCpblty""",WrtgCpblty),validElement(WrtgCpblty),validList("""RdngCpblty""",RdngCpblty),validElement(RdngCpblty),validList("""AddtlId""",AddtlId),validElement(AddtlId))|

---

## Enum ISO20022.Cain014001.TerminalIntegrationCategory1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SSLE|Int32||XmlEnum("""SSLE""")|1|
||MSLE|Int32||XmlEnum("""MSLE""")|2|
||MPOI|Int32||XmlEnum("""MPOI""")|3|

---

## Enum ISO20022.Cain014001.TerminalType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||POST|Int32||XmlEnum("""POST""")|1|
||OTHP|Int32||XmlEnum("""OTHP""")|2|
||OTHN|Int32||XmlEnum("""OTHN""")|3|
||MPOS|Int32||XmlEnum("""MPOS""")|4|
||ATMT|Int32||XmlEnum("""ATMT""")|5|

---

## Value ISO20022.Cain014001.Token2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
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

## Value ISO20022.Cain014001.Traceability10


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

## Value ISO20022.Cain014001.Track2Data1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HexBinryVal|String||XmlElement()||
|+|TxtVal|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""HexBinryVal""",HexBinryVal,"""([0-9A-F][0-9A-F]){1,19}"""),validChoice(HexBinryVal,TxtVal))|

---

## Value ISO20022.Cain014001.TransactionAmounts3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtldAmt|global::System.Collections.Generic.List<ISO20022.Cain014001.DetailedAmount22>||XmlElement()||
|+|RcncltnFctvXchgRate|Decimal||XmlElement()||
|+|RcncltnCcy|String||XmlElement()||
|+|RcncltnAmt|Decimal||XmlElement()||
|+|CrdhldrBllgFctvXchgRate|Decimal||XmlElement()||
|+|CrdhldrBllgCcy|String||XmlElement()||
|+|CrdhldrBllgAmt|Decimal||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
|+|AmtQlfr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""DtldAmt""",DtldAmt),validElement(DtldAmt),validPattern("""RcncltnCcy""",RcncltnCcy,"""[0-9]{3,3}"""),validPattern("""CrdhldrBllgCcy""",CrdhldrBllgCcy,"""[0-9]{3,3}"""),validPattern("""Ccy""",Ccy,"""[0-9]{3,3}"""))|

---

## Enum ISO20022.Cain014001.TransactionAttribute2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UCOF|Int32||XmlEnum("""UCOF""")|1|
||TPUP|Int32||XmlEnum("""TPUP""")|2|
||SUBR|Int32||XmlEnum("""SUBR""")|3|
||RCPT|Int32||XmlEnum("""RCPT""")|4|
||PPYT|Int32||XmlEnum("""PPYT""")|5|
||PACP|Int32||XmlEnum("""PACP""")|6|
||PAUT|Int32||XmlEnum("""PAUT""")|7|
||OTHP|Int32||XmlEnum("""OTHP""")|8|
||OTHN|Int32||XmlEnum("""OTHN""")|9|
||INST|Int32||XmlEnum("""INST""")|10|
||FRCP|Int32||XmlEnum("""FRCP""")|11|
||INCR|Int32||XmlEnum("""INCR""")|12|
||DFRD|Int32||XmlEnum("""DFRD""")|13|
||DBRP|Int32||XmlEnum("""DBRP""")|14|
||DBRC|Int32||XmlEnum("""DBRC""")|15|
||CPLT|Int32||XmlEnum("""CPLT""")|16|
||CADB|Int32||XmlEnum("""CADB""")|17|
||AGGR|Int32||XmlEnum("""AGGR""")|18|

---

## Value ISO20022.Cain014001.TransactionCharacteristics3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|TxDesc|String||XmlElement()||
|+|AltrnMsgRsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|MsgRsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Cxl|String||XmlElement()||
|+|OthrTxAttr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TxAttr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TxSubTp|String||XmlElement()||
|+|TxTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validPattern("""MsgRsn""",MsgRsn,"""[0-9]{4,4}"""),validPattern("""TxTp""",TxTp,"""[0-9A-Z]{2,2}"""))|

---

## Value ISO20022.Cain014001.TransactionIdentification54


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IssrRefData|String||XmlElement()||
|+|AcqrrRefNb|String||XmlElement()||
|+|AcqrrRefData|String||XmlElement()||
|+|LifeCyclIdMssng|String||XmlElement()||
|+|AuthntcnTkn|String||XmlElement()||
|+|PresntmntSeqCnt|String||XmlElement()||
|+|PresntmntSeqNb|String||XmlElement()||
|+|AuthstnSeqNb|String||XmlElement()||
|+|LifeCyclId|String||XmlElement()||
|+|LifeCyclSpprt|String||XmlElement()||
|+|RtrvlRefNb|String||XmlElement()||
|+|SysTracAudtNb|String||XmlElement()||
|+|TrnsmssnDtTm|DateTime||XmlElement()||
|+|PurchsIdr|String||XmlElement()||
|+|OthrPurchsIdrTp|String||XmlElement()||
|+|PurchsIdrTp|String||XmlElement()||
|+|TmZone|String||XmlElement()||
|+|LclTm|DateTime||XmlElement()||
|+|LclDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AcqrrRefNb""",AcqrrRefNb,"""[0-9]{1,23}"""),validPattern("""PresntmntSeqCnt""",PresntmntSeqCnt,"""[0-9]{2}"""),validPattern("""PresntmntSeqNb""",PresntmntSeqNb,"""[0-9]{2}"""),validPattern("""AuthstnSeqNb""",AuthstnSeqNb,"""[0-9]{2}"""),validPattern("""SysTracAudtNb""",SysTracAudtNb,"""[0-9]{1,12}"""))|

---

## Enum ISO20022.Cain014001.TransactionInitiator1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CUST|Int32||XmlEnum("""CUST""")|1|
||MERC|Int32||XmlEnum("""MERC""")|2|

---

## Enum ISO20022.Cain014001.TypeOfAmount21Code


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

## Enum ISO20022.Cain014001.TypeOfAmount22Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RESD|Int32||XmlEnum("""RESD""")|1|
||PRXY|Int32||XmlEnum("""PRXY""")|2|
||MAXI|Int32||XmlEnum("""MAXI""")|3|
||ESTM|Int32||XmlEnum("""ESTM""")|4|
||DPST|Int32||XmlEnum("""DPST""")|5|
||DFLT|Int32||XmlEnum("""DFLT""")|6|
||ACTL|Int32||XmlEnum("""ACTL""")|7|

---

## Enum ISO20022.Cain014001.UserInterface1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MRCP|Int32||XmlEnum("""MRCP""")|1|
||MDSP|Int32||XmlEnum("""MDSP""")|2|
||CRCP|Int32||XmlEnum("""CRCP""")|3|
||CDSP|Int32||XmlEnum("""CDSP""")|4|

---

## Enum ISO20022.Cain014001.UserInterface8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHN|Int32||XmlEnum("""OTHN""")|1|
||OTHP|Int32||XmlEnum("""OTHP""")|2|
||LOGF|Int32||XmlEnum("""LOGF""")|3|
||FILE|Int32||XmlEnum("""FILE""")|4|
||DSPU|Int32||XmlEnum("""DSPU""")|5|

---

## Enum ISO20022.Cain014001.Verification3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ERRR|Int32||XmlEnum("""ERRR""")|1|
||SUCC|Int32||XmlEnum("""SUCC""")|2|
||PART|Int32||XmlEnum("""PART""")|3|
||OTHP|Int32||XmlEnum("""OTHP""")|4|
||OTHN|Int32||XmlEnum("""OTHN""")|5|
||NOVF|Int32||XmlEnum("""NOVF""")|6|
||NOSP|Int32||XmlEnum("""NOSP""")|7|
||MISS|Int32||XmlEnum("""MISS""")|8|
||FUTA|Int32||XmlEnum("""FUTA""")|9|
||FAIL|Int32||XmlEnum("""FAIL""")|10|

---

## Value ISO20022.Cain014001.Verification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|RsltDtls|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|OthrRslt|String||XmlElement()||
|+|Rslt|String||XmlElement()||
|+|OthrNtty|String||XmlElement()||
|+|Ntty|String||XmlElement()||
|+|SubTp|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""RsltDtls""",RsltDtls),validElement(RsltDtls))|

---

## Enum ISO20022.Cain014001.VerificationEntity2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ICCA|Int32||XmlEnum("""ICCA""")|1|
||CDAD|Int32||XmlEnum("""CDAD""")|2|
||OTHP|Int32||XmlEnum("""OTHP""")|3|
||OTHN|Int32||XmlEnum("""OTHN""")|4|
||ISSR|Int32||XmlEnum("""ISSR""")|5|
||AGNT|Int32||XmlEnum("""AGNT""")|6|
||ACQR|Int32||XmlEnum("""ACQR""")|7|
||MERC|Int32||XmlEnum("""MERC""")|8|

---

## Value ISO20022.Cain014001.Wallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Cain014001.AdditionalData1>||XmlElement()||
|+|PrvdrAcctScore|Decimal||XmlElement()||
|+|PrvdrDvcScore|Decimal||XmlElement()||
|+|PrvdrPhneScore|Decimal||XmlElement()||
|+|PrvdrRskAssmntMdlVrsn|String||XmlElement()||
|+|PrvdrRskAssmnt|String||XmlElement()||
|+|AcctEmailAge|Decimal||XmlElement()||
|+|OthrCardDataNtryMd|String||XmlElement()||
|+|CardDataNtryMd|String||XmlElement()||
|+|AcctCtry|String||XmlElement()||
|+|SspdCrds|Decimal||XmlElement()||
|+|LastWlltChng|Decimal||XmlElement()||
|+|ActvtyIntrvl|String||XmlElement()||
|+|Actvty|Decimal||XmlElement()||
|+|DaysSncLastActvty|Decimal||XmlElement()||
|+|AcctAge|Decimal||XmlElement()||
|+|UsrAcctAge|Decimal||XmlElement()||
|+|PANAge|Decimal||XmlElement()||
|+|Prvdr|ISO20022.Cain014001.PartyIdentification285||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validPattern("""AcctCtry""",AcctCtry,"""[A-Z]{2,3}"""),validElement(Prvdr))|

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

