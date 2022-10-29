using AddressBook.Model;
using AddressBook.Repository;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            

            while (check)
            {

                Console.WriteLine("Welcome to Address Book Program");

                Console.WriteLine("Enter First Name");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter Last Name");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter Address");
                string address = Console.ReadLine();

                Console.WriteLine("Enter City Name");
                string city = Console.ReadLine();


                Console.WriteLine("Enter State Name");
                string state = Console.ReadLine();

                Console.WriteLine("Enter  Zip number");
                string zip = Console.ReadLine();

                Console.WriteLine("Enter Phone Number");
                string pnoneNumber = Console.ReadLine();

                Console.WriteLine("Enter Email");
                string email = Console.ReadLine();

                ContactDetails contactDetail = new ContactDetails()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Address = address,
                    City = city,
                    State = state,
                    Zip = zip,
                    PhoneNumber = pnoneNumber,
                    Email = email
                };
                ContactDetailsRepository contactDetails = new ContactDetailsRepository();
                contactDetails.AddContactDetails(contactDetail);


                contactDetails.DisplayContact();
                Console.WriteLine("Enter y if u want more Contact Deatils");
                string dicision = Console.ReadLine();
                if(dicision == "y")
                {
                    check = true;
                }
                else
                {
                    check = false;
                }


            }

        }
    }
}