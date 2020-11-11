namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Organize
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Short_Name { get; set; }

        [StringLength(50)]
        public string Full_Name { get; set; }

        [StringLength(50)]
        public string Standard_Name { get; set; }

        [StringLength(50)]
        public string Standard_Code { get; set; }

        [StringLength(40)]
        public string Parent_Id { get; set; }

        [StringLength(50)]
        public string Parent_Name { get; set; }

        [StringLength(20)]
        public string Parent_Code { get; set; }

        public int? Sort_Code { get; set; }

        [StringLength(50)]
        public string Category_Code { get; set; }

        public int? Layer { get; set; }

        [StringLength(100)]
        public string Outer_Phone { get; set; }

        [StringLength(100)]
        public string Inner_Phone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Postal_Code { get; set; }

        [StringLength(50)]
        public string Web { get; set; }

        public short? Is_Inner_Organize { get; set; }

        [StringLength(50)]
        public string Bank { get; set; }

        [StringLength(50)]
        public string Bank_Account { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Big_Area { get; set; }

        [StringLength(50)]
        public string Area { get; set; }

        [StringLength(50)]
        public string Joining_Methods { get; set; }

        public short? Contain_Child_Nodes { get; set; }

        [StringLength(100)]
        public string Quick_Query { get; set; }

        [StringLength(50)]
        public string Simple_Spelling { get; set; }

        public int? Province_Id { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        public int? City_Id { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        public int? District_Id { get; set; }

        [StringLength(50)]
        public string District { get; set; }

        public int? Street_Id { get; set; }

        [StringLength(50)]
        public string Street { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Statistical_Name { get; set; }

        [StringLength(40)]
        public string Master_Id { get; set; }

        [StringLength(50)]
        public string Master { get; set; }

        [StringLength(40)]
        public string Master_Phone { get; set; }

        [StringLength(50)]
        public string Master_Mobile { get; set; }

        [StringLength(50)]
        public string Master_QQ { get; set; }

        [StringLength(50)]
        public string Emergency_Call { get; set; }

        [StringLength(50)]
        public string Business_Phone { get; set; }

        [StringLength(50)]
        public string Manage_Id { get; set; }

        [StringLength(50)]
        public string Manage_Name { get; set; }

        [StringLength(40)]
        public string Manager_Phone { get; set; }

        [StringLength(50)]
        public string Manager { get; set; }

        [StringLength(50)]
        public string Manager_Mobile { get; set; }

        [StringLength(50)]
        public string Manager_QQ { get; set; }

        [StringLength(40)]
        public string Service_Manager_Id { get; set; }

        [StringLength(50)]
        public string Service_Manager { get; set; }

        [StringLength(20)]
        public string Service_Manager_QQ { get; set; }

        [StringLength(20)]
        public string Service_Manager_Phone { get; set; }

        [StringLength(20)]
        public string Service_Manager_Mobile { get; set; }

        [StringLength(200)]
        public string Complaint_Phone { get; set; }

        public short? Deletion_State_Code { get; set; }

        public short? Enabled { get; set; }

        public DateTime? Create_On { get; set; }

        [StringLength(40)]
        public string Create_User_Id { get; set; }

        [StringLength(20)]
        public string Create_By { get; set; }

        public DateTime? Modified_On { get; set; }

        [StringLength(40)]
        public string Modified_User_Id { get; set; }

        [StringLength(20)]
        public string Modified_By { get; set; }

        [StringLength(200)]
        public string Site_Telephone { get; set; }

        public short? Web_Enabled { get; set; }

        public int? Country_Id { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string Organize_From { get; set; }

        [StringLength(50)]
        public string Audit_Status { get; set; }

        [StringLength(50)]
        public string English_Name { get; set; }
    }
}
