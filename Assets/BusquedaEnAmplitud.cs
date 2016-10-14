using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    class BusquedaEnAmplitud
    {
        List<Nodo> nodosAbiertos = new List<Nodo>();
        debug de;

        //constructor con los estados originales de las jarras
        public BusquedaEnAmplitud(debug de)
        {
            this.de = de;

        }

        public Nodo busqueda(int j3, int j4)
        {
            List<Nodo> listaSucesores = new List<Nodo>();
            Nodo nodoActual = null;
            nodosAbiertos.Add(new Nodo(null, j3, j4, null));
            
            while (nodosAbiertos.Count() > 0)
            {
                nodoActual = nodosAbiertos[0];
             
                nodosAbiertos.RemoveAt(0);
                if (nodoActual.esNodoMeta())
                {
                    return nodoActual;
                }
                nodosAbiertos.AddRange(nodoActual.expandir(de));
            }

            return null;
        }

    }
}
