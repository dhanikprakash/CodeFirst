using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDomain
{
    [Table("DeliveryAddresses")]
    public class DeliveryAddress
    {
        [Key]
        public int DevliverAddressID { get; set; }
        public string NickName { get; set; }
        public string DeliveryAddressPostCode { get; set; }
    }
}