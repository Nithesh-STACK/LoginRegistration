using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginRegistration.KaniniModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoginRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegController : Controller
    {
        public static stationaryContext db = new stationaryContext();

        [HttpGet]
        public async Task<IActionResult> GetAllLoginDet()
        {
            return Ok(await db.Logintabls.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddRegis(Logintabl b)
        {
            db.Logintabls.Add(b);
            await db.SaveChangesAsync();
            return Ok();

        }

    }
}
