using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class TankMotor : MonoBehaviour
{
    // Need a reference to the Character Controller component
    private CharacterController characterController;
    private Transform tf;

    private void Start()
    {
        characterController = gameObject.GetComponent<CharacterController>();
        tf = gameObject.GetComponent<Transform>();
    }

    // Handle moving the tank
    public void Move(float speed)
    {
        // Vector to hold our speed data
        // Start with a vector pointing the same direction as the GameObject this script is on
        // Speed vector should be of a length of speed
        Vector3 speedVector = tf.forward * speed;

        // Send speedVector to SimpleMove to handle movement
        // SimpleMove already applies Time.deltaTime

        characterController.SimpleMove(speedVector);
    }

    // Handle rotation the tank
    public void Rotate(float speed)
    {
        // Vector to hold rotation data
        // Start by rotation by one degree pre frame draw
        // Adjust rotation based off speed
        // Multiply by time.deltaTime to ensure framerate independence
        Vector3 rotateVector = Vector3.up * speed * Time.deltaTime;

        

        // Pass our rotation vector into transform.rotate
        tf.Rotate(rotateVector, Space.Self);
    }
}
