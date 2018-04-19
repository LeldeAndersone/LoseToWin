using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour {
    public float speed = 1.0f;
    public Color startColor;
    public Color endColor;
    public bool repeatable = false;
    float startTime;
    private Light firelight;
    void Start()
    {
        startTime = Time.time;
        firelight = GetComponent<Light>();
    }
    void Update(){
        if (!repeatable){
            float t = (Time.time - startTime) * speed;
            firelight.color = Color.Lerp(startColor, endColor, t);

        }else{
            float t = (Mathf.Sin(Time.time - startTime) * speed);
            firelight.color = Color.Lerp(startColor, endColor, t);
        }
    }
}