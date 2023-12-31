﻿namespace OnlineBookstore.Repositories
{
	using OnlineBookstore.Data;
	using OnlineBookstore.Entities;
	using OnlineBookstore.Repository.Interfaces;
	using System;
	using System.Collections.Generic;
	public class CategoryRepository : ICategoryRepository
	{
		private readonly OnlineBookstoreDbContext _context;

		public CategoryRepository(OnlineBookstoreDbContext context)
		{
			_context = context;
		}

		public void Add(Category category)
		{
			throw new NotImplementedException();
		}

		public void Delete(Category catergory)
		{
			throw new NotImplementedException();
		}

		public void Edit(Category catergory)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Category> GetAllCategories()
		{
			var result = _context.Categories.AsEnumerable();
			return result;
		}

		public Category GetCategoryById(int id)
		{
			throw new NotImplementedException();
		}

		public Category GetCategoryByName(string name)
		{
			throw new NotImplementedException();
		}
	}
}
