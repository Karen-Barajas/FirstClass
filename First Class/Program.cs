using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace First_Class
{
    //Book a stay at the Maxie Inn
    //Class with proper syntax
    public class Reservation
    {
        //List 5 properties
        public string OwnerName { get; set; }
        public string DogName { get; set; }
        public string DogBreed { get; set; }
        public int DogAge { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        //Constructor
        public Reservation(string ownerName, string dogName, string dogBreed, int dogAge, DateTime checkInDate, DateTime checkOutDate, string email, string phoneNumber)
        {
            OwnerName = ownerName;
            DogName = dogName;
            DogBreed = dogBreed;
            DogAge = dogAge;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        //List 2 methods

        //Calculate how long stay is
        public int Duration()
        {
            return (CheckOutDate - CheckInDate).Days;
        }
      
        //Display confirmation of reservation
        public void Confirmation()
        {
            Console.WriteLine($"Thank you, {OwnerName} for your reservation for {DogName}, Age: {DogAge}, Breed: {DogBreed}. You have booked a stay at the Maxie Inn from {CheckInDate.ToShortDateString()} to {CheckOutDate.ToShortDateString()}. A confirmation email will be sent to {Email} soon.");           
        }                          
    }

    //Run and instantiate class object and print all properties
    class Program
    {
        static void Main()
        {


            Reservation myReservation = new Reservation("Karen Barajas", "Max", "Jack Russell Terrier", 3, new DateTime(2024, 9, 1), new DateTime(2024, 9, 5), "barakare@my.dom.edu", "708-366-2490");

            myReservation.Confirmation();

            Console.WriteLine($"The duration of your reservation is {myReservation.Duration()} days. Please contact us with any questions at {myReservation.PhoneNumber}."); 
            
            Console.ReadLine();
         }
    }
}