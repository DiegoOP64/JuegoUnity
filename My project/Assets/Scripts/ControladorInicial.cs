using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorInicial : MonoBehaviour
{
    public void irInstrucciones(){
        SceneManager.LoadScene("Instrucciones");
    }

    public void irPreguntas(){
        SceneManager.LoadScene("Preguntas");
    }


}
