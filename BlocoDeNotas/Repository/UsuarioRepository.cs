using BlocoDeNotas.Repository;
using BlocoDeNotas.Repository.Csvhelper;
using Microsoft.VisualBasic;

namespace BlocoDeNotas.Repository;

public class UsuarioRepository
{
    public Usuario ChamarUsuario(string email, string senha)
    {
        var dadosUsuario = CsvHelper.VarrerUsuario(email, senha);

        Usuario usuario = new Usuario(
            int.Parse(dadosUsuario[0]),
            dadosUsuario[1],
            dadosUsuario[2],
            dadosUsuario[3]
        );

        return usuario;
    }
}