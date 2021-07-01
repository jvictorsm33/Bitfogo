using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisorPilar : MonoBehaviour
{

    public GameManager manager;

    public AudioClip vaia;
    AudioSource audioS;

    private void Start()
    {
        manager = FindObjectOfType<GameManager>();
        audioS = gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            audioS.clip = vaia;
            audioS.Play();

            GameManager.pontos -= 3;

            if (GameManager.pontos <= 0)
            {
                GameManager.pontos = 0;
            }

            manager.pontuadorText.text = GameManager.pontos.ToString();
        }
    }
}
