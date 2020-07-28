using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer2Example : MonoBehaviour
{
    public float timerDelay = 3.0f;
    private float nextEventTime;

    // Start is called before the first frame update
    void Start()
    {
        nextEventTime = Time.time + timerDelay;  //Time.time = number of seconds that have passed since the game started running
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextEventTime)
        {
            Debug.Log("Timer2 completed");
            nextEventTime = Time.time + timerDelay;
        }
    }
}
