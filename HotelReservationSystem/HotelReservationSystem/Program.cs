using System;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace HotelReservationSystem
{
    internal class Program
    {
        //Booking room function
        static void BookingRoom()                     
        {
            //Declaring datatypes and variables
            string guestName, roomType = "";
            DateTime checkInDate, checkOutDate;
            bool validRoomType = true;

            Console.WriteLine("\nEnter guest name:");
            guestName = Console.ReadLine();

            do
            {
                Console.WriteLine("\nEnter room type (Single/Double/Suite):");
                roomType = Console.ReadLine();
                switch (roomType)
                {
                    case "Single":
                    case "Double":
                    case "Suite":
                        validRoomType = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid room type (Single/Double/Suite):");
                        break;
                }

            } while (validRoomType != false);

            Console.WriteLine("\nEnter Check-in Date (MM/DD/YYYY):");
            checkInDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter Check-out Date (MM/DD/YYYY):");
            checkOutDate = DateTime.Parse(Console.ReadLine());

            if (roomType == "Single")
            {
                Console.WriteLine($"\nRoom 102 booked for {guestName} from {checkInDate} to {checkOutDate}");
            }
            else if(roomType == "Double")
            {
                Console.WriteLine($"\nRoom 202 booked for {guestName} from {checkInDate} to {checkOutDate}");
            }
            else
            {
                Console.WriteLine($"\nRoom 301 booked for {guestName} from {checkInDate} to {checkOutDate}");
            }

            Booking newBooking = new Booking
            {
                GuestName = guestName,
                RoomType = roomType,
                CheckInDate = checkInDate,
                CheckOutDate = checkOutDate
            };

            bookingHistory.Add(newBooking);
            Console.WriteLine("\nBooking successfully added!");


        }

        //Checking in guest function
        static void CheckInGuest()
        {
            //Declaring datatypes and variables
            string guestName;
            int roomNum;

            Console.WriteLine("\nEnter guest name:");
            guestName= Console.ReadLine();

            Console.WriteLine("\nEnter room number:");
            roomNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n{guestName} has been check into room {roomNum}");

        }

        //Checking out guest function
        static void CheckOutGuest()
        {
            int roomNum;

            Console.WriteLine("\nEnter room number to check-out:");
            roomNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nRoom {roomNum} is now available for new guest");



        }


        //Viewing available rooms function
        static void ViewAvilableRooms()
        {
            DateTime checkInDate, checkOutDate;

            Console.WriteLine("\nEnter Check-in Date (MM/DD/YYYY):");
            checkInDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter Check-out Date (MM/DD/YYYY):");
            checkOutDate = DateTime.Parse(Console.ReadLine());

            string roomType1 = "Single";
            string roomType2 = "Double";
            string roomType3 = "Suite";

            Console.WriteLine("\nAvalable Rooms:");
            Console.WriteLine($"Room 102 ({roomType1})");
            Console.WriteLine($"Room 202 ({roomType2})");
            Console.WriteLine($"Room 301 ({roomType3})");
        }

        //Viewing Revervation History function
        static void ViewReservationHistory()
        {
            Console.WriteLine("\nBooking History:");
            if (bookingHistory.Count == 0)
            {
                Console.WriteLine("No bookings found.");
            }
            else
            {
                foreach (var booking in bookingHistory)
                {
                    Console.WriteLine(booking);
                }
            }


        }

        static List<Booking> bookingHistory = new List<Booking>();

        static void Main(string[] args)
        {

            
            int option;
            string guestName, roomType, checkInDate, checkOutDate;
            int roomNum;

            do
            {
                Console.WriteLine("\n-----------------Hotel Reservation System--------------------------");

                Console.WriteLine("1. Book Room");
                Console.WriteLine("2. Check-in Guest");
                Console.WriteLine("3. Check-out Guest");
                Console.WriteLine("4. View Avaiable Rooms");
                Console.WriteLine("5. View Reservative History");
                Console.WriteLine("6. Exit");

                Console.WriteLine("Chose an option (1-6):");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        BookingRoom();
                       
                        break;

                    case 2:
                        CheckInGuest();

                        break;
                    case 3:
                        CheckOutGuest();

                        break;

                    case 4:
                        ViewAvilableRooms();
                        break;

                    case 5:
                        ViewReservationHistory();

                        break;

                }

            }while (option !=6);

            Console.WriteLine("\nThank you for using the hotel reservation system");

            Console.WriteLine("\n-----------------End of Hotel Reservation System--------------------------");



        }
    }
}
