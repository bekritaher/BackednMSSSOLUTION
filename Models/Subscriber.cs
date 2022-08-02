using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Mss.Models
{
    [Table("m-pay_subscriber")]
    public class Subscriber
    {

        [Key]
        [Column("m-pay_sub_msisdn")]
        public String? Msisdn_subscriber { get; set; }

        [Column("m-pay_sub_client_bankcode")]
        public String? Client_bankcode_subscriber { get; set; }

        [Column("m-pay_sub_card_validity_1")]
        public String? card_validity_1_subscriber { get; set; }
        
        [Column("m-pay_sub_pwd")]
        public String? pwd_subscriber { get; set; }

        [Column("m-pay_sub_status_1")]
        public String? Statussubscriber { get; set; }
        
        [Column("mp_sub_code_app")]
        public String? code_app_subscriber { get; set; }

        [Column("mp_sub_code_canal")]
        public String? code_canal_subscriber { get; set; }

        [Column("m-pay_sub_iccid")]
        public String? iccid_subscriber { get; set; }

        [Column("m-pay_sub_imei")]
        public String? imei_subscriber { get; set; }

        [Column("m-pay_sub_otp")]
        public String? otp_subscriber { get; set; }

        [Column("m-pay_sub_otp_date")]
        public DateTime? otp_date_subscriber { get; set; }

        // sans validation

        [Column("m-pay_sub_otp_status")]
        public String? otp_status_subscriber { get; set; }

        [Column("m_pay_sub_maxTryOtp")]
        public Int32? maxTryOtp_subscriber { get; set; }

        [Column("m-pay_sub_otp_count")]
        public String? otp_count_subscriber { get; set; }

        [Column("m-pay_ sub_MerchantId")]
        public String? MerchantId_subscriber { get; set; }

        [Column("m-pay_sub_ssdm")]
        public String? ssdm_subscriber { get; set; }

        [Column("m-pay_sub_idSession")]
        public String? idSession_subscriber { get; set; }


        [Column("m-pay_sub_Is_Injected")]
        public Boolean? Is_Injected_subscriber { get; set; }


        [Column("m-pay_sub_status_1")]
        public String? status_global_subscriber { get; set; }



    }
}
