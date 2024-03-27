using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers
{
    [ApiController] //he controller as an API controller
    [Route("api/[controller]")]
    public class MPinVAlidation : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string mpnId)//handles GET requests to the specified route (/api/MPinVAlidation in this case). It takes a parameter mpnId from the query string.
        {
            // Mock data retrieval based on mpnId
            if (string.IsNullOrEmpty(mpnId))
            {
                return BadRequest("Mpin cannot be empty.");
            }
            if (mpnId.Length <= 8)
            {
                return BadRequest("Mpin length should be greater than 8 characters.");
            }
            if (!char.IsUpper(mpnId.FirstOrDefault()))
            {
                return BadRequest("First letter of the Mpin should be capital.");
            }

            if (!mpnId.All(char.IsLetterOrDigit))
            {
                return BadRequest("Mpin should contain only alphanumeric characters and no wildcard.");
            }
            return Ok("Mpin is valid.");//The response is a plain text response with the message "Mpin is valid." This is because the Ok method in ASP.NET Core's ControllerBase class is used to return an HTTP 200 OK response with a plain text content.

            //if (mpnId == "123456789")
            //{
            //    return Ok(new { isValidMpn = true });
            //}
            //else
            //{
            //    return Ok(new { isValidMpn = false });
            //}



            /*
             * 
             * 
             *  var response = new
            {
                message = "Mpin is valid."
            };

            return Ok(response);
             * 
             * 
             * */








        }
    }
}
