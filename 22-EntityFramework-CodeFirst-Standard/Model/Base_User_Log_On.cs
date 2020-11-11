namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_User_Log_On
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(50)]
        public string User_From { get; set; }

        [StringLength(100)]
        public string User_Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Open_Id { get; set; }

        public DateTime? Allow_Start_Time { get; set; }

        public DateTime? Allow_End_Time { get; set; }

        public DateTime? Lock_Start_Date { get; set; }

        public DateTime? Lock_End_Date { get; set; }

        public DateTime? First_Visit { get; set; }

        public DateTime? Previous_Visit { get; set; }

        public DateTime? Last_Visit { get; set; }

        public int? Log_On_Count { get; set; }

        public int Password_Error_Count { get; set; }

        public DateTime? Change_Password_Date { get; set; }

        public short? Is_Staff { get; set; }

        public short? User_On_Line { get; set; }

        public short? Multi_User_Login { get; set; }

        public int? Show_Count { get; set; }

        public short? Is_Visible { get; set; }

        public short? Check_IPAddress { get; set; }

        [StringLength(50)]
        public string Verification_Code { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        [StringLength(50)]
        public string MAC_Address { get; set; }

        [StringLength(50)]
        public string Question { get; set; }

        [StringLength(200)]
        public string Answer_Question { get; set; }

        public short? Enabled { get; set; }

        public short? Deletion_State_Code { get; set; }

        public int? Sort_Code { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(20)]
        public string Salt { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Open_Id_Timeout { get; set; }

        [StringLength(20)]
        public string System_Code { get; set; }

        [StringLength(50)]
        public string IPAddress_Name { get; set; }

        public short? Password_Strength { get; set; }

        [StringLength(50)]
        public string Computer_Name { get; set; }

        public short? Need_Modify_Password { get; set; }

        [StringLength(40)]
        public string Company_Id { get; set; }

        [StringLength(40)]
        public string Company { get; set; }

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

        public short? Check_Mac_Address { get; set; }
    }
}
