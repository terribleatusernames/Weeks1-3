using UnityEngine;

public class CloudMover : MonoBehaviour
{
    public float speed = 2f;
    public float xMax;
    public Camera gameCamera;

    // these are public for debugging
    public Vector3 cloudPositionWorld;
    public Vector3 cloudXPos;


    void Start()
    {
        cloudXPos = transform.position;
    }

    void Update()
    {
        // Move the cloud to the right
        cloudXPos.x = cloudXPos.x + speed * Time.deltaTime;
        transform.position = cloudXPos;



        // Check if the cloud has moved off the right side of the screen
        cloudPositionWorld = gameCamera.WorldToScreenPoint(transform.position);
        xMax = Screen.width + 50;

        if (xMax < cloudPositionWorld.x)
        {
            cloudXPos.x *= -1 ;
            Debug.Log("Cloud X Position Reset");
        }


    }
}