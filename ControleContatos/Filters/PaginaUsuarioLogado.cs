using ControleContatos.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text.Json;

namespace ControleContatos.Filters
{
    public class PaginaUsuarioLogado : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            string sessaoUsuario = context.HttpContext.Session.GetString("UsuarioLogado");

            if (string.IsNullOrEmpty(sessaoUsuario))
            {
                context.Result = new Microsoft.AspNetCore.Mvc.RedirectToActionResult("Index", "Login", null);
            }
            else
            {
                UsuarioModel usuario = JsonSerializer.Deserialize<UsuarioModel>(sessaoUsuario);

                if (usuario == null)
                {
                    context.Result = new Microsoft.AspNetCore.Mvc.RedirectToActionResult("Index", "Login", null);
                }
            }
                base.OnActionExecuted(context);
        }
    }
}
