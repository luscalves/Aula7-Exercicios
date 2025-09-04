using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7
{
    internal class Empregado
    {
        public string nome;
        public string departamento;
        public double horasTrabalhadas;
        public double salarioPorHora;

        public double calculaSalarioMensal()
        { 
            return horasTrabalhadas * salarioPorHora;
        }

        public string mostraDados()
        {
            return "Nome: " + this.nome + "\nDepartamento" + this.departamento + "\nHoras trabalhadas: " + horasTrabalhadas
                + "\n Salário por hora: " + this.salarioPorHora + "\n Salário total: " + this.calculaSalarioMensal();
        }
    }
}
