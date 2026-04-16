using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculos : MonoBehaviour
{
    public int num1;
    public int num2;
    int resultado;
    // Start is called before the first frame update
    void Start()
    {
        resultado = num1 + num2;
        Debug.Log("El resultado de la suma entre " + num1 + " y " + num2 + " es: " + resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
