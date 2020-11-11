namespace _22_EntityFramework_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_User_Express
    {
        [StringLength(40)]
        public string ID { get; set; }

        public int? IS_CHECK_BALANCE { get; set; }

        public double? TRANSFER_ADD_FEE { get; set; }

        [StringLength(40)]
        public string OWNER_ID { get; set; }

        [StringLength(30)]
        public string OWNER_RANGE { get; set; }

        public double? DISPATCH_ADD_FEE { get; set; }

        [StringLength(2000)]
        public string RECEIVE_AREA { get; set; }

        [StringLength(40)]
        public string MODIFIED_USER_ID { get; set; }

        [StringLength(30)]
        public string MODIFIED_BY { get; set; }

        public DateTime? MODIFIED_ON { get; set; }

        [StringLength(40)]
        public string CREATE_USER_ID { get; set; }

        [StringLength(30)]
        public string CREATE_BY { get; set; }

        public DateTime? CREATE_ON { get; set; }

        public int? WEB_ENABLED { get; set; }

        [StringLength(2000)]
        public string DISP_AREA { get; set; }

        [StringLength(20)]
        public string LONGITUDE { get; set; }

        [StringLength(20)]
        public string LATITUDE { get; set; }

        [StringLength(6)]
        public string SAN_DUAN_MA { get; set; }

        public int? IS_RECEIVE { get; set; }

        public int? IS_DISP { get; set; }

        [StringLength(40)]
        public string COMPANY_ID { get; set; }

        public int? NETWORK_ORDERS { get; set; }

        [StringLength(40)]
        public string ORDER_ASSIGN_TO { get; set; }

        [StringLength(20)]
        public string COOPERATE_FUNCTION { get; set; }

        public decimal? SYS_STSBDKW3OZ1775BWH74P2XAKHX { get; set; }

        public decimal? SYS_STSIF_NCZXZZ98_YLI21T6PG2G { get; set; }
    }
}
