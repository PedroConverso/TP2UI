using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CLAVEMANAGER : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextMeshProUGUI Textmensaje;

    string clave = "tic2025";

    // Start is called before the first frame update
    void Start()
    {
        Textmensaje.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void comprobarClave()
    {
        string claveIngresada = inputField.text;
        if(claveIngresada != clave)
        {
            Textmensaje.text = "Acceso denegado";
            inputField.text = "";
        }
        else
        {
            Textmensaje.text = "BIENVENIDO";
        }
    }
}
