using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;



public class GameControllerScript : MonoBehaviour
{
    private AudioMixer audioMixer;

    float sound;

    private int colorArrayNum = 2;
    public static GameObject[] colorObjects;

    private Slider masterVolumeSlider;





    //Question how do I get the renderer of multiple gameobjects in an array?
    //Also, how would I go about setting each one of those objects to a string name and set its color?

    void Awake()
    {


        audioMixer = Resources.Load("Audio/GameAudioMixer") as AudioMixer;

        masterVolumeSlider = GameObject.Find("MasterVolumeSlider").GetComponent<Slider>();

       
        
    }

    void Start()
    {
        colorObjects = new GameObject[colorArrayNum];

        colorObjects = GameObject.FindGameObjectsWithTag("Red");

        masterVolumeSlider.value = sound;

        audioMixer.GetFloat("SoundVolume", out sound);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }

        if(Input.GetKeyUp(KeyCode.F2))
        {
            audioMixer.SetFloat("masterVolume", sound + 5.0f);
        }

    }


    public void SetColor()
    {

        var cubeRenderer = colorObjects[0].GetComponent<Renderer>();

        if (colorObjects[0].tag == "Red")
        {


            cubeRenderer.material.SetColor("Red", Color.red);

            Debug.Log("I'm red");


        }

        if (cubeRenderer.material.HasProperty("Red"))
        {
            
            
        }
        
    }

    public void redSetVolume()
    {
        audioMixer.SetFloat("SoundVolume", sound + 10.0f);
    }



}
