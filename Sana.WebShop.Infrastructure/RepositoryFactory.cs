using System;
using Sana.WebShop.Infrastructure.InMemory;
using Sana.WebShop.Infrastructure.Sql;
using Sana.WebShop.Model.Contracts;

namespace Sana.WebShop.Infrastructure
{
    public class RepositoryFactory
    {
        public static IRepository GetRepository(String repositoryName)
        {
            switch (repositoryName)
            {
                case "SQL":
                    return new SqlRepository();
                default:
                    return InMemoryRepository.DefaultInstance;
            }
        }
    }
}
