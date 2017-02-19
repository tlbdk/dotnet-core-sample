using System.Linq;
using System.Threading.Tasks;
using AspNetCoreSample.DbModels;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Xunit;
using Xunit.Abstractions;

namespace AspNetCoreSample.Tests
{
    public class UserTests
    {
        private readonly ITestOutputHelper output;

        private DbContextOptions<DatabaseContext> _options;

        public UserTests(ITestOutputHelper output)
        {
            this.output = output;
            var builder = new DbContextOptionsBuilder<DatabaseContext>();
            builder.UseInMemoryDatabase();
            _options = builder.Options;
        }

        [Fact]
        public async Task CreateUser() {
            output.WriteLine("Create new user");
            using(var db = new DatabaseContext(_options)) {
                db.Users.Add(new User() {
                    FirstName = "Test",
                    LastName = "Testsen",
                    Email = "test@testsen.com"
                });
                await db.SaveChangesAsync();
            }
            output.WriteLine("Add IdCard to user");
            using(var db = new DatabaseContext(_options)) {
                var userId = await db.Users.Where(u => u.Email == "test@testsen.com").Select(u => u.Id).SingleOrDefaultAsync();
                db.IdCards.Add(new IdCard { 
                    Ssn = "123456781234",
                    UserId = userId
                });
                await db.SaveChangesAsync();
            }

            output.WriteLine("Try to find user again");
            using(var db = new DatabaseContext(_options)) {
                var user = await db.Users.Where(u => u.Email == "test@testsen.com")
                    .Include(u => u.IdCards)
                    .SingleOrDefaultAsync();

                Assert.Equal("Test", user.FirstName);
                Assert.Equal("123456781234", user.IdCards[0].Ssn);
            }
        }
    }
}