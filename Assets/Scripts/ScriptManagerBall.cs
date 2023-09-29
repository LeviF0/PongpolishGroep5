using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptManagerBall : MonoBehaviour
{
    GameObject ballObj;
    AudioPlayerZK audioScript;
    void Start()
    {
        ballObj = GameObject.FindGameObjectWithTag("Player");
        audioScript = ballObj.AddComponent<AudioPlayerZK>();
    }
}
