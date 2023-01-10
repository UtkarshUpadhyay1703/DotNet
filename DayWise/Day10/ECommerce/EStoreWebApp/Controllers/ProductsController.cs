using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreWebApp.Models;
using BOL;
using BLL;

namespace EStoreWebApp.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index(){
        CatalogManager manager=new CatalogManager();
        List<Product> allProducts=manager.GetAllproducts();
        this.ViewData["products"]=allProducts;
        return View();
    }
    public IActionResult Details(int id){
        CatalogManager manager =new  CatalogManager();
        Product product=manager.GetProductById(id);
        this.ViewData["product"]=product;
        return View();
    }
}