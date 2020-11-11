namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Organize_Log
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(50)]
        public string Table_Code { get; set; }

        [StringLength(200)]
        public string Table_Description { get; set; }

        [StringLength(50)]
        public string Record_Key { get; set; }

        [StringLength(50)]
        public string Column_Code { get; set; }

        [StringLength(200)]
        public string Column_Description { get; set; }

        [StringLength(50)]
        public string Old_Key { get; set; }

        [StringLength(200)]
        public string Old_Value { get; set; }

        [StringLength(50)]
        public string New_Key { get; set; }

        [StringLength(200)]
        public string New_Value { get; set; }

        [StringLength(30)]
        public string Create_IP { get; set; }

        public DateTime? Create_On { get; set; }

        [StringLength(40)]
        public string Create_Company_Id { get; set; }

        [StringLength(20)]
        public string Create_Company_Code { get; set; }

        [StringLength(50)]
        public string Create_Company { get; set; }

        [StringLength(40)]
        public string Create_User_Id { get; set; }

        [StringLength(20)]
        public string Create_User_Code { get; set; }

        [StringLength(20)]
        public string Create_By { get; set; }

        [StringLength(20)]
        public string Data_From { get; set; }
    }
}
