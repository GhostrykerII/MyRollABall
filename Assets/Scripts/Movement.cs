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
    private int CamState;
    public int MaxSpeed;


    // Start is called before the first frame update
    void Start()
    {
        MaxSpeed = 20;
        CamState = 0;
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

        if (rb.velocity.magnitude >= MaxSpeed)
        {
            rb.velocity = rb.velocity.normalized * MaxSpeed;
        }

        if (Input.GetMouseButtonDown(0))
            {
                CamState--;
        }

            if (Input.GetMouseButtonDown(1))
            {
                CamState++;
        }

        if (CamState == 5)
            CamState = 0;
        if (CamState == -1)
            CamState = 4;

        if (transform.position.y < -13)
        {

            transform.position = new Vector3(-136.5323f, 1.565f, 33.71458f);

            }
        }


        
    
        
    }