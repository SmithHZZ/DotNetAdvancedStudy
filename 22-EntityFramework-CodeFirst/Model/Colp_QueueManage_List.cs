namespace _22_EntityFramework_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Colp_QueueManage_List
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

        [StringLength(196)]
        public string Full_Name { get; set; }

        [StringLength(196)]
        public string Name { get; set; }

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
    }
}
