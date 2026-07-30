namespace ProjetoCadastroMVC.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? Cargo { get; set; }
        public string? Departamento { get; set; }
        public double Salario { get; set; }
    }
}
