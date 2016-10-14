using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    class Nodo
    {
        Nodo padre;
        Estado estado;
        debug de;

        public Nodo()
        {
        }
        public Nodo(Nodo padre, int j3, int j4, String accion)
        {
            this.padre = padre;
            this.estado = new Estado(j3, j4, accion);
        }
        //función para comprobar si el estado es meta
        public bool esNodoMeta()
        {
            return estado.EsMeta();
        }



        //crea una lista de estados candidatos, los compara con los del padre por si se repite. devuelve una lista de nodos.
        public List<Nodo> expandir(debug de)
        {
            this.de = de;
            de.setDeb(this.miEstado());
            estado.setDebug(de);
            List<Estado> estadosCandidatos = estado.expandir();
            List<Nodo> listaADevolver = new List<Nodo>();

            foreach (Estado esta in estadosCandidatos)
            {
                
                if (padre == null)
                {
                    Nodo nuevoNodo = new Nodo(this, esta.getJ3(), esta.getJ4(), null);
                    
                    listaADevolver.Add(nuevoNodo);
                }
                else if (!esta.comparaEstado(padre.getEstado()))
                    {
                        Nodo nuevoNodo = new Nodo(this, esta.getJ3(), esta.getJ4(), esta.accion);
                        listaADevolver.Add(nuevoNodo);
                }
            }
            return listaADevolver;
        }

        public Estado getEstado()
        {
            return estado;

        }
        public string miEstado()
        {
            return "Mi estado es (" + estado.getJ3() + ", " + estado.getJ4() + ")"; 
        }
        public Nodo miPadre()
        {
            return padre;
        }
    }
}