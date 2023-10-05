using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trails : MonoBehaviour
{
    TrailRenderer trailRenderer;
    Gradient gradient;
    float alpha = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        trailRenderer = gameObject.AddComponent<TrailRenderer>();
        gradient = new Gradient();
        trailRenderer.time = .6f;
        trailRenderer.startWidth = .5f;
        trailRenderer.endWidth = 0f;
        trailRenderer.sortingOrder = -1;
        trailRenderer.material = new Material(Shader.Find("Sprites/Default"));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerLeft")
        {
            gradient.SetKeys(
            new GradientColorKey[] { new GradientColorKey(Color.blue, 0.0f), new GradientColorKey(Color.black, 5.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 5.0f) });
            trailRenderer.colorGradient = gradient;
        }
        if (collision.gameObject.tag == "PlayerRight")
        {
            gradient.SetKeys(
            new GradientColorKey[] { new GradientColorKey(Color.red, 0.0f), new GradientColorKey(Color.black, 5.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 5.0f) });
            trailRenderer.colorGradient = gradient;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BoundLeft") || other.gameObject.CompareTag("BoundRight"))
        {
            trailRenderer.enabled = false;
            StartCoroutine(ResetsTrail());
        }
    }
    IEnumerator ResetsTrail()
    {
        trailRenderer.time = 0f; 
        yield return new WaitForSeconds(2.2f);
        trailRenderer.enabled = true;
        trailRenderer.time = .6f;
        gradient.SetKeys(
        new GradientColorKey[] { new GradientColorKey(Color.white, 0.0f), new GradientColorKey(Color.black, 5.0f) },
        new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 5.0f) });
        trailRenderer.colorGradient = gradient;
    }
}
