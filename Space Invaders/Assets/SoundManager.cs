using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour

{

    public static AudioClip laserSound, explosionSound, gameOverSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        laserSound = Resources.Load<AudioClip> ("laser_09");
        explosionSound = Resources.Load<AudioClip> ("explosion_23");
        gameOverSound = Resources.Load<AudioClip> ("game_over_04");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip) {
        switch (clip) {
            case "laser":
                audioSrc.PlayOneShot(laserSound);
                break;
            case "explosion":
                audioSrc.PlayOneShot(explosionSound);
                break;
            case "gameOver":
                audioSrc.PlayOneShot(gameOverSound);
                break;
        }
    }
}
