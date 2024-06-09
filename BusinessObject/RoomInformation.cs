using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BusinessObject
{
    public partial class RoomInformation
    {
        public RoomInformation()
        {
            BookingDetails = new HashSet<BookingDetail>();
        }

        [Key]
        public int RoomID { get; set; }

        [Required, StringLength(50)]
        public string RoomNumber { get; set; }

        [StringLength(220)]
        public string RoomDetailDescription { get; set; }

        public int? RoomMaxCapacity { get; set; }

        [Required]
        public int RoomTypeID { get; set; }

        public byte? RoomStatus { get; set; }

        public decimal? RoomPricePerDay { get; set; }

        [ForeignKey("RoomTypeID")]
        public virtual RoomType RoomType { get; set; }

        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
    }
}
