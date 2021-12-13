using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ControladorPreguntas : MonoBehaviour
{
    public ObjetoPregunta[] objPreguntas;
    public GameObject[] preguntas;
    public GameObject pregObj;
    public GameObject campos;
    public GameObject canvas;
    public int idx = 0;
    public int nCorregidas = 0;
    TextMeshProUGUI txt ;
    public string respuestaActual;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        preguntas = new GameObject[10];
        objPreguntas = new ObjetoPregunta[10];
        for (int i=0; i<10 ; i++){
            iniciarPregunta();
        }
          idx = 0;
        lanzarPrimera();
        

    }

    public void iniciarPregunta(){
        ObjetoPregunta nuevaPregunta =  new ObjetoPregunta("Pregunta" + idx, "r1", "r2", "r3", "r4", "r1");
        //Crea pregunta escogiendo una del "cupo" -> ObjetoPregunta o = escojePregunta();
        
        GameObject newPreg = Instantiate(pregObj) as GameObject;
        newPreg.name = "Pregunta" + idx;
        
        newPreg.transform.SetParent(canvas.transform, false);

        nuevaPregunta.mezclar();
        campos = GameObject.Find("Canvas/" + newPreg.name + "/Pregunta/txtPregunta");
        txt = campos.GetComponent<TextMeshProUGUI>();
        txt.text =nuevaPregunta.pregunta;

        campos = GameObject.Find("Canvas/" + newPreg.name + "/Respuesta1/txt1");
        txt = campos.GetComponent<TextMeshProUGUI>();
        txt.text =nuevaPregunta.respuestas[0];

        campos = GameObject.Find("Canvas/" + newPreg.name + "/Respuesta2/txt2");
        txt = campos.GetComponent<TextMeshProUGUI>();
        txt.text =nuevaPregunta.respuestas[1];

        campos = GameObject.Find("Canvas/" + newPreg.name + "/Respuesta3/txt3");
        txt = campos.GetComponent<TextMeshProUGUI>();
        txt.text =nuevaPregunta.respuestas[2];

        campos = GameObject.Find("Canvas/" + newPreg.name + "/Respuesta4/txt4");
        txt = campos.GetComponent<TextMeshProUGUI>();
        txt.text =nuevaPregunta.respuestas[3];

        preguntas[idx] = newPreg;
        objPreguntas[idx] = nuevaPregunta;
        idx++;

    }

    public void lanzarPrimera(){
        anim = preguntas[idx].GetComponent<Animator>();
        anim.Play("EntradaDerecha");
    }


    public void siguiente(){

        if( idx < 9 ){
            anim = preguntas[idx].GetComponent<Animator>();
            anim.Play("SalidaIzquierda");

            idx++;
            anim = preguntas[idx].GetComponent<Animator>();
            anim.Play("EntradaDerecha");
        }

    }

    public void anterior(){

        if( idx > 0 ){
            anim = preguntas[idx].GetComponent<Animator>();
            anim.Play("SalidaDerecha");

            idx--;
            anim = preguntas[idx].GetComponent<Animator>();
            anim.Play("EntradaIzquierda");
        }
    }







}
