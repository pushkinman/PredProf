using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFix : MonoBehaviour
{
    public GameObject ball;
    public GameObject cam;
    private Vector3 offset;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = ball.transform.position - cam.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.position = ball.transform.position - offset;
    }
}
