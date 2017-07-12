using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountOOP.Common
{
    internal class Constants
    {
        public const string DataSource = "Data Source=DESKTOP-PBHHE1A;Initial Catalog=BankOperations;Integrated Security=True";
        // stored procedure names
        public const string InsertDataOnBankAccount = "sp_InsertDataOnBankAccount";
        public const string DeleteBankRecord = "sp_DeleteBankRecord";
        public const string RetrieveBankAccountRecordById = "sp_RetrieveBankAccountRecordById";
        public const string UpdateBankAccountRecordById = "sp_UpdateBankAccountRecordById";
    }
}
