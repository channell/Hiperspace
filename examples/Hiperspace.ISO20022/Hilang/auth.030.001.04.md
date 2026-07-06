# auth.030.001.04
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Auth030001.ActiveOrHistoricCurrencyAnd19DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Auth030001.AgreementType2Choice {
        + Prtry  : String
        + Tp  : String
    }
    class ISO20022.Auth030001.AgriculturalCommodityDairy2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.AgriculturalCommodityForestry2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.AgriculturalCommodityGrain3 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.AgriculturalCommodityLiveStock2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.AgriculturalCommodityOilSeed2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.AgriculturalCommodityOliveOil3 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.AgriculturalCommodityOther2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.AgriculturalCommodityPotato2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.AgriculturalCommoditySeafood2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.AgriculturalCommoditySoft2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.AllocationIndicator1Code {
        UNAL = 1
        PREA = 2
        POST = 3
    }
    class ISO20022.Auth030001.AmountAndDirection106 {
        + Sgn  : String
        + Amt  : ISO20022.Auth030001.ActiveOrHistoricCurrencyAnd19DecimalAmount
    }
    ISO20022.Auth030001.AmountAndDirection106 *-- ISO20022.Auth030001.ActiveOrHistoricCurrencyAnd19DecimalAmount
    class ISO20022.Auth030001.AmountAndDirection109 {
        + Sgn  : String
        + Amt  : ISO20022.Auth030001.ActiveOrHistoricCurrencyAnd19DecimalAmount
    }
    ISO20022.Auth030001.AmountAndDirection109 *-- ISO20022.Auth030001.ActiveOrHistoricCurrencyAnd19DecimalAmount
    class ISO20022.Auth030001.AssetClassCommodity7Choice {
        + Plprpln  : ISO20022.Auth030001.AssetClassCommodityPolypropylene4Choice
        + Ppr  : ISO20022.Auth030001.AssetClassCommodityPaper5Choice
        + OthrC10  : ISO20022.Auth030001.AssetClassCommodityC10Other1
        + Othr  : ISO20022.Auth030001.AssetClassCommodityOther1
        + OffclEcnmcSttstcs  : ISO20022.Auth030001.AssetClassCommodityOfficialEconomicStatistics1
        + MultiCmmdtyExtc  : ISO20022.Auth030001.AssetClassCommodityMultiCommodityExotic1
        + Metl  : ISO20022.Auth030001.AssetClassCommodityMetal2Choice
        + Infltn  : ISO20022.Auth030001.AssetClassCommodityInflation1
        + IndstrlPdct  : ISO20022.Auth030001.AssetClassCommodityIndustrialProduct2Choice
        + Indx  : ISO20022.Auth030001.AssetClassCommodityIndex1
        + Frght  : ISO20022.Auth030001.AssetClassCommodityFreight4Choice
        + Frtlzr  : ISO20022.Auth030001.AssetClassCommodityFertilizer4Choice
        + Envttl  : ISO20022.Auth030001.AssetClassCommodityEnvironmental3Choice
        + Nrgy  : ISO20022.Auth030001.AssetClassCommodityEnergy3Choice
        + Agrcltrl  : ISO20022.Auth030001.AssetClassCommodityAgricultural6Choice
    }
    ISO20022.Auth030001.AssetClassCommodity7Choice *-- ISO20022.Auth030001.AssetClassCommodityPolypropylene4Choice
    ISO20022.Auth030001.AssetClassCommodity7Choice *-- ISO20022.Auth030001.AssetClassCommodityPaper5Choice
    ISO20022.Auth030001.AssetClassCommodity7Choice *-- ISO20022.Auth030001.AssetClassCommodityC10Other1
    ISO20022.Auth030001.AssetClassCommodity7Choice *-- ISO20022.Auth030001.AssetClassCommodityOther1
    ISO20022.Auth030001.AssetClassCommodity7Choice *-- ISO20022.Auth030001.AssetClassCommodityOfficialEconomicStatistics1
    ISO20022.Auth030001.AssetClassCommodity7Choice *-- ISO20022.Auth030001.AssetClassCommodityMultiCommodityExotic1
    ISO20022.Auth030001.AssetClassCommodity7Choice *-- ISO20022.Auth030001.AssetClassCommodityMetal2Choice
    ISO20022.Auth030001.AssetClassCommodity7Choice *-- ISO20022.Auth030001.AssetClassCommodityInflation1
    ISO20022.Auth030001.AssetClassCommodity7Choice *-- ISO20022.Auth030001.AssetClassCommodityIndustrialProduct2Choice
    ISO20022.Auth030001.AssetClassCommodity7Choice *-- ISO20022.Auth030001.AssetClassCommodityIndex1
    ISO20022.Auth030001.AssetClassCommodity7Choice *-- ISO20022.Auth030001.AssetClassCommodityFreight4Choice
    ISO20022.Auth030001.AssetClassCommodity7Choice *-- ISO20022.Auth030001.AssetClassCommodityFertilizer4Choice
    ISO20022.Auth030001.AssetClassCommodity7Choice *-- ISO20022.Auth030001.AssetClassCommodityEnvironmental3Choice
    ISO20022.Auth030001.AssetClassCommodity7Choice *-- ISO20022.Auth030001.AssetClassCommodityEnergy3Choice
    ISO20022.Auth030001.AssetClassCommodity7Choice *-- ISO20022.Auth030001.AssetClassCommodityAgricultural6Choice
    class ISO20022.Auth030001.AssetClassCommodityAgricultural6Choice {
        + Othr  : ISO20022.Auth030001.AgriculturalCommodityOther2
        + Grn  : ISO20022.Auth030001.AgriculturalCommodityGrain3
        + LiveStock  : ISO20022.Auth030001.AgriculturalCommodityLiveStock2
        + Sfd  : ISO20022.Auth030001.AgriculturalCommoditySeafood2
        + Frstry  : ISO20022.Auth030001.AgriculturalCommodityForestry2
        + Dairy  : ISO20022.Auth030001.AgriculturalCommodityDairy2
        + OlvOil  : ISO20022.Auth030001.AgriculturalCommodityOliveOil3
        + Ptt  : ISO20022.Auth030001.AgriculturalCommodityPotato2
        + Soft  : ISO20022.Auth030001.AgriculturalCommoditySoft2
        + GrnOilSeed  : ISO20022.Auth030001.AgriculturalCommodityOilSeed2
    }
    ISO20022.Auth030001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth030001.AgriculturalCommodityOther2
    ISO20022.Auth030001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth030001.AgriculturalCommodityGrain3
    ISO20022.Auth030001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth030001.AgriculturalCommodityLiveStock2
    ISO20022.Auth030001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth030001.AgriculturalCommoditySeafood2
    ISO20022.Auth030001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth030001.AgriculturalCommodityForestry2
    ISO20022.Auth030001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth030001.AgriculturalCommodityDairy2
    ISO20022.Auth030001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth030001.AgriculturalCommodityOliveOil3
    ISO20022.Auth030001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth030001.AgriculturalCommodityPotato2
    ISO20022.Auth030001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth030001.AgriculturalCommoditySoft2
    ISO20022.Auth030001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth030001.AgriculturalCommodityOilSeed2
    class ISO20022.Auth030001.AssetClassCommodityC10Other1 {
        + BasePdct  : String
    }
    class ISO20022.Auth030001.AssetClassCommodityEnergy3Choice {
        + Othr  : ISO20022.Auth030001.EnergyCommodityOther2
        + Dstllts  : ISO20022.Auth030001.EnergyCommodityDistillates2
        + LghtEnd  : ISO20022.Auth030001.EnergyCommodityLightEnd2
        + RnwblNrgy  : ISO20022.Auth030001.EnergyCommodityRenewableEnergy2
        + IntrNrgy  : ISO20022.Auth030001.EnergyCommodityInterEnergy2
        + Coal  : ISO20022.Auth030001.EnergyCommodityCoal2
        + Oil  : ISO20022.Auth030001.EnergyCommodityOil3
        + NtrlGas  : ISO20022.Auth030001.EnergyCommodityNaturalGas3
        + Elctrcty  : ISO20022.Auth030001.EnergyCommodityElectricity2
    }
    ISO20022.Auth030001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth030001.EnergyCommodityOther2
    ISO20022.Auth030001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth030001.EnergyCommodityDistillates2
    ISO20022.Auth030001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth030001.EnergyCommodityLightEnd2
    ISO20022.Auth030001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth030001.EnergyCommodityRenewableEnergy2
    ISO20022.Auth030001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth030001.EnergyCommodityInterEnergy2
    ISO20022.Auth030001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth030001.EnergyCommodityCoal2
    ISO20022.Auth030001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth030001.EnergyCommodityOil3
    ISO20022.Auth030001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth030001.EnergyCommodityNaturalGas3
    ISO20022.Auth030001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth030001.EnergyCommodityElectricity2
    class ISO20022.Auth030001.AssetClassCommodityEnvironmental3Choice {
        + Othr  : ISO20022.Auth030001.EnvironmentCommodityOther2
        + CrbnRltd  : ISO20022.Auth030001.EnvironmentalCommodityCarbonRelated2
        + Wthr  : ISO20022.Auth030001.EnvironmentalCommodityWeather2
        + Emssns  : ISO20022.Auth030001.EnvironmentalCommodityEmission3
    }
    ISO20022.Auth030001.AssetClassCommodityEnvironmental3Choice *-- ISO20022.Auth030001.EnvironmentCommodityOther2
    ISO20022.Auth030001.AssetClassCommodityEnvironmental3Choice *-- ISO20022.Auth030001.EnvironmentalCommodityCarbonRelated2
    ISO20022.Auth030001.AssetClassCommodityEnvironmental3Choice *-- ISO20022.Auth030001.EnvironmentalCommodityWeather2
    ISO20022.Auth030001.AssetClassCommodityEnvironmental3Choice *-- ISO20022.Auth030001.EnvironmentalCommodityEmission3
    class ISO20022.Auth030001.AssetClassCommodityFertilizer4Choice {
        + Othr  : ISO20022.Auth030001.FertilizerCommodityOther2
        + UreaAndAmmnmNtrt  : ISO20022.Auth030001.FertilizerCommodityUreaAndAmmoniumNitrate2
        + Urea  : ISO20022.Auth030001.FertilizerCommodityUrea2
        + Slphr  : ISO20022.Auth030001.FertilizerCommoditySulphur2
        + Ptsh  : ISO20022.Auth030001.FertilizerCommodityPotash2
        + DmmnmPhspht  : ISO20022.Auth030001.FertilizerCommodityDiammoniumPhosphate2
        + Ammn  : ISO20022.Auth030001.FertilizerCommodityAmmonia2
    }
    ISO20022.Auth030001.AssetClassCommodityFertilizer4Choice *-- ISO20022.Auth030001.FertilizerCommodityOther2
    ISO20022.Auth030001.AssetClassCommodityFertilizer4Choice *-- ISO20022.Auth030001.FertilizerCommodityUreaAndAmmoniumNitrate2
    ISO20022.Auth030001.AssetClassCommodityFertilizer4Choice *-- ISO20022.Auth030001.FertilizerCommodityUrea2
    ISO20022.Auth030001.AssetClassCommodityFertilizer4Choice *-- ISO20022.Auth030001.FertilizerCommoditySulphur2
    ISO20022.Auth030001.AssetClassCommodityFertilizer4Choice *-- ISO20022.Auth030001.FertilizerCommodityPotash2
    ISO20022.Auth030001.AssetClassCommodityFertilizer4Choice *-- ISO20022.Auth030001.FertilizerCommodityDiammoniumPhosphate2
    ISO20022.Auth030001.AssetClassCommodityFertilizer4Choice *-- ISO20022.Auth030001.FertilizerCommodityAmmonia2
    class ISO20022.Auth030001.AssetClassCommodityFreight4Choice {
        + Othr  : ISO20022.Auth030001.FreightCommodityOther2
        + CntnrShip  : ISO20022.Auth030001.FreightCommodityContainerShip2
        + Wet  : ISO20022.Auth030001.FreightCommodityWet3
        + Dry  : ISO20022.Auth030001.FreightCommodityDry3
    }
    ISO20022.Auth030001.AssetClassCommodityFreight4Choice *-- ISO20022.Auth030001.FreightCommodityOther2
    ISO20022.Auth030001.AssetClassCommodityFreight4Choice *-- ISO20022.Auth030001.FreightCommodityContainerShip2
    ISO20022.Auth030001.AssetClassCommodityFreight4Choice *-- ISO20022.Auth030001.FreightCommodityWet3
    ISO20022.Auth030001.AssetClassCommodityFreight4Choice *-- ISO20022.Auth030001.FreightCommodityDry3
    class ISO20022.Auth030001.AssetClassCommodityIndex1 {
        + BasePdct  : String
    }
    class ISO20022.Auth030001.AssetClassCommodityIndustrialProduct2Choice {
        + Manfctg  : ISO20022.Auth030001.IndustrialProductCommodityManufacturing2
        + Cnstrctn  : ISO20022.Auth030001.IndustrialProductCommodityConstruction2
    }
    ISO20022.Auth030001.AssetClassCommodityIndustrialProduct2Choice *-- ISO20022.Auth030001.IndustrialProductCommodityManufacturing2
    ISO20022.Auth030001.AssetClassCommodityIndustrialProduct2Choice *-- ISO20022.Auth030001.IndustrialProductCommodityConstruction2
    class ISO20022.Auth030001.AssetClassCommodityInflation1 {
        + BasePdct  : String
    }
    class ISO20022.Auth030001.AssetClassCommodityMetal2Choice {
        + Prcs  : ISO20022.Auth030001.MetalCommodityPrecious2
        + NonPrcs  : ISO20022.Auth030001.MetalCommodityNonPrecious2
    }
    ISO20022.Auth030001.AssetClassCommodityMetal2Choice *-- ISO20022.Auth030001.MetalCommodityPrecious2
    ISO20022.Auth030001.AssetClassCommodityMetal2Choice *-- ISO20022.Auth030001.MetalCommodityNonPrecious2
    class ISO20022.Auth030001.AssetClassCommodityMultiCommodityExotic1 {
        + BasePdct  : String
    }
    class ISO20022.Auth030001.AssetClassCommodityOfficialEconomicStatistics1 {
        + BasePdct  : String
    }
    class ISO20022.Auth030001.AssetClassCommodityOther1 {
        + BasePdct  : String
    }
    class ISO20022.Auth030001.AssetClassCommodityPaper5Choice {
        + Othr  : ISO20022.Auth030001.PaperCommodityOther1
        + RcvrdPpr  : ISO20022.Auth030001.PaperCommodityRecoveredPaper3
        + Pulp  : ISO20022.Auth030001.PaperCommodityPulp2
        + Nwsprnt  : ISO20022.Auth030001.PaperCommodityNewsprint2
        + CntnrBrd  : ISO20022.Auth030001.PaperCommodityContainerBoard2
    }
    ISO20022.Auth030001.AssetClassCommodityPaper5Choice *-- ISO20022.Auth030001.PaperCommodityOther1
    ISO20022.Auth030001.AssetClassCommodityPaper5Choice *-- ISO20022.Auth030001.PaperCommodityRecoveredPaper3
    ISO20022.Auth030001.AssetClassCommodityPaper5Choice *-- ISO20022.Auth030001.PaperCommodityPulp2
    ISO20022.Auth030001.AssetClassCommodityPaper5Choice *-- ISO20022.Auth030001.PaperCommodityNewsprint2
    ISO20022.Auth030001.AssetClassCommodityPaper5Choice *-- ISO20022.Auth030001.PaperCommodityContainerBoard2
    class ISO20022.Auth030001.AssetClassCommodityPolypropylene4Choice {
        + Othr  : ISO20022.Auth030001.PolypropyleneCommodityOther2
        + Plstc  : ISO20022.Auth030001.PolypropyleneCommodityPlastic2
    }
    ISO20022.Auth030001.AssetClassCommodityPolypropylene4Choice *-- ISO20022.Auth030001.PolypropyleneCommodityOther2
    ISO20022.Auth030001.AssetClassCommodityPolypropylene4Choice *-- ISO20022.Auth030001.PolypropyleneCommodityPlastic2
    class ISO20022.Auth030001.AssetClassDetailedSubProductType10Code {
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
    class ISO20022.Auth030001.AssetClassDetailedSubProductType11Code {
        SLVR = 1
        PTNM = 2
        PLDM = 3
        OTHR = 4
        GOLD = 5
    }
    class ISO20022.Auth030001.AssetClassDetailedSubProductType1Code {
        RICE = 1
        CORN = 2
        OTHR = 3
        RPSD = 4
        SOYB = 5
        FWHT = 6
    }
    class ISO20022.Auth030001.AssetClassDetailedSubProductType29Code {
        OTHR = 1
        LAMP = 2
    }
    class ISO20022.Auth030001.AssetClassDetailedSubProductType2Code {
        OTHR = 1
        WHSG = 2
        BRWN = 3
        CCOA = 4
        ROBU = 5
    }
    class ISO20022.Auth030001.AssetClassDetailedSubProductType30Code {
        OTHR = 1
        MWHT = 2
    }
    class ISO20022.Auth030001.AssetClassDetailedSubProductType31Code {
        OTHR = 1
        NBPG = 2
        TTFG = 3
        NCGG = 4
        LNGG = 5
        GASP = 6
    }
    class ISO20022.Auth030001.AssetClassDetailedSubProductType32Code {
        OTHR = 1
        URAL = 2
        WTIO = 3
        TAPI = 4
        NGLO = 5
        NAPH = 6
        MARS = 7
        LLSO = 8
        KERO = 9
        JTFL = 10
        HEAT = 11
        GSLN = 12
        GOIL = 13
        FOIL = 14
        FUEL = 15
        ETHA = 16
        ESPO = 17
        DUBA = 18
        DSEL = 19
        COND = 20
        CNDA = 21
        BRNX = 22
        BRNT = 23
        BDSL = 24
        BAKK = 25
    }
    class ISO20022.Auth030001.AssetClassDetailedSubProductType33Code {
        OTHR = 1
        DBCR = 2
    }
    class ISO20022.Auth030001.AssetClassDetailedSubProductType34Code {
        OTHR = 1
        TNKR = 2
    }
    class ISO20022.Auth030001.AssetClassDetailedSubProductType5Code {
        OTHR = 1
        OFFP = 2
        PKLD = 3
        FITR = 4
        BSLD = 5
    }
    class ISO20022.Auth030001.AssetClassDetailedSubProductType8Code {
        OTHR = 1
        EUAA = 2
        EUAE = 3
        ERUE = 4
        CERE = 5
    }
    class ISO20022.Auth030001.AssetClassProductType11Code {
        OTHC = 1
    }
    class ISO20022.Auth030001.AssetClassProductType12Code {
        INFL = 1
    }
    class ISO20022.Auth030001.AssetClassProductType13Code {
        MCEX = 1
    }
    class ISO20022.Auth030001.AssetClassProductType14Code {
        OEST = 1
    }
    class ISO20022.Auth030001.AssetClassProductType15Code {
        OTHR = 1
    }
    class ISO20022.Auth030001.AssetClassProductType16Code {
        INDX = 1
    }
    class ISO20022.Auth030001.AssetClassProductType1Code {
        AGRI = 1
    }
    class ISO20022.Auth030001.AssetClassProductType2Code {
        NRGY = 1
    }
    class ISO20022.Auth030001.AssetClassProductType3Code {
        ENVR = 1
    }
    class ISO20022.Auth030001.AssetClassProductType4Code {
        FRGT = 1
    }
    class ISO20022.Auth030001.AssetClassProductType5Code {
        FRTL = 1
    }
    class ISO20022.Auth030001.AssetClassProductType6Code {
        INDP = 1
    }
    class ISO20022.Auth030001.AssetClassProductType7Code {
        METL = 1
    }
    class ISO20022.Auth030001.AssetClassProductType8Code {
        PAPR = 1
    }
    class ISO20022.Auth030001.AssetClassProductType9Code {
        POLY = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType10Code {
        EMIS = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType15Code {
        NPRM = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType16Code {
        PRME = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType18Code {
        PLST = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType1Code {
        GROS = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType20Code {
        DIRY = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType21Code {
        FRST = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType22Code {
        LSTK = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType23Code {
        SEAF = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType24Code {
        COAL = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType25Code {
        DIST = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType26Code {
        INRG = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType27Code {
        LGHT = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType28Code {
        RNNG = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType29Code {
        CRBR = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType2Code {
        SOFT = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType30Code {
        WTHR = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType31Code {
        DRYF = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType32Code {
        WETF = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType33Code {
        CSTR = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType34Code {
        MFTG = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType35Code {
        CBRD = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType36Code {
        NSPT = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType37Code {
        PULP = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType39Code {
        AMMO = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType3Code {
        OOLI = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType40Code {
        DAPH = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType41Code {
        PTSH = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType42Code {
        SLPH = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType43Code {
        UREA = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType44Code {
        UAAN = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType45Code {
        POTA = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType46Code {
        CSHP = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType49Code {
        OTHR = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType50Code {
        RCVP = 1
        OTHR = 2
    }
    class ISO20022.Auth030001.AssetClassSubProductType5Code {
        GRIN = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType6Code {
        ELEC = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType7Code {
        NGAS = 1
    }
    class ISO20022.Auth030001.AssetClassSubProductType8Code {
        OILP = 1
    }
    class ISO20022.Auth030001.BasketConstituents3 {
        + UnitOfMeasr  : ISO20022.Auth030001.UnitOfMeasure8Choice
        + Qty  : Decimal
        + InstrmId  : ISO20022.Auth030001.InstrumentIdentification6Choice
    }
    ISO20022.Auth030001.BasketConstituents3 *-- ISO20022.Auth030001.UnitOfMeasure8Choice
    ISO20022.Auth030001.BasketConstituents3 *-- ISO20022.Auth030001.InstrumentIdentification6Choice
    class ISO20022.Auth030001.Cleared23Choice {
        + NonClrd  : ISO20022.Auth030001.ClearingExceptionOrExemption3Choice
        + IntndToClear  : ISO20022.Auth030001.ClearingPartyAndTime22Choice
        + Clrd  : ISO20022.Auth030001.ClearingPartyAndTime21Choice
    }
    ISO20022.Auth030001.Cleared23Choice *-- ISO20022.Auth030001.ClearingExceptionOrExemption3Choice
    ISO20022.Auth030001.Cleared23Choice *-- ISO20022.Auth030001.ClearingPartyAndTime22Choice
    ISO20022.Auth030001.Cleared23Choice *-- ISO20022.Auth030001.ClearingPartyAndTime21Choice
    class ISO20022.Auth030001.ClearingAccountType4Code {
        HOUS = 1
        CLIE = 2
    }
    class ISO20022.Auth030001.ClearingExceptionOrExemption2 {
        + OthrCtrPty  : ISO20022.Auth030001.NonClearingReason2
        + RptgCtrPty  : ISO20022.Auth030001.NonClearingReason2
    }
    ISO20022.Auth030001.ClearingExceptionOrExemption2 *-- ISO20022.Auth030001.NonClearingReason2
    ISO20022.Auth030001.ClearingExceptionOrExemption2 *-- ISO20022.Auth030001.NonClearingReason2
    class ISO20022.Auth030001.ClearingExceptionOrExemption3Choice {
        + CtrPties  : ISO20022.Auth030001.ClearingExceptionOrExemption2
        + Rsn  : String
    }
    ISO20022.Auth030001.ClearingExceptionOrExemption3Choice *-- ISO20022.Auth030001.ClearingExceptionOrExemption2
    class ISO20022.Auth030001.ClearingExemptionException1Code {
        SMBK = 1
        OTHR = 2
        NORE = 3
        NOAL = 4
        AFFL = 5
        ENDU = 6
        COOP = 7
    }
    class ISO20022.Auth030001.ClearingObligationType1Code {
        TRUE = 1
        UKWN = 2
        FLSE = 3
    }
    class ISO20022.Auth030001.ClearingPartyAndTime21Choice {
        + Dtls  : ISO20022.Auth030001.ClearingPartyAndTime22
        + Rsn  : String
    }
    ISO20022.Auth030001.ClearingPartyAndTime21Choice *-- ISO20022.Auth030001.ClearingPartyAndTime22
    class ISO20022.Auth030001.ClearingPartyAndTime22 {
        + ClrAcctOrgn  : String
        + OrgnlTradRpstryIdr  : ISO20022.Auth030001.OrganisationIdentification15Choice
        + OrgnlIdr  : ISO20022.Auth030001.UniqueTransactionIdentifier2Choice
        + ClrIdr  : ISO20022.Auth030001.UniqueTransactionIdentifier2Choice
        + ClrDtTm  : DateTime
        + ClrRctDtTm  : DateTime
        + CCP  : ISO20022.Auth030001.OrganisationIdentification15Choice
    }
    ISO20022.Auth030001.ClearingPartyAndTime22 *-- ISO20022.Auth030001.OrganisationIdentification15Choice
    ISO20022.Auth030001.ClearingPartyAndTime22 *-- ISO20022.Auth030001.UniqueTransactionIdentifier2Choice
    ISO20022.Auth030001.ClearingPartyAndTime22 *-- ISO20022.Auth030001.UniqueTransactionIdentifier2Choice
    ISO20022.Auth030001.ClearingPartyAndTime22 *-- ISO20022.Auth030001.OrganisationIdentification15Choice
    class ISO20022.Auth030001.ClearingPartyAndTime22Choice {
        + Dtls  : ISO20022.Auth030001.ClearingPartyAndTime23
        + Rsn  : String
    }
    ISO20022.Auth030001.ClearingPartyAndTime22Choice *-- ISO20022.Auth030001.ClearingPartyAndTime23
    class ISO20022.Auth030001.ClearingPartyAndTime23 {
        + OrgnlTradRpstryIdr  : ISO20022.Auth030001.OrganisationIdentification15Choice
        + OrgnlIdr  : ISO20022.Auth030001.UniqueTransactionIdentifier1Choice
        + ClrIdr  : ISO20022.Auth030001.UniqueTransactionIdentifier1Choice
        + ClrDtTm  : DateTime
        + ClrRctDtTm  : DateTime
        + CCP  : ISO20022.Auth030001.OrganisationIdentification15Choice
    }
    ISO20022.Auth030001.ClearingPartyAndTime23 *-- ISO20022.Auth030001.OrganisationIdentification15Choice
    ISO20022.Auth030001.ClearingPartyAndTime23 *-- ISO20022.Auth030001.UniqueTransactionIdentifier1Choice
    ISO20022.Auth030001.ClearingPartyAndTime23 *-- ISO20022.Auth030001.UniqueTransactionIdentifier1Choice
    ISO20022.Auth030001.ClearingPartyAndTime23 *-- ISO20022.Auth030001.OrganisationIdentification15Choice
    class ISO20022.Auth030001.CollateralPortfolioCode6Choice {
        + MrgnPrtflCd  : ISO20022.Auth030001.MarginPortfolio4
        + Prtfl  : ISO20022.Auth030001.PortfolioCode3Choice
    }
    ISO20022.Auth030001.CollateralPortfolioCode6Choice *-- ISO20022.Auth030001.MarginPortfolio4
    ISO20022.Auth030001.CollateralPortfolioCode6Choice *-- ISO20022.Auth030001.PortfolioCode3Choice
    class ISO20022.Auth030001.CommonTradeDataReport71 {
        + TxData  : ISO20022.Auth030001.TradeTransaction50
        + CtrctData  : ISO20022.Auth030001.ContractType15
    }
    ISO20022.Auth030001.CommonTradeDataReport71 *-- ISO20022.Auth030001.TradeTransaction50
    ISO20022.Auth030001.CommonTradeDataReport71 *-- ISO20022.Auth030001.ContractType15
    class ISO20022.Auth030001.ContractType15 {
        + DerivBasedOnCrptAsst  : String
        + PlcOfSttlm  : String
        + SttlmCcyScndLeg  : ISO20022.Auth030001.CurrencyExchange23
        + SttlmCcy  : ISO20022.Auth030001.CurrencyExchange23
        + UndrlygAsstPricSrc  : String
        + UndrlygAsstTradgPltfmIdr  : String
        + UndrlygInstrm  : ISO20022.Auth030001.SecurityIdentification41Choice
        + PdctId  : ISO20022.Auth030001.SecurityIdentification46
        + PdctClssfctn  : String
        + AsstClss  : String
        + CtrctTp  : String
    }
    ISO20022.Auth030001.ContractType15 *-- ISO20022.Auth030001.CurrencyExchange23
    ISO20022.Auth030001.ContractType15 *-- ISO20022.Auth030001.CurrencyExchange23
    ISO20022.Auth030001.ContractType15 *-- ISO20022.Auth030001.SecurityIdentification41Choice
    ISO20022.Auth030001.ContractType15 *-- ISO20022.Auth030001.SecurityIdentification46
    class ISO20022.Auth030001.ContractValuationData8 {
        + Dlta  : Decimal
        + Tp  : String
        + TmStmp  : DateTime
        + CtrctVal  : ISO20022.Auth030001.AmountAndDirection109
    }
    ISO20022.Auth030001.ContractValuationData8 *-- ISO20022.Auth030001.AmountAndDirection109
    class ISO20022.Auth030001.Counterparty45 {
        + RptgXmptn  : ISO20022.Auth030001.ReportingExemption1
        + BookgLctn  : String
        + TradrLctn  : String
        + DrctnOrSd  : ISO20022.Auth030001.Direction4Choice
        + TradgCpcty  : String
        + Ntr  : ISO20022.Auth030001.CounterpartyTradeNature15Choice
        + Id  : ISO20022.Auth030001.PartyIdentification248Choice
    }
    ISO20022.Auth030001.Counterparty45 *-- ISO20022.Auth030001.ReportingExemption1
    ISO20022.Auth030001.Counterparty45 *-- ISO20022.Auth030001.Direction4Choice
    ISO20022.Auth030001.Counterparty45 *-- ISO20022.Auth030001.CounterpartyTradeNature15Choice
    ISO20022.Auth030001.Counterparty45 *-- ISO20022.Auth030001.PartyIdentification248Choice
    class ISO20022.Auth030001.Counterparty46 {
        + RptgOblgtn  : String
        + Ntr  : ISO20022.Auth030001.CounterpartyTradeNature15Choice
        + IdTp  : ISO20022.Auth030001.PartyIdentification248Choice
    }
    ISO20022.Auth030001.Counterparty46 *-- ISO20022.Auth030001.CounterpartyTradeNature15Choice
    ISO20022.Auth030001.Counterparty46 *-- ISO20022.Auth030001.PartyIdentification248Choice
    class ISO20022.Auth030001.CounterpartySpecificData36 {
        + RptgTmStmp  : DateTime
        + Valtn  : ISO20022.Auth030001.ContractValuationData8
        + CtrPty  : ISO20022.Auth030001.TradeCounterpartyReport20
    }
    ISO20022.Auth030001.CounterpartySpecificData36 *-- ISO20022.Auth030001.ContractValuationData8
    ISO20022.Auth030001.CounterpartySpecificData36 *-- ISO20022.Auth030001.TradeCounterpartyReport20
    class ISO20022.Auth030001.CounterpartyTradeNature15Choice {
        + Othr  : String
        + CntrlCntrPty  : String
        + NFI  : ISO20022.Auth030001.NonFinancialInstitutionSector10
        + FI  : ISO20022.Auth030001.FinancialInstitutionSector1
    }
    ISO20022.Auth030001.CounterpartyTradeNature15Choice *-- ISO20022.Auth030001.NonFinancialInstitutionSector10
    ISO20022.Auth030001.CounterpartyTradeNature15Choice *-- ISO20022.Auth030001.FinancialInstitutionSector1
    class ISO20022.Auth030001.CreditDerivative4 {
        + Trch  : ISO20022.Auth030001.TrancheIndicator3Choice
        + IndxFctr  : Decimal
        + Vrsn  : Decimal
        + Srs  : Decimal
        + ClctnBsis  : String
        + PmtFrqcy  : String
        + RefPty  : ISO20022.Auth030001.DerivativePartyIdentification1Choice
        + Snrty  : String
    }
    ISO20022.Auth030001.CreditDerivative4 *-- ISO20022.Auth030001.TrancheIndicator3Choice
    ISO20022.Auth030001.CreditDerivative4 *-- ISO20022.Auth030001.DerivativePartyIdentification1Choice
    class ISO20022.Auth030001.CurrencyExchange22 {
        + FxgDt  : DateTime
        + XchgRateBsis  : ISO20022.Auth030001.ExchangeRateBasis1Choice
        + FwdXchgRate  : Decimal
        + XchgRate  : Decimal
        + DlvrblCrossCcy  : String
    }
    ISO20022.Auth030001.CurrencyExchange22 *-- ISO20022.Auth030001.ExchangeRateBasis1Choice
    class ISO20022.Auth030001.CurrencyExchange23 {
        + FxgDt  : DateTime
        + XchgRateBsis  : ISO20022.Auth030001.ExchangeRateBasis1Choice
        + FwdXchgRate  : Decimal
        + XchgRate  : Decimal
        + Ccy  : String
    }
    ISO20022.Auth030001.CurrencyExchange23 *-- ISO20022.Auth030001.ExchangeRateBasis1Choice
    class ISO20022.Auth030001.CustomBasket4 {
        + Cnsttnts  : global::System.Collections.Generic.List~ISO20022.Auth030001.BasketConstituents3~
        + Id  : String
        + Strr  : String
    }
    ISO20022.Auth030001.CustomBasket4 *-- ISO20022.Auth030001.BasketConstituents3
    class ISO20022.Auth030001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Auth030001.DatePeriod1 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Auth030001.DebtInstrumentSeniorityType2Code {
        OTHR = 1
        SNDB = 2
        SBOD = 3
    }
    class ISO20022.Auth030001.DeliveryInterconnectionPoint1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Auth030001.DerivativeEvent6 {
        + AmdmntInd  : String
        + TmStmp  : ISO20022.Auth030001.DateAndDateTime2Choice
        + Id  : ISO20022.Auth030001.EventIdentifier1Choice
        + Tp  : String
    }
    ISO20022.Auth030001.DerivativeEvent6 *-- ISO20022.Auth030001.DateAndDateTime2Choice
    ISO20022.Auth030001.DerivativeEvent6 *-- ISO20022.Auth030001.EventIdentifier1Choice
    class ISO20022.Auth030001.DerivativeEventType3Code {
        UPDT = 1
        TRAD = 2
        PTNG = 3
        NOVA = 4
        INCP = 5
        EXER = 6
        ETRM = 7
        CREV = 8
        CORP = 9
        COMP = 10
        CLAL = 11
        CLRG = 12
        ALOC = 13
    }
    class ISO20022.Auth030001.DerivativePartyIdentification1Choice {
        + LEI  : String
        + CtrySubDvsn  : String
        + Ctry  : String
    }
    class ISO20022.Auth030001.DerivativesTradeReportV04 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth030001.SupplementaryData1~
        + TradData  : ISO20022.Auth030001.TradeData59Choice
        + RptHdr  : ISO20022.Auth030001.TradeReportHeader4
    }
    ISO20022.Auth030001.DerivativesTradeReportV04 *-- ISO20022.Auth030001.SupplementaryData1
    ISO20022.Auth030001.DerivativesTradeReportV04 *-- ISO20022.Auth030001.TradeData59Choice
    ISO20022.Auth030001.DerivativesTradeReportV04 *-- ISO20022.Auth030001.TradeReportHeader4
    class ISO20022.Auth030001.Direction2 {
        + DrctnOfTheScndLeg  : String
        + DrctnOfTheFrstLeg  : String
    }
    class ISO20022.Auth030001.Direction4Choice {
        + CtrPtySd  : String
        + Drctn  : ISO20022.Auth030001.Direction2
    }
    ISO20022.Auth030001.Direction4Choice *-- ISO20022.Auth030001.Direction2
    class ISO20022.Auth030001.DisseminationData1 {
        + TmStmp  : DateTime
        + OrgnlDssmntnIdr  : String
        + DssmntnIdr  : String
    }
    class ISO20022.Auth030001.DurationType1Code {
        OTHR = 1
        DASD = 2
        HOUR = 3
        MNUT = 4
        MNTH = 5
        QURT = 6
        SEAS = 7
        WEEK = 8
        YEAR = 9
    }
    class ISO20022.Auth030001.EmbeddedType1Code {
        MDET = 1
        OTHR = 2
        OPET = 3
        EXTD = 4
        CANC = 5
    }
    class ISO20022.Auth030001.EnergyCommodityCoal2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.EnergyCommodityDistillates2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.EnergyCommodityElectricity2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.EnergyCommodityInterEnergy2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.EnergyCommodityLightEnd2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.EnergyCommodityNaturalGas3 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.EnergyCommodityOil3 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.EnergyCommodityOther2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.EnergyCommodityRenewableEnergy2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.EnergyDeliveryAttribute10 {
        + PricTmIntrvlQty  : ISO20022.Auth030001.AmountAndDirection106
        + QtyUnit  : ISO20022.Auth030001.EnergyQuantityUnit2Choice
        + DlvryCpcty  : ISO20022.Auth030001.Quantity47Choice
        + WkDay  : global::System.Collections.Generic.List~String~
        + Drtn  : String
        + DlvryDt  : ISO20022.Auth030001.DatePeriod1
        + DlvryIntrvl  : global::System.Collections.Generic.List~ISO20022.Auth030001.TimePeriodDetails1~
    }
    ISO20022.Auth030001.EnergyDeliveryAttribute10 *-- ISO20022.Auth030001.AmountAndDirection106
    ISO20022.Auth030001.EnergyDeliveryAttribute10 *-- ISO20022.Auth030001.EnergyQuantityUnit2Choice
    ISO20022.Auth030001.EnergyDeliveryAttribute10 *-- ISO20022.Auth030001.Quantity47Choice
    ISO20022.Auth030001.EnergyDeliveryAttribute10 *-- ISO20022.Auth030001.DatePeriod1
    ISO20022.Auth030001.EnergyDeliveryAttribute10 *-- ISO20022.Auth030001.TimePeriodDetails1
    class ISO20022.Auth030001.EnergyLoadType1Code {
        SHPD = 1
        PKLD = 2
        OTHR = 3
        OFFP = 4
        HABH = 5
        GASD = 6
        BSLD = 7
    }
    class ISO20022.Auth030001.EnergyQuantityUnit2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Auth030001.EnergyQuantityUnit2Code {
        THMD = 1
        MWHH = 2
        MWHD = 3
        MWAT = 4
        MTMD = 5
        MMJD = 6
        MBTD = 7
        MJDD = 8
        MCMD = 9
        KWHH = 10
        KWHD = 11
        KWAT = 12
        KTMD = 13
        HMJD = 14
        GWHH = 15
        GWHD = 16
        GWAT = 17
        GJDD = 18
        CMPD = 19
        BTUD = 20
    }
    class ISO20022.Auth030001.EnergySpecificAttribute9 {
        + DlvryAttr  : global::System.Collections.Generic.List~ISO20022.Auth030001.EnergyDeliveryAttribute10~
        + LdTp  : String
        + IntrCnnctnPt  : ISO20022.Auth030001.DeliveryInterconnectionPoint1Choice
        + DlvryPtOrZone  : global::System.Collections.Generic.List~ISO20022.Auth030001.DeliveryInterconnectionPoint1Choice~
    }
    ISO20022.Auth030001.EnergySpecificAttribute9 *-- ISO20022.Auth030001.EnergyDeliveryAttribute10
    ISO20022.Auth030001.EnergySpecificAttribute9 *-- ISO20022.Auth030001.DeliveryInterconnectionPoint1Choice
    ISO20022.Auth030001.EnergySpecificAttribute9 *-- ISO20022.Auth030001.DeliveryInterconnectionPoint1Choice
    class ISO20022.Auth030001.EnvironmentCommodityOther2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.EnvironmentalCommodityCarbonRelated2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.EnvironmentalCommodityEmission3 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.EnvironmentalCommodityWeather2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.EventIdentifier1Choice {
        + PstTradRskRdctnIdr  : ISO20022.Auth030001.PostTradeRiskReductionIdentifier1
        + EvtIdr  : String
    }
    ISO20022.Auth030001.EventIdentifier1Choice *-- ISO20022.Auth030001.PostTradeRiskReductionIdentifier1
    class ISO20022.Auth030001.ExchangeRateBasis1 {
        + QtdCcy  : String
        + BaseCcy  : String
    }
    class ISO20022.Auth030001.ExchangeRateBasis1Choice {
        + Prtry  : String
        + CcyPair  : ISO20022.Auth030001.ExchangeRateBasis1
    }
    ISO20022.Auth030001.ExchangeRateBasis1Choice *-- ISO20022.Auth030001.ExchangeRateBasis1
    class ISO20022.Auth030001.ExerciseDate1Choice {
        + PdgDtAplbl  : String
        + FrstExrcDt  : DateTime
    }
    class ISO20022.Auth030001.FertilizerCommodityAmmonia2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.FertilizerCommodityDiammoniumPhosphate2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.FertilizerCommodityOther2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.FertilizerCommodityPotash2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.FertilizerCommoditySulphur2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.FertilizerCommodityUrea2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.FertilizerCommodityUreaAndAmmoniumNitrate2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.FinancialInstitutionSector1 {
        + ClrThrshld  : String
        + Sctr  : global::System.Collections.Generic.List~ISO20022.Auth030001.FinancialPartyClassification2Choice~
    }
    ISO20022.Auth030001.FinancialInstitutionSector1 *-- ISO20022.Auth030001.FinancialPartyClassification2Choice
    class ISO20022.Auth030001.FinancialInstrumentContractType2Code {
        OTHR = 1
        SWPT = 2
        SWAP = 3
        SPDB = 4
        OPTN = 5
        FORW = 6
        FUTR = 7
        FRAS = 8
        CFDS = 9
    }
    class ISO20022.Auth030001.FinancialInstrumentQuantity32Choice {
        + MntryVal  : ISO20022.Auth030001.ActiveOrHistoricCurrencyAnd19DecimalAmount
        + NmnlVal  : ISO20022.Auth030001.ActiveOrHistoricCurrencyAnd19DecimalAmount
        + Unit  : Decimal
    }
    ISO20022.Auth030001.FinancialInstrumentQuantity32Choice *-- ISO20022.Auth030001.ActiveOrHistoricCurrencyAnd19DecimalAmount
    ISO20022.Auth030001.FinancialInstrumentQuantity32Choice *-- ISO20022.Auth030001.ActiveOrHistoricCurrencyAnd19DecimalAmount
    class ISO20022.Auth030001.FinancialPartyClassification2Choice {
        + Prtry  : ISO20022.Auth030001.GenericIdentification175
        + Cd  : String
    }
    ISO20022.Auth030001.FinancialPartyClassification2Choice *-- ISO20022.Auth030001.GenericIdentification175
    class ISO20022.Auth030001.FinancialPartySectorType3Code {
        OTHR = 1
        ASSU = 2
        UCIT = 3
        REIN = 4
        INVF = 5
        ORPI = 6
        INUN = 7
        CDTI = 8
        CCPS = 9
        CSDS = 10
        AIFD = 11
    }
    class ISO20022.Auth030001.FixedRate10 {
        + PmtFrqcy  : ISO20022.Auth030001.InterestRateFrequency3Choice
        + DayCnt  : ISO20022.Auth030001.InterestComputationMethodFormat7
        + Rate  : ISO20022.Auth030001.SecuritiesTransactionPrice14Choice
    }
    ISO20022.Auth030001.FixedRate10 *-- ISO20022.Auth030001.InterestRateFrequency3Choice
    ISO20022.Auth030001.FixedRate10 *-- ISO20022.Auth030001.InterestComputationMethodFormat7
    ISO20022.Auth030001.FixedRate10 *-- ISO20022.Auth030001.SecuritiesTransactionPrice14Choice
    class ISO20022.Auth030001.FloatingRate13 {
        + LastFltgRst  : ISO20022.Auth030001.ResetDateAndValue1
        + NxtFltgRst  : ISO20022.Auth030001.ResetDateAndValue1
        + RstFrqcy  : ISO20022.Auth030001.InterestRateFrequency3Choice
        + PmtFrqcy  : ISO20022.Auth030001.InterestRateFrequency3Choice
        + DayCnt  : ISO20022.Auth030001.InterestComputationMethodFormat7
        + Sprd  : ISO20022.Auth030001.SecuritiesTransactionPrice20Choice
        + RefPrd  : ISO20022.Auth030001.InterestRateContractTerm4
        + Rate  : ISO20022.Auth030001.FloatingRateIdentification8Choice
        + Nm  : String
        + Id  : String
    }
    ISO20022.Auth030001.FloatingRate13 *-- ISO20022.Auth030001.ResetDateAndValue1
    ISO20022.Auth030001.FloatingRate13 *-- ISO20022.Auth030001.ResetDateAndValue1
    ISO20022.Auth030001.FloatingRate13 *-- ISO20022.Auth030001.InterestRateFrequency3Choice
    ISO20022.Auth030001.FloatingRate13 *-- ISO20022.Auth030001.InterestRateFrequency3Choice
    ISO20022.Auth030001.FloatingRate13 *-- ISO20022.Auth030001.InterestComputationMethodFormat7
    ISO20022.Auth030001.FloatingRate13 *-- ISO20022.Auth030001.SecuritiesTransactionPrice20Choice
    ISO20022.Auth030001.FloatingRate13 *-- ISO20022.Auth030001.InterestRateContractTerm4
    ISO20022.Auth030001.FloatingRate13 *-- ISO20022.Auth030001.FloatingRateIdentification8Choice
    class ISO20022.Auth030001.FloatingRateIdentification8Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Auth030001.FreightCommodityContainerShip2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.FreightCommodityDry3 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.FreightCommodityOther2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.FreightCommodityWet3 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.Frequency13Code {
        QURT = 1
        MIAN = 2
        EXPI = 3
        ADHO = 4
        YEAR = 5
        MNTH = 6
        WEEK = 7
        DAIL = 8
    }
    class ISO20022.Auth030001.Frequency19Code {
        ODMD = 1
        HOUL = 2
        QURT = 3
        MIAN = 4
        EXPI = 5
        ADHO = 6
        YEAR = 7
        MNTH = 8
        WEEK = 9
        DAIL = 10
    }
    class ISO20022.Auth030001.GenericIdentification175 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Auth030001.GenericIdentification179 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Auth030001.GenericIdentification184 {
        + Src  : String
        + Id  : String
    }
    class ISO20022.Auth030001.GenericIdentification185 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Auth030001.IndexIdentification1 {
        + Indx  : String
        + Nm  : String
        + ISIN  : String
    }
    class ISO20022.Auth030001.IndustrialProductCommodityConstruction2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.IndustrialProductCommodityManufacturing2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.InstrumentIdentification6Choice {
        + OthrId  : ISO20022.Auth030001.GenericIdentification184
        + UnqPdctIdr  : ISO20022.Auth030001.UniqueProductIdentifier1Choice
        + AltrntvInstrmId  : String
        + ISIN  : String
    }
    ISO20022.Auth030001.InstrumentIdentification6Choice *-- ISO20022.Auth030001.GenericIdentification184
    ISO20022.Auth030001.InstrumentIdentification6Choice *-- ISO20022.Auth030001.UniqueProductIdentifier1Choice
    class ISO20022.Auth030001.InterestComputationMethod4Code {
        A020 = 1
        NARR = 2
        A016 = 3
        A007 = 4
        A013 = 5
        A012 = 6
        A003 = 7
        A002 = 8
        A001 = 9
        A011 = 10
        A018 = 11
        A015 = 12
        A008 = 13
        A006 = 14
        A010 = 15
        A014 = 16
        A009 = 17
        A005 = 18
        A017 = 19
        A019 = 20
        A004 = 21
    }
    class ISO20022.Auth030001.InterestComputationMethodFormat7 {
        + Nrrtv  : String
        + Cd  : String
    }
    class ISO20022.Auth030001.InterestRate33Choice {
        + Fltg  : ISO20022.Auth030001.FloatingRate13
        + Fxd  : ISO20022.Auth030001.FixedRate10
    }
    ISO20022.Auth030001.InterestRate33Choice *-- ISO20022.Auth030001.FloatingRate13
    ISO20022.Auth030001.InterestRate33Choice *-- ISO20022.Auth030001.FixedRate10
    class ISO20022.Auth030001.InterestRateContractTerm4 {
        + Val  : Decimal
        + Unit  : String
    }
    class ISO20022.Auth030001.InterestRateFrequency3Choice {
        + Prtry  : String
        + Term  : ISO20022.Auth030001.InterestRateContractTerm4
    }
    ISO20022.Auth030001.InterestRateFrequency3Choice *-- ISO20022.Auth030001.InterestRateContractTerm4
    class ISO20022.Auth030001.InterestRateLegs14 {
        + ScndLeg  : ISO20022.Auth030001.InterestRate33Choice
        + FrstLeg  : ISO20022.Auth030001.InterestRate33Choice
    }
    ISO20022.Auth030001.InterestRateLegs14 *-- ISO20022.Auth030001.InterestRate33Choice
    ISO20022.Auth030001.InterestRateLegs14 *-- ISO20022.Auth030001.InterestRate33Choice
    class ISO20022.Auth030001.LegalPersonIdentification1 {
        + Ctry  : String
        + Id  : ISO20022.Auth030001.OrganisationIdentification15Choice
    }
    ISO20022.Auth030001.LegalPersonIdentification1 *-- ISO20022.Auth030001.OrganisationIdentification15Choice
    class ISO20022.Auth030001.MarginPortfolio4 {
        + VartnMrgnPrtflCd  : ISO20022.Auth030001.PortfolioCode5Choice
        + InitlMrgnPrtflCd  : ISO20022.Auth030001.PortfolioCode5Choice
    }
    ISO20022.Auth030001.MarginPortfolio4 *-- ISO20022.Auth030001.PortfolioCode5Choice
    ISO20022.Auth030001.MarginPortfolio4 *-- ISO20022.Auth030001.PortfolioCode5Choice
    class ISO20022.Auth030001.MasterAgreement8 {
        + OthrMstrAgrmtDtls  : String
        + Vrsn  : String
        + Tp  : ISO20022.Auth030001.AgreementType2Choice
    }
    ISO20022.Auth030001.MasterAgreement8 *-- ISO20022.Auth030001.AgreementType2Choice
    class ISO20022.Auth030001.MetalCommodityNonPrecious2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.MetalCommodityPrecious2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.ModificationLevel1Code {
        TCTN = 1
        PSTN = 2
    }
    class ISO20022.Auth030001.NaturalPersonIdentification2 {
        + Dmcl  : String
        + Nm  : String
        + Id  : ISO20022.Auth030001.GenericIdentification175
    }
    ISO20022.Auth030001.NaturalPersonIdentification2 *-- ISO20022.Auth030001.GenericIdentification175
    class ISO20022.Auth030001.NaturalPersonIdentification3 {
        + Ctry  : String
        + Id  : ISO20022.Auth030001.NaturalPersonIdentification2
    }
    ISO20022.Auth030001.NaturalPersonIdentification3 *-- ISO20022.Auth030001.NaturalPersonIdentification2
    class ISO20022.Auth030001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Auth030001.NonClearingReason2 {
        + NonClrRsnInf  : String
        + ClrXmptnXcptn  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Auth030001.NonFinancialInstitutionSector10 {
        + FdrlInstn  : String
        + DrctlyLkdActvty  : String
        + ClrThrshld  : String
        + Sctr  : global::System.Collections.Generic.List~ISO20022.Auth030001.GenericIdentification175~
    }
    ISO20022.Auth030001.NonFinancialInstitutionSector10 *-- ISO20022.Auth030001.GenericIdentification175
    class ISO20022.Auth030001.NotApplicable1Code {
        NOAP = 1
    }
    class ISO20022.Auth030001.NotionalAmount5 {
        + SchdlPrd  : global::System.Collections.Generic.List~ISO20022.Auth030001.Schedule11~
        + Amt  : ISO20022.Auth030001.AmountAndDirection106
    }
    ISO20022.Auth030001.NotionalAmount5 *-- ISO20022.Auth030001.Schedule11
    ISO20022.Auth030001.NotionalAmount5 *-- ISO20022.Auth030001.AmountAndDirection106
    class ISO20022.Auth030001.NotionalAmount6 {
        + Ccy  : String
        + SchdlPrd  : global::System.Collections.Generic.List~ISO20022.Auth030001.Schedule11~
        + Amt  : ISO20022.Auth030001.AmountAndDirection106
    }
    ISO20022.Auth030001.NotionalAmount6 *-- ISO20022.Auth030001.Schedule11
    ISO20022.Auth030001.NotionalAmount6 *-- ISO20022.Auth030001.AmountAndDirection106
    class ISO20022.Auth030001.NotionalAmountLegs5 {
        + ScndLeg  : ISO20022.Auth030001.NotionalAmount6
        + FrstLeg  : ISO20022.Auth030001.NotionalAmount5
    }
    ISO20022.Auth030001.NotionalAmountLegs5 *-- ISO20022.Auth030001.NotionalAmount6
    ISO20022.Auth030001.NotionalAmountLegs5 *-- ISO20022.Auth030001.NotionalAmount5
    class ISO20022.Auth030001.NotionalQuantity9 {
        + Dtls  : ISO20022.Auth030001.QuantityOrTerm1Choice
        + UnitOfMeasr  : ISO20022.Auth030001.UnitOfMeasure8Choice
        + TtlQty  : Decimal
    }
    ISO20022.Auth030001.NotionalQuantity9 *-- ISO20022.Auth030001.QuantityOrTerm1Choice
    ISO20022.Auth030001.NotionalQuantity9 *-- ISO20022.Auth030001.UnitOfMeasure8Choice
    class ISO20022.Auth030001.NotionalQuantityLegs5 {
        + ScndLeg  : ISO20022.Auth030001.NotionalQuantity9
        + FrstLeg  : ISO20022.Auth030001.NotionalQuantity9
    }
    ISO20022.Auth030001.NotionalQuantityLegs5 *-- ISO20022.Auth030001.NotionalQuantity9
    ISO20022.Auth030001.NotionalQuantityLegs5 *-- ISO20022.Auth030001.NotionalQuantity9
    class ISO20022.Auth030001.OptionBarrierLevel1Choice {
        + Mltpl  : ISO20022.Auth030001.OptionMultipleBarrierLevels1
        + Sngl  : ISO20022.Auth030001.SecuritiesTransactionPrice23Choice
    }
    ISO20022.Auth030001.OptionBarrierLevel1Choice *-- ISO20022.Auth030001.OptionMultipleBarrierLevels1
    ISO20022.Auth030001.OptionBarrierLevel1Choice *-- ISO20022.Auth030001.SecuritiesTransactionPrice23Choice
    class ISO20022.Auth030001.OptionMultipleBarrierLevels1 {
        + UpperLvl  : ISO20022.Auth030001.SecuritiesTransactionPrice23Choice
        + LwrLvl  : ISO20022.Auth030001.SecuritiesTransactionPrice23Choice
    }
    ISO20022.Auth030001.OptionMultipleBarrierLevels1 *-- ISO20022.Auth030001.SecuritiesTransactionPrice23Choice
    ISO20022.Auth030001.OptionMultipleBarrierLevels1 *-- ISO20022.Auth030001.SecuritiesTransactionPrice23Choice
    class ISO20022.Auth030001.OptionOrSwaption11 {
        + BrrrLvls  : ISO20022.Auth030001.OptionBarrierLevel1Choice
        + MtrtyDtOfUndrlyg  : DateTime
        + PrmPmtDt  : DateTime
        + PrmAmt  : ISO20022.Auth030001.ActiveOrHistoricCurrencyAnd19DecimalAmount
        + PutAmt  : ISO20022.Auth030001.ActiveOrHistoricCurrencyAnd19DecimalAmount
        + CallAmt  : ISO20022.Auth030001.ActiveOrHistoricCurrencyAnd19DecimalAmount
        + StrkPricSchdl  : global::System.Collections.Generic.List~ISO20022.Auth030001.Schedule4~
        + StrkPric  : ISO20022.Auth030001.SecuritiesTransactionPrice17Choice
        + ExrcDt  : ISO20022.Auth030001.ExerciseDate1Choice
        + ExrcStyle  : global::System.Collections.Generic.List~String~
        + MbddTp  : String
        + Tp  : String
    }
    ISO20022.Auth030001.OptionOrSwaption11 *-- ISO20022.Auth030001.OptionBarrierLevel1Choice
    ISO20022.Auth030001.OptionOrSwaption11 *-- ISO20022.Auth030001.ActiveOrHistoricCurrencyAnd19DecimalAmount
    ISO20022.Auth030001.OptionOrSwaption11 *-- ISO20022.Auth030001.ActiveOrHistoricCurrencyAnd19DecimalAmount
    ISO20022.Auth030001.OptionOrSwaption11 *-- ISO20022.Auth030001.ActiveOrHistoricCurrencyAnd19DecimalAmount
    ISO20022.Auth030001.OptionOrSwaption11 *-- ISO20022.Auth030001.Schedule4
    ISO20022.Auth030001.OptionOrSwaption11 *-- ISO20022.Auth030001.SecuritiesTransactionPrice17Choice
    ISO20022.Auth030001.OptionOrSwaption11 *-- ISO20022.Auth030001.ExerciseDate1Choice
    class ISO20022.Auth030001.OptionParty1Code {
        BYER = 1
        SLLR = 2
    }
    class ISO20022.Auth030001.OptionParty3Code {
        TAKE = 1
        MAKE = 2
    }
    class ISO20022.Auth030001.OptionStyle6Code {
        AMER = 1
        ASIA = 2
        BERM = 3
        EURO = 4
    }
    class ISO20022.Auth030001.OptionType2Code {
        OTHR = 1
        PUTO = 2
        CALL = 3
    }
    class ISO20022.Auth030001.OrganisationIdentification15Choice {
        + AnyBIC  : String
        + Othr  : ISO20022.Auth030001.OrganisationIdentification38
        + LEI  : String
    }
    ISO20022.Auth030001.OrganisationIdentification15Choice *-- ISO20022.Auth030001.OrganisationIdentification38
    class ISO20022.Auth030001.OrganisationIdentification38 {
        + Dmcl  : String
        + Nm  : String
        + Id  : ISO20022.Auth030001.GenericIdentification175
    }
    ISO20022.Auth030001.OrganisationIdentification38 *-- ISO20022.Auth030001.GenericIdentification175
    class ISO20022.Auth030001.OtherPayment5 {
        + PmtRcvr  : ISO20022.Auth030001.PartyIdentification236Choice
        + PmtPyer  : ISO20022.Auth030001.PartyIdentification236Choice
        + PmtDt  : DateTime
        + PmtTp  : ISO20022.Auth030001.PaymentType5Choice
        + PmtAmt  : ISO20022.Auth030001.AmountAndDirection106
    }
    ISO20022.Auth030001.OtherPayment5 *-- ISO20022.Auth030001.PartyIdentification236Choice
    ISO20022.Auth030001.OtherPayment5 *-- ISO20022.Auth030001.PartyIdentification236Choice
    ISO20022.Auth030001.OtherPayment5 *-- ISO20022.Auth030001.PaymentType5Choice
    ISO20022.Auth030001.OtherPayment5 *-- ISO20022.Auth030001.AmountAndDirection106
    class ISO20022.Auth030001.PTRREvent2 {
        + SvcPrvdr  : ISO20022.Auth030001.OrganisationIdentification15Choice
        + Tchnq  : String
    }
    ISO20022.Auth030001.PTRREvent2 *-- ISO20022.Auth030001.OrganisationIdentification15Choice
    class ISO20022.Auth030001.Package4 {
        + Sprd  : ISO20022.Auth030001.SecuritiesTransactionPrice20Choice
        + Pric  : ISO20022.Auth030001.SecuritiesTransactionPrice17Choice
        + FxSwpLkId  : String
        + CmplxTradId  : String
    }
    ISO20022.Auth030001.Package4 *-- ISO20022.Auth030001.SecuritiesTransactionPrice20Choice
    ISO20022.Auth030001.Package4 *-- ISO20022.Auth030001.SecuritiesTransactionPrice17Choice
    class ISO20022.Auth030001.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Auth030001.PaperCommodityContainerBoard2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.PaperCommodityNewsprint2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.PaperCommodityOther1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.PaperCommodityPulp2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.PaperCommodityRecoveredPaper3 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.PartyIdentification236Choice {
        + Ntrl  : ISO20022.Auth030001.NaturalPersonIdentification2
        + Lgl  : ISO20022.Auth030001.OrganisationIdentification15Choice
    }
    ISO20022.Auth030001.PartyIdentification236Choice *-- ISO20022.Auth030001.NaturalPersonIdentification2
    ISO20022.Auth030001.PartyIdentification236Choice *-- ISO20022.Auth030001.OrganisationIdentification15Choice
    class ISO20022.Auth030001.PartyIdentification248Choice {
        + Ntrl  : ISO20022.Auth030001.NaturalPersonIdentification3
        + Lgl  : ISO20022.Auth030001.LegalPersonIdentification1
    }
    ISO20022.Auth030001.PartyIdentification248Choice *-- ISO20022.Auth030001.NaturalPersonIdentification3
    ISO20022.Auth030001.PartyIdentification248Choice *-- ISO20022.Auth030001.LegalPersonIdentification1
    class ISO20022.Auth030001.PaymentType4Code {
        PEXH = 1
        UWIN = 2
        UFRO = 3
    }
    class ISO20022.Auth030001.PaymentType5Choice {
        + PrtryTp  : String
        + Tp  : String
    }
    class ISO20022.Auth030001.PhysicalTransferType4Code {
        CASH = 1
        OPTL = 2
        PHYS = 3
    }
    class ISO20022.Auth030001.PolypropyleneCommodityOther2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.PolypropyleneCommodityPlastic2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth030001.PortfolioCode3Choice {
        + NoPrtfl  : String
        + Cd  : String
    }
    class ISO20022.Auth030001.PortfolioCode5Choice {
        + NoPrtfl  : String
        + Prtfl  : ISO20022.Auth030001.PortfolioIdentification3
    }
    ISO20022.Auth030001.PortfolioCode5Choice *-- ISO20022.Auth030001.PortfolioIdentification3
    class ISO20022.Auth030001.PortfolioIdentification3 {
        + PrtflTxXmptn  : String
        + Cd  : String
    }
    class ISO20022.Auth030001.PostTradeRiskReductionIdentifier1 {
        + Id  : String
        + Strr  : String
    }
    class ISO20022.Auth030001.PriceData2 {
        + PricMltplr  : Decimal
        + UnitOfMeasr  : ISO20022.Auth030001.UnitOfMeasure8Choice
        + SchdlPrd  : global::System.Collections.Generic.List~ISO20022.Auth030001.Schedule1~
        + Pric  : ISO20022.Auth030001.SecuritiesTransactionPrice17Choice
    }
    ISO20022.Auth030001.PriceData2 *-- ISO20022.Auth030001.UnitOfMeasure8Choice
    ISO20022.Auth030001.PriceData2 *-- ISO20022.Auth030001.Schedule1
    ISO20022.Auth030001.PriceData2 *-- ISO20022.Auth030001.SecuritiesTransactionPrice17Choice
    class ISO20022.Auth030001.PriceStatus1Code {
        NOAP = 1
        PNDG = 2
    }
    class ISO20022.Auth030001.PriceStatus2Code {
        PNDG = 1
    }
    class ISO20022.Auth030001.ProductType4Code {
        OTHR = 1
        COMM = 2
        INTR = 3
        EQUI = 4
        CURR = 5
        CRDT = 6
    }
    class ISO20022.Auth030001.Quantity47Choice {
        + Desc  : String
        + Qty  : Decimal
    }
    class ISO20022.Auth030001.QuantityOrTerm1Choice {
        + Term  : ISO20022.Auth030001.QuantityTerm1
        + SchdlPrd  : global::System.Collections.Generic.List~ISO20022.Auth030001.Schedule10~
    }
    ISO20022.Auth030001.QuantityOrTerm1Choice *-- ISO20022.Auth030001.QuantityTerm1
    ISO20022.Auth030001.QuantityOrTerm1Choice *-- ISO20022.Auth030001.Schedule10
    class ISO20022.Auth030001.QuantityTerm1 {
        + TmUnit  : String
        + Val  : Decimal
        + UnitOfMeasr  : ISO20022.Auth030001.UnitOfMeasure8Choice
        + Qty  : Decimal
    }
    ISO20022.Auth030001.QuantityTerm1 *-- ISO20022.Auth030001.UnitOfMeasure8Choice
    class ISO20022.Auth030001.Reconciliation3Code {
        SSNE = 1
        SSUN = 2
        SPRV = 3
        SPRW = 4
        SSPA = 5
        SSMA = 6
        NORE = 7
        DSNM = 8
        DSMA = 9
        DPRV = 10
        DPRW = 11
    }
    class ISO20022.Auth030001.ReportPeriodActivity1Code {
        NOTX = 1
    }
    class ISO20022.Auth030001.ReportingExemption1 {
        + Desc  : String
        + Rsn  : String
    }
    class ISO20022.Auth030001.ResetDateAndValue1 {
        + Val  : Decimal
        + Dt  : DateTime
    }
    class ISO20022.Auth030001.RiskReductionService1Code {
        PWAS = 1
        PRBM = 2
        OTHR = 3
        PWOS = 4
        NORR = 5
    }
    class ISO20022.Auth030001.Schedule1 {
        + Pric  : ISO20022.Auth030001.SecuritiesTransactionPrice17Choice
        + UadjstdEndDt  : DateTime
        + UadjstdFctvDt  : DateTime
    }
    ISO20022.Auth030001.Schedule1 *-- ISO20022.Auth030001.SecuritiesTransactionPrice17Choice
    class ISO20022.Auth030001.Schedule10 {
        + UadjstdEndDt  : DateTime
        + UadjstdFctvDt  : DateTime
        + UnitOfMeasr  : ISO20022.Auth030001.UnitOfMeasure8Choice
        + Qty  : Decimal
    }
    ISO20022.Auth030001.Schedule10 *-- ISO20022.Auth030001.UnitOfMeasure8Choice
    class ISO20022.Auth030001.Schedule11 {
        + Amt  : ISO20022.Auth030001.AmountAndDirection106
        + UadjstdEndDt  : DateTime
        + UadjstdFctvDt  : DateTime
    }
    ISO20022.Auth030001.Schedule11 *-- ISO20022.Auth030001.AmountAndDirection106
    class ISO20022.Auth030001.Schedule4 {
        + Pric  : ISO20022.Auth030001.SecuritiesTransactionPrice17Choice
        + UadjstdEndDt  : DateTime
        + UadjstdFctvDt  : DateTime
    }
    ISO20022.Auth030001.Schedule4 *-- ISO20022.Auth030001.SecuritiesTransactionPrice17Choice
    class ISO20022.Auth030001.SecuritiesTransactionPrice14Choice {
        + Dcml  : Decimal
        + Rate  : Decimal
    }
    class ISO20022.Auth030001.SecuritiesTransactionPrice17Choice {
        + Othr  : ISO20022.Auth030001.SecuritiesTransactionPrice5
        + PdgPric  : String
        + Dcml  : Decimal
        + Yld  : Decimal
        + Pctg  : Decimal
        + Unit  : Decimal
        + MntryVal  : ISO20022.Auth030001.AmountAndDirection106
    }
    ISO20022.Auth030001.SecuritiesTransactionPrice17Choice *-- ISO20022.Auth030001.SecuritiesTransactionPrice5
    ISO20022.Auth030001.SecuritiesTransactionPrice17Choice *-- ISO20022.Auth030001.AmountAndDirection106
    class ISO20022.Auth030001.SecuritiesTransactionPrice20Choice {
        + BsisPtSprd  : Decimal
        + Dcml  : Decimal
        + Pctg  : Decimal
        + MntryVal  : ISO20022.Auth030001.AmountAndDirection106
    }
    ISO20022.Auth030001.SecuritiesTransactionPrice20Choice *-- ISO20022.Auth030001.AmountAndDirection106
    class ISO20022.Auth030001.SecuritiesTransactionPrice23Choice {
        + Othr  : ISO20022.Auth030001.SecuritiesTransactionPrice5
        + Dcml  : Decimal
        + Yld  : Decimal
        + Pctg  : Decimal
        + Unit  : Decimal
        + MntryVal  : ISO20022.Auth030001.AmountAndDirection106
    }
    ISO20022.Auth030001.SecuritiesTransactionPrice23Choice *-- ISO20022.Auth030001.SecuritiesTransactionPrice5
    ISO20022.Auth030001.SecuritiesTransactionPrice23Choice *-- ISO20022.Auth030001.AmountAndDirection106
    class ISO20022.Auth030001.SecuritiesTransactionPrice5 {
        + Tp  : String
        + Val  : Decimal
    }
    class ISO20022.Auth030001.SecurityIdentification41Choice {
        + IdNotAvlbl  : String
        + Othr  : ISO20022.Auth030001.GenericIdentification184
        + Indx  : ISO20022.Auth030001.IndexIdentification1
        + Bskt  : ISO20022.Auth030001.CustomBasket4
        + UnqPdctIdr  : ISO20022.Auth030001.UniqueProductIdentifier2Choice
        + AltrntvInstrmId  : String
        + ISIN  : String
    }
    ISO20022.Auth030001.SecurityIdentification41Choice *-- ISO20022.Auth030001.GenericIdentification184
    ISO20022.Auth030001.SecurityIdentification41Choice *-- ISO20022.Auth030001.IndexIdentification1
    ISO20022.Auth030001.SecurityIdentification41Choice *-- ISO20022.Auth030001.CustomBasket4
    ISO20022.Auth030001.SecurityIdentification41Choice *-- ISO20022.Auth030001.UniqueProductIdentifier2Choice
    class ISO20022.Auth030001.SecurityIdentification46 {
        + PdctDesc  : String
        + AltrntvInstrmId  : String
        + UnqPdctIdr  : ISO20022.Auth030001.UniqueProductIdentifier2Choice
        + ISIN  : String
    }
    ISO20022.Auth030001.SecurityIdentification46 *-- ISO20022.Auth030001.UniqueProductIdentifier2Choice
    class ISO20022.Auth030001.SupplementaryData1 {
        + Envlp  : ISO20022.Auth030001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Auth030001.SupplementaryData1 *-- ISO20022.Auth030001.SupplementaryDataEnvelope1
    class ISO20022.Auth030001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Auth030001.TechnicalAttributes5 {
        + RptRctTmStmp  : DateTime
        + RcncltnFlg  : String
        + TechRcrdId  : String
    }
    class ISO20022.Auth030001.TimePeriodDetails1 {
        + ToTm  : DateTime
        + FrTm  : DateTime
    }
    class ISO20022.Auth030001.TradeClearing11 {
        + IntraGrp  : String
        + ClrSts  : ISO20022.Auth030001.Cleared23Choice
        + ClrOblgtn  : String
    }
    ISO20022.Auth030001.TradeClearing11 *-- ISO20022.Auth030001.Cleared23Choice
    class ISO20022.Auth030001.TradeConfirmation4Choice {
        + NonConfd  : ISO20022.Auth030001.TradeNonConfirmation1
        + Confd  : ISO20022.Auth030001.TradeConfirmation5
    }
    ISO20022.Auth030001.TradeConfirmation4Choice *-- ISO20022.Auth030001.TradeNonConfirmation1
    ISO20022.Auth030001.TradeConfirmation4Choice *-- ISO20022.Auth030001.TradeConfirmation5
    class ISO20022.Auth030001.TradeConfirmation5 {
        + TmStmp  : DateTime
        + Tp  : String
    }
    class ISO20022.Auth030001.TradeConfirmationType1Code {
        YCNF = 1
        ECNF = 2
    }
    class ISO20022.Auth030001.TradeConfirmationType2Code {
        NCNF = 1
    }
    class ISO20022.Auth030001.TradeCounterpartyRelationship1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Auth030001.TradeCounterpartyRelationshipRecord1 {
        + Desc  : String
        + RltshTp  : ISO20022.Auth030001.TradeCounterpartyRelationship1Choice
        + EndRltshPty  : String
        + StartRltshPty  : String
    }
    ISO20022.Auth030001.TradeCounterpartyRelationshipRecord1 *-- ISO20022.Auth030001.TradeCounterpartyRelationship1Choice
    class ISO20022.Auth030001.TradeCounterpartyReport20 {
        + RltshRcrd  : global::System.Collections.Generic.List~ISO20022.Auth030001.TradeCounterpartyRelationshipRecord1~
        + ExctnAgt  : global::System.Collections.Generic.List~ISO20022.Auth030001.OrganisationIdentification15Choice~
        + NttyRspnsblForRpt  : ISO20022.Auth030001.OrganisationIdentification15Choice
        + Bnfcry  : global::System.Collections.Generic.List~ISO20022.Auth030001.PartyIdentification248Choice~
        + ClrMmb  : ISO20022.Auth030001.PartyIdentification248Choice
        + SubmitgAgt  : ISO20022.Auth030001.OrganisationIdentification15Choice
        + Brkr  : ISO20022.Auth030001.OrganisationIdentification15Choice
        + OthrCtrPty  : ISO20022.Auth030001.Counterparty46
        + RptgCtrPty  : ISO20022.Auth030001.Counterparty45
    }
    ISO20022.Auth030001.TradeCounterpartyReport20 *-- ISO20022.Auth030001.TradeCounterpartyRelationshipRecord1
    ISO20022.Auth030001.TradeCounterpartyReport20 *-- ISO20022.Auth030001.OrganisationIdentification15Choice
    ISO20022.Auth030001.TradeCounterpartyReport20 *-- ISO20022.Auth030001.OrganisationIdentification15Choice
    ISO20022.Auth030001.TradeCounterpartyReport20 *-- ISO20022.Auth030001.PartyIdentification248Choice
    ISO20022.Auth030001.TradeCounterpartyReport20 *-- ISO20022.Auth030001.PartyIdentification248Choice
    ISO20022.Auth030001.TradeCounterpartyReport20 *-- ISO20022.Auth030001.OrganisationIdentification15Choice
    ISO20022.Auth030001.TradeCounterpartyReport20 *-- ISO20022.Auth030001.OrganisationIdentification15Choice
    ISO20022.Auth030001.TradeCounterpartyReport20 *-- ISO20022.Auth030001.Counterparty46
    ISO20022.Auth030001.TradeCounterpartyReport20 *-- ISO20022.Auth030001.Counterparty45
    class ISO20022.Auth030001.TradeCounterpartyType1Code {
        ERFR = 1
        SBMA = 2
        REPC = 3
        OTHC = 4
        EXEA = 5
        CLEM = 6
        BROK = 7
        BENE = 8
    }
    class ISO20022.Auth030001.TradeData43 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth030001.SupplementaryData1~
        + PblcDssmntnData  : ISO20022.Auth030001.DisseminationData1
        + TechAttrbts  : ISO20022.Auth030001.TechnicalAttributes5
        + Lvl  : String
        + CmonTradData  : ISO20022.Auth030001.CommonTradeDataReport71
        + CtrPtySpcfcData  : global::System.Collections.Generic.List~ISO20022.Auth030001.CounterpartySpecificData36~
    }
    ISO20022.Auth030001.TradeData43 *-- ISO20022.Auth030001.SupplementaryData1
    ISO20022.Auth030001.TradeData43 *-- ISO20022.Auth030001.DisseminationData1
    ISO20022.Auth030001.TradeData43 *-- ISO20022.Auth030001.TechnicalAttributes5
    ISO20022.Auth030001.TradeData43 *-- ISO20022.Auth030001.CommonTradeDataReport71
    ISO20022.Auth030001.TradeData43 *-- ISO20022.Auth030001.CounterpartySpecificData36
    class ISO20022.Auth030001.TradeData59Choice {
        + Rpt  : global::System.Collections.Generic.List~ISO20022.Auth030001.TradeReport33Choice~
        + DataSetActn  : String
    }
    ISO20022.Auth030001.TradeData59Choice *-- ISO20022.Auth030001.TradeReport33Choice
    class ISO20022.Auth030001.TradeNonConfirmation1 {
        + Tp  : String
    }
    class ISO20022.Auth030001.TradeReport33Choice {
        + Othr  : ISO20022.Auth030001.TradeData43
        + Rvv  : ISO20022.Auth030001.TradeData43
        + PortOut  : ISO20022.Auth030001.TradeData43
        + Err  : ISO20022.Auth030001.TradeData43
        + Cmprssn  : ISO20022.Auth030001.TradeData43
        + ValtnUpd  : ISO20022.Auth030001.TradeData43
        + PosCmpnt  : ISO20022.Auth030001.TradeData43
        + Termntn  : ISO20022.Auth030001.TradeData43
        + Crrctn  : ISO20022.Auth030001.TradeData43
        + Mod  : ISO20022.Auth030001.TradeData43
        + New  : ISO20022.Auth030001.TradeData43
    }
    ISO20022.Auth030001.TradeReport33Choice *-- ISO20022.Auth030001.TradeData43
    ISO20022.Auth030001.TradeReport33Choice *-- ISO20022.Auth030001.TradeData43
    ISO20022.Auth030001.TradeReport33Choice *-- ISO20022.Auth030001.TradeData43
    ISO20022.Auth030001.TradeReport33Choice *-- ISO20022.Auth030001.TradeData43
    ISO20022.Auth030001.TradeReport33Choice *-- ISO20022.Auth030001.TradeData43
    ISO20022.Auth030001.TradeReport33Choice *-- ISO20022.Auth030001.TradeData43
    ISO20022.Auth030001.TradeReport33Choice *-- ISO20022.Auth030001.TradeData43
    ISO20022.Auth030001.TradeReport33Choice *-- ISO20022.Auth030001.TradeData43
    ISO20022.Auth030001.TradeReport33Choice *-- ISO20022.Auth030001.TradeData43
    ISO20022.Auth030001.TradeReport33Choice *-- ISO20022.Auth030001.TradeData43
    ISO20022.Auth030001.TradeReport33Choice *-- ISO20022.Auth030001.TradeData43
    class ISO20022.Auth030001.TradeReportHeader4 {
        + RptgPurp  : global::System.Collections.Generic.List~String~
        + NewTradRpstryIdr  : ISO20022.Auth030001.OrganisationIdentification15Choice
        + CmptntAuthrty  : global::System.Collections.Generic.List~String~
        + NbRcrds  : Decimal
        + MsgPgntn  : ISO20022.Auth030001.Pagination1
        + RptExctnDt  : DateTime
    }
    ISO20022.Auth030001.TradeReportHeader4 *-- ISO20022.Auth030001.OrganisationIdentification15Choice
    ISO20022.Auth030001.TradeReportHeader4 *-- ISO20022.Auth030001.Pagination1
    class ISO20022.Auth030001.TradeTransaction50 {
        + TradAllcnSts  : String
        + Packg  : ISO20022.Auth030001.Package4
        + OthrPmt  : global::System.Collections.Generic.List~ISO20022.Auth030001.OtherPayment5~
        + Cdt  : ISO20022.Auth030001.CreditDerivative4
        + NrgySpcfcAttrbts  : ISO20022.Auth030001.EnergySpecificAttribute9
        + Optn  : ISO20022.Auth030001.OptionOrSwaption11
        + Cmmdty  : ISO20022.Auth030001.AssetClassCommodity7Choice
        + Ccy  : ISO20022.Auth030001.CurrencyExchange22
        + IntrstRate  : ISO20022.Auth030001.InterestRateLegs14
        + LrgNtnlOffFcltyElctn  : String
        + BlckTradElctn  : String
        + TradClr  : ISO20022.Auth030001.TradeClearing11
        + NonStdsdTerm  : String
        + TradConf  : ISO20022.Auth030001.TradeConfirmation4Choice
        + DerivEvt  : ISO20022.Auth030001.DerivativeEvent6
        + PstTradRskRdctnEvt  : ISO20022.Auth030001.PTRREvent2
        + PstTradRskRdctnFlg  : String
        + Cmprssn  : String
        + MstrAgrmt  : ISO20022.Auth030001.MasterAgreement8
        + SttlmDt  : global::System.Collections.Generic.List~DateTime~
        + EarlyTermntnDt  : DateTime
        + XprtnDt  : DateTime
        + FctvDt  : DateTime
        + ExctnTmStmp  : DateTime
        + DlvryTp  : String
        + Qty  : ISO20022.Auth030001.FinancialInstrumentQuantity32Choice
        + NtnlQty  : ISO20022.Auth030001.NotionalQuantityLegs5
        + NtnlAmt  : ISO20022.Auth030001.NotionalAmountLegs5
        + TxPric  : ISO20022.Auth030001.PriceData2
        + MrrrOrTrggrTx  : String
        + PltfmIdr  : String
        + RptTrckgNb  : String
        + CollPrtflCd  : ISO20022.Auth030001.CollateralPortfolioCode6Choice
        + SbsqntTxId  : ISO20022.Auth030001.UniqueTransactionIdentifier3Choice
        + PrrTxId  : ISO20022.Auth030001.UniqueTransactionIdentifier3Choice
        + ScndryTxId  : String
        + TxId  : ISO20022.Auth030001.UniqueTransactionIdentifier2Choice
    }
    ISO20022.Auth030001.TradeTransaction50 *-- ISO20022.Auth030001.Package4
    ISO20022.Auth030001.TradeTransaction50 *-- ISO20022.Auth030001.OtherPayment5
    ISO20022.Auth030001.TradeTransaction50 *-- ISO20022.Auth030001.CreditDerivative4
    ISO20022.Auth030001.TradeTransaction50 *-- ISO20022.Auth030001.EnergySpecificAttribute9
    ISO20022.Auth030001.TradeTransaction50 *-- ISO20022.Auth030001.OptionOrSwaption11
    ISO20022.Auth030001.TradeTransaction50 *-- ISO20022.Auth030001.AssetClassCommodity7Choice
    ISO20022.Auth030001.TradeTransaction50 *-- ISO20022.Auth030001.CurrencyExchange22
    ISO20022.Auth030001.TradeTransaction50 *-- ISO20022.Auth030001.InterestRateLegs14
    ISO20022.Auth030001.TradeTransaction50 *-- ISO20022.Auth030001.TradeClearing11
    ISO20022.Auth030001.TradeTransaction50 *-- ISO20022.Auth030001.TradeConfirmation4Choice
    ISO20022.Auth030001.TradeTransaction50 *-- ISO20022.Auth030001.DerivativeEvent6
    ISO20022.Auth030001.TradeTransaction50 *-- ISO20022.Auth030001.PTRREvent2
    ISO20022.Auth030001.TradeTransaction50 *-- ISO20022.Auth030001.MasterAgreement8
    ISO20022.Auth030001.TradeTransaction50 *-- ISO20022.Auth030001.FinancialInstrumentQuantity32Choice
    ISO20022.Auth030001.TradeTransaction50 *-- ISO20022.Auth030001.NotionalQuantityLegs5
    ISO20022.Auth030001.TradeTransaction50 *-- ISO20022.Auth030001.NotionalAmountLegs5
    ISO20022.Auth030001.TradeTransaction50 *-- ISO20022.Auth030001.PriceData2
    ISO20022.Auth030001.TradeTransaction50 *-- ISO20022.Auth030001.CollateralPortfolioCode6Choice
    ISO20022.Auth030001.TradeTransaction50 *-- ISO20022.Auth030001.UniqueTransactionIdentifier3Choice
    ISO20022.Auth030001.TradeTransaction50 *-- ISO20022.Auth030001.UniqueTransactionIdentifier3Choice
    ISO20022.Auth030001.TradeTransaction50 *-- ISO20022.Auth030001.UniqueTransactionIdentifier2Choice
    class ISO20022.Auth030001.TradingCapacity7Code {
        PRIN = 1
        AGEN = 2
    }
    class ISO20022.Auth030001.Tranche3 {
        + DtchmntPt  : Decimal
        + AttchmntPt  : Decimal
    }
    class ISO20022.Auth030001.TrancheIndicator3Choice {
        + Utrnchd  : String
        + Trnchd  : ISO20022.Auth030001.Tranche3
    }
    ISO20022.Auth030001.TrancheIndicator3Choice *-- ISO20022.Auth030001.Tranche3
    class ISO20022.Auth030001.UnderlyingIdentification1Code {
        INDX = 1
        BSKT = 2
        UKWN = 3
    }
    class ISO20022.Auth030001.UniqueProductIdentifier1Choice {
        + Prtry  : ISO20022.Auth030001.GenericIdentification175
        + Id  : String
    }
    ISO20022.Auth030001.UniqueProductIdentifier1Choice *-- ISO20022.Auth030001.GenericIdentification175
    class ISO20022.Auth030001.UniqueProductIdentifier2Choice {
        + Prtry  : ISO20022.Auth030001.GenericIdentification185
        + Id  : String
    }
    ISO20022.Auth030001.UniqueProductIdentifier2Choice *-- ISO20022.Auth030001.GenericIdentification185
    class ISO20022.Auth030001.UniqueTransactionIdentifier1Choice {
        + Prtry  : ISO20022.Auth030001.GenericIdentification179
        + UnqTxIdr  : String
    }
    ISO20022.Auth030001.UniqueTransactionIdentifier1Choice *-- ISO20022.Auth030001.GenericIdentification179
    class ISO20022.Auth030001.UniqueTransactionIdentifier2Choice {
        + Prtry  : ISO20022.Auth030001.GenericIdentification175
        + UnqTxIdr  : String
    }
    ISO20022.Auth030001.UniqueTransactionIdentifier2Choice *-- ISO20022.Auth030001.GenericIdentification175
    class ISO20022.Auth030001.UniqueTransactionIdentifier3Choice {
        + NotAvlbl  : String
        + Prtry  : ISO20022.Auth030001.GenericIdentification175
        + UnqTxIdr  : String
    }
    ISO20022.Auth030001.UniqueTransactionIdentifier3Choice *-- ISO20022.Auth030001.GenericIdentification175
    class ISO20022.Auth030001.UnitOfMeasure8Choice {
        + Prtry  : ISO20022.Auth030001.GenericIdentification175
        + Cd  : String
    }
    ISO20022.Auth030001.UnitOfMeasure8Choice *-- ISO20022.Auth030001.GenericIdentification175
    class ISO20022.Auth030001.ValuationType1Code {
        MTMO = 1
        MTMA = 2
        CCPV = 3
    }
    class ISO20022.Auth030001.WeekDay3Code {
        WEND = 1
        WDAY = 2
        WEDD = 3
        TUED = 4
        THUD = 5
        SUND = 6
        SATD = 7
        MOND = 8
        FRID = 9
        IBHL = 10
        XBHL = 11
        ALLD = 12
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

## Value ISO20022.Auth030001.ActiveOrHistoricCurrencyAnd19DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth030001.AgreementType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Tp))|

---

## Value ISO20022.Auth030001.AgriculturalCommodityDairy2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.AgriculturalCommodityForestry2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.AgriculturalCommodityGrain3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.AgriculturalCommodityLiveStock2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.AgriculturalCommodityOilSeed2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.AgriculturalCommodityOliveOil3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.AgriculturalCommodityOther2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.AgriculturalCommodityPotato2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.AgriculturalCommoditySeafood2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.AgriculturalCommoditySoft2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth030001.AllocationIndicator1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNAL|Int32||XmlEnum("""UNAL""")|1|
||PREA|Int32||XmlEnum("""PREA""")|2|
||POST|Int32||XmlEnum("""POST""")|3|

---

## Value ISO20022.Auth030001.AmountAndDirection106


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgn|String||XmlElement()||
|+|Amt|ISO20022.Auth030001.ActiveOrHistoricCurrencyAnd19DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Auth030001.AmountAndDirection109


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgn|String||XmlElement()||
|+|Amt|ISO20022.Auth030001.ActiveOrHistoricCurrencyAnd19DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Auth030001.AssetClassCommodity7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Plprpln|ISO20022.Auth030001.AssetClassCommodityPolypropylene4Choice||XmlElement()||
|+|Ppr|ISO20022.Auth030001.AssetClassCommodityPaper5Choice||XmlElement()||
|+|OthrC10|ISO20022.Auth030001.AssetClassCommodityC10Other1||XmlElement()||
|+|Othr|ISO20022.Auth030001.AssetClassCommodityOther1||XmlElement()||
|+|OffclEcnmcSttstcs|ISO20022.Auth030001.AssetClassCommodityOfficialEconomicStatistics1||XmlElement()||
|+|MultiCmmdtyExtc|ISO20022.Auth030001.AssetClassCommodityMultiCommodityExotic1||XmlElement()||
|+|Metl|ISO20022.Auth030001.AssetClassCommodityMetal2Choice||XmlElement()||
|+|Infltn|ISO20022.Auth030001.AssetClassCommodityInflation1||XmlElement()||
|+|IndstrlPdct|ISO20022.Auth030001.AssetClassCommodityIndustrialProduct2Choice||XmlElement()||
|+|Indx|ISO20022.Auth030001.AssetClassCommodityIndex1||XmlElement()||
|+|Frght|ISO20022.Auth030001.AssetClassCommodityFreight4Choice||XmlElement()||
|+|Frtlzr|ISO20022.Auth030001.AssetClassCommodityFertilizer4Choice||XmlElement()||
|+|Envttl|ISO20022.Auth030001.AssetClassCommodityEnvironmental3Choice||XmlElement()||
|+|Nrgy|ISO20022.Auth030001.AssetClassCommodityEnergy3Choice||XmlElement()||
|+|Agrcltrl|ISO20022.Auth030001.AssetClassCommodityAgricultural6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Plprpln),validElement(Ppr),validElement(OthrC10),validElement(Othr),validElement(OffclEcnmcSttstcs),validElement(MultiCmmdtyExtc),validElement(Metl),validElement(Infltn),validElement(IndstrlPdct),validElement(Indx),validElement(Frght),validElement(Frtlzr),validElement(Envttl),validElement(Nrgy),validElement(Agrcltrl),validChoice(Plprpln,Ppr,OthrC10,Othr,OffclEcnmcSttstcs,MultiCmmdtyExtc,Metl,Infltn,IndstrlPdct,Indx,Frght,Frtlzr,Envttl,Nrgy,Agrcltrl))|

---

## Value ISO20022.Auth030001.AssetClassCommodityAgricultural6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth030001.AgriculturalCommodityOther2||XmlElement()||
|+|Grn|ISO20022.Auth030001.AgriculturalCommodityGrain3||XmlElement()||
|+|LiveStock|ISO20022.Auth030001.AgriculturalCommodityLiveStock2||XmlElement()||
|+|Sfd|ISO20022.Auth030001.AgriculturalCommoditySeafood2||XmlElement()||
|+|Frstry|ISO20022.Auth030001.AgriculturalCommodityForestry2||XmlElement()||
|+|Dairy|ISO20022.Auth030001.AgriculturalCommodityDairy2||XmlElement()||
|+|OlvOil|ISO20022.Auth030001.AgriculturalCommodityOliveOil3||XmlElement()||
|+|Ptt|ISO20022.Auth030001.AgriculturalCommodityPotato2||XmlElement()||
|+|Soft|ISO20022.Auth030001.AgriculturalCommoditySoft2||XmlElement()||
|+|GrnOilSeed|ISO20022.Auth030001.AgriculturalCommodityOilSeed2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(Grn),validElement(LiveStock),validElement(Sfd),validElement(Frstry),validElement(Dairy),validElement(OlvOil),validElement(Ptt),validElement(Soft),validElement(GrnOilSeed),validChoice(Othr,Grn,LiveStock,Sfd,Frstry,Dairy,OlvOil,Ptt,Soft,GrnOilSeed))|

---

## Value ISO20022.Auth030001.AssetClassCommodityC10Other1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.AssetClassCommodityEnergy3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth030001.EnergyCommodityOther2||XmlElement()||
|+|Dstllts|ISO20022.Auth030001.EnergyCommodityDistillates2||XmlElement()||
|+|LghtEnd|ISO20022.Auth030001.EnergyCommodityLightEnd2||XmlElement()||
|+|RnwblNrgy|ISO20022.Auth030001.EnergyCommodityRenewableEnergy2||XmlElement()||
|+|IntrNrgy|ISO20022.Auth030001.EnergyCommodityInterEnergy2||XmlElement()||
|+|Coal|ISO20022.Auth030001.EnergyCommodityCoal2||XmlElement()||
|+|Oil|ISO20022.Auth030001.EnergyCommodityOil3||XmlElement()||
|+|NtrlGas|ISO20022.Auth030001.EnergyCommodityNaturalGas3||XmlElement()||
|+|Elctrcty|ISO20022.Auth030001.EnergyCommodityElectricity2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(Dstllts),validElement(LghtEnd),validElement(RnwblNrgy),validElement(IntrNrgy),validElement(Coal),validElement(Oil),validElement(NtrlGas),validElement(Elctrcty),validChoice(Othr,Dstllts,LghtEnd,RnwblNrgy,IntrNrgy,Coal,Oil,NtrlGas,Elctrcty))|

---

## Value ISO20022.Auth030001.AssetClassCommodityEnvironmental3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth030001.EnvironmentCommodityOther2||XmlElement()||
|+|CrbnRltd|ISO20022.Auth030001.EnvironmentalCommodityCarbonRelated2||XmlElement()||
|+|Wthr|ISO20022.Auth030001.EnvironmentalCommodityWeather2||XmlElement()||
|+|Emssns|ISO20022.Auth030001.EnvironmentalCommodityEmission3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(CrbnRltd),validElement(Wthr),validElement(Emssns),validChoice(Othr,CrbnRltd,Wthr,Emssns))|

---

## Value ISO20022.Auth030001.AssetClassCommodityFertilizer4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth030001.FertilizerCommodityOther2||XmlElement()||
|+|UreaAndAmmnmNtrt|ISO20022.Auth030001.FertilizerCommodityUreaAndAmmoniumNitrate2||XmlElement()||
|+|Urea|ISO20022.Auth030001.FertilizerCommodityUrea2||XmlElement()||
|+|Slphr|ISO20022.Auth030001.FertilizerCommoditySulphur2||XmlElement()||
|+|Ptsh|ISO20022.Auth030001.FertilizerCommodityPotash2||XmlElement()||
|+|DmmnmPhspht|ISO20022.Auth030001.FertilizerCommodityDiammoniumPhosphate2||XmlElement()||
|+|Ammn|ISO20022.Auth030001.FertilizerCommodityAmmonia2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(UreaAndAmmnmNtrt),validElement(Urea),validElement(Slphr),validElement(Ptsh),validElement(DmmnmPhspht),validElement(Ammn),validChoice(Othr,UreaAndAmmnmNtrt,Urea,Slphr,Ptsh,DmmnmPhspht,Ammn))|

---

## Value ISO20022.Auth030001.AssetClassCommodityFreight4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth030001.FreightCommodityOther2||XmlElement()||
|+|CntnrShip|ISO20022.Auth030001.FreightCommodityContainerShip2||XmlElement()||
|+|Wet|ISO20022.Auth030001.FreightCommodityWet3||XmlElement()||
|+|Dry|ISO20022.Auth030001.FreightCommodityDry3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(CntnrShip),validElement(Wet),validElement(Dry),validChoice(Othr,CntnrShip,Wet,Dry))|

---

## Value ISO20022.Auth030001.AssetClassCommodityIndex1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.AssetClassCommodityIndustrialProduct2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Manfctg|ISO20022.Auth030001.IndustrialProductCommodityManufacturing2||XmlElement()||
|+|Cnstrctn|ISO20022.Auth030001.IndustrialProductCommodityConstruction2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Manfctg),validElement(Cnstrctn),validChoice(Manfctg,Cnstrctn))|

---

## Value ISO20022.Auth030001.AssetClassCommodityInflation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.AssetClassCommodityMetal2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prcs|ISO20022.Auth030001.MetalCommodityPrecious2||XmlElement()||
|+|NonPrcs|ISO20022.Auth030001.MetalCommodityNonPrecious2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prcs),validElement(NonPrcs),validChoice(Prcs,NonPrcs))|

---

## Value ISO20022.Auth030001.AssetClassCommodityMultiCommodityExotic1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.AssetClassCommodityOfficialEconomicStatistics1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.AssetClassCommodityOther1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.AssetClassCommodityPaper5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth030001.PaperCommodityOther1||XmlElement()||
|+|RcvrdPpr|ISO20022.Auth030001.PaperCommodityRecoveredPaper3||XmlElement()||
|+|Pulp|ISO20022.Auth030001.PaperCommodityPulp2||XmlElement()||
|+|Nwsprnt|ISO20022.Auth030001.PaperCommodityNewsprint2||XmlElement()||
|+|CntnrBrd|ISO20022.Auth030001.PaperCommodityContainerBoard2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(RcvrdPpr),validElement(Pulp),validElement(Nwsprnt),validElement(CntnrBrd),validChoice(Othr,RcvrdPpr,Pulp,Nwsprnt,CntnrBrd))|

---

## Value ISO20022.Auth030001.AssetClassCommodityPolypropylene4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth030001.PolypropyleneCommodityOther2||XmlElement()||
|+|Plstc|ISO20022.Auth030001.PolypropyleneCommodityPlastic2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(Plstc),validChoice(Othr,Plstc))|

---

## Enum ISO20022.Auth030001.AssetClassDetailedSubProductType10Code


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

## Enum ISO20022.Auth030001.AssetClassDetailedSubProductType11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SLVR|Int32||XmlEnum("""SLVR""")|1|
||PTNM|Int32||XmlEnum("""PTNM""")|2|
||PLDM|Int32||XmlEnum("""PLDM""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||GOLD|Int32||XmlEnum("""GOLD""")|5|

---

## Enum ISO20022.Auth030001.AssetClassDetailedSubProductType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RICE|Int32||XmlEnum("""RICE""")|1|
||CORN|Int32||XmlEnum("""CORN""")|2|
||OTHR|Int32||XmlEnum("""OTHR""")|3|
||RPSD|Int32||XmlEnum("""RPSD""")|4|
||SOYB|Int32||XmlEnum("""SOYB""")|5|
||FWHT|Int32||XmlEnum("""FWHT""")|6|

---

## Enum ISO20022.Auth030001.AssetClassDetailedSubProductType29Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||LAMP|Int32||XmlEnum("""LAMP""")|2|

---

## Enum ISO20022.Auth030001.AssetClassDetailedSubProductType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||WHSG|Int32||XmlEnum("""WHSG""")|2|
||BRWN|Int32||XmlEnum("""BRWN""")|3|
||CCOA|Int32||XmlEnum("""CCOA""")|4|
||ROBU|Int32||XmlEnum("""ROBU""")|5|

---

## Enum ISO20022.Auth030001.AssetClassDetailedSubProductType30Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||MWHT|Int32||XmlEnum("""MWHT""")|2|

---

## Enum ISO20022.Auth030001.AssetClassDetailedSubProductType31Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||NBPG|Int32||XmlEnum("""NBPG""")|2|
||TTFG|Int32||XmlEnum("""TTFG""")|3|
||NCGG|Int32||XmlEnum("""NCGG""")|4|
||LNGG|Int32||XmlEnum("""LNGG""")|5|
||GASP|Int32||XmlEnum("""GASP""")|6|

---

## Enum ISO20022.Auth030001.AssetClassDetailedSubProductType32Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||URAL|Int32||XmlEnum("""URAL""")|2|
||WTIO|Int32||XmlEnum("""WTIO""")|3|
||TAPI|Int32||XmlEnum("""TAPI""")|4|
||NGLO|Int32||XmlEnum("""NGLO""")|5|
||NAPH|Int32||XmlEnum("""NAPH""")|6|
||MARS|Int32||XmlEnum("""MARS""")|7|
||LLSO|Int32||XmlEnum("""LLSO""")|8|
||KERO|Int32||XmlEnum("""KERO""")|9|
||JTFL|Int32||XmlEnum("""JTFL""")|10|
||HEAT|Int32||XmlEnum("""HEAT""")|11|
||GSLN|Int32||XmlEnum("""GSLN""")|12|
||GOIL|Int32||XmlEnum("""GOIL""")|13|
||FOIL|Int32||XmlEnum("""FOIL""")|14|
||FUEL|Int32||XmlEnum("""FUEL""")|15|
||ETHA|Int32||XmlEnum("""ETHA""")|16|
||ESPO|Int32||XmlEnum("""ESPO""")|17|
||DUBA|Int32||XmlEnum("""DUBA""")|18|
||DSEL|Int32||XmlEnum("""DSEL""")|19|
||COND|Int32||XmlEnum("""COND""")|20|
||CNDA|Int32||XmlEnum("""CNDA""")|21|
||BRNX|Int32||XmlEnum("""BRNX""")|22|
||BRNT|Int32||XmlEnum("""BRNT""")|23|
||BDSL|Int32||XmlEnum("""BDSL""")|24|
||BAKK|Int32||XmlEnum("""BAKK""")|25|

---

## Enum ISO20022.Auth030001.AssetClassDetailedSubProductType33Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||DBCR|Int32||XmlEnum("""DBCR""")|2|

---

## Enum ISO20022.Auth030001.AssetClassDetailedSubProductType34Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||TNKR|Int32||XmlEnum("""TNKR""")|2|

---

## Enum ISO20022.Auth030001.AssetClassDetailedSubProductType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||OFFP|Int32||XmlEnum("""OFFP""")|2|
||PKLD|Int32||XmlEnum("""PKLD""")|3|
||FITR|Int32||XmlEnum("""FITR""")|4|
||BSLD|Int32||XmlEnum("""BSLD""")|5|

---

## Enum ISO20022.Auth030001.AssetClassDetailedSubProductType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||EUAA|Int32||XmlEnum("""EUAA""")|2|
||EUAE|Int32||XmlEnum("""EUAE""")|3|
||ERUE|Int32||XmlEnum("""ERUE""")|4|
||CERE|Int32||XmlEnum("""CERE""")|5|

---

## Enum ISO20022.Auth030001.AssetClassProductType11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHC|Int32||XmlEnum("""OTHC""")|1|

---

## Enum ISO20022.Auth030001.AssetClassProductType12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFL|Int32||XmlEnum("""INFL""")|1|

---

## Enum ISO20022.Auth030001.AssetClassProductType13Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MCEX|Int32||XmlEnum("""MCEX""")|1|

---

## Enum ISO20022.Auth030001.AssetClassProductType14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OEST|Int32||XmlEnum("""OEST""")|1|

---

## Enum ISO20022.Auth030001.AssetClassProductType15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|

---

## Enum ISO20022.Auth030001.AssetClassProductType16Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDX|Int32||XmlEnum("""INDX""")|1|

---

## Enum ISO20022.Auth030001.AssetClassProductType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGRI|Int32||XmlEnum("""AGRI""")|1|

---

## Enum ISO20022.Auth030001.AssetClassProductType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NRGY|Int32||XmlEnum("""NRGY""")|1|

---

## Enum ISO20022.Auth030001.AssetClassProductType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ENVR|Int32||XmlEnum("""ENVR""")|1|

---

## Enum ISO20022.Auth030001.AssetClassProductType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRGT|Int32||XmlEnum("""FRGT""")|1|

---

## Enum ISO20022.Auth030001.AssetClassProductType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRTL|Int32||XmlEnum("""FRTL""")|1|

---

## Enum ISO20022.Auth030001.AssetClassProductType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDP|Int32||XmlEnum("""INDP""")|1|

---

## Enum ISO20022.Auth030001.AssetClassProductType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||METL|Int32||XmlEnum("""METL""")|1|

---

## Enum ISO20022.Auth030001.AssetClassProductType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PAPR|Int32||XmlEnum("""PAPR""")|1|

---

## Enum ISO20022.Auth030001.AssetClassProductType9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||POLY|Int32||XmlEnum("""POLY""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EMIS|Int32||XmlEnum("""EMIS""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NPRM|Int32||XmlEnum("""NPRM""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType16Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRME|Int32||XmlEnum("""PRME""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType18Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PLST|Int32||XmlEnum("""PLST""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GROS|Int32||XmlEnum("""GROS""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType20Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DIRY|Int32||XmlEnum("""DIRY""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType21Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRST|Int32||XmlEnum("""FRST""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType22Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LSTK|Int32||XmlEnum("""LSTK""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType23Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SEAF|Int32||XmlEnum("""SEAF""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType24Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||COAL|Int32||XmlEnum("""COAL""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType25Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DIST|Int32||XmlEnum("""DIST""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType26Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INRG|Int32||XmlEnum("""INRG""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType27Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LGHT|Int32||XmlEnum("""LGHT""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType28Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RNNG|Int32||XmlEnum("""RNNG""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType29Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CRBR|Int32||XmlEnum("""CRBR""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SOFT|Int32||XmlEnum("""SOFT""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType30Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WTHR|Int32||XmlEnum("""WTHR""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType31Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DRYF|Int32||XmlEnum("""DRYF""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType32Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WETF|Int32||XmlEnum("""WETF""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType33Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CSTR|Int32||XmlEnum("""CSTR""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType34Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MFTG|Int32||XmlEnum("""MFTG""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType35Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CBRD|Int32||XmlEnum("""CBRD""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType36Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NSPT|Int32||XmlEnum("""NSPT""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType37Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PULP|Int32||XmlEnum("""PULP""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType39Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AMMO|Int32||XmlEnum("""AMMO""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OOLI|Int32||XmlEnum("""OOLI""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType40Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DAPH|Int32||XmlEnum("""DAPH""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType41Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PTSH|Int32||XmlEnum("""PTSH""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType42Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SLPH|Int32||XmlEnum("""SLPH""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType43Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UREA|Int32||XmlEnum("""UREA""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType44Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UAAN|Int32||XmlEnum("""UAAN""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType45Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||POTA|Int32||XmlEnum("""POTA""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType46Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CSHP|Int32||XmlEnum("""CSHP""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType49Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType50Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RCVP|Int32||XmlEnum("""RCVP""")|1|
||OTHR|Int32||XmlEnum("""OTHR""")|2|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GRIN|Int32||XmlEnum("""GRIN""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ELEC|Int32||XmlEnum("""ELEC""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NGAS|Int32||XmlEnum("""NGAS""")|1|

---

## Enum ISO20022.Auth030001.AssetClassSubProductType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OILP|Int32||XmlEnum("""OILP""")|1|

---

## Value ISO20022.Auth030001.BasketConstituents3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UnitOfMeasr|ISO20022.Auth030001.UnitOfMeasure8Choice||XmlElement()||
|+|Qty|Decimal||XmlElement()||
|+|InstrmId|ISO20022.Auth030001.InstrumentIdentification6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UnitOfMeasr),validElement(InstrmId))|

---

## Value ISO20022.Auth030001.Cleared23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NonClrd|ISO20022.Auth030001.ClearingExceptionOrExemption3Choice||XmlElement()||
|+|IntndToClear|ISO20022.Auth030001.ClearingPartyAndTime22Choice||XmlElement()||
|+|Clrd|ISO20022.Auth030001.ClearingPartyAndTime21Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NonClrd),validElement(IntndToClear),validElement(Clrd),validChoice(NonClrd,IntndToClear,Clrd))|

---

## Enum ISO20022.Auth030001.ClearingAccountType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HOUS|Int32||XmlEnum("""HOUS""")|1|
||CLIE|Int32||XmlEnum("""CLIE""")|2|

---

## Value ISO20022.Auth030001.ClearingExceptionOrExemption2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrCtrPty|ISO20022.Auth030001.NonClearingReason2||XmlElement()||
|+|RptgCtrPty|ISO20022.Auth030001.NonClearingReason2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrCtrPty),validElement(RptgCtrPty))|

---

## Value ISO20022.Auth030001.ClearingExceptionOrExemption3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtrPties|ISO20022.Auth030001.ClearingExceptionOrExemption2||XmlElement()||
|+|Rsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtrPties),validChoice(CtrPties,Rsn))|

---

## Enum ISO20022.Auth030001.ClearingExemptionException1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SMBK|Int32||XmlEnum("""SMBK""")|1|
||OTHR|Int32||XmlEnum("""OTHR""")|2|
||NORE|Int32||XmlEnum("""NORE""")|3|
||NOAL|Int32||XmlEnum("""NOAL""")|4|
||AFFL|Int32||XmlEnum("""AFFL""")|5|
||ENDU|Int32||XmlEnum("""ENDU""")|6|
||COOP|Int32||XmlEnum("""COOP""")|7|

---

## Enum ISO20022.Auth030001.ClearingObligationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRUE|Int32||XmlEnum("""TRUE""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|
||FLSE|Int32||XmlEnum("""FLSE""")|3|

---

## Value ISO20022.Auth030001.ClearingPartyAndTime21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dtls|ISO20022.Auth030001.ClearingPartyAndTime22||XmlElement()||
|+|Rsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Dtls),validChoice(Dtls,Rsn))|

---

## Value ISO20022.Auth030001.ClearingPartyAndTime22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClrAcctOrgn|String||XmlElement()||
|+|OrgnlTradRpstryIdr|ISO20022.Auth030001.OrganisationIdentification15Choice||XmlElement()||
|+|OrgnlIdr|ISO20022.Auth030001.UniqueTransactionIdentifier2Choice||XmlElement()||
|+|ClrIdr|ISO20022.Auth030001.UniqueTransactionIdentifier2Choice||XmlElement()||
|+|ClrDtTm|DateTime||XmlElement()||
|+|ClrRctDtTm|DateTime||XmlElement()||
|+|CCP|ISO20022.Auth030001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlTradRpstryIdr),validElement(OrgnlIdr),validElement(ClrIdr),validElement(CCP))|

---

## Value ISO20022.Auth030001.ClearingPartyAndTime22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dtls|ISO20022.Auth030001.ClearingPartyAndTime23||XmlElement()||
|+|Rsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Dtls),validChoice(Dtls,Rsn))|

---

## Value ISO20022.Auth030001.ClearingPartyAndTime23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlTradRpstryIdr|ISO20022.Auth030001.OrganisationIdentification15Choice||XmlElement()||
|+|OrgnlIdr|ISO20022.Auth030001.UniqueTransactionIdentifier1Choice||XmlElement()||
|+|ClrIdr|ISO20022.Auth030001.UniqueTransactionIdentifier1Choice||XmlElement()||
|+|ClrDtTm|DateTime||XmlElement()||
|+|ClrRctDtTm|DateTime||XmlElement()||
|+|CCP|ISO20022.Auth030001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlTradRpstryIdr),validElement(OrgnlIdr),validElement(ClrIdr),validElement(CCP))|

---

## Value ISO20022.Auth030001.CollateralPortfolioCode6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MrgnPrtflCd|ISO20022.Auth030001.MarginPortfolio4||XmlElement()||
|+|Prtfl|ISO20022.Auth030001.PortfolioCode3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MrgnPrtflCd),validElement(Prtfl),validChoice(MrgnPrtflCd,Prtfl))|

---

## Value ISO20022.Auth030001.CommonTradeDataReport71


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxData|ISO20022.Auth030001.TradeTransaction50||XmlElement()||
|+|CtrctData|ISO20022.Auth030001.ContractType15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TxData),validElement(CtrctData))|

---

## Value ISO20022.Auth030001.ContractType15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivBasedOnCrptAsst|String||XmlElement()||
|+|PlcOfSttlm|String||XmlElement()||
|+|SttlmCcyScndLeg|ISO20022.Auth030001.CurrencyExchange23||XmlElement()||
|+|SttlmCcy|ISO20022.Auth030001.CurrencyExchange23||XmlElement()||
|+|UndrlygAsstPricSrc|String||XmlElement()||
|+|UndrlygAsstTradgPltfmIdr|String||XmlElement()||
|+|UndrlygInstrm|ISO20022.Auth030001.SecurityIdentification41Choice||XmlElement()||
|+|PdctId|ISO20022.Auth030001.SecurityIdentification46||XmlElement()||
|+|PdctClssfctn|String||XmlElement()||
|+|AsstClss|String||XmlElement()||
|+|CtrctTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PlcOfSttlm""",PlcOfSttlm,"""[A-Z]{2,2}"""),validElement(SttlmCcyScndLeg),validElement(SttlmCcy),validPattern("""UndrlygAsstTradgPltfmIdr""",UndrlygAsstTradgPltfmIdr,"""[A-Z0-9]{4,4}"""),validElement(UndrlygInstrm),validElement(PdctId),validPattern("""PdctClssfctn""",PdctClssfctn,"""[A-Z]{6,6}"""))|

---

## Value ISO20022.Auth030001.ContractValuationData8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dlta|Decimal||XmlElement()||
|+|Tp|String||XmlElement()||
|+|TmStmp|DateTime||XmlElement()||
|+|CtrctVal|ISO20022.Auth030001.AmountAndDirection109||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtrctVal))|

---

## Value ISO20022.Auth030001.Counterparty45


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RptgXmptn|ISO20022.Auth030001.ReportingExemption1||XmlElement()||
|+|BookgLctn|String||XmlElement()||
|+|TradrLctn|String||XmlElement()||
|+|DrctnOrSd|ISO20022.Auth030001.Direction4Choice||XmlElement()||
|+|TradgCpcty|String||XmlElement()||
|+|Ntr|ISO20022.Auth030001.CounterpartyTradeNature15Choice||XmlElement()||
|+|Id|ISO20022.Auth030001.PartyIdentification248Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RptgXmptn),validPattern("""BookgLctn""",BookgLctn,"""[A-Z]{2,2}"""),validPattern("""TradrLctn""",TradrLctn,"""[A-Z]{2,2}"""),validElement(DrctnOrSd),validElement(Ntr),validElement(Id))|

---

## Value ISO20022.Auth030001.Counterparty46


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RptgOblgtn|String||XmlElement()||
|+|Ntr|ISO20022.Auth030001.CounterpartyTradeNature15Choice||XmlElement()||
|+|IdTp|ISO20022.Auth030001.PartyIdentification248Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ntr),validElement(IdTp))|

---

## Value ISO20022.Auth030001.CounterpartySpecificData36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RptgTmStmp|DateTime||XmlElement()||
|+|Valtn|ISO20022.Auth030001.ContractValuationData8||XmlElement()||
|+|CtrPty|ISO20022.Auth030001.TradeCounterpartyReport20||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Valtn),validElement(CtrPty))|

---

## Value ISO20022.Auth030001.CounterpartyTradeNature15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|String||XmlElement()||
|+|CntrlCntrPty|String||XmlElement()||
|+|NFI|ISO20022.Auth030001.NonFinancialInstitutionSector10||XmlElement()||
|+|FI|ISO20022.Auth030001.FinancialInstitutionSector1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NFI),validElement(FI),validChoice(Othr,CntrlCntrPty,NFI,FI))|

---

## Value ISO20022.Auth030001.CreditDerivative4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Trch|ISO20022.Auth030001.TrancheIndicator3Choice||XmlElement()||
|+|IndxFctr|Decimal||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
|+|Srs|Decimal||XmlElement()||
|+|ClctnBsis|String||XmlElement()||
|+|PmtFrqcy|String||XmlElement()||
|+|RefPty|ISO20022.Auth030001.DerivativePartyIdentification1Choice||XmlElement()||
|+|Snrty|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Trch),validElement(RefPty))|

---

## Value ISO20022.Auth030001.CurrencyExchange22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FxgDt|DateTime||XmlElement()||
|+|XchgRateBsis|ISO20022.Auth030001.ExchangeRateBasis1Choice||XmlElement()||
|+|FwdXchgRate|Decimal||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|DlvrblCrossCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(XchgRateBsis),validPattern("""DlvrblCrossCcy""",DlvrblCrossCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth030001.CurrencyExchange23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FxgDt|DateTime||XmlElement()||
|+|XchgRateBsis|ISO20022.Auth030001.ExchangeRateBasis1Choice||XmlElement()||
|+|FwdXchgRate|Decimal||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|Ccy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(XchgRateBsis),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth030001.CustomBasket4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cnsttnts|global::System.Collections.Generic.List<ISO20022.Auth030001.BasketConstituents3>||XmlElement()||
|+|Id|String||XmlElement()||
|+|Strr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Cnsttnts""",Cnsttnts),validElement(Cnsttnts),validPattern("""Strr""",Strr,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Auth030001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Auth030001.DatePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth030001.DebtInstrumentSeniorityType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||SNDB|Int32||XmlEnum("""SNDB""")|2|
||SBOD|Int32||XmlEnum("""SBOD""")|3|

---

## Value ISO20022.Auth030001.DeliveryInterconnectionPoint1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Cd""",Cd,"""[A-Z0-9\-]{16}"""),validChoice(Prtry,Cd))|

---

## Value ISO20022.Auth030001.DerivativeEvent6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmdmntInd|String||XmlElement()||
|+|TmStmp|ISO20022.Auth030001.DateAndDateTime2Choice||XmlElement()||
|+|Id|ISO20022.Auth030001.EventIdentifier1Choice||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TmStmp),validElement(Id))|

---

## Enum ISO20022.Auth030001.DerivativeEventType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UPDT|Int32||XmlEnum("""UPDT""")|1|
||TRAD|Int32||XmlEnum("""TRAD""")|2|
||PTNG|Int32||XmlEnum("""PTNG""")|3|
||NOVA|Int32||XmlEnum("""NOVA""")|4|
||INCP|Int32||XmlEnum("""INCP""")|5|
||EXER|Int32||XmlEnum("""EXER""")|6|
||ETRM|Int32||XmlEnum("""ETRM""")|7|
||CREV|Int32||XmlEnum("""CREV""")|8|
||CORP|Int32||XmlEnum("""CORP""")|9|
||COMP|Int32||XmlEnum("""COMP""")|10|
||CLAL|Int32||XmlEnum("""CLAL""")|11|
||CLRG|Int32||XmlEnum("""CLRG""")|12|
||ALOC|Int32||XmlEnum("""ALOC""")|13|

---

## Value ISO20022.Auth030001.DerivativePartyIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|Ctry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""CtrySubDvsn""",CtrySubDvsn,"""[A-Z]{2,2}\-[0-9A-Z]{1,3}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validChoice(LEI,CtrySubDvsn,Ctry))|

---

## Aspect ISO20022.Auth030001.DerivativesTradeReportV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth030001.SupplementaryData1>||XmlElement()||
|+|TradData|ISO20022.Auth030001.TradeData59Choice||XmlElement()||
|+|RptHdr|ISO20022.Auth030001.TradeReportHeader4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TradData),validElement(RptHdr))|

---

## Value ISO20022.Auth030001.Direction2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DrctnOfTheScndLeg|String||XmlElement()||
|+|DrctnOfTheFrstLeg|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.Direction4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtrPtySd|String||XmlElement()||
|+|Drctn|ISO20022.Auth030001.Direction2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Drctn),validChoice(CtrPtySd,Drctn))|

---

## Value ISO20022.Auth030001.DisseminationData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TmStmp|DateTime||XmlElement()||
|+|OrgnlDssmntnIdr|String||XmlElement()||
|+|DssmntnIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Type ISO20022.Auth030001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivsTradRpt|ISO20022.Auth030001.DerivativesTradeReportV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DerivsTradRpt))|

---

## Enum ISO20022.Auth030001.DurationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||DASD|Int32||XmlEnum("""DASD""")|2|
||HOUR|Int32||XmlEnum("""HOUR""")|3|
||MNUT|Int32||XmlEnum("""MNUT""")|4|
||MNTH|Int32||XmlEnum("""MNTH""")|5|
||QURT|Int32||XmlEnum("""QURT""")|6|
||SEAS|Int32||XmlEnum("""SEAS""")|7|
||WEEK|Int32||XmlEnum("""WEEK""")|8|
||YEAR|Int32||XmlEnum("""YEAR""")|9|

---

## Enum ISO20022.Auth030001.EmbeddedType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MDET|Int32||XmlEnum("""MDET""")|1|
||OTHR|Int32||XmlEnum("""OTHR""")|2|
||OPET|Int32||XmlEnum("""OPET""")|3|
||EXTD|Int32||XmlEnum("""EXTD""")|4|
||CANC|Int32||XmlEnum("""CANC""")|5|

---

## Value ISO20022.Auth030001.EnergyCommodityCoal2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.EnergyCommodityDistillates2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.EnergyCommodityElectricity2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.EnergyCommodityInterEnergy2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.EnergyCommodityLightEnd2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.EnergyCommodityNaturalGas3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.EnergyCommodityOil3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.EnergyCommodityOther2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.EnergyCommodityRenewableEnergy2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.EnergyDeliveryAttribute10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricTmIntrvlQty|ISO20022.Auth030001.AmountAndDirection106||XmlElement()||
|+|QtyUnit|ISO20022.Auth030001.EnergyQuantityUnit2Choice||XmlElement()||
|+|DlvryCpcty|ISO20022.Auth030001.Quantity47Choice||XmlElement()||
|+|WkDay|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Drtn|String||XmlElement()||
|+|DlvryDt|ISO20022.Auth030001.DatePeriod1||XmlElement()||
|+|DlvryIntrvl|global::System.Collections.Generic.List<ISO20022.Auth030001.TimePeriodDetails1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricTmIntrvlQty),validElement(QtyUnit),validElement(DlvryCpcty),validElement(DlvryDt),validList("""DlvryIntrvl""",DlvryIntrvl),validElement(DlvryIntrvl))|

---

## Enum ISO20022.Auth030001.EnergyLoadType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHPD|Int32||XmlEnum("""SHPD""")|1|
||PKLD|Int32||XmlEnum("""PKLD""")|2|
||OTHR|Int32||XmlEnum("""OTHR""")|3|
||OFFP|Int32||XmlEnum("""OFFP""")|4|
||HABH|Int32||XmlEnum("""HABH""")|5|
||GASD|Int32||XmlEnum("""GASD""")|6|
||BSLD|Int32||XmlEnum("""BSLD""")|7|

---

## Value ISO20022.Auth030001.EnergyQuantityUnit2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Auth030001.EnergyQuantityUnit2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||THMD|Int32||XmlEnum("""THMD""")|1|
||MWHH|Int32||XmlEnum("""MWHH""")|2|
||MWHD|Int32||XmlEnum("""MWHD""")|3|
||MWAT|Int32||XmlEnum("""MWAT""")|4|
||MTMD|Int32||XmlEnum("""MTMD""")|5|
||MMJD|Int32||XmlEnum("""MMJD""")|6|
||MBTD|Int32||XmlEnum("""MBTD""")|7|
||MJDD|Int32||XmlEnum("""MJDD""")|8|
||MCMD|Int32||XmlEnum("""MCMD""")|9|
||KWHH|Int32||XmlEnum("""KWHH""")|10|
||KWHD|Int32||XmlEnum("""KWHD""")|11|
||KWAT|Int32||XmlEnum("""KWAT""")|12|
||KTMD|Int32||XmlEnum("""KTMD""")|13|
||HMJD|Int32||XmlEnum("""HMJD""")|14|
||GWHH|Int32||XmlEnum("""GWHH""")|15|
||GWHD|Int32||XmlEnum("""GWHD""")|16|
||GWAT|Int32||XmlEnum("""GWAT""")|17|
||GJDD|Int32||XmlEnum("""GJDD""")|18|
||CMPD|Int32||XmlEnum("""CMPD""")|19|
||BTUD|Int32||XmlEnum("""BTUD""")|20|

---

## Value ISO20022.Auth030001.EnergySpecificAttribute9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DlvryAttr|global::System.Collections.Generic.List<ISO20022.Auth030001.EnergyDeliveryAttribute10>||XmlElement()||
|+|LdTp|String||XmlElement()||
|+|IntrCnnctnPt|ISO20022.Auth030001.DeliveryInterconnectionPoint1Choice||XmlElement()||
|+|DlvryPtOrZone|global::System.Collections.Generic.List<ISO20022.Auth030001.DeliveryInterconnectionPoint1Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""DlvryAttr""",DlvryAttr),validElement(DlvryAttr),validElement(IntrCnnctnPt),validList("""DlvryPtOrZone""",DlvryPtOrZone),validElement(DlvryPtOrZone))|

---

## Value ISO20022.Auth030001.EnvironmentCommodityOther2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.EnvironmentalCommodityCarbonRelated2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.EnvironmentalCommodityEmission3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.EnvironmentalCommodityWeather2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.EventIdentifier1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstTradRskRdctnIdr|ISO20022.Auth030001.PostTradeRiskReductionIdentifier1||XmlElement()||
|+|EvtIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstTradRskRdctnIdr),validPattern("""EvtIdr""",EvtIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""),validChoice(PstTradRskRdctnIdr,EvtIdr))|

---

## Value ISO20022.Auth030001.ExchangeRateBasis1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtdCcy|String||XmlElement()||
|+|BaseCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""BaseCcy""",BaseCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth030001.ExchangeRateBasis1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|CcyPair|ISO20022.Auth030001.ExchangeRateBasis1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CcyPair),validChoice(Prtry,CcyPair))|

---

## Value ISO20022.Auth030001.ExerciseDate1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PdgDtAplbl|String||XmlElement()||
|+|FrstExrcDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(PdgDtAplbl,FrstExrcDt))|

---

## Value ISO20022.Auth030001.FertilizerCommodityAmmonia2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.FertilizerCommodityDiammoniumPhosphate2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.FertilizerCommodityOther2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.FertilizerCommodityPotash2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.FertilizerCommoditySulphur2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.FertilizerCommodityUrea2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.FertilizerCommodityUreaAndAmmoniumNitrate2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.FinancialInstitutionSector1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClrThrshld|String||XmlElement()||
|+|Sctr|global::System.Collections.Generic.List<ISO20022.Auth030001.FinancialPartyClassification2Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Sctr""",Sctr),validList("""Sctr""",Sctr),validElement(Sctr))|

---

## Enum ISO20022.Auth030001.FinancialInstrumentContractType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||SWPT|Int32||XmlEnum("""SWPT""")|2|
||SWAP|Int32||XmlEnum("""SWAP""")|3|
||SPDB|Int32||XmlEnum("""SPDB""")|4|
||OPTN|Int32||XmlEnum("""OPTN""")|5|
||FORW|Int32||XmlEnum("""FORW""")|6|
||FUTR|Int32||XmlEnum("""FUTR""")|7|
||FRAS|Int32||XmlEnum("""FRAS""")|8|
||CFDS|Int32||XmlEnum("""CFDS""")|9|

---

## Value ISO20022.Auth030001.FinancialInstrumentQuantity32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MntryVal|ISO20022.Auth030001.ActiveOrHistoricCurrencyAnd19DecimalAmount||XmlElement()||
|+|NmnlVal|ISO20022.Auth030001.ActiveOrHistoricCurrencyAnd19DecimalAmount||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MntryVal),validElement(NmnlVal),validChoice(MntryVal,NmnlVal,Unit))|

---

## Value ISO20022.Auth030001.FinancialPartyClassification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Auth030001.GenericIdentification175||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Auth030001.FinancialPartySectorType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||ASSU|Int32||XmlEnum("""ASSU""")|2|
||UCIT|Int32||XmlEnum("""UCIT""")|3|
||REIN|Int32||XmlEnum("""REIN""")|4|
||INVF|Int32||XmlEnum("""INVF""")|5|
||ORPI|Int32||XmlEnum("""ORPI""")|6|
||INUN|Int32||XmlEnum("""INUN""")|7|
||CDTI|Int32||XmlEnum("""CDTI""")|8|
||CCPS|Int32||XmlEnum("""CCPS""")|9|
||CSDS|Int32||XmlEnum("""CSDS""")|10|
||AIFD|Int32||XmlEnum("""AIFD""")|11|

---

## Value ISO20022.Auth030001.FixedRate10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PmtFrqcy|ISO20022.Auth030001.InterestRateFrequency3Choice||XmlElement()||
|+|DayCnt|ISO20022.Auth030001.InterestComputationMethodFormat7||XmlElement()||
|+|Rate|ISO20022.Auth030001.SecuritiesTransactionPrice14Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PmtFrqcy),validElement(DayCnt),validElement(Rate))|

---

## Value ISO20022.Auth030001.FloatingRate13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastFltgRst|ISO20022.Auth030001.ResetDateAndValue1||XmlElement()||
|+|NxtFltgRst|ISO20022.Auth030001.ResetDateAndValue1||XmlElement()||
|+|RstFrqcy|ISO20022.Auth030001.InterestRateFrequency3Choice||XmlElement()||
|+|PmtFrqcy|ISO20022.Auth030001.InterestRateFrequency3Choice||XmlElement()||
|+|DayCnt|ISO20022.Auth030001.InterestComputationMethodFormat7||XmlElement()||
|+|Sprd|ISO20022.Auth030001.SecuritiesTransactionPrice20Choice||XmlElement()||
|+|RefPrd|ISO20022.Auth030001.InterestRateContractTerm4||XmlElement()||
|+|Rate|ISO20022.Auth030001.FloatingRateIdentification8Choice||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LastFltgRst),validElement(NxtFltgRst),validElement(RstFrqcy),validElement(PmtFrqcy),validElement(DayCnt),validElement(Sprd),validElement(RefPrd),validElement(Rate),validPattern("""Id""",Id,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Auth030001.FloatingRateIdentification8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Auth030001.FreightCommodityContainerShip2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.FreightCommodityDry3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.FreightCommodityOther2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.FreightCommodityWet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth030001.Frequency13Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||QURT|Int32||XmlEnum("""QURT""")|1|
||MIAN|Int32||XmlEnum("""MIAN""")|2|
||EXPI|Int32||XmlEnum("""EXPI""")|3|
||ADHO|Int32||XmlEnum("""ADHO""")|4|
||YEAR|Int32||XmlEnum("""YEAR""")|5|
||MNTH|Int32||XmlEnum("""MNTH""")|6|
||WEEK|Int32||XmlEnum("""WEEK""")|7|
||DAIL|Int32||XmlEnum("""DAIL""")|8|

---

## Enum ISO20022.Auth030001.Frequency19Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ODMD|Int32||XmlEnum("""ODMD""")|1|
||HOUL|Int32||XmlEnum("""HOUL""")|2|
||QURT|Int32||XmlEnum("""QURT""")|3|
||MIAN|Int32||XmlEnum("""MIAN""")|4|
||EXPI|Int32||XmlEnum("""EXPI""")|5|
||ADHO|Int32||XmlEnum("""ADHO""")|6|
||YEAR|Int32||XmlEnum("""YEAR""")|7|
||MNTH|Int32||XmlEnum("""MNTH""")|8|
||WEEK|Int32||XmlEnum("""WEEK""")|9|
||DAIL|Int32||XmlEnum("""DAIL""")|10|

---

## Value ISO20022.Auth030001.GenericIdentification175


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.GenericIdentification179


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.GenericIdentification184


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Src|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.GenericIdentification185


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.IndexIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Indx|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Auth030001.IndustrialProductCommodityConstruction2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.IndustrialProductCommodityManufacturing2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.InstrumentIdentification6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrId|ISO20022.Auth030001.GenericIdentification184||XmlElement()||
|+|UnqPdctIdr|ISO20022.Auth030001.UniqueProductIdentifier1Choice||XmlElement()||
|+|AltrntvInstrmId|String||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrId),validElement(UnqPdctIdr),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validChoice(OthrId,UnqPdctIdr,AltrntvInstrmId,ISIN))|

---

## Enum ISO20022.Auth030001.InterestComputationMethod4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||A020|Int32||XmlEnum("""A020""")|1|
||NARR|Int32||XmlEnum("""NARR""")|2|
||A016|Int32||XmlEnum("""A016""")|3|
||A007|Int32||XmlEnum("""A007""")|4|
||A013|Int32||XmlEnum("""A013""")|5|
||A012|Int32||XmlEnum("""A012""")|6|
||A003|Int32||XmlEnum("""A003""")|7|
||A002|Int32||XmlEnum("""A002""")|8|
||A001|Int32||XmlEnum("""A001""")|9|
||A011|Int32||XmlEnum("""A011""")|10|
||A018|Int32||XmlEnum("""A018""")|11|
||A015|Int32||XmlEnum("""A015""")|12|
||A008|Int32||XmlEnum("""A008""")|13|
||A006|Int32||XmlEnum("""A006""")|14|
||A010|Int32||XmlEnum("""A010""")|15|
||A014|Int32||XmlEnum("""A014""")|16|
||A009|Int32||XmlEnum("""A009""")|17|
||A005|Int32||XmlEnum("""A005""")|18|
||A017|Int32||XmlEnum("""A017""")|19|
||A019|Int32||XmlEnum("""A019""")|20|
||A004|Int32||XmlEnum("""A004""")|21|

---

## Value ISO20022.Auth030001.InterestComputationMethodFormat7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nrrtv|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.InterestRate33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Fltg|ISO20022.Auth030001.FloatingRate13||XmlElement()||
|+|Fxd|ISO20022.Auth030001.FixedRate10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Fltg),validElement(Fxd),validChoice(Fltg,Fxd))|

---

## Value ISO20022.Auth030001.InterestRateContractTerm4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|Decimal||XmlElement()||
|+|Unit|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.InterestRateFrequency3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Term|ISO20022.Auth030001.InterestRateContractTerm4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Term),validChoice(Prtry,Term))|

---

## Value ISO20022.Auth030001.InterestRateLegs14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ScndLeg|ISO20022.Auth030001.InterestRate33Choice||XmlElement()||
|+|FrstLeg|ISO20022.Auth030001.InterestRate33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ScndLeg),validElement(FrstLeg))|

---

## Value ISO20022.Auth030001.LegalPersonIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Auth030001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Auth030001.MarginPortfolio4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|VartnMrgnPrtflCd|ISO20022.Auth030001.PortfolioCode5Choice||XmlElement()||
|+|InitlMrgnPrtflCd|ISO20022.Auth030001.PortfolioCode5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(VartnMrgnPrtflCd),validElement(InitlMrgnPrtflCd))|

---

## Value ISO20022.Auth030001.MasterAgreement8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrMstrAgrmtDtls|String||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|Tp|ISO20022.Auth030001.AgreementType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Auth030001.MetalCommodityNonPrecious2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.MetalCommodityPrecious2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth030001.ModificationLevel1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TCTN|Int32||XmlEnum("""TCTN""")|1|
||PSTN|Int32||XmlEnum("""PSTN""")|2|

---

## Value ISO20022.Auth030001.NaturalPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dmcl|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Auth030001.GenericIdentification175||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Auth030001.NaturalPersonIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Auth030001.NaturalPersonIdentification2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id))|

---

## Enum ISO20022.Auth030001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Auth030001.NonClearingReason2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NonClrRsnInf|String||XmlElement()||
|+|ClrXmptnXcptn|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""ClrXmptnXcptn""",ClrXmptnXcptn))|

---

## Value ISO20022.Auth030001.NonFinancialInstitutionSector10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FdrlInstn|String||XmlElement()||
|+|DrctlyLkdActvty|String||XmlElement()||
|+|ClrThrshld|String||XmlElement()||
|+|Sctr|global::System.Collections.Generic.List<ISO20022.Auth030001.GenericIdentification175>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Sctr""",Sctr),validList("""Sctr""",Sctr),validElement(Sctr))|

---

## Enum ISO20022.Auth030001.NotApplicable1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOAP|Int32||XmlEnum("""NOAP""")|1|

---

## Value ISO20022.Auth030001.NotionalAmount5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchdlPrd|global::System.Collections.Generic.List<ISO20022.Auth030001.Schedule11>||XmlElement()||
|+|Amt|ISO20022.Auth030001.AmountAndDirection106||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SchdlPrd""",SchdlPrd),validElement(SchdlPrd),validElement(Amt))|

---

## Value ISO20022.Auth030001.NotionalAmount6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ccy|String||XmlElement()||
|+|SchdlPrd|global::System.Collections.Generic.List<ISO20022.Auth030001.Schedule11>||XmlElement()||
|+|Amt|ISO20022.Auth030001.AmountAndDirection106||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validList("""SchdlPrd""",SchdlPrd),validElement(SchdlPrd),validElement(Amt))|

---

## Value ISO20022.Auth030001.NotionalAmountLegs5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ScndLeg|ISO20022.Auth030001.NotionalAmount6||XmlElement()||
|+|FrstLeg|ISO20022.Auth030001.NotionalAmount5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ScndLeg),validElement(FrstLeg))|

---

## Value ISO20022.Auth030001.NotionalQuantity9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dtls|ISO20022.Auth030001.QuantityOrTerm1Choice||XmlElement()||
|+|UnitOfMeasr|ISO20022.Auth030001.UnitOfMeasure8Choice||XmlElement()||
|+|TtlQty|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Dtls),validElement(UnitOfMeasr))|

---

## Value ISO20022.Auth030001.NotionalQuantityLegs5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ScndLeg|ISO20022.Auth030001.NotionalQuantity9||XmlElement()||
|+|FrstLeg|ISO20022.Auth030001.NotionalQuantity9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ScndLeg),validElement(FrstLeg))|

---

## Value ISO20022.Auth030001.OptionBarrierLevel1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Mltpl|ISO20022.Auth030001.OptionMultipleBarrierLevels1||XmlElement()||
|+|Sngl|ISO20022.Auth030001.SecuritiesTransactionPrice23Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Mltpl),validElement(Sngl),validChoice(Mltpl,Sngl))|

---

## Value ISO20022.Auth030001.OptionMultipleBarrierLevels1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UpperLvl|ISO20022.Auth030001.SecuritiesTransactionPrice23Choice||XmlElement()||
|+|LwrLvl|ISO20022.Auth030001.SecuritiesTransactionPrice23Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UpperLvl),validElement(LwrLvl))|

---

## Value ISO20022.Auth030001.OptionOrSwaption11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrrrLvls|ISO20022.Auth030001.OptionBarrierLevel1Choice||XmlElement()||
|+|MtrtyDtOfUndrlyg|DateTime||XmlElement()||
|+|PrmPmtDt|DateTime||XmlElement()||
|+|PrmAmt|ISO20022.Auth030001.ActiveOrHistoricCurrencyAnd19DecimalAmount||XmlElement()||
|+|PutAmt|ISO20022.Auth030001.ActiveOrHistoricCurrencyAnd19DecimalAmount||XmlElement()||
|+|CallAmt|ISO20022.Auth030001.ActiveOrHistoricCurrencyAnd19DecimalAmount||XmlElement()||
|+|StrkPricSchdl|global::System.Collections.Generic.List<ISO20022.Auth030001.Schedule4>||XmlElement()||
|+|StrkPric|ISO20022.Auth030001.SecuritiesTransactionPrice17Choice||XmlElement()||
|+|ExrcDt|ISO20022.Auth030001.ExerciseDate1Choice||XmlElement()||
|+|ExrcStyle|global::System.Collections.Generic.List<String>||XmlElement()||
|+|MbddTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrrrLvls),validElement(PrmAmt),validElement(PutAmt),validElement(CallAmt),validList("""StrkPricSchdl""",StrkPricSchdl),validElement(StrkPricSchdl),validElement(StrkPric),validElement(ExrcDt))|

---

## Enum ISO20022.Auth030001.OptionParty1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BYER|Int32||XmlEnum("""BYER""")|1|
||SLLR|Int32||XmlEnum("""SLLR""")|2|

---

## Enum ISO20022.Auth030001.OptionParty3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TAKE|Int32||XmlEnum("""TAKE""")|1|
||MAKE|Int32||XmlEnum("""MAKE""")|2|

---

## Enum ISO20022.Auth030001.OptionStyle6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AMER|Int32||XmlEnum("""AMER""")|1|
||ASIA|Int32||XmlEnum("""ASIA""")|2|
||BERM|Int32||XmlEnum("""BERM""")|3|
||EURO|Int32||XmlEnum("""EURO""")|4|

---

## Enum ISO20022.Auth030001.OptionType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||PUTO|Int32||XmlEnum("""PUTO""")|2|
||CALL|Int32||XmlEnum("""CALL""")|3|

---

## Value ISO20022.Auth030001.OrganisationIdentification15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AnyBIC|String||XmlElement()||
|+|Othr|ISO20022.Auth030001.OrganisationIdentification38||XmlElement()||
|+|LEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validChoice(AnyBIC,Othr,LEI))|

---

## Value ISO20022.Auth030001.OrganisationIdentification38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dmcl|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Auth030001.GenericIdentification175||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Auth030001.OtherPayment5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PmtRcvr|ISO20022.Auth030001.PartyIdentification236Choice||XmlElement()||
|+|PmtPyer|ISO20022.Auth030001.PartyIdentification236Choice||XmlElement()||
|+|PmtDt|DateTime||XmlElement()||
|+|PmtTp|ISO20022.Auth030001.PaymentType5Choice||XmlElement()||
|+|PmtAmt|ISO20022.Auth030001.AmountAndDirection106||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PmtRcvr),validElement(PmtPyer),validElement(PmtTp),validElement(PmtAmt))|

---

## Value ISO20022.Auth030001.PTRREvent2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SvcPrvdr|ISO20022.Auth030001.OrganisationIdentification15Choice||XmlElement()||
|+|Tchnq|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SvcPrvdr))|

---

## Value ISO20022.Auth030001.Package4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sprd|ISO20022.Auth030001.SecuritiesTransactionPrice20Choice||XmlElement()||
|+|Pric|ISO20022.Auth030001.SecuritiesTransactionPrice17Choice||XmlElement()||
|+|FxSwpLkId|String||XmlElement()||
|+|CmplxTradId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Sprd),validElement(Pric))|

---

## Value ISO20022.Auth030001.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Auth030001.PaperCommodityContainerBoard2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.PaperCommodityNewsprint2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.PaperCommodityOther1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.PaperCommodityPulp2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.PaperCommodityRecoveredPaper3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.PartyIdentification236Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ntrl|ISO20022.Auth030001.NaturalPersonIdentification2||XmlElement()||
|+|Lgl|ISO20022.Auth030001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ntrl),validElement(Lgl),validChoice(Ntrl,Lgl))|

---

## Value ISO20022.Auth030001.PartyIdentification248Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ntrl|ISO20022.Auth030001.NaturalPersonIdentification3||XmlElement()||
|+|Lgl|ISO20022.Auth030001.LegalPersonIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ntrl),validElement(Lgl),validChoice(Ntrl,Lgl))|

---

## Enum ISO20022.Auth030001.PaymentType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PEXH|Int32||XmlEnum("""PEXH""")|1|
||UWIN|Int32||XmlEnum("""UWIN""")|2|
||UFRO|Int32||XmlEnum("""UFRO""")|3|

---

## Value ISO20022.Auth030001.PaymentType5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrtryTp""",PrtryTp,"""[a-zA-Z0-9]{1,4}"""),validChoice(PrtryTp,Tp))|

---

## Enum ISO20022.Auth030001.PhysicalTransferType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CASH|Int32||XmlEnum("""CASH""")|1|
||OPTL|Int32||XmlEnum("""OPTL""")|2|
||PHYS|Int32||XmlEnum("""PHYS""")|3|

---

## Value ISO20022.Auth030001.PolypropyleneCommodityOther2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.PolypropyleneCommodityPlastic2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.PortfolioCode3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoPrtfl|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(NoPrtfl,Cd))|

---

## Value ISO20022.Auth030001.PortfolioCode5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoPrtfl|String||XmlElement()||
|+|Prtfl|ISO20022.Auth030001.PortfolioIdentification3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtfl),validChoice(NoPrtfl,Prtfl))|

---

## Value ISO20022.Auth030001.PortfolioIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtflTxXmptn|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.PostTradeRiskReductionIdentifier1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Strr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Strr""",Strr,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Auth030001.PriceData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricMltplr|Decimal||XmlElement()||
|+|UnitOfMeasr|ISO20022.Auth030001.UnitOfMeasure8Choice||XmlElement()||
|+|SchdlPrd|global::System.Collections.Generic.List<ISO20022.Auth030001.Schedule1>||XmlElement()||
|+|Pric|ISO20022.Auth030001.SecuritiesTransactionPrice17Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UnitOfMeasr),validList("""SchdlPrd""",SchdlPrd),validElement(SchdlPrd),validElement(Pric))|

---

## Enum ISO20022.Auth030001.PriceStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOAP|Int32||XmlEnum("""NOAP""")|1|
||PNDG|Int32||XmlEnum("""PNDG""")|2|

---

## Enum ISO20022.Auth030001.PriceStatus2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PNDG|Int32||XmlEnum("""PNDG""")|1|

---

## Enum ISO20022.Auth030001.ProductType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||COMM|Int32||XmlEnum("""COMM""")|2|
||INTR|Int32||XmlEnum("""INTR""")|3|
||EQUI|Int32||XmlEnum("""EQUI""")|4|
||CURR|Int32||XmlEnum("""CURR""")|5|
||CRDT|Int32||XmlEnum("""CRDT""")|6|

---

## Value ISO20022.Auth030001.Quantity47Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|Qty|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Desc,Qty))|

---

## Value ISO20022.Auth030001.QuantityOrTerm1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Term|ISO20022.Auth030001.QuantityTerm1||XmlElement()||
|+|SchdlPrd|global::System.Collections.Generic.List<ISO20022.Auth030001.Schedule10>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Term),validRequired("""SchdlPrd""",SchdlPrd),validList("""SchdlPrd""",SchdlPrd),validElement(SchdlPrd),validChoice(Term,SchdlPrd))|

---

## Value ISO20022.Auth030001.QuantityTerm1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TmUnit|String||XmlElement()||
|+|Val|Decimal||XmlElement()||
|+|UnitOfMeasr|ISO20022.Auth030001.UnitOfMeasure8Choice||XmlElement()||
|+|Qty|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UnitOfMeasr))|

---

## Enum ISO20022.Auth030001.Reconciliation3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SSNE|Int32||XmlEnum("""SSNE""")|1|
||SSUN|Int32||XmlEnum("""SSUN""")|2|
||SPRV|Int32||XmlEnum("""SPRV""")|3|
||SPRW|Int32||XmlEnum("""SPRW""")|4|
||SSPA|Int32||XmlEnum("""SSPA""")|5|
||SSMA|Int32||XmlEnum("""SSMA""")|6|
||NORE|Int32||XmlEnum("""NORE""")|7|
||DSNM|Int32||XmlEnum("""DSNM""")|8|
||DSMA|Int32||XmlEnum("""DSMA""")|9|
||DPRV|Int32||XmlEnum("""DPRV""")|10|
||DPRW|Int32||XmlEnum("""DPRW""")|11|

---

## Enum ISO20022.Auth030001.ReportPeriodActivity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOTX|Int32||XmlEnum("""NOTX""")|1|

---

## Value ISO20022.Auth030001.ReportingExemption1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|Rsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.ResetDateAndValue1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|Decimal||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth030001.RiskReductionService1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PWAS|Int32||XmlEnum("""PWAS""")|1|
||PRBM|Int32||XmlEnum("""PRBM""")|2|
||OTHR|Int32||XmlEnum("""OTHR""")|3|
||PWOS|Int32||XmlEnum("""PWOS""")|4|
||NORR|Int32||XmlEnum("""NORR""")|5|

---

## Value ISO20022.Auth030001.Schedule1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pric|ISO20022.Auth030001.SecuritiesTransactionPrice17Choice||XmlElement()||
|+|UadjstdEndDt|DateTime||XmlElement()||
|+|UadjstdFctvDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pric))|

---

## Value ISO20022.Auth030001.Schedule10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UadjstdEndDt|DateTime||XmlElement()||
|+|UadjstdFctvDt|DateTime||XmlElement()||
|+|UnitOfMeasr|ISO20022.Auth030001.UnitOfMeasure8Choice||XmlElement()||
|+|Qty|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UnitOfMeasr))|

---

## Value ISO20022.Auth030001.Schedule11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Auth030001.AmountAndDirection106||XmlElement()||
|+|UadjstdEndDt|DateTime||XmlElement()||
|+|UadjstdFctvDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Auth030001.Schedule4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pric|ISO20022.Auth030001.SecuritiesTransactionPrice17Choice||XmlElement()||
|+|UadjstdEndDt|DateTime||XmlElement()||
|+|UadjstdFctvDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pric))|

---

## Value ISO20022.Auth030001.SecuritiesTransactionPrice14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dcml|Decimal||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Dcml,Rate))|

---

## Value ISO20022.Auth030001.SecuritiesTransactionPrice17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth030001.SecuritiesTransactionPrice5||XmlElement()||
|+|PdgPric|String||XmlElement()||
|+|Dcml|Decimal||XmlElement()||
|+|Yld|Decimal||XmlElement()||
|+|Pctg|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
|+|MntryVal|ISO20022.Auth030001.AmountAndDirection106||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(MntryVal),validChoice(Othr,PdgPric,Dcml,Yld,Pctg,Unit,MntryVal))|

---

## Value ISO20022.Auth030001.SecuritiesTransactionPrice20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BsisPtSprd|Decimal||XmlElement()||
|+|Dcml|Decimal||XmlElement()||
|+|Pctg|Decimal||XmlElement()||
|+|MntryVal|ISO20022.Auth030001.AmountAndDirection106||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MntryVal),validChoice(BsisPtSprd,Dcml,Pctg,MntryVal))|

---

## Value ISO20022.Auth030001.SecuritiesTransactionPrice23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth030001.SecuritiesTransactionPrice5||XmlElement()||
|+|Dcml|Decimal||XmlElement()||
|+|Yld|Decimal||XmlElement()||
|+|Pctg|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
|+|MntryVal|ISO20022.Auth030001.AmountAndDirection106||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(MntryVal),validChoice(Othr,Dcml,Yld,Pctg,Unit,MntryVal))|

---

## Value ISO20022.Auth030001.SecuritiesTransactionPrice5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|String||XmlElement()||
|+|Val|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.SecurityIdentification41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdNotAvlbl|String||XmlElement()||
|+|Othr|ISO20022.Auth030001.GenericIdentification184||XmlElement()||
|+|Indx|ISO20022.Auth030001.IndexIdentification1||XmlElement()||
|+|Bskt|ISO20022.Auth030001.CustomBasket4||XmlElement()||
|+|UnqPdctIdr|ISO20022.Auth030001.UniqueProductIdentifier2Choice||XmlElement()||
|+|AltrntvInstrmId|String||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(Indx),validElement(Bskt),validElement(UnqPdctIdr),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validChoice(IdNotAvlbl,Othr,Indx,Bskt,UnqPdctIdr,AltrntvInstrmId,ISIN))|

---

## Value ISO20022.Auth030001.SecurityIdentification46


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PdctDesc|String||XmlElement()||
|+|AltrntvInstrmId|String||XmlElement()||
|+|UnqPdctIdr|ISO20022.Auth030001.UniqueProductIdentifier2Choice||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UnqPdctIdr),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Auth030001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Auth030001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Auth030001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.TechnicalAttributes5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RptRctTmStmp|DateTime||XmlElement()||
|+|RcncltnFlg|String||XmlElement()||
|+|TechRcrdId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.TimePeriodDetails1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToTm|DateTime||XmlElement()||
|+|FrTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.TradeClearing11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IntraGrp|String||XmlElement()||
|+|ClrSts|ISO20022.Auth030001.Cleared23Choice||XmlElement()||
|+|ClrOblgtn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSts))|

---

## Value ISO20022.Auth030001.TradeConfirmation4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NonConfd|ISO20022.Auth030001.TradeNonConfirmation1||XmlElement()||
|+|Confd|ISO20022.Auth030001.TradeConfirmation5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NonConfd),validElement(Confd),validChoice(NonConfd,Confd))|

---

## Value ISO20022.Auth030001.TradeConfirmation5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TmStmp|DateTime||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth030001.TradeConfirmationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YCNF|Int32||XmlEnum("""YCNF""")|1|
||ECNF|Int32||XmlEnum("""ECNF""")|2|

---

## Enum ISO20022.Auth030001.TradeConfirmationType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NCNF|Int32||XmlEnum("""NCNF""")|1|

---

## Value ISO20022.Auth030001.TradeCounterpartyRelationship1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Auth030001.TradeCounterpartyRelationshipRecord1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|RltshTp|ISO20022.Auth030001.TradeCounterpartyRelationship1Choice||XmlElement()||
|+|EndRltshPty|String||XmlElement()||
|+|StartRltshPty|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RltshTp))|

---

## Value ISO20022.Auth030001.TradeCounterpartyReport20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltshRcrd|global::System.Collections.Generic.List<ISO20022.Auth030001.TradeCounterpartyRelationshipRecord1>||XmlElement()||
|+|ExctnAgt|global::System.Collections.Generic.List<ISO20022.Auth030001.OrganisationIdentification15Choice>||XmlElement()||
|+|NttyRspnsblForRpt|ISO20022.Auth030001.OrganisationIdentification15Choice||XmlElement()||
|+|Bnfcry|global::System.Collections.Generic.List<ISO20022.Auth030001.PartyIdentification248Choice>||XmlElement()||
|+|ClrMmb|ISO20022.Auth030001.PartyIdentification248Choice||XmlElement()||
|+|SubmitgAgt|ISO20022.Auth030001.OrganisationIdentification15Choice||XmlElement()||
|+|Brkr|ISO20022.Auth030001.OrganisationIdentification15Choice||XmlElement()||
|+|OthrCtrPty|ISO20022.Auth030001.Counterparty46||XmlElement()||
|+|RptgCtrPty|ISO20022.Auth030001.Counterparty45||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""RltshRcrd""",RltshRcrd),validElement(RltshRcrd),validList("""ExctnAgt""",ExctnAgt),validListMax("""ExctnAgt""",ExctnAgt,2),validElement(ExctnAgt),validElement(NttyRspnsblForRpt),validList("""Bnfcry""",Bnfcry),validListMax("""Bnfcry""",Bnfcry,2),validElement(Bnfcry),validElement(ClrMmb),validElement(SubmitgAgt),validElement(Brkr),validElement(OthrCtrPty),validElement(RptgCtrPty))|

---

## Enum ISO20022.Auth030001.TradeCounterpartyType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ERFR|Int32||XmlEnum("""ERFR""")|1|
||SBMA|Int32||XmlEnum("""SBMA""")|2|
||REPC|Int32||XmlEnum("""REPC""")|3|
||OTHC|Int32||XmlEnum("""OTHC""")|4|
||EXEA|Int32||XmlEnum("""EXEA""")|5|
||CLEM|Int32||XmlEnum("""CLEM""")|6|
||BROK|Int32||XmlEnum("""BROK""")|7|
||BENE|Int32||XmlEnum("""BENE""")|8|

---

## Value ISO20022.Auth030001.TradeData43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth030001.SupplementaryData1>||XmlElement()||
|+|PblcDssmntnData|ISO20022.Auth030001.DisseminationData1||XmlElement()||
|+|TechAttrbts|ISO20022.Auth030001.TechnicalAttributes5||XmlElement()||
|+|Lvl|String||XmlElement()||
|+|CmonTradData|ISO20022.Auth030001.CommonTradeDataReport71||XmlElement()||
|+|CtrPtySpcfcData|global::System.Collections.Generic.List<ISO20022.Auth030001.CounterpartySpecificData36>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(PblcDssmntnData),validElement(TechAttrbts),validElement(CmonTradData),validRequired("""CtrPtySpcfcData""",CtrPtySpcfcData),validList("""CtrPtySpcfcData""",CtrPtySpcfcData),validListMax("""CtrPtySpcfcData""",CtrPtySpcfcData,2),validElement(CtrPtySpcfcData))|

---

## Value ISO20022.Auth030001.TradeData59Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rpt|global::System.Collections.Generic.List<ISO20022.Auth030001.TradeReport33Choice>||XmlElement()||
|+|DataSetActn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rpt""",Rpt),validList("""Rpt""",Rpt),validElement(Rpt),validChoice(Rpt,DataSetActn))|

---

## Value ISO20022.Auth030001.TradeNonConfirmation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.TradeReport33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth030001.TradeData43||XmlElement()||
|+|Rvv|ISO20022.Auth030001.TradeData43||XmlElement()||
|+|PortOut|ISO20022.Auth030001.TradeData43||XmlElement()||
|+|Err|ISO20022.Auth030001.TradeData43||XmlElement()||
|+|Cmprssn|ISO20022.Auth030001.TradeData43||XmlElement()||
|+|ValtnUpd|ISO20022.Auth030001.TradeData43||XmlElement()||
|+|PosCmpnt|ISO20022.Auth030001.TradeData43||XmlElement()||
|+|Termntn|ISO20022.Auth030001.TradeData43||XmlElement()||
|+|Crrctn|ISO20022.Auth030001.TradeData43||XmlElement()||
|+|Mod|ISO20022.Auth030001.TradeData43||XmlElement()||
|+|New|ISO20022.Auth030001.TradeData43||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(Rvv),validElement(PortOut),validElement(Err),validElement(Cmprssn),validElement(ValtnUpd),validElement(PosCmpnt),validElement(Termntn),validElement(Crrctn),validElement(Mod),validElement(New),validChoice(Othr,Rvv,PortOut,Err,Cmprssn,ValtnUpd,PosCmpnt,Termntn,Crrctn,Mod,New))|

---

## Value ISO20022.Auth030001.TradeReportHeader4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RptgPurp|global::System.Collections.Generic.List<String>||XmlElement()||
|+|NewTradRpstryIdr|ISO20022.Auth030001.OrganisationIdentification15Choice||XmlElement()||
|+|CmptntAuthrty|global::System.Collections.Generic.List<String>||XmlElement()||
|+|NbRcrds|Decimal||XmlElement()||
|+|MsgPgntn|ISO20022.Auth030001.Pagination1||XmlElement()||
|+|RptExctnDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NewTradRpstryIdr),validElement(MsgPgntn))|

---

## Value ISO20022.Auth030001.TradeTransaction50


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TradAllcnSts|String||XmlElement()||
|+|Packg|ISO20022.Auth030001.Package4||XmlElement()||
|+|OthrPmt|global::System.Collections.Generic.List<ISO20022.Auth030001.OtherPayment5>||XmlElement()||
|+|Cdt|ISO20022.Auth030001.CreditDerivative4||XmlElement()||
|+|NrgySpcfcAttrbts|ISO20022.Auth030001.EnergySpecificAttribute9||XmlElement()||
|+|Optn|ISO20022.Auth030001.OptionOrSwaption11||XmlElement()||
|+|Cmmdty|ISO20022.Auth030001.AssetClassCommodity7Choice||XmlElement()||
|+|Ccy|ISO20022.Auth030001.CurrencyExchange22||XmlElement()||
|+|IntrstRate|ISO20022.Auth030001.InterestRateLegs14||XmlElement()||
|+|LrgNtnlOffFcltyElctn|String||XmlElement()||
|+|BlckTradElctn|String||XmlElement()||
|+|TradClr|ISO20022.Auth030001.TradeClearing11||XmlElement()||
|+|NonStdsdTerm|String||XmlElement()||
|+|TradConf|ISO20022.Auth030001.TradeConfirmation4Choice||XmlElement()||
|+|DerivEvt|ISO20022.Auth030001.DerivativeEvent6||XmlElement()||
|+|PstTradRskRdctnEvt|ISO20022.Auth030001.PTRREvent2||XmlElement()||
|+|PstTradRskRdctnFlg|String||XmlElement()||
|+|Cmprssn|String||XmlElement()||
|+|MstrAgrmt|ISO20022.Auth030001.MasterAgreement8||XmlElement()||
|+|SttlmDt|global::System.Collections.Generic.List<DateTime>||XmlElement()||
|+|EarlyTermntnDt|DateTime||XmlElement()||
|+|XprtnDt|DateTime||XmlElement()||
|+|FctvDt|DateTime||XmlElement()||
|+|ExctnTmStmp|DateTime||XmlElement()||
|+|DlvryTp|String||XmlElement()||
|+|Qty|ISO20022.Auth030001.FinancialInstrumentQuantity32Choice||XmlElement()||
|+|NtnlQty|ISO20022.Auth030001.NotionalQuantityLegs5||XmlElement()||
|+|NtnlAmt|ISO20022.Auth030001.NotionalAmountLegs5||XmlElement()||
|+|TxPric|ISO20022.Auth030001.PriceData2||XmlElement()||
|+|MrrrOrTrggrTx|String||XmlElement()||
|+|PltfmIdr|String||XmlElement()||
|+|RptTrckgNb|String||XmlElement()||
|+|CollPrtflCd|ISO20022.Auth030001.CollateralPortfolioCode6Choice||XmlElement()||
|+|SbsqntTxId|ISO20022.Auth030001.UniqueTransactionIdentifier3Choice||XmlElement()||
|+|PrrTxId|ISO20022.Auth030001.UniqueTransactionIdentifier3Choice||XmlElement()||
|+|ScndryTxId|String||XmlElement()||
|+|TxId|ISO20022.Auth030001.UniqueTransactionIdentifier2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Packg),validList("""OthrPmt""",OthrPmt),validElement(OthrPmt),validElement(Cdt),validElement(NrgySpcfcAttrbts),validElement(Optn),validElement(Cmmdty),validElement(Ccy),validElement(IntrstRate),validElement(TradClr),validElement(TradConf),validElement(DerivEvt),validElement(PstTradRskRdctnEvt),validElement(MstrAgrmt),validElement(Qty),validElement(NtnlQty),validElement(NtnlAmt),validElement(TxPric),validPattern("""PltfmIdr""",PltfmIdr,"""[A-Z0-9]{4,4}"""),validElement(CollPrtflCd),validElement(SbsqntTxId),validElement(PrrTxId),validElement(TxId))|

---

## Enum ISO20022.Auth030001.TradingCapacity7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRIN|Int32||XmlEnum("""PRIN""")|1|
||AGEN|Int32||XmlEnum("""AGEN""")|2|

---

## Value ISO20022.Auth030001.Tranche3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtchmntPt|Decimal||XmlElement()||
|+|AttchmntPt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth030001.TrancheIndicator3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Utrnchd|String||XmlElement()||
|+|Trnchd|ISO20022.Auth030001.Tranche3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Trnchd),validChoice(Utrnchd,Trnchd))|

---

## Enum ISO20022.Auth030001.UnderlyingIdentification1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDX|Int32||XmlEnum("""INDX""")|1|
||BSKT|Int32||XmlEnum("""BSKT""")|2|
||UKWN|Int32||XmlEnum("""UKWN""")|3|

---

## Value ISO20022.Auth030001.UniqueProductIdentifier1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Auth030001.GenericIdentification175||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Id))|

---

## Value ISO20022.Auth030001.UniqueProductIdentifier2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Auth030001.GenericIdentification185||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Id))|

---

## Value ISO20022.Auth030001.UniqueTransactionIdentifier1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Auth030001.GenericIdentification179||XmlElement()||
|+|UnqTxIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validPattern("""UnqTxIdr""",UnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""),validChoice(Prtry,UnqTxIdr))|

---

## Value ISO20022.Auth030001.UniqueTransactionIdentifier2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Auth030001.GenericIdentification175||XmlElement()||
|+|UnqTxIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validPattern("""UnqTxIdr""",UnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""),validChoice(Prtry,UnqTxIdr))|

---

## Value ISO20022.Auth030001.UniqueTransactionIdentifier3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotAvlbl|String||XmlElement()||
|+|Prtry|ISO20022.Auth030001.GenericIdentification175||XmlElement()||
|+|UnqTxIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validPattern("""UnqTxIdr""",UnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""),validChoice(NotAvlbl,Prtry,UnqTxIdr))|

---

## Value ISO20022.Auth030001.UnitOfMeasure8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Auth030001.GenericIdentification175||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Auth030001.ValuationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MTMO|Int32||XmlEnum("""MTMO""")|1|
||MTMA|Int32||XmlEnum("""MTMA""")|2|
||CCPV|Int32||XmlEnum("""CCPV""")|3|

---

## Enum ISO20022.Auth030001.WeekDay3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEND|Int32||XmlEnum("""WEND""")|1|
||WDAY|Int32||XmlEnum("""WDAY""")|2|
||WEDD|Int32||XmlEnum("""WEDD""")|3|
||TUED|Int32||XmlEnum("""TUED""")|4|
||THUD|Int32||XmlEnum("""THUD""")|5|
||SUND|Int32||XmlEnum("""SUND""")|6|
||SATD|Int32||XmlEnum("""SATD""")|7|
||MOND|Int32||XmlEnum("""MOND""")|8|
||FRID|Int32||XmlEnum("""FRID""")|9|
||IBHL|Int32||XmlEnum("""IBHL""")|10|
||XBHL|Int32||XmlEnum("""XBHL""")|11|
||ALLD|Int32||XmlEnum("""ALLD""")|12|

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

