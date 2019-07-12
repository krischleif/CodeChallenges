using InputAnalysis.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InputAnalysis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InputAnalysisController : ControllerBase
    {
        private readonly IInputAnalysisService inputAnalysisService;

        public InputAnalysisController(IInputAnalysisService inputAnalysisService)
        {
            this.inputAnalysisService = inputAnalysisService;
        }


        // GET
        [HttpGet("GetSumOfAllNumbers")]
        public ActionResult<double> GetSumOfAllNumbers()
        {
            return Ok(inputAnalysisService.GetSumOfAllNumbers());
        }

        // GET
        [HttpGet("GetCountOfAllNumbers")]
        public ActionResult<int> GetCountOfAllNumbers()
        {
            return Ok(inputAnalysisService.GetCountOfAllNumbers());
        }

        // POST
        // Param: contains
        [HttpPost("ContainsString")]
        public ActionResult<bool> ContainsString(string contains)
        {
            if (string.IsNullOrEmpty(contains))
            {
                return BadRequest();
            }

            return Ok(inputAnalysisService.ContainsString(contains));
        }

        // POST
        // Param: contains
        [HttpPost("ContainsSubString")]
        public ActionResult<bool> ContainsSubString(string contains)
        {
            if (string.IsNullOrEmpty(contains))
            {
                return BadRequest();
            }

            return Ok(inputAnalysisService.ContainsSubString(contains));
        }

        // GET
        [HttpGet("GetFullProcessedData")]
        public ActionResult<(List<double> intList, List<string> stringList)> GetFullProcessedData()
        {
            return Ok(inputAnalysisService.GetFullProcessedData());
        }
    }
}
