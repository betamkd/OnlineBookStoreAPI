﻿namespace OnlineBookstore.Repository.Interfaces
{
	using OnlineBookstore.Entities;
	using System.Collections.Generic;
	public interface ICategoryRepository
	{
		void Add(Category category);
		void Edit(Category catergory);
		void Delete(Category catergory);

		Category GetCategoryById(int id);

		Category GetCategoryByName(string name);

		IEnumerable<Category> GetAllCategories();
	}
}
