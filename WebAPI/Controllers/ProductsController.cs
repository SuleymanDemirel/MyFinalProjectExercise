using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // Loosely coupled-Gevşek bağlılık(soyuta bağlılık)
        // IoC Container -- Inversion of Control
        //              Naming convention 
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll() 
        {
            
            var result = _productService.GetAll();
            if (result.Success)//default true ise
            {
                return Ok(result); // 200 
            }
            return BadRequest(result); // 400 
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id) 
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product) // client'dan,angular'dan,react'dan vs. gönderdiğin ürünü buraya koy.
        {
            var result = _productService.Add(product);
            if (result.Success)// işlem sonucu true ise
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
