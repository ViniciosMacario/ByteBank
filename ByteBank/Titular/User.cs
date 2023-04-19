//Pelo princípio da responsabilidade, uma classe deve tratar especificamente de um tema somente, ter uma responsabilidade única.
namespace ByteBank.Titular
{
    public class User
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }
    }
}
