using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConta
{
    public class Conta
    {
        public decimal total;
        public int quantidadePessoas;
        public decimal totalPorPessoa;

        public void Despesa(int qtdPessoa, decimal valorUnitario, int quantidade)
        {
            total += (valorUnitario * quantidade);
        }
    }
}
