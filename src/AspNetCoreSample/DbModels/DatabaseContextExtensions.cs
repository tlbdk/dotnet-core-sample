using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreSample.DbModels
{
    public static class DatabaseContextExtensions 
    {
        public static Task EnsureSeedData(this DatabaseContext context)
        {
            return Task.FromResult<object>(null);
        }
    }
}