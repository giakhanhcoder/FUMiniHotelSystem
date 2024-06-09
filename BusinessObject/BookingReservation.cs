using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public partial class BookingReservation
    {
        public BookingReservation()
        {
            BookingDetails = new HashSet<BookingDetail>();
        }

        [Key]
        public int BookingReservationID { get; set; }

        public DateTime? BookingDate { get; set; }

        public decimal? TotalPrice { get; set; }

        [Required]
        public int CustomerID { get; set; }

        public byte? BookingStatus { get; set; }

        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }

        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
    }
}
