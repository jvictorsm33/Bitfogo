using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public static bool facil;
    public static bool medio;
    public static bool bitfogo;

    private void Start()
    {
        facil = false;
        medio = false;
        bitfogo = false;
    }

    public void Facil()
    {
        SceneManager.LoadScene("Fase");

        facil = true;
        medio = false;
        bitfogo = false;
    }

    public void Medio()
    {
        SceneManager.LoadScene("Fase");

        facil = false;
        medio = true;
        bitfogo = false;
    }

    public void Bitfogo()
    {
        SceneManager.LoadScene("Fase");

        facil = false;
        medio = false;
        bitfogo = true; 
    }

}
