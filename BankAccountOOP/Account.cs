using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountOOP
{
    abstract class Account
    {
        // The properties are for containing the values of the retrieved record for viewing
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string AccountPassword { get; set; }

        public abstract void InsertDetails(List<string> record);
        public abstract void UpdateDetails(string record, List<string> collection);
        public abstract void DeleteDetails(string id);
        public abstract void ViewDetails(int id);
    }
}
