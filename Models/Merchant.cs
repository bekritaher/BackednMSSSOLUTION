

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Mss.Models
{
    [Table("m-pay_merchant")]
    public class Merchant

    {
        [Key]
        [Column("m-pay_merchant_affiliation_num")]
        public String? Affiliation_num_merchant { get; set; }  

        [Column("m-pay_merchant_msisdn")]
        public String? Msisdn_merchant { get; set; }

        [Column("m-pay_merchant_bank_code")]
        public String? ClientBankcodeMerchant { get; set; }
        [Column("m-pay_merchant_status")]
        public String? Status_merchant { get; set; }
        [Column("m-pay_merchant_iccid")]
        public String? Iccid_merchant { get; set; }

        [Column("m-pay_merchant_pwd")]
        public String? Pwd_merchant { get; set; }
        [Column("m-pay_merchant_type")]
        public String? Type_merchant { get; set; }

        [Column("mp_merchant_code_app")]
        public String? Code_app_merchant { get; set; }

        [Column("mp_merchant_code_canal")]
        public String? Code_canal_merchant { get; set; }


        // sans validation
        [Column("m-pay_merchant_imei")]
        public String? Imei_merchant { get; set; }

        [Column("m_pay_merchant_MCC")]
        public String? MCC_merchant { get; set; }

        [Column("m-pay_merchant_isHuawei")]
        public int? IsHuawei_merchant { get; set; }

        [Column("m-pay_merchant_PaymentType")]
        public String? PaymentType_merchant { get; set; }

        [Column("Cashout")]
        public Boolean? Cashout_merchant { get; set; }



        //prop de navigation

        // public virtual ICollection<subscriber> Subscribes { get; set; }
    }
}
