using BlocoDeNotas.Models;
using BlocoDeNotas.Repository;

UsuarioRepository usuarioRepository = new UsuarioRepository();
NotaRepository notaRepository = new NotaRepository();

var usuario = usuarioRepository.ObterUsuario("amigoestouaqui@gmail.com", "123456789");
System.Console.WriteLine(usuario.ToString());

notaRepository.CriarNota(usuario, "Amigo", "Estou aqui");
var notas = notaRepository.ObterNotasDoUsuario(usuario);
System.Console.WriteLine();
foreach ( var nota in notas)
{
    System.Console.WriteLine(nota.ExibirNota());
}

