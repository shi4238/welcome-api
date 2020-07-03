using Microsoft.AspNetCore.Mvc;
using System;
using welcome_api.Models;

namespace welcome_api.Controllers
{
    public class BaseApiController : ControllerBase
    {
        [HttpGet("metadata")]
        public MetadataResponse GetMetadata()
        {
            return new MetadataResponse {  Host = Environment.MachineName };
        }
    }
}
