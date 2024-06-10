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
            if (BookingReservations.Count == 0)
            {
                GenerateSampleData();
            }
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

        private static void GenerateSampleData()
        {
            var random = new Random();

            // Sample customers for foreign key relation
            var customers = new List<Customer>
            {
                new Customer { CustomerID = 2, CustomerFullName = "Gia Khanh" },
                new Customer { CustomerID = 3, CustomerFullName = "Hai Quyen" },
            };

            // Add sample data

            for (int i = 1; i <= 20; i++)
            {
                var bookingReservation = new BookingReservation
                {
                    BookingReservationID = countId++,
                    BookingDate = DateTime.Now.AddDays(-random.Next(0, 30)),
                    TotalPrice = (decimal)(random.Next(100, 1000) + random.NextDouble()),
                    CustomerID = customers[random.Next(customers.Count)].CustomerID,
                    BookingStatus = (byte)(random.Next(0, 2)),
                    Customer = customers[random.Next(customers.Count)]
                };

                BookingReservations.Add(bookingReservation);
            }
        }
    }
}
