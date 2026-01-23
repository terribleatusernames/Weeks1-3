
using Unity.VisualScripting.ReorderableList;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    public float speed = 10f;
    Vector3 position;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool leftIsHeld = Mouse.current.leftButton.isPressed;
        if (leftIsHeld)
        {
            Debug.Log("Left mouse is held");
        }

        bool leftIsPressed = Mouse.current.leftButton.wasPressedThisFrame;
        if (leftIsPressed)
        {
            Debug.Log("Left mouse is pressed.");
        }

        bool leftIsReleased = Mouse.current.leftButton.wasReleasedThisFrame;
        if (leftIsReleased)
        {
            Debug.Log("Left mouse is released.");
        }

        bool upIsHeld = Keyboard.current.upArrowKey.isPressed;
        if(upIsHeld)
        {
            transform.position += transform.up + speed;
        }
        bool downIsHeld = Keyboard.current.downArrowKey.isPressed;
        if(downIsHeld)
        {
            position.y = position.y - speed * Time.deltaTime;
            transform.position = position;
        }
    }
}