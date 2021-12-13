using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoPregunta 
{
    public string pregunta{ get; set; }
    public string[] respuestas{ get; set; }
    public string respuestaCorrecta{ get; set; } 
    public bool corregido{ get; set; } 

    public ObjetoPregunta(string nPregunta, string r1, string r2, string r3, string r4, string correcta ){
        pregunta = nPregunta;
        respuestas = new string[] {r1,r2,r3,r4};
        respuestaCorrecta = correcta;
        corregido = false;
    }

    public void mezclar(){
        int n = respuestas.Length;
        while (n > 1) 
        {
            int k = Random.Range(0, n--);
            string temp = respuestas[n];
            respuestas[n] = respuestas[k];
            respuestas[k] = temp;
        }
    }

}
