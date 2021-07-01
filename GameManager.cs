using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject geradorFacil;
    public GameObject geradorMedio;
    public GameObject geradorBitfogo;

    public GameObject GameOver;
    public GameObject RestartButton;
    public GameObject GoToMenuButton;

    public GameObject Win;
    public GameObject Loose;

    public Text pontuadorText;

    public static bool gameOver;
    public static bool pause;
    public static bool collisionWithCE;
    

    public static int pontos;

    public void Start()
    {
        Time.timeScale = 1;

        

        if (muteLigado == true)
        {
            muteOn.SetActive(true);
            muteOff.SetActive(false);
            BGM.SetActive(false);
        }
        else if (muteLigado == false)
        {
            muteOn.SetActive(false);
            muteOff.SetActive(true);
            BGM.SetActive(true);
        }

        //muteLigado = false;

        collisionWithCE = false;
        pontos = 0;
        pause = false;
        gameOver = false;

        if (StartGame.facil == true)
        {
            geradorFacil.SetActive(true);
            geradorMedio.SetActive(false);
            geradorBitfogo.SetActive(false);
        }

        if(StartGame.medio == true)
        {
            geradorFacil.SetActive(false);
            geradorMedio.SetActive(true);
            geradorBitfogo.SetActive(false);
        }

        if (StartGame.bitfogo == true)
        {
            geradorFacil.SetActive(false);
            geradorMedio.SetActive(false);
            geradorBitfogo.SetActive(true);
        }
    }

    private void Update()
    {
        //MUTE
        if (Input.GetKeyDown(KeyCode.M) && muteLigado == false)
        {
            muteOn.SetActive(true);
            muteOff.SetActive(false);
            BGM.SetActive(false);

            muteLigado = true;
        }

        else if (Input.GetKeyDown(KeyCode.M) && muteLigado == true)
        {
            muteOn.SetActive(false);
            muteOff.SetActive(true);
            BGM.SetActive(true);

            muteLigado = false;
        }

        //ESC
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
        if (pause == false && gameOver == false)
             {
                 returnButtonOBJ.SetActive(true);
                 GameOver.SetActive(true);
                 RestartButton.SetActive(true);
                 GoToMenuButton.SetActive(true);
                 Time.timeScale = 0;
                 pause = true;
             }
             else if (pause == true && gameOver == false)
             {
                 returnButtonOBJ.SetActive(false);
                 GameOver.SetActive(false);
                 RestartButton.SetActive(false);
                 GoToMenuButton.SetActive(false);
                 Time.timeScale = 1;
                 pause = false;
             }        
            
        }



        if (pontos <= 44 && collisionWithCE == true)
        {
            gameOver = true;
            GameOver.SetActive(true);
            Loose.SetActive(true);
            RestartButton.SetActive(true);
            GoToMenuButton.SetActive(true);
            //Time.timeScale = 0;
            
        }

        if (pontos > 44 && collisionWithCE == true)
        {
            gameOver = true;
            GameOver.SetActive(true);
            Win.SetActive(true);
            RestartButton.SetActive(true);
            GoToMenuButton.SetActive(true);
            Time.timeScale = 0;

        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Fase");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }



    public GameObject muteOn;
    public GameObject muteOff;
    public static bool muteLigado;
    public GameObject BGM;

    public void Mute()
    {
        
            if (muteLigado == false)
            {
                muteOn.SetActive(true);
                muteOff.SetActive(false);
                BGM.SetActive(false);

                muteLigado = true;
            }

            else if (muteLigado == true)
            {
                muteOn.SetActive(false);
                muteOff.SetActive(true);
                BGM.SetActive(true);

                muteLigado = false;
            }
        }


    public GameObject pauseButton;

    public void Pause()
    {
        if (pause == false && gameOver == false)
        {
            returnButtonOBJ.SetActive(true);
            GameOver.SetActive(true);
            RestartButton.SetActive(true);
            GoToMenuButton.SetActive(true);
            Time.timeScale = 0;
            pause = true;
        }

        
    }

    public GameObject returnButtonOBJ;

    public void ReturnButton()
    {
        if (pause == true && gameOver == false)
        {
            returnButtonOBJ.SetActive(false);
            GameOver.SetActive(false);
            RestartButton.SetActive(false);
            GoToMenuButton.SetActive(false);
            Time.timeScale = 1;
            pause = false;
        }
    }

}
