# tsrv.002.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Tsrv002001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Tsrv002001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Tsrv002001.AdvisingPartyAdditionalInformation1 {
        + BkToBnfcryInf  : global::System.Collections.Generic.List~String~
        + RefNb  : String
    }
    class ISO20022.Tsrv002001.AmountAndTrigger1 {
        + Trggr  : global::System.Collections.Generic.List~ISO20022.Tsrv002001.Trigger1~
        + AmtDtlsChc  : ISO20022.Tsrv002001.AmountOrPercentage1Choice
        + Id  : String
    }
    ISO20022.Tsrv002001.AmountAndTrigger1 *-- ISO20022.Tsrv002001.Trigger1
    ISO20022.Tsrv002001.AmountAndTrigger1 *-- ISO20022.Tsrv002001.AmountOrPercentage1Choice
    class ISO20022.Tsrv002001.AmountOrPercentage1Choice {
        + PctgAmt  : ISO20022.Tsrv002001.Percentage1
        + DfndAmt  : ISO20022.Tsrv002001.UndertakingAmount4
    }
    ISO20022.Tsrv002001.AmountOrPercentage1Choice *-- ISO20022.Tsrv002001.Percentage1
    ISO20022.Tsrv002001.AmountOrPercentage1Choice *-- ISO20022.Tsrv002001.UndertakingAmount4
    class ISO20022.Tsrv002001.AutoExtend1Choice {
        + Dt  : DateTime
        + Yrs  : Decimal
        + Mnths  : Decimal
        + Days  : Decimal
    }
    class ISO20022.Tsrv002001.AutoExtension1 {
        + NonXtnsnNtfctn  : global::System.Collections.Generic.List~ISO20022.Tsrv002001.NonExtension1~
        + FnlXpryDt  : DateTime
        + Prd  : ISO20022.Tsrv002001.AutoExtend1Choice
    }
    ISO20022.Tsrv002001.AutoExtension1 *-- ISO20022.Tsrv002001.NonExtension1
    ISO20022.Tsrv002001.AutoExtension1 *-- ISO20022.Tsrv002001.AutoExtend1Choice
    class ISO20022.Tsrv002001.AutomaticVariation1 {
        + AddtlInf  : global::System.Collections.Generic.List~String~
        + AmtAndTrggr  : global::System.Collections.Generic.List~ISO20022.Tsrv002001.AmountAndTrigger1~
        + Tp  : String
        + Id  : String
    }
    ISO20022.Tsrv002001.AutomaticVariation1 *-- ISO20022.Tsrv002001.AmountAndTrigger1
    class ISO20022.Tsrv002001.Channel1Choice {
        + Prtry  : ISO20022.Tsrv002001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Tsrv002001.Channel1Choice *-- ISO20022.Tsrv002001.GenericIdentification1
    class ISO20022.Tsrv002001.CommunicationChannel1 {
        + DlvrToAdr  : ISO20022.Tsrv002001.PostalAddress6
        + DlvrToNm  : String
        + DlvrToPtyTp  : ISO20022.Tsrv002001.PartyType1Choice
        + Mtd  : String
    }
    ISO20022.Tsrv002001.CommunicationChannel1 *-- ISO20022.Tsrv002001.PostalAddress6
    ISO20022.Tsrv002001.CommunicationChannel1 *-- ISO20022.Tsrv002001.PartyType1Choice
    class ISO20022.Tsrv002001.CommunicationMethod1Choice {
        + Prtry  : ISO20022.Tsrv002001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Tsrv002001.CommunicationMethod1Choice *-- ISO20022.Tsrv002001.GenericIdentification1
    class ISO20022.Tsrv002001.ContactDetails2 {
        + Othr  : String
        + EmailAdr  : String
        + FaxNb  : String
        + MobNb  : String
        + PhneNb  : String
        + Nm  : String
        + NmPrfx  : String
    }
    class ISO20022.Tsrv002001.CountrySubdivision1Choice {
        + Prtry  : ISO20022.Tsrv002001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Tsrv002001.CountrySubdivision1Choice *-- ISO20022.Tsrv002001.GenericIdentification1
    class ISO20022.Tsrv002001.DateAndDateTimeChoice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Tsrv002001.DateAndPlaceOfBirth {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Tsrv002001.DateInformation1 {
        + Nb  : Decimal
        + Frqcy  : String
        + StartDt  : DateTime
    }
    class ISO20022.Tsrv002001.Document10 {
        + SgndInd  : String
        + CpyInd  : String
        + DocFrmt  : ISO20022.Tsrv002001.DocumentFormat1Choice
        + PresntnChanl  : ISO20022.Tsrv002001.Channel1Choice
        + DocTp  : ISO20022.Tsrv002001.UndertakingDocumentType2Choice
    }
    ISO20022.Tsrv002001.Document10 *-- ISO20022.Tsrv002001.DocumentFormat1Choice
    ISO20022.Tsrv002001.Document10 *-- ISO20022.Tsrv002001.Channel1Choice
    ISO20022.Tsrv002001.Document10 *-- ISO20022.Tsrv002001.UndertakingDocumentType2Choice
    class ISO20022.Tsrv002001.Document8 {
        + ElctrncDtls  : global::System.Collections.Generic.List~ISO20022.Tsrv002001.Presentation3~
        + Wrdg  : String
        + Tp  : ISO20022.Tsrv002001.PresentationDocumentFormat1Choice
    }
    ISO20022.Tsrv002001.Document8 *-- ISO20022.Tsrv002001.Presentation3
    ISO20022.Tsrv002001.Document8 *-- ISO20022.Tsrv002001.PresentationDocumentFormat1Choice
    class ISO20022.Tsrv002001.Document9 {
        + DgtlSgntr  : ISO20022.Tsrv002001.PartyAndSignature2
        + Nclsr  : String
        + Frmt  : ISO20022.Tsrv002001.DocumentFormat1Choice
        + Id  : String
        + Tp  : ISO20022.Tsrv002001.UndertakingDocumentType1Choice
    }
    ISO20022.Tsrv002001.Document9 *-- ISO20022.Tsrv002001.PartyAndSignature2
    ISO20022.Tsrv002001.Document9 *-- ISO20022.Tsrv002001.DocumentFormat1Choice
    ISO20022.Tsrv002001.Document9 *-- ISO20022.Tsrv002001.UndertakingDocumentType1Choice
    class ISO20022.Tsrv002001.DocumentFormat1Choice {
        + Prtry  : ISO20022.Tsrv002001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Tsrv002001.DocumentFormat1Choice *-- ISO20022.Tsrv002001.GenericIdentification1
    class ISO20022.Tsrv002001.ExpiryDetails1 {
        + AddtlXpryInf  : global::System.Collections.Generic.List~String~
        + XpryTerms  : ISO20022.Tsrv002001.ExpiryTerms1
    }
    ISO20022.Tsrv002001.ExpiryDetails1 *-- ISO20022.Tsrv002001.ExpiryTerms1
    class ISO20022.Tsrv002001.ExpiryTerms1 {
        + OpnEnddInd  : String
        + Cond  : String
        + AutoXtnsn  : ISO20022.Tsrv002001.AutoExtension1
        + DtTm  : ISO20022.Tsrv002001.DateAndDateTimeChoice
    }
    ISO20022.Tsrv002001.ExpiryTerms1 *-- ISO20022.Tsrv002001.AutoExtension1
    ISO20022.Tsrv002001.ExpiryTerms1 *-- ISO20022.Tsrv002001.DateAndDateTimeChoice
    class ISO20022.Tsrv002001.FixedOrRecurrentDate1Choice {
        + RcrntDt  : ISO20022.Tsrv002001.DateInformation1
        + FxdDt  : DateTime
    }
    ISO20022.Tsrv002001.FixedOrRecurrentDate1Choice *-- ISO20022.Tsrv002001.DateInformation1
    class ISO20022.Tsrv002001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Tsrv002001.GenericOrganisationIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Tsrv002001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Tsrv002001.GenericOrganisationIdentification1 *-- ISO20022.Tsrv002001.OrganisationIdentificationSchemeName1Choice
    class ISO20022.Tsrv002001.GenericPersonIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Tsrv002001.PersonIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Tsrv002001.GenericPersonIdentification1 *-- ISO20022.Tsrv002001.PersonIdentificationSchemeName1Choice
    class ISO20022.Tsrv002001.GovernanceIdentification1Choice {
        + Prtry  : ISO20022.Tsrv002001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Tsrv002001.GovernanceIdentification1Choice *-- ISO20022.Tsrv002001.GenericIdentification1
    class ISO20022.Tsrv002001.GovernanceIdentification1Code {
        URDG = 1
        UCPR = 2
        NONE = 3
        ISPR = 4
    }
    class ISO20022.Tsrv002001.GovernanceRules1 {
        + Jursdctn  : global::System.Collections.Generic.List~ISO20022.Tsrv002001.Location1~
        + AplblLaw  : ISO20022.Tsrv002001.Location1
        + RuleId  : ISO20022.Tsrv002001.GovernanceIdentification1Choice
    }
    ISO20022.Tsrv002001.GovernanceRules1 *-- ISO20022.Tsrv002001.Location1
    ISO20022.Tsrv002001.GovernanceRules1 *-- ISO20022.Tsrv002001.Location1
    ISO20022.Tsrv002001.GovernanceRules1 *-- ISO20022.Tsrv002001.GovernanceIdentification1Choice
    class ISO20022.Tsrv002001.IssuanceType1Code {
        ISAD = 1
        ISCO = 2
        ISSU = 3
        CRQC = 4
        CRQL = 5
    }
    class ISO20022.Tsrv002001.Location1 {
        + Txt  : global::System.Collections.Generic.List~String~
        + CtrySubDvsn  : ISO20022.Tsrv002001.CountrySubdivision1Choice
        + Ctry  : String
    }
    ISO20022.Tsrv002001.Location1 *-- ISO20022.Tsrv002001.CountrySubdivision1Choice
    class ISO20022.Tsrv002001.ModelFormIdentification1 {
        + Vrsn  : String
        + Id  : ISO20022.Tsrv002001.ModelFormIdentification1Choice
    }
    ISO20022.Tsrv002001.ModelFormIdentification1 *-- ISO20022.Tsrv002001.ModelFormIdentification1Choice
    class ISO20022.Tsrv002001.ModelFormIdentification1Choice {
        + Prtry  : ISO20022.Tsrv002001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Tsrv002001.ModelFormIdentification1Choice *-- ISO20022.Tsrv002001.GenericIdentification1
    class ISO20022.Tsrv002001.NamePrefix1Code {
        MADM = 1
        MISS = 2
        MIST = 3
        DOCT = 4
    }
    class ISO20022.Tsrv002001.Narrative1 {
        + Txt  : global::System.Collections.Generic.List~String~
        + Tp  : ISO20022.Tsrv002001.NarrativeType1Choice
    }
    ISO20022.Tsrv002001.Narrative1 *-- ISO20022.Tsrv002001.NarrativeType1Choice
    class ISO20022.Tsrv002001.NarrativeType1Choice {
        + Prtry  : ISO20022.Tsrv002001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Tsrv002001.NarrativeType1Choice *-- ISO20022.Tsrv002001.GenericIdentification1
    class ISO20022.Tsrv002001.NonExtension1 {
        + NtfctnRcptAdr  : ISO20022.Tsrv002001.PostalAddress6
        + NtfctnRcptNm  : String
        + NtfctnRcptTp  : ISO20022.Tsrv002001.PartyType1Choice
        + NtfctnMtd  : ISO20022.Tsrv002001.CommunicationMethod1Choice
        + NtfctnPrd  : Decimal
    }
    ISO20022.Tsrv002001.NonExtension1 *-- ISO20022.Tsrv002001.PostalAddress6
    ISO20022.Tsrv002001.NonExtension1 *-- ISO20022.Tsrv002001.PartyType1Choice
    ISO20022.Tsrv002001.NonExtension1 *-- ISO20022.Tsrv002001.CommunicationMethod1Choice
    class ISO20022.Tsrv002001.OrganisationIdentification8 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Tsrv002001.GenericOrganisationIdentification1~
        + AnyBIC  : String
    }
    ISO20022.Tsrv002001.OrganisationIdentification8 *-- ISO20022.Tsrv002001.GenericOrganisationIdentification1
    class ISO20022.Tsrv002001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Tsrv002001.Party11Choice {
        + PrvtId  : ISO20022.Tsrv002001.PersonIdentification5
        + OrgId  : ISO20022.Tsrv002001.OrganisationIdentification8
    }
    ISO20022.Tsrv002001.Party11Choice *-- ISO20022.Tsrv002001.PersonIdentification5
    ISO20022.Tsrv002001.Party11Choice *-- ISO20022.Tsrv002001.OrganisationIdentification8
    class ISO20022.Tsrv002001.PartyAndSignature2 {
        + Sgntr  : ISO20022.Tsrv002001.ProprietaryData3
        + Pty  : ISO20022.Tsrv002001.PartyIdentification43
    }
    ISO20022.Tsrv002001.PartyAndSignature2 *-- ISO20022.Tsrv002001.ProprietaryData3
    ISO20022.Tsrv002001.PartyAndSignature2 *-- ISO20022.Tsrv002001.PartyIdentification43
    class ISO20022.Tsrv002001.PartyAndType1 {
        + Pty  : ISO20022.Tsrv002001.PartyIdentification43
        + Tp  : ISO20022.Tsrv002001.PartyType1Choice
    }
    ISO20022.Tsrv002001.PartyAndType1 *-- ISO20022.Tsrv002001.PartyIdentification43
    ISO20022.Tsrv002001.PartyAndType1 *-- ISO20022.Tsrv002001.PartyType1Choice
    class ISO20022.Tsrv002001.PartyIdentification43 {
        + CtctDtls  : ISO20022.Tsrv002001.ContactDetails2
        + CtryOfRes  : String
        + Id  : ISO20022.Tsrv002001.Party11Choice
        + PstlAdr  : ISO20022.Tsrv002001.PostalAddress6
        + Nm  : String
    }
    ISO20022.Tsrv002001.PartyIdentification43 *-- ISO20022.Tsrv002001.ContactDetails2
    ISO20022.Tsrv002001.PartyIdentification43 *-- ISO20022.Tsrv002001.Party11Choice
    ISO20022.Tsrv002001.PartyIdentification43 *-- ISO20022.Tsrv002001.PostalAddress6
    class ISO20022.Tsrv002001.PartyType1Choice {
        + Prtry  : ISO20022.Tsrv002001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Tsrv002001.PartyType1Choice *-- ISO20022.Tsrv002001.GenericIdentification1
    class ISO20022.Tsrv002001.Percentage1 {
        + RltvTo  : String
        + Rate  : Decimal
    }
    class ISO20022.Tsrv002001.PersonIdentification5 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Tsrv002001.GenericPersonIdentification1~
        + DtAndPlcOfBirth  : ISO20022.Tsrv002001.DateAndPlaceOfBirth
    }
    ISO20022.Tsrv002001.PersonIdentification5 *-- ISO20022.Tsrv002001.GenericPersonIdentification1
    ISO20022.Tsrv002001.PersonIdentification5 *-- ISO20022.Tsrv002001.DateAndPlaceOfBirth
    class ISO20022.Tsrv002001.PersonIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Tsrv002001.PlaceOfPresentation1 {
        + Ctry  : String
        + Plc  : String
    }
    class ISO20022.Tsrv002001.PlaceOrUnderConfirmationChoice1 {
        + PresntnUdrConf  : String
        + PlcOfPresntn  : ISO20022.Tsrv002001.PlaceOfPresentation1
    }
    ISO20022.Tsrv002001.PlaceOrUnderConfirmationChoice1 *-- ISO20022.Tsrv002001.PlaceOfPresentation1
    class ISO20022.Tsrv002001.PostalAddress12 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
    }
    class ISO20022.Tsrv002001.PostalAddress6 {
        + AdrLine  : global::System.Collections.Generic.List~String~
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + SubDept  : String
        + Dept  : String
        + AdrTp  : String
    }
    class ISO20022.Tsrv002001.Presentation1 {
        + AddtlInf  : global::System.Collections.Generic.List~String~
        + Doc  : global::System.Collections.Generic.List~ISO20022.Tsrv002001.Document8~
        + PlcOfPresntnOrUdrConfChc  : ISO20022.Tsrv002001.PlaceOrUnderConfirmationChoice1
        + Mdm  : ISO20022.Tsrv002001.PresentationMedium1Choice
    }
    ISO20022.Tsrv002001.Presentation1 *-- ISO20022.Tsrv002001.Document8
    ISO20022.Tsrv002001.Presentation1 *-- ISO20022.Tsrv002001.PlaceOrUnderConfirmationChoice1
    ISO20022.Tsrv002001.Presentation1 *-- ISO20022.Tsrv002001.PresentationMedium1Choice
    class ISO20022.Tsrv002001.Presentation3 {
        + Adr  : String
        + Chanl  : ISO20022.Tsrv002001.Channel1Choice
        + Frmt  : ISO20022.Tsrv002001.DocumentFormat1Choice
    }
    ISO20022.Tsrv002001.Presentation3 *-- ISO20022.Tsrv002001.Channel1Choice
    ISO20022.Tsrv002001.Presentation3 *-- ISO20022.Tsrv002001.DocumentFormat1Choice
    class ISO20022.Tsrv002001.PresentationDocumentFormat1Choice {
        + Prtry  : ISO20022.Tsrv002001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Tsrv002001.PresentationDocumentFormat1Choice *-- ISO20022.Tsrv002001.GenericIdentification1
    class ISO20022.Tsrv002001.PresentationMedium1Choice {
        + Prtry  : ISO20022.Tsrv002001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Tsrv002001.PresentationMedium1Choice *-- ISO20022.Tsrv002001.GenericIdentification1
    class ISO20022.Tsrv002001.PresentationMedium1Code {
        PAPR = 1
        ELEC = 2
        BOTH = 3
    }
    class ISO20022.Tsrv002001.PresentationParty1Code {
        EXIS = 1
        EXCN = 2
        ETHR = 3
    }
    class ISO20022.Tsrv002001.ProprietaryData3 {
    }
    class ISO20022.Tsrv002001.Trigger1 {
        + DcmntryEvt  : global::System.Collections.Generic.List~ISO20022.Tsrv002001.Document10~
        + DtChc  : ISO20022.Tsrv002001.FixedOrRecurrentDate1Choice
    }
    ISO20022.Tsrv002001.Trigger1 *-- ISO20022.Tsrv002001.Document10
    ISO20022.Tsrv002001.Trigger1 *-- ISO20022.Tsrv002001.FixedOrRecurrentDate1Choice
    class ISO20022.Tsrv002001.UnderlyingTradeTransaction1 {
        + AddtlInf  : global::System.Collections.Generic.List~String~
        + CtrctAmtPctg  : Decimal
        + TxAmt  : ISO20022.Tsrv002001.ActiveCurrencyAndAmount
        + TndrClsgDt  : DateTime
        + TxDt  : DateTime
        + Id  : String
        + Tp  : ISO20022.Tsrv002001.UnderlyingTradeTransactionType1Choice
    }
    ISO20022.Tsrv002001.UnderlyingTradeTransaction1 *-- ISO20022.Tsrv002001.ActiveCurrencyAndAmount
    ISO20022.Tsrv002001.UnderlyingTradeTransaction1 *-- ISO20022.Tsrv002001.UnderlyingTradeTransactionType1Choice
    class ISO20022.Tsrv002001.UnderlyingTradeTransactionType1Choice {
        + Prtry  : ISO20022.Tsrv002001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Tsrv002001.UnderlyingTradeTransactionType1Choice *-- ISO20022.Tsrv002001.GenericIdentification1
    class ISO20022.Tsrv002001.Undertaking3 {
        + ReqdLclUdrtkg  : ISO20022.Tsrv002001.Undertaking4
        + AddtlInf  : global::System.Collections.Generic.List~String~
        + NclsdFile  : global::System.Collections.Generic.List~ISO20022.Tsrv002001.Document9~
        + TrfInd  : String
        + DlvryChanl  : ISO20022.Tsrv002001.CommunicationChannel1
        + AutomtcAmtVartn  : global::System.Collections.Generic.List~ISO20022.Tsrv002001.AutomaticVariation1~
        + TrfChrgsPyblBy  : String
        + ConfChrgsPyblBy  : String
        + PrtlDmndInd  : String
        + MltplDmndInd  : String
        + UdrtkgTermsAndConds  : global::System.Collections.Generic.List~ISO20022.Tsrv002001.Narrative1~
        + PresntnDtls  : ISO20022.Tsrv002001.Presentation1
        + UndrlygTx  : global::System.Collections.Generic.List~ISO20022.Tsrv002001.UnderlyingTradeTransaction1~
        + GovncRulesAndLaw  : ISO20022.Tsrv002001.GovernanceRules1
        + AddtlPty  : global::System.Collections.Generic.List~ISO20022.Tsrv002001.PartyAndType1~
        + ConfPtyTp  : String
        + ConfInd  : String
        + XpryDtls  : ISO20022.Tsrv002001.ExpiryDetails1
        + UdrtkgAmt  : ISO20022.Tsrv002001.UndertakingAmount1
        + ScndAdvsgPty  : ISO20022.Tsrv002001.PartyIdentification43
        + AdvsgPty  : ISO20022.Tsrv002001.PartyIdentification43
        + PlcOfIsse  : ISO20022.Tsrv002001.PostalAddress12
        + DtOfIssnc  : DateTime
        + Bnfcry  : global::System.Collections.Generic.List~ISO20022.Tsrv002001.PartyIdentification43~
        + Issr  : ISO20022.Tsrv002001.PartyIdentification43
        + Applcnt  : global::System.Collections.Generic.List~ISO20022.Tsrv002001.PartyIdentification43~
        + IssncTp  : String
        + Tp  : ISO20022.Tsrv002001.UndertakingType1Choice
        + Nm  : String
        + Id  : String
    }
    ISO20022.Tsrv002001.Undertaking3 *-- ISO20022.Tsrv002001.Undertaking4
    ISO20022.Tsrv002001.Undertaking3 *-- ISO20022.Tsrv002001.Document9
    ISO20022.Tsrv002001.Undertaking3 *-- ISO20022.Tsrv002001.CommunicationChannel1
    ISO20022.Tsrv002001.Undertaking3 *-- ISO20022.Tsrv002001.AutomaticVariation1
    ISO20022.Tsrv002001.Undertaking3 *-- ISO20022.Tsrv002001.Narrative1
    ISO20022.Tsrv002001.Undertaking3 *-- ISO20022.Tsrv002001.Presentation1
    ISO20022.Tsrv002001.Undertaking3 *-- ISO20022.Tsrv002001.UnderlyingTradeTransaction1
    ISO20022.Tsrv002001.Undertaking3 *-- ISO20022.Tsrv002001.GovernanceRules1
    ISO20022.Tsrv002001.Undertaking3 *-- ISO20022.Tsrv002001.PartyAndType1
    ISO20022.Tsrv002001.Undertaking3 *-- ISO20022.Tsrv002001.ExpiryDetails1
    ISO20022.Tsrv002001.Undertaking3 *-- ISO20022.Tsrv002001.UndertakingAmount1
    ISO20022.Tsrv002001.Undertaking3 *-- ISO20022.Tsrv002001.PartyIdentification43
    ISO20022.Tsrv002001.Undertaking3 *-- ISO20022.Tsrv002001.PartyIdentification43
    ISO20022.Tsrv002001.Undertaking3 *-- ISO20022.Tsrv002001.PostalAddress12
    ISO20022.Tsrv002001.Undertaking3 *-- ISO20022.Tsrv002001.PartyIdentification43
    ISO20022.Tsrv002001.Undertaking3 *-- ISO20022.Tsrv002001.PartyIdentification43
    ISO20022.Tsrv002001.Undertaking3 *-- ISO20022.Tsrv002001.PartyIdentification43
    ISO20022.Tsrv002001.Undertaking3 *-- ISO20022.Tsrv002001.UndertakingType1Choice
    class ISO20022.Tsrv002001.Undertaking4 {
        + AddtlInf  : global::System.Collections.Generic.List~String~
        + TrfInd  : String
        + DlvryChanl  : ISO20022.Tsrv002001.CommunicationChannel1
        + AutomtcAmtVartn  : global::System.Collections.Generic.List~ISO20022.Tsrv002001.AutomaticVariation1~
        + TrfChrgsPyblBy  : String
        + ConfChrgsPyblBy  : String
        + PrtlDmndInd  : String
        + MltplDmndInd  : String
        + UdrtkgWrdg  : ISO20022.Tsrv002001.UndertakingWording1
        + PresntnDtls  : ISO20022.Tsrv002001.Presentation1
        + UndrlygTx  : global::System.Collections.Generic.List~ISO20022.Tsrv002001.UnderlyingTradeTransaction1~
        + GovncRulesAndLaw  : ISO20022.Tsrv002001.GovernanceRules1
        + AddtlPty  : global::System.Collections.Generic.List~ISO20022.Tsrv002001.PartyAndType1~
        + ConfInd  : String
        + XpryDtls  : ISO20022.Tsrv002001.ExpiryDetails1
        + LclUdrtkgAmt  : ISO20022.Tsrv002001.UndertakingAmount1
        + ScndAdvsgPty  : ISO20022.Tsrv002001.PartyIdentification43
        + AdvsgPty  : ISO20022.Tsrv002001.PartyIdentification43
        + DtOfIssnc  : DateTime
        + Bnfcry  : global::System.Collections.Generic.List~ISO20022.Tsrv002001.PartyIdentification43~
        + Applcnt  : global::System.Collections.Generic.List~ISO20022.Tsrv002001.PartyIdentification43~
        + Tp  : String
        + Nm  : String
    }
    ISO20022.Tsrv002001.Undertaking4 *-- ISO20022.Tsrv002001.CommunicationChannel1
    ISO20022.Tsrv002001.Undertaking4 *-- ISO20022.Tsrv002001.AutomaticVariation1
    ISO20022.Tsrv002001.Undertaking4 *-- ISO20022.Tsrv002001.UndertakingWording1
    ISO20022.Tsrv002001.Undertaking4 *-- ISO20022.Tsrv002001.Presentation1
    ISO20022.Tsrv002001.Undertaking4 *-- ISO20022.Tsrv002001.UnderlyingTradeTransaction1
    ISO20022.Tsrv002001.Undertaking4 *-- ISO20022.Tsrv002001.GovernanceRules1
    ISO20022.Tsrv002001.Undertaking4 *-- ISO20022.Tsrv002001.PartyAndType1
    ISO20022.Tsrv002001.Undertaking4 *-- ISO20022.Tsrv002001.ExpiryDetails1
    ISO20022.Tsrv002001.Undertaking4 *-- ISO20022.Tsrv002001.UndertakingAmount1
    ISO20022.Tsrv002001.Undertaking4 *-- ISO20022.Tsrv002001.PartyIdentification43
    ISO20022.Tsrv002001.Undertaking4 *-- ISO20022.Tsrv002001.PartyIdentification43
    ISO20022.Tsrv002001.Undertaking4 *-- ISO20022.Tsrv002001.PartyIdentification43
    ISO20022.Tsrv002001.Undertaking4 *-- ISO20022.Tsrv002001.PartyIdentification43
    class ISO20022.Tsrv002001.UndertakingAdvice1 {
        + DgtlSgntr  : global::System.Collections.Generic.List~ISO20022.Tsrv002001.PartyAndSignature2~
        + ConfDtls  : ISO20022.Tsrv002001.UndertakingConfirmation1
        + ScndAdvsgPtyAddtlInf  : ISO20022.Tsrv002001.AdvisingPartyAdditionalInformation1
        + FrstAdvsgPtyAddtlInf  : ISO20022.Tsrv002001.AdvisingPartyAdditionalInformation1
        + UdrtkgIssncMsg  : ISO20022.Tsrv002001.UndertakingIssuanceMessage
    }
    ISO20022.Tsrv002001.UndertakingAdvice1 *-- ISO20022.Tsrv002001.PartyAndSignature2
    ISO20022.Tsrv002001.UndertakingAdvice1 *-- ISO20022.Tsrv002001.UndertakingConfirmation1
    ISO20022.Tsrv002001.UndertakingAdvice1 *-- ISO20022.Tsrv002001.AdvisingPartyAdditionalInformation1
    ISO20022.Tsrv002001.UndertakingAdvice1 *-- ISO20022.Tsrv002001.AdvisingPartyAdditionalInformation1
    ISO20022.Tsrv002001.UndertakingAdvice1 *-- ISO20022.Tsrv002001.UndertakingIssuanceMessage
    class ISO20022.Tsrv002001.UndertakingAmount1 {
        + AddtlInf  : global::System.Collections.Generic.List~String~
        + PlusTlrnce  : Decimal
        + Amt  : ISO20022.Tsrv002001.ActiveCurrencyAndAmount
    }
    ISO20022.Tsrv002001.UndertakingAmount1 *-- ISO20022.Tsrv002001.ActiveCurrencyAndAmount
    class ISO20022.Tsrv002001.UndertakingAmount4 {
        + BalAmt  : ISO20022.Tsrv002001.ActiveCurrencyAndAmount
        + VartnAmt  : ISO20022.Tsrv002001.ActiveCurrencyAndAmount
    }
    ISO20022.Tsrv002001.UndertakingAmount4 *-- ISO20022.Tsrv002001.ActiveCurrencyAndAmount
    ISO20022.Tsrv002001.UndertakingAmount4 *-- ISO20022.Tsrv002001.ActiveCurrencyAndAmount
    class ISO20022.Tsrv002001.UndertakingConfirmation1 {
        + Conf  : global::System.Collections.Generic.List~String~
        + Dt  : ISO20022.Tsrv002001.DateAndDateTimeChoice
        + RefNb  : String
        + Cnfrmr  : ISO20022.Tsrv002001.PartyIdentification43
    }
    ISO20022.Tsrv002001.UndertakingConfirmation1 *-- ISO20022.Tsrv002001.DateAndDateTimeChoice
    ISO20022.Tsrv002001.UndertakingConfirmation1 *-- ISO20022.Tsrv002001.PartyIdentification43
    class ISO20022.Tsrv002001.UndertakingDocumentType1Choice {
        + Prtry  : ISO20022.Tsrv002001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Tsrv002001.UndertakingDocumentType1Choice *-- ISO20022.Tsrv002001.GenericIdentification1
    class ISO20022.Tsrv002001.UndertakingDocumentType2Choice {
        + Prtry  : ISO20022.Tsrv002001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Tsrv002001.UndertakingDocumentType2Choice *-- ISO20022.Tsrv002001.GenericIdentification1
    class ISO20022.Tsrv002001.UndertakingIssuanceAdviceV01 {
        + DgtlSgntr  : ISO20022.Tsrv002001.PartyAndSignature2
        + BkToBkInf  : global::System.Collections.Generic.List~String~
        + UdrtkgIssncAdvcDtls  : ISO20022.Tsrv002001.UndertakingAdvice1
        + DtOfAdvc  : ISO20022.Tsrv002001.DateAndDateTimeChoice
        + ScndAdvsgPty  : ISO20022.Tsrv002001.PartyIdentification43
        + AdvsgPty  : ISO20022.Tsrv002001.PartyIdentification43
    }
    ISO20022.Tsrv002001.UndertakingIssuanceAdviceV01 *-- ISO20022.Tsrv002001.PartyAndSignature2
    ISO20022.Tsrv002001.UndertakingIssuanceAdviceV01 *-- ISO20022.Tsrv002001.UndertakingAdvice1
    ISO20022.Tsrv002001.UndertakingIssuanceAdviceV01 *-- ISO20022.Tsrv002001.DateAndDateTimeChoice
    ISO20022.Tsrv002001.UndertakingIssuanceAdviceV01 *-- ISO20022.Tsrv002001.PartyIdentification43
    ISO20022.Tsrv002001.UndertakingIssuanceAdviceV01 *-- ISO20022.Tsrv002001.PartyIdentification43
    class ISO20022.Tsrv002001.UndertakingIssuanceMessage {
        + DgtlSgntr  : ISO20022.Tsrv002001.PartyAndSignature2
        + UdrtkgDtls  : ISO20022.Tsrv002001.Undertaking3
    }
    ISO20022.Tsrv002001.UndertakingIssuanceMessage *-- ISO20022.Tsrv002001.PartyAndSignature2
    ISO20022.Tsrv002001.UndertakingIssuanceMessage *-- ISO20022.Tsrv002001.Undertaking3
    class ISO20022.Tsrv002001.UndertakingIssuanceName1Code {
        DGAR = 1
        STBY = 2
    }
    class ISO20022.Tsrv002001.UndertakingName1Code {
        DGAR = 1
        STBY = 2
    }
    class ISO20022.Tsrv002001.UndertakingType1Choice {
        + Prtry  : ISO20022.Tsrv002001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Tsrv002001.UndertakingType1Choice *-- ISO20022.Tsrv002001.GenericIdentification1
    class ISO20022.Tsrv002001.UndertakingWording1 {
        + UdrtkgTermsAndConds  : global::System.Collections.Generic.List~ISO20022.Tsrv002001.Narrative1~
        + ReqdWrdgLang  : String
        + MdlForm  : ISO20022.Tsrv002001.ModelFormIdentification1
    }
    ISO20022.Tsrv002001.UndertakingWording1 *-- ISO20022.Tsrv002001.Narrative1
    ISO20022.Tsrv002001.UndertakingWording1 *-- ISO20022.Tsrv002001.ModelFormIdentification1
    class ISO20022.Tsrv002001.VariationType1Code {
        INCR = 1
        DECR = 2
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

## Value ISO20022.Tsrv002001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Tsrv002001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Tsrv002001.AdvisingPartyAdditionalInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BkToBnfcryInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|RefNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""BkToBnfcryInf""",BkToBnfcryInf,5))|

---

## Value ISO20022.Tsrv002001.AmountAndTrigger1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Trggr|global::System.Collections.Generic.List<ISO20022.Tsrv002001.Trigger1>||XmlElement()||
|+|AmtDtlsChc|ISO20022.Tsrv002001.AmountOrPercentage1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Trggr""",Trggr),validList("""Trggr""",Trggr),validElement(Trggr),validElement(AmtDtlsChc))|

---

## Value ISO20022.Tsrv002001.AmountOrPercentage1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PctgAmt|ISO20022.Tsrv002001.Percentage1||XmlElement()||
|+|DfndAmt|ISO20022.Tsrv002001.UndertakingAmount4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PctgAmt),validElement(DfndAmt),validChoice(PctgAmt,DfndAmt))|

---

## Value ISO20022.Tsrv002001.AutoExtend1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dt|DateTime||XmlElement()||
|+|Yrs|Decimal||XmlElement()||
|+|Mnths|Decimal||XmlElement()||
|+|Days|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Dt,Yrs,Mnths,Days))|

---

## Value ISO20022.Tsrv002001.AutoExtension1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NonXtnsnNtfctn|global::System.Collections.Generic.List<ISO20022.Tsrv002001.NonExtension1>||XmlElement()||
|+|FnlXpryDt|DateTime||XmlElement()||
|+|Prd|ISO20022.Tsrv002001.AutoExtend1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""NonXtnsnNtfctn""",NonXtnsnNtfctn),validElement(NonXtnsnNtfctn),validElement(Prd))|

---

## Value ISO20022.Tsrv002001.AutomaticVariation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AmtAndTrggr|global::System.Collections.Generic.List<ISO20022.Tsrv002001.AmountAndTrigger1>||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AddtlInf""",AddtlInf,5),validRequired("""AmtAndTrggr""",AmtAndTrggr),validList("""AmtAndTrggr""",AmtAndTrggr),validElement(AmtAndTrggr))|

---

## Value ISO20022.Tsrv002001.Channel1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Tsrv002001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsrv002001.CommunicationChannel1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DlvrToAdr|ISO20022.Tsrv002001.PostalAddress6||XmlElement()||
|+|DlvrToNm|String||XmlElement()||
|+|DlvrToPtyTp|ISO20022.Tsrv002001.PartyType1Choice||XmlElement()||
|+|Mtd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DlvrToAdr),validElement(DlvrToPtyTp))|

---

## Value ISO20022.Tsrv002001.CommunicationMethod1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Tsrv002001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsrv002001.ContactDetails2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|String||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|MobNb|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""MobNb""",MobNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""PhneNb""",PhneNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Value ISO20022.Tsrv002001.CountrySubdivision1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Tsrv002001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsrv002001.DateAndDateTimeChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Tsrv002001.DateAndPlaceOfBirth


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Tsrv002001.DateInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nb|Decimal||XmlElement()||
|+|Frqcy|String||XmlElement()||
|+|StartDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Type ISO20022.Tsrv002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UdrtkgIssncAdvc|ISO20022.Tsrv002001.UndertakingIssuanceAdviceV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UdrtkgIssncAdvc))|

---

## Value ISO20022.Tsrv002001.Document10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SgndInd|String||XmlElement()||
|+|CpyInd|String||XmlElement()||
|+|DocFrmt|ISO20022.Tsrv002001.DocumentFormat1Choice||XmlElement()||
|+|PresntnChanl|ISO20022.Tsrv002001.Channel1Choice||XmlElement()||
|+|DocTp|ISO20022.Tsrv002001.UndertakingDocumentType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DocFrmt),validElement(PresntnChanl),validElement(DocTp))|

---

## Value ISO20022.Tsrv002001.Document8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ElctrncDtls|global::System.Collections.Generic.List<ISO20022.Tsrv002001.Presentation3>||XmlElement()||
|+|Wrdg|String||XmlElement()||
|+|Tp|ISO20022.Tsrv002001.PresentationDocumentFormat1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""ElctrncDtls""",ElctrncDtls),validElement(ElctrncDtls),validElement(Tp))|

---

## Value ISO20022.Tsrv002001.Document9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlSgntr|ISO20022.Tsrv002001.PartyAndSignature2||XmlElement()||
|+|Nclsr|String||XmlElement()||
|+|Frmt|ISO20022.Tsrv002001.DocumentFormat1Choice||XmlElement()||
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Tsrv002001.UndertakingDocumentType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgtlSgntr),validElement(Frmt),validElement(Tp))|

---

## Value ISO20022.Tsrv002001.DocumentFormat1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Tsrv002001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsrv002001.ExpiryDetails1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlXpryInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|XpryTerms|ISO20022.Tsrv002001.ExpiryTerms1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AddtlXpryInf""",AddtlXpryInf,5),validElement(XpryTerms))|

---

## Value ISO20022.Tsrv002001.ExpiryTerms1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OpnEnddInd|String||XmlElement()||
|+|Cond|String||XmlElement()||
|+|AutoXtnsn|ISO20022.Tsrv002001.AutoExtension1||XmlElement()||
|+|DtTm|ISO20022.Tsrv002001.DateAndDateTimeChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AutoXtnsn),validElement(DtTm))|

---

## Value ISO20022.Tsrv002001.FixedOrRecurrentDate1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RcrntDt|ISO20022.Tsrv002001.DateInformation1||XmlElement()||
|+|FxdDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RcrntDt),validChoice(RcrntDt,FxdDt))|

---

## Value ISO20022.Tsrv002001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsrv002001.GenericOrganisationIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Tsrv002001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Tsrv002001.GenericPersonIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Tsrv002001.PersonIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Tsrv002001.GovernanceIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Tsrv002001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Tsrv002001.GovernanceIdentification1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||URDG|Int32||XmlEnum("""URDG""")|1|
||UCPR|Int32||XmlEnum("""UCPR""")|2|
||NONE|Int32||XmlEnum("""NONE""")|3|
||ISPR|Int32||XmlEnum("""ISPR""")|4|

---

## Value ISO20022.Tsrv002001.GovernanceRules1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Jursdctn|global::System.Collections.Generic.List<ISO20022.Tsrv002001.Location1>||XmlElement()||
|+|AplblLaw|ISO20022.Tsrv002001.Location1||XmlElement()||
|+|RuleId|ISO20022.Tsrv002001.GovernanceIdentification1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Jursdctn""",Jursdctn),validElement(Jursdctn),validElement(AplblLaw),validElement(RuleId))|

---

## Enum ISO20022.Tsrv002001.IssuanceType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ISAD|Int32||XmlEnum("""ISAD""")|1|
||ISCO|Int32||XmlEnum("""ISCO""")|2|
||ISSU|Int32||XmlEnum("""ISSU""")|3|
||CRQC|Int32||XmlEnum("""CRQC""")|4|
||CRQL|Int32||XmlEnum("""CRQL""")|5|

---

## Value ISO20022.Tsrv002001.Location1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txt|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CtrySubDvsn|ISO20022.Tsrv002001.CountrySubdivision1Choice||XmlElement()||
|+|Ctry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""Txt""",Txt,5),validElement(CtrySubDvsn),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Tsrv002001.ModelFormIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Vrsn|String||XmlElement()||
|+|Id|ISO20022.Tsrv002001.ModelFormIdentification1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Tsrv002001.ModelFormIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Tsrv002001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Tsrv002001.NamePrefix1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MADM|Int32||XmlEnum("""MADM""")|1|
||MISS|Int32||XmlEnum("""MISS""")|2|
||MIST|Int32||XmlEnum("""MIST""")|3|
||DOCT|Int32||XmlEnum("""DOCT""")|4|

---

## Value ISO20022.Tsrv002001.Narrative1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txt|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Tp|ISO20022.Tsrv002001.NarrativeType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Txt""",Txt),validListMax("""Txt""",Txt,5),validElement(Tp))|

---

## Value ISO20022.Tsrv002001.NarrativeType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Tsrv002001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsrv002001.NonExtension1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NtfctnRcptAdr|ISO20022.Tsrv002001.PostalAddress6||XmlElement()||
|+|NtfctnRcptNm|String||XmlElement()||
|+|NtfctnRcptTp|ISO20022.Tsrv002001.PartyType1Choice||XmlElement()||
|+|NtfctnMtd|ISO20022.Tsrv002001.CommunicationMethod1Choice||XmlElement()||
|+|NtfctnPrd|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NtfctnRcptAdr),validElement(NtfctnRcptTp),validElement(NtfctnMtd))|

---

## Value ISO20022.Tsrv002001.OrganisationIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Tsrv002001.GenericOrganisationIdentification1>||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Tsrv002001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsrv002001.Party11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|ISO20022.Tsrv002001.PersonIdentification5||XmlElement()||
|+|OrgId|ISO20022.Tsrv002001.OrganisationIdentification8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvtId),validElement(OrgId),validChoice(PrvtId,OrgId))|

---

## Value ISO20022.Tsrv002001.PartyAndSignature2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgntr|ISO20022.Tsrv002001.ProprietaryData3||XmlElement()||
|+|Pty|ISO20022.Tsrv002001.PartyIdentification43||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Sgntr),validElement(Pty))|

---

## Value ISO20022.Tsrv002001.PartyAndType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty|ISO20022.Tsrv002001.PartyIdentification43||XmlElement()||
|+|Tp|ISO20022.Tsrv002001.PartyType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty),validElement(Tp))|

---

## Value ISO20022.Tsrv002001.PartyIdentification43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Tsrv002001.ContactDetails2||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Tsrv002001.Party11Choice||XmlElement()||
|+|PstlAdr|ISO20022.Tsrv002001.PostalAddress6||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Value ISO20022.Tsrv002001.PartyType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Tsrv002001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsrv002001.Percentage1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltvTo|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsrv002001.PersonIdentification5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Tsrv002001.GenericPersonIdentification1>||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Tsrv002001.DateAndPlaceOfBirth||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(DtAndPlcOfBirth))|

---

## Value ISO20022.Tsrv002001.PersonIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsrv002001.PlaceOfPresentation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|Plc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Tsrv002001.PlaceOrUnderConfirmationChoice1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PresntnUdrConf|String||XmlElement()||
|+|PlcOfPresntn|ISO20022.Tsrv002001.PlaceOfPresentation1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PlcOfPresntn),validChoice(PresntnUdrConf,PlcOfPresntn))|

---

## Value ISO20022.Tsrv002001.PostalAddress12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Tsrv002001.PostalAddress6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|SubDept|String||XmlElement()||
|+|Dept|String||XmlElement()||
|+|AdrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Tsrv002001.Presentation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Doc|global::System.Collections.Generic.List<ISO20022.Tsrv002001.Document8>||XmlElement()||
|+|PlcOfPresntnOrUdrConfChc|ISO20022.Tsrv002001.PlaceOrUnderConfirmationChoice1||XmlElement()||
|+|Mdm|ISO20022.Tsrv002001.PresentationMedium1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AddtlInf""",AddtlInf,5),validList("""Doc""",Doc),validElement(Doc),validElement(PlcOfPresntnOrUdrConfChc),validElement(Mdm))|

---

## Value ISO20022.Tsrv002001.Presentation3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|String||XmlElement()||
|+|Chanl|ISO20022.Tsrv002001.Channel1Choice||XmlElement()||
|+|Frmt|ISO20022.Tsrv002001.DocumentFormat1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Chanl),validElement(Frmt))|

---

## Value ISO20022.Tsrv002001.PresentationDocumentFormat1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Tsrv002001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsrv002001.PresentationMedium1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Tsrv002001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Tsrv002001.PresentationMedium1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PAPR|Int32||XmlEnum("""PAPR""")|1|
||ELEC|Int32||XmlEnum("""ELEC""")|2|
||BOTH|Int32||XmlEnum("""BOTH""")|3|

---

## Enum ISO20022.Tsrv002001.PresentationParty1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXIS|Int32||XmlEnum("""EXIS""")|1|
||EXCN|Int32||XmlEnum("""EXCN""")|2|
||ETHR|Int32||XmlEnum("""ETHR""")|3|

---

## Value ISO20022.Tsrv002001.ProprietaryData3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsrv002001.Trigger1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DcmntryEvt|global::System.Collections.Generic.List<ISO20022.Tsrv002001.Document10>||XmlElement()||
|+|DtChc|ISO20022.Tsrv002001.FixedOrRecurrentDate1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""DcmntryEvt""",DcmntryEvt),validElement(DcmntryEvt),validElement(DtChc))|

---

## Value ISO20022.Tsrv002001.UnderlyingTradeTransaction1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CtrctAmtPctg|Decimal||XmlElement()||
|+|TxAmt|ISO20022.Tsrv002001.ActiveCurrencyAndAmount||XmlElement()||
|+|TndrClsgDt|DateTime||XmlElement()||
|+|TxDt|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Tsrv002001.UnderlyingTradeTransactionType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AddtlInf""",AddtlInf,5),validElement(TxAmt),validElement(Tp))|

---

## Value ISO20022.Tsrv002001.UnderlyingTradeTransactionType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Tsrv002001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsrv002001.Undertaking3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ReqdLclUdrtkg|ISO20022.Tsrv002001.Undertaking4||XmlElement()||
|+|AddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|NclsdFile|global::System.Collections.Generic.List<ISO20022.Tsrv002001.Document9>||XmlElement()||
|+|TrfInd|String||XmlElement()||
|+|DlvryChanl|ISO20022.Tsrv002001.CommunicationChannel1||XmlElement()||
|+|AutomtcAmtVartn|global::System.Collections.Generic.List<ISO20022.Tsrv002001.AutomaticVariation1>||XmlElement()||
|+|TrfChrgsPyblBy|String||XmlElement()||
|+|ConfChrgsPyblBy|String||XmlElement()||
|+|PrtlDmndInd|String||XmlElement()||
|+|MltplDmndInd|String||XmlElement()||
|+|UdrtkgTermsAndConds|global::System.Collections.Generic.List<ISO20022.Tsrv002001.Narrative1>||XmlElement()||
|+|PresntnDtls|ISO20022.Tsrv002001.Presentation1||XmlElement()||
|+|UndrlygTx|global::System.Collections.Generic.List<ISO20022.Tsrv002001.UnderlyingTradeTransaction1>||XmlElement()||
|+|GovncRulesAndLaw|ISO20022.Tsrv002001.GovernanceRules1||XmlElement()||
|+|AddtlPty|global::System.Collections.Generic.List<ISO20022.Tsrv002001.PartyAndType1>||XmlElement()||
|+|ConfPtyTp|String||XmlElement()||
|+|ConfInd|String||XmlElement()||
|+|XpryDtls|ISO20022.Tsrv002001.ExpiryDetails1||XmlElement()||
|+|UdrtkgAmt|ISO20022.Tsrv002001.UndertakingAmount1||XmlElement()||
|+|ScndAdvsgPty|ISO20022.Tsrv002001.PartyIdentification43||XmlElement()||
|+|AdvsgPty|ISO20022.Tsrv002001.PartyIdentification43||XmlElement()||
|+|PlcOfIsse|ISO20022.Tsrv002001.PostalAddress12||XmlElement()||
|+|DtOfIssnc|DateTime||XmlElement()||
|+|Bnfcry|global::System.Collections.Generic.List<ISO20022.Tsrv002001.PartyIdentification43>||XmlElement()||
|+|Issr|ISO20022.Tsrv002001.PartyIdentification43||XmlElement()||
|+|Applcnt|global::System.Collections.Generic.List<ISO20022.Tsrv002001.PartyIdentification43>||XmlElement()||
|+|IssncTp|String||XmlElement()||
|+|Tp|ISO20022.Tsrv002001.UndertakingType1Choice||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ReqdLclUdrtkg),validListMax("""AddtlInf""",AddtlInf,5),validList("""NclsdFile""",NclsdFile),validElement(NclsdFile),validElement(DlvryChanl),validList("""AutomtcAmtVartn""",AutomtcAmtVartn),validElement(AutomtcAmtVartn),validRequired("""UdrtkgTermsAndConds""",UdrtkgTermsAndConds),validList("""UdrtkgTermsAndConds""",UdrtkgTermsAndConds),validElement(UdrtkgTermsAndConds),validElement(PresntnDtls),validList("""UndrlygTx""",UndrlygTx),validElement(UndrlygTx),validElement(GovncRulesAndLaw),validList("""AddtlPty""",AddtlPty),validElement(AddtlPty),validElement(XpryDtls),validElement(UdrtkgAmt),validElement(ScndAdvsgPty),validElement(AdvsgPty),validElement(PlcOfIsse),validRequired("""Bnfcry""",Bnfcry),validList("""Bnfcry""",Bnfcry),validElement(Bnfcry),validElement(Issr),validList("""Applcnt""",Applcnt),validElement(Applcnt),validElement(Tp))|

---

## Value ISO20022.Tsrv002001.Undertaking4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TrfInd|String||XmlElement()||
|+|DlvryChanl|ISO20022.Tsrv002001.CommunicationChannel1||XmlElement()||
|+|AutomtcAmtVartn|global::System.Collections.Generic.List<ISO20022.Tsrv002001.AutomaticVariation1>||XmlElement()||
|+|TrfChrgsPyblBy|String||XmlElement()||
|+|ConfChrgsPyblBy|String||XmlElement()||
|+|PrtlDmndInd|String||XmlElement()||
|+|MltplDmndInd|String||XmlElement()||
|+|UdrtkgWrdg|ISO20022.Tsrv002001.UndertakingWording1||XmlElement()||
|+|PresntnDtls|ISO20022.Tsrv002001.Presentation1||XmlElement()||
|+|UndrlygTx|global::System.Collections.Generic.List<ISO20022.Tsrv002001.UnderlyingTradeTransaction1>||XmlElement()||
|+|GovncRulesAndLaw|ISO20022.Tsrv002001.GovernanceRules1||XmlElement()||
|+|AddtlPty|global::System.Collections.Generic.List<ISO20022.Tsrv002001.PartyAndType1>||XmlElement()||
|+|ConfInd|String||XmlElement()||
|+|XpryDtls|ISO20022.Tsrv002001.ExpiryDetails1||XmlElement()||
|+|LclUdrtkgAmt|ISO20022.Tsrv002001.UndertakingAmount1||XmlElement()||
|+|ScndAdvsgPty|ISO20022.Tsrv002001.PartyIdentification43||XmlElement()||
|+|AdvsgPty|ISO20022.Tsrv002001.PartyIdentification43||XmlElement()||
|+|DtOfIssnc|DateTime||XmlElement()||
|+|Bnfcry|global::System.Collections.Generic.List<ISO20022.Tsrv002001.PartyIdentification43>||XmlElement()||
|+|Applcnt|global::System.Collections.Generic.List<ISO20022.Tsrv002001.PartyIdentification43>||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AddtlInf""",AddtlInf,5),validElement(DlvryChanl),validList("""AutomtcAmtVartn""",AutomtcAmtVartn),validElement(AutomtcAmtVartn),validElement(UdrtkgWrdg),validElement(PresntnDtls),validList("""UndrlygTx""",UndrlygTx),validElement(UndrlygTx),validElement(GovncRulesAndLaw),validList("""AddtlPty""",AddtlPty),validElement(AddtlPty),validElement(XpryDtls),validElement(LclUdrtkgAmt),validElement(ScndAdvsgPty),validElement(AdvsgPty),validRequired("""Bnfcry""",Bnfcry),validList("""Bnfcry""",Bnfcry),validElement(Bnfcry),validRequired("""Applcnt""",Applcnt),validList("""Applcnt""",Applcnt),validElement(Applcnt))|

---

## Value ISO20022.Tsrv002001.UndertakingAdvice1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlSgntr|global::System.Collections.Generic.List<ISO20022.Tsrv002001.PartyAndSignature2>||XmlElement()||
|+|ConfDtls|ISO20022.Tsrv002001.UndertakingConfirmation1||XmlElement()||
|+|ScndAdvsgPtyAddtlInf|ISO20022.Tsrv002001.AdvisingPartyAdditionalInformation1||XmlElement()||
|+|FrstAdvsgPtyAddtlInf|ISO20022.Tsrv002001.AdvisingPartyAdditionalInformation1||XmlElement()||
|+|UdrtkgIssncMsg|ISO20022.Tsrv002001.UndertakingIssuanceMessage||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""DgtlSgntr""",DgtlSgntr),validListMax("""DgtlSgntr""",DgtlSgntr,3),validElement(DgtlSgntr),validElement(ConfDtls),validElement(ScndAdvsgPtyAddtlInf),validElement(FrstAdvsgPtyAddtlInf),validElement(UdrtkgIssncMsg))|

---

## Value ISO20022.Tsrv002001.UndertakingAmount1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PlusTlrnce|Decimal||XmlElement()||
|+|Amt|ISO20022.Tsrv002001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AddtlInf""",AddtlInf,5),validElement(Amt))|

---

## Value ISO20022.Tsrv002001.UndertakingAmount4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BalAmt|ISO20022.Tsrv002001.ActiveCurrencyAndAmount||XmlElement()||
|+|VartnAmt|ISO20022.Tsrv002001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BalAmt),validElement(VartnAmt))|

---

## Value ISO20022.Tsrv002001.UndertakingConfirmation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Conf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Dt|ISO20022.Tsrv002001.DateAndDateTimeChoice||XmlElement()||
|+|RefNb|String||XmlElement()||
|+|Cnfrmr|ISO20022.Tsrv002001.PartyIdentification43||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""Conf""",Conf,5),validElement(Dt),validElement(Cnfrmr))|

---

## Value ISO20022.Tsrv002001.UndertakingDocumentType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Tsrv002001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsrv002001.UndertakingDocumentType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Tsrv002001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Aspect ISO20022.Tsrv002001.UndertakingIssuanceAdviceV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlSgntr|ISO20022.Tsrv002001.PartyAndSignature2||XmlElement()||
|+|BkToBkInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|UdrtkgIssncAdvcDtls|ISO20022.Tsrv002001.UndertakingAdvice1||XmlElement()||
|+|DtOfAdvc|ISO20022.Tsrv002001.DateAndDateTimeChoice||XmlElement()||
|+|ScndAdvsgPty|ISO20022.Tsrv002001.PartyIdentification43||XmlElement()||
|+|AdvsgPty|ISO20022.Tsrv002001.PartyIdentification43||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgtlSgntr),validListMax("""BkToBkInf""",BkToBkInf,5),validElement(UdrtkgIssncAdvcDtls),validElement(DtOfAdvc),validElement(ScndAdvsgPty),validElement(AdvsgPty))|

---

## Value ISO20022.Tsrv002001.UndertakingIssuanceMessage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlSgntr|ISO20022.Tsrv002001.PartyAndSignature2||XmlElement()||
|+|UdrtkgDtls|ISO20022.Tsrv002001.Undertaking3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgtlSgntr),validElement(UdrtkgDtls))|

---

## Enum ISO20022.Tsrv002001.UndertakingIssuanceName1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DGAR|Int32||XmlEnum("""DGAR""")|1|
||STBY|Int32||XmlEnum("""STBY""")|2|

---

## Enum ISO20022.Tsrv002001.UndertakingName1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DGAR|Int32||XmlEnum("""DGAR""")|1|
||STBY|Int32||XmlEnum("""STBY""")|2|

---

## Value ISO20022.Tsrv002001.UndertakingType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Tsrv002001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsrv002001.UndertakingWording1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UdrtkgTermsAndConds|global::System.Collections.Generic.List<ISO20022.Tsrv002001.Narrative1>||XmlElement()||
|+|ReqdWrdgLang|String||XmlElement()||
|+|MdlForm|ISO20022.Tsrv002001.ModelFormIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""UdrtkgTermsAndConds""",UdrtkgTermsAndConds),validElement(UdrtkgTermsAndConds),validPattern("""ReqdWrdgLang""",ReqdWrdgLang,"""[a-z]{2,2}"""),validElement(MdlForm))|

---

## Enum ISO20022.Tsrv002001.VariationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INCR|Int32||XmlEnum("""INCR""")|1|
||DECR|Int32||XmlEnum("""DECR""")|2|

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

