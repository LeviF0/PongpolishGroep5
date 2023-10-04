using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalExplosion : MonoBehaviour
{
    [SerializeField] Camera mainCam;
    float ballSize = 2;
    float ballColor = 135f;
    SpriteRenderer SpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = FindObjectOfType<Camera>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "BoundLeft")
        {
            StartCoroutine(Explosion());
        }
        if (collision.gameObject.tag == "BoundRight")
        {
            StartCoroutine(Explosion());
        }
    }

    IEnumerator Explosion()
    {
        
        for (int i = 0; i <= 18; i++)
        {
            ballColor -= 5;
            ballSize = ballSize + 0.3f;
            SpriteRenderer.color = new Color(255f / 225f, ballColor / 225f, 0f / 225f);
            transform.localScale = new Vector3(ballSize, ballSize, 2);
            mainCam.backgroundColor = new Color(255f/225f, 135f/225f, 0f/225f);
            yield return new WaitForSeconds(0.05f);
            mainCam.backgroundColor = Color.black;
            ballSize = ballSize + 0.3f;
            ballColor -= 5;
            yield return new WaitForSeconds(0.05f);
            print(i);
        }

        SpriteRenderer.color = Color.white;
        ballColor = 135f;
        ballSize = 2;
        transform.localScale = new Vector3(2, 2, 2);
        StopCoroutine(Explosion());
    }
}
 