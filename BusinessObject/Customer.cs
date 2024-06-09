using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public partial class Customer
    {
        public Customer()
        {
            BookingReservations = new HashSet<BookingReservation>();
        }

        [Key]
        public int CustomerID { get; set; }

        [StringLength(50)]
        public string CustomerFullName { get; set; }

        [StringLength(12)]
        public string Telephone { get; set; }

        [Required, StringLength(50)]
        public string EmailAddress { get; set; }

        public DateTime? CustomerBirthday { get; set; }

        public byte? CustomerStatus { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public virtual ICollection<BookingReservation> BookingReservations { get; set; }
    }

}
