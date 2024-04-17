using OOP_Uygulama1.Exceptions;
using OOP_Uygulama1.Models;
using OOP_Uygulama1.Repository;
using System.Collections.Generic;
using System;

namespace OOP_Uygulama1.Services;

public class BrandService
{
	private BrandRepository _brandRepository;

	public BrandService()
	{
		_brandRepository = new BrandRepository();
	}

	public void GetAll()
	{
		List<Brand> brands = _brandRepository.GetAll();
		brands.ForEach(b => Console.WriteLine(b));
	}

	public void Add(Brand brand)
	{
		_brandRepository.Add(brand);
		Console.WriteLine($"Brand eklendi: \n {brand}");
	}

	public void GetById(int id)
	{
		try
		{
			Brand brand = _brandRepository.GetById(id);
			Console.WriteLine(brand);
		}
		catch (NotFoundException ex)
		{
			Console.WriteLine("Verilen ID bulunamadý.");
			Console.WriteLine(ex.Message);
		}
	}

	public void Delete(int id)
	{
		try
		{
			_brandRepository.Delete(id);
		}
		catch (NotFoundException ex)
		{
			Console.WriteLine("Verilen ID bulunamadý.");
			Console.WriteLine(ex.Message);
		}
	}
}
