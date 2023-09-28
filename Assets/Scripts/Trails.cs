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
        trailRenderer.material = new Material(Shader.Find("Sprites/Default"));
        gradient.SetKeys(
            new GradientColorKey[] { new GradientColorKey(Color.red, 0.0f), new GradientColorKey(Color.black, 5.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 5.0f) }
        );
        trailRenderer.time = .6f;
        trailRenderer.startWidth = .5f;
        trailRenderer.endWidth = 0f;

        print(trailRenderer.colorGradient + " + " + gradient);

    }

    private void Update()
    {
        trailRenderer.colorGradient = gradient;

    }
}
