using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class debug {

    String deb;

    public debug()
    {
        deb = "Nuevo ";
    }

    public String getDeb()
    {
        return deb;
    }
    public void setDeb(String nuevo)
    {
        deb = deb + nuevo;
    }
    
}
