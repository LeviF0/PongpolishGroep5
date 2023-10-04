using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPlacer : MonoBehaviour
{
    GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = FindObjectOfType<BallMovement>().gameObject;
        ball.AddComponent<GoalExplosion>();
    }
}
