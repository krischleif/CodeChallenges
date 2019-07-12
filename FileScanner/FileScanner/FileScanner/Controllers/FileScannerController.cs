using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileScanner.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FileScanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IFileScannerService service;

        public ValuesController(IFileScannerService service)
        {
            this.service = service;
        }
        // POST
        [HttpPost("GetNumberOfFiles")]
        public ActionResult<int> GetNumberOfFiles(string directory)
        {
            return service.GetNumberOfFiles(directory);
        }

        // POST
        [HttpPost("GetNumberOfDirectories")]
        public ActionResult<int> GetNumberOfDirectories(string directory)
        {
            return service.GetNumberOfDirectories(directory);
        }

        // POST
        [HttpPost("GetFileSizeTotal")]
        public ActionResult<long> GetFileSizeTotal(string directory)
        {
            return service.GetFileSizeTotal(directory);
        }

        // POST
        [HttpPost("GetAverageFileSize")]
        public ActionResult<int> GetAverageFileSize(string directory)
        {
            return service.GetAverageFileSize(directory);
        }
    }
}
