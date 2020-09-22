using FinancialPortal_API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinancialPortal_API.Models
{
    /// <summary>
    /// Transaction
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// PK for the Transaction
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// FK for the parent Bank Account
        /// </summary>
        public int AccountId { get; set; }
        /// <summary>
        /// FK for the parent Budget Item
        /// </summary>
        public int? BudgetItemId { get; set; }

        /// <summary>
        /// FK for the Owner
        /// </summary>
        public string OwnerId { get; set; }
        /// <summary>
        /// Transaction Type
        /// </summary>
        public TransactionType TransactionType { get; set; }

        //public TransactionType TransactionType { get; set; }
        /// <summary>
        /// Date and time it was created
        /// </summary>
        public DateTime Created { get; set; }
        /// <summary>
        /// Monetary Trasaction amount
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// Included message with Transaction
        /// </summary>
        public string Memo { get; set; }
        /// <summary>
        /// Soft delete
        /// </summary>
        public bool IsDeleted { get; set; }

    }
}