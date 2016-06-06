using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	// Use this for initialization

    public Rigidbody prefab;

    public float speed = 10.0f;

    
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        if(Input.GetKey(KeyCode.Q)) Application.Quit();
        
        if (Input.GetButtonDown("Fire1")) {
            var obj = (Rigidbody)Instantiate(this.prefab, transform.position, transform.rotation);
            obj.velocity = (transform.forward + transform.up / 2) * speed;
        }





	}
}
