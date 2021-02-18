using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    private AlienInvasion deductGenerator;

    private void Start()
    {
        deductGenerator = Camera.main.GetComponent<AlienInvasion>();
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Projectile")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            deductGenerator.GeneratorDestroyed();
            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
