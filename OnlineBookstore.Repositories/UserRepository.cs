namespace OnlineBookstore.Repositories
{
	using OnlineBookstore.Data;
	using OnlineBookstore.Entities;
	using OnlineBookstore.Repository.Interfaces;
	using System;
	using System.Collections.Generic;

	public class UserRepository : IUserRepository
	{
		private readonly OnlineBookstoreDbContext _context;

		public UserRepository(OnlineBookstoreDbContext context)
		{
			_context = context;
		}

		public void Add(User user)
		{
			throw new NotImplementedException();
		}

		public void Delete(User user)
		{
			throw new NotImplementedException();
		}
	
		public void Edit(User user)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<User> GetAllUser()
		{
			var result = _context.Users.AsEnumerable();
			return result;
		}

		public User GetUserById(int id)
		{
			throw new NotImplementedException();
		}

		public User GetUserByUserName(string userName)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<User> GetUsersByCity(string city)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<User> GetUsersByCountry(string country)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<User> GetUsersByEmail(string email)
		{
			throw new NotImplementedException();
		}
	}
}
