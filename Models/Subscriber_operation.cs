using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Mss.Models
{
    [Table("m-pay_subscriber_operations")]
    public class Subscriber_operation
    {


        [Key]
        [Column("m-pay_sub_ops_type")]
        public String? Type_sub_ops { get; set; }

        [Column("m-pay_sub_ops_date")]
        public String? Date_ops { get; set; }

        //[Column("m-pay_sub_ops_result_code")]
        //public String? Result_code_sub_ops { get; set; }

        //[Column("m_pay_sub_ops_maxTryOtp")]
        //public Int32? MaxTryOtp_sub_ops { get; set; }

        //[Column("m-pay_sub_ops_id_session")]
        //public String? Id_session_sub_ops { get; set; }

        //[Column("m-pay_sub_ops_msisdn_receiver")]
        //public String? Msisdn_receiver_sub_ops { get; set; }

        //[Column("m-pay_sub_ops_status")]
        //public String? Status_sub_ops { get; set; }

        //[Column("m-pay_sub_ops_terminal")]
        //public String? Terminal_sub_ops { get; set; }

        //[Column("mp_sub_ops_code_app")]
        //public String? Code_app_sub_ops { get; set; }

        //[Column("mp_sub_ops_code_canal")]
        //public String? Code_canal_sub_ops { get; set; }



    }
}