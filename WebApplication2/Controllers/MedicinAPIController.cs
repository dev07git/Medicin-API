using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class MedicinAPIController : Controller
    {
        private readonly IMedicinService _medicinService;
        public MedicinAPIController(IMedicinService medicinService)
        {
          
            this._medicinService = medicinService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            IList<Medicin> returnModel = new List<Medicin>();
            returnModel = await _medicinService.GetMedicinsAsync();
            return Ok(returnModel);
        }
    }
}
