using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    class ContactHelper : HelperBase
    {
        public ContactHelper (ApplicationManager manager) : base(manager) { 
        }

        public ContactData GetContactInformationFromTable(int index)
        {

        }

        public ContactData GetContactInformationFromEditForm(int index)
        {
            manager.Navigatior.GoToHomePage();
            initContactModification(0);
            string firstName = driver.FindElement(by.Name("firstname")).GetAttribute("value");
            string lastName = driver.FindElement(by.Name("lastname")).GetAttribute("value");
            string address = driver.FindElement(by.Name("address")).GetAttribute("value");

            string homePhone = driver.FindElement(by.Name("home")).GetAttribute("value");
            string mobilePhone = driver.FindElement(by.Name("mobile")).GetAttribute("value");
            string workPhone = driver.FindElement(by.Name("work")).GetAttribute("value");
        }

        public void initContactModification()
        {
            throw new NotImplementedException();
        }
    }

}
