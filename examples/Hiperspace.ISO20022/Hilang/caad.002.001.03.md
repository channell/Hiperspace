# caad.002.001.03
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Caad002001.AdditionalData1 {
        + Val  : String
        + Tp  : String
    }
    class ISO20022.Caad002001.AdditionalData2 {
        + Dtls  : global::System.Collections.Generic.List~ISO20022.Caad002001.AdditionalData1~
        + Tp  : String
    }
    ISO20022.Caad002001.AdditionalData2 *-- ISO20022.Caad002001.AdditionalData1
    class ISO20022.Caad002001.AdditionalFee3 {
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
    class ISO20022.Caad002001.Algorithm13Code {
        EA5C = 1
        EA9C = 2
        UKA1 = 3
        UKPT = 4
        DKP9 = 5
        E3DC = 6
        EA2C = 7
    }
    class ISO20022.Caad002001.Algorithm20Code {
        HS51 = 1
        HS38 = 2
        HS25 = 3
    }
    class ISO20022.Caad002001.Algorithm23Code {
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
    class ISO20022.Caad002001.Algorithm5Code {
        HS51 = 1
        HS38 = 2
        HS25 = 3
    }
    class ISO20022.Caad002001.Algorithm7Code {
        RSAO = 1
        ERSA = 2
    }
    class ISO20022.Caad002001.Algorithm8Code {
        MGF1 = 1
    }
    class ISO20022.Caad002001.AlgorithmIdentification25 {
        + Param  : ISO20022.Caad002001.Parameter7
        + Algo  : String
    }
    ISO20022.Caad002001.AlgorithmIdentification25 *-- ISO20022.Caad002001.Parameter7
    class ISO20022.Caad002001.AlgorithmIdentification26 {
        + Param  : String
        + Algo  : String
    }
    class ISO20022.Caad002001.AlgorithmIdentification27 {
        + Param  : ISO20022.Caad002001.Parameter13
        + Algo  : String
    }
    ISO20022.Caad002001.AlgorithmIdentification27 *-- ISO20022.Caad002001.Parameter13
    class ISO20022.Caad002001.AlgorithmIdentification28 {
        + Param  : ISO20022.Caad002001.Parameter14
        + Algo  : String
    }
    ISO20022.Caad002001.AlgorithmIdentification28 *-- ISO20022.Caad002001.Parameter14
    class ISO20022.Caad002001.AttributeType1Code {
        CATT = 1
        OUAT = 2
        OATT = 3
        LATT = 4
        CNAT = 5
    }
    class ISO20022.Caad002001.BatchManagementInformation1 {
        + MsgChcksmInptVal  : String
        + MsgSeqNb  : String
        + BtchId  : String
        + ColltnId  : String
    }
    class ISO20022.Caad002001.BatchManagementResponseV03 {
        + SctyTrlr  : ISO20022.Caad002001.ContentInformationType41
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Caad002001.SupplementaryData1~
        + PrtctdData  : global::System.Collections.Generic.List~ISO20022.Caad002001.ProtectedData2~
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Caad002001.AdditionalData2~
        + PrcgRslt  : ISO20022.Caad002001.ProcessingResult23
        + OrgnlRspnCd  : String
        + Rcncltn  : ISO20022.Caad002001.Reconciliation4
        + AddtlFee  : global::System.Collections.Generic.List~ISO20022.Caad002001.AdditionalFee3~
        + SttlmSvc  : ISO20022.Caad002001.SettlementService6
        + Jursdctn  : ISO20022.Caad002001.Jurisdiction2
        + Crrctn  : ISO20022.Caad002001.CorrectionIdentification1
        + LifeCyclId  : String
        + RtrvlRefNb  : String
        + TrnsmssnDtTm  : DateTime
        + SysTracAudtNb  : String
        + Prgrmm  : global::System.Collections.Generic.List~ISO20022.Caad002001.ProgrammeMode5~
        + Dstn  : ISO20022.Caad002001.PartyIdentification286
        + Rcvr  : ISO20022.Caad002001.PartyIdentification286
        + Sndr  : ISO20022.Caad002001.PartyIdentification286
        + Orgtr  : ISO20022.Caad002001.PartyIdentification286
        + Conttn  : String
        + PostvAck  : String
        + MsgsBfrAck  : Decimal
        + ReqAck  : String
        + BtchChcksm  : String
        + ColltnChcksm  : String
        + ChckptId  : String
        + BtchIdList  : global::System.Collections.Generic.List~String~
        + ColltnIdList  : global::System.Collections.Generic.List~String~
        + MsgSeqNb  : String
        + RmngMsgsInColltn  : Decimal
        + NbOfMsgs  : Decimal
        + NbOfBtchsInColltn  : Decimal
        + OrgnlBtchId  : String
        + OrgnlColltnId  : String
        + ColltnSz  : Decimal
        + BtchId  : String
        + ColltnId  : String
        + OthrBtchMgmtTp  : String
        + BtchMgmtTp  : String
        + Hdr  : ISO20022.Caad002001.Header71
    }
    ISO20022.Caad002001.BatchManagementResponseV03 *-- ISO20022.Caad002001.ContentInformationType41
    ISO20022.Caad002001.BatchManagementResponseV03 *-- ISO20022.Caad002001.SupplementaryData1
    ISO20022.Caad002001.BatchManagementResponseV03 *-- ISO20022.Caad002001.ProtectedData2
    ISO20022.Caad002001.BatchManagementResponseV03 *-- ISO20022.Caad002001.AdditionalData2
    ISO20022.Caad002001.BatchManagementResponseV03 *-- ISO20022.Caad002001.ProcessingResult23
    ISO20022.Caad002001.BatchManagementResponseV03 *-- ISO20022.Caad002001.Reconciliation4
    ISO20022.Caad002001.BatchManagementResponseV03 *-- ISO20022.Caad002001.AdditionalFee3
    ISO20022.Caad002001.BatchManagementResponseV03 *-- ISO20022.Caad002001.SettlementService6
    ISO20022.Caad002001.BatchManagementResponseV03 *-- ISO20022.Caad002001.Jurisdiction2
    ISO20022.Caad002001.BatchManagementResponseV03 *-- ISO20022.Caad002001.CorrectionIdentification1
    ISO20022.Caad002001.BatchManagementResponseV03 *-- ISO20022.Caad002001.ProgrammeMode5
    ISO20022.Caad002001.BatchManagementResponseV03 *-- ISO20022.Caad002001.PartyIdentification286
    ISO20022.Caad002001.BatchManagementResponseV03 *-- ISO20022.Caad002001.PartyIdentification286
    ISO20022.Caad002001.BatchManagementResponseV03 *-- ISO20022.Caad002001.PartyIdentification286
    ISO20022.Caad002001.BatchManagementResponseV03 *-- ISO20022.Caad002001.PartyIdentification286
    ISO20022.Caad002001.BatchManagementResponseV03 *-- ISO20022.Caad002001.Header71
    class ISO20022.Caad002001.BatchManagementType2Code {
        STRT = 1
        RERQ = 2
        OTHP = 3
        OTHN = 4
        IDNT = 5
        ENDB = 6
        AKRP = 7
        AKRQ = 8
    }
    class ISO20022.Caad002001.BytePadding1Code {
        RAND = 1
        NULL = 2
        NULG = 3
        NUL8 = 4
        LNGT = 5
    }
    class ISO20022.Caad002001.CertificateIssuer1 {
        + RltvDstngshdNm  : global::System.Collections.Generic.List~ISO20022.Caad002001.RelativeDistinguishedName1~
    }
    ISO20022.Caad002001.CertificateIssuer1 *-- ISO20022.Caad002001.RelativeDistinguishedName1
    class ISO20022.Caad002001.ContentInformationType41 {
        + MAC  : String
        + MACData  : ISO20022.Caad002001.MACData1
    }
    ISO20022.Caad002001.ContentInformationType41 *-- ISO20022.Caad002001.MACData1
    class ISO20022.Caad002001.ContentType2Code {
        AUTH = 1
        DGST = 2
        EVLP = 3
        SIGN = 4
        DATA = 5
    }
    class ISO20022.Caad002001.ContentType3Code {
        IFSE = 1
        EVLP = 2
    }
    class ISO20022.Caad002001.CorrectionIdentification1 {
        + Tm  : DateTime
        + Dt  : DateTime
        + Ind  : String
    }
    class ISO20022.Caad002001.CreditDebit3Code {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Caad002001.EncryptedContent8 {
        + NcrptdDataElmt  : global::System.Collections.Generic.List~ISO20022.Caad002001.EncryptedDataElement2~
        + CnttNcrptnAlgo  : ISO20022.Caad002001.AlgorithmIdentification25
        + CnttTp  : String
    }
    ISO20022.Caad002001.EncryptedContent8 *-- ISO20022.Caad002001.EncryptedDataElement2
    ISO20022.Caad002001.EncryptedContent8 *-- ISO20022.Caad002001.AlgorithmIdentification25
    class ISO20022.Caad002001.EncryptedData2 {
        + NcrptdElmt  : global::System.Collections.Generic.List~ISO20022.Caad002001.EncryptedDataElement2~
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
    ISO20022.Caad002001.EncryptedData2 *-- ISO20022.Caad002001.EncryptedDataElement2
    class ISO20022.Caad002001.EncryptedData2Choice {
        + HexBinry  : String
        + Binry  : String
    }
    class ISO20022.Caad002001.EncryptedDataElement2 {
        + OthrClearTxtFrmt  : String
        + ClearTxtFrmt  : String
        + Data  : ISO20022.Caad002001.EncryptedData2Choice
        + Id  : String
    }
    ISO20022.Caad002001.EncryptedDataElement2 *-- ISO20022.Caad002001.EncryptedData2Choice
    class ISO20022.Caad002001.EncryptedDataFormat1Code {
        OTHP = 1
        OTHN = 2
        HEXF = 3
        EBCD = 4
        BINF = 5
        ASCI = 6
    }
    class ISO20022.Caad002001.EncryptionFormat3Code {
        CBCE = 1
        CTCE = 2
        TR31 = 3
        TR34 = 4
    }
    class ISO20022.Caad002001.EnvelopedData12 {
        + NcrptdCntt  : ISO20022.Caad002001.EncryptedContent8
        + Rcpt  : global::System.Collections.Generic.List~ISO20022.Caad002001.Recipient7Choice~
        + Vrsn  : Decimal
    }
    ISO20022.Caad002001.EnvelopedData12 *-- ISO20022.Caad002001.EncryptedContent8
    ISO20022.Caad002001.EnvelopedData12 *-- ISO20022.Caad002001.Recipient7Choice
    class ISO20022.Caad002001.ErrorDetails3 {
        + DataElmtInErr  : global::System.Collections.Generic.List~String~
        + Desc  : String
        + Cd  : String
        + OthrTp  : String
        + Tp  : String
    }
    class ISO20022.Caad002001.GenericIdentification183 {
        + ShrtNm  : String
        + Ctry  : String
        + Assgnr  : String
        + OthrTp  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Caad002001.Header71 {
        + Tracblt  : global::System.Collections.Generic.List~ISO20022.Caad002001.Traceability10~
        + TracData  : global::System.Collections.Generic.List~ISO20022.Caad002001.AdditionalData1~
        + RcptPty  : ISO20022.Caad002001.GenericIdentification183
        + InitgPty  : ISO20022.Caad002001.GenericIdentification183
        + BtchMgmtInf  : ISO20022.Caad002001.BatchManagementInformation1
        + CreDtTm  : DateTime
        + ReTrnsmssnCntr  : String
        + XchgId  : String
        + PrtcolVrsn  : String
        + MsgFctn  : String
    }
    ISO20022.Caad002001.Header71 *-- ISO20022.Caad002001.Traceability10
    ISO20022.Caad002001.Header71 *-- ISO20022.Caad002001.AdditionalData1
    ISO20022.Caad002001.Header71 *-- ISO20022.Caad002001.GenericIdentification183
    ISO20022.Caad002001.Header71 *-- ISO20022.Caad002001.GenericIdentification183
    ISO20022.Caad002001.Header71 *-- ISO20022.Caad002001.BatchManagementInformation1
    class ISO20022.Caad002001.IssuerAndSerialNumber1 {
        + SrlNb  : String
        + Issr  : ISO20022.Caad002001.CertificateIssuer1
    }
    ISO20022.Caad002001.IssuerAndSerialNumber1 *-- ISO20022.Caad002001.CertificateIssuer1
    class ISO20022.Caad002001.Jurisdiction2 {
        + DmstQlfctn  : String
        + DmstInd  : String
    }
    class ISO20022.Caad002001.KEK6 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Caad002001.AlgorithmIdentification28
        + KEKId  : ISO20022.Caad002001.KEKIdentifier6
        + Vrsn  : Decimal
    }
    ISO20022.Caad002001.KEK6 *-- ISO20022.Caad002001.AlgorithmIdentification28
    ISO20022.Caad002001.KEK6 *-- ISO20022.Caad002001.KEKIdentifier6
    class ISO20022.Caad002001.KEKIdentifier2 {
        + DerivtnId  : String
        + SeqNb  : Decimal
        + KeyVrsn  : String
        + KeyId  : String
    }
    class ISO20022.Caad002001.KEKIdentifier6 {
        + DerivtnId  : String
        + SeqNb  : Decimal
        + KeyVrsn  : String
        + KeyId  : String
    }
    class ISO20022.Caad002001.KeyTransport6 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Caad002001.AlgorithmIdentification27
        + RcptId  : ISO20022.Caad002001.Recipient5Choice
        + Vrsn  : Decimal
    }
    ISO20022.Caad002001.KeyTransport6 *-- ISO20022.Caad002001.AlgorithmIdentification27
    ISO20022.Caad002001.KeyTransport6 *-- ISO20022.Caad002001.Recipient5Choice
    class ISO20022.Caad002001.LocalData14 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Caad002001.AdditionalData1~
        + LglCorpNm  : String
        + ShrtNm  : String
        + NcodgFrmt  : String
        + Lang  : String
    }
    ISO20022.Caad002001.LocalData14 *-- ISO20022.Caad002001.AdditionalData1
    class ISO20022.Caad002001.MACData1 {
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
    class ISO20022.Caad002001.MessageError1Code {
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
    class ISO20022.Caad002001.Parameter13 {
        + MskGnrtrAlgo  : ISO20022.Caad002001.AlgorithmIdentification26
        + DgstAlgo  : String
    }
    ISO20022.Caad002001.Parameter13 *-- ISO20022.Caad002001.AlgorithmIdentification26
    class ISO20022.Caad002001.Parameter14 {
        + BPddg  : String
        + InitlstnVctr  : String
        + NcrptnFrmt  : String
    }
    class ISO20022.Caad002001.Parameter7 {
        + BPddg  : String
        + InitlstnVctr  : String
    }
    class ISO20022.Caad002001.PartyIdentification286 {
        + LclData  : ISO20022.Caad002001.LocalData14
        + AddtlId  : global::System.Collections.Generic.List~ISO20022.Caad002001.AdditionalData1~
        + LglCorpNm  : String
        + ShrtNm  : String
        + Ctry  : String
        + Assgnr  : String
        + Id  : String
    }
    ISO20022.Caad002001.PartyIdentification286 *-- ISO20022.Caad002001.LocalData14
    ISO20022.Caad002001.PartyIdentification286 *-- ISO20022.Caad002001.AdditionalData1
    class ISO20022.Caad002001.PartyType17Code {
        AGNT = 1
        CISP = 2
        CISS = 3
        ACQP = 4
        ACQR = 5
        OTHP = 6
        OTHN = 7
    }
    class ISO20022.Caad002001.PartyType18Code {
        AGNT = 1
        CSCH = 2
        CISS = 3
        ACQR = 4
    }
    class ISO20022.Caad002001.PartyType26Code {
        OTHP = 1
        OTHN = 2
        AGNT = 3
        DLIS = 4
        CISS = 5
        ICCA = 6
        ACQR = 7
        ACCP = 8
    }
    class ISO20022.Caad002001.PartyType32Code {
        OTHP = 1
        OTHN = 2
        ISUR = 3
        AGNT = 4
        ACQR = 5
    }
    class ISO20022.Caad002001.PartyType9Code {
        SCHP = 1
        CSCH = 2
        CISP = 3
        CISS = 4
        ACQP = 5
        ACQR = 6
    }
    class ISO20022.Caad002001.ProcessingResult23 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Caad002001.AdditionalData1~
        + ErrDtl  : global::System.Collections.Generic.List~ISO20022.Caad002001.ErrorDetails3~
        + RspnCd  : String
        + RspnSrcShrtNm  : String
        + RspnSrcCtry  : String
        + RspnSrcAssgnr  : String
        + RspnSrcOthrTp  : String
        + RspnSrcTp  : String
        + RspnSrcId  : String
    }
    ISO20022.Caad002001.ProcessingResult23 *-- ISO20022.Caad002001.AdditionalData1
    ISO20022.Caad002001.ProcessingResult23 *-- ISO20022.Caad002001.ErrorDetails3
    class ISO20022.Caad002001.ProgrammeMode5 {
        + AddtlId  : global::System.Collections.Generic.List~ISO20022.Caad002001.AdditionalData1~
        + ApldId  : String
    }
    ISO20022.Caad002001.ProgrammeMode5 *-- ISO20022.Caad002001.AdditionalData1
    class ISO20022.Caad002001.ProtectedData2 {
        + NcrptdData  : ISO20022.Caad002001.EncryptedData2
        + EnvlpdData  : ISO20022.Caad002001.EnvelopedData12
        + CnttTp  : String
    }
    ISO20022.Caad002001.ProtectedData2 *-- ISO20022.Caad002001.EncryptedData2
    ISO20022.Caad002001.ProtectedData2 *-- ISO20022.Caad002001.EnvelopedData12
    class ISO20022.Caad002001.Recipient5Choice {
        + KeyIdr  : ISO20022.Caad002001.KEKIdentifier2
        + IssrAndSrlNb  : ISO20022.Caad002001.IssuerAndSerialNumber1
    }
    ISO20022.Caad002001.Recipient5Choice *-- ISO20022.Caad002001.KEKIdentifier2
    ISO20022.Caad002001.Recipient5Choice *-- ISO20022.Caad002001.IssuerAndSerialNumber1
    class ISO20022.Caad002001.Recipient7Choice {
        + KeyIdr  : ISO20022.Caad002001.KEKIdentifier6
        + KEK  : ISO20022.Caad002001.KEK6
        + KeyTrnsprt  : ISO20022.Caad002001.KeyTransport6
    }
    ISO20022.Caad002001.Recipient7Choice *-- ISO20022.Caad002001.KEKIdentifier6
    ISO20022.Caad002001.Recipient7Choice *-- ISO20022.Caad002001.KEK6
    ISO20022.Caad002001.Recipient7Choice *-- ISO20022.Caad002001.KeyTransport6
    class ISO20022.Caad002001.Reconciliation4 {
        + ChckptRef  : String
        + Dt  : DateTime
        + Id  : String
    }
    class ISO20022.Caad002001.RelativeDistinguishedName1 {
        + AttrVal  : String
        + AttrTp  : String
    }
    class ISO20022.Caad002001.SettlementService6 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Caad002001.AdditionalData1~
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
    ISO20022.Caad002001.SettlementService6 *-- ISO20022.Caad002001.AdditionalData1
    class ISO20022.Caad002001.SupplementaryData1 {
        + Envlp  : ISO20022.Caad002001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Caad002001.SupplementaryData1 *-- ISO20022.Caad002001.SupplementaryDataEnvelope1
    class ISO20022.Caad002001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Caad002001.Traceability10 {
        + DtTmOut  : DateTime
        + DtTmIn  : DateTime
        + ShrtNm  : String
        + Ctry  : String
        + Assgnr  : String
        + OthrTp  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Caad002001.TypeOfAmount21Code {
        MNIF = 1
        MXIF = 2
        CSIF = 3
        FEEA = 4
        OTHP = 5
        OTHN = 6
        FEEP = 7
        INTC = 8
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

## Value ISO20022.Caad002001.AdditionalData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caad002001.AdditionalData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dtls|global::System.Collections.Generic.List<ISO20022.Caad002001.AdditionalData1>||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Dtls""",Dtls),validElement(Dtls))|

---

## Value ISO20022.Caad002001.AdditionalFee3


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

## Enum ISO20022.Caad002001.Algorithm13Code


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

## Enum ISO20022.Caad002001.Algorithm20Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HS51|Int32||XmlEnum("""HS51""")|1|
||HS38|Int32||XmlEnum("""HS38""")|2|
||HS25|Int32||XmlEnum("""HS25""")|3|

---

## Enum ISO20022.Caad002001.Algorithm23Code


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

## Enum ISO20022.Caad002001.Algorithm5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HS51|Int32||XmlEnum("""HS51""")|1|
||HS38|Int32||XmlEnum("""HS38""")|2|
||HS25|Int32||XmlEnum("""HS25""")|3|

---

## Enum ISO20022.Caad002001.Algorithm7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSAO|Int32||XmlEnum("""RSAO""")|1|
||ERSA|Int32||XmlEnum("""ERSA""")|2|

---

## Enum ISO20022.Caad002001.Algorithm8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MGF1|Int32||XmlEnum("""MGF1""")|1|

---

## Value ISO20022.Caad002001.AlgorithmIdentification25


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caad002001.Parameter7||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Caad002001.AlgorithmIdentification26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|String||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caad002001.AlgorithmIdentification27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caad002001.Parameter13||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Caad002001.AlgorithmIdentification28


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caad002001.Parameter14||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Enum ISO20022.Caad002001.AttributeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CATT|Int32||XmlEnum("""CATT""")|1|
||OUAT|Int32||XmlEnum("""OUAT""")|2|
||OATT|Int32||XmlEnum("""OATT""")|3|
||LATT|Int32||XmlEnum("""LATT""")|4|
||CNAT|Int32||XmlEnum("""CNAT""")|5|

---

## Value ISO20022.Caad002001.BatchManagementInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgChcksmInptVal|String||XmlElement()||
|+|MsgSeqNb|String||XmlElement()||
|+|BtchId|String||XmlElement()||
|+|ColltnId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MsgSeqNb""",MsgSeqNb,"""[0-9]{1,15}"""))|

---

## Aspect ISO20022.Caad002001.BatchManagementResponseV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyTrlr|ISO20022.Caad002001.ContentInformationType41||XmlElement()||
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Caad002001.SupplementaryData1>||XmlElement()||
|+|PrtctdData|global::System.Collections.Generic.List<ISO20022.Caad002001.ProtectedData2>||XmlElement()||
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Caad002001.AdditionalData2>||XmlElement()||
|+|PrcgRslt|ISO20022.Caad002001.ProcessingResult23||XmlElement()||
|+|OrgnlRspnCd|String||XmlElement()||
|+|Rcncltn|ISO20022.Caad002001.Reconciliation4||XmlElement()||
|+|AddtlFee|global::System.Collections.Generic.List<ISO20022.Caad002001.AdditionalFee3>||XmlElement()||
|+|SttlmSvc|ISO20022.Caad002001.SettlementService6||XmlElement()||
|+|Jursdctn|ISO20022.Caad002001.Jurisdiction2||XmlElement()||
|+|Crrctn|ISO20022.Caad002001.CorrectionIdentification1||XmlElement()||
|+|LifeCyclId|String||XmlElement()||
|+|RtrvlRefNb|String||XmlElement()||
|+|TrnsmssnDtTm|DateTime||XmlElement()||
|+|SysTracAudtNb|String||XmlElement()||
|+|Prgrmm|global::System.Collections.Generic.List<ISO20022.Caad002001.ProgrammeMode5>||XmlElement()||
|+|Dstn|ISO20022.Caad002001.PartyIdentification286||XmlElement()||
|+|Rcvr|ISO20022.Caad002001.PartyIdentification286||XmlElement()||
|+|Sndr|ISO20022.Caad002001.PartyIdentification286||XmlElement()||
|+|Orgtr|ISO20022.Caad002001.PartyIdentification286||XmlElement()||
|+|Conttn|String||XmlElement()||
|+|PostvAck|String||XmlElement()||
|+|MsgsBfrAck|Decimal||XmlElement()||
|+|ReqAck|String||XmlElement()||
|+|BtchChcksm|String||XmlElement()||
|+|ColltnChcksm|String||XmlElement()||
|+|ChckptId|String||XmlElement()||
|+|BtchIdList|global::System.Collections.Generic.List<String>||XmlElement()||
|+|ColltnIdList|global::System.Collections.Generic.List<String>||XmlElement()||
|+|MsgSeqNb|String||XmlElement()||
|+|RmngMsgsInColltn|Decimal||XmlElement()||
|+|NbOfMsgs|Decimal||XmlElement()||
|+|NbOfBtchsInColltn|Decimal||XmlElement()||
|+|OrgnlBtchId|String||XmlElement()||
|+|OrgnlColltnId|String||XmlElement()||
|+|ColltnSz|Decimal||XmlElement()||
|+|BtchId|String||XmlElement()||
|+|ColltnId|String||XmlElement()||
|+|OthrBtchMgmtTp|String||XmlElement()||
|+|BtchMgmtTp|String||XmlElement()||
|+|Hdr|ISO20022.Caad002001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(PrcgRslt),validPattern("""OrgnlRspnCd""",OrgnlRspnCd,"""[0-9A-Z]{2,2}"""),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validElement(Crrctn),validPattern("""SysTracAudtNb""",SysTracAudtNb,"""[0-9]{1,12}"""),validList("""Prgrmm""",Prgrmm),validElement(Prgrmm),validElement(Dstn),validElement(Rcvr),validElement(Sndr),validElement(Orgtr),validPattern("""MsgSeqNb""",MsgSeqNb,"""[0-9]{1,15}"""),validElement(Hdr))|

---

## Enum ISO20022.Caad002001.BatchManagementType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||STRT|Int32||XmlEnum("""STRT""")|1|
||RERQ|Int32||XmlEnum("""RERQ""")|2|
||OTHP|Int32||XmlEnum("""OTHP""")|3|
||OTHN|Int32||XmlEnum("""OTHN""")|4|
||IDNT|Int32||XmlEnum("""IDNT""")|5|
||ENDB|Int32||XmlEnum("""ENDB""")|6|
||AKRP|Int32||XmlEnum("""AKRP""")|7|
||AKRQ|Int32||XmlEnum("""AKRQ""")|8|

---

## Enum ISO20022.Caad002001.BytePadding1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RAND|Int32||XmlEnum("""RAND""")|1|
||NULL|Int32||XmlEnum("""NULL""")|2|
||NULG|Int32||XmlEnum("""NULG""")|3|
||NUL8|Int32||XmlEnum("""NUL8""")|4|
||LNGT|Int32||XmlEnum("""LNGT""")|5|

---

## Value ISO20022.Caad002001.CertificateIssuer1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltvDstngshdNm|global::System.Collections.Generic.List<ISO20022.Caad002001.RelativeDistinguishedName1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""RltvDstngshdNm""",RltvDstngshdNm),validList("""RltvDstngshdNm""",RltvDstngshdNm),validElement(RltvDstngshdNm))|

---

## Value ISO20022.Caad002001.ContentInformationType41


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MAC|String||XmlElement()||
|+|MACData|ISO20022.Caad002001.MACData1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MAC""",MAC,"""([0-9A-F][0-9A-F]){1,8}"""),validElement(MACData))|

---

## Enum ISO20022.Caad002001.ContentType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AUTH|Int32||XmlEnum("""AUTH""")|1|
||DGST|Int32||XmlEnum("""DGST""")|2|
||EVLP|Int32||XmlEnum("""EVLP""")|3|
||SIGN|Int32||XmlEnum("""SIGN""")|4|
||DATA|Int32||XmlEnum("""DATA""")|5|

---

## Enum ISO20022.Caad002001.ContentType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||IFSE|Int32||XmlEnum("""IFSE""")|1|
||EVLP|Int32||XmlEnum("""EVLP""")|2|

---

## Value ISO20022.Caad002001.CorrectionIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caad002001.CreditDebit3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Type ISO20022.Caad002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BtchMgmtRspn|ISO20022.Caad002001.BatchManagementResponseV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BtchMgmtRspn))|

---

## Value ISO20022.Caad002001.EncryptedContent8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdDataElmt|global::System.Collections.Generic.List<ISO20022.Caad002001.EncryptedDataElement2>||XmlElement()||
|+|CnttNcrptnAlgo|ISO20022.Caad002001.AlgorithmIdentification25||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""NcrptdDataElmt""",NcrptdDataElmt),validList("""NcrptdDataElmt""",NcrptdDataElmt),validElement(NcrptdDataElmt),validElement(CnttNcrptnAlgo))|

---

## Value ISO20022.Caad002001.EncryptedData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdElmt|global::System.Collections.Generic.List<ISO20022.Caad002001.EncryptedDataElement2>||XmlElement()||
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

## Value ISO20022.Caad002001.EncryptedData2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HexBinry|String||XmlElement()||
|+|Binry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""HexBinry""",HexBinry,"""([0-9A-F][0-9A-F]){1,9999}"""),validChoice(HexBinry,Binry))|

---

## Value ISO20022.Caad002001.EncryptedDataElement2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrClearTxtFrmt|String||XmlElement()||
|+|ClearTxtFrmt|String||XmlElement()||
|+|Data|ISO20022.Caad002001.EncryptedData2Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Data))|

---

## Enum ISO20022.Caad002001.EncryptedDataFormat1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHP|Int32||XmlEnum("""OTHP""")|1|
||OTHN|Int32||XmlEnum("""OTHN""")|2|
||HEXF|Int32||XmlEnum("""HEXF""")|3|
||EBCD|Int32||XmlEnum("""EBCD""")|4|
||BINF|Int32||XmlEnum("""BINF""")|5|
||ASCI|Int32||XmlEnum("""ASCI""")|6|

---

## Enum ISO20022.Caad002001.EncryptionFormat3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CBCE|Int32||XmlEnum("""CBCE""")|1|
||CTCE|Int32||XmlEnum("""CTCE""")|2|
||TR31|Int32||XmlEnum("""TR31""")|3|
||TR34|Int32||XmlEnum("""TR34""")|4|

---

## Value ISO20022.Caad002001.EnvelopedData12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdCntt|ISO20022.Caad002001.EncryptedContent8||XmlElement()||
|+|Rcpt|global::System.Collections.Generic.List<ISO20022.Caad002001.Recipient7Choice>||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcrptdCntt),validRequired("""Rcpt""",Rcpt),validList("""Rcpt""",Rcpt),validElement(Rcpt))|

---

## Value ISO20022.Caad002001.ErrorDetails3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DataElmtInErr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Desc|String||XmlElement()||
|+|Cd|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caad002001.GenericIdentification183


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

## Value ISO20022.Caad002001.Header71


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tracblt|global::System.Collections.Generic.List<ISO20022.Caad002001.Traceability10>||XmlElement()||
|+|TracData|global::System.Collections.Generic.List<ISO20022.Caad002001.AdditionalData1>||XmlElement()||
|+|RcptPty|ISO20022.Caad002001.GenericIdentification183||XmlElement()||
|+|InitgPty|ISO20022.Caad002001.GenericIdentification183||XmlElement()||
|+|BtchMgmtInf|ISO20022.Caad002001.BatchManagementInformation1||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|ReTrnsmssnCntr|String||XmlElement()||
|+|XchgId|String||XmlElement()||
|+|PrtcolVrsn|String||XmlElement()||
|+|MsgFctn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Tracblt""",Tracblt),validElement(Tracblt),validList("""TracData""",TracData),validElement(TracData),validElement(RcptPty),validElement(InitgPty),validElement(BtchMgmtInf),validPattern("""ReTrnsmssnCntr""",ReTrnsmssnCntr,"""[0-9]{1,3}"""))|

---

## Value ISO20022.Caad002001.IssuerAndSerialNumber1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrlNb|String||XmlElement()||
|+|Issr|ISO20022.Caad002001.CertificateIssuer1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Issr))|

---

## Value ISO20022.Caad002001.Jurisdiction2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DmstQlfctn|String||XmlElement()||
|+|DmstInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caad002001.KEK6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Caad002001.AlgorithmIdentification28||XmlElement()||
|+|KEKId|ISO20022.Caad002001.KEKIdentifier6||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(KEKId))|

---

## Value ISO20022.Caad002001.KEKIdentifier2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivtnId|String||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|KeyVrsn|String||XmlElement()||
|+|KeyId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caad002001.KEKIdentifier6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivtnId|String||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|KeyVrsn|String||XmlElement()||
|+|KeyId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caad002001.KeyTransport6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Caad002001.AlgorithmIdentification27||XmlElement()||
|+|RcptId|ISO20022.Caad002001.Recipient5Choice||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(RcptId))|

---

## Value ISO20022.Caad002001.LocalData14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Caad002001.AdditionalData1>||XmlElement()||
|+|LglCorpNm|String||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|NcodgFrmt|String||XmlElement()||
|+|Lang|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validPattern("""Lang""",Lang,"""[a-z]{2,3}"""))|

---

## Value ISO20022.Caad002001.MACData1


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

## Enum ISO20022.Caad002001.MessageError1Code


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

## Value ISO20022.Caad002001.Parameter13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MskGnrtrAlgo|ISO20022.Caad002001.AlgorithmIdentification26||XmlElement()||
|+|DgstAlgo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MskGnrtrAlgo))|

---

## Value ISO20022.Caad002001.Parameter14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
|+|NcrptnFrmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caad002001.Parameter7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caad002001.PartyIdentification286


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LclData|ISO20022.Caad002001.LocalData14||XmlElement()||
|+|AddtlId|global::System.Collections.Generic.List<ISO20022.Caad002001.AdditionalData1>||XmlElement()||
|+|LglCorpNm|String||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Assgnr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LclData),validList("""AddtlId""",AddtlId),validElement(AddtlId),validPattern("""Ctry""",Ctry,"""[0-9]{3,3}"""),validPattern("""Id""",Id,"""[0-9]{1,11}"""))|

---

## Enum ISO20022.Caad002001.PartyType17Code


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

## Enum ISO20022.Caad002001.PartyType18Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGNT|Int32||XmlEnum("""AGNT""")|1|
||CSCH|Int32||XmlEnum("""CSCH""")|2|
||CISS|Int32||XmlEnum("""CISS""")|3|
||ACQR|Int32||XmlEnum("""ACQR""")|4|

---

## Enum ISO20022.Caad002001.PartyType26Code


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

## Enum ISO20022.Caad002001.PartyType32Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHP|Int32||XmlEnum("""OTHP""")|1|
||OTHN|Int32||XmlEnum("""OTHN""")|2|
||ISUR|Int32||XmlEnum("""ISUR""")|3|
||AGNT|Int32||XmlEnum("""AGNT""")|4|
||ACQR|Int32||XmlEnum("""ACQR""")|5|

---

## Enum ISO20022.Caad002001.PartyType9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SCHP|Int32||XmlEnum("""SCHP""")|1|
||CSCH|Int32||XmlEnum("""CSCH""")|2|
||CISP|Int32||XmlEnum("""CISP""")|3|
||CISS|Int32||XmlEnum("""CISS""")|4|
||ACQP|Int32||XmlEnum("""ACQP""")|5|
||ACQR|Int32||XmlEnum("""ACQR""")|6|

---

## Value ISO20022.Caad002001.ProcessingResult23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Caad002001.AdditionalData1>||XmlElement()||
|+|ErrDtl|global::System.Collections.Generic.List<ISO20022.Caad002001.ErrorDetails3>||XmlElement()||
|+|RspnCd|String||XmlElement()||
|+|RspnSrcShrtNm|String||XmlElement()||
|+|RspnSrcCtry|String||XmlElement()||
|+|RspnSrcAssgnr|String||XmlElement()||
|+|RspnSrcOthrTp|String||XmlElement()||
|+|RspnSrcTp|String||XmlElement()||
|+|RspnSrcId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validList("""ErrDtl""",ErrDtl),validElement(ErrDtl),validPattern("""RspnCd""",RspnCd,"""[0-9A-Z]{2,2}"""),validPattern("""RspnSrcCtry""",RspnSrcCtry,"""[A-Z]{2,3}"""))|

---

## Value ISO20022.Caad002001.ProgrammeMode5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlId|global::System.Collections.Generic.List<ISO20022.Caad002001.AdditionalData1>||XmlElement()||
|+|ApldId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlId""",AddtlId),validElement(AddtlId))|

---

## Value ISO20022.Caad002001.ProtectedData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdData|ISO20022.Caad002001.EncryptedData2||XmlElement()||
|+|EnvlpdData|ISO20022.Caad002001.EnvelopedData12||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcrptdData),validElement(EnvlpdData))|

---

## Value ISO20022.Caad002001.Recipient5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeyIdr|ISO20022.Caad002001.KEKIdentifier2||XmlElement()||
|+|IssrAndSrlNb|ISO20022.Caad002001.IssuerAndSerialNumber1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyIdr),validElement(IssrAndSrlNb),validChoice(KeyIdr,IssrAndSrlNb))|

---

## Value ISO20022.Caad002001.Recipient7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeyIdr|ISO20022.Caad002001.KEKIdentifier6||XmlElement()||
|+|KEK|ISO20022.Caad002001.KEK6||XmlElement()||
|+|KeyTrnsprt|ISO20022.Caad002001.KeyTransport6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyIdr),validElement(KEK),validElement(KeyTrnsprt),validChoice(KeyIdr,KEK,KeyTrnsprt))|

---

## Value ISO20022.Caad002001.Reconciliation4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ChckptRef|String||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caad002001.RelativeDistinguishedName1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AttrVal|String||XmlElement()||
|+|AttrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caad002001.SettlementService6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Caad002001.AdditionalData1>||XmlElement()||
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

## Value ISO20022.Caad002001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Caad002001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Caad002001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caad002001.Traceability10


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

## Enum ISO20022.Caad002001.TypeOfAmount21Code


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

## View Hiperspace.Node
node in a graph view of data

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|SKey|String||||
|+|TypeName|String||||
|+|Name|String||||
||Froms|Hiperspace.Edge|||From = this|
||Tos|Hiperspace.Edge|||To = this|

