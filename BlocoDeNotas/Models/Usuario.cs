public class Usuario
{
    public Usuario(int id, string nome, string email, string senha)
    {
        Id = id;
        Nome = nome;
        Email = email;
        _senha = senha;
    }
    public string _senha;
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }

    public override string ToString()
    {
        return $"Id: {Id} | Nome: {Nome} | E-mail: {Email}";
    }
}