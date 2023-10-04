using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPlacer : MonoBehaviour
{
    GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball").GetComponent<GameObject>();
        ball = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (ball != null)
        {
            print("ja");
        }
        else
        {
            print("nee");
        }
    }
}
