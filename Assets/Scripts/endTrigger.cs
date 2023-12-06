using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class endTrigger : MonoBehaviour
{
    public GameObject endPanel;
    public GameObject idol;
    public Camera playerCamera;
    public Camera endCamera;
    public GameObject flashlight;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            flashlight.SetActive(false);
            endPanel.SetActive(true);
            idol.SetActive(true);
            playerCamera.enabled = false;
            endCamera.enabled = true;
        }
    }
}

