using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlienInvasion : MonoBehaviour
{

    public int numHouse = 4;
    public List<GameObject> houseList;
    public int numGenerator = 5;
    public List<GameObject> generatorList;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void HouseDestroyed()
    {
        numHouse = numHouse - 1;
        if (numHouse == 0)
        {
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

    // Update is called once per frame
    void Update()
    {
        
        //Check to see if the saucer is still there

        //If not, reload the scene

    }
}
