using System;

namespace ProjetoDTO
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Sexo { get; set; }
        public decimal LimeteCompra { get; set; }
    }
    
}