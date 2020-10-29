using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicScript : MonoBehaviour
{
    private AudioSource source;
    public AudioClip guitar;
    public AudioClip bass;
    public AudioClip flute;
    public AudioClip saxophone;
    public AudioClip drums;
    public AudioClip tamborine;
    

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        switch(other.gameObject.tag)
        {
            case "Guitar" : source.PlayOneShot(guitar);

            break;

            case "Bass": source.PlayOneShot(bass);

            break;


            case "Flute": source.PlayOneShot(flute);

            break;

            case "Saxophone": source.PlayOneShot(saxophone);

            break;

            case "Drums": source.PlayOneShot(drums);

            break;

            case "Tamborine": source.PlayOneShot(tamborine);

            break;
        }

        if(source.isPlaying == guitar)
        {
            if (source.isPlaying == bass)
                bass.length.Equals(0);
        }    
    }

}
