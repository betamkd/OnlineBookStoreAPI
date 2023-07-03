namespace OnlineBookstore.Service.Interfaces
{
	using OnlineBookstore.Entities;
	using System;
	using System.Collections.Generic;
	public interface IPhotoService
	{
		void Add(Photo photo);
		void Edit(Photo photo);
		void Delete(Photo photo);

		Photo GetPhotoById(int id);

		IEnumerable<Photo> GetAllPhotos();

		IEnumerable<Photo> GetAllPhotosByDate(DateTime dateTime);

		IEnumerable<Photo> GetAllMainPhotos(bool isMain);
	}
}
