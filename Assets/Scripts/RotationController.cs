using UnityEngine;

public class RotationController : MonoBehaviour
{
    [SerializeField] float _smoothSpeed = 0.15f, _smoothRotation = 0.15f;

    Transform _target;
    Quaternion _desiredRotation;

    void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player").transform;
        _desiredRotation = transform.rotation;
    }

    void Rotate(float angle) => _desiredRotation *= Quaternion.Euler(0, angle, 0);

    void RotateRight() => Rotate(90);

    void RotateLeft() => Rotate(-90);

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, _target.position, _smoothSpeed);
        transform.rotation = Quaternion.Lerp(transform.rotation, _desiredRotation, _smoothRotation);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Rotating left");
            RotateLeft();
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Rotating right");
            RotateRight();
        }
    }
}