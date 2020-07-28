using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TankData))]
[RequireComponent(typeof(TankMotor))]
public class InputManager : MonoBehaviour
{
    public enum InputScheme { WASD, arrowKeys };
    public InputScheme input = InputScheme.WASD;

    private TankMotor motor;
    private TankData data;

    // Start is called before the first frame update
    void Start()
    {
        data = gameObject.GetComponent<TankData>();
        motor = gameObject.GetComponent<TankMotor>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
    }

    void HandleInput()
    {
        switch (input)
        {
            case InputScheme.arrowKeys:

                //Handle Movement for the arrow keys
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    motor.Move(data.moveSpeed);
                }

                else if (Input.GetKey(KeyCode.DownArrow))
                {
                    motor.Move(-data.moveSpeed);
                }

                else
                {
                    motor.Move(0);
                }

                //Handle rotation for the arrow keys
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    motor.Rotate(data.rotateSpeed);
                }

                else if (Input.GetKey(KeyCode.LeftArrow))
                {
                    motor.Rotate(-data.rotateSpeed);
                }

                else
                {
                    motor.Move(0);
                }

                break;

            case InputScheme.WASD:

                //Handle movement for WASD
                if (Input.GetKey(KeyCode.W))
                {
                    motor.Move(data.moveSpeed);
                }

                else if (Input.GetKey(KeyCode.S))
                {
                    motor.Move(-data.moveSpeed);
                }

                else
                {
                    motor.Move(0);
                }

                //Handle rotation for WASD
                if (Input.GetKey(KeyCode.D))
                {
                    motor.Rotate(data.rotateSpeed);
                }

                else if (Input.GetKey(KeyCode.A))
                {
                    motor.Rotate(-data.rotateSpeed);
                }

                else
                {
                    motor.Move(0);
                }

                break;

            default:
                Debug.LogError("[InputManager] Undefined input scheme");
                break;
        }
    }
}
