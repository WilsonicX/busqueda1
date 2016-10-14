using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class main : MonoBehaviour {
    debug de;
    // Use this for initialization
    void Start () {
        de = new debug();
        List<Assets.Nodo> solucion = new List<Assets.Nodo>();
        Assets.Nodo nodo;
        Assets.BusquedaEnAmplitud busqueda = new Assets.BusquedaEnAmplitud(de);

        //llamamos a la función de búsqueda
        nodo = busqueda.busqueda(1,1);
        //para ver la traza
        Debug.Log(de.getDeb());

        

        //a través del nodo padre creamos una lista con la solución
        while (nodo.miPadre() != null )
        {
            solucion.Insert(0, nodo);
            nodo = nodo.miPadre();

        }
        solucion.Insert(0, nodo);

        Debug.Log("Lista de nodos con la solución");
        //recorremos toda la lista para mostrar la solución
        foreach (Assets.Nodo nod in solucion)
        {
            Debug.Log(nod.miEstado());
        }

           
        

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
