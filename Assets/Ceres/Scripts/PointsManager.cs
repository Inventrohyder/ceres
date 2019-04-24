using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PointsManager : MonoBehaviour
{
    // Access the text game object storing the points of the player
    public Text pointsText;

    // Store the value of points already earned
    private int points;

    // Waypoints gameobject
    public GameObject waypoints;

    // Record the time of the click
    private float starting_time;

    // Seconds to pause the game
    private int pausePeriod = 5;

    // Access the Event system
    GameObject eventSystem;

    // Start is called before the first frame update
    void Start()
    {
        // Initiate the number of points
        points = 0;
        // Move the starting time back so that it doesn't run the first time
        starting_time = Time.time - pausePeriod;

        // Initialize the event system variable
        eventSystem = GameObject.Find("GvrEventSystem");
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time < starting_time + pausePeriod)
        {
            // Remove waypoints
            waypoints.SetActive(false);

            // Make the counting timer pause
            eventSystem.GetComponent<TimeKeeper>().wait = false;
        } else
        {
            // Bring back the waypoints
            waypoints.SetActive(true);

            // Make the counting timer continue
            eventSystem.GetComponent<TimeKeeper>().wait = true;
        }
    }


    public void AddPoint(GameObject clickeObject)
    {
        // Increase points by 1
        points++;
        // Update the shown points
        pointsText.text = points.ToString();

        // Set starting time to the time of the click
        starting_time = Time.time;

        // Access this game object's animator and turn it on
        Animator spinoffAnimator = clickeObject.GetComponent<Animator>();
        spinoffAnimator.enabled = true;
        
    }
}
