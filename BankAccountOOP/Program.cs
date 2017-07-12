using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountOOP
{
    class Program
    {
        public List<string> bankRecord { get; set; }
        

        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            List<string> userRecord = new List<string>();
            Program p = new Program();

            // For Account
            //Console.WriteLine("Please enter client information:");

            //Console.Write("First Name:");
            //string firstNameInput = Console.ReadLine();
            //Console.Write("Middle Name:");
            //string middleNameInput = Console.ReadLine();
            //Console.Write("Last Name:");
            //string lastNameInput = Console.ReadLine();
            //Console.Write("Age:");
            //string ageInput = Console.ReadLine();
            //Console.Write("Email:");
            //string emailInput = Console.ReadLine(); 
            //Console.Write("Username:");
            //string userNameInput = Console.ReadLine();
            //Console.Write("Password:");
            //string passwordInput = Console.ReadLine();

            //userRecord.Add(firstNameInput);
            //userRecord.Add(middleNameInput);
            //userRecord.Add(lastNameInput);
            //userRecord.Add(ageInput.ToString());
            //userRecord.Add(emailInput);
            //userRecord.Add(userNameInput);
            //userRecord.Add(passwordInput);


            //GetBankDetails();
            //Delete a record?
            string cont = null;
            do
            {   
                Console.WriteLine("What actions do you want to do?");
                Console.WriteLine("Bank Account Records:");
                Console.WriteLine("\t(1)Display Bank Account Records" +
                                  "\n\t(2)Insert Bank Account Records" +
                                  "\n\t(3)Update Bank Details" +
                                  "\n\t(4)Delete Bank Account Records");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("Please select the number above to perform action:");
                
                string command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        break;
                    case "2":
                        InsertBankDetails();
                        break;
                    case "3":
                        UpdateBankRecord();
                        break;
                    case "4":
                        DeleteABankRecord();
                        break;
                    default:
                        break;
                }
                Console.Write("Do you want to continue?(Y/N)");
                cont = Console.ReadLine();
                Console.Clear();
            }
            while (cont == "Y" || cont == "y");
        }

        private static void InsertBankDetails()
        {
            // For Bank Account
            Console.WriteLine("Please enter bank details:");
            Program p = new Program();
            BankAccount bankAccount = new BankAccount();

            Console.Write("Bank Account Password: ");
            string bankPasswordInput = Console.ReadLine();
            Console.Write("Pin: ");
            string pinInput = Console.ReadLine();
            Console.Write("Bank Account Type: ");
            string bankAccountTypeInput = Console.ReadLine();
            
            string joinDateInput = DateTime.Today.ToString();
            Console.WriteLine("Join Date: " + joinDateInput);
            
            Console.ReadKey();

            bankAccount.InsertDetails(p.BankRecordList(bankPasswordInput, pinInput, bankAccountTypeInput, joinDateInput));
        }

        private static void DeleteABankRecord()
        {
            Program p = new Program();
            BankAccount bankAccount = new BankAccount();

            Console.WriteLine("Please enter the id of the bank record to be deleted:");
            Console.Write("Bank Account Id: ");
            string bankIdInput = Console.ReadLine();


            Console.Write("Are you sure you want to delete this record?(Y/N)");
            string command = Console.ReadLine();
            if (command == "Y" || command == "y")
            {
                bankAccount.DeleteDetails(bankIdInput);
            }
            Console.ReadKey();
        }

        private static void UpdateBankRecord()
        {
            Program p = new Program();
            List<string> record = new List<string>();
            BankAccount bankAccount = new BankAccount();

            Console.WriteLine("Please enter the id of the bank record to be updated:");
            Console.Write("Bank Account Id: ");
            string bankIdInput = Console.ReadLine();


            Console.Write("Are you sure you want to update this record?(Y/N)");
            string command = Console.ReadLine();
            if (command == "Y" || command == "y")
            {
                Console.WriteLine("Please enter the new values of the bank record to be updated:");
                Console.Write("Bank Account Password: ");
                string bankPasswordInput = Console.ReadLine();
                Console.Write("Bank Account Pin: ");
                string bankPinInput = Console.ReadLine();
                Console.Write("Bank Account Type: ");
                string bankAccountTypeInput = Console.ReadLine();
                Console.Write("Bank Joining Date: ");
                string bankJoinDateInput = DateTime.Now.ToShortDateString();

                record.Add(bankPasswordInput);
                record.Add(bankPinInput);
                record.Add(bankAccountTypeInput);
                record.Add(bankJoinDateInput);
                bankAccount.UpdateDetails(bankIdInput, record);
            }
            

            Console.ReadKey();
        }

        private List<string> BankRecordList(string bankPassword, string pin,
            string bankAccountType, string date)
        {
            bankRecord = new List<string>();
            bankRecord.Add(bankPassword);
            bankRecord.Add(pin);
            bankRecord.Add(bankAccountType);
            bankRecord.Add(date);

            return bankRecord;
        }
    }
}
