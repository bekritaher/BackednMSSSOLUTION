using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace digiPro.Models
{
    [Table("Commercant")]

    public class Commercant
    {
        [Key]
        
        [Column("msisdn")]
        public String? msisdn { get; set; }

        [Column("imei")]
        public String? imei { get; set; }

        [Column("bankcode")]
        public String? bankcode { get; set; }

        [Column("uuid")]
        public String? uuid { get; set; }

        [Column("idSession")]
        public String? idSession { get; set; }

        [Column("code_app")]
        public String? code_app { get; set; }

        [Column("code_canal")]
        public String? code_canal { get; set; }



    }
}
