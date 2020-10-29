using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMenu : MonoBehaviour
{

    private Text text;
    void Start()
    {
        text = GameObject.Find("DoorText").GetComponent<Text>();

        text.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        text.enabled = true;
    }





}
