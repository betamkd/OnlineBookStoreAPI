﻿namespace OnlineBookstore.Service.Interfaces
{
	using OnlineBookstore.Entities;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	public interface IBookService
	{
		void Add(Book book);

		void Edit(Book book);

		void Delete(Book book);

		Book GetBookById(int id);

		IQueryable<Book> GetAllBooksQueryable();

		IEnumerable<Book> GetAllBooks();

		IEnumerable<Book> GetAllBooksByUser();
		IEnumerable<Book> GetAllBooksByUserId(string userId);
		IEnumerable<Book> GetAllBooksByDateDescending();
		IEnumerable<Book> GetAllBooksByDateAscending();
		IEnumerable<Book> GetAllBooksFromToDateByUserId(string userId, DateTime from, DateTime to);
		IEnumerable<Book> GetAllBooksByPriceAscending();
		IEnumerable<Book> GetAllBooksByPriceDescending();
		IEnumerable<Book> GetAllBooksByCountry();
		IEnumerable<Book> GetAllBooksByAuthor(string authorName);
		IEnumerable<Book> GetAllBooksByPublisher(string publisherName);
		IEnumerable<Book> GetTop5PopularBooks();
		IEnumerable<Book> GetTopPopularBooksByBestSellingAuthor();

		// IMPORTANT!!!
		IEnumerable<Book> GetAllBooksWithFullRelationalData();

	}
}
