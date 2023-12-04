using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endTrigger : MonoBehaviour
{
    public GameObject endRun;
    public GameObject character;
    [SerializeField] private Light spotLight;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            character.SetActive(true);
            endRun.SetActive(true);
            spotLight.enabled = false;
        }
    }
}
