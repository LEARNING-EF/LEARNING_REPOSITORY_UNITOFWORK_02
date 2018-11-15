namespace Dal
{
	public interface IUnitOfWork : System.IDisposable
	{
		// **********
		IUserRepository UserRepository { get; }
		// **********

		// **********
		ICountryRepository CountryRepository { get; }
		// **********

		void Save();
	}
}
