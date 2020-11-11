namespace _22_EntityFramework_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Business_Card
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [StringLength(200)]
        public string Company_Name { get; set; }

        [StringLength(40)]
        public string Title { get; set; }

        [StringLength(40)]
        public string Phone { get; set; }

        [StringLength(40)]
        public string Mobile { get; set; }

        [StringLength(40)]
        public string Email { get; set; }

        [StringLength(40)]
        public string Fax { get; set; }

        [StringLength(40)]
        public string Big_Area { get; set; }

        [StringLength(40)]
        public string Duty { get; set; }

        [StringLength(800)]
        public string Responsibility { get; set; }

        [StringLength(300)]
        public string Tranfer_Range { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Tranfer_Center { get; set; }

        [StringLength(50)]
        public string Department_Name { get; set; }

        [StringLength(40)]
        public string Department_Id { get; set; }

        [StringLength(50)]
        public string Category_Code { get; set; }

        [StringLength(40)]
        public string Postalcode { get; set; }

        [StringLength(40)]
        public string Address { get; set; }

        [StringLength(40)]
        public string OfficePhone { get; set; }

        [StringLength(40)]
        public string QQ { get; set; }

        [StringLength(40)]
        public string Web { get; set; }

        [StringLength(40)]
        public string BankName { get; set; }

        [StringLength(40)]
        public string BankAccount { get; set; }

        [StringLength(40)]
        public string TaxAccount { get; set; }

        public int? Personal { get; set; }

        public int Enabled { get; set; }

        public int Deletion_State_Code { get; set; }

        public int? Sort_Code { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Create_On { get; set; }

        [StringLength(20)]
        public string Create_User_Id { get; set; }

        [StringLength(20)]
        public string Create_By { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Modified_On { get; set; }

        [StringLength(20)]
        public string Modified_User_Id { get; set; }

        [StringLength(20)]
        public string Modified_By { get; set; }

        [StringLength(50)]
        public string Center_Name { get; set; }

        [StringLength(40)]
        public string Center_Id { get; set; }

        [StringLength(50)]
        public string Sub_Department_Name { get; set; }

        [StringLength(40)]
        public string Sub_Department_Id { get; set; }
    }
}
