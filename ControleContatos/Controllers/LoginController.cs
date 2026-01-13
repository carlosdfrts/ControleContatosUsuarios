using ControleContatos.Helper;
using ControleContatos.Models;
using ControleContatos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ControleContatos.Controllers
{
    public class LoginController : Controller
    {

        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly ISessao _sessao;

        public LoginController(IUsuarioRepositorio usuarioRepositorio, ISessao sessao)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _sessao = sessao;
        }

        public IActionResult Index()
        {
            // Se o usuário já estiver logado, redireciona para a home
            if (_sessao.BuscarSessaoUsuario() != null) return RedirectToAction("Index", "Home");
            return View();
        }

        public IActionResult Sair()
        {
            _sessao.RemoverSessaoUsuario();
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UsuarioModel usuario = _usuarioRepositorio.BuscarPorLogin(loginModel.Login);

                    if (usuario != null)
                    {
                        if (usuario.SenhaValida(loginModel.Senha))
                        {
                            _sessao.CriarSessaoUsuario(usuario);
                            return RedirectToAction("Index", "Home");
                        }

                        TempData["MensagemErro"] = $"Senha inválida.";
                    }

                    TempData["MensagemErro"] = $"Usuário ou Senha inválido.";
                }

                return View("Index");
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possível realizar o Login, Tente novamente mais tarde. Erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
