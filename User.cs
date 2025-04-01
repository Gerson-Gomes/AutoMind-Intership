namespace ConsoleAutoMind;

public class User(String nome, String email, int idade)
{
    string nome = nome;
    string email = email;
    int idade = idade;
    
    public string Nome { get => nome; set => nome = value; }
    public string Email { get => email; set => email = value; }
    public int Idade { get => idade; set => idade = value; }
    
}