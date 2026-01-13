using ControleContatos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ControleContatos.ViewComponents
{
    public class Menu : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string sessaoUsuario = HttpContext.Session.GetString("UsuarioLogado");
            if (string.IsNullOrEmpty(sessaoUsuario))
            {
                return Content("");
            }
            UsuarioModel usuario = JsonSerializer.Deserialize<UsuarioModel>(sessaoUsuario);
            return View(usuario);
        }
    }
}
