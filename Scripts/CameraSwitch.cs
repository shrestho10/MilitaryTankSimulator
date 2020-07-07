using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{

    public GameObject cameraOne;
    public GameObject cameraTwo;
    public GameObject camerathree;
    public GameObject camera4;

    AudioListener cameraOneAudioLis;
    AudioListener cameraTwoAudioLis;
    AudioListener camerathreeAudioLis;
    AudioListener camera4AudioLis;


    // Use this for initialization
    void Start()
    {

        //Get Camera Listeners
        cameraOneAudioLis = cameraOne.GetComponent<AudioListener>();
        cameraTwoAudioLis = cameraTwo.GetComponent<AudioListener>();
        camerathreeAudioLis = camerathree.GetComponent<AudioListener>();
        camera4AudioLis = camera4.GetComponent<AudioListener>();

        //Camera Position Set
        cameraPositionChange(PlayerPrefs.GetInt("CameraPosition"));
    }

    // Update is called once per frame
    void Update()
    {
        //Change Camera Keyboard
        switchCamera();
    }

    //UI JoyStick Method
    public void cameraPositonM()
    {
        cameraChangeCounter();
    }

    //Change Camera Keyboard
    void switchCamera()
    {
        if (Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.LeftAlt) || Input.GetKeyDown(KeyCode.RightAlt))
        {
            cameraChangeCounter();
        }
    }

    //Camera Counter
    void cameraChangeCounter()
    {
        int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
        cameraPositionCounter++;
        cameraPositionChange(cameraPositionCounter);
    }

    //Camera change Logic
    void cameraPositionChange(int camPosition)
    {
        if (camPosition > 1 && camPosition < 2)
        {
            camPosition = 2;
        }
        else if(camPosition > 2 && camPosition < 3)
        {
            camPosition = 3;
        }
        else if (camPosition >3)
        {
            camPosition = 0;
        }

            //Set camera position database
            PlayerPrefs.SetInt("CameraPosition", camPosition);

        //Set camera position 1
        if (camPosition == 0)
        {
            cameraOne.SetActive(true);
            cameraOneAudioLis.enabled = true;

            cameraTwoAudioLis.enabled = false;
            cameraTwo.SetActive(false);
            camerathreeAudioLis.enabled = false;
            camerathree.SetActive(false);
            camera4AudioLis.enabled = false;
            camera4.SetActive(false);
        }

        //Set camera position 2
        if (camPosition == 1)
        {
            cameraTwo.SetActive(true);
            cameraTwoAudioLis.enabled = true;

            cameraOneAudioLis.enabled = false;
            cameraOne.SetActive(false);
            camerathreeAudioLis.enabled = false;
            camerathree.SetActive(false);
            camera4AudioLis.enabled = false;
            camera4.SetActive(false);
        }
        if (camPosition == 2)
        {
            camerathreeAudioLis.enabled = true;
            camerathree.SetActive(true);
            cameraTwo.SetActive(false);
            cameraTwoAudioLis.enabled = false;

            cameraOneAudioLis.enabled = false;
            cameraOne.SetActive(false);
            camera4AudioLis.enabled = false;
            camera4.SetActive(false);

        }
        if (camPosition == 3)
        {
            camera4AudioLis.enabled = true;
            camera4.SetActive(true);
            camerathreeAudioLis.enabled = false;
            camerathree.SetActive(false);
            cameraTwo.SetActive(false);
            cameraTwoAudioLis.enabled = false;

            cameraOneAudioLis.enabled = false;
            cameraOne.SetActive(false);
          

        }

    }
}