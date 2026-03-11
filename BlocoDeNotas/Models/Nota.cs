using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlocoDeNotas.Models;

public class Nota
{
    public Nota(int id, int idUsuario, string titulo, string texto)
    {
        Id = id;
        IdUsuario = idUsuario;
        Titulo = titulo;
        Texto = texto;
    }
    public int Id { get; set; }
    public int IdUsuario { get; set; }
    public string Titulo { get; set; }
    public string Texto { get; set; }

    public string ExibirNota()
    {
        return 
        @$"========================================================================
    {Titulo.ToUpper()}

    {Texto}";
    }
}
