using System.IO;
using UnityEngine;

public static class Utilidades
{
    private static string rutaArchivo = Application.persistentDataPath + "/Datos.json";

    public static void SaveDataInfo(ListasSerializadas datos)
    {
        string json = JsonUtility.ToJson(datos, true);
        File.WriteAllText(rutaArchivo, json);
        Debug.Log("JSON guardado:\n" + json);
        Debug.Log("Datos guardados en: " + rutaArchivo);

    }

 
}

