namespace OnlineBookstore.Services
{
	using OnlineBookstore.Entities;
	using OnlineBookstore.Repository.Interfaces;
	using OnlineBookstore.Service.Interfaces;
	using System;
	using System.Collections.Generic;
	public class PhotoService : IPhotoService
	{
		private readonly IPhotoRepository _photoRepository;

		public PhotoService(IPhotoRepository photoRepository)
		{
			_photoRepository = photoRepository;
		}

		//private readonly IPhotoRepository photoRepository;
		//private readonly IUserRepository userRepository;

		//public PhotoService(IPhotoRepository photoRepository, IUserRepository userRepository)
		//{
		//	this.photoRepository = photoRepository;
		//	this.userRepository = userRepository;
		//}

		public void Add(Photo photo)
		{
			_photoRepository.Add(photo);	
		}

		public void Delete(Photo photo)
		{
			_photoRepository.Delete(photo);
		}

		public void Edit(Photo photo)
		{
			_photoRepository.Edit(photo);
		}

		public IEnumerable<Photo> GetAllMainPhotos(bool isMain)
		{
			var result = _photoRepository.GetAllMainPhotos(isMain);
			return result;
		}

		public IEnumerable<Photo> GetAllPhotos()
		{
			var results = _photoRepository.GetAllPhotos();
			return results;
		}
		public Photo GetPhotoById(int id)
		{
			var results = _photoRepository.GetPhotoById(id);
			return results;
		}
		public IEnumerable<Photo> GetAllPhotosByDate(DateTime dateTime)
		{
			var results = _photoRepository.GetAllPhotosByDate(dateTime);
			return results;
		}


	}
}
