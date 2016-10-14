using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    class Estado
    {
        public int J3 { get; set; }
        public int J4 { get; set; }
        debug de;

        public String accion;

        public Estado(int j3, int j4, String accion)
        {
            J3 = j3;
            J4 = j4;
            this.accion = this.accion + accion;
        }

        public void setDebug(debug de)
        {
            this.de = de;
        }
        public int getJ3()
        {
            return J3;
        }
        public int getJ4()
        {
            return J4;
        }
        public String getAccion()
        {
            return accion;
        }
        //función que comprueba si hemos llegado al estado meta
        public bool EsMeta()
        {
            return J4 == 2;
        }
        //devuelve una lista de estados tras realizar, de ser posible, todas las acciones
        public List<Estado> expandir()
        {
            int cont = 0;
            List<Estado> listaADevolver = new List<Estado>();
            if (J3 != 3)
            {
                listaADevolver.Add(LlenarJ3());
            }
            if (J4 != 4)
            {
                listaADevolver.Add(LlenarJ4());
            }
            if (J3 > 0)
            {
                listaADevolver.Add(VaciarJ3());
            }
            if (J4 > 0)
            {
                listaADevolver.Add(VaciarJ4());
            }
            if ((J3 != 0) && (J4 != 4))
            {
                listaADevolver.Add(VaciarJ3EnJ4());
            }
            if ((J4 != 0) && (J3 != 3))
            {
                listaADevolver.Add(VaciarJ4EnJ3());
            }
            return listaADevolver;
        }

        //todas las acciones posibles
        public Estado LlenarJ3()
        {
            Estado estado = new Estado(3, J4, "LLenar J3 ");
            de.setDeb("He llenado J3 *" + estado.getJ3() + "," + estado.getJ4() + "* ");
            return estado;

        }
        public Estado LlenarJ4()
        {
            Estado estado = new Estado(J3, 4, "LLenar J4 ");
            de.setDeb("He llenado J4 *" + estado.getJ3() + "," + estado.getJ4() + "* ");
            return estado;
        }
        public Estado VaciarJ3()
        {
   
            Estado estado = new Estado(0, J4, "Vaciar J3 ");
            de.setDeb("He vaciado J3 *" + estado.getJ3() + "," + estado.getJ4() +"* " );
            return estado;
        }
        public Estado VaciarJ4()
        {
            Estado estado = new Estado(J3, 0, "VAciar J4 ");
            de.setDeb("He vaciado J4 *" + estado.getJ3() + "," + estado.getJ4() + "* ");
            return estado;
        }
        public Estado VaciarJ3EnJ4()
        {
            int x, y;
            x = J3 + J4 - 4;
            if (x < 0)
            {
                x = 0;
            }
            y = J4 + (J3 - x);
            Estado estado = new Estado(x, y, "Vaciar J3 en J4 ");
            de.setDeb("He vaciado J3 en J4 *" + estado.getJ3() + "," + estado.getJ4() + "* ");
            return estado;
        }
        public Estado VaciarJ4EnJ3()
        {
            int x, y;
            y = J4 + J3 - 3;
            if (y < 0)
            {
                y = 0;
            }
            x = J3 + J4 - y;
            Estado estado = new Estado(x, y, "Vaciar J4 en J3 ");
            de.setDeb("He vaciado J3 en J4 *" + estado.getJ3() + "," + estado.getJ4() + "* ");
            return estado;
        }

        //compara estados para ver si son iguales
        public bool comparaEstado(Estado esta)
        {
            return (J3 == esta.getJ3() && J4 == esta.getJ4());
        }
    }

}
