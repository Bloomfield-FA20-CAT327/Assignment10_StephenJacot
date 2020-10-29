using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class RedColorDetector : MonoBehaviour
{
    GameControllerScript gc;
    private AudioSource source;
    public AudioClip guitar;

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
        var cuberenderer = this.gameObject.GetComponent<Renderer>();
        GameControllerScript gc = GameObject.FindWithTag("GameController").GetComponent<GameControllerScript>();
        if(other.gameObject.tag == "Player")
        {
            this.gameObject.GetComponent<Renderer>().material.SetColor("Red", Color.red);

            if(cuberenderer.material.HasProperty("Red"))
            {
                source.PlayOneShot(guitar);
            }
            
        }

        
        
        
    }
}
