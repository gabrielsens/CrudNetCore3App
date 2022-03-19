namespace CrudNetCore3.Models
{
    public class Cliente
    {
        public Cliente()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
    }
}
