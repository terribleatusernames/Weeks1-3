using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Kite : MonoBehaviour
{
    public AnimationCurve shake;

    //public for testing purposes
    public Vector3 startPos;
    public Vector3 endPos;
    public float progress = 0;
    public Vector3 output;
    public float duration = 5;
    public float direction = 1;
    public float shakeProgress = 0;
    public float shakeDuration = 4;
    public float shakeAmount;
    void Start()
    {

    }

    void Update()
    {
        //shake progress curve
        shakeProgress += Time.deltaTime / shakeDuration;
        shakeAmount = shake.Evaluate(shakeProgress);

        if (shakeProgress > 1f)
        {
            shakeProgress = 0f;
        }

        //move the kite back and forth between the start and end positions
        progress += (Time.deltaTime / duration) * direction;
        output = Vector3.Lerp(startPos, endPos, progress);

        //shale the kite
        output.x *= shakeAmount;
        transform.position = output;

        //prevent the if duration is set to 0 from softlocking
        if (duration <= 0)
        {
            duration = 0.0001f;
        }

        //invert the direction of the lerp when it reaches the end or start
        if (progress > 1f)
        {
            direction = -1f;
        }
        else if (progress < 0f)
        {
            direction = 1f;
        }

    }
}
