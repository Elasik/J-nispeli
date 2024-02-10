using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip endSound, osumaSound, pisteSound;
    static AudioSource audioSrc;


    // Start is called before the first frame update
    void Start()
    {
        endSound = Resources.Load<AudioClip>("end");
        osumaSound = Resources.Load<AudioClip>("osuma");
        pisteSound = Resources.Load<AudioClip>("piste");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
        public static void PlaySound (string clip)
        {
            switch (clip)
            {
                case "end":
                    audioSrc.PlayOneShot(endSound);
                break;
            case "osuma":
                audioSrc.PlayOneShot(osumaSound);
                break;
            case "piste":
                audioSrc.PlayOneShot(pisteSound);
                break;

        }
        }
    } 
