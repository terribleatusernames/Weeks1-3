using UnityEngine;

public class SunPulsar : MonoBehaviour
{

    public AnimationCurve pulse;
    public float duration = 3f;
    public float output;
    
    //public for testing purposes
    //public Vector3 testing;
    public float progress = 0f;

  
    void Start()
    {

    }

    void Update()
    {
        //progress the animation curve 
        progress += Time.deltaTime / duration;
        output = pulse.Evaluate(progress);


        //scale the sun based on the animation curve
        //transform.localScale = testing;
        transform.localScale = Vector3.one * output;

        //reset the progress of the animation curve
        if (progress > 1f)
        {
            progress = 0f;
        }

    }
}