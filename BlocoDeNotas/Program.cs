using BlocoDeNotas.Models;
using BlocoDeNotas.Repository;

UsuarioRepository usuarioRepository = new UsuarioRepository();
NotaRepository notaRepository = new NotaRepository();

var usuario = usuarioRepository.ChamarUsuario("djefferson141005@gmail.com", "123456789");
System.Console.WriteLine(usuario.ToString());


var notas = notaRepository.ChamarNotas(usuario);
System.Console.WriteLine();
foreach ( var nota in notas)
{
    System.Console.WriteLine(nota.ExibirNota());
}
