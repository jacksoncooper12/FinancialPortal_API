using FinancialPortal_API.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FinancialPortal_API.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext()
            : base("ApiConnection")
        {
        }


        //public DbSet<Household> Households { get; set; }
        public async Task<List<Household>> GetAllHouseholdData()
        {
            return await Database.SqlQuery<Household>("GetAllHouseholdData").ToListAsync();
        }
        #region GetDataById
        public async Task<Household> GetHouseholdDataById(int Id)
        {
            return await Database.SqlQuery<Household>("GetHouseholdDataById @Id",
                new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }
        public async Task<BankAccount> GetBankDataById(int Id)
        {
            return await Database.SqlQuery<BankAccount>("GetBankDataById @Id",
                new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }
        public async Task<Budget> GetBudgetDataById(int Id)
        {
            return await Database.SqlQuery<Budget>("GetBudgetDataById @Id",
                new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }
        public async Task<BudgetItem> GetBudgetItemDataById(int Id)
        {
            return await Database.SqlQuery<BudgetItem>("GetBudgetItemDataById @Id",
                new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }
        public async Task<Transaction> GetTransactionDataById(int Id)
        {
            return await Database.SqlQuery<Transaction>("GetTransactionDataById @Id",
                new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }
        #endregion
        #region DeleteById
        public async Task<int> DeleteHouseholdById(int Id)
        {
            return await Database.ExecuteSqlCommandAsync("DeleteHouseholdById @Id",
               new SqlParameter("Id", Id));
        }
        public async Task<int> DeleteBudgetById(int Id)
        {
            return await Database.ExecuteSqlCommandAsync("DeleteBudgetById @Id",
               new SqlParameter("Id", Id));
        }
        public async Task<int> DeleteBudgetItemById(int Id)
        {
            return await Database.ExecuteSqlCommandAsync("DeleteBudgetItemById @Id",
               new SqlParameter("Id", Id));
        }
        public async Task<int> DeleteTransactionById(int Id)
        {
            return await Database.ExecuteSqlCommandAsync("DeleteTransactionById @Id",
               new SqlParameter("Id", Id));
        }
        public async Task<int> DeleteBankById(int Id)
        {
            return await Database.ExecuteSqlCommandAsync("DeleteBankById @Id",
               new SqlParameter("Id", Id));
        }
        #endregion
        #region UpdateById
        public async Task<Household> UpdateHouseholdById(int Id, string HouseholdName, string Greeting)
        {
            return await Database.SqlQuery<Household>("UpdateHouseholdById @Id, @HouseholdName, @Greeting",
               new SqlParameter("Id", Id),
               new SqlParameter("HouseholdName", HouseholdName),
               new SqlParameter("Greeting", Greeting)
               ).FirstOrDefaultAsync();
        }
        public async Task<BankAccount> UpdateBankById(int Id, string AccountName, decimal CurrentBalance, decimal WarningBalance)
        {
            return await Database.SqlQuery<BankAccount>("UpdateBankById @Id, @AccountName, @CurrentBalance, @WarningBalance",
               new SqlParameter("Id", Id),
               new SqlParameter("AccountName", AccountName),
               new SqlParameter("CurrentBalance", CurrentBalance),
               new SqlParameter("WarningBalance", WarningBalance)
               ).FirstOrDefaultAsync();
        }
        public async Task<Budget> UpdateBudgetById(int Id, string BudgetName, decimal CurrentAmount)
        {
            return await Database.SqlQuery<Budget>("UpdateBudgetById @Id, @BudgetName, @CurrentAmount",
               new SqlParameter("Id", Id),
               new SqlParameter("BudgetName", BudgetName),
               new SqlParameter("CurrentAmount", CurrentAmount)
               ).FirstOrDefaultAsync();
        }
        public async Task<BudgetItem> UpdateBudgetItemById(int Id, string ItemName, decimal CurrentAmount, decimal TargetAmount)
        {
            return await Database.SqlQuery<BudgetItem>("UpdateBudgetItemById @Id, @ItemName, @CurrentAmount, @TargetAmount",
               new SqlParameter("Id", Id),
               new SqlParameter("ItemName", ItemName),
               new SqlParameter("CurrentAmount", CurrentAmount),
               new SqlParameter("TargetAmount", TargetAmount)
               ).FirstOrDefaultAsync();
        }
        public async Task<Household> UpdateTransactionById(int Id, string HouseholdName, string Greeting)
        {
            return await Database.SqlQuery<Household>("UpdateTransactionById @Id, @HouseholdName, @Greeting",
               new SqlParameter("Id", Id),
               new SqlParameter("HouseholdName", HouseholdName),
               new SqlParameter("Greeting", Greeting)
               ).FirstOrDefaultAsync();
        }

        #endregion
        #region InsertNew
        public async Task<Household> InsertHouseholdData(string HouseholdName, string Greeting)
        {
            return await Database.SqlQuery<Household>("InsertHouseholdData @HouseholdName, @Greeting",
               new SqlParameter("HouseholdName", HouseholdName),
               new SqlParameter("Greeting", Greeting)
               ).FirstOrDefaultAsync();
        }
        public async Task<BankAccount> InsertBankData(int HouseholdId, string OwnerId, string AccountName, decimal StartingBalance, decimal WarningBalance, int AccountType)
        {
            return await Database.SqlQuery<BankAccount>("InsertBankData @HouseholdId, @OwnerId, @AccountName, @StartingBalance, @WarningBalance, @AccountType",
               new SqlParameter("HouseholdId", HouseholdId),
               new SqlParameter("OwnerId", OwnerId),
               new SqlParameter("AccountName", AccountName),
               new SqlParameter("StartingBalance", StartingBalance),
               new SqlParameter("WarningBalance", WarningBalance),
               new SqlParameter("AccountType", AccountType)
               ).FirstOrDefaultAsync();
        }
        public async Task<Budget> InsertBudgetData(int HouseholdId, string OwnerId, string BudgetName, decimal CurrentAmount)
        {
            return await Database.SqlQuery<Budget>("InsertBudgetData @HouseholdId, @OwnerId, @BudgetName, @CurrentAmount",
               new SqlParameter("HouseholdId", HouseholdId),
               new SqlParameter("OwnerId", OwnerId),
               new SqlParameter("BudgetName", BudgetName),
               new SqlParameter("CurrentAmount", CurrentAmount)
               ).FirstOrDefaultAsync();
        }
        public async Task<BudgetItem> InsertBudgetItemData(int BudgetId, string ItemName, decimal TargetAmount, decimal CurrentAmount)
        {
            return await Database.SqlQuery<BudgetItem>("InsertBudgetItemData @BudgetId, @ItemName, @TargetAmount, @CurrentAmount",
               new SqlParameter("BudgetId", BudgetId),
               new SqlParameter("ItemName", ItemName),
               new SqlParameter("TargetAmount", TargetAmount),
               new SqlParameter("CurrentAmount", CurrentAmount)
               ).FirstOrDefaultAsync();
        }
        public async Task<Transaction> InsertTransactionData(int BudgetItemId, string OwnerId, TransactionType TransactionType, decimal Amount, string Memo, bool IsDeleted, int AccountId)
        {
            return await Database.SqlQuery<Transaction>("InsertTransactionData @BudgetItemId, @OwnerId, @TransactionType, @Amount, @Memo, @IsDeleted, @AccountId",
               new SqlParameter("BudgetItemId", BudgetItemId),
               new SqlParameter("OwnerId", OwnerId),
               new SqlParameter("TransactionType", TransactionType),
               new SqlParameter("Amount", Amount),
               new SqlParameter("Memo", Memo),
               new SqlParameter("IsDeleted", IsDeleted),
               new SqlParameter("AccountId", AccountId)
               ).FirstOrDefaultAsync();
        }
        #endregion
    }
}