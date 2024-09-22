
# Catamaran Booking Management System

## Overview
The Catamaran Booking Management System is a desktop application built using C# and WPF for managing catamaran reservations. The application is designed for administrators to add, view, edit, and delete bookings for catamaran rentals, as well as provide clients with essential information about catamaran usage.

## Key Features
- **Administrator Login:** Upon opening the application, the user must log in with a valid username and password.
- **New Booking Creation:**
  - The administrator can create new reservations by selecting the "New Booking" option from the main menu.
  - The booking form allows the input of essential booking details including:
    - Reservation date and time.
    - Catamaran type (e.g., single-seat, two-seat, three-seat).
    - Client's full name, phone number, passport series, and passport number.
  - Once the information is filled out, the administrator can click the "Add" button to save the reservation.
- **View Bookings:**
  - Administrators can view all existing bookings in a list format.
  - From the list, bookings can be modified or deleted as necessary.
- **Client Information:** A section in the menu provides detailed instructions on how to use the catamarans, ensuring customers are well-informed.

## How to Use

### 1. Launch the Application
Upon launching, the user is prompted to log in. Once logged in, the system will automatically direct you to the main menu.

### 2. Main Menu Options
The main menu on the left side of the interface provides the following options:
- **New Booking:** Opens the booking form where you can input reservation details.
- **Client Information:** Displays guidelines and instructions for catamaran usage.
- **View Bookings:** Lists all current reservations, with options to edit or delete entries.

### 3. Adding a New Booking
- Click "New Booking" in the main menu.
- Fill in the required information:
  - Date and time of the reservation.
  - Select the type of catamaran (e.g., single-seat, two-seat, three-seat).
  - Enter the client's full name, phone number, passport series, and passport number.
- Click the "Add" button to save the booking.

### 4. Viewing and Editing Bookings
- Navigate to the "View Bookings" section to see all reservations.
- To modify a booking, click the "Edit" button next to the respective booking.
- To delete a booking, click the "Delete" button next to the respective booking.

## Technologies Used
- **Programming Language:** C#
- **Framework:** WPF (Windows Presentation Foundation)
- **UI Design:** Material Design for XAML styling
- **Database:** Integrated database for storing booking information

## Installation
1. Clone the repository from the version control system.
2. Open the project in Visual Studio.
3. Build and run the project to start using the application.

## License
This project is licensed under the MIT License.
