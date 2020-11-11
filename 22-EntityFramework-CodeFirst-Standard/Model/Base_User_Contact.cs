namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_User_Contact
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public int Email_Valiated { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        public int? Mobile_Valiated { get; set; }

        public DateTime? Mobile_Verification_Date { get; set; }

        public int? Mobile_Unique { get; set; }

        public short? Show_Mobile { get; set; }

        [StringLength(50)]
        public string Telephone { get; set; }

        [StringLength(50)]
        public string QQ { get; set; }

        [StringLength(50)]
        public string WW { get; set; }

        [StringLength(50)]
        public string WeChat_Open_Id { get; set; }

        [StringLength(50)]
        public string WeChat { get; set; }

        public int WeChat_Valiated { get; set; }

        [StringLength(50)]
        public string YiXin { get; set; }

        public int YiXin_Valiated { get; set; }

        [StringLength(50)]
        public string Short_Number { get; set; }

        [StringLength(50)]
        public string Extension { get; set; }

        [StringLength(50)]
        public string YY { get; set; }

        [StringLength(50)]
        public string Company_Mail { get; set; }

        [StringLength(50)]
        public string Emergency_Contact { get; set; }

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

        [StringLength(40)]
        public string Company_Id { get; set; }
    }
}
