using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject tp2;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
            other.gameObject.transform.position = tp2.transform.position;
        }
    }

    /*public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "Sphere")
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 500);
        }
    }*/

    //public void OnTriggerStay(Collider other)
    //{
    //    if (other.gameObject.name == "Sphere")
    //    {
    //        other.gameObject.transform.Rotate(Vector3.up, 5f);
    //    }
    //}

    
}
