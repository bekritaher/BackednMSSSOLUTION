using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Mss.Models
{
    [Table("m-pay_subscriber_verifications")]
    public class Subscriber_verification
    {
        [Key]
        [Column("m-pay_sub_verification_msisdn")]
        public String? Msisdn_sub_verification { get; set; }

        [Column("m-pay_sub_verification_client_bankcode")]
        public String? Client_bankcode_sub_verification { get; set; }

        [Column("m-pay_sub_verification_imei")]
        public String? Imei_sub_verification { get; set; }

        [Column("m-pay_sub_verification_idSession")]
        public String? IdSession_sub_verification { get; set; }

        [Column("m-pay_sub_verification_code_canal")]
        public String? CodeCanalSubVerification { get; set; }

        [Column("m-pay_sub_verification_code_app")]
        public String? Code_app_sub_verification { get; set; }

        [Column("m-pay_sub_verification_pwd")]
        public String? Pwd_sub_verification { get; set; }

        [Column("m-pay_sub_verification_otp")]
        public String? Otp_sub_verification { get; set; }

        [Column("m-pay_sub_verification_otp_date")]
        public DateTime? Otp_date_sub_verification { get; set; }

        [Column("m-pay_sub_verification_otp_status")]
        public String? Otp_status_sub_verification { get; set; }

        [Column("m-pay_sub_verification_maxTryOtp")]
        public int? MaxTryOtp_sub_verification { get; set; }

        [Column("m-pay_sub_verification_otp_count")]
        public String? Otp_count_sub_verification { get; set; }


    }
}
