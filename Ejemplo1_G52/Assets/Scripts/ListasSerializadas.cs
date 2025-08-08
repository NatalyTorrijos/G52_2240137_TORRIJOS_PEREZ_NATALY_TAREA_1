using PackagePersona;
using PackagePunto2D;
using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]

public class ListasSerializadas
{
    public List<Estudiante> listaE;
    public List<Punto2D> listaP;
    public ListasSerializadas()
    {
    }

    public ListasSerializadas(List<Estudiante> listaE, List<Punto2D> listaP)
    {
        this.listaE = listaE;
        this.listaP = listaP;
    }
    public List<Estudiante> ListaE { get => listaE; set => listaE = value; }
    public List<Punto2D> ListaP { get => listaP; set => listaP = value; }

}

