using UnityEngine;
using UnityEngine.InputSystem;

public class Chaser : MonoBehaviour
{
    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // turn the position of the mouse into a value
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        // set the dimensions to be within the world camera
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);

        // set the z position of the chaser to 0
        worldMousePosition.z = 0f;
        // have the chaser follow the mouse
        transform.position = worldMousePosition;
    }
}
