namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Login_Log
    {
        [StringLength(40)]
        public string Id { get; set; }

        public DateTime Create_On { get; set; }

        [StringLength(50)]
        public string User_Name { get; set; }

        [StringLength(50)]
        public string Login_Status { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        [StringLength(200)]
        public string IPAddress_Name { get; set; }

        [StringLength(50)]
        public string MAC_Address { get; set; }

        [StringLength(50)]
        public string System_Code { get; set; }

        [StringLength(50)]
        public string User_Id { get; set; }

        [StringLength(50)]
        public string Real_Name { get; set; }

        [StringLength(50)]
        public string Company_Id { get; set; }

        [StringLength(50)]
        public string Company_Code { get; set; }

        [StringLength(50)]
        public string Company_Name { get; set; }

        public short? Log_Level { get; set; }

        [StringLength(50)]
        public string Source_Type { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Service { get; set; }

        public int? ElapsedTicks { get; set; }

        [StringLength(50)]
        public string Target_Application { get; set; }

        [StringLength(50)]
        public string Target_Ip { get; set; }

        public short? Result { get; set; }

        public short? Operation_Type { get; set; }
    }
}
