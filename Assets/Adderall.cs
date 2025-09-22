using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adderall : MonoBehaviour
{

    static public bool machineGun = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D Target)
    {
        if (Target.tag == "Player")
        {
            machineGun = true;
            Destroy(gameObject);
        }
    }
}
