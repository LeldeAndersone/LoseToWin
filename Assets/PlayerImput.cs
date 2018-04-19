using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImput : MonoBehaviour
{
    public GameObject seklasPrefab;
    public Transform Seklusspawn;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Shoot();
        }
        
            
        
    }

    void Shoot()
    {
       GameObject.Instantiate(seklasPrefab,Seklusspawn.position,Seklusspawn.rotation);
    }
}
