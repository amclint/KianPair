using FirstExample.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstExample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly KianPairContext _dbContext;

        public IndexModel(ILogger<IndexModel> logger, KianPairContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public void OnGet()
        {
            var users = _dbContext.Users.ToList();

            foreach (var u in users)
            {
                if (u.FirstName == "Aaron")
                {                    
                    Console.WriteLine($"Yes! Aaron is Role {u.Role.RoleName}");
                    Console.WriteLine("...");
                }
            }
        }
    }
}
