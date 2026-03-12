using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlocoDeNotas.Repository.Csvhelper;
public static class CsvHelper
{
    public static string[] BuscarUsuario(string email, string senha)
    {
        var usuario = File.ReadAllLines
            ("Data/Usuario.csv")
            .Skip(1)
            .Select( linha => linha.Split(','))
            .FirstOrDefault( colunas => colunas[2] == email && colunas[3] == senha);

        return usuario;
    }

    public static IEnumerable<string[]> BuscarNotasDoUsuario(Usuario usuario)
    {
        var notas = File.ReadAllLines
            ("Data/Nota.csv")
            .Skip(1)
            .Select( linha => linha.Split(','))
            .Where(coluna => int.Parse(coluna[1]) == usuario.Id);
        
        return notas;
    }

    public static int ContarNotas()
    {
        var quantidadeNotas = File.ReadAllLines("Data/Nota.csv")
            .Skip(1)
            .Count();

        return quantidadeNotas;
    }
}