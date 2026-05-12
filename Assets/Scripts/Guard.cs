using UnityEngine;

public class Guard : MonoBehaviour
{
    public Vector3 startValue;
    public Vector3 endValue;

    public float duration;

    public Vector3 currentValue;

    float progress = 0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime;

        //float number = Mathf.Lerp(startValue, endValue, (progress/duration));
        currentValue = Vector3.Lerp(startValue, endValue, (progress/duration));
        transform.position = currentValue;

        //Debug.Log("progress: " +progress+ " duration: " +duration);
        if(progress > duration)
        {
            //Debug.Log("progress > duration");
            progress = 0f;
        }
    }
}
