using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TalkObject : MonoBehaviour
{
    public GameObject player;
    public void activate(GameObject gameObject)
    {
        GameObject[] spinoffs = GameObject.FindGameObjectsWithTag("spinoff");
        foreach (GameObject spinoff in spinoffs)
        {
            spinoff.transform.localScale = new Vector3(0, 0, 0);
        }

        // Access the infoDeck game object
        GameObject infoDeck = GameObject.Find("InfoDeck");

        // Set the info deck's text to that of the gameObject's child
        infoDeck.GetComponent<Text>().text = gameObject.GetComponentInChildren<Text>().text;

        // gameObject.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
    }
}
