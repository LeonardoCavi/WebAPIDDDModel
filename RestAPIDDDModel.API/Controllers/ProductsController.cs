using Microsoft.AspNetCore.Mvc;
using RestAPIDDDModel.Application.DTOs;
using RestAPIDDDModel.Application.Interfaces;

namespace RestAPIDDDModel.API.Controllers
{
    [Route("api/products/")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IApplicationServiceProduct applicationServiceProduct;

        public ProductsController(IApplicationServiceProduct applicationServiceProduct)
        {
            this.applicationServiceProduct = applicationServiceProduct;
        }

        [Route("getall")]
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAll()
        {
            try
            {
                var products = applicationServiceProduct.GetAll();

                if (products != null)
                {
                    return Ok(products);
                }
                else
                {
                    return NotFound("No registration data found.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error message.: " + ex.Message);
            }
        }

        [Route("getbyid/{id}")]
        [HttpGet]
        public ActionResult<string> GetById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest("Invalid ID, please try again!");
                }
                else
                {
                    var product = applicationServiceProduct.GetById(id);

                    if (product != null)
                    {
                        return Ok(product);
                    }
                    else
                    {
                        return NotFound("No registration data found.");
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error message.:" + ex.Message);
            }
        }

        [Route("addproduct")]
        [HttpPost]
        public ActionResult AddProduct([FromBody] DTOProduct dtoProduct)
        {
            try
            {
                if (dtoProduct == null)
                {
                    return BadRequest("Incorrect product data.");
                }

                applicationServiceProduct.Add(dtoProduct);
                return Ok("Product registered successfully!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error message.:" + ex.Message);
            }
        }

        [Route("updateproduct")]
        [HttpPut]
        public ActionResult UpdateProduct([FromBody] DTOProduct dtoProduct)
        {
            try
            {
                if (dtoProduct == null)
                {
                    return BadRequest("Incorrect product data.");
                }
                if (dtoProduct.Id <= 0)
                {
                    return BadRequest("Invalid ID, please try again!");
                }

                applicationServiceProduct.Update(dtoProduct);
                return Ok("Successfully changed data!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error message.:" + ex.Message);
            }
        }

        [Route("removeproduct")]
        [HttpDelete]
        public ActionResult RemoveProduct([FromBody] DTOProduct dtoProduct)
        {
            try
            {
                if (dtoProduct == null)
                {
                    return BadRequest("Incorrect product data.");
                }
                if (dtoProduct.Id <= 0)
                {
                    return BadRequest("Invalid ID, please try again!");
                }

                applicationServiceProduct.Remove(dtoProduct);
                return Ok("Successfully removed data!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error message.:" + ex.Message);
            }
        }
    }
}