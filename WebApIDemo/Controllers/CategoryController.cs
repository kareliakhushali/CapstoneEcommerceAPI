using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApIDemo.Models;

namespace WebApIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class CategoryController : Controller
    {
        
        
            private ICategory _categoryRepository;
            private IWebHostEnvironment _hostingEnvironment;
            public CategoryController(ICategory categoryRepository, IWebHostEnvironment hostEnvironment)
            {
                _categoryRepository = categoryRepository;
                _hostingEnvironment = hostEnvironment;
            }
            [HttpGet]
            public IEnumerable<Category> GetCategory()
            {
                return _categoryRepository.GetAllCategory();
            }

            [HttpGet("{id}")]
            public Category GetCategoryById(int id)
            {
                return _categoryRepository.GetCategoryById(id);
            }

            [HttpPut]
        [Route("editCategory")]
        public bool UpdateCategory([FromBody] Category category)
            {
                if (ModelState.IsValid)
                {
                    if (_categoryRepository.CheckUpdateUnique
                        (category.CatName, category.Id))
                    {
                        return _categoryRepository.UpdateCategory(category);
                    }
                }
                return false;
            }
            [HttpPost]
            [Route("createcategory")]
            public bool AddCategory([FromForm] Category category)
            {
            

                return _categoryRepository.AddCategory(category);

            }
            [HttpDelete]
            [Route("deletecategory")]
            public bool DeleteCategoryById(int id)
            {
                return _categoryRepository.Delete(id);
            }
        }
    }

