# caam.001.001.04
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Caam001001.ATMCommand15 {
        + AddtlErrInf  : String
        + Rslt  : String
        + CmdId  : ISO20022.Caam001001.ATMCommandIdentification1
        + PrcdDtTm  : DateTime
        + ReqrdDtTm  : DateTime
        + Tp  : String
    }
    ISO20022.Caam001001.ATMCommand15 *-- ISO20022.Caam001001.ATMCommandIdentification1
    class ISO20022.Caam001001.ATMCommand16 {
        + CmdId  : ISO20022.Caam001001.ATMCommandIdentification1
        + Tp  : String
    }
    ISO20022.Caam001001.ATMCommand16 *-- ISO20022.Caam001001.ATMCommandIdentification1
    class ISO20022.Caam001001.ATMCommand7Code {
        RREQ = 1
        KCHG = 2
        HKRV = 3
        HKCG = 4
        SNDM = 5
        SSTU = 6
        SSCU = 7
        SCFU = 8
        KRMV = 9
        KDWL = 10
        KDAC = 11
        KACT = 12
        DISC = 13
        CCNT = 14
        CFGT = 15
        ASTS = 16
        ABAL = 17
    }
    class ISO20022.Caam001001.ATMCommandIdentification1 {
        + Prcr  : String
        + Ref  : String
        + Orgn  : String
    }
    class ISO20022.Caam001001.ATMConfigurationParameter1 {
        + Vrsn  : String
        + Tp  : String
    }
    class ISO20022.Caam001001.ATMDevice2Code {
        RWDR = 1
        SCAN = 2
        RPRN = 3
        PINR = 4
        PSBK = 5
        SNSR = 6
        JPRN = 7
        JRNL = 8
        INPM = 9
        DOOR = 10
        DPRN = 11
        DPST = 12
        CDIS = 13
        CHCK = 14
        CSHR = 15
        CSHI = 16
        CSHD = 17
        CRDR = 18
        CRDD = 19
        CAMR = 20
        BRCD = 21
        ALRM = 22
    }
    class ISO20022.Caam001001.ATMDeviceReport4 {
        + ATMSctyCntxt  : ISO20022.Caam001001.ATMSecurityContext5
        + CmdCntxt  : ISO20022.Caam001001.ATMCommand16
        + CmdRslt  : global::System.Collections.Generic.List~ISO20022.Caam001001.ATMCommand15~
        + ATMGblSts  : ISO20022.Caam001001.ATMStatus2
        + Envt  : ISO20022.Caam001001.ATMEnvironment6
    }
    ISO20022.Caam001001.ATMDeviceReport4 *-- ISO20022.Caam001001.ATMSecurityContext5
    ISO20022.Caam001001.ATMDeviceReport4 *-- ISO20022.Caam001001.ATMCommand16
    ISO20022.Caam001001.ATMDeviceReport4 *-- ISO20022.Caam001001.ATMCommand15
    ISO20022.Caam001001.ATMDeviceReport4 *-- ISO20022.Caam001001.ATMStatus2
    ISO20022.Caam001001.ATMDeviceReport4 *-- ISO20022.Caam001001.ATMEnvironment6
    class ISO20022.Caam001001.ATMDeviceReportV04 {
        + SctyTrlr  : ISO20022.Caam001001.ContentInformationType13
        + ATMDvcRpt  : ISO20022.Caam001001.ATMDeviceReport4
        + PrtctdATMDvcRpt  : ISO20022.Caam001001.ContentInformationType10
        + Hdr  : ISO20022.Caam001001.Header31
    }
    ISO20022.Caam001001.ATMDeviceReportV04 *-- ISO20022.Caam001001.ContentInformationType13
    ISO20022.Caam001001.ATMDeviceReportV04 *-- ISO20022.Caam001001.ATMDeviceReport4
    ISO20022.Caam001001.ATMDeviceReportV04 *-- ISO20022.Caam001001.ContentInformationType10
    ISO20022.Caam001001.ATMDeviceReportV04 *-- ISO20022.Caam001001.Header31
    class ISO20022.Caam001001.ATMEnvironment6 {
        + ATM  : ISO20022.Caam001001.AutomatedTellerMachine5
        + HstgNtty  : ISO20022.Caam001001.TerminalHosting1
        + ATMMgrId  : String
        + Acqrr  : ISO20022.Caam001001.Acquirer7
    }
    ISO20022.Caam001001.ATMEnvironment6 *-- ISO20022.Caam001001.AutomatedTellerMachine5
    ISO20022.Caam001001.ATMEnvironment6 *-- ISO20022.Caam001001.TerminalHosting1
    ISO20022.Caam001001.ATMEnvironment6 *-- ISO20022.Caam001001.Acquirer7
    class ISO20022.Caam001001.ATMEquipment1 {
        + CfgtnParam  : global::System.Collections.Generic.List~ISO20022.Caam001001.ATMConfigurationParameter1~
        + ApprvlNb  : String
        + ApplVrsn  : String
        + ApplNm  : String
        + ApplPrvdr  : String
        + SrlNb  : String
        + Mdl  : String
        + Manfctr  : String
    }
    ISO20022.Caam001001.ATMEquipment1 *-- ISO20022.Caam001001.ATMConfigurationParameter1
    class ISO20022.Caam001001.ATMEquipment2 {
        + FrmwrVrsn  : String
        + FrmwrId  : String
        + FrmwrPrvdr  : String
        + SrlNb  : String
        + Vrsn  : String
        + Mdl  : String
        + Manfctr  : String
    }
    class ISO20022.Caam001001.ATMMessageFunction2 {
        + HstSvcCd  : String
        + ATMSvcCd  : String
        + Fctn  : String
    }
    class ISO20022.Caam001001.ATMSecurityConfiguration1 {
        + MsgPrtcn  : global::System.Collections.Generic.List~String~
        + PIN  : ISO20022.Caam001001.ATMSecurityConfiguration5
        + DgtlSgntr  : ISO20022.Caam001001.ATMSecurityConfiguration4
        + DgstAlgo  : global::System.Collections.Generic.List~String~
        + MACAlgo  : global::System.Collections.Generic.List~String~
        + Ncrptn  : ISO20022.Caam001001.ATMSecurityConfiguration3
        + Keys  : ISO20022.Caam001001.ATMSecurityConfiguration2
    }
    ISO20022.Caam001001.ATMSecurityConfiguration1 *-- ISO20022.Caam001001.ATMSecurityConfiguration5
    ISO20022.Caam001001.ATMSecurityConfiguration1 *-- ISO20022.Caam001001.ATMSecurityConfiguration4
    ISO20022.Caam001001.ATMSecurityConfiguration1 *-- ISO20022.Caam001001.ATMSecurityConfiguration3
    ISO20022.Caam001001.ATMSecurityConfiguration1 *-- ISO20022.Caam001001.ATMSecurityConfiguration2
    class ISO20022.Caam001001.ATMSecurityConfiguration2 {
        + MaxRootKeyLngth  : Decimal
        + MaxRSAKeyLngth  : Decimal
        + MaxAsmmtrcKey  : Decimal
        + MaxSmmtrcKey  : Decimal
    }
    class ISO20022.Caam001001.ATMSecurityConfiguration3 {
        + NcrptnFrmt  : global::System.Collections.Generic.List~String~
        + SmmtrcNcrptnAlgo  : global::System.Collections.Generic.List~String~
        + SmmtrcTrnsprtKeyAlgo  : global::System.Collections.Generic.List~String~
        + SmmtrcTrnsprtKey  : String
        + AsmmtrcNcrptnAlgo  : global::System.Collections.Generic.List~String~
        + AsmmtrcKeyStdId  : String
        + AsmmtrcNcrptn  : String
    }
    class ISO20022.Caam001001.ATMSecurityConfiguration4 {
        + DgtlSgntrAlgo  : global::System.Collections.Generic.List~String~
        + MaxSgntrs  : Decimal
        + MaxCerts  : Decimal
    }
    class ISO20022.Caam001001.ATMSecurityConfiguration5 {
        + PINLngthCpblties  : Decimal
        + PINFrmt  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Caam001001.ATMSecurityContext5 {
        + HstChllng  : String
        + Key  : global::System.Collections.Generic.List~ISO20022.Caam001001.CryptographicKey11~
        + SctyDvc  : ISO20022.Caam001001.ATMSecurityDevice2
        + SctySchmeCpblties  : global::System.Collections.Generic.List~String~
        + CurSctySchme  : String
    }
    ISO20022.Caam001001.ATMSecurityContext5 *-- ISO20022.Caam001001.CryptographicKey11
    ISO20022.Caam001001.ATMSecurityContext5 *-- ISO20022.Caam001001.ATMSecurityDevice2
    class ISO20022.Caam001001.ATMSecurityDevice2 {
        + BndgStat  : String
        + Incdnt  : String
        + CurSts  : String
        + SpprtdCfgtn  : ISO20022.Caam001001.ATMSecurityConfiguration1
        + CurCfgtn  : ISO20022.Caam001001.ATMSecurityConfiguration1
        + DvcPrprty  : ISO20022.Caam001001.ATMEquipment2
    }
    ISO20022.Caam001001.ATMSecurityDevice2 *-- ISO20022.Caam001001.ATMSecurityConfiguration1
    ISO20022.Caam001001.ATMSecurityDevice2 *-- ISO20022.Caam001001.ATMSecurityConfiguration1
    ISO20022.Caam001001.ATMSecurityDevice2 *-- ISO20022.Caam001001.ATMEquipment2
    class ISO20022.Caam001001.ATMSecurityScheme3Code {
        TR34 = 1
        NONE = 2
        SIGN = 3
        PKIP = 4
        MANU = 5
        LUXG = 6
        DTCH = 7
        FRAN = 8
        CERT = 9
        APPK = 10
    }
    class ISO20022.Caam001001.ATMSecurityScheme4Code {
        TR34 = 1
        SIGN = 2
        PKIP = 3
        MANU = 4
        LUXG = 5
        DTCH = 6
        FRAN = 7
        CERT = 8
        APPK = 9
    }
    class ISO20022.Caam001001.ATMStatus1Code {
        OUTS = 1
        INSV = 2
    }
    class ISO20022.Caam001001.ATMStatus2 {
        + DmnddSts  : String
        + CurStsRsn  : global::System.Collections.Generic.List~String~
        + CurSts  : String
    }
    class ISO20022.Caam001001.ATMStatus2Code {
        OUTS = 1
        OPER = 2
    }
    class ISO20022.Caam001001.ATMStatus3Code {
        WACT = 1
        STOP = 2
        OPER = 3
    }
    class ISO20022.Caam001001.Acquirer7 {
        + Brnch  : String
        + AcqrgInstn  : String
    }
    class ISO20022.Caam001001.Algorithm11Code {
        HS01 = 1
        HS51 = 2
        HS38 = 3
        HS25 = 4
    }
    class ISO20022.Caam001001.Algorithm12Code {
        CMA5 = 1
        CMA9 = 2
        MCC1 = 3
        CMA1 = 4
        MCCS = 5
        MACC = 6
    }
    class ISO20022.Caam001001.Algorithm13Code {
        EA5C = 1
        EA9C = 2
        UKA1 = 3
        UKPT = 4
        DKP9 = 5
        E3DC = 6
        EA2C = 7
    }
    class ISO20022.Caam001001.Algorithm14Code {
        RPSS = 1
        ERS1 = 2
        ERS2 = 3
    }
    class ISO20022.Caam001001.Algorithm15Code {
        EA5C = 1
        EA9C = 2
        E3DC = 3
        EA2C = 4
    }
    class ISO20022.Caam001001.Algorithm7Code {
        RSAO = 1
        ERSA = 2
    }
    class ISO20022.Caam001001.Algorithm8Code {
        MGF1 = 1
    }
    class ISO20022.Caam001001.AlgorithmIdentification11 {
        + Param  : ISO20022.Caam001001.Parameter4
        + Algo  : String
    }
    ISO20022.Caam001001.AlgorithmIdentification11 *-- ISO20022.Caam001001.Parameter4
    class ISO20022.Caam001001.AlgorithmIdentification12 {
        + Param  : ISO20022.Caam001001.Parameter5
        + Algo  : String
    }
    ISO20022.Caam001001.AlgorithmIdentification12 *-- ISO20022.Caam001001.Parameter5
    class ISO20022.Caam001001.AlgorithmIdentification13 {
        + Param  : ISO20022.Caam001001.Parameter6
        + Algo  : String
    }
    ISO20022.Caam001001.AlgorithmIdentification13 *-- ISO20022.Caam001001.Parameter6
    class ISO20022.Caam001001.AlgorithmIdentification14 {
        + Param  : ISO20022.Caam001001.Parameter6
        + Algo  : String
    }
    ISO20022.Caam001001.AlgorithmIdentification14 *-- ISO20022.Caam001001.Parameter6
    class ISO20022.Caam001001.AlgorithmIdentification15 {
        + Param  : ISO20022.Caam001001.Parameter7
        + Algo  : String
    }
    ISO20022.Caam001001.AlgorithmIdentification15 *-- ISO20022.Caam001001.Parameter7
    class ISO20022.Caam001001.AlgorithmIdentification16 {
        + Algo  : String
    }
    class ISO20022.Caam001001.AlgorithmIdentification17 {
        + Param  : ISO20022.Caam001001.Parameter8
        + Algo  : String
    }
    ISO20022.Caam001001.AlgorithmIdentification17 *-- ISO20022.Caam001001.Parameter8
    class ISO20022.Caam001001.AttributeType1Code {
        CATT = 1
        OUAT = 2
        OATT = 3
        LATT = 4
        CNAT = 5
    }
    class ISO20022.Caam001001.AuthenticatedData4 {
        + MAC  : String
        + NcpsltdCntt  : ISO20022.Caam001001.EncapsulatedContent3
        + MACAlgo  : ISO20022.Caam001001.AlgorithmIdentification15
        + Rcpt  : global::System.Collections.Generic.List~ISO20022.Caam001001.Recipient4Choice~
        + Vrsn  : Decimal
    }
    ISO20022.Caam001001.AuthenticatedData4 *-- ISO20022.Caam001001.EncapsulatedContent3
    ISO20022.Caam001001.AuthenticatedData4 *-- ISO20022.Caam001001.AlgorithmIdentification15
    ISO20022.Caam001001.AuthenticatedData4 *-- ISO20022.Caam001001.Recipient4Choice
    class ISO20022.Caam001001.AutomatedTellerMachine5 {
        + MsgPrtcn  : String
        + OutOfSvcDvc  : global::System.Collections.Generic.List~String~
        + Eqpmnt  : ISO20022.Caam001001.ATMEquipment1
        + LctnCtgy  : String
        + Lctn  : ISO20022.Caam001001.PostalAddress17
        + BaseCcy  : String
        + SeqNb  : String
        + AddtlId  : String
        + Id  : String
    }
    ISO20022.Caam001001.AutomatedTellerMachine5 *-- ISO20022.Caam001001.ATMEquipment1
    ISO20022.Caam001001.AutomatedTellerMachine5 *-- ISO20022.Caam001001.PostalAddress17
    class ISO20022.Caam001001.BytePadding1Code {
        RAND = 1
        NULL = 2
        NULG = 3
        NUL8 = 4
        LNGT = 5
    }
    class ISO20022.Caam001001.CertificateIssuer1 {
        + RltvDstngshdNm  : global::System.Collections.Generic.List~ISO20022.Caam001001.RelativeDistinguishedName1~
    }
    ISO20022.Caam001001.CertificateIssuer1 *-- ISO20022.Caam001001.RelativeDistinguishedName1
    class ISO20022.Caam001001.ContentInformationType10 {
        + EnvlpdData  : ISO20022.Caam001001.EnvelopedData4
        + CnttTp  : String
    }
    ISO20022.Caam001001.ContentInformationType10 *-- ISO20022.Caam001001.EnvelopedData4
    class ISO20022.Caam001001.ContentInformationType13 {
        + SgndData  : ISO20022.Caam001001.SignedData4
        + AuthntcdData  : ISO20022.Caam001001.AuthenticatedData4
        + CnttTp  : String
    }
    ISO20022.Caam001001.ContentInformationType13 *-- ISO20022.Caam001001.SignedData4
    ISO20022.Caam001001.ContentInformationType13 *-- ISO20022.Caam001001.AuthenticatedData4
    class ISO20022.Caam001001.ContentType2Code {
        AUTH = 1
        DGST = 2
        EVLP = 3
        SIGN = 4
        DATA = 5
    }
    class ISO20022.Caam001001.CryptographicKey11 {
        + FailrRsn  : String
        + CurSts  : String
        + KeyChckVal  : String
        + DeactvtnDt  : DateTime
        + ActvtnDt  : DateTime
        + Fctn  : global::System.Collections.Generic.List~String~
        + Tp  : String
        + SeqCntr  : Decimal
        + Vrsn  : String
        + AddtlId  : String
        + SctyDomnId  : String
        + Id  : String
        + Nm  : String
    }
    class ISO20022.Caam001001.CryptographicKeyType3Code {
        EDE4 = 1
        AES5 = 2
        AES9 = 3
        DKP9 = 4
        EDE3 = 5
        AES2 = 6
    }
    class ISO20022.Caam001001.DataSetCategory7Code {
        MNOC = 1
        LOCC = 2
        AMNT = 3
        OEXR = 4
        CPRC = 5
        CRAP = 6
        APPR = 7
        ATMP = 8
        ATMC = 9
    }
    class ISO20022.Caam001001.EncapsulatedContent3 {
        + Cntt  : String
        + CnttTp  : String
    }
    class ISO20022.Caam001001.EncryptedContent3 {
        + NcrptdData  : String
        + CnttNcrptnAlgo  : ISO20022.Caam001001.AlgorithmIdentification14
        + CnttTp  : String
    }
    ISO20022.Caam001001.EncryptedContent3 *-- ISO20022.Caam001001.AlgorithmIdentification14
    class ISO20022.Caam001001.EncryptionFormat1Code {
        TR34 = 1
        TR31 = 2
    }
    class ISO20022.Caam001001.EnvelopedData4 {
        + NcrptdCntt  : ISO20022.Caam001001.EncryptedContent3
        + Rcpt  : global::System.Collections.Generic.List~ISO20022.Caam001001.Recipient4Choice~
        + Vrsn  : Decimal
    }
    ISO20022.Caam001001.EnvelopedData4 *-- ISO20022.Caam001001.EncryptedContent3
    ISO20022.Caam001001.EnvelopedData4 *-- ISO20022.Caam001001.Recipient4Choice
    class ISO20022.Caam001001.FailureReason5Code {
        HRDW = 1
        SECR = 2
    }
    class ISO20022.Caam001001.FailureReason6Code {
        KLOD = 1
        KCVE = 2
        EXPR = 3
        CMPR = 4
    }
    class ISO20022.Caam001001.GenericIdentification77 {
        + ShrtNm  : String
        + Ctry  : String
        + Issr  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Caam001001.GeographicCoordinates1 {
        + Long  : String
        + Lat  : String
    }
    class ISO20022.Caam001001.GeographicLocation1Choice {
        + UTMCordints  : ISO20022.Caam001001.UTMCoordinates1
        + GeogcCordints  : ISO20022.Caam001001.GeographicCoordinates1
    }
    ISO20022.Caam001001.GeographicLocation1Choice *-- ISO20022.Caam001001.UTMCoordinates1
    ISO20022.Caam001001.GeographicLocation1Choice *-- ISO20022.Caam001001.GeographicCoordinates1
    class ISO20022.Caam001001.Header31 {
        + Tracblt  : global::System.Collections.Generic.List~ISO20022.Caam001001.Traceability4~
        + PrcStat  : String
        + RcptPty  : String
        + InitgPty  : String
        + CreDtTm  : DateTime
        + XchgId  : String
        + PrtcolVrsn  : String
        + MsgFctn  : ISO20022.Caam001001.ATMMessageFunction2
    }
    ISO20022.Caam001001.Header31 *-- ISO20022.Caam001001.Traceability4
    ISO20022.Caam001001.Header31 *-- ISO20022.Caam001001.ATMMessageFunction2
    class ISO20022.Caam001001.IssuerAndSerialNumber1 {
        + SrlNb  : String
        + Issr  : ISO20022.Caam001001.CertificateIssuer1
    }
    ISO20022.Caam001001.IssuerAndSerialNumber1 *-- ISO20022.Caam001001.CertificateIssuer1
    class ISO20022.Caam001001.KEK4 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Caam001001.AlgorithmIdentification13
        + KEKId  : ISO20022.Caam001001.KEKIdentifier2
        + Vrsn  : Decimal
    }
    ISO20022.Caam001001.KEK4 *-- ISO20022.Caam001001.AlgorithmIdentification13
    ISO20022.Caam001001.KEK4 *-- ISO20022.Caam001001.KEKIdentifier2
    class ISO20022.Caam001001.KEKIdentifier2 {
        + DerivtnId  : String
        + SeqNb  : Decimal
        + KeyVrsn  : String
        + KeyId  : String
    }
    class ISO20022.Caam001001.KeyTransport4 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Caam001001.AlgorithmIdentification11
        + RcptId  : ISO20022.Caam001001.Recipient5Choice
        + Vrsn  : Decimal
    }
    ISO20022.Caam001001.KeyTransport4 *-- ISO20022.Caam001001.AlgorithmIdentification11
    ISO20022.Caam001001.KeyTransport4 *-- ISO20022.Caam001001.Recipient5Choice
    class ISO20022.Caam001001.KeyUsage1Code {
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
    class ISO20022.Caam001001.MessageFunction11Code {
        RPTC = 1
        TRFP = 2
        TRFQ = 3
        EXPV = 4
        EXPK = 5
        DPSP = 6
        DPSQ = 7
        DPSV = 8
        DPSK = 9
        SSTS = 10
        SKSC = 11
        DSEC = 12
        CSEC = 13
        TMOP = 14
        H2AQ = 15
        H2AP = 16
        INQC = 17
        WITP = 18
        WITQ = 19
        WITK = 20
        WITV = 21
        RJAP = 22
        RJAQ = 23
        PINP = 24
        PINQ = 25
        KYAP = 26
        KYAQ = 27
        INQP = 28
        INQQ = 29
        GSTS = 30
        DIAP = 31
        DIAQ = 32
        DVCC = 33
        ACMD = 34
        CMPD = 35
        CMPA = 36
        BALN = 37
    }
    class ISO20022.Caam001001.MessageProtection1Code {
        UNPR = 1
        MACM = 2
        MACB = 3
        EVLP = 4
    }
    class ISO20022.Caam001001.PINFormat4Code {
        VIS3 = 1
        VIS2 = 2
        ISO5 = 3
        ISO4 = 4
        ISO3 = 5
        ISO2 = 6
        ISO1 = 7
        ISO0 = 8
        IBM3 = 9
        EMVS = 10
        ECI3 = 11
        ECI2 = 12
        DBLC = 13
        DBLD = 14
        BKSY = 15
        BNCM = 16
        ANSI = 17
    }
    class ISO20022.Caam001001.Parameter4 {
        + MskGnrtrAlgo  : ISO20022.Caam001001.AlgorithmIdentification12
        + DgstAlgo  : String
        + NcrptnFrmt  : String
    }
    ISO20022.Caam001001.Parameter4 *-- ISO20022.Caam001001.AlgorithmIdentification12
    class ISO20022.Caam001001.Parameter5 {
        + DgstAlgo  : String
    }
    class ISO20022.Caam001001.Parameter6 {
        + BPddg  : String
        + InitlstnVctr  : String
        + NcrptnFrmt  : String
    }
    class ISO20022.Caam001001.Parameter7 {
        + BPddg  : String
        + InitlstnVctr  : String
    }
    class ISO20022.Caam001001.Parameter8 {
        + TrlrFld  : Decimal
        + SaltLngth  : Decimal
        + MskGnrtrAlgo  : ISO20022.Caam001001.AlgorithmIdentification12
        + DgstAlgo  : String
    }
    ISO20022.Caam001001.Parameter8 *-- ISO20022.Caam001001.AlgorithmIdentification12
    class ISO20022.Caam001001.PartyType12Code {
        OATM = 1
        ITAG = 2
        HSTG = 3
        DLIS = 4
        CISP = 5
        ATMG = 6
        ACQR = 7
    }
    class ISO20022.Caam001001.PostalAddress17 {
        + GLctn  : ISO20022.Caam001001.GeographicLocation1Choice
        + Ctry  : String
        + CtrySubDvsn  : global::System.Collections.Generic.List~String~
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Caam001001.PostalAddress17 *-- ISO20022.Caam001001.GeographicLocation1Choice
    class ISO20022.Caam001001.Recipient4Choice {
        + KeyIdr  : ISO20022.Caam001001.KEKIdentifier2
        + KEK  : ISO20022.Caam001001.KEK4
        + KeyTrnsprt  : ISO20022.Caam001001.KeyTransport4
    }
    ISO20022.Caam001001.Recipient4Choice *-- ISO20022.Caam001001.KEKIdentifier2
    ISO20022.Caam001001.Recipient4Choice *-- ISO20022.Caam001001.KEK4
    ISO20022.Caam001001.Recipient4Choice *-- ISO20022.Caam001001.KeyTransport4
    class ISO20022.Caam001001.Recipient5Choice {
        + KeyIdr  : ISO20022.Caam001001.KEKIdentifier2
        + IssrAndSrlNb  : ISO20022.Caam001001.IssuerAndSerialNumber1
    }
    ISO20022.Caam001001.Recipient5Choice *-- ISO20022.Caam001001.KEKIdentifier2
    ISO20022.Caam001001.Recipient5Choice *-- ISO20022.Caam001001.IssuerAndSerialNumber1
    class ISO20022.Caam001001.RelativeDistinguishedName1 {
        + AttrVal  : String
        + AttrTp  : String
    }
    class ISO20022.Caam001001.SignedData4 {
        + Sgnr  : global::System.Collections.Generic.List~ISO20022.Caam001001.Signer3~
        + Cert  : global::System.Collections.Generic.List~String~
        + NcpsltdCntt  : ISO20022.Caam001001.EncapsulatedContent3
        + DgstAlgo  : global::System.Collections.Generic.List~ISO20022.Caam001001.AlgorithmIdentification16~
        + Vrsn  : Decimal
    }
    ISO20022.Caam001001.SignedData4 *-- ISO20022.Caam001001.Signer3
    ISO20022.Caam001001.SignedData4 *-- ISO20022.Caam001001.EncapsulatedContent3
    ISO20022.Caam001001.SignedData4 *-- ISO20022.Caam001001.AlgorithmIdentification16
    class ISO20022.Caam001001.Signer3 {
        + Sgntr  : String
        + SgntrAlgo  : ISO20022.Caam001001.AlgorithmIdentification17
        + DgstAlgo  : ISO20022.Caam001001.AlgorithmIdentification16
        + SgnrId  : ISO20022.Caam001001.Recipient5Choice
        + Vrsn  : Decimal
    }
    ISO20022.Caam001001.Signer3 *-- ISO20022.Caam001001.AlgorithmIdentification17
    ISO20022.Caam001001.Signer3 *-- ISO20022.Caam001001.AlgorithmIdentification16
    ISO20022.Caam001001.Signer3 *-- ISO20022.Caam001001.Recipient5Choice
    class ISO20022.Caam001001.TR34Status1Code {
        UBND = 1
        BUND = 2
    }
    class ISO20022.Caam001001.TerminalHosting1 {
        + Id  : String
        + Ctgy  : String
    }
    class ISO20022.Caam001001.TerminalManagementActionResult2Code {
        UKRF = 1
        TIMO = 2
        SYNE = 3
        SUCC = 4
        SECR = 5
        NSUP = 6
        HRDW = 7
        FMTE = 8
        CNTE = 9
    }
    class ISO20022.Caam001001.Traceability4 {
        + TracDtTmOut  : DateTime
        + TracDtTmIn  : DateTime
        + SeqNb  : String
        + RlayId  : ISO20022.Caam001001.GenericIdentification77
    }
    ISO20022.Caam001001.Traceability4 *-- ISO20022.Caam001001.GenericIdentification77
    class ISO20022.Caam001001.TransactionEnvironment2Code {
        PUBL = 1
        PRIV = 2
    }
    class ISO20022.Caam001001.TransactionEnvironment3Code {
        OTHR = 1
        MERC = 2
        BRCH = 3
    }
    class ISO20022.Caam001001.UTMCoordinates1 {
        + UTMNrthwrd  : Decimal
        + UTMEstwrd  : Decimal
        + UTMZone  : String
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

## Value ISO20022.Caam001001.ATMCommand15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlErrInf|String||XmlElement()||
|+|Rslt|String||XmlElement()||
|+|CmdId|ISO20022.Caam001001.ATMCommandIdentification1||XmlElement()||
|+|PrcdDtTm|DateTime||XmlElement()||
|+|ReqrdDtTm|DateTime||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CmdId))|

---

## Value ISO20022.Caam001001.ATMCommand16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CmdId|ISO20022.Caam001001.ATMCommandIdentification1||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CmdId))|

---

## Enum ISO20022.Caam001001.ATMCommand7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RREQ|Int32||XmlEnum("""RREQ""")|1|
||KCHG|Int32||XmlEnum("""KCHG""")|2|
||HKRV|Int32||XmlEnum("""HKRV""")|3|
||HKCG|Int32||XmlEnum("""HKCG""")|4|
||SNDM|Int32||XmlEnum("""SNDM""")|5|
||SSTU|Int32||XmlEnum("""SSTU""")|6|
||SSCU|Int32||XmlEnum("""SSCU""")|7|
||SCFU|Int32||XmlEnum("""SCFU""")|8|
||KRMV|Int32||XmlEnum("""KRMV""")|9|
||KDWL|Int32||XmlEnum("""KDWL""")|10|
||KDAC|Int32||XmlEnum("""KDAC""")|11|
||KACT|Int32||XmlEnum("""KACT""")|12|
||DISC|Int32||XmlEnum("""DISC""")|13|
||CCNT|Int32||XmlEnum("""CCNT""")|14|
||CFGT|Int32||XmlEnum("""CFGT""")|15|
||ASTS|Int32||XmlEnum("""ASTS""")|16|
||ABAL|Int32||XmlEnum("""ABAL""")|17|

---

## Value ISO20022.Caam001001.ATMCommandIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prcr|String||XmlElement()||
|+|Ref|String||XmlElement()||
|+|Orgn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam001001.ATMConfigurationParameter1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Vrsn|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caam001001.ATMDevice2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RWDR|Int32||XmlEnum("""RWDR""")|1|
||SCAN|Int32||XmlEnum("""SCAN""")|2|
||RPRN|Int32||XmlEnum("""RPRN""")|3|
||PINR|Int32||XmlEnum("""PINR""")|4|
||PSBK|Int32||XmlEnum("""PSBK""")|5|
||SNSR|Int32||XmlEnum("""SNSR""")|6|
||JPRN|Int32||XmlEnum("""JPRN""")|7|
||JRNL|Int32||XmlEnum("""JRNL""")|8|
||INPM|Int32||XmlEnum("""INPM""")|9|
||DOOR|Int32||XmlEnum("""DOOR""")|10|
||DPRN|Int32||XmlEnum("""DPRN""")|11|
||DPST|Int32||XmlEnum("""DPST""")|12|
||CDIS|Int32||XmlEnum("""CDIS""")|13|
||CHCK|Int32||XmlEnum("""CHCK""")|14|
||CSHR|Int32||XmlEnum("""CSHR""")|15|
||CSHI|Int32||XmlEnum("""CSHI""")|16|
||CSHD|Int32||XmlEnum("""CSHD""")|17|
||CRDR|Int32||XmlEnum("""CRDR""")|18|
||CRDD|Int32||XmlEnum("""CRDD""")|19|
||CAMR|Int32||XmlEnum("""CAMR""")|20|
||BRCD|Int32||XmlEnum("""BRCD""")|21|
||ALRM|Int32||XmlEnum("""ALRM""")|22|

---

## Value ISO20022.Caam001001.ATMDeviceReport4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ATMSctyCntxt|ISO20022.Caam001001.ATMSecurityContext5||XmlElement()||
|+|CmdCntxt|ISO20022.Caam001001.ATMCommand16||XmlElement()||
|+|CmdRslt|global::System.Collections.Generic.List<ISO20022.Caam001001.ATMCommand15>||XmlElement()||
|+|ATMGblSts|ISO20022.Caam001001.ATMStatus2||XmlElement()||
|+|Envt|ISO20022.Caam001001.ATMEnvironment6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMSctyCntxt),validElement(CmdCntxt),validList("""CmdRslt""",CmdRslt),validElement(CmdRslt),validElement(ATMGblSts),validElement(Envt))|

---

## Aspect ISO20022.Caam001001.ATMDeviceReportV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyTrlr|ISO20022.Caam001001.ContentInformationType13||XmlElement()||
|+|ATMDvcRpt|ISO20022.Caam001001.ATMDeviceReport4||XmlElement()||
|+|PrtctdATMDvcRpt|ISO20022.Caam001001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Caam001001.Header31||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMDvcRpt),validElement(PrtctdATMDvcRpt),validElement(Hdr))|

---

## Value ISO20022.Caam001001.ATMEnvironment6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ATM|ISO20022.Caam001001.AutomatedTellerMachine5||XmlElement()||
|+|HstgNtty|ISO20022.Caam001001.TerminalHosting1||XmlElement()||
|+|ATMMgrId|String||XmlElement()||
|+|Acqrr|ISO20022.Caam001001.Acquirer7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATM),validElement(HstgNtty),validElement(Acqrr))|

---

## Value ISO20022.Caam001001.ATMEquipment1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CfgtnParam|global::System.Collections.Generic.List<ISO20022.Caam001001.ATMConfigurationParameter1>||XmlElement()||
|+|ApprvlNb|String||XmlElement()||
|+|ApplVrsn|String||XmlElement()||
|+|ApplNm|String||XmlElement()||
|+|ApplPrvdr|String||XmlElement()||
|+|SrlNb|String||XmlElement()||
|+|Mdl|String||XmlElement()||
|+|Manfctr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CfgtnParam""",CfgtnParam),validElement(CfgtnParam))|

---

## Value ISO20022.Caam001001.ATMEquipment2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrmwrVrsn|String||XmlElement()||
|+|FrmwrId|String||XmlElement()||
|+|FrmwrPrvdr|String||XmlElement()||
|+|SrlNb|String||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|Mdl|String||XmlElement()||
|+|Manfctr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam001001.ATMMessageFunction2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HstSvcCd|String||XmlElement()||
|+|ATMSvcCd|String||XmlElement()||
|+|Fctn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam001001.ATMSecurityConfiguration1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgPrtcn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PIN|ISO20022.Caam001001.ATMSecurityConfiguration5||XmlElement()||
|+|DgtlSgntr|ISO20022.Caam001001.ATMSecurityConfiguration4||XmlElement()||
|+|DgstAlgo|global::System.Collections.Generic.List<String>||XmlElement()||
|+|MACAlgo|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Ncrptn|ISO20022.Caam001001.ATMSecurityConfiguration3||XmlElement()||
|+|Keys|ISO20022.Caam001001.ATMSecurityConfiguration2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PIN),validElement(DgtlSgntr),validElement(Ncrptn),validElement(Keys))|

---

## Value ISO20022.Caam001001.ATMSecurityConfiguration2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MaxRootKeyLngth|Decimal||XmlElement()||
|+|MaxRSAKeyLngth|Decimal||XmlElement()||
|+|MaxAsmmtrcKey|Decimal||XmlElement()||
|+|MaxSmmtrcKey|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam001001.ATMSecurityConfiguration3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptnFrmt|global::System.Collections.Generic.List<String>||XmlElement()||
|+|SmmtrcNcrptnAlgo|global::System.Collections.Generic.List<String>||XmlElement()||
|+|SmmtrcTrnsprtKeyAlgo|global::System.Collections.Generic.List<String>||XmlElement()||
|+|SmmtrcTrnsprtKey|String||XmlElement()||
|+|AsmmtrcNcrptnAlgo|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AsmmtrcKeyStdId|String||XmlElement()||
|+|AsmmtrcNcrptn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam001001.ATMSecurityConfiguration4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlSgntrAlgo|global::System.Collections.Generic.List<String>||XmlElement()||
|+|MaxSgntrs|Decimal||XmlElement()||
|+|MaxCerts|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam001001.ATMSecurityConfiguration5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PINLngthCpblties|Decimal||XmlElement()||
|+|PINFrmt|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam001001.ATMSecurityContext5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HstChllng|String||XmlElement()||
|+|Key|global::System.Collections.Generic.List<ISO20022.Caam001001.CryptographicKey11>||XmlElement()||
|+|SctyDvc|ISO20022.Caam001001.ATMSecurityDevice2||XmlElement()||
|+|SctySchmeCpblties|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CurSctySchme|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Key""",Key),validElement(Key),validElement(SctyDvc))|

---

## Value ISO20022.Caam001001.ATMSecurityDevice2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BndgStat|String||XmlElement()||
|+|Incdnt|String||XmlElement()||
|+|CurSts|String||XmlElement()||
|+|SpprtdCfgtn|ISO20022.Caam001001.ATMSecurityConfiguration1||XmlElement()||
|+|CurCfgtn|ISO20022.Caam001001.ATMSecurityConfiguration1||XmlElement()||
|+|DvcPrprty|ISO20022.Caam001001.ATMEquipment2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SpprtdCfgtn),validElement(CurCfgtn),validElement(DvcPrprty))|

---

## Enum ISO20022.Caam001001.ATMSecurityScheme3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TR34|Int32||XmlEnum("""TR34""")|1|
||NONE|Int32||XmlEnum("""NONE""")|2|
||SIGN|Int32||XmlEnum("""SIGN""")|3|
||PKIP|Int32||XmlEnum("""PKIP""")|4|
||MANU|Int32||XmlEnum("""MANU""")|5|
||LUXG|Int32||XmlEnum("""LUXG""")|6|
||DTCH|Int32||XmlEnum("""DTCH""")|7|
||FRAN|Int32||XmlEnum("""FRAN""")|8|
||CERT|Int32||XmlEnum("""CERT""")|9|
||APPK|Int32||XmlEnum("""APPK""")|10|

---

## Enum ISO20022.Caam001001.ATMSecurityScheme4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TR34|Int32||XmlEnum("""TR34""")|1|
||SIGN|Int32||XmlEnum("""SIGN""")|2|
||PKIP|Int32||XmlEnum("""PKIP""")|3|
||MANU|Int32||XmlEnum("""MANU""")|4|
||LUXG|Int32||XmlEnum("""LUXG""")|5|
||DTCH|Int32||XmlEnum("""DTCH""")|6|
||FRAN|Int32||XmlEnum("""FRAN""")|7|
||CERT|Int32||XmlEnum("""CERT""")|8|
||APPK|Int32||XmlEnum("""APPK""")|9|

---

## Enum ISO20022.Caam001001.ATMStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OUTS|Int32||XmlEnum("""OUTS""")|1|
||INSV|Int32||XmlEnum("""INSV""")|2|

---

## Value ISO20022.Caam001001.ATMStatus2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DmnddSts|String||XmlElement()||
|+|CurStsRsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CurSts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caam001001.ATMStatus2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OUTS|Int32||XmlEnum("""OUTS""")|1|
||OPER|Int32||XmlEnum("""OPER""")|2|

---

## Enum ISO20022.Caam001001.ATMStatus3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WACT|Int32||XmlEnum("""WACT""")|1|
||STOP|Int32||XmlEnum("""STOP""")|2|
||OPER|Int32||XmlEnum("""OPER""")|3|

---

## Value ISO20022.Caam001001.Acquirer7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Brnch|String||XmlElement()||
|+|AcqrgInstn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caam001001.Algorithm11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HS01|Int32||XmlEnum("""HS01""")|1|
||HS51|Int32||XmlEnum("""HS51""")|2|
||HS38|Int32||XmlEnum("""HS38""")|3|
||HS25|Int32||XmlEnum("""HS25""")|4|

---

## Enum ISO20022.Caam001001.Algorithm12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CMA5|Int32||XmlEnum("""CMA5""")|1|
||CMA9|Int32||XmlEnum("""CMA9""")|2|
||MCC1|Int32||XmlEnum("""MCC1""")|3|
||CMA1|Int32||XmlEnum("""CMA1""")|4|
||MCCS|Int32||XmlEnum("""MCCS""")|5|
||MACC|Int32||XmlEnum("""MACC""")|6|

---

## Enum ISO20022.Caam001001.Algorithm13Code


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

## Enum ISO20022.Caam001001.Algorithm14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RPSS|Int32||XmlEnum("""RPSS""")|1|
||ERS1|Int32||XmlEnum("""ERS1""")|2|
||ERS2|Int32||XmlEnum("""ERS2""")|3|

---

## Enum ISO20022.Caam001001.Algorithm15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EA5C|Int32||XmlEnum("""EA5C""")|1|
||EA9C|Int32||XmlEnum("""EA9C""")|2|
||E3DC|Int32||XmlEnum("""E3DC""")|3|
||EA2C|Int32||XmlEnum("""EA2C""")|4|

---

## Enum ISO20022.Caam001001.Algorithm7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSAO|Int32||XmlEnum("""RSAO""")|1|
||ERSA|Int32||XmlEnum("""ERSA""")|2|

---

## Enum ISO20022.Caam001001.Algorithm8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MGF1|Int32||XmlEnum("""MGF1""")|1|

---

## Value ISO20022.Caam001001.AlgorithmIdentification11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caam001001.Parameter4||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Caam001001.AlgorithmIdentification12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caam001001.Parameter5||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Caam001001.AlgorithmIdentification13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caam001001.Parameter6||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Caam001001.AlgorithmIdentification14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caam001001.Parameter6||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Caam001001.AlgorithmIdentification15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caam001001.Parameter7||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Caam001001.AlgorithmIdentification16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam001001.AlgorithmIdentification17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caam001001.Parameter8||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Enum ISO20022.Caam001001.AttributeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CATT|Int32||XmlEnum("""CATT""")|1|
||OUAT|Int32||XmlEnum("""OUAT""")|2|
||OATT|Int32||XmlEnum("""OATT""")|3|
||LATT|Int32||XmlEnum("""LATT""")|4|
||CNAT|Int32||XmlEnum("""CNAT""")|5|

---

## Value ISO20022.Caam001001.AuthenticatedData4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MAC|String||XmlElement()||
|+|NcpsltdCntt|ISO20022.Caam001001.EncapsulatedContent3||XmlElement()||
|+|MACAlgo|ISO20022.Caam001001.AlgorithmIdentification15||XmlElement()||
|+|Rcpt|global::System.Collections.Generic.List<ISO20022.Caam001001.Recipient4Choice>||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcpsltdCntt),validElement(MACAlgo),validRequired("""Rcpt""",Rcpt),validList("""Rcpt""",Rcpt),validElement(Rcpt))|

---

## Value ISO20022.Caam001001.AutomatedTellerMachine5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgPrtcn|String||XmlElement()||
|+|OutOfSvcDvc|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Eqpmnt|ISO20022.Caam001001.ATMEquipment1||XmlElement()||
|+|LctnCtgy|String||XmlElement()||
|+|Lctn|ISO20022.Caam001001.PostalAddress17||XmlElement()||
|+|BaseCcy|String||XmlElement()||
|+|SeqNb|String||XmlElement()||
|+|AddtlId|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Eqpmnt),validElement(Lctn),validPattern("""BaseCcy""",BaseCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Caam001001.BytePadding1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RAND|Int32||XmlEnum("""RAND""")|1|
||NULL|Int32||XmlEnum("""NULL""")|2|
||NULG|Int32||XmlEnum("""NULG""")|3|
||NUL8|Int32||XmlEnum("""NUL8""")|4|
||LNGT|Int32||XmlEnum("""LNGT""")|5|

---

## Value ISO20022.Caam001001.CertificateIssuer1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltvDstngshdNm|global::System.Collections.Generic.List<ISO20022.Caam001001.RelativeDistinguishedName1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""RltvDstngshdNm""",RltvDstngshdNm),validList("""RltvDstngshdNm""",RltvDstngshdNm),validElement(RltvDstngshdNm))|

---

## Value ISO20022.Caam001001.ContentInformationType10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EnvlpdData|ISO20022.Caam001001.EnvelopedData4||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EnvlpdData))|

---

## Value ISO20022.Caam001001.ContentInformationType13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SgndData|ISO20022.Caam001001.SignedData4||XmlElement()||
|+|AuthntcdData|ISO20022.Caam001001.AuthenticatedData4||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SgndData),validElement(AuthntcdData))|

---

## Enum ISO20022.Caam001001.ContentType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AUTH|Int32||XmlEnum("""AUTH""")|1|
||DGST|Int32||XmlEnum("""DGST""")|2|
||EVLP|Int32||XmlEnum("""EVLP""")|3|
||SIGN|Int32||XmlEnum("""SIGN""")|4|
||DATA|Int32||XmlEnum("""DATA""")|5|

---

## Value ISO20022.Caam001001.CryptographicKey11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FailrRsn|String||XmlElement()||
|+|CurSts|String||XmlElement()||
|+|KeyChckVal|String||XmlElement()||
|+|DeactvtnDt|DateTime||XmlElement()||
|+|ActvtnDt|DateTime||XmlElement()||
|+|Fctn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Tp|String||XmlElement()||
|+|SeqCntr|Decimal||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|AddtlId|String||XmlElement()||
|+|SctyDomnId|String||XmlElement()||
|+|Id|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Fctn""",Fctn))|

---

## Enum ISO20022.Caam001001.CryptographicKeyType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EDE4|Int32||XmlEnum("""EDE4""")|1|
||AES5|Int32||XmlEnum("""AES5""")|2|
||AES9|Int32||XmlEnum("""AES9""")|3|
||DKP9|Int32||XmlEnum("""DKP9""")|4|
||EDE3|Int32||XmlEnum("""EDE3""")|5|
||AES2|Int32||XmlEnum("""AES2""")|6|

---

## Enum ISO20022.Caam001001.DataSetCategory7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MNOC|Int32||XmlEnum("""MNOC""")|1|
||LOCC|Int32||XmlEnum("""LOCC""")|2|
||AMNT|Int32||XmlEnum("""AMNT""")|3|
||OEXR|Int32||XmlEnum("""OEXR""")|4|
||CPRC|Int32||XmlEnum("""CPRC""")|5|
||CRAP|Int32||XmlEnum("""CRAP""")|6|
||APPR|Int32||XmlEnum("""APPR""")|7|
||ATMP|Int32||XmlEnum("""ATMP""")|8|
||ATMC|Int32||XmlEnum("""ATMC""")|9|

---

## Type ISO20022.Caam001001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ATMDvcRpt|ISO20022.Caam001001.ATMDeviceReportV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMDvcRpt))|

---

## Value ISO20022.Caam001001.EncapsulatedContent3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cntt|String||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam001001.EncryptedContent3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdData|String||XmlElement()||
|+|CnttNcrptnAlgo|ISO20022.Caam001001.AlgorithmIdentification14||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CnttNcrptnAlgo))|

---

## Enum ISO20022.Caam001001.EncryptionFormat1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TR34|Int32||XmlEnum("""TR34""")|1|
||TR31|Int32||XmlEnum("""TR31""")|2|

---

## Value ISO20022.Caam001001.EnvelopedData4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdCntt|ISO20022.Caam001001.EncryptedContent3||XmlElement()||
|+|Rcpt|global::System.Collections.Generic.List<ISO20022.Caam001001.Recipient4Choice>||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcrptdCntt),validRequired("""Rcpt""",Rcpt),validList("""Rcpt""",Rcpt),validElement(Rcpt))|

---

## Enum ISO20022.Caam001001.FailureReason5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HRDW|Int32||XmlEnum("""HRDW""")|1|
||SECR|Int32||XmlEnum("""SECR""")|2|

---

## Enum ISO20022.Caam001001.FailureReason6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||KLOD|Int32||XmlEnum("""KLOD""")|1|
||KCVE|Int32||XmlEnum("""KCVE""")|2|
||EXPR|Int32||XmlEnum("""EXPR""")|3|
||CMPR|Int32||XmlEnum("""CMPR""")|4|

---

## Value ISO20022.Caam001001.GenericIdentification77


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[a-zA-Z]{2,3}"""))|

---

## Value ISO20022.Caam001001.GeographicCoordinates1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Long|String||XmlElement()||
|+|Lat|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam001001.GeographicLocation1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UTMCordints|ISO20022.Caam001001.UTMCoordinates1||XmlElement()||
|+|GeogcCordints|ISO20022.Caam001001.GeographicCoordinates1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UTMCordints),validElement(GeogcCordints),validChoice(UTMCordints,GeogcCordints))|

---

## Value ISO20022.Caam001001.Header31


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tracblt|global::System.Collections.Generic.List<ISO20022.Caam001001.Traceability4>||XmlElement()||
|+|PrcStat|String||XmlElement()||
|+|RcptPty|String||XmlElement()||
|+|InitgPty|String||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|XchgId|String||XmlElement()||
|+|PrtcolVrsn|String||XmlElement()||
|+|MsgFctn|ISO20022.Caam001001.ATMMessageFunction2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Tracblt""",Tracblt),validElement(Tracblt),validPattern("""XchgId""",XchgId,"""[0-9]{1,3}"""),validElement(MsgFctn))|

---

## Value ISO20022.Caam001001.IssuerAndSerialNumber1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrlNb|String||XmlElement()||
|+|Issr|ISO20022.Caam001001.CertificateIssuer1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Issr))|

---

## Value ISO20022.Caam001001.KEK4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Caam001001.AlgorithmIdentification13||XmlElement()||
|+|KEKId|ISO20022.Caam001001.KEKIdentifier2||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(KEKId))|

---

## Value ISO20022.Caam001001.KEKIdentifier2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivtnId|String||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|KeyVrsn|String||XmlElement()||
|+|KeyId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam001001.KeyTransport4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Caam001001.AlgorithmIdentification11||XmlElement()||
|+|RcptId|ISO20022.Caam001001.Recipient5Choice||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(RcptId))|

---

## Enum ISO20022.Caam001001.KeyUsage1Code


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

## Enum ISO20022.Caam001001.MessageFunction11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RPTC|Int32||XmlEnum("""RPTC""")|1|
||TRFP|Int32||XmlEnum("""TRFP""")|2|
||TRFQ|Int32||XmlEnum("""TRFQ""")|3|
||EXPV|Int32||XmlEnum("""EXPV""")|4|
||EXPK|Int32||XmlEnum("""EXPK""")|5|
||DPSP|Int32||XmlEnum("""DPSP""")|6|
||DPSQ|Int32||XmlEnum("""DPSQ""")|7|
||DPSV|Int32||XmlEnum("""DPSV""")|8|
||DPSK|Int32||XmlEnum("""DPSK""")|9|
||SSTS|Int32||XmlEnum("""SSTS""")|10|
||SKSC|Int32||XmlEnum("""SKSC""")|11|
||DSEC|Int32||XmlEnum("""DSEC""")|12|
||CSEC|Int32||XmlEnum("""CSEC""")|13|
||TMOP|Int32||XmlEnum("""TMOP""")|14|
||H2AQ|Int32||XmlEnum("""H2AQ""")|15|
||H2AP|Int32||XmlEnum("""H2AP""")|16|
||INQC|Int32||XmlEnum("""INQC""")|17|
||WITP|Int32||XmlEnum("""WITP""")|18|
||WITQ|Int32||XmlEnum("""WITQ""")|19|
||WITK|Int32||XmlEnum("""WITK""")|20|
||WITV|Int32||XmlEnum("""WITV""")|21|
||RJAP|Int32||XmlEnum("""RJAP""")|22|
||RJAQ|Int32||XmlEnum("""RJAQ""")|23|
||PINP|Int32||XmlEnum("""PINP""")|24|
||PINQ|Int32||XmlEnum("""PINQ""")|25|
||KYAP|Int32||XmlEnum("""KYAP""")|26|
||KYAQ|Int32||XmlEnum("""KYAQ""")|27|
||INQP|Int32||XmlEnum("""INQP""")|28|
||INQQ|Int32||XmlEnum("""INQQ""")|29|
||GSTS|Int32||XmlEnum("""GSTS""")|30|
||DIAP|Int32||XmlEnum("""DIAP""")|31|
||DIAQ|Int32||XmlEnum("""DIAQ""")|32|
||DVCC|Int32||XmlEnum("""DVCC""")|33|
||ACMD|Int32||XmlEnum("""ACMD""")|34|
||CMPD|Int32||XmlEnum("""CMPD""")|35|
||CMPA|Int32||XmlEnum("""CMPA""")|36|
||BALN|Int32||XmlEnum("""BALN""")|37|

---

## Enum ISO20022.Caam001001.MessageProtection1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNPR|Int32||XmlEnum("""UNPR""")|1|
||MACM|Int32||XmlEnum("""MACM""")|2|
||MACB|Int32||XmlEnum("""MACB""")|3|
||EVLP|Int32||XmlEnum("""EVLP""")|4|

---

## Enum ISO20022.Caam001001.PINFormat4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VIS3|Int32||XmlEnum("""VIS3""")|1|
||VIS2|Int32||XmlEnum("""VIS2""")|2|
||ISO5|Int32||XmlEnum("""ISO5""")|3|
||ISO4|Int32||XmlEnum("""ISO4""")|4|
||ISO3|Int32||XmlEnum("""ISO3""")|5|
||ISO2|Int32||XmlEnum("""ISO2""")|6|
||ISO1|Int32||XmlEnum("""ISO1""")|7|
||ISO0|Int32||XmlEnum("""ISO0""")|8|
||IBM3|Int32||XmlEnum("""IBM3""")|9|
||EMVS|Int32||XmlEnum("""EMVS""")|10|
||ECI3|Int32||XmlEnum("""ECI3""")|11|
||ECI2|Int32||XmlEnum("""ECI2""")|12|
||DBLC|Int32||XmlEnum("""DBLC""")|13|
||DBLD|Int32||XmlEnum("""DBLD""")|14|
||BKSY|Int32||XmlEnum("""BKSY""")|15|
||BNCM|Int32||XmlEnum("""BNCM""")|16|
||ANSI|Int32||XmlEnum("""ANSI""")|17|

---

## Value ISO20022.Caam001001.Parameter4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MskGnrtrAlgo|ISO20022.Caam001001.AlgorithmIdentification12||XmlElement()||
|+|DgstAlgo|String||XmlElement()||
|+|NcrptnFrmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MskGnrtrAlgo))|

---

## Value ISO20022.Caam001001.Parameter5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgstAlgo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam001001.Parameter6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
|+|NcrptnFrmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam001001.Parameter7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam001001.Parameter8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrlrFld|Decimal||XmlElement()||
|+|SaltLngth|Decimal||XmlElement()||
|+|MskGnrtrAlgo|ISO20022.Caam001001.AlgorithmIdentification12||XmlElement()||
|+|DgstAlgo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MskGnrtrAlgo))|

---

## Enum ISO20022.Caam001001.PartyType12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OATM|Int32||XmlEnum("""OATM""")|1|
||ITAG|Int32||XmlEnum("""ITAG""")|2|
||HSTG|Int32||XmlEnum("""HSTG""")|3|
||DLIS|Int32||XmlEnum("""DLIS""")|4|
||CISP|Int32||XmlEnum("""CISP""")|5|
||ATMG|Int32||XmlEnum("""ATMG""")|6|
||ACQR|Int32||XmlEnum("""ACQR""")|7|

---

## Value ISO20022.Caam001001.PostalAddress17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|GLctn|ISO20022.Caam001001.GeographicLocation1Choice||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GLctn),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validListMax("""CtrySubDvsn""",CtrySubDvsn,2),validListMax("""AdrLine""",AdrLine,2))|

---

## Value ISO20022.Caam001001.Recipient4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeyIdr|ISO20022.Caam001001.KEKIdentifier2||XmlElement()||
|+|KEK|ISO20022.Caam001001.KEK4||XmlElement()||
|+|KeyTrnsprt|ISO20022.Caam001001.KeyTransport4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyIdr),validElement(KEK),validElement(KeyTrnsprt),validChoice(KeyIdr,KEK,KeyTrnsprt))|

---

## Value ISO20022.Caam001001.Recipient5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeyIdr|ISO20022.Caam001001.KEKIdentifier2||XmlElement()||
|+|IssrAndSrlNb|ISO20022.Caam001001.IssuerAndSerialNumber1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyIdr),validElement(IssrAndSrlNb),validChoice(KeyIdr,IssrAndSrlNb))|

---

## Value ISO20022.Caam001001.RelativeDistinguishedName1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AttrVal|String||XmlElement()||
|+|AttrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam001001.SignedData4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgnr|global::System.Collections.Generic.List<ISO20022.Caam001001.Signer3>||XmlElement()||
|+|Cert|global::System.Collections.Generic.List<String>||XmlElement()||
|+|NcpsltdCntt|ISO20022.Caam001001.EncapsulatedContent3||XmlElement()||
|+|DgstAlgo|global::System.Collections.Generic.List<ISO20022.Caam001001.AlgorithmIdentification16>||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Sgnr""",Sgnr),validList("""Sgnr""",Sgnr),validElement(Sgnr),validElement(NcpsltdCntt),validRequired("""DgstAlgo""",DgstAlgo),validList("""DgstAlgo""",DgstAlgo),validElement(DgstAlgo))|

---

## Value ISO20022.Caam001001.Signer3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgntr|String||XmlElement()||
|+|SgntrAlgo|ISO20022.Caam001001.AlgorithmIdentification17||XmlElement()||
|+|DgstAlgo|ISO20022.Caam001001.AlgorithmIdentification16||XmlElement()||
|+|SgnrId|ISO20022.Caam001001.Recipient5Choice||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SgntrAlgo),validElement(DgstAlgo),validElement(SgnrId))|

---

## Enum ISO20022.Caam001001.TR34Status1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UBND|Int32||XmlEnum("""UBND""")|1|
||BUND|Int32||XmlEnum("""BUND""")|2|

---

## Value ISO20022.Caam001001.TerminalHosting1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Ctgy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caam001001.TerminalManagementActionResult2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKRF|Int32||XmlEnum("""UKRF""")|1|
||TIMO|Int32||XmlEnum("""TIMO""")|2|
||SYNE|Int32||XmlEnum("""SYNE""")|3|
||SUCC|Int32||XmlEnum("""SUCC""")|4|
||SECR|Int32||XmlEnum("""SECR""")|5|
||NSUP|Int32||XmlEnum("""NSUP""")|6|
||HRDW|Int32||XmlEnum("""HRDW""")|7|
||FMTE|Int32||XmlEnum("""FMTE""")|8|
||CNTE|Int32||XmlEnum("""CNTE""")|9|

---

## Value ISO20022.Caam001001.Traceability4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TracDtTmOut|DateTime||XmlElement()||
|+|TracDtTmIn|DateTime||XmlElement()||
|+|SeqNb|String||XmlElement()||
|+|RlayId|ISO20022.Caam001001.GenericIdentification77||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RlayId))|

---

## Enum ISO20022.Caam001001.TransactionEnvironment2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUBL|Int32||XmlEnum("""PUBL""")|1|
||PRIV|Int32||XmlEnum("""PRIV""")|2|

---

## Enum ISO20022.Caam001001.TransactionEnvironment3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||MERC|Int32||XmlEnum("""MERC""")|2|
||BRCH|Int32||XmlEnum("""BRCH""")|3|

---

## Value ISO20022.Caam001001.UTMCoordinates1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UTMNrthwrd|Decimal||XmlElement()||
|+|UTMEstwrd|Decimal||XmlElement()||
|+|UTMZone|String||XmlElement()||
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

