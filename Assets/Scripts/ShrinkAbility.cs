using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkAbility : MonoBehaviour
{
    private float curScale;
    public float startScale;
    public float shrinkSpeed;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        curScale = Mathf.MoveTowards(curScale, startScale, Time.deltaTime * shrinkSpeed);
        gameObject.transform.localScale = new Vector3(curScale, curScale, curScale);
    }
}
