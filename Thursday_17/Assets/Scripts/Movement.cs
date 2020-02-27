using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    public GameObject ball;

    public static int score;
    public Text scoreText;

    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        
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
}
