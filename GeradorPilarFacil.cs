using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorPilarFacil : MonoBehaviour
{
    public int time = 40;

    public GameObject spawnPilar;

    public GameObject pilar01;
    public GameObject pilar02;
    public GameObject pilar03;
    public GameObject pilar04;
    public GameObject pilar05;
    public GameObject pilar06;
    public GameObject pilar07;
    public GameObject pilar08;
    public GameObject pilar09;
    public GameObject pilar10;
    public GameObject pilar11;
    public GameObject pilar12;
    public GameObject pilar13;
    public GameObject pilar14;
    public GameObject pilar15;
    public GameObject pilar16;
    public GameObject pilar17;
    public GameObject pilar18;
    public GameObject pilar19;

    void Start()
    {
        StartCoroutine("contadorPilar");
    }

    
    void Update()
    {
        
    }

    IEnumerator contadorPilar()
    {
        yield return new WaitForSeconds(1);

        time -= 1;

        if (time > 0)
        {
            StartCoroutine("contadorPilar");

        }
        
        if(time == 38)
        {
            Instantiate(pilar01, spawnPilar.transform.position, pilar01.transform.rotation);

        }

        if (time == 36)
        {
            Instantiate(pilar02, spawnPilar.transform.position, pilar02.transform.rotation);
        }

        if (time == 34)
        {
            Instantiate(pilar03, spawnPilar.transform.position, pilar03.transform.rotation);
        }

        if (time == 32)
        {
            Instantiate(pilar04, spawnPilar.transform.position, pilar04.transform.rotation);
        }

        if (time == 30)
        {
            Instantiate(pilar05, spawnPilar.transform.position, pilar05.transform.rotation);
        }

        if (time == 28)
        {
            Instantiate(pilar06, spawnPilar.transform.position, pilar06.transform.rotation);
        }

        if (time == 26)
        {
            Instantiate(pilar07, spawnPilar.transform.position, pilar07.transform.rotation);
        }

        if (time == 24)
        {
            Instantiate(pilar08, spawnPilar.transform.position, pilar08.transform.rotation);
        }

        if (time == 22)
        {
            Instantiate(pilar09, spawnPilar.transform.position, pilar09.transform.rotation);
        }

        if (time == 20)
        {
            Instantiate(pilar10, spawnPilar.transform.position, pilar10.transform.rotation);
        }

        if (time == 18)
        {
            Instantiate(pilar11, spawnPilar.transform.position, pilar11.transform.rotation);
        }

        if (time == 16)
        {
            Instantiate(pilar12, spawnPilar.transform.position, pilar12.transform.rotation);
        }

        if (time == 14)
        {
            Instantiate(pilar13, spawnPilar.transform.position, pilar13.transform.rotation);
        }

        if (time == 12)
        {
            Instantiate(pilar14, spawnPilar.transform.position, pilar14.transform.rotation);
        }

        if (time == 10)
        {
            Instantiate(pilar15, spawnPilar.transform.position, pilar15.transform.rotation);
        }

        if (time == 8)
        {
            Instantiate(pilar16, spawnPilar.transform.position, pilar16.transform.rotation);
        }

        if (time == 6)
        {
            Instantiate(pilar17, spawnPilar.transform.position, pilar17.transform.rotation);
        }

        if (time == 4)
        {
            Instantiate(pilar18, spawnPilar.transform.position, pilar18.transform.rotation);
        }

        if (time == 2)
        {
            Instantiate(pilar19, spawnPilar.transform.position, pilar19.transform.rotation);
        }
    }


}
