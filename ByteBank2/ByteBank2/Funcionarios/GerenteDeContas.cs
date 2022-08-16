using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public GerenteDeContas(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Criando DIRETOR");
        }

        public string Senha { get; set; }


        public bool Autenticar(string senha)
        {
            return Senha == senha;
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
