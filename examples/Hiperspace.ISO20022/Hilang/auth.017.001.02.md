# auth.017.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Auth017001.ActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Auth017001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Auth017001.AgriculturalCommodityDairy1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.AgriculturalCommodityForestry1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.AgriculturalCommodityGrain1 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.AgriculturalCommodityLiveStock1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.AgriculturalCommodityOilSeed1 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.AgriculturalCommodityOliveOil1 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.AgriculturalCommodityPotato1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.AgriculturalCommoditySeafood1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.AgriculturalCommoditySoft1 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.AmountAndDirection61 {
        + Sgn  : String
        + Amt  : ISO20022.Auth017001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Auth017001.AmountAndDirection61 *-- ISO20022.Auth017001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Auth017001.AssetClass2 {
        + FX  : ISO20022.Auth017001.DerivativeForeignExchange3
        + Intrst  : ISO20022.Auth017001.DerivativeInterest3
        + Cmmdty  : ISO20022.Auth017001.DerivativeCommodity2
    }
    ISO20022.Auth017001.AssetClass2 *-- ISO20022.Auth017001.DerivativeForeignExchange3
    ISO20022.Auth017001.AssetClass2 *-- ISO20022.Auth017001.DerivativeInterest3
    ISO20022.Auth017001.AssetClass2 *-- ISO20022.Auth017001.DerivativeCommodity2
    class ISO20022.Auth017001.AssetClassCommodity3Choice {
        + Othr  : ISO20022.Auth017001.AssetClassCommodityOther1
        + OffclEcnmcSttstcs  : ISO20022.Auth017001.AssetClassCommodityOfficialEconomicStatistics1
        + MultiCmmdtyExtc  : ISO20022.Auth017001.AssetClassCommodityMultiCommodityExotic1
        + Infltn  : ISO20022.Auth017001.AssetClassCommodityInflation1
        + Plprpln  : ISO20022.Auth017001.AssetClassCommodityPolypropylene1Choice
        + Ppr  : ISO20022.Auth017001.AssetClassCommodityPaper1Choice
        + OthrC10  : ISO20022.Auth017001.AssetClassCommodityOtherC102Choice
        + Metl  : ISO20022.Auth017001.AssetClassCommodityMetal1Choice
        + IndstrlPdct  : ISO20022.Auth017001.AssetClassCommodityIndustrialProduct1Choice
        + Frght  : ISO20022.Auth017001.AssetClassCommodityFreight1Choice
        + Frtlzr  : ISO20022.Auth017001.AssetClassCommodityFertilizer1Choice
        + Envttl  : ISO20022.Auth017001.AssetClassCommodityEnvironmental1Choice
        + Nrgy  : ISO20022.Auth017001.AssetClassCommodityEnergy1Choice
        + Agrcltrl  : ISO20022.Auth017001.AssetClassCommodityAgricultural1Choice
    }
    ISO20022.Auth017001.AssetClassCommodity3Choice *-- ISO20022.Auth017001.AssetClassCommodityOther1
    ISO20022.Auth017001.AssetClassCommodity3Choice *-- ISO20022.Auth017001.AssetClassCommodityOfficialEconomicStatistics1
    ISO20022.Auth017001.AssetClassCommodity3Choice *-- ISO20022.Auth017001.AssetClassCommodityMultiCommodityExotic1
    ISO20022.Auth017001.AssetClassCommodity3Choice *-- ISO20022.Auth017001.AssetClassCommodityInflation1
    ISO20022.Auth017001.AssetClassCommodity3Choice *-- ISO20022.Auth017001.AssetClassCommodityPolypropylene1Choice
    ISO20022.Auth017001.AssetClassCommodity3Choice *-- ISO20022.Auth017001.AssetClassCommodityPaper1Choice
    ISO20022.Auth017001.AssetClassCommodity3Choice *-- ISO20022.Auth017001.AssetClassCommodityOtherC102Choice
    ISO20022.Auth017001.AssetClassCommodity3Choice *-- ISO20022.Auth017001.AssetClassCommodityMetal1Choice
    ISO20022.Auth017001.AssetClassCommodity3Choice *-- ISO20022.Auth017001.AssetClassCommodityIndustrialProduct1Choice
    ISO20022.Auth017001.AssetClassCommodity3Choice *-- ISO20022.Auth017001.AssetClassCommodityFreight1Choice
    ISO20022.Auth017001.AssetClassCommodity3Choice *-- ISO20022.Auth017001.AssetClassCommodityFertilizer1Choice
    ISO20022.Auth017001.AssetClassCommodity3Choice *-- ISO20022.Auth017001.AssetClassCommodityEnvironmental1Choice
    ISO20022.Auth017001.AssetClassCommodity3Choice *-- ISO20022.Auth017001.AssetClassCommodityEnergy1Choice
    ISO20022.Auth017001.AssetClassCommodity3Choice *-- ISO20022.Auth017001.AssetClassCommodityAgricultural1Choice
    class ISO20022.Auth017001.AssetClassCommodityAgricultural1Choice {
        + Grn  : ISO20022.Auth017001.AgriculturalCommodityGrain1
        + LiveStock  : ISO20022.Auth017001.AgriculturalCommodityLiveStock1
        + Sfd  : ISO20022.Auth017001.AgriculturalCommoditySeafood1
        + Frstry  : ISO20022.Auth017001.AgriculturalCommodityForestry1
        + Dairy  : ISO20022.Auth017001.AgriculturalCommodityDairy1
        + OlvOil  : ISO20022.Auth017001.AgriculturalCommodityOliveOil1
        + Ptt  : ISO20022.Auth017001.AgriculturalCommodityPotato1
        + Soft  : ISO20022.Auth017001.AgriculturalCommoditySoft1
        + GrnOilSeed  : ISO20022.Auth017001.AgriculturalCommodityOilSeed1
    }
    ISO20022.Auth017001.AssetClassCommodityAgricultural1Choice *-- ISO20022.Auth017001.AgriculturalCommodityGrain1
    ISO20022.Auth017001.AssetClassCommodityAgricultural1Choice *-- ISO20022.Auth017001.AgriculturalCommodityLiveStock1
    ISO20022.Auth017001.AssetClassCommodityAgricultural1Choice *-- ISO20022.Auth017001.AgriculturalCommoditySeafood1
    ISO20022.Auth017001.AssetClassCommodityAgricultural1Choice *-- ISO20022.Auth017001.AgriculturalCommodityForestry1
    ISO20022.Auth017001.AssetClassCommodityAgricultural1Choice *-- ISO20022.Auth017001.AgriculturalCommodityDairy1
    ISO20022.Auth017001.AssetClassCommodityAgricultural1Choice *-- ISO20022.Auth017001.AgriculturalCommodityOliveOil1
    ISO20022.Auth017001.AssetClassCommodityAgricultural1Choice *-- ISO20022.Auth017001.AgriculturalCommodityPotato1
    ISO20022.Auth017001.AssetClassCommodityAgricultural1Choice *-- ISO20022.Auth017001.AgriculturalCommoditySoft1
    ISO20022.Auth017001.AssetClassCommodityAgricultural1Choice *-- ISO20022.Auth017001.AgriculturalCommodityOilSeed1
    class ISO20022.Auth017001.AssetClassCommodityEnergy1Choice {
        + Dstllts  : ISO20022.Auth017001.EnergyCommodityDistillates1
        + LghtEnd  : ISO20022.Auth017001.EnergyCommodityLightEnd1
        + RnwblNrgy  : ISO20022.Auth017001.EnergyCommodityRenewableEnergy1
        + IntrNrgy  : ISO20022.Auth017001.EnergyCommodityInterEnergy1
        + Coal  : ISO20022.Auth017001.EnergyCommodityCoal1
        + Oil  : ISO20022.Auth017001.EnergyCommodityOil1
        + NtrlGas  : ISO20022.Auth017001.EnergyCommodityNaturalGas1
        + Elctrcty  : ISO20022.Auth017001.EnergyCommodityElectricity1
    }
    ISO20022.Auth017001.AssetClassCommodityEnergy1Choice *-- ISO20022.Auth017001.EnergyCommodityDistillates1
    ISO20022.Auth017001.AssetClassCommodityEnergy1Choice *-- ISO20022.Auth017001.EnergyCommodityLightEnd1
    ISO20022.Auth017001.AssetClassCommodityEnergy1Choice *-- ISO20022.Auth017001.EnergyCommodityRenewableEnergy1
    ISO20022.Auth017001.AssetClassCommodityEnergy1Choice *-- ISO20022.Auth017001.EnergyCommodityInterEnergy1
    ISO20022.Auth017001.AssetClassCommodityEnergy1Choice *-- ISO20022.Auth017001.EnergyCommodityCoal1
    ISO20022.Auth017001.AssetClassCommodityEnergy1Choice *-- ISO20022.Auth017001.EnergyCommodityOil1
    ISO20022.Auth017001.AssetClassCommodityEnergy1Choice *-- ISO20022.Auth017001.EnergyCommodityNaturalGas1
    ISO20022.Auth017001.AssetClassCommodityEnergy1Choice *-- ISO20022.Auth017001.EnergyCommodityElectricity1
    class ISO20022.Auth017001.AssetClassCommodityEnvironmental1Choice {
        + CrbnRltd  : ISO20022.Auth017001.EnvironmentalCommodityCarbonRelated1
        + Wthr  : ISO20022.Auth017001.EnvironmentalCommodityWeather1
        + Emssns  : ISO20022.Auth017001.EnvironmentalCommodityEmission1
    }
    ISO20022.Auth017001.AssetClassCommodityEnvironmental1Choice *-- ISO20022.Auth017001.EnvironmentalCommodityCarbonRelated1
    ISO20022.Auth017001.AssetClassCommodityEnvironmental1Choice *-- ISO20022.Auth017001.EnvironmentalCommodityWeather1
    ISO20022.Auth017001.AssetClassCommodityEnvironmental1Choice *-- ISO20022.Auth017001.EnvironmentalCommodityEmission1
    class ISO20022.Auth017001.AssetClassCommodityFertilizer1Choice {
        + UreaAndAmmnmNtrt  : ISO20022.Auth017001.FertilizerCommodityUreaAndAmmoniumNitrate1
        + Urea  : ISO20022.Auth017001.FertilizerCommodityUrea1
        + Slphr  : ISO20022.Auth017001.FertilizerCommoditySulphur1
        + Ptsh  : ISO20022.Auth017001.FertilizerCommodityPotash1
        + DmmnmPhspht  : ISO20022.Auth017001.FertilizerCommodityDiammoniumPhosphate1
        + Ammn  : ISO20022.Auth017001.FertilizerCommodityAmmonia1
    }
    ISO20022.Auth017001.AssetClassCommodityFertilizer1Choice *-- ISO20022.Auth017001.FertilizerCommodityUreaAndAmmoniumNitrate1
    ISO20022.Auth017001.AssetClassCommodityFertilizer1Choice *-- ISO20022.Auth017001.FertilizerCommodityUrea1
    ISO20022.Auth017001.AssetClassCommodityFertilizer1Choice *-- ISO20022.Auth017001.FertilizerCommoditySulphur1
    ISO20022.Auth017001.AssetClassCommodityFertilizer1Choice *-- ISO20022.Auth017001.FertilizerCommodityPotash1
    ISO20022.Auth017001.AssetClassCommodityFertilizer1Choice *-- ISO20022.Auth017001.FertilizerCommodityDiammoniumPhosphate1
    ISO20022.Auth017001.AssetClassCommodityFertilizer1Choice *-- ISO20022.Auth017001.FertilizerCommodityAmmonia1
    class ISO20022.Auth017001.AssetClassCommodityFreight1Choice {
        + CntnrShip  : ISO20022.Auth017001.FreightCommodityContainerShip1
        + Wet  : ISO20022.Auth017001.FreightCommodityWet1
        + Dry  : ISO20022.Auth017001.FreightCommodityDry1
    }
    ISO20022.Auth017001.AssetClassCommodityFreight1Choice *-- ISO20022.Auth017001.FreightCommodityContainerShip1
    ISO20022.Auth017001.AssetClassCommodityFreight1Choice *-- ISO20022.Auth017001.FreightCommodityWet1
    ISO20022.Auth017001.AssetClassCommodityFreight1Choice *-- ISO20022.Auth017001.FreightCommodityDry1
    class ISO20022.Auth017001.AssetClassCommodityIndustrialProduct1Choice {
        + Manfctg  : ISO20022.Auth017001.IndustrialProductCommodityManufacturing1
        + Cnstrctn  : ISO20022.Auth017001.IndustrialProductCommodityConstruction1
    }
    ISO20022.Auth017001.AssetClassCommodityIndustrialProduct1Choice *-- ISO20022.Auth017001.IndustrialProductCommodityManufacturing1
    ISO20022.Auth017001.AssetClassCommodityIndustrialProduct1Choice *-- ISO20022.Auth017001.IndustrialProductCommodityConstruction1
    class ISO20022.Auth017001.AssetClassCommodityInflation1 {
        + BasePdct  : String
    }
    class ISO20022.Auth017001.AssetClassCommodityMetal1Choice {
        + Prcs  : ISO20022.Auth017001.MetalCommodityPrecious1
        + NonPrcs  : ISO20022.Auth017001.MetalCommodityNonPrecious1
    }
    ISO20022.Auth017001.AssetClassCommodityMetal1Choice *-- ISO20022.Auth017001.MetalCommodityPrecious1
    ISO20022.Auth017001.AssetClassCommodityMetal1Choice *-- ISO20022.Auth017001.MetalCommodityNonPrecious1
    class ISO20022.Auth017001.AssetClassCommodityMultiCommodityExotic1 {
        + BasePdct  : String
    }
    class ISO20022.Auth017001.AssetClassCommodityOfficialEconomicStatistics1 {
        + BasePdct  : String
    }
    class ISO20022.Auth017001.AssetClassCommodityOther1 {
        + BasePdct  : String
    }
    class ISO20022.Auth017001.AssetClassCommodityOtherC102Choice {
        + NonDlvrbl  : ISO20022.Auth017001.OtherC10CommodityNonDeliverable2
        + Dlvrbl  : ISO20022.Auth017001.OtherC10CommodityDeliverable2
    }
    ISO20022.Auth017001.AssetClassCommodityOtherC102Choice *-- ISO20022.Auth017001.OtherC10CommodityNonDeliverable2
    ISO20022.Auth017001.AssetClassCommodityOtherC102Choice *-- ISO20022.Auth017001.OtherC10CommodityDeliverable2
    class ISO20022.Auth017001.AssetClassCommodityPaper1Choice {
        + RcvrdPpr  : ISO20022.Auth017001.PaperCommodityRecoveredPaper1
        + Pulp  : ISO20022.Auth017001.PaperCommodityPulp1
        + Nwsprnt  : ISO20022.Auth017001.PaperCommodityNewsprint1
        + CntnrBrd  : ISO20022.Auth017001.PaperCommodityContainerBoard1
    }
    ISO20022.Auth017001.AssetClassCommodityPaper1Choice *-- ISO20022.Auth017001.PaperCommodityRecoveredPaper1
    ISO20022.Auth017001.AssetClassCommodityPaper1Choice *-- ISO20022.Auth017001.PaperCommodityPulp1
    ISO20022.Auth017001.AssetClassCommodityPaper1Choice *-- ISO20022.Auth017001.PaperCommodityNewsprint1
    ISO20022.Auth017001.AssetClassCommodityPaper1Choice *-- ISO20022.Auth017001.PaperCommodityContainerBoard1
    class ISO20022.Auth017001.AssetClassCommodityPolypropylene1Choice {
        + Plstc  : ISO20022.Auth017001.PolypropyleneCommodityPlastic1
    }
    ISO20022.Auth017001.AssetClassCommodityPolypropylene1Choice *-- ISO20022.Auth017001.PolypropyleneCommodityPlastic1
    class ISO20022.Auth017001.AssetClassDetailedSubProductType10Code {
        LEAD = 1
        OTHR = 2
        ZINC = 3
        TINN = 4
        STEL = 5
        NICK = 6
        NASC = 7
        MOLY = 8
        IRON = 9
        COPR = 10
        CBLT = 11
        ALUA = 12
        ALUM = 13
    }
    class ISO20022.Auth017001.AssetClassDetailedSubProductType11Code {
        SLVR = 1
        PTNM = 2
        PLDM = 3
        OTHR = 4
        GOLD = 5
    }
    class ISO20022.Auth017001.AssetClassDetailedSubProductType12Code {
        TNKR = 1
    }
    class ISO20022.Auth017001.AssetClassDetailedSubProductType14Code {
        DBCR = 1
    }
    class ISO20022.Auth017001.AssetClassDetailedSubProductType15Code {
        MWHT = 1
    }
    class ISO20022.Auth017001.AssetClassDetailedSubProductType1Code {
        RICE = 1
        CORN = 2
        OTHR = 3
        RPSD = 4
        SOYB = 5
        FWHT = 6
    }
    class ISO20022.Auth017001.AssetClassDetailedSubProductType2Code {
        OTHR = 1
        WHSG = 2
        BRWN = 3
        CCOA = 4
        ROBU = 5
    }
    class ISO20022.Auth017001.AssetClassDetailedSubProductType4Code {
        LAMP = 1
    }
    class ISO20022.Auth017001.AssetClassDetailedSubProductType5Code {
        OTHR = 1
        OFFP = 2
        PKLD = 3
        FITR = 4
        BSLD = 5
    }
    class ISO20022.Auth017001.AssetClassDetailedSubProductType6Code {
        NBPG = 1
        TTFG = 2
        NCGG = 3
        LNGG = 4
        GASP = 5
    }
    class ISO20022.Auth017001.AssetClassDetailedSubProductType7Code {
        URAL = 1
        WTIO = 2
        TAPI = 3
        NGLO = 4
        NAPH = 5
        MARS = 6
        LLSO = 7
        KERO = 8
        JTFL = 9
        HEAT = 10
        GSLN = 11
        GOIL = 12
        FOIL = 13
        FUEL = 14
        ETHA = 15
        ESPO = 16
        DUBA = 17
        DSEL = 18
        COND = 19
        CNDA = 20
        BRNX = 21
        BRNT = 22
        BDSL = 23
        BAKK = 24
    }
    class ISO20022.Auth017001.AssetClassDetailedSubProductType8Code {
        OTHR = 1
        EUAA = 2
        EUAE = 3
        ERUE = 4
        CERE = 5
    }
    class ISO20022.Auth017001.AssetClassProductType11Code {
        OTHC = 1
    }
    class ISO20022.Auth017001.AssetClassProductType12Code {
        INFL = 1
    }
    class ISO20022.Auth017001.AssetClassProductType13Code {
        MCEX = 1
    }
    class ISO20022.Auth017001.AssetClassProductType14Code {
        OEST = 1
    }
    class ISO20022.Auth017001.AssetClassProductType15Code {
        OTHR = 1
    }
    class ISO20022.Auth017001.AssetClassProductType1Code {
        AGRI = 1
    }
    class ISO20022.Auth017001.AssetClassProductType2Code {
        NRGY = 1
    }
    class ISO20022.Auth017001.AssetClassProductType3Code {
        ENVR = 1
    }
    class ISO20022.Auth017001.AssetClassProductType4Code {
        FRGT = 1
    }
    class ISO20022.Auth017001.AssetClassProductType5Code {
        FRTL = 1
    }
    class ISO20022.Auth017001.AssetClassProductType6Code {
        INDP = 1
    }
    class ISO20022.Auth017001.AssetClassProductType7Code {
        METL = 1
    }
    class ISO20022.Auth017001.AssetClassProductType8Code {
        PAPR = 1
    }
    class ISO20022.Auth017001.AssetClassProductType9Code {
        POLY = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType10Code {
        EMIS = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType15Code {
        NPRM = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType16Code {
        PRME = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType18Code {
        PLST = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType1Code {
        GROS = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType20Code {
        DIRY = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType21Code {
        FRST = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType22Code {
        LSTK = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType23Code {
        SEAF = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType24Code {
        COAL = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType25Code {
        DIST = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType26Code {
        INRG = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType27Code {
        LGHT = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType28Code {
        RNNG = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType29Code {
        CRBR = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType2Code {
        SOFT = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType30Code {
        WTHR = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType31Code {
        DRYF = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType32Code {
        WETF = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType33Code {
        CSTR = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType34Code {
        MFTG = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType35Code {
        CBRD = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType36Code {
        NSPT = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType37Code {
        PULP = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType38Code {
        RCVP = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType39Code {
        AMMO = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType3Code {
        OOLI = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType40Code {
        DAPH = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType41Code {
        PTSH = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType42Code {
        SLPH = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType43Code {
        UREA = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType44Code {
        UAAN = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType45Code {
        POTA = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType46Code {
        CSHP = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType47Code {
        DLVR = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType48Code {
        NDLV = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType5Code {
        GRIN = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType6Code {
        ELEC = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType7Code {
        NGAS = 1
    }
    class ISO20022.Auth017001.AssetClassSubProductType8Code {
        OILP = 1
    }
    class ISO20022.Auth017001.AssetClassTransactionType1Code {
        OTHR = 1
        TAPO = 2
        SWAP = 3
        ORIT = 4
        OTCT = 5
        OPTN = 6
        MINI = 7
        FUTR = 8
        DIFF = 9
        CRCK = 10
    }
    class ISO20022.Auth017001.AssetFXSubProductType1Code {
        FXMJ = 1
        FXEM = 2
        FXCR = 3
    }
    class ISO20022.Auth017001.AssetPriceType1Code {
        PLAT = 1
        OTHR = 2
        IHSM = 3
        GBCL = 4
        EXOF = 5
        BLTC = 6
        ARGM = 7
    }
    class ISO20022.Auth017001.BenchmarkCurveName2Code {
        BBSW = 1
        BUBO = 2
        CDOR = 3
        CIBO = 4
        EONA = 5
        EONS = 6
        EURI = 7
        EUUS = 8
        EUCH = 9
        FUSW = 10
        GCFR = 11
        ISDA = 12
        JIBA = 13
        LIBI = 14
        LIBO = 15
        MOSP = 16
        MAAA = 17
        NIBO = 18
        PFAN = 19
        PRBO = 20
        STBO = 21
        SWAP = 22
        TLBO = 23
        TIBO = 24
        TREA = 25
        WIBO = 26
    }
    class ISO20022.Auth017001.BenchmarkCurveName5Choice {
        + Nm  : String
        + Indx  : String
    }
    class ISO20022.Auth017001.BenchmarkCurveName6Choice {
        + Nm  : String
        + Indx  : String
        + ISIN  : String
    }
    class ISO20022.Auth017001.DebtInstrument2 {
        + DebtSnrty  : String
        + IntrstRate  : ISO20022.Auth017001.InterestRate6Choice
        + NmnlValPerUnit  : ISO20022.Auth017001.ActiveOrHistoricCurrencyAndAmount
        + MtrtyDt  : DateTime
        + TtlIssdNmnlAmt  : ISO20022.Auth017001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Auth017001.DebtInstrument2 *-- ISO20022.Auth017001.InterestRate6Choice
    ISO20022.Auth017001.DebtInstrument2 *-- ISO20022.Auth017001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Auth017001.DebtInstrument2 *-- ISO20022.Auth017001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Auth017001.DebtInstrumentSeniorityType1Code {
        JUND = 1
        MZZD = 2
        SNDB = 3
        SBOD = 4
    }
    class ISO20022.Auth017001.DerivativeCommodity2 {
        + FnlPricTp  : String
        + TxTp  : String
        + Pdct  : ISO20022.Auth017001.AssetClassCommodity3Choice
    }
    ISO20022.Auth017001.DerivativeCommodity2 *-- ISO20022.Auth017001.AssetClassCommodity3Choice
    class ISO20022.Auth017001.DerivativeForeignExchange3 {
        + OthrNtnlCcy  : String
        + FxTp  : String
    }
    class ISO20022.Auth017001.DerivativeInstrument5 {
        + AsstClssSpcfcAttrbts  : ISO20022.Auth017001.AssetClass2
        + DlvryTp  : String
        + OptnExrcStyle  : String
        + StrkPric  : ISO20022.Auth017001.SecuritiesTransactionPrice4Choice
        + OptnTp  : String
        + UndrlygInstrm  : ISO20022.Auth017001.FinancialInstrumentIdentification5Choice
        + PricMltplr  : Decimal
        + XpryDt  : DateTime
    }
    ISO20022.Auth017001.DerivativeInstrument5 *-- ISO20022.Auth017001.AssetClass2
    ISO20022.Auth017001.DerivativeInstrument5 *-- ISO20022.Auth017001.SecuritiesTransactionPrice4Choice
    ISO20022.Auth017001.DerivativeInstrument5 *-- ISO20022.Auth017001.FinancialInstrumentIdentification5Choice
    class ISO20022.Auth017001.DerivativeInterest3 {
        + OthrLegIntrstRate  : ISO20022.Auth017001.InterestRate8Choice
        + OthrNtnlCcy  : String
        + FrstLegIntrstRate  : ISO20022.Auth017001.InterestRate8Choice
        + IntrstRate  : ISO20022.Auth017001.FloatingInterestRate8
    }
    ISO20022.Auth017001.DerivativeInterest3 *-- ISO20022.Auth017001.InterestRate8Choice
    ISO20022.Auth017001.DerivativeInterest3 *-- ISO20022.Auth017001.InterestRate8Choice
    ISO20022.Auth017001.DerivativeInterest3 *-- ISO20022.Auth017001.FloatingInterestRate8
    class ISO20022.Auth017001.EnergyCommodityCoal1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.EnergyCommodityDistillates1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.EnergyCommodityElectricity1 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.EnergyCommodityInterEnergy1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.EnergyCommodityLightEnd1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.EnergyCommodityNaturalGas1 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.EnergyCommodityOil1 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.EnergyCommodityRenewableEnergy1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.EnvironmentalCommodityCarbonRelated1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.EnvironmentalCommodityEmission1 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.EnvironmentalCommodityWeather1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.FertilizerCommodityAmmonia1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.FertilizerCommodityDiammoniumPhosphate1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.FertilizerCommodityPotash1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.FertilizerCommoditySulphur1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.FertilizerCommodityUrea1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.FertilizerCommodityUreaAndAmmoniumNitrate1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.FinancialInstrument48Choice {
        + Indx  : ISO20022.Auth017001.FinancialInstrument58
        + LEI  : String
        + ISIN  : String
    }
    ISO20022.Auth017001.FinancialInstrument48Choice *-- ISO20022.Auth017001.FinancialInstrument58
    class ISO20022.Auth017001.FinancialInstrument53 {
        + LEI  : global::System.Collections.Generic.List~String~
        + ISIN  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Auth017001.FinancialInstrument58 {
        + Nm  : ISO20022.Auth017001.FloatingInterestRate8
        + ISIN  : String
    }
    ISO20022.Auth017001.FinancialInstrument58 *-- ISO20022.Auth017001.FloatingInterestRate8
    class ISO20022.Auth017001.FinancialInstrumentIdentification5Choice {
        + Bskt  : ISO20022.Auth017001.FinancialInstrument53
        + Sngl  : ISO20022.Auth017001.FinancialInstrument48Choice
    }
    ISO20022.Auth017001.FinancialInstrumentIdentification5Choice *-- ISO20022.Auth017001.FinancialInstrument53
    ISO20022.Auth017001.FinancialInstrumentIdentification5Choice *-- ISO20022.Auth017001.FinancialInstrument48Choice
    class ISO20022.Auth017001.FinancialInstrumentReportingReferenceDataReportV02 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth017001.SupplementaryData1~
        + RefData  : global::System.Collections.Generic.List~ISO20022.Auth017001.SecuritiesReferenceDataReport6~
        + RptHdr  : ISO20022.Auth017001.SecuritiesMarketReportHeader1
    }
    ISO20022.Auth017001.FinancialInstrumentReportingReferenceDataReportV02 *-- ISO20022.Auth017001.SupplementaryData1
    ISO20022.Auth017001.FinancialInstrumentReportingReferenceDataReportV02 *-- ISO20022.Auth017001.SecuritiesReferenceDataReport6
    ISO20022.Auth017001.FinancialInstrumentReportingReferenceDataReportV02 *-- ISO20022.Auth017001.SecuritiesMarketReportHeader1
    class ISO20022.Auth017001.FloatingInterestRate6 {
        + BsisPtSprd  : Decimal
        + Term  : ISO20022.Auth017001.InterestRateContractTerm2
        + RefRate  : ISO20022.Auth017001.BenchmarkCurveName6Choice
    }
    ISO20022.Auth017001.FloatingInterestRate6 *-- ISO20022.Auth017001.InterestRateContractTerm2
    ISO20022.Auth017001.FloatingInterestRate6 *-- ISO20022.Auth017001.BenchmarkCurveName6Choice
    class ISO20022.Auth017001.FloatingInterestRate8 {
        + Term  : ISO20022.Auth017001.InterestRateContractTerm2
        + RefRate  : ISO20022.Auth017001.BenchmarkCurveName5Choice
    }
    ISO20022.Auth017001.FloatingInterestRate8 *-- ISO20022.Auth017001.InterestRateContractTerm2
    ISO20022.Auth017001.FloatingInterestRate8 *-- ISO20022.Auth017001.BenchmarkCurveName5Choice
    class ISO20022.Auth017001.FreightCommodityContainerShip1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.FreightCommodityDry1 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.FreightCommodityWet1 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.IndustrialProductCommodityConstruction1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.IndustrialProductCommodityManufacturing1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.InterestRate6Choice {
        + Fltg  : ISO20022.Auth017001.FloatingInterestRate6
        + Fxd  : Decimal
    }
    ISO20022.Auth017001.InterestRate6Choice *-- ISO20022.Auth017001.FloatingInterestRate6
    class ISO20022.Auth017001.InterestRate8Choice {
        + Fltg  : ISO20022.Auth017001.FloatingInterestRate8
        + Fxd  : Decimal
    }
    ISO20022.Auth017001.InterestRate8Choice *-- ISO20022.Auth017001.FloatingInterestRate8
    class ISO20022.Auth017001.InterestRateContractTerm2 {
        + Val  : Decimal
        + Unit  : String
    }
    class ISO20022.Auth017001.MetalCommodityNonPrecious1 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.MetalCommodityPrecious1 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.OptionStyle7Code {
        OTHR = 1
        EURO = 2
        BERM = 3
        ASIA = 4
        AMER = 5
    }
    class ISO20022.Auth017001.OptionType2Code {
        OTHR = 1
        PUTO = 2
        CALL = 3
    }
    class ISO20022.Auth017001.OtherC10CommodityDeliverable2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.OtherC10CommodityNonDeliverable2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.PaperCommodityContainerBoard1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.PaperCommodityNewsprint1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.PaperCommodityPulp1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.PaperCommodityRecoveredPaper1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.Period2 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Auth017001.Period4Choice {
        + FrDtToDt  : ISO20022.Auth017001.Period2
        + ToDt  : DateTime
        + FrDt  : DateTime
        + Dt  : DateTime
    }
    ISO20022.Auth017001.Period4Choice *-- ISO20022.Auth017001.Period2
    class ISO20022.Auth017001.PhysicalTransferType4Code {
        CASH = 1
        OPTL = 2
        PHYS = 3
    }
    class ISO20022.Auth017001.PolypropyleneCommodityPlastic1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth017001.PriceStatus1Code {
        NOAP = 1
        PNDG = 2
    }
    class ISO20022.Auth017001.RateBasis1Code {
        YEAR = 1
        WEEK = 2
        MNTH = 3
        DAYS = 4
    }
    class ISO20022.Auth017001.RecordTechnicalData4 {
        + RlvntTradgVn  : String
        + NvrPblshd  : String
        + PblctnPrd  : ISO20022.Auth017001.Period4Choice
        + RlvntCmptntAuthrty  : String
        + SubmissnDtTm  : DateTime
        + LastUpd  : DateTime
        + IncnsstncyInd  : String
    }
    ISO20022.Auth017001.RecordTechnicalData4 *-- ISO20022.Auth017001.Period4Choice
    class ISO20022.Auth017001.SecuritiesMarketReportHeader1 {
        + SubmissnDtTm  : DateTime
        + RptgPrd  : ISO20022.Auth017001.Period4Choice
        + RptgNtty  : ISO20022.Auth017001.TradingVenueIdentification1Choice
    }
    ISO20022.Auth017001.SecuritiesMarketReportHeader1 *-- ISO20022.Auth017001.Period4Choice
    ISO20022.Auth017001.SecuritiesMarketReportHeader1 *-- ISO20022.Auth017001.TradingVenueIdentification1Choice
    class ISO20022.Auth017001.SecuritiesReferenceDataReport6 {
        + TechAttrbts  : ISO20022.Auth017001.RecordTechnicalData4
        + DerivInstrmAttrbts  : ISO20022.Auth017001.DerivativeInstrument5
        + DebtInstrmAttrbts  : ISO20022.Auth017001.DebtInstrument2
        + TradgVnRltdAttrbts  : global::System.Collections.Generic.List~ISO20022.Auth017001.TradingVenueAttributes1~
        + Issr  : String
        + FinInstrmGnlAttrbts  : ISO20022.Auth017001.SecurityInstrumentDescription9
        + TechRcrdId  : String
    }
    ISO20022.Auth017001.SecuritiesReferenceDataReport6 *-- ISO20022.Auth017001.RecordTechnicalData4
    ISO20022.Auth017001.SecuritiesReferenceDataReport6 *-- ISO20022.Auth017001.DerivativeInstrument5
    ISO20022.Auth017001.SecuritiesReferenceDataReport6 *-- ISO20022.Auth017001.DebtInstrument2
    ISO20022.Auth017001.SecuritiesReferenceDataReport6 *-- ISO20022.Auth017001.TradingVenueAttributes1
    ISO20022.Auth017001.SecuritiesReferenceDataReport6 *-- ISO20022.Auth017001.SecurityInstrumentDescription9
    class ISO20022.Auth017001.SecuritiesTransactionPrice1 {
        + Ccy  : String
        + Pdg  : String
    }
    class ISO20022.Auth017001.SecuritiesTransactionPrice2Choice {
        + BsisPts  : Decimal
        + Yld  : Decimal
        + Pctg  : Decimal
        + MntryVal  : ISO20022.Auth017001.AmountAndDirection61
    }
    ISO20022.Auth017001.SecuritiesTransactionPrice2Choice *-- ISO20022.Auth017001.AmountAndDirection61
    class ISO20022.Auth017001.SecuritiesTransactionPrice4Choice {
        + NoPric  : ISO20022.Auth017001.SecuritiesTransactionPrice1
        + Pric  : ISO20022.Auth017001.SecuritiesTransactionPrice2Choice
    }
    ISO20022.Auth017001.SecuritiesTransactionPrice4Choice *-- ISO20022.Auth017001.SecuritiesTransactionPrice1
    ISO20022.Auth017001.SecuritiesTransactionPrice4Choice *-- ISO20022.Auth017001.SecuritiesTransactionPrice2Choice
    class ISO20022.Auth017001.SecurityInstrumentDescription9 {
        + CmmdtyDerivInd  : String
        + NtnlCcy  : String
        + ClssfctnTp  : String
        + ShrtNm  : String
        + FullNm  : String
        + Id  : String
    }
    class ISO20022.Auth017001.SupplementaryData1 {
        + Envlp  : ISO20022.Auth017001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Auth017001.SupplementaryData1 *-- ISO20022.Auth017001.SupplementaryDataEnvelope1
    class ISO20022.Auth017001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Auth017001.TradingVenue2Code {
        CTPS = 1
        APPA = 2
    }
    class ISO20022.Auth017001.TradingVenueAttributes1 {
        + TermntnDt  : DateTime
        + FrstTradDt  : DateTime
        + ReqForAdmssnDt  : DateTime
        + AdmssnApprvlDtByIssr  : DateTime
        + IssrReq  : String
        + Id  : String
    }
    class ISO20022.Auth017001.TradingVenueIdentification1Choice {
        + Othr  : ISO20022.Auth017001.TradingVenueIdentification2
        + NtlCmptntAuthrty  : String
        + MktIdCd  : String
    }
    ISO20022.Auth017001.TradingVenueIdentification1Choice *-- ISO20022.Auth017001.TradingVenueIdentification2
    class ISO20022.Auth017001.TradingVenueIdentification2 {
        + Tp  : String
        + Id  : String
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

## Value ISO20022.Auth017001.ActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth017001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth017001.AgriculturalCommodityDairy1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.AgriculturalCommodityForestry1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.AgriculturalCommodityGrain1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.AgriculturalCommodityLiveStock1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.AgriculturalCommodityOilSeed1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.AgriculturalCommodityOliveOil1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.AgriculturalCommodityPotato1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.AgriculturalCommoditySeafood1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.AgriculturalCommoditySoft1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.AmountAndDirection61


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgn|String||XmlElement()||
|+|Amt|ISO20022.Auth017001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Auth017001.AssetClass2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FX|ISO20022.Auth017001.DerivativeForeignExchange3||XmlElement()||
|+|Intrst|ISO20022.Auth017001.DerivativeInterest3||XmlElement()||
|+|Cmmdty|ISO20022.Auth017001.DerivativeCommodity2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FX),validElement(Intrst),validElement(Cmmdty))|

---

## Value ISO20022.Auth017001.AssetClassCommodity3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth017001.AssetClassCommodityOther1||XmlElement()||
|+|OffclEcnmcSttstcs|ISO20022.Auth017001.AssetClassCommodityOfficialEconomicStatistics1||XmlElement()||
|+|MultiCmmdtyExtc|ISO20022.Auth017001.AssetClassCommodityMultiCommodityExotic1||XmlElement()||
|+|Infltn|ISO20022.Auth017001.AssetClassCommodityInflation1||XmlElement()||
|+|Plprpln|ISO20022.Auth017001.AssetClassCommodityPolypropylene1Choice||XmlElement()||
|+|Ppr|ISO20022.Auth017001.AssetClassCommodityPaper1Choice||XmlElement()||
|+|OthrC10|ISO20022.Auth017001.AssetClassCommodityOtherC102Choice||XmlElement()||
|+|Metl|ISO20022.Auth017001.AssetClassCommodityMetal1Choice||XmlElement()||
|+|IndstrlPdct|ISO20022.Auth017001.AssetClassCommodityIndustrialProduct1Choice||XmlElement()||
|+|Frght|ISO20022.Auth017001.AssetClassCommodityFreight1Choice||XmlElement()||
|+|Frtlzr|ISO20022.Auth017001.AssetClassCommodityFertilizer1Choice||XmlElement()||
|+|Envttl|ISO20022.Auth017001.AssetClassCommodityEnvironmental1Choice||XmlElement()||
|+|Nrgy|ISO20022.Auth017001.AssetClassCommodityEnergy1Choice||XmlElement()||
|+|Agrcltrl|ISO20022.Auth017001.AssetClassCommodityAgricultural1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(OffclEcnmcSttstcs),validElement(MultiCmmdtyExtc),validElement(Infltn),validElement(Plprpln),validElement(Ppr),validElement(OthrC10),validElement(Metl),validElement(IndstrlPdct),validElement(Frght),validElement(Frtlzr),validElement(Envttl),validElement(Nrgy),validElement(Agrcltrl),validChoice(Othr,OffclEcnmcSttstcs,MultiCmmdtyExtc,Infltn,Plprpln,Ppr,OthrC10,Metl,IndstrlPdct,Frght,Frtlzr,Envttl,Nrgy,Agrcltrl))|

---

## Value ISO20022.Auth017001.AssetClassCommodityAgricultural1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Grn|ISO20022.Auth017001.AgriculturalCommodityGrain1||XmlElement()||
|+|LiveStock|ISO20022.Auth017001.AgriculturalCommodityLiveStock1||XmlElement()||
|+|Sfd|ISO20022.Auth017001.AgriculturalCommoditySeafood1||XmlElement()||
|+|Frstry|ISO20022.Auth017001.AgriculturalCommodityForestry1||XmlElement()||
|+|Dairy|ISO20022.Auth017001.AgriculturalCommodityDairy1||XmlElement()||
|+|OlvOil|ISO20022.Auth017001.AgriculturalCommodityOliveOil1||XmlElement()||
|+|Ptt|ISO20022.Auth017001.AgriculturalCommodityPotato1||XmlElement()||
|+|Soft|ISO20022.Auth017001.AgriculturalCommoditySoft1||XmlElement()||
|+|GrnOilSeed|ISO20022.Auth017001.AgriculturalCommodityOilSeed1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Grn),validElement(LiveStock),validElement(Sfd),validElement(Frstry),validElement(Dairy),validElement(OlvOil),validElement(Ptt),validElement(Soft),validElement(GrnOilSeed),validChoice(Grn,LiveStock,Sfd,Frstry,Dairy,OlvOil,Ptt,Soft,GrnOilSeed))|

---

## Value ISO20022.Auth017001.AssetClassCommodityEnergy1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dstllts|ISO20022.Auth017001.EnergyCommodityDistillates1||XmlElement()||
|+|LghtEnd|ISO20022.Auth017001.EnergyCommodityLightEnd1||XmlElement()||
|+|RnwblNrgy|ISO20022.Auth017001.EnergyCommodityRenewableEnergy1||XmlElement()||
|+|IntrNrgy|ISO20022.Auth017001.EnergyCommodityInterEnergy1||XmlElement()||
|+|Coal|ISO20022.Auth017001.EnergyCommodityCoal1||XmlElement()||
|+|Oil|ISO20022.Auth017001.EnergyCommodityOil1||XmlElement()||
|+|NtrlGas|ISO20022.Auth017001.EnergyCommodityNaturalGas1||XmlElement()||
|+|Elctrcty|ISO20022.Auth017001.EnergyCommodityElectricity1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Dstllts),validElement(LghtEnd),validElement(RnwblNrgy),validElement(IntrNrgy),validElement(Coal),validElement(Oil),validElement(NtrlGas),validElement(Elctrcty),validChoice(Dstllts,LghtEnd,RnwblNrgy,IntrNrgy,Coal,Oil,NtrlGas,Elctrcty))|

---

## Value ISO20022.Auth017001.AssetClassCommodityEnvironmental1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CrbnRltd|ISO20022.Auth017001.EnvironmentalCommodityCarbonRelated1||XmlElement()||
|+|Wthr|ISO20022.Auth017001.EnvironmentalCommodityWeather1||XmlElement()||
|+|Emssns|ISO20022.Auth017001.EnvironmentalCommodityEmission1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CrbnRltd),validElement(Wthr),validElement(Emssns),validChoice(CrbnRltd,Wthr,Emssns))|

---

## Value ISO20022.Auth017001.AssetClassCommodityFertilizer1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UreaAndAmmnmNtrt|ISO20022.Auth017001.FertilizerCommodityUreaAndAmmoniumNitrate1||XmlElement()||
|+|Urea|ISO20022.Auth017001.FertilizerCommodityUrea1||XmlElement()||
|+|Slphr|ISO20022.Auth017001.FertilizerCommoditySulphur1||XmlElement()||
|+|Ptsh|ISO20022.Auth017001.FertilizerCommodityPotash1||XmlElement()||
|+|DmmnmPhspht|ISO20022.Auth017001.FertilizerCommodityDiammoniumPhosphate1||XmlElement()||
|+|Ammn|ISO20022.Auth017001.FertilizerCommodityAmmonia1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UreaAndAmmnmNtrt),validElement(Urea),validElement(Slphr),validElement(Ptsh),validElement(DmmnmPhspht),validElement(Ammn),validChoice(UreaAndAmmnmNtrt,Urea,Slphr,Ptsh,DmmnmPhspht,Ammn))|

---

## Value ISO20022.Auth017001.AssetClassCommodityFreight1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CntnrShip|ISO20022.Auth017001.FreightCommodityContainerShip1||XmlElement()||
|+|Wet|ISO20022.Auth017001.FreightCommodityWet1||XmlElement()||
|+|Dry|ISO20022.Auth017001.FreightCommodityDry1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CntnrShip),validElement(Wet),validElement(Dry),validChoice(CntnrShip,Wet,Dry))|

---

## Value ISO20022.Auth017001.AssetClassCommodityIndustrialProduct1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Manfctg|ISO20022.Auth017001.IndustrialProductCommodityManufacturing1||XmlElement()||
|+|Cnstrctn|ISO20022.Auth017001.IndustrialProductCommodityConstruction1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Manfctg),validElement(Cnstrctn),validChoice(Manfctg,Cnstrctn))|

---

## Value ISO20022.Auth017001.AssetClassCommodityInflation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.AssetClassCommodityMetal1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prcs|ISO20022.Auth017001.MetalCommodityPrecious1||XmlElement()||
|+|NonPrcs|ISO20022.Auth017001.MetalCommodityNonPrecious1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prcs),validElement(NonPrcs),validChoice(Prcs,NonPrcs))|

---

## Value ISO20022.Auth017001.AssetClassCommodityMultiCommodityExotic1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.AssetClassCommodityOfficialEconomicStatistics1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.AssetClassCommodityOther1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.AssetClassCommodityOtherC102Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NonDlvrbl|ISO20022.Auth017001.OtherC10CommodityNonDeliverable2||XmlElement()||
|+|Dlvrbl|ISO20022.Auth017001.OtherC10CommodityDeliverable2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NonDlvrbl),validElement(Dlvrbl),validChoice(NonDlvrbl,Dlvrbl))|

---

## Value ISO20022.Auth017001.AssetClassCommodityPaper1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RcvrdPpr|ISO20022.Auth017001.PaperCommodityRecoveredPaper1||XmlElement()||
|+|Pulp|ISO20022.Auth017001.PaperCommodityPulp1||XmlElement()||
|+|Nwsprnt|ISO20022.Auth017001.PaperCommodityNewsprint1||XmlElement()||
|+|CntnrBrd|ISO20022.Auth017001.PaperCommodityContainerBoard1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RcvrdPpr),validElement(Pulp),validElement(Nwsprnt),validElement(CntnrBrd),validChoice(RcvrdPpr,Pulp,Nwsprnt,CntnrBrd))|

---

## Value ISO20022.Auth017001.AssetClassCommodityPolypropylene1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Plstc|ISO20022.Auth017001.PolypropyleneCommodityPlastic1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Plstc),validChoice(Plstc))|

---

## Enum ISO20022.Auth017001.AssetClassDetailedSubProductType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LEAD|Int32||XmlEnum("""LEAD""")|1|
||OTHR|Int32||XmlEnum("""OTHR""")|2|
||ZINC|Int32||XmlEnum("""ZINC""")|3|
||TINN|Int32||XmlEnum("""TINN""")|4|
||STEL|Int32||XmlEnum("""STEL""")|5|
||NICK|Int32||XmlEnum("""NICK""")|6|
||NASC|Int32||XmlEnum("""NASC""")|7|
||MOLY|Int32||XmlEnum("""MOLY""")|8|
||IRON|Int32||XmlEnum("""IRON""")|9|
||COPR|Int32||XmlEnum("""COPR""")|10|
||CBLT|Int32||XmlEnum("""CBLT""")|11|
||ALUA|Int32||XmlEnum("""ALUA""")|12|
||ALUM|Int32||XmlEnum("""ALUM""")|13|

---

## Enum ISO20022.Auth017001.AssetClassDetailedSubProductType11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SLVR|Int32||XmlEnum("""SLVR""")|1|
||PTNM|Int32||XmlEnum("""PTNM""")|2|
||PLDM|Int32||XmlEnum("""PLDM""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||GOLD|Int32||XmlEnum("""GOLD""")|5|

---

## Enum ISO20022.Auth017001.AssetClassDetailedSubProductType12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TNKR|Int32||XmlEnum("""TNKR""")|1|

---

## Enum ISO20022.Auth017001.AssetClassDetailedSubProductType14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBCR|Int32||XmlEnum("""DBCR""")|1|

---

## Enum ISO20022.Auth017001.AssetClassDetailedSubProductType15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MWHT|Int32||XmlEnum("""MWHT""")|1|

---

## Enum ISO20022.Auth017001.AssetClassDetailedSubProductType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RICE|Int32||XmlEnum("""RICE""")|1|
||CORN|Int32||XmlEnum("""CORN""")|2|
||OTHR|Int32||XmlEnum("""OTHR""")|3|
||RPSD|Int32||XmlEnum("""RPSD""")|4|
||SOYB|Int32||XmlEnum("""SOYB""")|5|
||FWHT|Int32||XmlEnum("""FWHT""")|6|

---

## Enum ISO20022.Auth017001.AssetClassDetailedSubProductType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||WHSG|Int32||XmlEnum("""WHSG""")|2|
||BRWN|Int32||XmlEnum("""BRWN""")|3|
||CCOA|Int32||XmlEnum("""CCOA""")|4|
||ROBU|Int32||XmlEnum("""ROBU""")|5|

---

## Enum ISO20022.Auth017001.AssetClassDetailedSubProductType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LAMP|Int32||XmlEnum("""LAMP""")|1|

---

## Enum ISO20022.Auth017001.AssetClassDetailedSubProductType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||OFFP|Int32||XmlEnum("""OFFP""")|2|
||PKLD|Int32||XmlEnum("""PKLD""")|3|
||FITR|Int32||XmlEnum("""FITR""")|4|
||BSLD|Int32||XmlEnum("""BSLD""")|5|

---

## Enum ISO20022.Auth017001.AssetClassDetailedSubProductType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NBPG|Int32||XmlEnum("""NBPG""")|1|
||TTFG|Int32||XmlEnum("""TTFG""")|2|
||NCGG|Int32||XmlEnum("""NCGG""")|3|
||LNGG|Int32||XmlEnum("""LNGG""")|4|
||GASP|Int32||XmlEnum("""GASP""")|5|

---

## Enum ISO20022.Auth017001.AssetClassDetailedSubProductType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||URAL|Int32||XmlEnum("""URAL""")|1|
||WTIO|Int32||XmlEnum("""WTIO""")|2|
||TAPI|Int32||XmlEnum("""TAPI""")|3|
||NGLO|Int32||XmlEnum("""NGLO""")|4|
||NAPH|Int32||XmlEnum("""NAPH""")|5|
||MARS|Int32||XmlEnum("""MARS""")|6|
||LLSO|Int32||XmlEnum("""LLSO""")|7|
||KERO|Int32||XmlEnum("""KERO""")|8|
||JTFL|Int32||XmlEnum("""JTFL""")|9|
||HEAT|Int32||XmlEnum("""HEAT""")|10|
||GSLN|Int32||XmlEnum("""GSLN""")|11|
||GOIL|Int32||XmlEnum("""GOIL""")|12|
||FOIL|Int32||XmlEnum("""FOIL""")|13|
||FUEL|Int32||XmlEnum("""FUEL""")|14|
||ETHA|Int32||XmlEnum("""ETHA""")|15|
||ESPO|Int32||XmlEnum("""ESPO""")|16|
||DUBA|Int32||XmlEnum("""DUBA""")|17|
||DSEL|Int32||XmlEnum("""DSEL""")|18|
||COND|Int32||XmlEnum("""COND""")|19|
||CNDA|Int32||XmlEnum("""CNDA""")|20|
||BRNX|Int32||XmlEnum("""BRNX""")|21|
||BRNT|Int32||XmlEnum("""BRNT""")|22|
||BDSL|Int32||XmlEnum("""BDSL""")|23|
||BAKK|Int32||XmlEnum("""BAKK""")|24|

---

## Enum ISO20022.Auth017001.AssetClassDetailedSubProductType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||EUAA|Int32||XmlEnum("""EUAA""")|2|
||EUAE|Int32||XmlEnum("""EUAE""")|3|
||ERUE|Int32||XmlEnum("""ERUE""")|4|
||CERE|Int32||XmlEnum("""CERE""")|5|

---

## Enum ISO20022.Auth017001.AssetClassProductType11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHC|Int32||XmlEnum("""OTHC""")|1|

---

## Enum ISO20022.Auth017001.AssetClassProductType12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFL|Int32||XmlEnum("""INFL""")|1|

---

## Enum ISO20022.Auth017001.AssetClassProductType13Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MCEX|Int32||XmlEnum("""MCEX""")|1|

---

## Enum ISO20022.Auth017001.AssetClassProductType14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OEST|Int32||XmlEnum("""OEST""")|1|

---

## Enum ISO20022.Auth017001.AssetClassProductType15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|

---

## Enum ISO20022.Auth017001.AssetClassProductType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGRI|Int32||XmlEnum("""AGRI""")|1|

---

## Enum ISO20022.Auth017001.AssetClassProductType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NRGY|Int32||XmlEnum("""NRGY""")|1|

---

## Enum ISO20022.Auth017001.AssetClassProductType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ENVR|Int32||XmlEnum("""ENVR""")|1|

---

## Enum ISO20022.Auth017001.AssetClassProductType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRGT|Int32||XmlEnum("""FRGT""")|1|

---

## Enum ISO20022.Auth017001.AssetClassProductType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRTL|Int32||XmlEnum("""FRTL""")|1|

---

## Enum ISO20022.Auth017001.AssetClassProductType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDP|Int32||XmlEnum("""INDP""")|1|

---

## Enum ISO20022.Auth017001.AssetClassProductType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||METL|Int32||XmlEnum("""METL""")|1|

---

## Enum ISO20022.Auth017001.AssetClassProductType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PAPR|Int32||XmlEnum("""PAPR""")|1|

---

## Enum ISO20022.Auth017001.AssetClassProductType9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||POLY|Int32||XmlEnum("""POLY""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EMIS|Int32||XmlEnum("""EMIS""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NPRM|Int32||XmlEnum("""NPRM""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType16Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRME|Int32||XmlEnum("""PRME""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType18Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PLST|Int32||XmlEnum("""PLST""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GROS|Int32||XmlEnum("""GROS""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType20Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DIRY|Int32||XmlEnum("""DIRY""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType21Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRST|Int32||XmlEnum("""FRST""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType22Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LSTK|Int32||XmlEnum("""LSTK""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType23Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SEAF|Int32||XmlEnum("""SEAF""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType24Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||COAL|Int32||XmlEnum("""COAL""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType25Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DIST|Int32||XmlEnum("""DIST""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType26Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INRG|Int32||XmlEnum("""INRG""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType27Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LGHT|Int32||XmlEnum("""LGHT""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType28Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RNNG|Int32||XmlEnum("""RNNG""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType29Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CRBR|Int32||XmlEnum("""CRBR""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SOFT|Int32||XmlEnum("""SOFT""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType30Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WTHR|Int32||XmlEnum("""WTHR""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType31Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DRYF|Int32||XmlEnum("""DRYF""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType32Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WETF|Int32||XmlEnum("""WETF""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType33Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CSTR|Int32||XmlEnum("""CSTR""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType34Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MFTG|Int32||XmlEnum("""MFTG""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType35Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CBRD|Int32||XmlEnum("""CBRD""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType36Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NSPT|Int32||XmlEnum("""NSPT""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType37Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PULP|Int32||XmlEnum("""PULP""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType38Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RCVP|Int32||XmlEnum("""RCVP""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType39Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AMMO|Int32||XmlEnum("""AMMO""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OOLI|Int32||XmlEnum("""OOLI""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType40Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DAPH|Int32||XmlEnum("""DAPH""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType41Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PTSH|Int32||XmlEnum("""PTSH""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType42Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SLPH|Int32||XmlEnum("""SLPH""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType43Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UREA|Int32||XmlEnum("""UREA""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType44Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UAAN|Int32||XmlEnum("""UAAN""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType45Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||POTA|Int32||XmlEnum("""POTA""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType46Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CSHP|Int32||XmlEnum("""CSHP""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType47Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVR|Int32||XmlEnum("""DLVR""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType48Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NDLV|Int32||XmlEnum("""NDLV""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GRIN|Int32||XmlEnum("""GRIN""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ELEC|Int32||XmlEnum("""ELEC""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NGAS|Int32||XmlEnum("""NGAS""")|1|

---

## Enum ISO20022.Auth017001.AssetClassSubProductType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OILP|Int32||XmlEnum("""OILP""")|1|

---

## Enum ISO20022.Auth017001.AssetClassTransactionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||TAPO|Int32||XmlEnum("""TAPO""")|2|
||SWAP|Int32||XmlEnum("""SWAP""")|3|
||ORIT|Int32||XmlEnum("""ORIT""")|4|
||OTCT|Int32||XmlEnum("""OTCT""")|5|
||OPTN|Int32||XmlEnum("""OPTN""")|6|
||MINI|Int32||XmlEnum("""MINI""")|7|
||FUTR|Int32||XmlEnum("""FUTR""")|8|
||DIFF|Int32||XmlEnum("""DIFF""")|9|
||CRCK|Int32||XmlEnum("""CRCK""")|10|

---

## Enum ISO20022.Auth017001.AssetFXSubProductType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FXMJ|Int32||XmlEnum("""FXMJ""")|1|
||FXEM|Int32||XmlEnum("""FXEM""")|2|
||FXCR|Int32||XmlEnum("""FXCR""")|3|

---

## Enum ISO20022.Auth017001.AssetPriceType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PLAT|Int32||XmlEnum("""PLAT""")|1|
||OTHR|Int32||XmlEnum("""OTHR""")|2|
||IHSM|Int32||XmlEnum("""IHSM""")|3|
||GBCL|Int32||XmlEnum("""GBCL""")|4|
||EXOF|Int32||XmlEnum("""EXOF""")|5|
||BLTC|Int32||XmlEnum("""BLTC""")|6|
||ARGM|Int32||XmlEnum("""ARGM""")|7|

---

## Enum ISO20022.Auth017001.BenchmarkCurveName2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BBSW|Int32||XmlEnum("""BBSW""")|1|
||BUBO|Int32||XmlEnum("""BUBO""")|2|
||CDOR|Int32||XmlEnum("""CDOR""")|3|
||CIBO|Int32||XmlEnum("""CIBO""")|4|
||EONA|Int32||XmlEnum("""EONA""")|5|
||EONS|Int32||XmlEnum("""EONS""")|6|
||EURI|Int32||XmlEnum("""EURI""")|7|
||EUUS|Int32||XmlEnum("""EUUS""")|8|
||EUCH|Int32||XmlEnum("""EUCH""")|9|
||FUSW|Int32||XmlEnum("""FUSW""")|10|
||GCFR|Int32||XmlEnum("""GCFR""")|11|
||ISDA|Int32||XmlEnum("""ISDA""")|12|
||JIBA|Int32||XmlEnum("""JIBA""")|13|
||LIBI|Int32||XmlEnum("""LIBI""")|14|
||LIBO|Int32||XmlEnum("""LIBO""")|15|
||MOSP|Int32||XmlEnum("""MOSP""")|16|
||MAAA|Int32||XmlEnum("""MAAA""")|17|
||NIBO|Int32||XmlEnum("""NIBO""")|18|
||PFAN|Int32||XmlEnum("""PFAN""")|19|
||PRBO|Int32||XmlEnum("""PRBO""")|20|
||STBO|Int32||XmlEnum("""STBO""")|21|
||SWAP|Int32||XmlEnum("""SWAP""")|22|
||TLBO|Int32||XmlEnum("""TLBO""")|23|
||TIBO|Int32||XmlEnum("""TIBO""")|24|
||TREA|Int32||XmlEnum("""TREA""")|25|
||WIBO|Int32||XmlEnum("""WIBO""")|26|

---

## Value ISO20022.Auth017001.BenchmarkCurveName5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Indx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Nm,Indx))|

---

## Value ISO20022.Auth017001.BenchmarkCurveName6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Indx|String||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validChoice(Nm,Indx,ISIN))|

---

## Value ISO20022.Auth017001.DebtInstrument2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DebtSnrty|String||XmlElement()||
|+|IntrstRate|ISO20022.Auth017001.InterestRate6Choice||XmlElement()||
|+|NmnlValPerUnit|ISO20022.Auth017001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|TtlIssdNmnlAmt|ISO20022.Auth017001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IntrstRate),validElement(NmnlValPerUnit),validElement(TtlIssdNmnlAmt))|

---

## Enum ISO20022.Auth017001.DebtInstrumentSeniorityType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||JUND|Int32||XmlEnum("""JUND""")|1|
||MZZD|Int32||XmlEnum("""MZZD""")|2|
||SNDB|Int32||XmlEnum("""SNDB""")|3|
||SBOD|Int32||XmlEnum("""SBOD""")|4|

---

## Value ISO20022.Auth017001.DerivativeCommodity2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FnlPricTp|String||XmlElement()||
|+|TxTp|String||XmlElement()||
|+|Pdct|ISO20022.Auth017001.AssetClassCommodity3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pdct))|

---

## Value ISO20022.Auth017001.DerivativeForeignExchange3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrNtnlCcy|String||XmlElement()||
|+|FxTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""OthrNtnlCcy""",OthrNtnlCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth017001.DerivativeInstrument5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AsstClssSpcfcAttrbts|ISO20022.Auth017001.AssetClass2||XmlElement()||
|+|DlvryTp|String||XmlElement()||
|+|OptnExrcStyle|String||XmlElement()||
|+|StrkPric|ISO20022.Auth017001.SecuritiesTransactionPrice4Choice||XmlElement()||
|+|OptnTp|String||XmlElement()||
|+|UndrlygInstrm|ISO20022.Auth017001.FinancialInstrumentIdentification5Choice||XmlElement()||
|+|PricMltplr|Decimal||XmlElement()||
|+|XpryDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AsstClssSpcfcAttrbts),validElement(StrkPric),validElement(UndrlygInstrm))|

---

## Value ISO20022.Auth017001.DerivativeInterest3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrLegIntrstRate|ISO20022.Auth017001.InterestRate8Choice||XmlElement()||
|+|OthrNtnlCcy|String||XmlElement()||
|+|FrstLegIntrstRate|ISO20022.Auth017001.InterestRate8Choice||XmlElement()||
|+|IntrstRate|ISO20022.Auth017001.FloatingInterestRate8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrLegIntrstRate),validPattern("""OthrNtnlCcy""",OthrNtnlCcy,"""[A-Z]{3,3}"""),validElement(FrstLegIntrstRate),validElement(IntrstRate))|

---

## Type ISO20022.Auth017001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmRptgRefDataRpt|ISO20022.Auth017001.FinancialInstrumentReportingReferenceDataReportV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FinInstrmRptgRefDataRpt))|

---

## Value ISO20022.Auth017001.EnergyCommodityCoal1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.EnergyCommodityDistillates1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.EnergyCommodityElectricity1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.EnergyCommodityInterEnergy1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.EnergyCommodityLightEnd1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.EnergyCommodityNaturalGas1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.EnergyCommodityOil1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.EnergyCommodityRenewableEnergy1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.EnvironmentalCommodityCarbonRelated1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.EnvironmentalCommodityEmission1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.EnvironmentalCommodityWeather1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.FertilizerCommodityAmmonia1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.FertilizerCommodityDiammoniumPhosphate1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.FertilizerCommodityPotash1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.FertilizerCommoditySulphur1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.FertilizerCommodityUrea1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.FertilizerCommodityUreaAndAmmoniumNitrate1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.FinancialInstrument48Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Indx|ISO20022.Auth017001.FinancialInstrument58||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Indx),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validChoice(Indx,LEI,ISIN))|

---

## Value ISO20022.Auth017001.FinancialInstrument53


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|global::System.Collections.Generic.List<String>||XmlElement()||
|+|ISIN|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Auth017001.FinancialInstrument58


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|ISO20022.Auth017001.FloatingInterestRate8||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Nm),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Auth017001.FinancialInstrumentIdentification5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bskt|ISO20022.Auth017001.FinancialInstrument53||XmlElement()||
|+|Sngl|ISO20022.Auth017001.FinancialInstrument48Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Bskt),validElement(Sngl),validChoice(Bskt,Sngl))|

---

## Aspect ISO20022.Auth017001.FinancialInstrumentReportingReferenceDataReportV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth017001.SupplementaryData1>||XmlElement()||
|+|RefData|global::System.Collections.Generic.List<ISO20022.Auth017001.SecuritiesReferenceDataReport6>||XmlElement()||
|+|RptHdr|ISO20022.Auth017001.SecuritiesMarketReportHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""RefData""",RefData),validList("""RefData""",RefData),validElement(RefData),validElement(RptHdr))|

---

## Value ISO20022.Auth017001.FloatingInterestRate6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BsisPtSprd|Decimal||XmlElement()||
|+|Term|ISO20022.Auth017001.InterestRateContractTerm2||XmlElement()||
|+|RefRate|ISO20022.Auth017001.BenchmarkCurveName6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Term),validElement(RefRate))|

---

## Value ISO20022.Auth017001.FloatingInterestRate8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Term|ISO20022.Auth017001.InterestRateContractTerm2||XmlElement()||
|+|RefRate|ISO20022.Auth017001.BenchmarkCurveName5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Term),validElement(RefRate))|

---

## Value ISO20022.Auth017001.FreightCommodityContainerShip1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.FreightCommodityDry1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.FreightCommodityWet1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.IndustrialProductCommodityConstruction1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.IndustrialProductCommodityManufacturing1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.InterestRate6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Fltg|ISO20022.Auth017001.FloatingInterestRate6||XmlElement()||
|+|Fxd|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Fltg),validChoice(Fltg,Fxd))|

---

## Value ISO20022.Auth017001.InterestRate8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Fltg|ISO20022.Auth017001.FloatingInterestRate8||XmlElement()||
|+|Fxd|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Fltg),validChoice(Fltg,Fxd))|

---

## Value ISO20022.Auth017001.InterestRateContractTerm2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|Decimal||XmlElement()||
|+|Unit|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.MetalCommodityNonPrecious1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.MetalCommodityPrecious1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth017001.OptionStyle7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||EURO|Int32||XmlEnum("""EURO""")|2|
||BERM|Int32||XmlEnum("""BERM""")|3|
||ASIA|Int32||XmlEnum("""ASIA""")|4|
||AMER|Int32||XmlEnum("""AMER""")|5|

---

## Enum ISO20022.Auth017001.OptionType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||PUTO|Int32||XmlEnum("""PUTO""")|2|
||CALL|Int32||XmlEnum("""CALL""")|3|

---

## Value ISO20022.Auth017001.OtherC10CommodityDeliverable2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.OtherC10CommodityNonDeliverable2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.PaperCommodityContainerBoard1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.PaperCommodityNewsprint1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.PaperCommodityPulp1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.PaperCommodityRecoveredPaper1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.Period2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth017001.Period4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrDtToDt|ISO20022.Auth017001.Period2||XmlElement()||
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrDtToDt),validChoice(FrDtToDt,ToDt,FrDt,Dt))|

---

## Enum ISO20022.Auth017001.PhysicalTransferType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CASH|Int32||XmlEnum("""CASH""")|1|
||OPTL|Int32||XmlEnum("""OPTL""")|2|
||PHYS|Int32||XmlEnum("""PHYS""")|3|

---

## Value ISO20022.Auth017001.PolypropyleneCommodityPlastic1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth017001.PriceStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOAP|Int32||XmlEnum("""NOAP""")|1|
||PNDG|Int32||XmlEnum("""PNDG""")|2|

---

## Enum ISO20022.Auth017001.RateBasis1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YEAR|Int32||XmlEnum("""YEAR""")|1|
||WEEK|Int32||XmlEnum("""WEEK""")|2|
||MNTH|Int32||XmlEnum("""MNTH""")|3|
||DAYS|Int32||XmlEnum("""DAYS""")|4|

---

## Value ISO20022.Auth017001.RecordTechnicalData4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RlvntTradgVn|String||XmlElement()||
|+|NvrPblshd|String||XmlElement()||
|+|PblctnPrd|ISO20022.Auth017001.Period4Choice||XmlElement()||
|+|RlvntCmptntAuthrty|String||XmlElement()||
|+|SubmissnDtTm|DateTime||XmlElement()||
|+|LastUpd|DateTime||XmlElement()||
|+|IncnsstncyInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""RlvntTradgVn""",RlvntTradgVn,"""[A-Z0-9]{4,4}"""),validElement(PblctnPrd),validPattern("""RlvntCmptntAuthrty""",RlvntCmptntAuthrty,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Auth017001.SecuritiesMarketReportHeader1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubmissnDtTm|DateTime||XmlElement()||
|+|RptgPrd|ISO20022.Auth017001.Period4Choice||XmlElement()||
|+|RptgNtty|ISO20022.Auth017001.TradingVenueIdentification1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RptgPrd),validElement(RptgNtty))|

---

## Value ISO20022.Auth017001.SecuritiesReferenceDataReport6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TechAttrbts|ISO20022.Auth017001.RecordTechnicalData4||XmlElement()||
|+|DerivInstrmAttrbts|ISO20022.Auth017001.DerivativeInstrument5||XmlElement()||
|+|DebtInstrmAttrbts|ISO20022.Auth017001.DebtInstrument2||XmlElement()||
|+|TradgVnRltdAttrbts|global::System.Collections.Generic.List<ISO20022.Auth017001.TradingVenueAttributes1>||XmlElement()||
|+|Issr|String||XmlElement()||
|+|FinInstrmGnlAttrbts|ISO20022.Auth017001.SecurityInstrumentDescription9||XmlElement()||
|+|TechRcrdId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TechAttrbts),validElement(DerivInstrmAttrbts),validElement(DebtInstrmAttrbts),validRequired("""TradgVnRltdAttrbts""",TradgVnRltdAttrbts),validList("""TradgVnRltdAttrbts""",TradgVnRltdAttrbts),validElement(TradgVnRltdAttrbts),validPattern("""Issr""",Issr,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(FinInstrmGnlAttrbts))|

---

## Value ISO20022.Auth017001.SecuritiesTransactionPrice1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ccy|String||XmlElement()||
|+|Pdg|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth017001.SecuritiesTransactionPrice2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BsisPts|Decimal||XmlElement()||
|+|Yld|Decimal||XmlElement()||
|+|Pctg|Decimal||XmlElement()||
|+|MntryVal|ISO20022.Auth017001.AmountAndDirection61||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MntryVal),validChoice(BsisPts,Yld,Pctg,MntryVal))|

---

## Value ISO20022.Auth017001.SecuritiesTransactionPrice4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoPric|ISO20022.Auth017001.SecuritiesTransactionPrice1||XmlElement()||
|+|Pric|ISO20022.Auth017001.SecuritiesTransactionPrice2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NoPric),validElement(Pric),validChoice(NoPric,Pric))|

---

## Value ISO20022.Auth017001.SecurityInstrumentDescription9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CmmdtyDerivInd|String||XmlElement()||
|+|NtnlCcy|String||XmlElement()||
|+|ClssfctnTp|String||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|FullNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""NtnlCcy""",NtnlCcy,"""[A-Z]{3,3}"""),validPattern("""ClssfctnTp""",ClssfctnTp,"""[A-Z]{6,6}"""),validPattern("""Id""",Id,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Auth017001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Auth017001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Auth017001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth017001.TradingVenue2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CTPS|Int32||XmlEnum("""CTPS""")|1|
||APPA|Int32||XmlEnum("""APPA""")|2|

---

## Value ISO20022.Auth017001.TradingVenueAttributes1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TermntnDt|DateTime||XmlElement()||
|+|FrstTradDt|DateTime||XmlElement()||
|+|ReqForAdmssnDt|DateTime||XmlElement()||
|+|AdmssnApprvlDtByIssr|DateTime||XmlElement()||
|+|IssrReq|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}"""))|

---

## Value ISO20022.Auth017001.TradingVenueIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth017001.TradingVenueIdentification2||XmlElement()||
|+|NtlCmptntAuthrty|String||XmlElement()||
|+|MktIdCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""NtlCmptntAuthrty""",NtlCmptntAuthrty,"""[A-Z]{2,2}"""),validPattern("""MktIdCd""",MktIdCd,"""[A-Z0-9]{4,4}"""),validChoice(Othr,NtlCmptntAuthrty,MktIdCd))|

---

## Value ISO20022.Auth017001.TradingVenueIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
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

