using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontuador : MonoBehaviour
{

    public GameManager manager;

    public AudioClip vibra;
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
            audioS.clip = vibra;
            audioS.Play();

            GameManager.pontos += 3;
            manager.pontuadorText.text = GameManager.pontos.ToString();
        }
    }
}
