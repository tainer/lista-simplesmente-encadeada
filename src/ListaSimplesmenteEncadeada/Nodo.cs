using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimplesmenteEncadeada;
public class Nodo
{
    public int Valor { get; private set; }
    public Nodo ProximoNodo { get; set; }

    public Nodo(int valor)
    {
        Valor = valor;
    }
}
