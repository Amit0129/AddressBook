using AddressBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Repository
{
    internal class ContactDetailsRepository
    {
        Dictionary<string, ContactDetails> contactDetails = new Dictionary<string, ContactDetails>();

        public void AddContactDetails(ContactDetails contactDetail)
        {
            string? phoneNumber = contactDetail.PhoneNumber;
            contactDetails.Add(phoneNumber, contactDetail);
            //=====================KEY=========VALUE=======
        }
        //=======================OR=========================================
        /*public void AddContactDetails(string firstname, string lastname, string mobilenumber)
        {
            ContactDetails contactDetail = new ContactDetails();
            contactDetail.FirstName = firstname;
            contactDetail.LastName = lastname;
            contactDetail.MobileNumber = mobilenumber;
            contactDetails.Add(contactDetail.MobileNumber, contactDetail);
            //========================KEY==================VALUES=======
        }*/
        public void DisplayContact()
        {
            foreach(var item in contactDetails)
            {
                Console.WriteLine($"Contact details of :: {item.Value.FirstName}");
                Console.WriteLine($"Contact details of :: {item.Value.LastName}");
                Console.WriteLine($"Contact details of :: {item.Value.PhoneNumber}");
                Console.WriteLine($"Contact details of :: {item.Value.Email}");
                Console.WriteLine($"Contact details of :: {item.Value.State}");
                Console.WriteLine($"Contact details of :: {item.Value.City}");
                Console.WriteLine($"Contact details of :: {item.Value.Zip}");
            }
        }
    }
}
