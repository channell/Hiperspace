# auth.090.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd19DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Auth090001.AgreementType2Choice {
        + Prtry  : String
        + Tp  : String
    }
    class ISO20022.Auth090001.AgriculturalCommodityDairy2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.AgriculturalCommodityForestry2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.AgriculturalCommodityGrain3 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.AgriculturalCommodityLiveStock2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.AgriculturalCommodityOilSeed2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.AgriculturalCommodityOliveOil3 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.AgriculturalCommodityOther2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.AgriculturalCommodityPotato2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.AgriculturalCommoditySeafood2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.AgriculturalCommoditySoft2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.AssetClassCommodity6Choice {
        + Plprpln  : ISO20022.Auth090001.AssetClassCommodityPolypropylene4Choice
        + Ppr  : ISO20022.Auth090001.AssetClassCommodityPaper4Choice
        + OthrC10  : ISO20022.Auth090001.AssetClassCommodityC10Other1
        + Othr  : ISO20022.Auth090001.AssetClassCommodityOther1
        + OffclEcnmcSttstcs  : ISO20022.Auth090001.AssetClassCommodityOfficialEconomicStatistics1
        + MultiCmmdtyExtc  : ISO20022.Auth090001.AssetClassCommodityMultiCommodityExotic1
        + Metl  : ISO20022.Auth090001.AssetClassCommodityMetal2Choice
        + Infltn  : ISO20022.Auth090001.AssetClassCommodityInflation1
        + IndstrlPdct  : ISO20022.Auth090001.AssetClassCommodityIndustrialProduct2Choice
        + Indx  : ISO20022.Auth090001.AssetClassCommodityIndex1
        + Frght  : ISO20022.Auth090001.AssetClassCommodityFreight4Choice
        + Frtlzr  : ISO20022.Auth090001.AssetClassCommodityFertilizer4Choice
        + Envttl  : ISO20022.Auth090001.AssetClassCommodityEnvironmental3Choice
        + Nrgy  : ISO20022.Auth090001.AssetClassCommodityEnergy3Choice
        + Agrcltrl  : ISO20022.Auth090001.AssetClassCommodityAgricultural6Choice
    }
    ISO20022.Auth090001.AssetClassCommodity6Choice *-- ISO20022.Auth090001.AssetClassCommodityPolypropylene4Choice
    ISO20022.Auth090001.AssetClassCommodity6Choice *-- ISO20022.Auth090001.AssetClassCommodityPaper4Choice
    ISO20022.Auth090001.AssetClassCommodity6Choice *-- ISO20022.Auth090001.AssetClassCommodityC10Other1
    ISO20022.Auth090001.AssetClassCommodity6Choice *-- ISO20022.Auth090001.AssetClassCommodityOther1
    ISO20022.Auth090001.AssetClassCommodity6Choice *-- ISO20022.Auth090001.AssetClassCommodityOfficialEconomicStatistics1
    ISO20022.Auth090001.AssetClassCommodity6Choice *-- ISO20022.Auth090001.AssetClassCommodityMultiCommodityExotic1
    ISO20022.Auth090001.AssetClassCommodity6Choice *-- ISO20022.Auth090001.AssetClassCommodityMetal2Choice
    ISO20022.Auth090001.AssetClassCommodity6Choice *-- ISO20022.Auth090001.AssetClassCommodityInflation1
    ISO20022.Auth090001.AssetClassCommodity6Choice *-- ISO20022.Auth090001.AssetClassCommodityIndustrialProduct2Choice
    ISO20022.Auth090001.AssetClassCommodity6Choice *-- ISO20022.Auth090001.AssetClassCommodityIndex1
    ISO20022.Auth090001.AssetClassCommodity6Choice *-- ISO20022.Auth090001.AssetClassCommodityFreight4Choice
    ISO20022.Auth090001.AssetClassCommodity6Choice *-- ISO20022.Auth090001.AssetClassCommodityFertilizer4Choice
    ISO20022.Auth090001.AssetClassCommodity6Choice *-- ISO20022.Auth090001.AssetClassCommodityEnvironmental3Choice
    ISO20022.Auth090001.AssetClassCommodity6Choice *-- ISO20022.Auth090001.AssetClassCommodityEnergy3Choice
    ISO20022.Auth090001.AssetClassCommodity6Choice *-- ISO20022.Auth090001.AssetClassCommodityAgricultural6Choice
    class ISO20022.Auth090001.AssetClassCommodityAgricultural6Choice {
        + Othr  : ISO20022.Auth090001.AgriculturalCommodityOther2
        + Grn  : ISO20022.Auth090001.AgriculturalCommodityGrain3
        + LiveStock  : ISO20022.Auth090001.AgriculturalCommodityLiveStock2
        + Sfd  : ISO20022.Auth090001.AgriculturalCommoditySeafood2
        + Frstry  : ISO20022.Auth090001.AgriculturalCommodityForestry2
        + Dairy  : ISO20022.Auth090001.AgriculturalCommodityDairy2
        + OlvOil  : ISO20022.Auth090001.AgriculturalCommodityOliveOil3
        + Ptt  : ISO20022.Auth090001.AgriculturalCommodityPotato2
        + Soft  : ISO20022.Auth090001.AgriculturalCommoditySoft2
        + GrnOilSeed  : ISO20022.Auth090001.AgriculturalCommodityOilSeed2
    }
    ISO20022.Auth090001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth090001.AgriculturalCommodityOther2
    ISO20022.Auth090001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth090001.AgriculturalCommodityGrain3
    ISO20022.Auth090001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth090001.AgriculturalCommodityLiveStock2
    ISO20022.Auth090001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth090001.AgriculturalCommoditySeafood2
    ISO20022.Auth090001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth090001.AgriculturalCommodityForestry2
    ISO20022.Auth090001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth090001.AgriculturalCommodityDairy2
    ISO20022.Auth090001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth090001.AgriculturalCommodityOliveOil3
    ISO20022.Auth090001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth090001.AgriculturalCommodityPotato2
    ISO20022.Auth090001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth090001.AgriculturalCommoditySoft2
    ISO20022.Auth090001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth090001.AgriculturalCommodityOilSeed2
    class ISO20022.Auth090001.AssetClassCommodityC10Other1 {
        + BasePdct  : String
    }
    class ISO20022.Auth090001.AssetClassCommodityEnergy3Choice {
        + Othr  : ISO20022.Auth090001.EnergyCommodityOther2
        + Dstllts  : ISO20022.Auth090001.EnergyCommodityDistillates2
        + LghtEnd  : ISO20022.Auth090001.EnergyCommodityLightEnd2
        + RnwblNrgy  : ISO20022.Auth090001.EnergyCommodityRenewableEnergy2
        + IntrNrgy  : ISO20022.Auth090001.EnergyCommodityInterEnergy2
        + Coal  : ISO20022.Auth090001.EnergyCommodityCoal2
        + Oil  : ISO20022.Auth090001.EnergyCommodityOil3
        + NtrlGas  : ISO20022.Auth090001.EnergyCommodityNaturalGas3
        + Elctrcty  : ISO20022.Auth090001.EnergyCommodityElectricity2
    }
    ISO20022.Auth090001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth090001.EnergyCommodityOther2
    ISO20022.Auth090001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth090001.EnergyCommodityDistillates2
    ISO20022.Auth090001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth090001.EnergyCommodityLightEnd2
    ISO20022.Auth090001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth090001.EnergyCommodityRenewableEnergy2
    ISO20022.Auth090001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth090001.EnergyCommodityInterEnergy2
    ISO20022.Auth090001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth090001.EnergyCommodityCoal2
    ISO20022.Auth090001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth090001.EnergyCommodityOil3
    ISO20022.Auth090001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth090001.EnergyCommodityNaturalGas3
    ISO20022.Auth090001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth090001.EnergyCommodityElectricity2
    class ISO20022.Auth090001.AssetClassCommodityEnvironmental3Choice {
        + Othr  : ISO20022.Auth090001.EnvironmentCommodityOther2
        + CrbnRltd  : ISO20022.Auth090001.EnvironmentalCommodityCarbonRelated2
        + Wthr  : ISO20022.Auth090001.EnvironmentalCommodityWeather2
        + Emssns  : ISO20022.Auth090001.EnvironmentalCommodityEmission3
    }
    ISO20022.Auth090001.AssetClassCommodityEnvironmental3Choice *-- ISO20022.Auth090001.EnvironmentCommodityOther2
    ISO20022.Auth090001.AssetClassCommodityEnvironmental3Choice *-- ISO20022.Auth090001.EnvironmentalCommodityCarbonRelated2
    ISO20022.Auth090001.AssetClassCommodityEnvironmental3Choice *-- ISO20022.Auth090001.EnvironmentalCommodityWeather2
    ISO20022.Auth090001.AssetClassCommodityEnvironmental3Choice *-- ISO20022.Auth090001.EnvironmentalCommodityEmission3
    class ISO20022.Auth090001.AssetClassCommodityFertilizer4Choice {
        + Othr  : ISO20022.Auth090001.FertilizerCommodityOther2
        + UreaAndAmmnmNtrt  : ISO20022.Auth090001.FertilizerCommodityUreaAndAmmoniumNitrate2
        + Urea  : ISO20022.Auth090001.FertilizerCommodityUrea2
        + Slphr  : ISO20022.Auth090001.FertilizerCommoditySulphur2
        + Ptsh  : ISO20022.Auth090001.FertilizerCommodityPotash2
        + DmmnmPhspht  : ISO20022.Auth090001.FertilizerCommodityDiammoniumPhosphate2
        + Ammn  : ISO20022.Auth090001.FertilizerCommodityAmmonia2
    }
    ISO20022.Auth090001.AssetClassCommodityFertilizer4Choice *-- ISO20022.Auth090001.FertilizerCommodityOther2
    ISO20022.Auth090001.AssetClassCommodityFertilizer4Choice *-- ISO20022.Auth090001.FertilizerCommodityUreaAndAmmoniumNitrate2
    ISO20022.Auth090001.AssetClassCommodityFertilizer4Choice *-- ISO20022.Auth090001.FertilizerCommodityUrea2
    ISO20022.Auth090001.AssetClassCommodityFertilizer4Choice *-- ISO20022.Auth090001.FertilizerCommoditySulphur2
    ISO20022.Auth090001.AssetClassCommodityFertilizer4Choice *-- ISO20022.Auth090001.FertilizerCommodityPotash2
    ISO20022.Auth090001.AssetClassCommodityFertilizer4Choice *-- ISO20022.Auth090001.FertilizerCommodityDiammoniumPhosphate2
    ISO20022.Auth090001.AssetClassCommodityFertilizer4Choice *-- ISO20022.Auth090001.FertilizerCommodityAmmonia2
    class ISO20022.Auth090001.AssetClassCommodityFreight4Choice {
        + Othr  : ISO20022.Auth090001.FreightCommodityOther2
        + CntnrShip  : ISO20022.Auth090001.FreightCommodityContainerShip2
        + Wet  : ISO20022.Auth090001.FreightCommodityWet3
        + Dry  : ISO20022.Auth090001.FreightCommodityDry3
    }
    ISO20022.Auth090001.AssetClassCommodityFreight4Choice *-- ISO20022.Auth090001.FreightCommodityOther2
    ISO20022.Auth090001.AssetClassCommodityFreight4Choice *-- ISO20022.Auth090001.FreightCommodityContainerShip2
    ISO20022.Auth090001.AssetClassCommodityFreight4Choice *-- ISO20022.Auth090001.FreightCommodityWet3
    ISO20022.Auth090001.AssetClassCommodityFreight4Choice *-- ISO20022.Auth090001.FreightCommodityDry3
    class ISO20022.Auth090001.AssetClassCommodityIndex1 {
        + BasePdct  : String
    }
    class ISO20022.Auth090001.AssetClassCommodityIndustrialProduct2Choice {
        + Manfctg  : ISO20022.Auth090001.IndustrialProductCommodityManufacturing2
        + Cnstrctn  : ISO20022.Auth090001.IndustrialProductCommodityConstruction2
    }
    ISO20022.Auth090001.AssetClassCommodityIndustrialProduct2Choice *-- ISO20022.Auth090001.IndustrialProductCommodityManufacturing2
    ISO20022.Auth090001.AssetClassCommodityIndustrialProduct2Choice *-- ISO20022.Auth090001.IndustrialProductCommodityConstruction2
    class ISO20022.Auth090001.AssetClassCommodityInflation1 {
        + BasePdct  : String
    }
    class ISO20022.Auth090001.AssetClassCommodityMetal2Choice {
        + Prcs  : ISO20022.Auth090001.MetalCommodityPrecious2
        + NonPrcs  : ISO20022.Auth090001.MetalCommodityNonPrecious2
    }
    ISO20022.Auth090001.AssetClassCommodityMetal2Choice *-- ISO20022.Auth090001.MetalCommodityPrecious2
    ISO20022.Auth090001.AssetClassCommodityMetal2Choice *-- ISO20022.Auth090001.MetalCommodityNonPrecious2
    class ISO20022.Auth090001.AssetClassCommodityMultiCommodityExotic1 {
        + BasePdct  : String
    }
    class ISO20022.Auth090001.AssetClassCommodityOfficialEconomicStatistics1 {
        + BasePdct  : String
    }
    class ISO20022.Auth090001.AssetClassCommodityOther1 {
        + BasePdct  : String
    }
    class ISO20022.Auth090001.AssetClassCommodityPaper4Choice {
        + Othr  : ISO20022.Auth090001.PaperCommodityOther1
        + RcvrdPpr  : ISO20022.Auth090001.PaperCommodityOther1
        + Pulp  : ISO20022.Auth090001.PaperCommodityPulp2
        + Nwsprnt  : ISO20022.Auth090001.PaperCommodityNewsprint2
        + CntnrBrd  : ISO20022.Auth090001.PaperCommodityContainerBoard2
    }
    ISO20022.Auth090001.AssetClassCommodityPaper4Choice *-- ISO20022.Auth090001.PaperCommodityOther1
    ISO20022.Auth090001.AssetClassCommodityPaper4Choice *-- ISO20022.Auth090001.PaperCommodityOther1
    ISO20022.Auth090001.AssetClassCommodityPaper4Choice *-- ISO20022.Auth090001.PaperCommodityPulp2
    ISO20022.Auth090001.AssetClassCommodityPaper4Choice *-- ISO20022.Auth090001.PaperCommodityNewsprint2
    ISO20022.Auth090001.AssetClassCommodityPaper4Choice *-- ISO20022.Auth090001.PaperCommodityContainerBoard2
    class ISO20022.Auth090001.AssetClassCommodityPolypropylene4Choice {
        + Othr  : ISO20022.Auth090001.PolypropyleneCommodityOther2
        + Plstc  : ISO20022.Auth090001.PolypropyleneCommodityPlastic2
    }
    ISO20022.Auth090001.AssetClassCommodityPolypropylene4Choice *-- ISO20022.Auth090001.PolypropyleneCommodityOther2
    ISO20022.Auth090001.AssetClassCommodityPolypropylene4Choice *-- ISO20022.Auth090001.PolypropyleneCommodityPlastic2
    class ISO20022.Auth090001.AssetClassDetailedSubProductType10Code {
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
    class ISO20022.Auth090001.AssetClassDetailedSubProductType11Code {
        SLVR = 1
        PTNM = 2
        PLDM = 3
        OTHR = 4
        GOLD = 5
    }
    class ISO20022.Auth090001.AssetClassDetailedSubProductType1Code {
        RICE = 1
        CORN = 2
        OTHR = 3
        RPSD = 4
        SOYB = 5
        FWHT = 6
    }
    class ISO20022.Auth090001.AssetClassDetailedSubProductType29Code {
        OTHR = 1
        LAMP = 2
    }
    class ISO20022.Auth090001.AssetClassDetailedSubProductType2Code {
        OTHR = 1
        WHSG = 2
        BRWN = 3
        CCOA = 4
        ROBU = 5
    }
    class ISO20022.Auth090001.AssetClassDetailedSubProductType30Code {
        OTHR = 1
        MWHT = 2
    }
    class ISO20022.Auth090001.AssetClassDetailedSubProductType31Code {
        OTHR = 1
        NBPG = 2
        TTFG = 3
        NCGG = 4
        LNGG = 5
        GASP = 6
    }
    class ISO20022.Auth090001.AssetClassDetailedSubProductType32Code {
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
    class ISO20022.Auth090001.AssetClassDetailedSubProductType33Code {
        OTHR = 1
        DBCR = 2
    }
    class ISO20022.Auth090001.AssetClassDetailedSubProductType34Code {
        OTHR = 1
        TNKR = 2
    }
    class ISO20022.Auth090001.AssetClassDetailedSubProductType5Code {
        OTHR = 1
        OFFP = 2
        PKLD = 3
        FITR = 4
        BSLD = 5
    }
    class ISO20022.Auth090001.AssetClassDetailedSubProductType8Code {
        OTHR = 1
        EUAA = 2
        EUAE = 3
        ERUE = 4
        CERE = 5
    }
    class ISO20022.Auth090001.AssetClassProductType11Code {
        OTHC = 1
    }
    class ISO20022.Auth090001.AssetClassProductType12Code {
        INFL = 1
    }
    class ISO20022.Auth090001.AssetClassProductType13Code {
        MCEX = 1
    }
    class ISO20022.Auth090001.AssetClassProductType14Code {
        OEST = 1
    }
    class ISO20022.Auth090001.AssetClassProductType15Code {
        OTHR = 1
    }
    class ISO20022.Auth090001.AssetClassProductType16Code {
        INDX = 1
    }
    class ISO20022.Auth090001.AssetClassProductType1Code {
        AGRI = 1
    }
    class ISO20022.Auth090001.AssetClassProductType2Code {
        NRGY = 1
    }
    class ISO20022.Auth090001.AssetClassProductType3Code {
        ENVR = 1
    }
    class ISO20022.Auth090001.AssetClassProductType4Code {
        FRGT = 1
    }
    class ISO20022.Auth090001.AssetClassProductType5Code {
        FRTL = 1
    }
    class ISO20022.Auth090001.AssetClassProductType6Code {
        INDP = 1
    }
    class ISO20022.Auth090001.AssetClassProductType7Code {
        METL = 1
    }
    class ISO20022.Auth090001.AssetClassProductType8Code {
        PAPR = 1
    }
    class ISO20022.Auth090001.AssetClassProductType9Code {
        POLY = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType10Code {
        EMIS = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType15Code {
        NPRM = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType16Code {
        PRME = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType18Code {
        PLST = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType1Code {
        GROS = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType20Code {
        DIRY = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType21Code {
        FRST = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType22Code {
        LSTK = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType23Code {
        SEAF = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType24Code {
        COAL = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType25Code {
        DIST = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType26Code {
        INRG = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType27Code {
        LGHT = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType28Code {
        RNNG = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType29Code {
        CRBR = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType2Code {
        SOFT = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType30Code {
        WTHR = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType31Code {
        DRYF = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType32Code {
        WETF = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType33Code {
        CSTR = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType34Code {
        MFTG = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType35Code {
        CBRD = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType36Code {
        NSPT = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType37Code {
        PULP = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType39Code {
        AMMO = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType3Code {
        OOLI = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType40Code {
        DAPH = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType41Code {
        PTSH = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType42Code {
        SLPH = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType43Code {
        UREA = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType44Code {
        UAAN = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType45Code {
        POTA = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType46Code {
        CSHP = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType49Code {
        OTHR = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType5Code {
        GRIN = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType6Code {
        ELEC = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType7Code {
        NGAS = 1
    }
    class ISO20022.Auth090001.AssetClassSubProductType8Code {
        OILP = 1
    }
    class ISO20022.Auth090001.BasketConstituents3 {
        + UnitOfMeasr  : ISO20022.Auth090001.UnitOfMeasure8Choice
        + Qty  : Decimal
        + InstrmId  : ISO20022.Auth090001.InstrumentIdentification6Choice
    }
    ISO20022.Auth090001.BasketConstituents3 *-- ISO20022.Auth090001.UnitOfMeasure8Choice
    ISO20022.Auth090001.BasketConstituents3 *-- ISO20022.Auth090001.InstrumentIdentification6Choice
    class ISO20022.Auth090001.CollateralPortfolioCode5Choice {
        + MrgnPrtflCd  : ISO20022.Auth090001.MarginPortfolio3
        + Prtfl  : ISO20022.Auth090001.PortfolioCode3Choice
    }
    ISO20022.Auth090001.CollateralPortfolioCode5Choice *-- ISO20022.Auth090001.MarginPortfolio3
    ISO20022.Auth090001.CollateralPortfolioCode5Choice *-- ISO20022.Auth090001.PortfolioCode3Choice
    class ISO20022.Auth090001.CollateralisationType3Code {
        UNCL = 1
        PRC2 = 2
        PRC1 = 3
        PRCL = 4
        OWP2 = 5
        OWP1 = 6
        OWC2 = 7
        OWC1 = 8
        OWCL = 9
        FLCL = 10
    }
    class ISO20022.Auth090001.Counterparty45 {
        + RptgXmptn  : ISO20022.Auth090001.ReportingExemption1
        + BookgLctn  : String
        + TradrLctn  : String
        + DrctnOrSd  : ISO20022.Auth090001.Direction4Choice
        + TradgCpcty  : String
        + Ntr  : ISO20022.Auth090001.CounterpartyTradeNature15Choice
        + Id  : ISO20022.Auth090001.PartyIdentification248Choice
    }
    ISO20022.Auth090001.Counterparty45 *-- ISO20022.Auth090001.ReportingExemption1
    ISO20022.Auth090001.Counterparty45 *-- ISO20022.Auth090001.Direction4Choice
    ISO20022.Auth090001.Counterparty45 *-- ISO20022.Auth090001.CounterpartyTradeNature15Choice
    ISO20022.Auth090001.Counterparty45 *-- ISO20022.Auth090001.PartyIdentification248Choice
    class ISO20022.Auth090001.Counterparty46 {
        + RptgOblgtn  : String
        + Ntr  : ISO20022.Auth090001.CounterpartyTradeNature15Choice
        + IdTp  : ISO20022.Auth090001.PartyIdentification248Choice
    }
    ISO20022.Auth090001.Counterparty46 *-- ISO20022.Auth090001.CounterpartyTradeNature15Choice
    ISO20022.Auth090001.Counterparty46 *-- ISO20022.Auth090001.PartyIdentification248Choice
    class ISO20022.Auth090001.CounterpartyTradeNature15Choice {
        + Othr  : String
        + CntrlCntrPty  : String
        + NFI  : ISO20022.Auth090001.NonFinancialInstitutionSector10
        + FI  : ISO20022.Auth090001.FinancialInstitutionSector1
    }
    ISO20022.Auth090001.CounterpartyTradeNature15Choice *-- ISO20022.Auth090001.NonFinancialInstitutionSector10
    ISO20022.Auth090001.CounterpartyTradeNature15Choice *-- ISO20022.Auth090001.FinancialInstitutionSector1
    class ISO20022.Auth090001.CreditDerivative7 {
        + TrchInd  : String
        + IndxFctr  : Decimal
        + Vrsn  : Decimal
        + Srs  : Decimal
        + ClctnBsis  : String
        + PmtFrqcy  : String
        + RefPty  : ISO20022.Auth090001.DerivativePartyIdentification1Choice
        + Snrty  : String
    }
    ISO20022.Auth090001.CreditDerivative7 *-- ISO20022.Auth090001.DerivativePartyIdentification1Choice
    class ISO20022.Auth090001.CustomBasket4 {
        + Cnsttnts  : global::System.Collections.Generic.List~ISO20022.Auth090001.BasketConstituents3~
        + Id  : String
        + Strr  : String
    }
    ISO20022.Auth090001.CustomBasket4 *-- ISO20022.Auth090001.BasketConstituents3
    class ISO20022.Auth090001.DebtInstrumentSeniorityType2Code {
        OTHR = 1
        SNDB = 2
        SBOD = 3
    }
    class ISO20022.Auth090001.DerivativePartyIdentification1Choice {
        + LEI  : String
        + CtrySubDvsn  : String
        + Ctry  : String
    }
    class ISO20022.Auth090001.DerivativesTradePositionSetReportV02 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth090001.SupplementaryData1~
        + AggtdPos  : ISO20022.Auth090001.PositionSetAggregated2Choice
    }
    ISO20022.Auth090001.DerivativesTradePositionSetReportV02 *-- ISO20022.Auth090001.SupplementaryData1
    ISO20022.Auth090001.DerivativesTradePositionSetReportV02 *-- ISO20022.Auth090001.PositionSetAggregated2Choice
    class ISO20022.Auth090001.Direction2 {
        + DrctnOfTheScndLeg  : String
        + DrctnOfTheFrstLeg  : String
    }
    class ISO20022.Auth090001.Direction4Choice {
        + CtrPtySd  : String
        + Drctn  : ISO20022.Auth090001.Direction2
    }
    ISO20022.Auth090001.Direction4Choice *-- ISO20022.Auth090001.Direction2
    class ISO20022.Auth090001.EnergyCommodityCoal2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.EnergyCommodityDistillates2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.EnergyCommodityElectricity2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.EnergyCommodityInterEnergy2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.EnergyCommodityLightEnd2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.EnergyCommodityNaturalGas3 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.EnergyCommodityOil3 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.EnergyCommodityOther2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.EnergyCommodityRenewableEnergy2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.EnvironmentCommodityOther2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.EnvironmentalCommodityCarbonRelated2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.EnvironmentalCommodityEmission3 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.EnvironmentalCommodityWeather2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.ExchangeRateBasis1 {
        + QtdCcy  : String
        + BaseCcy  : String
    }
    class ISO20022.Auth090001.ExchangeRateBasis1Choice {
        + Prtry  : String
        + CcyPair  : ISO20022.Auth090001.ExchangeRateBasis1
    }
    ISO20022.Auth090001.ExchangeRateBasis1Choice *-- ISO20022.Auth090001.ExchangeRateBasis1
    class ISO20022.Auth090001.FertilizerCommodityAmmonia2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.FertilizerCommodityDiammoniumPhosphate2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.FertilizerCommodityOther2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.FertilizerCommodityPotash2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.FertilizerCommoditySulphur2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.FertilizerCommodityUrea2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.FertilizerCommodityUreaAndAmmoniumNitrate2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.FinancialInstitutionSector1 {
        + ClrThrshld  : String
        + Sctr  : global::System.Collections.Generic.List~ISO20022.Auth090001.FinancialPartyClassification2Choice~
    }
    ISO20022.Auth090001.FinancialInstitutionSector1 *-- ISO20022.Auth090001.FinancialPartyClassification2Choice
    class ISO20022.Auth090001.FinancialInstrumentContractType2Code {
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
    class ISO20022.Auth090001.FinancialPartyClassification2Choice {
        + Prtry  : ISO20022.Auth090001.GenericIdentification175
        + Cd  : String
    }
    ISO20022.Auth090001.FinancialPartyClassification2Choice *-- ISO20022.Auth090001.GenericIdentification175
    class ISO20022.Auth090001.FinancialPartySectorType3Code {
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
    class ISO20022.Auth090001.FreightCommodityContainerShip2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.FreightCommodityDry3 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.FreightCommodityOther2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.FreightCommodityWet3 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.Frequency13Code {
        QURT = 1
        MIAN = 2
        EXPI = 3
        ADHO = 4
        YEAR = 5
        MNTH = 6
        WEEK = 7
        DAIL = 8
    }
    class ISO20022.Auth090001.GenericIdentification175 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Auth090001.GenericIdentification184 {
        + Src  : String
        + Id  : String
    }
    class ISO20022.Auth090001.GenericIdentification185 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Auth090001.IndexIdentification1 {
        + Indx  : String
        + Nm  : String
        + ISIN  : String
    }
    class ISO20022.Auth090001.IndustrialProductCommodityConstruction2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.IndustrialProductCommodityManufacturing2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.InstrumentIdentification6Choice {
        + OthrId  : ISO20022.Auth090001.GenericIdentification184
        + UnqPdctIdr  : ISO20022.Auth090001.UniqueProductIdentifier1Choice
        + AltrntvInstrmId  : String
        + ISIN  : String
    }
    ISO20022.Auth090001.InstrumentIdentification6Choice *-- ISO20022.Auth090001.GenericIdentification184
    ISO20022.Auth090001.InstrumentIdentification6Choice *-- ISO20022.Auth090001.UniqueProductIdentifier1Choice
    class ISO20022.Auth090001.LegalPersonIdentification1 {
        + Ctry  : String
        + Id  : ISO20022.Auth090001.OrganisationIdentification15Choice
    }
    ISO20022.Auth090001.LegalPersonIdentification1 *-- ISO20022.Auth090001.OrganisationIdentification15Choice
    class ISO20022.Auth090001.MarginCollateralReport4 {
        + TmStmp  : DateTime
        + CollstnCtgy  : String
        + CollPrtflCd  : ISO20022.Auth090001.CollateralPortfolioCode5Choice
    }
    ISO20022.Auth090001.MarginCollateralReport4 *-- ISO20022.Auth090001.CollateralPortfolioCode5Choice
    class ISO20022.Auth090001.MarginPortfolio3 {
        + VartnMrgnPrtflCd  : ISO20022.Auth090001.PortfolioCode5Choice
        + InitlMrgnPrtflCd  : ISO20022.Auth090001.PortfolioCode5Choice
    }
    ISO20022.Auth090001.MarginPortfolio3 *-- ISO20022.Auth090001.PortfolioCode5Choice
    ISO20022.Auth090001.MarginPortfolio3 *-- ISO20022.Auth090001.PortfolioCode5Choice
    class ISO20022.Auth090001.MasterAgreement8 {
        + OthrMstrAgrmtDtls  : String
        + Vrsn  : String
        + Tp  : ISO20022.Auth090001.AgreementType2Choice
    }
    ISO20022.Auth090001.MasterAgreement8 *-- ISO20022.Auth090001.AgreementType2Choice
    class ISO20022.Auth090001.MaturityTerm2 {
        + Val  : Decimal
        + Unit  : String
    }
    class ISO20022.Auth090001.MetalCommodityNonPrecious2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.MetalCommodityPrecious2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.NaturalPersonIdentification2 {
        + Dmcl  : String
        + Nm  : String
        + Id  : ISO20022.Auth090001.GenericIdentification175
    }
    ISO20022.Auth090001.NaturalPersonIdentification2 *-- ISO20022.Auth090001.GenericIdentification175
    class ISO20022.Auth090001.NaturalPersonIdentification3 {
        + Ctry  : String
        + Id  : ISO20022.Auth090001.NaturalPersonIdentification2
    }
    ISO20022.Auth090001.NaturalPersonIdentification3 *-- ISO20022.Auth090001.NaturalPersonIdentification2
    class ISO20022.Auth090001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Auth090001.NonFinancialInstitutionSector10 {
        + FdrlInstn  : String
        + DrctlyLkdActvty  : String
        + ClrThrshld  : String
        + Sctr  : global::System.Collections.Generic.List~ISO20022.Auth090001.GenericIdentification175~
    }
    ISO20022.Auth090001.NonFinancialInstitutionSector10 *-- ISO20022.Auth090001.GenericIdentification175
    class ISO20022.Auth090001.NotApplicable1Code {
        NOAP = 1
    }
    class ISO20022.Auth090001.NotionalAmount7 {
        + WghtdAvrgDlta  : Decimal
        + AmtInFct  : global::System.Collections.Generic.List~ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd19DecimalAmount~
        + Amt  : ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd19DecimalAmount
    }
    ISO20022.Auth090001.NotionalAmount7 *-- ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd19DecimalAmount
    ISO20022.Auth090001.NotionalAmount7 *-- ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd19DecimalAmount
    class ISO20022.Auth090001.NotionalAmountLegs6 {
        + ScndLeg  : ISO20022.Auth090001.NotionalAmount7
        + FrstLeg  : ISO20022.Auth090001.NotionalAmount7
    }
    ISO20022.Auth090001.NotionalAmountLegs6 *-- ISO20022.Auth090001.NotionalAmount7
    ISO20022.Auth090001.NotionalAmountLegs6 *-- ISO20022.Auth090001.NotionalAmount7
    class ISO20022.Auth090001.OptionParty1Code {
        BYER = 1
        SLLR = 2
    }
    class ISO20022.Auth090001.OptionParty3Code {
        TAKE = 1
        MAKE = 2
    }
    class ISO20022.Auth090001.OptionType2Code {
        OTHR = 1
        PUTO = 2
        CALL = 3
    }
    class ISO20022.Auth090001.OrganisationIdentification15Choice {
        + AnyBIC  : String
        + Othr  : ISO20022.Auth090001.OrganisationIdentification38
        + LEI  : String
    }
    ISO20022.Auth090001.OrganisationIdentification15Choice *-- ISO20022.Auth090001.OrganisationIdentification38
    class ISO20022.Auth090001.OrganisationIdentification38 {
        + Dmcl  : String
        + Nm  : String
        + Id  : ISO20022.Auth090001.GenericIdentification175
    }
    ISO20022.Auth090001.OrganisationIdentification38 *-- ISO20022.Auth090001.GenericIdentification175
    class ISO20022.Auth090001.OtherPayment6 {
        + PmtRcvr  : ISO20022.Auth090001.PartyIdentification236Choice
        + PmtPyer  : ISO20022.Auth090001.PartyIdentification236Choice
        + PmtDt  : DateTime
        + PmtTp  : ISO20022.Auth090001.PaymentType5Choice
        + PmtCcy  : String
    }
    ISO20022.Auth090001.OtherPayment6 *-- ISO20022.Auth090001.PartyIdentification236Choice
    ISO20022.Auth090001.OtherPayment6 *-- ISO20022.Auth090001.PartyIdentification236Choice
    ISO20022.Auth090001.OtherPayment6 *-- ISO20022.Auth090001.PaymentType5Choice
    class ISO20022.Auth090001.PaperCommodityContainerBoard2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.PaperCommodityNewsprint2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.PaperCommodityOther1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.PaperCommodityPulp2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.PartyIdentification236Choice {
        + Ntrl  : ISO20022.Auth090001.NaturalPersonIdentification2
        + Lgl  : ISO20022.Auth090001.OrganisationIdentification15Choice
    }
    ISO20022.Auth090001.PartyIdentification236Choice *-- ISO20022.Auth090001.NaturalPersonIdentification2
    ISO20022.Auth090001.PartyIdentification236Choice *-- ISO20022.Auth090001.OrganisationIdentification15Choice
    class ISO20022.Auth090001.PartyIdentification248Choice {
        + Ntrl  : ISO20022.Auth090001.NaturalPersonIdentification3
        + Lgl  : ISO20022.Auth090001.LegalPersonIdentification1
    }
    ISO20022.Auth090001.PartyIdentification248Choice *-- ISO20022.Auth090001.NaturalPersonIdentification3
    ISO20022.Auth090001.PartyIdentification248Choice *-- ISO20022.Auth090001.LegalPersonIdentification1
    class ISO20022.Auth090001.PaymentType4Code {
        PEXH = 1
        UWIN = 2
        UFRO = 3
    }
    class ISO20022.Auth090001.PaymentType5Choice {
        + PrtryTp  : String
        + Tp  : String
    }
    class ISO20022.Auth090001.PolypropyleneCommodityOther2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.PolypropyleneCommodityPlastic2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth090001.PortfolioCode3Choice {
        + NoPrtfl  : String
        + Cd  : String
    }
    class ISO20022.Auth090001.PortfolioCode5Choice {
        + NoPrtfl  : String
        + Prtfl  : ISO20022.Auth090001.PortfolioIdentification3
    }
    ISO20022.Auth090001.PortfolioCode5Choice *-- ISO20022.Auth090001.PortfolioIdentification3
    class ISO20022.Auth090001.PortfolioIdentification3 {
        + PrtflTxXmptn  : String
        + Cd  : String
    }
    class ISO20022.Auth090001.PositionSet21 {
        + Mtrcs  : ISO20022.Auth090001.PositionSetMetrics14
        + Dmnsns  : ISO20022.Auth090001.PositionSetDimensions16
    }
    ISO20022.Auth090001.PositionSet21 *-- ISO20022.Auth090001.PositionSetMetrics14
    ISO20022.Auth090001.PositionSet21 *-- ISO20022.Auth090001.PositionSetDimensions16
    class ISO20022.Auth090001.PositionSet22 {
        + Mtrcs  : ISO20022.Auth090001.PositionSetCollateralMetrics2
        + Dmnsns  : ISO20022.Auth090001.PositionSetCollateralDimensions3
    }
    ISO20022.Auth090001.PositionSet22 *-- ISO20022.Auth090001.PositionSetCollateralMetrics2
    ISO20022.Auth090001.PositionSet22 *-- ISO20022.Auth090001.PositionSetCollateralDimensions3
    class ISO20022.Auth090001.PositionSetAggregated2Choice {
        + Rpt  : ISO20022.Auth090001.PositionSetAggregated4
        + DataSetActn  : String
    }
    ISO20022.Auth090001.PositionSetAggregated2Choice *-- ISO20022.Auth090001.PositionSetAggregated4
    class ISO20022.Auth090001.PositionSetAggregated4 {
        + CcyCollPosSet  : global::System.Collections.Generic.List~ISO20022.Auth090001.PositionSet22~
        + CollPosSet  : global::System.Collections.Generic.List~ISO20022.Auth090001.PositionSet22~
        + CcyPosSet  : global::System.Collections.Generic.List~ISO20022.Auth090001.PositionSet21~
        + PosSet  : global::System.Collections.Generic.List~ISO20022.Auth090001.PositionSet21~
        + RefDt  : DateTime
    }
    ISO20022.Auth090001.PositionSetAggregated4 *-- ISO20022.Auth090001.PositionSet22
    ISO20022.Auth090001.PositionSetAggregated4 *-- ISO20022.Auth090001.PositionSet22
    ISO20022.Auth090001.PositionSetAggregated4 *-- ISO20022.Auth090001.PositionSet21
    ISO20022.Auth090001.PositionSetAggregated4 *-- ISO20022.Auth090001.PositionSet21
    class ISO20022.Auth090001.PositionSetBuyerAndSeller2 {
        + Sellr  : ISO20022.Auth090001.PositionSetTotal2
        + Buyr  : ISO20022.Auth090001.PositionSetTotal2
    }
    ISO20022.Auth090001.PositionSetBuyerAndSeller2 *-- ISO20022.Auth090001.PositionSetTotal2
    ISO20022.Auth090001.PositionSetBuyerAndSeller2 *-- ISO20022.Auth090001.PositionSetTotal2
    class ISO20022.Auth090001.PositionSetCollateralDimensions3 {
        + XcssCollRcvdCcy  : String
        + XcssCollPstdCcy  : String
        + VartnMrgnRcvdCcy  : String
        + InitlMrgnRcvdCcy  : String
        + VartnMrgnPstdCcy  : String
        + InitlMrgnPstdCcy  : String
        + Coll  : ISO20022.Auth090001.MarginCollateralReport4
        + CtrPtyId  : ISO20022.Auth090001.TradeCounterpartyReport20
    }
    ISO20022.Auth090001.PositionSetCollateralDimensions3 *-- ISO20022.Auth090001.MarginCollateralReport4
    ISO20022.Auth090001.PositionSetCollateralDimensions3 *-- ISO20022.Auth090001.TradeCounterpartyReport20
    class ISO20022.Auth090001.PositionSetCollateralMetrics2 {
        + Clean  : ISO20022.Auth090001.PositionSetCollateralTotal2
        + Ttl  : ISO20022.Auth090001.PositionSetCollateralTotal2
    }
    ISO20022.Auth090001.PositionSetCollateralMetrics2 *-- ISO20022.Auth090001.PositionSetCollateralTotal2
    ISO20022.Auth090001.PositionSetCollateralMetrics2 *-- ISO20022.Auth090001.PositionSetCollateralTotal2
    class ISO20022.Auth090001.PositionSetCollateralTotal2 {
        + RcvdMrgnOrColl  : ISO20022.Auth090001.ReceivedMarginOrCollateral6
        + PstdMrgnOrColl  : ISO20022.Auth090001.PostedMarginOrCollateral6
        + NbOfRpts  : Decimal
    }
    ISO20022.Auth090001.PositionSetCollateralTotal2 *-- ISO20022.Auth090001.ReceivedMarginOrCollateral6
    ISO20022.Auth090001.PositionSetCollateralTotal2 *-- ISO20022.Auth090001.PostedMarginOrCollateral6
    class ISO20022.Auth090001.PositionSetDimensions16 {
        + OthrPmt  : ISO20022.Auth090001.OtherPayment6
        + Cmmdty  : ISO20022.Auth090001.AssetClassCommodity6Choice
        + Cdt  : ISO20022.Auth090001.CreditDerivative7
        + IRSTp  : String
        + TmToMtrty  : ISO20022.Auth090001.TimeToMaturity1Choice
        + OptnTp  : String
        + XchgRateBsis  : ISO20022.Auth090001.ExchangeRateBasis1Choice
        + IntraGrp  : String
        + Clrd  : String
        + MstrAgrmt  : ISO20022.Auth090001.MasterAgreement8
        + SttlmCcyScndLeg  : String
        + SttlmCcy  : String
        + NtnlCcyScndLeg  : String
        + NtnlCcy  : String
        + UndrlygInstrm  : ISO20022.Auth090001.SecurityIdentification41Choice
        + AsstClss  : String
        + CtrctTp  : String
        + Coll  : ISO20022.Auth090001.MarginCollateralReport4
        + ValCcy  : String
        + CtrPtyId  : ISO20022.Auth090001.TradeCounterpartyReport20
    }
    ISO20022.Auth090001.PositionSetDimensions16 *-- ISO20022.Auth090001.OtherPayment6
    ISO20022.Auth090001.PositionSetDimensions16 *-- ISO20022.Auth090001.AssetClassCommodity6Choice
    ISO20022.Auth090001.PositionSetDimensions16 *-- ISO20022.Auth090001.CreditDerivative7
    ISO20022.Auth090001.PositionSetDimensions16 *-- ISO20022.Auth090001.TimeToMaturity1Choice
    ISO20022.Auth090001.PositionSetDimensions16 *-- ISO20022.Auth090001.ExchangeRateBasis1Choice
    ISO20022.Auth090001.PositionSetDimensions16 *-- ISO20022.Auth090001.MasterAgreement8
    ISO20022.Auth090001.PositionSetDimensions16 *-- ISO20022.Auth090001.SecurityIdentification41Choice
    ISO20022.Auth090001.PositionSetDimensions16 *-- ISO20022.Auth090001.MarginCollateralReport4
    ISO20022.Auth090001.PositionSetDimensions16 *-- ISO20022.Auth090001.TradeCounterpartyReport20
    class ISO20022.Auth090001.PositionSetMetrics14 {
        + Clean  : ISO20022.Auth090001.PositionSetBuyerAndSeller2
        + Ttl  : ISO20022.Auth090001.PositionSetBuyerAndSeller2
    }
    ISO20022.Auth090001.PositionSetMetrics14 *-- ISO20022.Auth090001.PositionSetBuyerAndSeller2
    ISO20022.Auth090001.PositionSetMetrics14 *-- ISO20022.Auth090001.PositionSetBuyerAndSeller2
    class ISO20022.Auth090001.PositionSetTotal2 {
        + OthrPmtAmt  : global::System.Collections.Generic.List~ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd19DecimalAmount~
        + Ntnl  : ISO20022.Auth090001.NotionalAmountLegs6
        + NegVal  : ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd19DecimalAmount
        + PostvVal  : ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd19DecimalAmount
        + NbOfTrds  : Decimal
    }
    ISO20022.Auth090001.PositionSetTotal2 *-- ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd19DecimalAmount
    ISO20022.Auth090001.PositionSetTotal2 *-- ISO20022.Auth090001.NotionalAmountLegs6
    ISO20022.Auth090001.PositionSetTotal2 *-- ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd19DecimalAmount
    ISO20022.Auth090001.PositionSetTotal2 *-- ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd19DecimalAmount
    class ISO20022.Auth090001.PostedMarginOrCollateral6 {
        + XcssCollPstd  : ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount
        + VartnMrgnPstdPstHrcut  : ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount
        + VartnMrgnPstdPreHrcut  : ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount
        + InitlMrgnPstdPstHrcut  : ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount
        + InitlMrgnPstdPreHrcut  : ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    }
    ISO20022.Auth090001.PostedMarginOrCollateral6 *-- ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    ISO20022.Auth090001.PostedMarginOrCollateral6 *-- ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    ISO20022.Auth090001.PostedMarginOrCollateral6 *-- ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    ISO20022.Auth090001.PostedMarginOrCollateral6 *-- ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    ISO20022.Auth090001.PostedMarginOrCollateral6 *-- ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    class ISO20022.Auth090001.ProductType4Code {
        OTHR = 1
        COMM = 2
        INTR = 3
        EQUI = 4
        CURR = 5
        CRDT = 6
    }
    class ISO20022.Auth090001.RateBasis1Code {
        YEAR = 1
        WEEK = 2
        MNTH = 3
        DAYS = 4
    }
    class ISO20022.Auth090001.ReceivedMarginOrCollateral6 {
        + XcssCollRcvd  : ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount
        + VartnMrgnRcvdPstHrcut  : ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount
        + VartnMrgnRcvdPreHrcut  : ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount
        + InitlMrgnRcvdPstHrcut  : ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount
        + InitlMrgnRcvdPreHrcut  : ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    }
    ISO20022.Auth090001.ReceivedMarginOrCollateral6 *-- ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    ISO20022.Auth090001.ReceivedMarginOrCollateral6 *-- ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    ISO20022.Auth090001.ReceivedMarginOrCollateral6 *-- ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    ISO20022.Auth090001.ReceivedMarginOrCollateral6 *-- ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    ISO20022.Auth090001.ReceivedMarginOrCollateral6 *-- ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    class ISO20022.Auth090001.ReportPeriodActivity1Code {
        NOTX = 1
    }
    class ISO20022.Auth090001.ReportingExemption1 {
        + Desc  : String
        + Rsn  : String
    }
    class ISO20022.Auth090001.SecurityIdentification41Choice {
        + IdNotAvlbl  : String
        + Othr  : ISO20022.Auth090001.GenericIdentification184
        + Indx  : ISO20022.Auth090001.IndexIdentification1
        + Bskt  : ISO20022.Auth090001.CustomBasket4
        + UnqPdctIdr  : ISO20022.Auth090001.UniqueProductIdentifier2Choice
        + AltrntvInstrmId  : String
        + ISIN  : String
    }
    ISO20022.Auth090001.SecurityIdentification41Choice *-- ISO20022.Auth090001.GenericIdentification184
    ISO20022.Auth090001.SecurityIdentification41Choice *-- ISO20022.Auth090001.IndexIdentification1
    ISO20022.Auth090001.SecurityIdentification41Choice *-- ISO20022.Auth090001.CustomBasket4
    ISO20022.Auth090001.SecurityIdentification41Choice *-- ISO20022.Auth090001.UniqueProductIdentifier2Choice
    class ISO20022.Auth090001.SpecialPurpose2Code {
        NTAV = 1
        BLNK = 2
    }
    class ISO20022.Auth090001.SupplementaryData1 {
        + Envlp  : ISO20022.Auth090001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Auth090001.SupplementaryData1 *-- ISO20022.Auth090001.SupplementaryDataEnvelope1
    class ISO20022.Auth090001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Auth090001.TimeToMaturity1Choice {
        + Spcl  : String
        + Prd  : ISO20022.Auth090001.TimeToMaturityPeriod1
    }
    ISO20022.Auth090001.TimeToMaturity1Choice *-- ISO20022.Auth090001.TimeToMaturityPeriod1
    class ISO20022.Auth090001.TimeToMaturityPeriod1 {
        + End  : ISO20022.Auth090001.MaturityTerm2
        + Start  : ISO20022.Auth090001.MaturityTerm2
    }
    ISO20022.Auth090001.TimeToMaturityPeriod1 *-- ISO20022.Auth090001.MaturityTerm2
    ISO20022.Auth090001.TimeToMaturityPeriod1 *-- ISO20022.Auth090001.MaturityTerm2
    class ISO20022.Auth090001.TradeCounterpartyRelationship1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Auth090001.TradeCounterpartyRelationshipRecord1 {
        + Desc  : String
        + RltshTp  : ISO20022.Auth090001.TradeCounterpartyRelationship1Choice
        + EndRltshPty  : String
        + StartRltshPty  : String
    }
    ISO20022.Auth090001.TradeCounterpartyRelationshipRecord1 *-- ISO20022.Auth090001.TradeCounterpartyRelationship1Choice
    class ISO20022.Auth090001.TradeCounterpartyReport20 {
        + RltshRcrd  : global::System.Collections.Generic.List~ISO20022.Auth090001.TradeCounterpartyRelationshipRecord1~
        + ExctnAgt  : global::System.Collections.Generic.List~ISO20022.Auth090001.OrganisationIdentification15Choice~
        + NttyRspnsblForRpt  : ISO20022.Auth090001.OrganisationIdentification15Choice
        + Bnfcry  : global::System.Collections.Generic.List~ISO20022.Auth090001.PartyIdentification248Choice~
        + ClrMmb  : ISO20022.Auth090001.PartyIdentification248Choice
        + SubmitgAgt  : ISO20022.Auth090001.OrganisationIdentification15Choice
        + Brkr  : ISO20022.Auth090001.OrganisationIdentification15Choice
        + OthrCtrPty  : ISO20022.Auth090001.Counterparty46
        + RptgCtrPty  : ISO20022.Auth090001.Counterparty45
    }
    ISO20022.Auth090001.TradeCounterpartyReport20 *-- ISO20022.Auth090001.TradeCounterpartyRelationshipRecord1
    ISO20022.Auth090001.TradeCounterpartyReport20 *-- ISO20022.Auth090001.OrganisationIdentification15Choice
    ISO20022.Auth090001.TradeCounterpartyReport20 *-- ISO20022.Auth090001.OrganisationIdentification15Choice
    ISO20022.Auth090001.TradeCounterpartyReport20 *-- ISO20022.Auth090001.PartyIdentification248Choice
    ISO20022.Auth090001.TradeCounterpartyReport20 *-- ISO20022.Auth090001.PartyIdentification248Choice
    ISO20022.Auth090001.TradeCounterpartyReport20 *-- ISO20022.Auth090001.OrganisationIdentification15Choice
    ISO20022.Auth090001.TradeCounterpartyReport20 *-- ISO20022.Auth090001.OrganisationIdentification15Choice
    ISO20022.Auth090001.TradeCounterpartyReport20 *-- ISO20022.Auth090001.Counterparty46
    ISO20022.Auth090001.TradeCounterpartyReport20 *-- ISO20022.Auth090001.Counterparty45
    class ISO20022.Auth090001.TradeCounterpartyType1Code {
        ERFR = 1
        SBMA = 2
        REPC = 3
        OTHC = 4
        EXEA = 5
        CLEM = 6
        BROK = 7
        BENE = 8
    }
    class ISO20022.Auth090001.TradingCapacity7Code {
        PRIN = 1
        AGEN = 2
    }
    class ISO20022.Auth090001.UnderlyingIdentification1Code {
        INDX = 1
        BSKT = 2
        UKWN = 3
    }
    class ISO20022.Auth090001.UniqueProductIdentifier1Choice {
        + Prtry  : ISO20022.Auth090001.GenericIdentification175
        + Id  : String
    }
    ISO20022.Auth090001.UniqueProductIdentifier1Choice *-- ISO20022.Auth090001.GenericIdentification175
    class ISO20022.Auth090001.UniqueProductIdentifier2Choice {
        + Prtry  : ISO20022.Auth090001.GenericIdentification185
        + Id  : String
    }
    ISO20022.Auth090001.UniqueProductIdentifier2Choice *-- ISO20022.Auth090001.GenericIdentification185
    class ISO20022.Auth090001.UnitOfMeasure8Choice {
        + Prtry  : ISO20022.Auth090001.GenericIdentification175
        + Cd  : String
    }
    ISO20022.Auth090001.UnitOfMeasure8Choice *-- ISO20022.Auth090001.GenericIdentification175
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

## Value ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd19DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth090001.AgreementType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Tp))|

---

## Value ISO20022.Auth090001.AgriculturalCommodityDairy2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.AgriculturalCommodityForestry2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.AgriculturalCommodityGrain3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.AgriculturalCommodityLiveStock2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.AgriculturalCommodityOilSeed2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.AgriculturalCommodityOliveOil3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.AgriculturalCommodityOther2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.AgriculturalCommodityPotato2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.AgriculturalCommoditySeafood2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.AgriculturalCommoditySoft2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.AssetClassCommodity6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Plprpln|ISO20022.Auth090001.AssetClassCommodityPolypropylene4Choice||XmlElement()||
|+|Ppr|ISO20022.Auth090001.AssetClassCommodityPaper4Choice||XmlElement()||
|+|OthrC10|ISO20022.Auth090001.AssetClassCommodityC10Other1||XmlElement()||
|+|Othr|ISO20022.Auth090001.AssetClassCommodityOther1||XmlElement()||
|+|OffclEcnmcSttstcs|ISO20022.Auth090001.AssetClassCommodityOfficialEconomicStatistics1||XmlElement()||
|+|MultiCmmdtyExtc|ISO20022.Auth090001.AssetClassCommodityMultiCommodityExotic1||XmlElement()||
|+|Metl|ISO20022.Auth090001.AssetClassCommodityMetal2Choice||XmlElement()||
|+|Infltn|ISO20022.Auth090001.AssetClassCommodityInflation1||XmlElement()||
|+|IndstrlPdct|ISO20022.Auth090001.AssetClassCommodityIndustrialProduct2Choice||XmlElement()||
|+|Indx|ISO20022.Auth090001.AssetClassCommodityIndex1||XmlElement()||
|+|Frght|ISO20022.Auth090001.AssetClassCommodityFreight4Choice||XmlElement()||
|+|Frtlzr|ISO20022.Auth090001.AssetClassCommodityFertilizer4Choice||XmlElement()||
|+|Envttl|ISO20022.Auth090001.AssetClassCommodityEnvironmental3Choice||XmlElement()||
|+|Nrgy|ISO20022.Auth090001.AssetClassCommodityEnergy3Choice||XmlElement()||
|+|Agrcltrl|ISO20022.Auth090001.AssetClassCommodityAgricultural6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Plprpln),validElement(Ppr),validElement(OthrC10),validElement(Othr),validElement(OffclEcnmcSttstcs),validElement(MultiCmmdtyExtc),validElement(Metl),validElement(Infltn),validElement(IndstrlPdct),validElement(Indx),validElement(Frght),validElement(Frtlzr),validElement(Envttl),validElement(Nrgy),validElement(Agrcltrl),validChoice(Plprpln,Ppr,OthrC10,Othr,OffclEcnmcSttstcs,MultiCmmdtyExtc,Metl,Infltn,IndstrlPdct,Indx,Frght,Frtlzr,Envttl,Nrgy,Agrcltrl))|

---

## Value ISO20022.Auth090001.AssetClassCommodityAgricultural6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth090001.AgriculturalCommodityOther2||XmlElement()||
|+|Grn|ISO20022.Auth090001.AgriculturalCommodityGrain3||XmlElement()||
|+|LiveStock|ISO20022.Auth090001.AgriculturalCommodityLiveStock2||XmlElement()||
|+|Sfd|ISO20022.Auth090001.AgriculturalCommoditySeafood2||XmlElement()||
|+|Frstry|ISO20022.Auth090001.AgriculturalCommodityForestry2||XmlElement()||
|+|Dairy|ISO20022.Auth090001.AgriculturalCommodityDairy2||XmlElement()||
|+|OlvOil|ISO20022.Auth090001.AgriculturalCommodityOliveOil3||XmlElement()||
|+|Ptt|ISO20022.Auth090001.AgriculturalCommodityPotato2||XmlElement()||
|+|Soft|ISO20022.Auth090001.AgriculturalCommoditySoft2||XmlElement()||
|+|GrnOilSeed|ISO20022.Auth090001.AgriculturalCommodityOilSeed2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(Grn),validElement(LiveStock),validElement(Sfd),validElement(Frstry),validElement(Dairy),validElement(OlvOil),validElement(Ptt),validElement(Soft),validElement(GrnOilSeed),validChoice(Othr,Grn,LiveStock,Sfd,Frstry,Dairy,OlvOil,Ptt,Soft,GrnOilSeed))|

---

## Value ISO20022.Auth090001.AssetClassCommodityC10Other1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.AssetClassCommodityEnergy3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth090001.EnergyCommodityOther2||XmlElement()||
|+|Dstllts|ISO20022.Auth090001.EnergyCommodityDistillates2||XmlElement()||
|+|LghtEnd|ISO20022.Auth090001.EnergyCommodityLightEnd2||XmlElement()||
|+|RnwblNrgy|ISO20022.Auth090001.EnergyCommodityRenewableEnergy2||XmlElement()||
|+|IntrNrgy|ISO20022.Auth090001.EnergyCommodityInterEnergy2||XmlElement()||
|+|Coal|ISO20022.Auth090001.EnergyCommodityCoal2||XmlElement()||
|+|Oil|ISO20022.Auth090001.EnergyCommodityOil3||XmlElement()||
|+|NtrlGas|ISO20022.Auth090001.EnergyCommodityNaturalGas3||XmlElement()||
|+|Elctrcty|ISO20022.Auth090001.EnergyCommodityElectricity2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(Dstllts),validElement(LghtEnd),validElement(RnwblNrgy),validElement(IntrNrgy),validElement(Coal),validElement(Oil),validElement(NtrlGas),validElement(Elctrcty),validChoice(Othr,Dstllts,LghtEnd,RnwblNrgy,IntrNrgy,Coal,Oil,NtrlGas,Elctrcty))|

---

## Value ISO20022.Auth090001.AssetClassCommodityEnvironmental3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth090001.EnvironmentCommodityOther2||XmlElement()||
|+|CrbnRltd|ISO20022.Auth090001.EnvironmentalCommodityCarbonRelated2||XmlElement()||
|+|Wthr|ISO20022.Auth090001.EnvironmentalCommodityWeather2||XmlElement()||
|+|Emssns|ISO20022.Auth090001.EnvironmentalCommodityEmission3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(CrbnRltd),validElement(Wthr),validElement(Emssns),validChoice(Othr,CrbnRltd,Wthr,Emssns))|

---

## Value ISO20022.Auth090001.AssetClassCommodityFertilizer4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth090001.FertilizerCommodityOther2||XmlElement()||
|+|UreaAndAmmnmNtrt|ISO20022.Auth090001.FertilizerCommodityUreaAndAmmoniumNitrate2||XmlElement()||
|+|Urea|ISO20022.Auth090001.FertilizerCommodityUrea2||XmlElement()||
|+|Slphr|ISO20022.Auth090001.FertilizerCommoditySulphur2||XmlElement()||
|+|Ptsh|ISO20022.Auth090001.FertilizerCommodityPotash2||XmlElement()||
|+|DmmnmPhspht|ISO20022.Auth090001.FertilizerCommodityDiammoniumPhosphate2||XmlElement()||
|+|Ammn|ISO20022.Auth090001.FertilizerCommodityAmmonia2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(UreaAndAmmnmNtrt),validElement(Urea),validElement(Slphr),validElement(Ptsh),validElement(DmmnmPhspht),validElement(Ammn),validChoice(Othr,UreaAndAmmnmNtrt,Urea,Slphr,Ptsh,DmmnmPhspht,Ammn))|

---

## Value ISO20022.Auth090001.AssetClassCommodityFreight4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth090001.FreightCommodityOther2||XmlElement()||
|+|CntnrShip|ISO20022.Auth090001.FreightCommodityContainerShip2||XmlElement()||
|+|Wet|ISO20022.Auth090001.FreightCommodityWet3||XmlElement()||
|+|Dry|ISO20022.Auth090001.FreightCommodityDry3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(CntnrShip),validElement(Wet),validElement(Dry),validChoice(Othr,CntnrShip,Wet,Dry))|

---

## Value ISO20022.Auth090001.AssetClassCommodityIndex1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.AssetClassCommodityIndustrialProduct2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Manfctg|ISO20022.Auth090001.IndustrialProductCommodityManufacturing2||XmlElement()||
|+|Cnstrctn|ISO20022.Auth090001.IndustrialProductCommodityConstruction2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Manfctg),validElement(Cnstrctn),validChoice(Manfctg,Cnstrctn))|

---

## Value ISO20022.Auth090001.AssetClassCommodityInflation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.AssetClassCommodityMetal2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prcs|ISO20022.Auth090001.MetalCommodityPrecious2||XmlElement()||
|+|NonPrcs|ISO20022.Auth090001.MetalCommodityNonPrecious2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prcs),validElement(NonPrcs),validChoice(Prcs,NonPrcs))|

---

## Value ISO20022.Auth090001.AssetClassCommodityMultiCommodityExotic1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.AssetClassCommodityOfficialEconomicStatistics1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.AssetClassCommodityOther1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.AssetClassCommodityPaper4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth090001.PaperCommodityOther1||XmlElement()||
|+|RcvrdPpr|ISO20022.Auth090001.PaperCommodityOther1||XmlElement()||
|+|Pulp|ISO20022.Auth090001.PaperCommodityPulp2||XmlElement()||
|+|Nwsprnt|ISO20022.Auth090001.PaperCommodityNewsprint2||XmlElement()||
|+|CntnrBrd|ISO20022.Auth090001.PaperCommodityContainerBoard2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(RcvrdPpr),validElement(Pulp),validElement(Nwsprnt),validElement(CntnrBrd),validChoice(Othr,RcvrdPpr,Pulp,Nwsprnt,CntnrBrd))|

---

## Value ISO20022.Auth090001.AssetClassCommodityPolypropylene4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth090001.PolypropyleneCommodityOther2||XmlElement()||
|+|Plstc|ISO20022.Auth090001.PolypropyleneCommodityPlastic2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(Plstc),validChoice(Othr,Plstc))|

---

## Enum ISO20022.Auth090001.AssetClassDetailedSubProductType10Code


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

## Enum ISO20022.Auth090001.AssetClassDetailedSubProductType11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SLVR|Int32||XmlEnum("""SLVR""")|1|
||PTNM|Int32||XmlEnum("""PTNM""")|2|
||PLDM|Int32||XmlEnum("""PLDM""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||GOLD|Int32||XmlEnum("""GOLD""")|5|

---

## Enum ISO20022.Auth090001.AssetClassDetailedSubProductType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RICE|Int32||XmlEnum("""RICE""")|1|
||CORN|Int32||XmlEnum("""CORN""")|2|
||OTHR|Int32||XmlEnum("""OTHR""")|3|
||RPSD|Int32||XmlEnum("""RPSD""")|4|
||SOYB|Int32||XmlEnum("""SOYB""")|5|
||FWHT|Int32||XmlEnum("""FWHT""")|6|

---

## Enum ISO20022.Auth090001.AssetClassDetailedSubProductType29Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||LAMP|Int32||XmlEnum("""LAMP""")|2|

---

## Enum ISO20022.Auth090001.AssetClassDetailedSubProductType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||WHSG|Int32||XmlEnum("""WHSG""")|2|
||BRWN|Int32||XmlEnum("""BRWN""")|3|
||CCOA|Int32||XmlEnum("""CCOA""")|4|
||ROBU|Int32||XmlEnum("""ROBU""")|5|

---

## Enum ISO20022.Auth090001.AssetClassDetailedSubProductType30Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||MWHT|Int32||XmlEnum("""MWHT""")|2|

---

## Enum ISO20022.Auth090001.AssetClassDetailedSubProductType31Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||NBPG|Int32||XmlEnum("""NBPG""")|2|
||TTFG|Int32||XmlEnum("""TTFG""")|3|
||NCGG|Int32||XmlEnum("""NCGG""")|4|
||LNGG|Int32||XmlEnum("""LNGG""")|5|
||GASP|Int32||XmlEnum("""GASP""")|6|

---

## Enum ISO20022.Auth090001.AssetClassDetailedSubProductType32Code


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

## Enum ISO20022.Auth090001.AssetClassDetailedSubProductType33Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||DBCR|Int32||XmlEnum("""DBCR""")|2|

---

## Enum ISO20022.Auth090001.AssetClassDetailedSubProductType34Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||TNKR|Int32||XmlEnum("""TNKR""")|2|

---

## Enum ISO20022.Auth090001.AssetClassDetailedSubProductType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||OFFP|Int32||XmlEnum("""OFFP""")|2|
||PKLD|Int32||XmlEnum("""PKLD""")|3|
||FITR|Int32||XmlEnum("""FITR""")|4|
||BSLD|Int32||XmlEnum("""BSLD""")|5|

---

## Enum ISO20022.Auth090001.AssetClassDetailedSubProductType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||EUAA|Int32||XmlEnum("""EUAA""")|2|
||EUAE|Int32||XmlEnum("""EUAE""")|3|
||ERUE|Int32||XmlEnum("""ERUE""")|4|
||CERE|Int32||XmlEnum("""CERE""")|5|

---

## Enum ISO20022.Auth090001.AssetClassProductType11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHC|Int32||XmlEnum("""OTHC""")|1|

---

## Enum ISO20022.Auth090001.AssetClassProductType12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFL|Int32||XmlEnum("""INFL""")|1|

---

## Enum ISO20022.Auth090001.AssetClassProductType13Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MCEX|Int32||XmlEnum("""MCEX""")|1|

---

## Enum ISO20022.Auth090001.AssetClassProductType14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OEST|Int32||XmlEnum("""OEST""")|1|

---

## Enum ISO20022.Auth090001.AssetClassProductType15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|

---

## Enum ISO20022.Auth090001.AssetClassProductType16Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDX|Int32||XmlEnum("""INDX""")|1|

---

## Enum ISO20022.Auth090001.AssetClassProductType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGRI|Int32||XmlEnum("""AGRI""")|1|

---

## Enum ISO20022.Auth090001.AssetClassProductType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NRGY|Int32||XmlEnum("""NRGY""")|1|

---

## Enum ISO20022.Auth090001.AssetClassProductType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ENVR|Int32||XmlEnum("""ENVR""")|1|

---

## Enum ISO20022.Auth090001.AssetClassProductType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRGT|Int32||XmlEnum("""FRGT""")|1|

---

## Enum ISO20022.Auth090001.AssetClassProductType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRTL|Int32||XmlEnum("""FRTL""")|1|

---

## Enum ISO20022.Auth090001.AssetClassProductType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDP|Int32||XmlEnum("""INDP""")|1|

---

## Enum ISO20022.Auth090001.AssetClassProductType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||METL|Int32||XmlEnum("""METL""")|1|

---

## Enum ISO20022.Auth090001.AssetClassProductType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PAPR|Int32||XmlEnum("""PAPR""")|1|

---

## Enum ISO20022.Auth090001.AssetClassProductType9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||POLY|Int32||XmlEnum("""POLY""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EMIS|Int32||XmlEnum("""EMIS""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NPRM|Int32||XmlEnum("""NPRM""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType16Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRME|Int32||XmlEnum("""PRME""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType18Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PLST|Int32||XmlEnum("""PLST""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GROS|Int32||XmlEnum("""GROS""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType20Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DIRY|Int32||XmlEnum("""DIRY""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType21Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRST|Int32||XmlEnum("""FRST""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType22Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LSTK|Int32||XmlEnum("""LSTK""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType23Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SEAF|Int32||XmlEnum("""SEAF""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType24Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||COAL|Int32||XmlEnum("""COAL""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType25Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DIST|Int32||XmlEnum("""DIST""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType26Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INRG|Int32||XmlEnum("""INRG""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType27Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LGHT|Int32||XmlEnum("""LGHT""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType28Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RNNG|Int32||XmlEnum("""RNNG""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType29Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CRBR|Int32||XmlEnum("""CRBR""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SOFT|Int32||XmlEnum("""SOFT""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType30Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WTHR|Int32||XmlEnum("""WTHR""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType31Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DRYF|Int32||XmlEnum("""DRYF""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType32Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WETF|Int32||XmlEnum("""WETF""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType33Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CSTR|Int32||XmlEnum("""CSTR""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType34Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MFTG|Int32||XmlEnum("""MFTG""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType35Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CBRD|Int32||XmlEnum("""CBRD""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType36Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NSPT|Int32||XmlEnum("""NSPT""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType37Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PULP|Int32||XmlEnum("""PULP""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType39Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AMMO|Int32||XmlEnum("""AMMO""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OOLI|Int32||XmlEnum("""OOLI""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType40Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DAPH|Int32||XmlEnum("""DAPH""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType41Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PTSH|Int32||XmlEnum("""PTSH""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType42Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SLPH|Int32||XmlEnum("""SLPH""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType43Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UREA|Int32||XmlEnum("""UREA""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType44Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UAAN|Int32||XmlEnum("""UAAN""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType45Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||POTA|Int32||XmlEnum("""POTA""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType46Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CSHP|Int32||XmlEnum("""CSHP""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType49Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GRIN|Int32||XmlEnum("""GRIN""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ELEC|Int32||XmlEnum("""ELEC""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NGAS|Int32||XmlEnum("""NGAS""")|1|

---

## Enum ISO20022.Auth090001.AssetClassSubProductType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OILP|Int32||XmlEnum("""OILP""")|1|

---

## Value ISO20022.Auth090001.BasketConstituents3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UnitOfMeasr|ISO20022.Auth090001.UnitOfMeasure8Choice||XmlElement()||
|+|Qty|Decimal||XmlElement()||
|+|InstrmId|ISO20022.Auth090001.InstrumentIdentification6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UnitOfMeasr),validElement(InstrmId))|

---

## Value ISO20022.Auth090001.CollateralPortfolioCode5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MrgnPrtflCd|ISO20022.Auth090001.MarginPortfolio3||XmlElement()||
|+|Prtfl|ISO20022.Auth090001.PortfolioCode3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MrgnPrtflCd),validElement(Prtfl),validChoice(MrgnPrtflCd,Prtfl))|

---

## Enum ISO20022.Auth090001.CollateralisationType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNCL|Int32||XmlEnum("""UNCL""")|1|
||PRC2|Int32||XmlEnum("""PRC2""")|2|
||PRC1|Int32||XmlEnum("""PRC1""")|3|
||PRCL|Int32||XmlEnum("""PRCL""")|4|
||OWP2|Int32||XmlEnum("""OWP2""")|5|
||OWP1|Int32||XmlEnum("""OWP1""")|6|
||OWC2|Int32||XmlEnum("""OWC2""")|7|
||OWC1|Int32||XmlEnum("""OWC1""")|8|
||OWCL|Int32||XmlEnum("""OWCL""")|9|
||FLCL|Int32||XmlEnum("""FLCL""")|10|

---

## Value ISO20022.Auth090001.Counterparty45


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RptgXmptn|ISO20022.Auth090001.ReportingExemption1||XmlElement()||
|+|BookgLctn|String||XmlElement()||
|+|TradrLctn|String||XmlElement()||
|+|DrctnOrSd|ISO20022.Auth090001.Direction4Choice||XmlElement()||
|+|TradgCpcty|String||XmlElement()||
|+|Ntr|ISO20022.Auth090001.CounterpartyTradeNature15Choice||XmlElement()||
|+|Id|ISO20022.Auth090001.PartyIdentification248Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RptgXmptn),validPattern("""BookgLctn""",BookgLctn,"""[A-Z]{2,2}"""),validPattern("""TradrLctn""",TradrLctn,"""[A-Z]{2,2}"""),validElement(DrctnOrSd),validElement(Ntr),validElement(Id))|

---

## Value ISO20022.Auth090001.Counterparty46


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RptgOblgtn|String||XmlElement()||
|+|Ntr|ISO20022.Auth090001.CounterpartyTradeNature15Choice||XmlElement()||
|+|IdTp|ISO20022.Auth090001.PartyIdentification248Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ntr),validElement(IdTp))|

---

## Value ISO20022.Auth090001.CounterpartyTradeNature15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|String||XmlElement()||
|+|CntrlCntrPty|String||XmlElement()||
|+|NFI|ISO20022.Auth090001.NonFinancialInstitutionSector10||XmlElement()||
|+|FI|ISO20022.Auth090001.FinancialInstitutionSector1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NFI),validElement(FI),validChoice(Othr,CntrlCntrPty,NFI,FI))|

---

## Value ISO20022.Auth090001.CreditDerivative7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrchInd|String||XmlElement()||
|+|IndxFctr|Decimal||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
|+|Srs|Decimal||XmlElement()||
|+|ClctnBsis|String||XmlElement()||
|+|PmtFrqcy|String||XmlElement()||
|+|RefPty|ISO20022.Auth090001.DerivativePartyIdentification1Choice||XmlElement()||
|+|Snrty|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefPty))|

---

## Value ISO20022.Auth090001.CustomBasket4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cnsttnts|global::System.Collections.Generic.List<ISO20022.Auth090001.BasketConstituents3>||XmlElement()||
|+|Id|String||XmlElement()||
|+|Strr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Cnsttnts""",Cnsttnts),validElement(Cnsttnts),validPattern("""Strr""",Strr,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Enum ISO20022.Auth090001.DebtInstrumentSeniorityType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||SNDB|Int32||XmlEnum("""SNDB""")|2|
||SBOD|Int32||XmlEnum("""SBOD""")|3|

---

## Value ISO20022.Auth090001.DerivativePartyIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|Ctry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""CtrySubDvsn""",CtrySubDvsn,"""[A-Z]{2,2}\-[0-9A-Z]{1,3}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validChoice(LEI,CtrySubDvsn,Ctry))|

---

## Aspect ISO20022.Auth090001.DerivativesTradePositionSetReportV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth090001.SupplementaryData1>||XmlElement()||
|+|AggtdPos|ISO20022.Auth090001.PositionSetAggregated2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AggtdPos))|

---

## Value ISO20022.Auth090001.Direction2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DrctnOfTheScndLeg|String||XmlElement()||
|+|DrctnOfTheFrstLeg|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.Direction4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtrPtySd|String||XmlElement()||
|+|Drctn|ISO20022.Auth090001.Direction2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Drctn),validChoice(CtrPtySd,Drctn))|

---

## Type ISO20022.Auth090001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivsTradPosSetRpt|ISO20022.Auth090001.DerivativesTradePositionSetReportV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DerivsTradPosSetRpt))|

---

## Value ISO20022.Auth090001.EnergyCommodityCoal2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.EnergyCommodityDistillates2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.EnergyCommodityElectricity2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.EnergyCommodityInterEnergy2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.EnergyCommodityLightEnd2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.EnergyCommodityNaturalGas3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.EnergyCommodityOil3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.EnergyCommodityOther2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.EnergyCommodityRenewableEnergy2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.EnvironmentCommodityOther2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.EnvironmentalCommodityCarbonRelated2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.EnvironmentalCommodityEmission3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.EnvironmentalCommodityWeather2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.ExchangeRateBasis1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtdCcy|String||XmlElement()||
|+|BaseCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""BaseCcy""",BaseCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth090001.ExchangeRateBasis1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|CcyPair|ISO20022.Auth090001.ExchangeRateBasis1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CcyPair),validChoice(Prtry,CcyPair))|

---

## Value ISO20022.Auth090001.FertilizerCommodityAmmonia2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.FertilizerCommodityDiammoniumPhosphate2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.FertilizerCommodityOther2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.FertilizerCommodityPotash2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.FertilizerCommoditySulphur2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.FertilizerCommodityUrea2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.FertilizerCommodityUreaAndAmmoniumNitrate2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.FinancialInstitutionSector1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClrThrshld|String||XmlElement()||
|+|Sctr|global::System.Collections.Generic.List<ISO20022.Auth090001.FinancialPartyClassification2Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Sctr""",Sctr),validList("""Sctr""",Sctr),validElement(Sctr))|

---

## Enum ISO20022.Auth090001.FinancialInstrumentContractType2Code


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

## Value ISO20022.Auth090001.FinancialPartyClassification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Auth090001.GenericIdentification175||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Auth090001.FinancialPartySectorType3Code


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

## Value ISO20022.Auth090001.FreightCommodityContainerShip2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.FreightCommodityDry3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.FreightCommodityOther2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.FreightCommodityWet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth090001.Frequency13Code


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

## Value ISO20022.Auth090001.GenericIdentification175


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.GenericIdentification184


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Src|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.GenericIdentification185


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.IndexIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Indx|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Auth090001.IndustrialProductCommodityConstruction2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.IndustrialProductCommodityManufacturing2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.InstrumentIdentification6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrId|ISO20022.Auth090001.GenericIdentification184||XmlElement()||
|+|UnqPdctIdr|ISO20022.Auth090001.UniqueProductIdentifier1Choice||XmlElement()||
|+|AltrntvInstrmId|String||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrId),validElement(UnqPdctIdr),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validChoice(OthrId,UnqPdctIdr,AltrntvInstrmId,ISIN))|

---

## Value ISO20022.Auth090001.LegalPersonIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Auth090001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Auth090001.MarginCollateralReport4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TmStmp|DateTime||XmlElement()||
|+|CollstnCtgy|String||XmlElement()||
|+|CollPrtflCd|ISO20022.Auth090001.CollateralPortfolioCode5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollPrtflCd))|

---

## Value ISO20022.Auth090001.MarginPortfolio3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|VartnMrgnPrtflCd|ISO20022.Auth090001.PortfolioCode5Choice||XmlElement()||
|+|InitlMrgnPrtflCd|ISO20022.Auth090001.PortfolioCode5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(VartnMrgnPrtflCd),validElement(InitlMrgnPrtflCd))|

---

## Value ISO20022.Auth090001.MasterAgreement8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrMstrAgrmtDtls|String||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|Tp|ISO20022.Auth090001.AgreementType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Auth090001.MaturityTerm2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|Decimal||XmlElement()||
|+|Unit|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.MetalCommodityNonPrecious2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.MetalCommodityPrecious2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.NaturalPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dmcl|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Auth090001.GenericIdentification175||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Auth090001.NaturalPersonIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Auth090001.NaturalPersonIdentification2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id))|

---

## Enum ISO20022.Auth090001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Auth090001.NonFinancialInstitutionSector10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FdrlInstn|String||XmlElement()||
|+|DrctlyLkdActvty|String||XmlElement()||
|+|ClrThrshld|String||XmlElement()||
|+|Sctr|global::System.Collections.Generic.List<ISO20022.Auth090001.GenericIdentification175>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Sctr""",Sctr),validList("""Sctr""",Sctr),validElement(Sctr))|

---

## Enum ISO20022.Auth090001.NotApplicable1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOAP|Int32||XmlEnum("""NOAP""")|1|

---

## Value ISO20022.Auth090001.NotionalAmount7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|WghtdAvrgDlta|Decimal||XmlElement()||
|+|AmtInFct|global::System.Collections.Generic.List<ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd19DecimalAmount>||XmlElement()||
|+|Amt|ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd19DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AmtInFct""",AmtInFct),validElement(AmtInFct),validElement(Amt))|

---

## Value ISO20022.Auth090001.NotionalAmountLegs6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ScndLeg|ISO20022.Auth090001.NotionalAmount7||XmlElement()||
|+|FrstLeg|ISO20022.Auth090001.NotionalAmount7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ScndLeg),validElement(FrstLeg))|

---

## Enum ISO20022.Auth090001.OptionParty1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BYER|Int32||XmlEnum("""BYER""")|1|
||SLLR|Int32||XmlEnum("""SLLR""")|2|

---

## Enum ISO20022.Auth090001.OptionParty3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TAKE|Int32||XmlEnum("""TAKE""")|1|
||MAKE|Int32||XmlEnum("""MAKE""")|2|

---

## Enum ISO20022.Auth090001.OptionType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||PUTO|Int32||XmlEnum("""PUTO""")|2|
||CALL|Int32||XmlEnum("""CALL""")|3|

---

## Value ISO20022.Auth090001.OrganisationIdentification15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AnyBIC|String||XmlElement()||
|+|Othr|ISO20022.Auth090001.OrganisationIdentification38||XmlElement()||
|+|LEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validChoice(AnyBIC,Othr,LEI))|

---

## Value ISO20022.Auth090001.OrganisationIdentification38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dmcl|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Auth090001.GenericIdentification175||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Auth090001.OtherPayment6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PmtRcvr|ISO20022.Auth090001.PartyIdentification236Choice||XmlElement()||
|+|PmtPyer|ISO20022.Auth090001.PartyIdentification236Choice||XmlElement()||
|+|PmtDt|DateTime||XmlElement()||
|+|PmtTp|ISO20022.Auth090001.PaymentType5Choice||XmlElement()||
|+|PmtCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PmtRcvr),validElement(PmtPyer),validElement(PmtTp),validPattern("""PmtCcy""",PmtCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth090001.PaperCommodityContainerBoard2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.PaperCommodityNewsprint2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.PaperCommodityOther1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.PaperCommodityPulp2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.PartyIdentification236Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ntrl|ISO20022.Auth090001.NaturalPersonIdentification2||XmlElement()||
|+|Lgl|ISO20022.Auth090001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ntrl),validElement(Lgl),validChoice(Ntrl,Lgl))|

---

## Value ISO20022.Auth090001.PartyIdentification248Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ntrl|ISO20022.Auth090001.NaturalPersonIdentification3||XmlElement()||
|+|Lgl|ISO20022.Auth090001.LegalPersonIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ntrl),validElement(Lgl),validChoice(Ntrl,Lgl))|

---

## Enum ISO20022.Auth090001.PaymentType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PEXH|Int32||XmlEnum("""PEXH""")|1|
||UWIN|Int32||XmlEnum("""UWIN""")|2|
||UFRO|Int32||XmlEnum("""UFRO""")|3|

---

## Value ISO20022.Auth090001.PaymentType5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrtryTp""",PrtryTp,"""[a-zA-Z0-9]{1,4}"""),validChoice(PrtryTp,Tp))|

---

## Value ISO20022.Auth090001.PolypropyleneCommodityOther2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.PolypropyleneCommodityPlastic2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.PortfolioCode3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoPrtfl|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(NoPrtfl,Cd))|

---

## Value ISO20022.Auth090001.PortfolioCode5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoPrtfl|String||XmlElement()||
|+|Prtfl|ISO20022.Auth090001.PortfolioIdentification3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtfl),validChoice(NoPrtfl,Prtfl))|

---

## Value ISO20022.Auth090001.PortfolioIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtflTxXmptn|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.PositionSet21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Mtrcs|ISO20022.Auth090001.PositionSetMetrics14||XmlElement()||
|+|Dmnsns|ISO20022.Auth090001.PositionSetDimensions16||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Mtrcs),validElement(Dmnsns))|

---

## Value ISO20022.Auth090001.PositionSet22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Mtrcs|ISO20022.Auth090001.PositionSetCollateralMetrics2||XmlElement()||
|+|Dmnsns|ISO20022.Auth090001.PositionSetCollateralDimensions3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Mtrcs),validElement(Dmnsns))|

---

## Value ISO20022.Auth090001.PositionSetAggregated2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rpt|ISO20022.Auth090001.PositionSetAggregated4||XmlElement()||
|+|DataSetActn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rpt),validChoice(Rpt,DataSetActn))|

---

## Value ISO20022.Auth090001.PositionSetAggregated4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CcyCollPosSet|global::System.Collections.Generic.List<ISO20022.Auth090001.PositionSet22>||XmlElement()||
|+|CollPosSet|global::System.Collections.Generic.List<ISO20022.Auth090001.PositionSet22>||XmlElement()||
|+|CcyPosSet|global::System.Collections.Generic.List<ISO20022.Auth090001.PositionSet21>||XmlElement()||
|+|PosSet|global::System.Collections.Generic.List<ISO20022.Auth090001.PositionSet21>||XmlElement()||
|+|RefDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CcyCollPosSet""",CcyCollPosSet),validElement(CcyCollPosSet),validList("""CollPosSet""",CollPosSet),validElement(CollPosSet),validList("""CcyPosSet""",CcyPosSet),validElement(CcyPosSet),validList("""PosSet""",PosSet),validElement(PosSet))|

---

## Value ISO20022.Auth090001.PositionSetBuyerAndSeller2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sellr|ISO20022.Auth090001.PositionSetTotal2||XmlElement()||
|+|Buyr|ISO20022.Auth090001.PositionSetTotal2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Sellr),validElement(Buyr))|

---

## Value ISO20022.Auth090001.PositionSetCollateralDimensions3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XcssCollRcvdCcy|String||XmlElement()||
|+|XcssCollPstdCcy|String||XmlElement()||
|+|VartnMrgnRcvdCcy|String||XmlElement()||
|+|InitlMrgnRcvdCcy|String||XmlElement()||
|+|VartnMrgnPstdCcy|String||XmlElement()||
|+|InitlMrgnPstdCcy|String||XmlElement()||
|+|Coll|ISO20022.Auth090001.MarginCollateralReport4||XmlElement()||
|+|CtrPtyId|ISO20022.Auth090001.TradeCounterpartyReport20||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""XcssCollRcvdCcy""",XcssCollRcvdCcy,"""[A-Z]{3,3}"""),validPattern("""XcssCollPstdCcy""",XcssCollPstdCcy,"""[A-Z]{3,3}"""),validPattern("""VartnMrgnRcvdCcy""",VartnMrgnRcvdCcy,"""[A-Z]{3,3}"""),validPattern("""InitlMrgnRcvdCcy""",InitlMrgnRcvdCcy,"""[A-Z]{3,3}"""),validPattern("""VartnMrgnPstdCcy""",VartnMrgnPstdCcy,"""[A-Z]{3,3}"""),validPattern("""InitlMrgnPstdCcy""",InitlMrgnPstdCcy,"""[A-Z]{3,3}"""),validElement(Coll),validElement(CtrPtyId))|

---

## Value ISO20022.Auth090001.PositionSetCollateralMetrics2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Clean|ISO20022.Auth090001.PositionSetCollateralTotal2||XmlElement()||
|+|Ttl|ISO20022.Auth090001.PositionSetCollateralTotal2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Clean),validElement(Ttl))|

---

## Value ISO20022.Auth090001.PositionSetCollateralTotal2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RcvdMrgnOrColl|ISO20022.Auth090001.ReceivedMarginOrCollateral6||XmlElement()||
|+|PstdMrgnOrColl|ISO20022.Auth090001.PostedMarginOrCollateral6||XmlElement()||
|+|NbOfRpts|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RcvdMrgnOrColl),validElement(PstdMrgnOrColl))|

---

## Value ISO20022.Auth090001.PositionSetDimensions16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPmt|ISO20022.Auth090001.OtherPayment6||XmlElement()||
|+|Cmmdty|ISO20022.Auth090001.AssetClassCommodity6Choice||XmlElement()||
|+|Cdt|ISO20022.Auth090001.CreditDerivative7||XmlElement()||
|+|IRSTp|String||XmlElement()||
|+|TmToMtrty|ISO20022.Auth090001.TimeToMaturity1Choice||XmlElement()||
|+|OptnTp|String||XmlElement()||
|+|XchgRateBsis|ISO20022.Auth090001.ExchangeRateBasis1Choice||XmlElement()||
|+|IntraGrp|String||XmlElement()||
|+|Clrd|String||XmlElement()||
|+|MstrAgrmt|ISO20022.Auth090001.MasterAgreement8||XmlElement()||
|+|SttlmCcyScndLeg|String||XmlElement()||
|+|SttlmCcy|String||XmlElement()||
|+|NtnlCcyScndLeg|String||XmlElement()||
|+|NtnlCcy|String||XmlElement()||
|+|UndrlygInstrm|ISO20022.Auth090001.SecurityIdentification41Choice||XmlElement()||
|+|AsstClss|String||XmlElement()||
|+|CtrctTp|String||XmlElement()||
|+|Coll|ISO20022.Auth090001.MarginCollateralReport4||XmlElement()||
|+|ValCcy|String||XmlElement()||
|+|CtrPtyId|ISO20022.Auth090001.TradeCounterpartyReport20||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrPmt),validElement(Cmmdty),validElement(Cdt),validElement(TmToMtrty),validElement(XchgRateBsis),validElement(MstrAgrmt),validPattern("""SttlmCcyScndLeg""",SttlmCcyScndLeg,"""[A-Z]{3,3}"""),validPattern("""SttlmCcy""",SttlmCcy,"""[A-Z]{3,3}"""),validPattern("""NtnlCcyScndLeg""",NtnlCcyScndLeg,"""[A-Z]{3,3}"""),validPattern("""NtnlCcy""",NtnlCcy,"""[A-Z]{3,3}"""),validElement(UndrlygInstrm),validElement(Coll),validPattern("""ValCcy""",ValCcy,"""[A-Z]{3,3}"""),validElement(CtrPtyId))|

---

## Value ISO20022.Auth090001.PositionSetMetrics14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Clean|ISO20022.Auth090001.PositionSetBuyerAndSeller2||XmlElement()||
|+|Ttl|ISO20022.Auth090001.PositionSetBuyerAndSeller2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Clean),validElement(Ttl))|

---

## Value ISO20022.Auth090001.PositionSetTotal2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPmtAmt|global::System.Collections.Generic.List<ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd19DecimalAmount>||XmlElement()||
|+|Ntnl|ISO20022.Auth090001.NotionalAmountLegs6||XmlElement()||
|+|NegVal|ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd19DecimalAmount||XmlElement()||
|+|PostvVal|ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd19DecimalAmount||XmlElement()||
|+|NbOfTrds|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrPmtAmt""",OthrPmtAmt),validElement(OthrPmtAmt),validElement(Ntnl),validElement(NegVal),validElement(PostvVal))|

---

## Value ISO20022.Auth090001.PostedMarginOrCollateral6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XcssCollPstd|ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount||XmlElement()||
|+|VartnMrgnPstdPstHrcut|ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount||XmlElement()||
|+|VartnMrgnPstdPreHrcut|ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount||XmlElement()||
|+|InitlMrgnPstdPstHrcut|ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount||XmlElement()||
|+|InitlMrgnPstdPreHrcut|ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(XcssCollPstd),validElement(VartnMrgnPstdPstHrcut),validElement(VartnMrgnPstdPreHrcut),validElement(InitlMrgnPstdPstHrcut),validElement(InitlMrgnPstdPreHrcut))|

---

## Enum ISO20022.Auth090001.ProductType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||COMM|Int32||XmlEnum("""COMM""")|2|
||INTR|Int32||XmlEnum("""INTR""")|3|
||EQUI|Int32||XmlEnum("""EQUI""")|4|
||CURR|Int32||XmlEnum("""CURR""")|5|
||CRDT|Int32||XmlEnum("""CRDT""")|6|

---

## Enum ISO20022.Auth090001.RateBasis1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YEAR|Int32||XmlEnum("""YEAR""")|1|
||WEEK|Int32||XmlEnum("""WEEK""")|2|
||MNTH|Int32||XmlEnum("""MNTH""")|3|
||DAYS|Int32||XmlEnum("""DAYS""")|4|

---

## Value ISO20022.Auth090001.ReceivedMarginOrCollateral6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XcssCollRcvd|ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount||XmlElement()||
|+|VartnMrgnRcvdPstHrcut|ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount||XmlElement()||
|+|VartnMrgnRcvdPreHrcut|ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount||XmlElement()||
|+|InitlMrgnRcvdPstHrcut|ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount||XmlElement()||
|+|InitlMrgnRcvdPreHrcut|ISO20022.Auth090001.ActiveOrHistoricCurrencyAnd20DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(XcssCollRcvd),validElement(VartnMrgnRcvdPstHrcut),validElement(VartnMrgnRcvdPreHrcut),validElement(InitlMrgnRcvdPstHrcut),validElement(InitlMrgnRcvdPreHrcut))|

---

## Enum ISO20022.Auth090001.ReportPeriodActivity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOTX|Int32||XmlEnum("""NOTX""")|1|

---

## Value ISO20022.Auth090001.ReportingExemption1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|Rsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.SecurityIdentification41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdNotAvlbl|String||XmlElement()||
|+|Othr|ISO20022.Auth090001.GenericIdentification184||XmlElement()||
|+|Indx|ISO20022.Auth090001.IndexIdentification1||XmlElement()||
|+|Bskt|ISO20022.Auth090001.CustomBasket4||XmlElement()||
|+|UnqPdctIdr|ISO20022.Auth090001.UniqueProductIdentifier2Choice||XmlElement()||
|+|AltrntvInstrmId|String||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(Indx),validElement(Bskt),validElement(UnqPdctIdr),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validChoice(IdNotAvlbl,Othr,Indx,Bskt,UnqPdctIdr,AltrntvInstrmId,ISIN))|

---

## Enum ISO20022.Auth090001.SpecialPurpose2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NTAV|Int32||XmlEnum("""NTAV""")|1|
||BLNK|Int32||XmlEnum("""BLNK""")|2|

---

## Value ISO20022.Auth090001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Auth090001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Auth090001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth090001.TimeToMaturity1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Spcl|String||XmlElement()||
|+|Prd|ISO20022.Auth090001.TimeToMaturityPeriod1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prd),validChoice(Spcl,Prd))|

---

## Value ISO20022.Auth090001.TimeToMaturityPeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|End|ISO20022.Auth090001.MaturityTerm2||XmlElement()||
|+|Start|ISO20022.Auth090001.MaturityTerm2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(End),validElement(Start))|

---

## Value ISO20022.Auth090001.TradeCounterpartyRelationship1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Auth090001.TradeCounterpartyRelationshipRecord1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|RltshTp|ISO20022.Auth090001.TradeCounterpartyRelationship1Choice||XmlElement()||
|+|EndRltshPty|String||XmlElement()||
|+|StartRltshPty|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RltshTp))|

---

## Value ISO20022.Auth090001.TradeCounterpartyReport20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltshRcrd|global::System.Collections.Generic.List<ISO20022.Auth090001.TradeCounterpartyRelationshipRecord1>||XmlElement()||
|+|ExctnAgt|global::System.Collections.Generic.List<ISO20022.Auth090001.OrganisationIdentification15Choice>||XmlElement()||
|+|NttyRspnsblForRpt|ISO20022.Auth090001.OrganisationIdentification15Choice||XmlElement()||
|+|Bnfcry|global::System.Collections.Generic.List<ISO20022.Auth090001.PartyIdentification248Choice>||XmlElement()||
|+|ClrMmb|ISO20022.Auth090001.PartyIdentification248Choice||XmlElement()||
|+|SubmitgAgt|ISO20022.Auth090001.OrganisationIdentification15Choice||XmlElement()||
|+|Brkr|ISO20022.Auth090001.OrganisationIdentification15Choice||XmlElement()||
|+|OthrCtrPty|ISO20022.Auth090001.Counterparty46||XmlElement()||
|+|RptgCtrPty|ISO20022.Auth090001.Counterparty45||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""RltshRcrd""",RltshRcrd),validElement(RltshRcrd),validList("""ExctnAgt""",ExctnAgt),validListMax("""ExctnAgt""",ExctnAgt,2),validElement(ExctnAgt),validElement(NttyRspnsblForRpt),validList("""Bnfcry""",Bnfcry),validListMax("""Bnfcry""",Bnfcry,2),validElement(Bnfcry),validElement(ClrMmb),validElement(SubmitgAgt),validElement(Brkr),validElement(OthrCtrPty),validElement(RptgCtrPty))|

---

## Enum ISO20022.Auth090001.TradeCounterpartyType1Code


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

## Enum ISO20022.Auth090001.TradingCapacity7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRIN|Int32||XmlEnum("""PRIN""")|1|
||AGEN|Int32||XmlEnum("""AGEN""")|2|

---

## Enum ISO20022.Auth090001.UnderlyingIdentification1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDX|Int32||XmlEnum("""INDX""")|1|
||BSKT|Int32||XmlEnum("""BSKT""")|2|
||UKWN|Int32||XmlEnum("""UKWN""")|3|

---

## Value ISO20022.Auth090001.UniqueProductIdentifier1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Auth090001.GenericIdentification175||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Id))|

---

## Value ISO20022.Auth090001.UniqueProductIdentifier2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Auth090001.GenericIdentification185||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Id))|

---

## Value ISO20022.Auth090001.UnitOfMeasure8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Auth090001.GenericIdentification175||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

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

