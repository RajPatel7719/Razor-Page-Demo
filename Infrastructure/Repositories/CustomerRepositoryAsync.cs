using Core.Entities;
using Core.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class CustomerRepositoryAsync : GenericRepositoryAsync<Customer>, ICustomerRepositoryAsync
    {
        private readonly DbSet<Customer> _customer;
        public CustomerRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _customer = dbContext.Set<Customer>();
        }
    }
}
