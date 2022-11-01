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
        public ContactDetails GetFirstName(string firstname)
        {
            foreach (var item in contactDetails)
            {
                if(item.Value.FirstName.Contains(firstname))
                {
                    return item.Value;
                }
            }
            return null;
        }
        public void EditContactFirstName(string firstname,string firstN)
        {
            var personDetail = GetFirstName(firstname);
            contactDetails.Remove(personDetail.PhoneNumber);
            personDetail.FirstName = firstN;
            contactDetails.Add(personDetail.PhoneNumber, personDetail);

        }
        public void EditContactLastName(string firstname, string lastN)
        {
            var personDetail = GetFirstName(firstname);
            contactDetails.Remove(personDetail.PhoneNumber);
            personDetail.LastName = lastN;
            contactDetails.Add(personDetail.PhoneNumber, personDetail);

        }
        public void EditContactAdress(string firstname, string addrs)
        {
            var personDetail = GetFirstName(firstname);
            contactDetails.Remove(personDetail.PhoneNumber);
            personDetail.Address = addrs;
            contactDetails.Add(personDetail.PhoneNumber, personDetail);

        }
        public void EditContactCity(string firstname, string cit)
        {
            var personDetail = GetFirstName(firstname);
            contactDetails.Remove(personDetail.PhoneNumber);
            personDetail.City = cit;
            contactDetails.Add(personDetail.PhoneNumber, personDetail);

        }
        public void EditContactState(string firstname, string ste)
        {
            var personDetail = GetFirstName(firstname);
            contactDetails.Remove(personDetail.PhoneNumber);
            personDetail.State = ste;
            contactDetails.Add(personDetail.PhoneNumber, personDetail);

        }
        public void EditContactZip(string firstname, string zi)
        {
            var personDetail = GetFirstName(firstname);
            contactDetails.Remove(personDetail.PhoneNumber);
            personDetail.Zip = zi;
            contactDetails.Add(personDetail.PhoneNumber, personDetail);

        }
        public void EditContactPhoneNumber(string firstname, string phNo)
        {
            var personDetail = GetFirstName(firstname);
            contactDetails.Remove(personDetail.PhoneNumber);
            personDetail.PhoneNumber = phNo;
            contactDetails.Add(personDetail.PhoneNumber, personDetail);

        }
        public void EditContactEmail(string firstname, string emai)
        {
            var personDetail = GetFirstName(firstname);
            contactDetails.Remove(personDetail.PhoneNumber);
            personDetail.Email = emai;
            contactDetails.Add(personDetail.PhoneNumber, personDetail);

        }

}
