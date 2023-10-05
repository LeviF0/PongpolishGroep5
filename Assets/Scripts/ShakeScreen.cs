using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class ShakeScreen : MonoBehaviour
{
    public bool start = false;
    public float duration = 1f;
    Camera camera;
    GameObject ball;

    private void Start()
    {
        camera = Camera.main;
        ball = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BoundLeft"))
        {
            print("hsuiovf");
            StartCoroutine(Shaking());
        }
        else if (other.gameObject.CompareTag("BoundRight"))
        {
            print("uivhfboa");
            StartCoroutine(Shaking());
        }
    }

    private void Update()
    {
        camera = Camera.main;
        if (start)
        {
            start = false;
            StartCoroutine(Shaking());
        }
    }


    /*IEnumerator*/
    IEnumerator Shaking()
    {
        //make it when I hit a key the screen shakes
        //IEnumerator Shaking()
        
        Vector3 startPosition = transform.position; // this is the position of the camera
        float elapsedTime = 0f; // this is the timer

        while (elapsedTime < duration) // this is the duration of the shake
        {
            elapsedTime += Time.deltaTime; // this is the timer
            transform.position = startPosition + Random.insideUnitSphere; // this is the shake
            yield return null; // this is the return
        }
        transform.position = startPosition; // this is the end of the shake
    }
}
