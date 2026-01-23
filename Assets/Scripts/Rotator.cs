using UnityEngine;
using UnityEngine.InputSystem;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 100;
    public float zMax = 360f;
    public float zMin = 0f;
    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if( transform.eulerAngles.z >= zMax || transform.eulerAngles.z <= zMin)
        {
            rotationSpeed = -rotationSpeed;
            Debug.Log(transform.eulerAngles);
        }

        //If we wanted to move the object, we would use transform.position
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z += rotationSpeed * Time.deltaTime;

        transform.eulerAngles = currentRotation;

        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0f;

        
        Vector3 directionToFace = worldMousePosition - transform.position;
        transform.up = directionToFace;

        transform.position += transform.up * 1f * Time.deltaTime;
    }
}
