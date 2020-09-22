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
    /// Manages Budget Items
    /// </summary>
    [RoutePrefix("api/BudgetItems")]
    public class BudgetItemsController : ApiController
    {
        private ApiDbContext db = new ApiDbContext();
        /// <summary>
        /// Returns Budget Item data by Id
        /// </summary>
        /// <param name="Id">Budget Item's PK</param>
        /// <returns>Single Budget Item model</returns>
        [Route("GetBudgetItemDataById")]
        public async Task<BudgetItem> GetBudgetItemDataById(int Id)
        {
            return await db.GetBudgetItemDataById(Id);
        }
        /// <summary>
        /// Deletes a single Budge Item by Id
        /// </summary>
        /// <param name="Id">PK of the Budget Item to delete</param>
        /// <returns></returns>
        [Route("DeleteBudgetItemById")]
        public async Task<int> DeleteBudgetItemById(int Id)
        {
            return await db.DeleteBudgetItemById(Id);
        }
        /// <summary>
        /// Creates a new BudgetItem
        /// </summary>
        /// <param name="BudgetId">PK for the parent Budget</param>
        /// <param name="ItemName">User generated name for the Item</param>
        /// <param name="TargetAmount">Target Amount</param>
        /// <param name="CurrentAmount">Current Amount</param>
        /// <returns></returns>
        [Route("InsertBudgetItemData")]
        public async Task<BudgetItem> InsertBudgetItemData(int BudgetId, string ItemName, decimal TargetAmount, decimal CurrentAmount)
        {
            return await db.InsertBudgetItemData(BudgetId, ItemName, TargetAmount, CurrentAmount);
        }

        /// <summary>
        /// Updates a specific Budget Item
        /// </summary>
        /// <param name="Id">Id for the Item to be altered</param>
        /// <param name="ItemName">Title for the item</param>
        /// <param name="CurrentAmount">Current monetary amount for the Item</param>
        /// <param name="TargetAmount">Amount to reach for the Item</param>
        /// <returns></returns>
        [Route("UpdateBudgetItemById")]
        [HttpPatch]
        public async Task<BudgetItem> UpdateBudgetItemById(int Id, string ItemName, decimal CurrentAmount, decimal TargetAmount)
        {
            return await db.UpdateBudgetItemById(Id, ItemName, CurrentAmount, TargetAmount);
        }
    }
}
