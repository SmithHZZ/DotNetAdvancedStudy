namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_User
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string User_Name { get; set; }

        [StringLength(50)]
        public string Real_Name { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }

        [StringLength(100)]
        public string Quick_Query { get; set; }

        [StringLength(50)]
        public string Simple_Spelling { get; set; }

        [StringLength(50)]
        public string Duty { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        [StringLength(200)]
        public string Signature { get; set; }

        [StringLength(50)]
        public string IDCard { get; set; }

        [StringLength(50)]
        public string Birthday { get; set; }

        [StringLength(50)]
        public string Company_Id { get; set; }

        [StringLength(50)]
        public string Company_Name { get; set; }

        [StringLength(20)]
        public string Company_Code { get; set; }

        [StringLength(50)]
        public string Department_Id { get; set; }

        [StringLength(50)]
        public string Department_Name { get; set; }

        [StringLength(20)]
        public string Department_Code { get; set; }

        [StringLength(50)]
        public string Sub_Company_Id { get; set; }

        [StringLength(50)]
        public string Sub_Company_Name { get; set; }

        [StringLength(50)]
        public string Sub_Department_Id { get; set; }

        [StringLength(50)]
        public string Sub_Department_Name { get; set; }

        [StringLength(50)]
        public string Workgroup_Id { get; set; }

        [StringLength(50)]
        public string Workgroup_Name { get; set; }

        public int? Province_Id { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        public int? City_Id { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        public int? District_Id { get; set; }

        [StringLength(50)]
        public string District { get; set; }

        [StringLength(200)]
        public string Home_Address { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public short? Is_Administrator { get; set; }

        [StringLength(50)]
        public string Work_Category { get; set; }

        public int? Security_Level { get; set; }

        [StringLength(50)]
        public string Lang { get; set; }

        [StringLength(50)]
        public string Theme { get; set; }

        public int? Score { get; set; }

        public int? Fans { get; set; }

        [StringLength(50)]
        public string User_From { get; set; }

        [StringLength(40)]
        public string Manager_Id { get; set; }

        [StringLength(20)]
        public string Manager { get; set; }

        public short? MANAGER_AUDIT_STATUS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MANAGER_AUDIT_DATE { get; set; }

        public int? Sort_Code { get; set; }

        public short? Is_Staff { get; set; }

        public short? Is_Visible { get; set; }

        public short? Enabled { get; set; }

        public short? Deletion_State_Code { get; set; }

        [StringLength(50)]
        public string Audit_Status { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Create_On { get; set; }

        [StringLength(40)]
        public string Create_User_Id { get; set; }

        [StringLength(20)]
        public string Create_User_Code { get; set; }

        [StringLength(20)]
        public string Create_By { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Modified_On { get; set; }

        [StringLength(40)]
        public string Modified_User_Id { get; set; }

        [StringLength(20)]
        public string Modified_By { get; set; }
    }
}
