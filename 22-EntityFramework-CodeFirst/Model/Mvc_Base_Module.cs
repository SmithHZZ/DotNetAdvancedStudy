namespace _22_EntityFramework_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mvc_Base_Module
    {
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

        public int? Sort_Code { get; set; }

        public short? Enabled { get; set; }

        public short Deletion_State_Code { get; set; }

        public short? Is_Menu { get; set; }

        public short Is_Public { get; set; }

        public short Expand { get; set; }

        public short Is_Scope { get; set; }

        public short Is_Visible { get; set; }

        public short Allow_Edit { get; set; }

        public short Allow_Delete { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Last_Call { get; set; }

        public int? Authorized_Days { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public DateTime? Create_On { get; set; }

        [StringLength(40)]
        public string Create_User_Id { get; set; }

        [StringLength(50)]
        public string Create_By { get; set; }

        public DateTime? Modified_On { get; set; }

        [StringLength(40)]
        public string Modified_User_Id { get; set; }

        [StringLength(50)]
        public string Modified_By { get; set; }

        public int? Security_Level { get; set; }
    }
}
