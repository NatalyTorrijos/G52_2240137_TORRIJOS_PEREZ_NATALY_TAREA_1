using UnityEngine;
using System;
using PackagePersona;
using PackagePunto2D;
using System.Collections.Generic;


public class UsoPunto2D : MonoBehaviour
{
    List<Estudiante> listaE = new List<Estudiante>();
    List<Punto2D> listaP = new List<Punto2D>();
    void Start()
    {
        Estudiante e1 = new Estudiante("2240137", "Ing multimedia", "Nataly Torrijos", "nataly.torrijos@uao.edu.co",
            "calle 87");
        Estudiante e2 = new Estudiante("2235643", "Mercadeo", "Luna Perez", "Lunap@uao.edu.co",
            "calle 13");
        Estudiante e3 = new Estudiante("2224533", "Publicidad", "Mateo Lopez", "lopezM@uao.edu.co",
            "carrera 15");

        listaE.Add(e1);
        listaE.Add(e2);
        listaE.Add(e3);
        Punto2D p1 = new Punto2D(2.54, 5.6);
        Punto2D p2 = new Punto2D(3.44, 8.9);
        Punto2D p3 = new Punto2D(1.3, 7.4);

        listaP.Add(p1);
        listaP.Add(p2);
        listaP.Add(p3);

        ListasSerializadas datos = new ListasSerializadas(listaE, listaP);
        Utilidades.SaveDataInfo(datos);

    }


    
}