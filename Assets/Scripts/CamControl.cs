using UnityEngine;
using System.Collections;

public class CamControl : MonoBehaviour
{
    //This entire thing makes me want to commit die
    public Camera CameraController;
    public GameObject Player;
    public float speed = 2f;
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - Player.transform.position;
    }

    void FixedUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
    void Update()
    {
    //    RotateCamera();
    //}

    //void RotateCamera()
    //{
    //    if (Input.GetMouseButton(0))
    //    {
    //        CameraController.transform.RotateAround(Player.transform.position,
    //        Vector3.up,
    //        Input.GetAxis("Mouse X") * speed);
    //    }


    }

}