using UnityEngine;
using UnityEngine.InputSystem;

public class BasketballMover : MonoBehaviour 
{
    public Camera gameCamera;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        //make the basketball follow the mouse position
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0;

        transform.position = worldMousePosition;
    }
}
