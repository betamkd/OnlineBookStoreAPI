namespace OnlineBookstore.Service.Interfaces
{
	using OnlineBookstore.Entities;
	using System.Collections.Generic;
	public interface IAuthorService
	{
		void Add(Author author);

		void Edit(Author author);

		void Delete(Author author);

		Author GetAuthorById(int id);

		Author GetAuhtorByPopularity(bool popularity);
		IEnumerable<Author> GetAuthors();

		IEnumerable<Author> GetAuhtorsByPopularity(bool popularity);
	}
}
