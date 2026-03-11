using BlocoDeNotas.Models;
using BlocoDeNotas.Repository;

UsuarioRepository usuarioRepository = new UsuarioRepository();
NotaRepository notaRepository = new NotaRepository();

var usuario = usuarioRepository.ObterUsuario("djefferson141005@gmail.com", "123456789");
System.Console.WriteLine(usuario.ToString());


var notas = notaRepository.ObterNotasDoUsuario(usuario);
System.Console.WriteLine();
foreach ( var nota in notas)
{
    System.Console.WriteLine(nota.ExibirNota());
}
