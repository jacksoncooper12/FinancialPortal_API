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
    /// Manages Transactions
    /// </summary>
    [RoutePrefix("api/Transactions")]
    public class TransactionsController : ApiController
    {
        private ApiDbContext db = new ApiDbContext();
        /// <summary>
        /// Returns Transaction data by Id
        /// </summary>
        /// <param name="Id">Transaction's PK</param>
        /// <returns>Single Budget Item model</returns>
        [Route("GetTransactionDataById")]
        public async Task<Transaction> GetTransactionDataById(int Id)
        {
            return await db.GetTransactionDataById(Id);
        }
        /// <summary>
        /// Deletes a single Transaction by Id
        /// </summary>
        /// <param name="Id">PK of the Transaction to delete</param>
        /// <returns></returns>
        [Route("DeleteTransactionById")]
        public async Task<int> DeleteTransactionById(int Id)
        {
            return await db.DeleteTransactionById(Id);
        }
    }
}
