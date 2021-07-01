using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{
   

    public void Iniciar()
    {
        SceneManager.LoadScene("Dificuldades");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void Sair()
    {
        Application.Quit();
    }

}
