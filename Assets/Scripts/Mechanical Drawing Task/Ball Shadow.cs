using UnityEngine;
using UnityEngine.InputSystem;

public class BallShadow : MonoBehaviour 
{
    public Camera gameCamera;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        //make the shadow follow the mouse position
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0;
        worldMousePosition.y = -4.5f; //fixed y position for the shadow
        transform.position = worldMousePosition;
    }
}
