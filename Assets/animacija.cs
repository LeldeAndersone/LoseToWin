using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacija : MonoBehaviour {

    public Animation Animator;
    void Start()
    {
        Animator = GetComponent<Animation>();
        foreach (AnimationState state in Animator)
        {
            state.speed = 0.5F;
        }
    }
}
