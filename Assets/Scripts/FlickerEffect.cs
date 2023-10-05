using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerEffect : MonoBehaviour
{
    protected Renderer rend;
    private Color startColor;
    private Color afterColor = Color.white;
    private float transition = 2.0f;

    protected virtual void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    protected virtual void Update()
    {
        if (rend == null)
        {
            return;
        }

        float t = (Time.time / transition) % 1.0f;
        rend.material.color = Color.Lerp(startColor, afterColor, t);

        if (t >= 1.0f)
        {
            Destroy(this);
        }
    }
}
