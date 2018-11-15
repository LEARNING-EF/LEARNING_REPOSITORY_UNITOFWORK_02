namespace Dal
{
	//public interface IUserRepository : IRepository<Models.User>
	//{
	//}






























	//public interface IUserRepository : IRepository<Models.User>
	//{
	//	System.Linq.IQueryable<Models.User> GetActiveUsers();
	//}































	public interface IUserRepository : IRepository<Models.User>
	{
		System.Collections.Generic.IList<Models.User> GetActiveUsers();
	}
}
