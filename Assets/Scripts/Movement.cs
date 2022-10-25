using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Movement : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI countText;
    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
        }

    }

    private void Update()
    {
        if (transform.position.y < -2)
        {
            {
                /*transform.position.x = -136.5323;
                transform.position.y = 0.9000003;
                transform.position.z = 33.71458;*/
                transform.position = new Vector3(-136.5323f, 0.9000003f, 33.71458f);
                /*transform.rotation.x = 1;
                transform.rotation.y = 1;
                transform.rotation.z = 1;*/
            }
        }
        

        
    }
}