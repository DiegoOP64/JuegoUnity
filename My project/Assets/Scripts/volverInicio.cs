using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class volverInicio : MonoBehaviour
{

   void start()
     {
         
     }

    void update(){}

    public void volverInicioBut(){
        SceneManager.LoadScene("Controlador Inicial");
    }

}
