using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ShrinkTrigger"))
            transform.localScale = new Vector3(0.5f,0.5f,0.5f);
        if (other.CompareTag("ResizeTrigger"))
            transform.localScale = new Vector3(1f, 1f, 1f);
        if (other.CompareTag("GrowTrigger"))
            transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
}



