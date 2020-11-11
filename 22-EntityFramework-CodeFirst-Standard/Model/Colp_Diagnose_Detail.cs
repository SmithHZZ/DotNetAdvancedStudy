namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Colp_Diagnose_Detail
    {
        [StringLength(36)]
        public string Id { get; set; }

        [StringLength(36)]
        public string Parent_Id { get; set; }

        [StringLength(196)]
        public string Parent_Name { get; set; }

        [StringLength(40)]
        public string Parent_Code { get; set; }

        [StringLength(36)]
        public string Organization_Id { get; set; }

        [StringLength(196)]
        public string Organization_Name { get; set; }

        [StringLength(40)]
        public string Organization_Code { get; set; }

        [StringLength(36)]
        public string Department_Id { get; set; }

        [StringLength(196)]
        public string Department_Name { get; set; }

        [StringLength(40)]
        public string Department_Code { get; set; }

        [StringLength(36)]
        public string Equipment_Id { get; set; }

        [StringLength(196)]
        public string Equipment_Name { get; set; }

        [StringLength(40)]
        public string Equipment_Code { get; set; }

        [StringLength(36)]
        public string User_Id { get; set; }

        [StringLength(196)]
        public string User_Name { get; set; }

        [StringLength(40)]
        public string User_Code { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(196)]
        public string Patientsubject { get; set; }

        public int? Sufficient { get; set; }

        public int? OverallCervixVisible { get; set; }

        public int? OverallSCJVisible { get; set; }

        public int? BeforAcidErosion { get; set; }

        public int? BeforAcidCrisp { get; set; }

        public int? BeforAcidBlood { get; set; }

        public int? BeforAcidInflammation { get; set; }

        public int? BeforAcidWhite { get; set; }

        public int? BeforAcidChange { get; set; }

        public int? AfterAcidWhite { get; set; }

        public int? AfterAcidInfection { get; set; }

        public int? Referral { get; set; }

        [StringLength(40)]
        public string ReferralCode { get; set; }

        public int? NormalLepidoteEpidermisRipe { get; set; }

        public int? NormalLepidoteEpidermisAtrophy { get; set; }

        public int? NormalLepidoteEpidermisGestation { get; set; }

        public int? NormalHistogramEpidermisShift { get; set; }

        public int? NormalNabothCyst { get; set; }

        public int? NormalBodyGlandOpening { get; set; }

        public int? NormalVingerShrink { get; set; }

        public int? NormalMetaplasticEpithelium { get; set; }

        public int? LSILTranslucent { get; set; }

        public int? LSILBoundaryVague { get; set; }

        public int? LSILWartyBulge { get; set; }

        public int? LSILFlatNipple { get; set; }

        public int? LSILNone { get; set; }

        public int? LSILPunctate { get; set; }

        public int? LSILSmallInlay { get; set; }

        public int? LSILUnOperater { get; set; }

        public int? LSILUnbepaint { get; set; }

        public int? LSILPartUnbepaint { get; set; }

        public int? HSILIncrassatedCompact { get; set; }

        public int? HSILBoundaryClear { get; set; }

        public int? HSILCuffBodyGlandOpening { get; set; }

        public int? HSILBulge { get; set; }

        public int? HSILConfertusNipple { get; set; }

        public int? HSILInsideBoundaryRemark { get; set; }

        public int? HSILNone { get; set; }

        public int? HSILCrudeInlay { get; set; }

        public int? HSILCrudePunctiform { get; set; }

        public int? HSILAbnormitydBlood { get; set; }

        public int? HSILUnOperater { get; set; }

        public int? HSILUnbepaint { get; set; }

        public int? HSILPartUnbepaint { get; set; }

        public int? IrregularSurface { get; set; }

        public int? FragilityAtypiaBlood { get; set; }

        public int? AbnormalSecretion { get; set; }

        public int? Neoplasm { get; set; }

        public int? ExogenicGoitre { get; set; }

        public int? PregnancyBleeding { get; set; }

        public int? UlcerNecrosis { get; set; }

        public int? VingerCanceration { get; set; }

        public int? LugolIodineStaining { get; set; }

        public int? TrichomonasInfection { get; set; }

        public int? Polyp { get; set; }

        public int? CervicalMyoma { get; set; }

        public int? ContactBleeding { get; set; }

        public int? Erosion { get; set; }

        public int? Leukoplakia { get; set; }

        public int? EasyCrispOrganize { get; set; }

        public int? TreatChange { get; set; }

        public int? OtherInspect { get; set; }

        [StringLength(40)]
        public string SatisfactionDegree { get; set; }

        public string DisagreementItem { get; set; }

        [StringLength(40)]
        public string ConversionType { get; set; }

        public string Screen { get; set; }

        public string ScreenOther { get; set; }

        public string ReferralResult { get; set; }

        public string ReferralOther { get; set; }

        public int? OverAllVinegarWhiteEpithelium { get; set; }

        public int? OverAllInfection { get; set; }

        public string Attention { get; set; }

        public string DisposeSuggestion { get; set; }

        public DateTime? FlupDate { get; set; }

        public string SelectedPicture { get; set; }

        public string Associated_Documents { get; set; }

        [StringLength(40)]
        public string Code { get; set; }

        [StringLength(196)]
        public string Full_Name { get; set; }

        [StringLength(196)]
        public string Name { get; set; }

        [StringLength(40)]
        public string Category_Code { get; set; }

        [StringLength(196)]
        public string Category { get; set; }

        public short? State_Code { get; set; }

        [StringLength(196)]
        public string State { get; set; }

        public int? Sort_Code { get; set; }

        public short? Allow_Edit { get; set; }

        public short? Allow_Delete { get; set; }

        public short? Is_Visible { get; set; }

        public short? Is_Public { get; set; }

        public short? Enabled { get; set; }

        public short? Deletion_State_Code { get; set; }

        public string Contents { get; set; }

        public string Description { get; set; }

        public string Tag { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Create_On { get; set; }

        [Required]
        [StringLength(36)]
        public string Create_User_Id { get; set; }

        [Required]
        [StringLength(196)]
        public string Create_By { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Modified_On { get; set; }

        [Required]
        [StringLength(36)]
        public string Modified_User_Id { get; set; }

        [Required]
        [StringLength(196)]
        public string Modified_By { get; set; }

        public string PathologyPlace { get; set; }

        public string PathologyLocal { get; set; }

        public string PathologyArea { get; set; }

        public string PathologySize { get; set; }

        public string BeforeUseEthylicacid { get; set; }

        public string AfterUseEthylicacid { get; set; }
    }
}
