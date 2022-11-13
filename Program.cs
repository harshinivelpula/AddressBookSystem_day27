using AddressBookSystemm;

namespace AddresBookSystemm
{
    public class Program
    {
        //creating list of contact
        public static List<Contact> ContactList = new List<Contact>();
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Sytem.");

            //ability to creating contacts
            Contact contact = new Contact();
            contact.firstName = "Anurag";
            contact.lastName = "Mendhe";
            contact.address = "Akola Maharashtra";
            contact.phone = 1234567890;
            contact.city = "Akola";
            contact.state = "Maharashtra";
            contact.zipcode = 444005;
            ContactList.Add(contact);
        }
    }
}