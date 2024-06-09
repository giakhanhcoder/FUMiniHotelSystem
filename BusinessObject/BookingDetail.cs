using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public partial class BookingDetail
    {
        [Key, Column(Order = 0)]
        public int BookingReservationID { get; set; }

        [Key, Column(Order = 1)]
        public int RoomID { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public decimal? ActualPrice { get; set; }

        [ForeignKey("BookingReservationID")]
        public virtual BookingReservation BookingReservation { get; set; }

        [ForeignKey("RoomID")]
        public virtual RoomInformation RoomInformation { get; set; }
    }
}
