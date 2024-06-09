using BusinessObject;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BookingReservationDAO
    {
        public static ObservableCollection<BookingReservation> BookingReservations = new ObservableCollection<BookingReservation>();
        private static int countId = 1;

        public static ObservableCollection<BookingReservation> GetBookingReservations()
        {
            return BookingReservations;
        }

        public static void SaveBookingReservation(BookingReservation bookingReservation)
        {
            bookingReservation.BookingReservationID = countId++;
            BookingReservations.Add(bookingReservation);
        }

        public static void UpdateBookingReservation(BookingReservation bookingReservation)
        {
            var existingReservation = BookingReservations.FirstOrDefault(br => br.BookingReservationID == bookingReservation.BookingReservationID);
            if (existingReservation != null)
            {
                existingReservation.BookingDate = bookingReservation.BookingDate;
                existingReservation.TotalPrice = bookingReservation.TotalPrice;
                existingReservation.CustomerID = bookingReservation.CustomerID;
                existingReservation.BookingStatus = bookingReservation.BookingStatus;
            }
        }

        public static void DeleteBookingReservation(BookingReservation bookingReservation)
        {
            var existingReservation = BookingReservations.FirstOrDefault(br => br.BookingReservationID == bookingReservation.BookingReservationID);
            if (existingReservation != null)
            {
                BookingReservations.Remove(existingReservation);
            }
        }

        public static BookingReservation GetBookingReservationById(int id)
        {
            return BookingReservations.FirstOrDefault(br => br.BookingReservationID == id);
        }
    }
}
