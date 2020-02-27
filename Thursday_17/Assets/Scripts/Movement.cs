using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Movement : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    public GameObject ball;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {         
            //transform.Translate(Vector3.forward * speed * Time.deltaTime);
            GetComponent<Rigidbody>().AddForce(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space) && Physics.Raycast(ball.transform.position, Vector3.down, 0.50001f))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
        }


    }
    //void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject.name == "Door")
    //        SceneManager.LoadScene("AnotherScene");
    //    if (collision.gameObject.name == "Cube")
    //        ball.transform.position = new Vector3(100,100,100);
    //}
}
