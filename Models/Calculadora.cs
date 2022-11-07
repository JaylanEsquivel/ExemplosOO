using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoFinal.Interfaces;

namespace ProjetoFinal.Models
{
    public class Calculadora : ICalculadora
    {

        public int Somar(int x, int y) {
            return x + y;
        }
        public int Subtrair(int x, int y) {
            return x - y;
        }
        public int Multiplicar(int x, int y) {
            return x * y;
        }
        public int Dividir(int x, int y) {
            return x / y;
        }

    }
}