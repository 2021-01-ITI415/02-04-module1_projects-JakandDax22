using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlienInvasion : MonoBehaviour
{

    public int numHouse = 4;
    public int numGenerator = 5;
    public int numShip = 2;
    //public GameObject winTextObject;
    //public GameObject loseTextObject;
    //public float textDelay = 3f;


    // Start is called before the first frame update
    void Start()
    {
        //loseTextObject.SetActive(false);
        //winTextObject.SetActive(false);
    }

    public void HouseDestroyed()
    {
        numHouse = numHouse - 1;
        if (numHouse == 0)
        {
            //loseTextObject.SetActive(true);
            SceneManager.LoadScene("Main-Prototype 1");
        }
    }

    public void GeneratorDestroyed()
    {
        numGenerator = numGenerator - 1;
        if (numGenerator == 0)
        {
            Destroy(GameObject.FindGameObjectWithTag("Barrier"));
        }
    }

    public void ShipCheck()
    {
            numShip = numShip - 1;
            if (numShip == 0)
            {
            SceneManager.LoadScene("Main-Prototype 1");
            }
       
    }


    // Update is called once per frame
    void Update()
    {
        
        //Check to see if the saucer is still there

        //If not, reload the scene

    }
}
