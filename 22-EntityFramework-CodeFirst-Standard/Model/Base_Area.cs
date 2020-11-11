namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Area
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? Parent_Id { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Short_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Full_Name { get; set; }

        [StringLength(100)]
        public string Quick_Query { get; set; }

        [StringLength(50)]
        public string Simple_Spelling { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string District { get; set; }

        [StringLength(10)]
        public string Postal_code { get; set; }

        [StringLength(16)]
        public string Longitude { get; set; }

        [StringLength(16)]
        public string Latitude { get; set; }

        public short? Allow_Edit { get; set; }

        public short? Allow_Delete { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int? Sort_Code { get; set; }

        public int? Layer { get; set; }

        public short? Network_Orders { get; set; }

        public short Allow_To_Pay { get; set; }

        public int Max_To_Payment { get; set; }

        public short Allow_Goods_Pay { get; set; }

        public int Max_Goods_Payment { get; set; }

        public short Whole { get; set; }

        public short Receive { get; set; }

        public short Send { get; set; }

        [StringLength(10)]
        public string Mark { get; set; }

        public short? Out_Of_Range { get; set; }

        public short? OPENING { get; set; }

        [StringLength(20)]
        public string PRINT_MARK { get; set; }

        public short? DELAY_DAY { get; set; }

        [StringLength(20)]
        public string STATISTICS { get; set; }

        public short Is_Public { get; set; }

        public short Enabled { get; set; }

        public short Deletion_State_Code { get; set; }

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

        [StringLength(50)]
        public string Manage_Company_Id { get; set; }

        [StringLength(50)]
        public string Manage_Company_Code { get; set; }

        [StringLength(50)]
        public string Manage_Company { get; set; }

        [StringLength(40)]
        public string MODIFIED_COMPANY_ID { get; set; }

        [StringLength(50)]
        public string MODIFIED_COMPANY { get; set; }

        [StringLength(20)]
        public string MODIFIED_COMPANY_CODE { get; set; }
    }
}
