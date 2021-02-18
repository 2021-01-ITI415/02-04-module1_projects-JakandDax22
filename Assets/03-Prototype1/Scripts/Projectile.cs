using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -20)
        {
            Destroy(this.gameObject);
        }

        if (transform.position.x < -30)
        {
            Destroy(this.gameObject);
        } else if (transform.position.x > 30)
        {
            Destroy(this.gameObject);
        }
    }
}

