using ControleContatos.Models;

namespace ControleContatos.Helper
{
    public interface ISessao
    {
        void CriarSessaoUsuario(UsuarioModel usuarioNome);
        void RemoverSessaoUsuario();
        UsuarioModel BuscarSessaoUsuario();
    }
}
