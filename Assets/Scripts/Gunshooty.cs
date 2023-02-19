using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunshooty : MonoBehaviour
{
    public GameObject bullet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            GameObject shot = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            shot.GetComponent <Rigidbody>().AddForce(transform.forward * 10);
        }
    }
}
