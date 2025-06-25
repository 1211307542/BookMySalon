# BookMyStyle - Salon Booking System

A comprehensive salon booking and management system built with C# Windows Forms and ASP.NET Web Services.

## 📋 Overview

BookMyStyle is a full-stack application that allows customers to book salon appointments and manage their preferences. The system consists of a Windows Forms client application and a web service backend.

## 🏗️ Architecture

### Client Application (BookMyStyleClient)
- **Technology**: C# Windows Forms (.NET Framework)
- **Purpose**: Desktop client for customers to interact with the salon booking system
- **Features**:
  - User authentication and login
  - Appointment booking and management
  - View and update customer preferences
  - Appointment history tracking
  - Staff dashboard for salon employees

### Web Service (BookMyStyleService)
- **Technology**: ASP.NET Web Services (ASMX)
- **Purpose**: Backend API for handling business logic and data operations
- **Features**:
  - RESTful web services for client communication
  - File-based data storage (bookings.txt, preferences.txt)
  - Appointment management operations
  - Customer preference management

## 🚀 Features

### Customer Features
- **User Authentication**: Secure login system
- **Appointment Booking**: Schedule salon appointments with available staff
- **Appointment Management**: View, modify, and cancel existing bookings
- **Preference Management**: Set and update personal preferences
- **History Tracking**: View past appointments and booking history

### Staff Features
- **Staff Dashboard**: Dedicated interface for salon employees
- **Booking Management**: View and manage customer appointments
- **Availability Management**: Control staff availability

### System Features
- **Real-time Booking**: Live appointment scheduling
- **Data Persistence**: File-based storage for bookings and preferences
- **Service Integration**: Web service communication between client and server

## 📁 Project Structure

```
BookMyStyle/
├── BookMyStyleClient/          # Windows Forms Client Application
│   ├── Forms/                  # UI Forms
│   │   ├── LoginForm.cs        # User authentication
│   │   ├── MainMenuForm.cs     # Main navigation
│   │   ├── ManageBookingsForm.cs # Booking management
│   │   ├── AppointmentHistoryForm.cs # History view
│   │   ├── UpdatePreferencesForm.cs # Preference management
│   │   ├── ViewPreferencesForm.cs # Preference display
│   │   └── StaffDashboardForm.cs # Staff interface
│   ├── Connected Services/     # Web service references
│   └── Resources/              # Application resources
│
└── BookMyStyleService/         # Web Service Backend
    ├── SalonService.asmx       # Main web service
    ├── App_Data/               # Data storage
    │   ├── bookings.txt        # Appointment data
    │   └── preferences.txt     # Customer preferences
    └── Web.config              # Service configuration
```

## 🛠️ Technologies Used

- **Frontend**: C# Windows Forms (.NET Framework)
- **Backend**: ASP.NET Web Services (ASMX)
- **Data Storage**: File-based storage (TXT files)
- **Communication**: SOAP Web Services
- **Development Environment**: Visual Studio

## 📦 Installation & Setup

### Prerequisites
- Visual Studio 2019 or later
- .NET Framework 4.7.2 or higher
- IIS Express (for web service)

### Setup Instructions

1. **Clone the Repository**
   ```bash
   git clone https://github.com/1211307542/BookMySalon.git
   cd BookMySalon
   ```

2. **Open the Solution**
   - Open `BookMyStyleClient/BookMyStyleClient.sln` in Visual Studio
   - Open `BookMyStyleService/BookMyStyleService.sln` in Visual Studio

3. **Build and Run**
   - Build both projects
   - Start the web service first (BookMyStyleService)
   - Then run the client application (BookMyStyleClient)

## 🔧 Configuration

### Web Service Configuration
- The web service runs on IIS Express by default
- Service endpoints are configured in the client's service references
- Data files are stored in the `App_Data` folder

### Client Configuration
- Service references are automatically configured
- Application settings are stored in `App.config`

## 📊 Data Storage

The system uses simple text files for data persistence:

- **bookings.txt**: Stores appointment information
- **preferences.txt**: Stores customer preferences

## 🔌 API Endpoints

The web service provides the following operations:

- `BookAppointment`: Create new appointments
- `CancelBooking`: Cancel existing appointments
- `GetAllBookings`: Retrieve all bookings
- `GetAppointmentsByCustomer`: Get customer-specific appointments
- `GetAvailableStaff`: Get available staff members
- `SavePreferences`: Save customer preferences
- `GetAllPreferences`: Retrieve all preferences
- `GetAppointmentsByCustomer`: Get customer-specific appointments

## 👥 User Roles

1. **Customers**: Can book appointments, manage preferences, view history
2. **Staff**: Can view bookings, manage availability through dashboard

## 🔒 Security

- User authentication required for all operations
- Session-based security
- Input validation on both client and server

## 🚀 Usage

1. **Customer Login**: Use the login form to authenticate
2. **Main Menu**: Navigate through available options
3. **Book Appointment**: Select service, date, time, and staff
4. **Manage Bookings**: View, modify, or cancel appointments
5. **Preferences**: Set and update personal preferences
6. **History**: View past appointments

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see the LICENSE file for details.

## 👨‍💻 Author

- **GitHub**: [1211307542](https://github.com/1211307542)

## 📞 Support

For support and questions, please open an issue on GitHub or contact the development team.

---

**Note**: This is a demonstration project showcasing Windows Forms development with web service integration. For production use, consider implementing a more robust database solution and additional security measures.