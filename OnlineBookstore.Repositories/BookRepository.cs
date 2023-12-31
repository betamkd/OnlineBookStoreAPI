﻿namespace OnlineBookstore.Repositories
{
	using OnlineBookstore.Data;
	using OnlineBookstore.Entities;
	using OnlineBookstore.Repository.Interfaces;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	public class BookRepository : IBookRepository
	{
		private readonly OnlineBookstoreDbContext _context;

		public BookRepository(OnlineBookstoreDbContext context)
		{
			_context = context;
		}

		public void Add(Book book)
		{
			throw new NotImplementedException();
		}

		public void Delete(Book book)
		{
			throw new NotImplementedException();
		}

		public void Edit(Book book)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Book> GetAllBooks()
		{
			var result = _context.Books.AsEnumerable();
			return result;
		}

		public IEnumerable<Book> GetAllBooksByAuthor(string authorName)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Book> GetAllBooksByCountry()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Book> GetAllBooksByDateAscending()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Book> GetAllBooksByDateDescending()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Book> GetAllBooksByPriceAscending()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Book> GetAllBooksByPriceDescending()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Book> GetAllBooksByPublisher(string publisherName)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Book> GetAllBooksByUser()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Book> GetAllBooksByUserId(string userId)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Book> GetAllBooksFromToDateByUserId(string userId, DateTime from, DateTime to)
		{
			throw new NotImplementedException();
		}

		public IQueryable<Book> GetAllBooksQueryable()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Book> GetAllBooksWithFullRelationalData()
		{
			throw new NotImplementedException();
		}

		public Book GetBookById(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Book> GetTop5PopularBooks()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Book> GetTopPopularBooksByBestSellingAuthor()
		{
			throw new NotImplementedException();
		}
	}
}
