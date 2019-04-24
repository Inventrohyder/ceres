using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class TimeKeeper : MonoBehaviour
{
    // The Timer text game object
    public Text timerText;


    // Number of seconds a player can play the game before it ends
    public float playingTime = 30f;

    // Elapsed time
    private float time;

    // Difference between last recorded time and now
    private float nextTime;

    // If wait is on then countdown stops
    public bool wait;


    // Start is called before the first frame update
    void Start()
    {
        // Initiate our current time to 0 at the beginning
        time = playingTime;

        // Initiate wait to false
        wait = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Continue counting the time as long as it is less than the maximum
        // and it is not waiting time
        if (time > 0 && wait)
        {
            // Get the difference between the time in the last frame and now
            nextTime = Time.deltaTime;
            // Increase our current time
            time -= nextTime;
            // Show our current time rounded off
            timerText.text = Math.Round(time).ToString();
        }


    }

    void increaseFive()
    {
        time += 5;
    }
}
