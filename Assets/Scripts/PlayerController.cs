using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public TankMotor motor;

    private TankData data;

    // Start is called before the first frame update
    void Start()
    {
        data = GetComponent<TankData>();
        motor = GetComponent<TankMotor>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            motor.Move(data.moveSpeed);
        }

        if(Input.GetKey(KeyCode.D))
        {
            motor.Rotate(data.rotateSpeed);
        }
    }
}
