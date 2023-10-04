using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChange : MonoBehaviour
{
    Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("BoundLeft"))
        {
            mainCamera.backgroundColor = Random.ColorHSV();
        }
        if (collision.gameObject.CompareTag("BoundRight"))
        {
            mainCamera.backgroundColor = Random.ColorHSV();
        }
        if(collision.gameObject.CompareTag("Wall"))
        {
            mainCamera.backgroundColor = Random.ColorHSV();
        }
    }

    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        mainCamera.backgroundColor = Random.ColorHSV();
    //    }
        
        
    //}
}
