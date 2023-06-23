using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatosLineales.LinkedListCycle
{
    internal class Node
    {
        public int Valor { get; set; }
        public Node Siguiente { get; set; }
    }

    internal class LinkedListCycle
    {
        public static bool HasCycle(Node nodo)
        {
            if (nodo is null) return false;

            var lento = nodo;
            var rapido = nodo.Siguiente;

            while (lento != rapido)
            {
                if (lento is null || rapido.Siguiente is null)
                    return false;

                lento = lento.Siguiente;
                rapido = rapido.Siguiente.Siguiente;
            }

            return true;
        }
    }
}
