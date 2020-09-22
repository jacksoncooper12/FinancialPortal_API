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
    /// Manages Budgets
    /// </summary>
    [RoutePrefix("api/Budgets")]
    public class BudgetsController : ApiController
    {
        private ApiDbContext db = new ApiDbContext();
        /// <summary>
        /// Returns Budget data by Id
        /// </summary>
        /// <param name="Id">Budget's PK</param>
        /// <returns>Single Budget model</returns>
        [Route("GetBudgetDataById")]
        public async Task<Budget> GetBudgetDataById(int Id)
        {
            return await db.GetBudgetDataById(Id);
        }
        /// <summary>
        /// Deletes a single Budget by Id
        /// </summary>
        /// <param name="Id">PK of the Budget to delete</param>
        /// <returns></returns>
        [Route("DeleteBudgetById")]
        public async Task<int> DeleteBudgetById(int Id)
        {
            return await db.DeleteBudgetById(Id);
        }
        /// <summary>
        /// Creates a new Budget
        /// </summary>
        /// <param name="HouseholdId">PK for the Household</param>
        /// <param name="OwnerId">PK for the Owner</param>
        /// <param name="BudgetName">User generated name for the Budget</param>
        /// <param name="CurrentAmount">Current Amount</param>
        /// <returns></returns>
        [Route("InsertBudgetData")]
        public async Task<Budget> InsertBudgetData(int HouseholdId, string OwnerId, string BudgetName, decimal CurrentAmount)
        {
            return await db.InsertBudgetData(HouseholdId, OwnerId, BudgetName, CurrentAmount);
        }
        /// <summary>
        /// Updates a specific Budget
        /// </summary>
        /// <param name="Id">Id for the Budget to be altered</param>
        /// <param name="BudgetName">Title for the Budget</param>
        /// <param name="CurrentAmount">Current monetary balance for the Budget</param>
        /// <returns></returns>
        [Route("UpdateBudgetById")]
        public async Task<Budget> UpdateBudgetById(int Id, string BudgetName, decimal CurrentAmount)
        {
            return await db.UpdateBudgetById( Id,  BudgetName,  CurrentAmount);
        }
    }
}
