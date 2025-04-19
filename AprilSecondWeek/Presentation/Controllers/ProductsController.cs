using Microsoft.AspNetCore.Mvc;
using Presentation.Models;
using Presentation.Repositories;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository _repository;

        public ProductController(ProductRepository repository)
        {
            _repository = repository;
        }

     
        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _repository.GetAll();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _repository.GetById(id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Product product)
        {
            _repository.Add(product);
            return Ok("Ürün başarıyla eklendi.");
        }

     
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Product product)
        {
            var existing = _repository.GetById(id);
            if (existing == null)
                return NotFound("Ürün bulunamadı.");

            _repository.Update(id, product);
            return Ok("Ürün güncellendi.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing = _repository.GetById(id);
            if (existing == null)
                return NotFound("Ürün bulunamadı.");

            _repository.Delete(id);
            return Ok("Ürün silindi.");
        }
    }
}
