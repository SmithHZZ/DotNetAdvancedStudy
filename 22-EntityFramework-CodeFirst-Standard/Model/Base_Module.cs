namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Module
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(40)]
        public string Parent_Id { get; set; }

        [StringLength(100)]
        public string Code { get; set; }

        [StringLength(100)]
        public string Full_Name { get; set; }

        [StringLength(50)]
        public string Category_Code { get; set; }

        [StringLength(200)]
        public string Imag_Url { get; set; }

        [StringLength(50)]
        public string Image_Index { get; set; }

        [StringLength(50)]
        public string Selected_Image_Index { get; set; }

        [StringLength(200)]
        public string Navigate_Url { get; set; }

        [StringLength(100)]
        public string Target { get; set; }

        [StringLength(50)]
        public string Web_Browser { get; set; }

        [StringLength(100)]
        public string Form_Name { get; set; }

        [StringLength(100)]
        public string Assembly_Name { get; set; }

        [StringLength(500)]
        public string Permission_Scope_Tables { get; set; }

        public short? Is_Menu { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Is_Public { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Is_Scope { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Is_Visible { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Last_Call { get; set; }

        public int? Sort_Code { get; set; }

        public short? Enabled { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Deletion_State_Code { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Expand { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Allow_Edit { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Allow_Delete { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Create_On { get; set; }

        [StringLength(40)]
        public string Create_User_Id { get; set; }

        [StringLength(20)]
        public string Create_By { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Modified_On { get; set; }

        [StringLength(40)]
        public string Modified_User_Id { get; set; }

        [StringLength(20)]
        public string Modified_By { get; set; }

        public int? Authorized_Days { get; set; }

        public int? Security_Level { get; set; }
    }
}
