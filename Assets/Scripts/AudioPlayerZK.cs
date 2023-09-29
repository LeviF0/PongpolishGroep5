using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class AudioPlayerZK : MonoBehaviour
{

    AudioClip clip1; AudioClip clip2;
    AudioClip clip3; AudioClip clip4;
    AudioClip clip5; AudioClip clip6;
    AudioClip clip7; AudioClip clip8; 
    AudioClip clip9; AudioClip clip10;

    AudioSource source;
    PlayerMovement playerMov;
    float ogPlayerMov;
    void Start()
    {
        
        clip1 = Resources.Load<AudioClip>("Audio/collision1"); //teveel audio i know
        clip2 = Resources.Load<AudioClip>("Audio/eminem");
        clip3 = Resources.Load<AudioClip>("Audio/albanian");
        clip4 = Resources.Load<AudioClip>("Audio/khaled");
        clip5 = Resources.Load<AudioClip>("Audio/obama");
        clip6 = Resources.Load<AudioClip>("Audio/putin");
        clip7 = Resources.Load<AudioClip>("Audio/skibidi");
        clip8 = Resources.Load<AudioClip>("Audio/xmas");
        clip9 = Resources.Load<AudioClip>("Audio/bbq");
        clip10 = Resources.Load<AudioClip>("Audio/HappyWorld");

        playerMov = FindObjectOfType<PlayerMovement>();
        source = gameObject.AddComponent<AudioSource>();
        ogPlayerMov = playerMov.playerSpeed;
    }

    public void Update()
    {
        if (source.isPlaying)
        {
            return;
        }

        else
        {
            source.PlayOneShot(clip10);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioClip[] a_Audio = { clip1, clip2, clip3, clip4, clip5, clip6, clip7, clip8, clip9 };
        if (collision.gameObject.tag == "PlayerRight" || collision.gameObject.tag == "PlayerLeft")
        {
            source.Stop();
            int rdIndex = Random.Range(0, a_Audio.Length);

            MovBoostDur(6f);

            source.PlayOneShot(a_Audio[rdIndex]);
        }
    }

    public IEnumerator MovBoostDur(float _duration)
    {
        int rdSpeedBoost = Random.Range(0, 6);

        if (rdSpeedBoost == 5)
        {
            playerMov.playerSpeed *= 30;
            yield return new WaitForSeconds(_duration);
            playerMov.playerSpeed = ogPlayerMov;
        }

        else { yield return new WaitForSeconds(0f); }
    }
}
