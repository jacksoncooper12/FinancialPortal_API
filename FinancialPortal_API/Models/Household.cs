using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinancialPortal_API.Models
{
    /// <summary>
    /// Overarching class containing users, bank accounts, budgets.
    /// </summary>
    public class Household
    {
            /// <summary>
            /// The PK for Households
            /// </summary>
            public int Id { get; set; }
            /// <summary>
            /// User generated Household name
            /// </summary>
            public string HouseholdName { get; set; }
            /// <summary>
            /// Shown to prospective joiners of the Household
            /// </summary>
            public string Greeting { get; set; }
            /// <summary>
            /// When the Household was created
            /// </summary>
            public DateTime Created { get; set; }
            /// <summary>
            /// Soft delete for the user's benefit
            /// </summary>
            public bool IsDeleted { get; set; }

    }
}