using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletlauncher : MonoBehaviour {
    public GameObject bulletPrefab;
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        /*if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GameObject instant = Instantiate(bulletPrefab);
            Rigidbody rb=instant.GetComponent<Rigidbody>();
            rb.velocity = Vector3.left * speed;
        } 
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GameObject instant = Instantiate(bulletPrefab);
            Rigidbody rb=instant.GetComponent<Rigidbody>();
            rb.velocity = Vector3.right * speed;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GameObject instant = Instantiate(bulletPrefab);
            Rigidbody rb=instant.GetComponent<Rigidbody>();
            rb.velocity = Vector3.forward * speed;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GameObject instant = Instantiate(bulletPrefab);
            Rigidbody rb=instant.GetComponent<Rigidbody>();
            rb.velocity = Vector3.back * speed;
        }*/
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject instant = Instantiate(bulletPrefab);
            instant.transform.position = transform.position;
            Rigidbody rb = instant.GetComponent<Rigidbody>();
            Camera camera = GetComponent<Camera>();
            rb.velocity = camera.transform.rotation * Vector3.forward * speed;


        }














    }




}

