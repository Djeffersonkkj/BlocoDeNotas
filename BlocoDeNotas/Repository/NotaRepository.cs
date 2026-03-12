using BlocoDeNotas.Models;
using BlocoDeNotas.Repository.Csvhelper;

public class NotaRepository
{
    public IEnumerable<Nota> ObterNotasDoUsuario(Usuario usuario)
    {
        var notasDados = CsvHelper.BuscarNotasDoUsuario(usuario);
        List<Nota> notas = new List<Nota>{};

        foreach (var linha in notasDados)
        {
            var nota = new Nota(
                int.Parse(linha[0]),
                int.Parse(linha[1]),
                linha[2],
                linha[3]
            );

            notas.Add(nota);
        }
        
        return notas;
    }

    public void CriarNota(Usuario usuario, string titulo, string texto)
    {
        var quantidadeNotas = CsvHelper.ContarNotas();

        string novaNota = 
$@"
{quantidadeNotas + 1},{usuario.Id},{titulo},{texto}";

        File.AppendAllText("Data/Nota.csv", novaNota);
    }
}