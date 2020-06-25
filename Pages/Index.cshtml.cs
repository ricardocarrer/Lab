using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Lab.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public void OnPostNome()
        {
            Nome = Request.Form["nome"].ToString();
        }

        public void OnPostSobrenome()
        {
            Sobrenome = Request.Form["nome"].ToString();
        }
    }
}
