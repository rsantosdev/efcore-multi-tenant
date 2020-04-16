using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.MultiTenant.Data;

namespace WebApi.MultiTenant.Controllers
{
    public class ContactsController : ControllerBase
    {
        [HttpGet("/{clientName}/contacts")]
        public async Task<IActionResult> GetContacts(
            [FromRoute]string clientName,
            [FromServices]CustomerDataContext context)
        {
            var contacts = await context.Contacts.ToListAsync();
            return Ok(contacts);
        }
    }
}
