using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGunDemo : MonoBehaviour
{

    private string spawndirection = "null";
    private bool canUpdateDirection = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(despawn());
    }

    // Update is called once per frame
    void Update()
    {
        if (TopDownMovement.playerFacing == "right" && canUpdateDirection)
        {
            spawndirection = "right";
            canUpdateDirection = false;
        }
        else if (TopDownMovement.playerFacing == "left" && canUpdateDirection)
        {
            spawndirection = "left";
            canUpdateDirection = false;
        }

        if (spawndirection == "right")
        {
            transform.position = transform.position + new Vector3(0.2f, 0, 0);
        }
        else if (spawndirection == "left")
        {
            transform.position = transform.position + new Vector3(-0.2f, 0, 0);
        }
    }

    private IEnumerator despawn()
    {
        yield return new WaitForSeconds(5.0f);
        Destroy(gameObject);
    }
}
