using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteMobills.Models
{
    public class Receita
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public bool Recebido { get; set; }
    }
}
