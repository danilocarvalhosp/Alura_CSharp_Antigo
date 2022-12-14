using ByteBank2.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Criando DIRETOR");
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
    }
}
