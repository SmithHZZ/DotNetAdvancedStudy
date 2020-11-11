namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Contact
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(40)]
        public string Parent_Id { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(100)]
        public string Color { get; set; }

        [StringLength(40)]
        public string Style { get; set; }

        [StringLength(400)]
        public string Contents { get; set; }

        [StringLength(40)]
        public string Priority { get; set; }

        [StringLength(40)]
        public string Customer_Name { get; set; }

        [StringLength(50)]
        public string Customer_Sex { get; set; }

        [StringLength(60)]
        public string Customer_Telephone { get; set; }

        [StringLength(80)]
        public string Customer_Email { get; set; }

        public int? Cancel_Top_Day { get; set; }

        [StringLength(40)]
        public string Source { get; set; }

        [StringLength(40)]
        public string Category_Code { get; set; }

        [StringLength(40)]
        public string Label_Mark { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int? Send_Count { get; set; }

        public int? Read_Count { get; set; }

        public int? Reply_Count { get; set; }

        public int? Must_Read { get; set; }

        public int? Must_Reply { get; set; }

        public int? Is_Open { get; set; }

        [StringLength(30)]
        public string IPAddress { get; set; }

        public int? Allow_Comments { get; set; }

        public int? Enabled { get; set; }

        [StringLength(40)]
        public string Comment_User_Id { get; set; }

        [StringLength(40)]
        public string Comment_User_Real_Name { get; set; }

        public DateTime? Comment_Date { get; set; }

        public int? Deletion_State_Code { get; set; }

        [StringLength(40)]
        public string Audit_Status { get; set; }

        [StringLength(40)]
        public string Audit_User_Id { get; set; }

        [StringLength(50)]
        public string Audit_User_Real_Name { get; set; }

        public int? Sort_Code { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Create_On { get; set; }

        [StringLength(20)]
        public string Create_User_Id { get; set; }

        [StringLength(20)]
        public string Create_By { get; set; }

        [StringLength(40)]
        public string Create_Department_Id { get; set; }

        [StringLength(50)]
        public string Create_Department { get; set; }

        [StringLength(50)]
        public string Create_Company { get; set; }

        [StringLength(40)]
        public string Create_Company_Id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Modified_On { get; set; }

        [StringLength(20)]
        public string Modified_User_Id { get; set; }

        [StringLength(20)]
        public string Modified_By { get; set; }

        [StringLength(10)]
        public string Recruit_Num { get; set; }
    }
}
