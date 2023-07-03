namespace OnlineBookstore.Repositories
{
	using OnlineBookstore.Data;
	using OnlineBookstore.Entities;
	using OnlineBookstore.Repository.Interfaces;
	using System;
	using System.Collections.Generic;

	public class AuthorRepository : IAuthorRepository
	{
		private readonly OnlineBookstoreDbContext _context;

		public AuthorRepository(OnlineBookstoreDbContext context)
		{
			_context = context;
		}

		public void Add(Author author)
		{
			throw new NotImplementedException();
		}

		public void Delete(Author author)
		{
			throw new NotImplementedException();
		}

		public void Edit(Author author)
		{
			throw new NotImplementedException();
		}

		public Author GetAuhtorByPopularity(bool popularity)
		{
			throw new NotImplementedException();
		}

		public Author GetAuthorById(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Author> GetAuthors()
		{
			var result = _context.Author.AsEnumerable();
			return result;
		}
		public IEnumerable<Author> GetAuhtorsByPopularity(bool popularity)
		{
			throw new NotImplementedException();
		}
	}
}
