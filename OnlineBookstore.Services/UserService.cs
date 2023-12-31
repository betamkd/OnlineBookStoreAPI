﻿namespace OnlineBookstore.Services
{
	using OnlineBookstore.Entities;
	using OnlineBookstore.Repository.Interfaces;
	using OnlineBookstore.Service.Interfaces;
	using System.Collections.Generic;
	public class UserService : IUserService
	{
		private readonly IUserRepository _userRepository;

		public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		public void Add(User user)
		{
			_userRepository.Add(user);
		}

		public void Delete(User user)
		{
			_userRepository.Delete(user);
		}

		public void Edit(User user)
		{
			_userRepository.Edit(user);
		}

		public IEnumerable<User> GetAllUser()
		{
			var result = _userRepository.GetAllUser();
			return result;
		}

		public User GetUserById(int id)
		{
			var result = _userRepository.GetUserById(id);
			return result;
		}

		public User GetUserByUserName(string userName)
		{
			var result = _userRepository.GetUserByUserName(userName);
			return result;
		}

		public IEnumerable<User> GetUsersByCity(string city)
		{
			var result = _userRepository.GetUsersByCity(city);
			return result;
		}

		public IEnumerable<User> GetUsersByCountry(string country)
		{
			var result = _userRepository.GetUsersByCountry(country);
			return result;
		}

		public IEnumerable<User> GetUsersByEmail(string email)
		{
			var result = _userRepository.GetUsersByEmail(email);
			return result;
		}
	}
}
