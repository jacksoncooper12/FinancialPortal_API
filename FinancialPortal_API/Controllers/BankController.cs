using FinancialPortal_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FinancialPortal_API.Controllers
{
    /// <summary>
    /// Manages Bank Accounts
    /// </summary>
    [RoutePrefix("api/Banks")]
    public class BankAccountsController : ApiController
    {
        private ApiDbContext db = new ApiDbContext();
        /// <summary>
        /// Returns Household data by Id
        /// </summary>
        /// <param name="Id">The Bank's PK</param>
        /// <returns>Single Bank model</returns>
        [Route("GetBankDataById")]
        public async Task<BankAccount> GetBankDataById(int Id)
        {
            return await db.GetBankDataById(Id);
        }
        /// <summary>
        /// Deletes a single Bank Account by Id
        /// </summary>
        /// <param name="Id">PK of the Bank Account to delete</param>
        /// <returns></returns>
        [Route("DeleteBankById")]
        public async Task<int> DeleteBankById(int Id)
        {
            return await db.DeleteBankById(Id);
        }
        /// <summary>
        /// Creates a new Bank Account
        /// </summary>
        /// <param name="HouseholdId">PK for the Household</param>
        /// <param name="OwnerId">PK for the Owner</param>
        /// <param name="AccountName">User generated Account Name</param>
        /// <param name="StartingBalance">Beginning balance</param>
        /// <param name="WarningBalance">Warning Balance</param>
        /// <param name="AccountType">0 for Checking, 1 for Savings</param>
        /// <returns></returns>
        [Route("InsertBankData")]
        public async Task<BankAccount> InsertBankData(int HouseholdId, string OwnerId, string AccountName, decimal StartingBalance, decimal WarningBalance, int AccountType)
        {
            return await db.InsertBankData(HouseholdId, OwnerId, AccountName, StartingBalance, WarningBalance, AccountType);
        }
        /// <summary>
        /// Updates a specific Bank Account
        /// </summary>
        /// <param name="Id">PK for the Account</param>
        /// <param name="AccountName">Title for the Account</param>
        /// <param name="CurrentBalance">Current monetary amount</param>
        /// <param name="WarningBalance">Amount to be notified at</param>
        /// <returns>Updated Bank Account</returns>
        [Route("UpdateBankById")]
        [HttpPatch]
        public async Task<BankAccount> UpdateBankById(int Id, string AccountName, decimal CurrentBalance, decimal WarningBalance)
        {
            return await db.UpdateBankById(Id, AccountName, CurrentBalance, WarningBalance);
        }
    }
}
