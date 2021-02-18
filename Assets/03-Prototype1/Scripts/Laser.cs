using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float bottomY = -20f;

    // Update is called once per frame
    void Update()
    {
     if (transform.position.y<-20)
        {
            Destroy(this.gameObject);
        }
    }
}
