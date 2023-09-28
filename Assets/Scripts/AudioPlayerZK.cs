using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayerZK : MonoBehaviour
{
    [SerializeField] AudioClip[] a_Audio;
    [SerializeField] AudioClip clip1;
    AudioSource source;
    Camera cam;
    void Start()
    {
        clip1 = Resources.Load<AudioClip>("Audio/collision1");
        source = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
