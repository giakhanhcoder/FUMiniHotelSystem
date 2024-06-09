using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public partial class RoomType
    {
        public RoomType()
        {
            RoomInformations = new HashSet<RoomInformation>();
        }

        [Key]
        public int RoomTypeID { get; set; }

        [Required, StringLength(50)]
        public string RoomTypeName { get; set; }

        [StringLength(250)]
        public string TypeDescription { get; set; }

        [StringLength(250)]
        public string TypeNote { get; set; }

        public virtual ICollection<RoomInformation> RoomInformations { get; set; }
    }
}
