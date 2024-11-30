using Backend.DTOs;
using Backend.Models.Scaffold;
using Backend.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController: ControllerBase
    {
        private readonly ProductRepository _productRepository;
        public ProductsController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        
            
        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Product> products= (await _productRepository.GetAllAsync()).ToList();

            return Ok(products);
        }
        
        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Product? product = await _productRepository.GetByIdAsync(id);
            if (product is null)
                return BadRequest("Product does not exists");
            return Ok(product);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductCreateDTO request)
        {
            Product product = new Product
            {
                Name = request.Name,
                Price = request.Price,
                Description = request.Description,
                Guid = Guid.NewGuid().ToString(),
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                CreatedBy = 0,
                UpdateBy = 0,
                Status = 1
            };

            await _productRepository.AddAsync(product);
            return Ok("Product Created");

        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ProductCreateDTO request)
        {
            Product? product = await _productRepository.GetByIdAsync(id);
            if (product is null)
                return BadRequest("Product does not exists");

            product.Name = request.Name;
            product.Price = request.Price;
            product.Description = request.Description;
            product.UpdatedDate = DateTime.Now;
            product.UpdateBy = 0;

            await _productRepository.UpdateAsync(product);

            return Ok("Product Updated");
        }
        
        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Product? product = await _productRepository.GetByIdAsync(id);
            if (product is null)
                return BadRequest("Product does not exists");

            await _productRepository.DeleteAsync(id);
            return Ok("Product Deleted");
        }
        
    }
}
