namespace OnlineBookstore.Repositories
{
	using OnlineBookstore.Data;
	using OnlineBookstore.Entities;
	using OnlineBookstore.Repository.Interfaces;
	using System;
	using System.Collections.Generic;
	public class PhotoRepository : IPhotoRepository
	{
		private readonly OnlineBookstoreDbContext _context;

		public PhotoRepository(OnlineBookstoreDbContext context)
		{
			_context = context;
		}

		public void Add(Photo photo)
		{
			throw new NotImplementedException();
		}

		public void Delete(Photo photo)
		{
			throw new NotImplementedException();
		}

		public void Edit(Photo photo)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Photo> GetAllMainPhotos(bool isMain)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Photo> GetAllPhotos()
		{
			var result = _context.Photos.AsEnumerable();
			return result;
		}

		public IEnumerable<Photo> GetAllPhotosByDate(DateTime dateTime)
		{
			throw new NotImplementedException();
		}

		public Photo GetPhotoById(int id)
		{
			throw new NotImplementedException();
		}
	}
}
