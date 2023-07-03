namespace OnlineBookstore.Services
{
	using OnlineBookstore.Entities;
	using OnlineBookstore.Repository.Interfaces;
	using OnlineBookstore.Service.Interfaces;
	using System.Collections.Generic;
	public class AuthorService : IAuthorService
	{
		private readonly IAuthorRepository _authorRepository;

		public AuthorService(IAuthorRepository authorRepository)
		{
			_authorRepository = authorRepository;
		}

		public void Add(Author author)
		{
			_authorRepository.Add(author);
		}

		public void Delete(Author author)
		{
			_authorRepository.Delete(author);
		}

		public void Edit(Author author)
		{
			_authorRepository.Edit(author);
		}


		public Author GetAuthorById(int id)
		{
			// 1st option
			var result = _authorRepository.GetAuthorById(id);
			return result;

			// 2nd option FOR SENIORS
			//return _authorRepository.GetAuthorById(id);
		}

		public Author GetAuhtorByPopularity(bool popularity)
		{
			var result = _authorRepository.GetAuhtorByPopularity(popularity);
			return result;
		}
		public IEnumerable<Author> GetAuthors()
		{
			var result = _authorRepository.GetAuthors();
			return result;
		}
		public IEnumerable<Author> GetAuhtorsByPopularity(bool popularity)
		{
			var result = _authorRepository.GetAuhtorsByPopularity(popularity);
			return result;
		}
	}
}
