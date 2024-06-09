using BusinessObject;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BookingDetailDAO
    {
        public static ObservableCollection<BookingDetail> BookingDetails = new ObservableCollection<BookingDetail>();
        private static int countId = 1;

        public static ObservableCollection<BookingDetail> GetBookingDetails()
        {
            return BookingDetails;
        }

        public static void SaveBookingDetail(BookingDetail bookingDetail)
        {
            bookingDetail.BookingReservationID = countId++;
            BookingDetails.Add(bookingDetail);
        }

        public static void UpdateBookingDetail(BookingDetail bookingDetail)
        {
            var existingDetail = BookingDetails.FirstOrDefault(bd => bd.BookingReservationID == bookingDetail.BookingReservationID && bd.RoomID == bookingDetail.RoomID);
            if (existingDetail != null)
            {
                existingDetail.StartDate = bookingDetail.StartDate;
                existingDetail.EndDate = bookingDetail.EndDate;
                existingDetail.ActualPrice = bookingDetail.ActualPrice;
            }
        }

        public static void DeleteBookingDetail(BookingDetail bookingDetail)
        {
            var existingDetail = BookingDetails.FirstOrDefault(bd => bd.BookingReservationID == bookingDetail.BookingReservationID && bd.RoomID == bookingDetail.RoomID);
            if (existingDetail != null)
            {
                BookingDetails.Remove(existingDetail);
            }
        }

        public static BookingDetail GetBookingDetailById(int bookingReservationId, int roomId)
        {
            return BookingDetails.FirstOrDefault(bd => bd.BookingReservationID == bookingReservationId && bd.RoomID == roomId);
        }
    }
}
