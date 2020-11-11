namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Colp_Check_List
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

        [StringLength(40)]
        public string Code { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(196)]
        public string Full_Name { get; set; }

        [StringLength(196)]
        public string Name { get; set; }

        public int? Age { get; set; }

        [StringLength(40)]
        public string Gender { get; set; }

        [StringLength(40)]
        public string Nationality { get; set; }

        public DateTime? BirthDate { get; set; }

        [StringLength(40)]
        public string IdType { get; set; }

        [StringLength(40)]
        public string IdNumber { get; set; }

        [StringLength(40)]
        public string Marriage { get; set; }

        [StringLength(40)]
        public string Occupation { get; set; }

        [StringLength(196)]
        public string HomeAddress { get; set; }

        public DateTime? RegisterDate { get; set; }

        public string PatientDirectory { get; set; }

        [StringLength(40)]
        public string ContactNumber { get; set; }

        public DateTime? Lastdaymenses { get; set; }

        [StringLength(40)]
        public string Source { get; set; }

        [StringLength(40)]
        public string HCG { get; set; }

        [StringLength(40)]
        public string Condommode { get; set; }

        public int? PregnancyNumber { get; set; }

        public int? ProduceNumber { get; set; }

        public int? AbortionNumber { get; set; }

        [StringLength(40)]
        public string BloodType { get; set; }

        public int? PartnerNumber { get; set; }

        public int? Smoke { get; set; }

        public string Remark { get; set; }

        [StringLength(10)]
        public string IsRecheck { get; set; }

        [StringLength(40)]
        public string PregnancyState { get; set; }

        public int? PregnancyWeeks { get; set; }

        [StringLength(40)]
        public string MenopauseStatus { get; set; }

        public int? ContactBleeding { get; set; }

        public int? IrregularBleeding { get; set; }

        public int? AbnormalSecretion { get; set; }

        public int? ExogenicLesion { get; set; }

        public int? Neoplasm { get; set; }

        public int? Ulcer { get; set; }

        public int? PregnancyBleeding { get; set; }

        public int? GestationHighLesions { get; set; }

        public int? PhysicalExamination { get; set; }

        public string TreatmentHistory { get; set; }

        public string MedicalHistory { get; set; }

        public string TCTCheckResult { get; set; }

        public DateTime? TCTCheckDate { get; set; }

        [StringLength(40)]
        public string TCTCheckResultSource { get; set; }

        public string HPVCheckResult { get; set; }

        public DateTime? HPVCheckDate { get; set; }

        [StringLength(40)]
        public string HPVCheckResultSource { get; set; }

        public string HistopathologyDiagnoseResult { get; set; }

        public DateTime? HistopathologyDiagnoseDate { get; set; }

        [StringLength(40)]
        public string HistopathologyDiagnoseResultSource { get; set; }

        public string OtherCharacteristic { get; set; }

        public string CheckDirectory { get; set; }

        [StringLength(40)]
        public string Appointment_Period { get; set; }

        public string Associated_Documents { get; set; }

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

        [StringLength(196)]
        public string Encryption_Code { get; set; }

        [StringLength(40)]
        public string Software_Version { get; set; }

        [StringLength(40)]
        public string Language_Version { get; set; }

        [StringLength(40)]
        public string Term_Version { get; set; }

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

        public string Patientsubject { get; set; }

        public int? CerviexLesion { get; set; }

        public int? HPVInfected { get; set; }

        [StringLength(1)]
        public string BranchType { get; set; }
    }
}
