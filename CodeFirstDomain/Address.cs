using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDomain
{
    [Table("Addresses")]
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string StreetName { get; set; }
        public string PostCode { get; set; }

        public DeliveryAddress DeliverAddress { get; set; }
    }
}