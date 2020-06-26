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
        //public Usuario _Usuario { get; set; }
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
        public void OnPostNome(string nome)
        {
            Nome = nome;
        }

        public void OnPostSobrenome(Usuario u)
        {
            Sobrenome = u.Sobrenome;
        }
    }

    public class Usuario {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }
}
