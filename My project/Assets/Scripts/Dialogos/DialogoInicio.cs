using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class DialogoInicio : MonoBehaviour
{

    private Queue <string> colaDialogo;
    TextosInicio texto;
    [SerializeField] TextMeshProUGUI textoPantalla;
    private bool check;
  
    void Start(){
          Debug.Log("Funcion3");
          colaDialogo = new Queue<string>();
        Debug.Log("Funcion1");
        colaDialogo.Enqueue("Saludos y bienvenidos a Who Wants to be a Developer");
        colaDialogo.Enqueue("Juego creado para mejorar respecto a las interfaces de usuario");
        colaDialogo.Enqueue("*Tab para comenzar*");
        SiguienteFrase();
    }
  

   

    public void SiguienteFrase(){
          Debug.Log("Funcion2");
          textoPantalla.text="";
        if (colaDialogo.Count == 0){
            //SceneManager.LoadScene("PreguntasPrograma");
            return;
        }
            string fraseActual =  colaDialogo.Dequeue();
            textoPantalla.text = fraseActual;
            StartCoroutine(MostrarCaracteres(fraseActual));        
    }
    
    IEnumerator MostrarCaracteres (string textoAMostrar){

        textoPantalla.text = "";
        foreach(char caracter in textoAMostrar.ToCharArray()){
            textoPantalla.text += caracter;
            yield return new WaitForSeconds(0.003f);
        }
    }


}
