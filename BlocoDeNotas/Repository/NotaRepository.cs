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
}