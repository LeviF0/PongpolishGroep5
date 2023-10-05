using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSet : MonoBehaviour
{
    GameObject ball;
    GameObject mainCamera;

    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Player");
        //mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        ball.AddComponent<ShakeScreen>();
        //mainCamera.AddComponent<ShakeScreen>();
    }
}
