using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FUMiniHotelSystem
{
    /// <summary>
    /// Interaction logic for CreateReportWindow.xaml
    /// </summary>
    public partial class CreateReportWindow : Window
    {
        public CreateReportWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Load initial data if needed
        }

        private void btnGenerateReport_Click(object sender, RoutedEventArgs e)
        {
            DateTime startDate = dpStartDate.SelectedDate ?? DateTime.MinValue;
            DateTime endDate = dpEndDate.SelectedDate ?? DateTime.MaxValue;

            if (startDate == DateTime.MinValue || endDate == DateTime.MaxValue)
            {
                MessageBox.Show("Please select both Start Date and End Date.");
                return;
            }

            // Sample data
            var bookingDetails = new List<BookingDetail>
            {
  new BookingDetail { BookingReservationID = 1, RoomID = 101, StartDate = new DateTime(2023, 5, 1), EndDate = new DateTime(2023, 5, 5), ActualPrice = 500 },
                new BookingDetail { BookingReservationID = 2, RoomID = 102, StartDate = new DateTime(2023, 6, 1), EndDate = new DateTime(2023, 6, 3), ActualPrice = 300 },
                new BookingDetail { BookingReservationID = 3, RoomID = 103, StartDate = new DateTime(2023, 7, 10), EndDate = new DateTime(2023, 7, 15), ActualPrice = 600 },
                new BookingDetail { BookingReservationID = 4, RoomID = 104, StartDate = new DateTime(2023, 8, 1), EndDate = new DateTime(2023, 8, 4), ActualPrice = 400 },
                new BookingDetail { BookingReservationID = 5, RoomID = 105, StartDate = new DateTime(2023, 9, 5), EndDate = new DateTime(2023, 9, 10), ActualPrice = 700 },
                new BookingDetail { BookingReservationID = 6, RoomID = 106, StartDate = new DateTime(2023, 10, 15), EndDate = new DateTime(2023, 10, 18), ActualPrice = 350 },
                new BookingDetail { BookingReservationID = 7, RoomID = 107, StartDate = new DateTime(2023, 11, 20), EndDate = new DateTime(2023, 11, 25), ActualPrice = 800 },
                new BookingDetail { BookingReservationID = 8, RoomID = 108, StartDate = new DateTime(2024, 1, 5), EndDate = new DateTime(2024, 1, 7), ActualPrice = 200 },
                new BookingDetail { BookingReservationID = 9, RoomID = 109, StartDate = new DateTime(2024, 2, 10), EndDate = new DateTime(2024, 2, 15), ActualPrice = 900 },
                new BookingDetail { BookingReservationID = 10, RoomID = 110, StartDate = new DateTime(2024, 3, 1), EndDate = new DateTime(2024, 3, 4), ActualPrice = 450 },
                new BookingDetail { BookingReservationID = 11, RoomID = 111, StartDate = new DateTime(2024, 4, 12), EndDate = new DateTime(2024, 4, 15), ActualPrice = 550 },
                new BookingDetail { BookingReservationID = 12, RoomID = 112, StartDate = new DateTime(2024, 5, 20), EndDate = new DateTime(2024, 5, 22), ActualPrice = 250 },
                new BookingDetail { BookingReservationID = 13, RoomID = 113, StartDate = new DateTime(2024, 6, 25), EndDate = new DateTime(2024, 6, 28), ActualPrice = 650 },
                new BookingDetail { BookingReservationID = 14, RoomID = 114, StartDate = new DateTime(2024, 7, 10), EndDate = new DateTime(2024, 7, 12), ActualPrice = 300 },
                new BookingDetail { BookingReservationID = 15, RoomID = 115, StartDate = new DateTime(2024, 8, 15), EndDate = new DateTime(2024, 8, 18), ActualPrice = 750 },
                new BookingDetail { BookingReservationID = 16, RoomID = 116, StartDate = new DateTime(2024, 9, 20), EndDate = new DateTime(2024, 9, 25), ActualPrice = 850 },
                new BookingDetail { BookingReservationID = 17, RoomID = 117, StartDate = new DateTime(2024, 10, 5), EndDate = new DateTime(2024, 10, 7), ActualPrice = 150 },
                new BookingDetail { BookingReservationID = 18, RoomID = 118, StartDate = new DateTime(2024, 11, 1), EndDate = new DateTime(2024, 11, 3), ActualPrice = 600 },
                new BookingDetail { BookingReservationID = 19, RoomID = 119, StartDate = new DateTime(2024, 12, 10), EndDate = new DateTime(2024, 12, 15), ActualPrice = 950 }
                // Add more sample data here
            };

            var filteredData = bookingDetails
                                .Where(bd => bd.StartDate >= startDate && bd.EndDate <= endDate)
                                .OrderByDescending(bd => bd.StartDate)
                                .ToList();

            dgReportData.ItemsSource = filteredData;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
