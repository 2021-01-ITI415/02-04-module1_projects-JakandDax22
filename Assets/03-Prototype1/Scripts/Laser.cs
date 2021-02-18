using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float bottomY = -20f;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "House")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            //Invoke houseDestroyed();
        }

        if (other.gameObject.tag == "Projectile")
        {
            Destroy(gameObject);
        }
    }
    

    // Update is called once per frame
    void Update()
    {
     if (transform.position.y < -20)
        {
            Destroy(this.gameObject);
        }
    }
}
