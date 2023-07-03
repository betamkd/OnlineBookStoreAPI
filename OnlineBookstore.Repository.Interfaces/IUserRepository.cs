namespace OnlineBookstore.Repository.Interfaces
{
	using OnlineBookstore.Entities;
	using System.Collections.Generic;
	public interface IUserRepository
	{
		void Add(User user);
		void Edit(User user);
		void Delete(User user);

		User GetUserById(int id);

		User GetUserByUserName(string userName);

		IEnumerable<User> GetUsersByCountry(string country);

		IEnumerable<User> GetUsersByCity(string city);

		IEnumerable<User> GetUsersByEmail(string email);
		IEnumerable<User> GetAllUser();
	}
}
