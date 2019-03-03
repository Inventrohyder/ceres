using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkObject : MonoBehaviour
{
    public void activate(GameObject gameObject)
    {
        GameObject[] spinoffs = GameObject.FindGameObjectsWithTag("spinoff");
        foreach (GameObject spinoff in spinoffs)
        {
            Debug.Log(spinoff.name);
            spinoff.transform.localScale = new Vector3(0, 0, 0);
        }

        gameObject.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
    }
}
