using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

public float speed = 1.5f;
public float rotSpeed = 10.0f;

public float jumpForce = 100f;
public Rigidbody rb;


	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody>();	
	}
	
	// Update is called once per frame
	void Update () 
	{

	if (Input.GetKey(KeyCode.DownArrow))
	{
		rb.AddRelativeForce(Vector3.forward * speed * 4);
	}

	if (Input.GetKey(KeyCode.UpArrow))
	{
		rb.AddRelativeForce(Vector3.back * speed * 4);
	}

	if (Input.GetKey(KeyCode.RightArrow))
	{
		rb.AddRelativeTorque(Vector3.up*speed);
	}

		if (Input.GetKey(KeyCode.LeftArrow))
	{
		rb.AddRelativeTorque(Vector3.down*speed);
	}

/* 
	if (Input.GetKey(KeyCode.UpArrow))	
		{
			Debug.Log("Up Arrow Pressed!");
			transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}

	if (Input.GetKey(KeyCode.DownArrow))	
		{
			Debug.Log("Down Arrow Pressed!");
			transform.Translate(Vector3.back * speed * Time.deltaTime);
		}
	if (Input.GetKey(KeyCode.LeftArrow))	
		{
			Debug.Log("Left Arrow Pressed!");
			transform.Rotate(Vector3.down * rotSpeed * Time.deltaTime);
		}
	
	if (Input.GetKey(KeyCode.RightArrow))	
		{
			Debug.Log("Right Arrow Pressed!");
			transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);
		}
	*/
				
	}
		void FixedUpdate ()
	{

		if(Input.GetKey(KeyCode.Space))
	{
		print("up");
		rb.AddForce(Vector3.up * jumpForce);
	}
	}
}