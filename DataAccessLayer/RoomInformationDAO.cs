using BusinessObject;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RoomInformationDAO
    {
        public static ObservableCollection<RoomInformation> RoomInformations = new ObservableCollection<RoomInformation>();
        private static int countId = 1;

        public static ObservableCollection<RoomInformation> GetRoomInformations()
        {
            return RoomInformations;
        }

        public static void SaveRoomInformation(RoomInformation roomInformation)
        {
            roomInformation.RoomID = countId++;
            RoomInformations.Add(roomInformation);
        }

        public static void UpdateRoomInformation(RoomInformation roomInformation)
        {
            var existingRoom = RoomInformations.FirstOrDefault(r => r.RoomID == roomInformation.RoomID);
            if (existingRoom != null)
            {
                existingRoom.RoomNumber = roomInformation.RoomNumber;
                existingRoom.RoomDetailDescription = roomInformation.RoomDetailDescription;
                existingRoom.RoomMaxCapacity = roomInformation.RoomMaxCapacity;
                existingRoom.RoomTypeID = roomInformation.RoomTypeID;
                existingRoom.RoomStatus = roomInformation.RoomStatus;
                existingRoom.RoomPricePerDay = roomInformation.RoomPricePerDay;
            }
        }

        public static void DeleteRoomInformation(RoomInformation roomInformation)
        {
            var existingRoom = RoomInformations.FirstOrDefault(r => r.RoomID == roomInformation.RoomID);
            if (existingRoom != null)
            {
                RoomInformations.Remove(existingRoom);
            }
        }

        public static RoomInformation GetRoomInformationById(int id)
        {
            return RoomInformations.FirstOrDefault(r => r.RoomID == id);
        }
    }
}
