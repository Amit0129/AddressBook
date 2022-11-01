using AddressBook.Model;
using AddressBook.Repository;
using System.Transactions;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactDetailsRepository contactDetails = new ContactDetailsRepository();
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
            Console.WriteLine("Enter persons First Naame if you want to change the contact details");
            string name = Console.ReadLine();
            Console.WriteLine("To change First name Enter 1 \n To change Last Name Enter 2 \n To change Address Enter 3 \n To change City nameEnter 4 \n To change State Enter 5 \n To change Zip enter 6 \n To change Phone Number ebter 7 \n To change email enter 8  ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter new First Name u Want to Update");
                    string fName = Console.ReadLine();
                    contactDetails.EditContactFirstName(name, fName);
                    break;
                case 2:
                    Console.WriteLine("Enter new Last Name You Want to Update");
                    string lName = Console.ReadLine();
                    contactDetails.EditContactLastName(name, lName);
                    break;
                case 3:
                    Console.WriteLine("Enter new Address You Want to Update");
                    string aDress = Console.ReadLine();
                    contactDetails.EditContactAdress(name, aDress);
                    break;
                case 4:
                    Console.WriteLine("Enter new City Name You Want to Update");
                    string cIty = Console.ReadLine();
                    contactDetails.EditContactCity(name, cIty);
                    break;
                case 5:
                    Console.WriteLine("Enter new State Want to Update");
                    string stat = Console.ReadLine();
                    contactDetails.EditContactState(name, stat);
                    break;
                case 6:
                    Console.WriteLine("Enter new Zip code Want to Update");
                    string zipCo = Console.ReadLine();
                    contactDetails.EditContactZip(name, zipCo);
                    break;
                case 7:
                    Console.WriteLine("Enter new phone number you Want to Update");
                    string pno = Console.ReadLine();
                    contactDetails.EditContactPhoneNumber(name, pno);
                    break;
                case 8:
                    Console.WriteLine("Enter new Email Id You Want to Update");
                    string emaill = Console.ReadLine();
                    contactDetails.EditContactEmail(name, emaill);
                    break;
            }
            


        }
    }
}