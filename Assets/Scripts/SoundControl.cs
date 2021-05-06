using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public static AudioClip Jump;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        Jump = Resources.Load<AudioClip>("jump");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Jump":
                audioSrc.PlayOneShot(Jump);
                break;
        }
    }
}
