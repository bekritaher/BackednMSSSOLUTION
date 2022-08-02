using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Mss.Models
{
    [Table("m-pay_merchant_tpe")]
    public class Merchant_tpe
    {

        [Key]
        [Column("m-pay_merchant_tpe_id")]
        public String? Id_merchant_tpe { get; set; }

        [Column("m-pay_merchant_tpe_affiliation_num")]
        public String? Affiliation_num_merchant_tpe { get; set; }

        [Column("m-pay_merchant_tpe_status_1")]
        public String? Status_1_merchant_tpe { get; set; }
        [Column("m-pay_merchant_tpe_status_2")]
        public String? Status_2_merchant_tpe { get; set; }

        [Column("m-pay_merchant_tpe_status_date_1")]
        public String? Status_date_1_merchant_tpe { get; set; }
        [Column("m-pay_merchant_tpe_status_date_2")]
        public String? Status_date_2_merchant_tpe { get; set; }

        [Column("m-pay_merchant_tpe_otp")]
        public String? Otp_merchant_tpe { get; set; }

        [Column("m-pay_merchant_tpe_status")]
        public String? Status_merchant_tpe { get; set; }

        [Column("m-pay_merchant_tpe_otp_status")]
        public String? Otp_status_merchant_tpe { get; set; }

        [Column("m-pay_merchant_tpe_otp_date")]
        public String? Otp_date_merchant_tpe { get; set; }

        [Column("m-pay_merchant_tpe_msisdn")]
        public String? Msisdn_merchant_tpe { get; set; }

        // sans validation

        [Column("m-pay_merchant_tpe_cardValidity")]
        public String? CardValidity_merchant_tpe { get; set; }

        [Column("m-pay_merchant_tpe_batch_num")]
        public String? Batch_num_merchant_tpe { get; set; }



        //prop de navigation

        // public virtual ICollection<subscriber> Subscribes { get; set; }
    }
}
