using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Repositories;
using Microsoft.AspNetCore.Mvc;
using eShop.ViewModels;
namespace eShop.Controllers
{
public class ProductController : Controller
{
private readonly IProductRepository _productRepository;
private readonly ICategoryRepository _categoryRepository;
public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
{
    _productRepository = productRepository;
    _categoryRepository = categoryRepository;
}
public IActionResult List()
{
    //return View(_productRepository.GetAllProduct);
    var productListViewModel = new ProductListViewModel();
    productListViewModel.Products = _productRepository.GetAllProduct;
    productListViewModel.CurrentCategory = "BestSellers";
    return View(productListViewModel);
}
}
}