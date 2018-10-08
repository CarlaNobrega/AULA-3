using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fp_stack.web.ViewComponents
{
    public class NoticiasViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int total, bool noticiasUrgentes=false)
        {
            var view = noticiasUrgentes ? "noticiasUrgentes" : "noticias";
            var itens = GetItens(total);

            return View(view, itens);
        }

        private IEnumerable<Noticia> GetItens(int total)
        {
            for (int i = 0; i < total; i++)
            {
                yield return new Noticia() { Id = i + 1, Titulo = $"Noticia sobre {i}" };
            }
        }
    }
    public class Noticia
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Link { get; set; }
        public Autor Autor { get; set; }

    }
    public class Autor
    {
        public string Nome { get; set; }
    }
}
