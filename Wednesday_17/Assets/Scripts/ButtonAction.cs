using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAction : MonoBehaviour
{
    public GameObject platform;

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<MeshRenderer>().enabled = false;

        platform.GetComponent<Rigidbody>().MovePosition(new Vector3(platform.transform.position.x, 0, platform.transform.position.z));
        platform.GetComponent<Rigidbody>().isKinematic = true;
    }
}
