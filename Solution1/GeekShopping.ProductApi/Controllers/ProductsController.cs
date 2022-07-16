using GeekShopping.ProductApi.Data;
using GeekShopping.ProductApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductRepository _repository;

        public ProductsController(IProductRepository repository)
        {
            _repository = repository ?? throw new ArgumentException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductVO>>> FindAll()
        {
            return Ok(await _repository.FindAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductVO>> GetById(int id)
        {
            ProductVO product = await _repository.FindById(id);

            if(product == null) return NotFound();

            return Ok(product);
        } 

        [HttpPost]
        public async Task<ActionResult<ProductVO>> Create(ProductVO product)
        {
            if (product == null) return BadRequest();
            return Ok(await _repository.Create(product));
        }

        [HttpPut]
        public async Task<ActionResult<ProductVO>> Update(ProductVO product)
        {
            if (product == null) return BadRequest();
            return Ok(await _repository.Update(product));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            bool status = await _repository.Delete(id);
            if(!status) return BadRequest();

            return Ok(status);
        }
    }
}
