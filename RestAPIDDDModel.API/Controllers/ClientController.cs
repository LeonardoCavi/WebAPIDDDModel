using Microsoft.AspNetCore.Mvc;
using RestAPIDDDModel.Application.DTOs;
using RestAPIDDDModel.Application.Interfaces;

namespace RestAPIDDDModel.API.Controllers
{
    [Route("api/client/")]
    [ApiController]
    public class ClientController : Controller
    {
        private readonly IApplicationServiceClient applicationServiceClient;

        public ClientController(IApplicationServiceClient applicationServiceClient)
        {
            this.applicationServiceClient = applicationServiceClient;
        }

        [Route("getall")]
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAll()
        {
            try
            {
                var clients = applicationServiceClient.GetAll();

                if (clients != null)
                {
                    return Ok(clients);
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
                    var client = applicationServiceClient.GetById(id);

                    if (client != null)
                    {
                        return Ok(client);
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

        [Route("addclient")]
        [HttpPost]
        public ActionResult AddClient([FromBody] DTOClient dtoClient)
        {
            try
            {
                if (dtoClient == null)
                {
                    return BadRequest("Incorrect client data.");
                }

                applicationServiceClient.Add(dtoClient);
                return Ok("Client registered successfully!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error message.:" + ex.Message);
            }
        }

        [Route("updateclient")]
        [HttpPut]
        public ActionResult UpdateClient([FromBody] DTOClient dtoClient)
        {
            try
            {
                if (dtoClient == null)
                {
                    return BadRequest("Incorrect client data.");
                }
                if (dtoClient.Id <= 0)
                {
                    return BadRequest("Invalid ID, please try again!");
                }

                applicationServiceClient.Update(dtoClient);
                return Ok("Successfully changed data!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error message.:" + ex.Message);
            }
        }

        [Route("removeclient")]
        [HttpDelete]
        public ActionResult RemoveClient([FromBody] DTOClient dtoClient)
        {
            try
            {
                if (dtoClient == null)
                {
                    return BadRequest("Incorrect client data.");
                }
                if (dtoClient.Id <= 0)
                {
                    return BadRequest("Invalid ID, please try again!");
                }

                applicationServiceClient.Remove(dtoClient);
                return Ok("Successfully removed data!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error message.:" + ex.Message);
            }
        }
    }
}