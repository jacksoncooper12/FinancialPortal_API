using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinancialPortal_API.Models
{
    /// <summary>
    /// Budgets
    /// </summary>
    public class Budget
    {
        /// <summary>
        /// PK For the Budget
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// FK For the Household
        /// </summary>
        public int? HouseholdId { get; set; }
        /// <summary>
        /// FK for the Budget Owner
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Date and time it was created
        /// </summary>
        public DateTime Created { get; set; }
        /// <summary>
        /// User Generated Name For Budget
        /// </summary>
        public string BudgetName { get; set; }
        /// <summary>
        /// The Budget's current monetary standing
        /// </summary>
        public decimal CurrentAmount { get; set; }
        /// <summary>
        /// Soft Delete
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}