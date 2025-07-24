using Microsoft.AspNetCore.Mvc;

namespace ConnieLactationAesthetics.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicesController : ControllerBase
    {
        [HttpGet]
        public IActionResult ServicesGET()
        {
            var services = new[]
            {
                new { Id = 1, Name = "泌乳諮詢與護理", Description = "專業泌乳顧問協助媽媽順利哺乳。" },
                new { Id = 2, Name = "產後身體護理", Description = "產後媽媽專屬身體調理與放鬆。" },
                new { Id = 3, Name = "美學舒壓按摩", Description = "舒緩壓力，提升美感與健康。" }
            };
            return Ok(services);
        }
    }
} 