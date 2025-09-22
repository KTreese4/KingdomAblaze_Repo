using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{

    static public string playerFacing = "right";
    public GameObject bullet;
    public GameObject spawnbullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-0.1f, 0, 0);
            playerFacing = "left";
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(0.1f, 0, 0);
            transform.localScale = new Vector3(1,1,1);
            playerFacing = "right";
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0, 0.1f, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0, -0.1f, 0);
        }

        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bullet, spawnbullet.transform.position, transform.rotation);
            if (Adderall.machineGun == true)
            {
                Instantiate(bullet, (spawnbullet.transform.position + new Vector3(0,1,0)), transform.rotation);
                Instantiate(bullet, spawnbullet.transform.position, transform.rotation);
                Instantiate(bullet, (spawnbullet.transform.position + new Vector3(0, -1, 0)), transform.rotation);
            }
        }
        
    }
}
