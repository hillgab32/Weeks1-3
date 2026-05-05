using UnityEngine;
using UnityEngine.UIElements;

public class SquareMover : MonoBehaviour
{
    public float speed = 0.01f;
    public float xMax = 8.4f;
    public float xMin = -8.4f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //We can get access to the transform component 
        //transform.position.x += 1;

        
    }

    // Update is called once per frame
    void Update()
    {
        // Turn object randomColor
        Vector3 newPosition = transform.position;

        newPosition.x += speed;

        transform.position = newPosition;

        if (newPosition.x > xMax || newPosition.x < xMin)
        {
            speed *= -1f;
        }
    }
}
