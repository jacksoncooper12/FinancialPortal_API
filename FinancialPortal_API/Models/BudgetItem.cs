using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinancialPortal_API.Models
{
    /// <summary>
    /// Budget Items
    /// </summary>
    public class BudgetItem
    {
        /// <summary>
        /// Budget Item's PK
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Budget's FK
        /// </summary>
        public int BudgetId { get; set; }
        /// <summary>
        /// Date and time it was created
        /// </summary>
        public DateTime Created { get; set; }
        /// <summary>
        /// User generated Item Name
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// User generated Target balance for the Item
        /// </summary>
        public decimal TargetAmount { get; set; }
        /// <summary>
        /// Current balance for the Item
        /// </summary>
        public decimal CurrentAmount { get; set; }
        /// <summary>
        /// Soft Delete
        /// </summary>
        public bool IsDeleted { get; set; }

    }
}