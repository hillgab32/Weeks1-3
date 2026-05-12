using UnityEngine;

public class BouncerBall : MonoBehaviour
{
    public float ySpeed = 4f;
    public float xSpeed = 4f;
    public float xMax = 8.4f;
    public float xMin = -8.4f;
    public float yMax = 4.4f;
    public float yMin = -4.4f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;

        newPosition.x += xSpeed * Time.deltaTime;
        newPosition.y += ySpeed * Time.deltaTime;

        transform.position = newPosition;

        if (newPosition.x > xMax || newPosition.x < xMin)
        {
            xSpeed *= -1f;
        }

        if (newPosition.y > yMax || newPosition.y < yMin)
        {
            ySpeed *= -1f;
        }
    }
}
