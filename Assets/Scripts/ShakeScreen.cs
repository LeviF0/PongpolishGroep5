using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class ShakeScreen : MonoBehaviour
{
    public bool start = false;
    public float duration = 2f;
    Camera camera;
    GameObject ball;
    Vector3 initailPosition;
    Transform target;


    private void Start()
    {
        camera = Camera.main;
        target = Camera.main.transform;
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
    void OnTriggerEnter2D(Collider2D other)
    {
        camera = Camera.main;
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

    /*IEnumerator*/
    IEnumerator Shaking()
    {
        //make it when I hit a key the screen shakes
        //IEnumerator Shaking()
        float startTime = Time.realtimeSinceStartup;

        //Vector3 startPosition = transform.position; // this is the position of the camera
        //float elapsedTime = 0f; // this is the timer

        while (Time.realtimeSinceStartup < startTime + duration) // this is the duration of the shake
        {
            Vector3 randomPosition = new Vector3(Random.Range(5f, -5f), Random.Range(5f, -5f), initailPosition.z = -0.5f);
            target.localPosition = randomPosition;
            //elapsedTime += Time.deltaTime; // this is the timer
            //transform.position = startPosition + Random.insideUnitSphere; // this is the shake
            yield return null; // this is the return
        }
        target.localPosition = initailPosition;
        //transform.position = startPosition; // this is the end of the shake
    }
}
