using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BookMyStyleService
{
    /// <summary>
    /// Summary description for SalonService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class SalonService : System.Web.Services.WebService
    {
        [WebMethod]
        public string BookAppointment(string customerName, string serviceType, string dateTime)
        {
            string bookingId = Guid.NewGuid().ToString();

            string record = $"{bookingId}|{customerName}|{serviceType}|{dateTime}";
            string filePath = HttpContext.Current.Server.MapPath("~/App_Data/bookings.txt");

            Directory.CreateDirectory(Path.GetDirectoryName(filePath)); // Ensure folder exists
            File.AppendAllText(filePath, record + Environment.NewLine);

            return $"Booking confirmed! ID: {bookingId}";
        }

        [WebMethod]
        public string[] GetAvailableStaff(string serviceType)
        {
            // Example only - not real logic
            return new string[] { "Stylist A", "Stylist B" };
        }

        [WebMethod]
        public List<string> GetAppointmentsByCustomer(string customerName)
        {
            string filePath = HttpContext.Current.Server.MapPath("~/App_Data/bookings.txt");
            List<string> appointments = new List<string>();

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length >= 4 && parts[1].Equals(customerName, StringComparison.OrdinalIgnoreCase))
                    {
                        appointments.Add($"Service: {parts[2]}, Date: {parts[3]}, Booking ID: {parts[0]}");
                    }
                }
            }

            return appointments;
        }
        [WebMethod]
        public string CancelBooking(string bookingId)
        {
            string filePath = HttpContext.Current.Server.MapPath("~/App_Data/bookings.txt");

            if (!File.Exists(filePath))
                return "No bookings found.";

            var lines = File.ReadAllLines(filePath).ToList();
            var updatedLines = lines.Where(line => !line.StartsWith(bookingId + "|")).ToList();

            if (lines.Count == updatedLines.Count)
                return $"Booking ID {bookingId} not found.";

            File.WriteAllLines(filePath, updatedLines);
            return $"Booking ID {bookingId} has been canceled.";
        }
        [WebMethod]
        public string SavePreferences(string customerName, string stylist, string service, string notification, string notes)
        {
            string filePath = HttpContext.Current.Server.MapPath("~/App_Data/preferences.txt");
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            string line = $"{customerName}|{stylist}|{service}|{notification}|{notes}";
            File.AppendAllText(filePath, line + Environment.NewLine);

            return "Preferences saved successfully.";
        }
        [WebMethod]
        public List<string> GetAllBookings()
        {
            string filePath = HttpContext.Current.Server.MapPath("~/App_Data/bookings.txt");
            List<string> bookings = new List<string>();

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length >= 4)
                    {
                        bookings.Add($"Booking ID: {parts[0]}, Customer: {parts[1]}, Service: {parts[2]}, Date: {parts[3]}");
                    }
                }
            }

            return bookings;
        }
        [WebMethod]
        public List<string> GetAllPreferences()
        {
            string filePath = HttpContext.Current.Server.MapPath("~/App_Data/preferences.txt");
            List<string> preferences = new List<string>();

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length >= 5)
                    {
                        preferences.Add($"Customer: {parts[0]}, Stylist: {parts[1]}, Service: {parts[2]}, Notification: {parts[3]}, Notes: {parts[4]}");
                    }
                }
            }

            return preferences;
        }
    }
}
