using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Seklas : MonoBehaviour {
    float speed;
	// Use this for initialization
	void Start () {
        speed = 15;
        //Destroy(this.gameObject, 2);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * Time.deltaTime * speed;
	}
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<Vista>().Hit(10);
            Debug.Log("Hit enemy");
            //Destroy(this.gameObject);
        }
    }
}
