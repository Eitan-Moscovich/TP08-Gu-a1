using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string nombre = "Eitan";
    public int edad = 16;
    public float estatura = 1.67f;
    public bool esDonante = false; 
    // Start is called before the first frame update
    void Start()
    {
         Debug.Log("Mi nombre es " + nombre + ", tengo " + edad + ", mido " + estatura + " metros y es " + esDonante + " que soy donante de organos.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
