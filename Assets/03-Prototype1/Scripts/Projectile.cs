using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Generator")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            //Invoke generatorDestroyed();
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

