namespace _22_EntityFramework_CodeFirst_Standard.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PDA_USER_LOG_ON
    {
        [StringLength(40)]
        public string ID { get; set; }

        [StringLength(40)]
        public string USER_FROM { get; set; }

        [StringLength(200)]
        public string USER_PASSWORD { get; set; }

        [StringLength(40)]
        public string OPEN_ID { get; set; }

        public DateTime? ALLOW_START_TIME { get; set; }

        public DateTime? ALLOW_END_TIME { get; set; }

        public DateTime? LOCK_START_DATE { get; set; }

        public DateTime? LOCK_END_DATE { get; set; }

        public DateTime? FIRST_VISIT { get; set; }

        public DateTime? PREVIOUS_VISIT { get; set; }

        public DateTime? LAST_VISIT { get; set; }

        public int? LOG_ON_COUNT { get; set; }

        public int? PASSWORD_ERROR_COUNT { get; set; }

        public DateTime? CHANGE_PASSWORD_DATE { get; set; }

        public int? IS_STAFF { get; set; }

        public int? USER_ON_LINE { get; set; }

        public int? MULTI_USER_LOGIN { get; set; }

        public int? SHOW_COUNT { get; set; }

        public int? IS_VISIBLE { get; set; }

        public int? CHECK_IPADDRESS { get; set; }

        [StringLength(50)]
        public string VERIFICATION_CODE { get; set; }

        [StringLength(50)]
        public string IPADDRESS { get; set; }

        [StringLength(80)]
        public string MAC_ADDRESS { get; set; }

        [StringLength(50)]
        public string QUESTION { get; set; }

        [StringLength(50)]
        public string ANSWER_QUESTION { get; set; }

        public int ENABLED { get; set; }

        public int? DELETION_STATE_CODE { get; set; }

        public int? SORT_CODE { get; set; }

        [StringLength(800)]
        public string DESCRIPTION { get; set; }

        public DateTime CREATE_ON { get; set; }

        [StringLength(40)]
        public string CREATE_USER_ID { get; set; }

        [StringLength(50)]
        public string CREATE_BY { get; set; }

        public DateTime MODIFIED_ON { get; set; }

        [StringLength(40)]
        public string MODIFIED_USER_ID { get; set; }

        [StringLength(50)]
        public string MODIFIED_BY { get; set; }

        [StringLength(20)]
        public string SALT { get; set; }

        public DateTime? OPEN_ID_TIMEOUT { get; set; }

        [StringLength(50)]
        public string SYSTEM_CODE { get; set; }

        [StringLength(50)]
        public string IPADDRESS_NAME { get; set; }

        public int? PASSWORD_STRENGTH { get; set; }

        [StringLength(50)]
        public string COMPUTER_NAME { get; set; }

        public int? NEED_MODIFY_PASSWORD { get; set; }

        [StringLength(8)]
        public string COMPANY_ID { get; set; }

        [StringLength(30)]
        public string COMPANY { get; set; }

        public int? CHECK_MAC_ADDRESS { get; set; }
    }
}
