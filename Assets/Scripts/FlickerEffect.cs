using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerEffect : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer spriteRenderer;
    private bool isFlickerEnabled = false;

    void EnableFlicker()
    {
        isFlickerEnabled = true;
    }

    IEnumerator colorFlickerRoutine()
    {
        while (isFlickerEnabled == true)
        {
            spriteRenderer.color = Color.red;
            yield return new WaitForSeconds(0.8f);
            spriteRenderer.color = Color.white;
            yield return new WaitForSeconds(0.8f);
            isFlickerEnabled = false;
        }
    }
}
