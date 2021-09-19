using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Iskol.Adviser.Api.WebApi.Controllers
{
    public class MetaController : BaseApiController
    {
        private readonly IConfiguration _configuration;
        public MetaController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet("/info")]
        public ActionResult<object> Info()
        {
            var assembly = typeof(Startup).Assembly;

            var lastUpdate = System.IO.File.GetLastWriteTime(assembly.Location);
            var version = FileVersionInfo.GetVersionInfo(assembly.Location).ProductVersion;
            var organizationName = _configuration.GetSection("AppSettings").GetSection("OrganizationName").Value;
            //return Ok($"Version: {version}, Last Updated: {lastUpdate}, Organization: {organizationName}");
            return Ok(new { Version = version, LastUpdated = lastUpdate, Organization = organizationName });
        }
    }
}
