using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int x,int y);
        int Subtrair(int x,int y);
        int Multiplicar(int x,int y); // METODOS NAO IMPLEMENTADOS NECESSITAM SER IMPLEMENTADOS
        int Dividir(int x, int y) { // METODOS IMPLEMENTADOS NAO NECESSITAM SER IMPLEMENTADOS
            return x / y;
        }
    }
}