using System.Linq;
using System.Data.Entity;

namespace Dal
{
	//public class UserRepository : Repository<Models.User>, IUserRepository
	//{
	//	public UserRepository(Models.DatabaseContext databaseContext) : base(databaseContext)
	//	{
	//	}
	//}
























	public class UserRepository : Repository<Models.User>, IUserRepository
	{
		public UserRepository(Models.DatabaseContext databaseContext) : base(databaseContext)
		{
		}

		//public IQueryable<User> GetActiveUsers()
		//{
		//	throw new System.NotImplementedException();
		//}

		//public IQueryable<Models.User> GetActiveUsers()
		//{
		//	var users =
		//		Get()
		//		.Where(current => current.IsActive)
		//		;

		//	//var users =
		//	//	Get()
		//	//	.Where(current => current.IsActive)
		//	//	.Where(current => current.IsDeleted == false)
		//	//	;

		//	return users;
		//}

		public System.Collections.Generic.IList<Models.User> GetActiveUsers()
		{
			var users =
				Get()
				.Where(current => current.IsActive)
				.ToList()
				;

			//var users =
			//	Get()
			//	.Where(current => current.IsActive)
			//	.Where(current => current.IsDeleted == false)
			//	.ToList()
			//	;

			return users;
		}
	}
}
