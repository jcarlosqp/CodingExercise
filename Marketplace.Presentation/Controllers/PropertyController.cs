using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marketplace.Application.Services.Commands;
using Marketplace.Application.Services.Queries;
using Marketplace.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Marketplace.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyQuery propertyQuery;
        private readonly IPropertyCommand propertyCommand;

        public PropertyController(IPropertyQuery propertyQuery, IPropertyCommand propertyCommand)
        {
            this.propertyQuery = propertyQuery;
            this.propertyCommand = propertyCommand;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var properties = await this.propertyQuery.GetAsync();
            return Ok(properties);
        }

        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Property property)
        {
            await this.propertyCommand.AddPropertyAsync(property);
            return Ok();
        }

        
    }
}
