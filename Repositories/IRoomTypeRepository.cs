using BusinessObject;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRoomTypeRepository
    {
        ObservableCollection<RoomType> GetRoomTypes();

        RoomType GetRoomTypeById(int id);

    }
}
