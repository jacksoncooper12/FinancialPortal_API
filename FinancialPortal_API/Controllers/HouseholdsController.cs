using FinancialPortal_API.Models;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
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
    /// Manages Households
    /// </summary>
    [RoutePrefix("api/Households")]
    public class HouseholdsController : ApiController
    {
        private ApiDbContext db = new ApiDbContext();
        /// <summary>
        /// Returns all Household data
        /// </summary>
        /// <returns>All Households</returns>
        [Route("GetAllHouseholdData")]
        public async Task<List<Household>> GetAllHouseholdData()
        {
            return await db.GetAllHouseholdData();
        }

        /// <summary>
        /// Returns all Households in Json format
        /// </summary>
        /// <returns>All Households</returns>
        [Route("GetAllHouseholdData/json")]
       public async Task<IHttpActionResult> GetDataAsJson()
        {
            var json = JsonConvert.SerializeObject(await db.GetAllHouseholdData());
            return Ok(json);
        }
        /// <summary>
        /// Returns Household Data by Id
        /// </summary>
        /// <param name="Id">PK of the Household to view</param>
        /// <returns>Single Household model</returns>
        [Route("GetHouseholdDataById")]
        public async Task<Household> GetHouseholdDataById(int Id)
        {
            return await db.GetHouseholdDataById(Id);
        }
        /// <summary>
        /// Deletes a single household by Id
        /// </summary>
        /// <param name="Id">PK of the Household to delete</param>
        /// <returns></returns>
        [Route("DeleteHouseholdById")]
        public async Task<int> DeleteHouseholdById(int Id)
        {
             return await db.DeleteHouseholdById(Id);
        }
        /// <summary>
        /// Updates a specific Household
        /// </summary>
        /// <param name="Id">PK for the Household</param>
        /// <param name="HouseholdName">Title of the Household</param>
        /// <param name="Greeting">What new users will see</param>
        /// <returns>Updated Household</returns>
        [Route("UpdateHouseholdById")]
        [HttpPatch]
        public async Task<Household> UpdateHouseholdById(int Id, string HouseholdName, string Greeting)
        {
            return await db.UpdateHouseholdById(Id, HouseholdName, Greeting);
        }

        /// <summary>
        /// Creates a new Household
        /// </summary>
        /// <param name="HouseholdName">The name of the Household</param>
        /// <param name="Greeting">What new Household members see upon joining</param>
        /// <returns>New Household</returns>
        [Route("InsertHouseholdData")]
        public async Task<Household> InsertHouseholdData(string HouseholdName, string Greeting)
        {
            return await db.InsertHouseholdData(HouseholdName, Greeting);
        }

    }
}
