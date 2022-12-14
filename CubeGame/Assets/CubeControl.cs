using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour

{
    Rigidbody ourRigidbody;

    private float turningSpeed = 180;

    // Start is called before the first frame update
    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        transform.position += Vector3.up* Time.deltaTime;
        if (Input.GetKey(KeyCode.DownArrow))
        transform.position += Vector3.down* Time.deltaTime;
        if (Input.GetKey(KeyCode.RightArrow))
        transform.position += Vector3.right* Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftArrow))
        transform.position += Vector3.left * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
        transform.Rotate(Vector3.up,-turningSpeed* Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
        transform.Rotate(Vector3.up,+turningSpeed* Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
        transform.position += transform.forward* Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
        transform.position -= transform.forward* Time.deltaTime;


        //  if (Input.GetKeyDown(KeyCode.LeftArrow)) 
            ourRigidbody.AddExplosionForce(1000,transform.position+Vector3.down);



    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.position += Vector3.down;
    }
}
