using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour 
{
/*	public float speed = 1.5f;
	public float rotSpeed = 10.0f;
	public float jumpForce = 100f;
*/	
	public Rigidbody rigidBullet;
	public GameObject Bullet;
	public float ballPower = 1000f;
	// Use this for initialization
void Start () 
	{
		//rigidBullet = GetComponent<Rigidbody>();		
	}
	
	// Update is called once per frame
	void Update () 
	{

		//if(Input.GetKey(KeyCode.Return))
		if(Input.GetMouseButtonDown(0))
		{
			GameObject newBullet = Instantiate(Bullet, transform.position + Vector3.forward, Quaternion.identity);
		
			newBullet.GetComponent<Rigidbody>().AddForce(Vector3.forward * ballPower);


			
		}
	}
}
