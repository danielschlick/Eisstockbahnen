using EisstockbahnenDatabase;
using EisstockbahnenDatabase.Entities;
using EisstockbahnenWebModel;
using System.Collections.Generic;

namespace EisstockbahnenBusinessLogic
{
    public class AccountService
    {
        private readonly DatabaseContext context;

        public AccountService(DatabaseContext context)
        {
            this.context = context;
        }

        public void Add(string username, string password)
        {
            var account = new Account
            {
                Username = username,
                Password = password
            };

            context.Accounts.Add(account);
            context.SaveChanges();
        }

        public List<AccountModel> Get()
        {
            List<AccountModel> accounts = new List<AccountModel>();
            foreach (Account contextAccount in context.Accounts)
            {
                accounts.Add(new AccountModel
                {
                    Id = contextAccount.Id,
                    Username = contextAccount.Username,
                    Password = contextAccount.Password
                });
            }

            return accounts;
        }

        public bool Remove(int id)
        {
            Account account = context.Accounts.Find(id);

            if (account == null)
            {
                return false;
            }

            context.Accounts.Remove(account);
            context.SaveChanges();
            return true;
        }
    }
}
