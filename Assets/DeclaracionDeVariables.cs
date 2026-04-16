using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    int numero = 10;
    float decimalNum = 3.14f;
    string texto = "Hola mundo";
    bool esVerdadero = true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(numero);
        Debug.Log(decimalNum);
        Debug.Log(texto);
        Debug.Log(esVerdadero);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
