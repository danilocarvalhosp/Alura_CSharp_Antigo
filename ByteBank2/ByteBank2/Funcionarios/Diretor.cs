using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando DIRETOR");
        }

        public override double GetBonificacao()
        {            
            return Salario + base.GetBonificacao();
        }

        public override void AumentarSalario()
        {
            // Salario = Salario + (Salario * 0.15);
            // Salario = Salario * 1.15;            
            Salario *= 1.15;
        }

    }
}
