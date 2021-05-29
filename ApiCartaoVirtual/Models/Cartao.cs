using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCartaoVirtual.Models
{
    public class Cartao
    {

        public int Id { get; set; }
        public string Email { get; set; }
        public int NumCartao { get; set; }

        public Cartao()
        {
            Random random = new Random();
            NumCartao = random.Next(0000000000000000);
        }
    }
}
