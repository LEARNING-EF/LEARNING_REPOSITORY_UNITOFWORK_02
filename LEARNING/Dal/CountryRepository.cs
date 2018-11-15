using System.Linq;

namespace Dal
{
	public class CountryRepository : Repository<Models.Country>, ICountryRepository
	{
		public CountryRepository(Models.DatabaseContext databaseContext) : base(databaseContext)
		{
		}
	}
}
