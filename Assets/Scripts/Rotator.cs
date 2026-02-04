using System;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.RuleTile.TilingRuleOutput;

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

        //If we wanted to move the object, we would use transform.position
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(Input.mousePosition);
        worldMousePosition.z = 0f;
        transform.up = worldMousePosition - transform.position;

        //transform.eulerAngles += transform.up;

        //Vector3 currentRotation = transform.eulerAngles;
        //currentRotation += transform.up;
        //transform.eulerAngles = currentRotation;

    }
}