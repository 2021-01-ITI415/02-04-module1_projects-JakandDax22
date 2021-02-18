using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    private AlienInvasion deductShip;

    //Create the laser prefab
    public GameObject laserPrefab;

    //Spaceship speed
    public float speed = 2f;

    //Indicate distance of where the ship will change direction 
    public float leftAndRightEdge = 10f;

    //Chance of changing direction
    public float chanceToChangeDirections = 0.1f;

    //Set the frequency of laser blasts
    public float secondsbetweenLaser = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //Set the time in beween laser blasts
        Invoke("laserBlast", 2f);

        deductShip = Camera.main.GetComponent<AlienInvasion>();

    }

    void laserBlast()
    {
        GameObject laser = Instantiate<GameObject>(laserPrefab);
        laser.transform.position = transform.position;
        Invoke("laserBlast", secondsbetweenLaser);
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Projectile")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            deductShip.ShipCheck();
        }
    }


    // Update is called once per frame
    void Update()
    {
        //Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //Change Direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //Move right
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); //Move left
        }

    }

    private void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1; //Change direction
        }
    }
}

