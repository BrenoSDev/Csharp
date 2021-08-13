using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetApplication.Pages
{
    //Cada arquivo .cshtml tem um arquivo de código associado. Para abrir o arquivo de código no editor, expanda
    //o nó index.cshtml em Gerenciador de Soluções e escolha o arquivo index.cshtml.cs
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
    }
}
