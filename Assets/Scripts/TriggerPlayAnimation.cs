using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlayAnimation : MonoBehaviour
{
    public GameObject AnimatedObject;
    //public GameObject AnimatedObject2;
    //public GameObject AnimatedObject3;  Basically, this how you'll make this work with multiple objects.

    private Animator _animator;

    private void Start()
    {
        _animator = AnimatedObject.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        _animator.enabled = true;
    }

    void OnTriggerExit(Collider other)
    {
        _animator.enabled = false;
    }


}
