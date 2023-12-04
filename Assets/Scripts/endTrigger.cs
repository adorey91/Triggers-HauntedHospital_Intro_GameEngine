using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endTrigger : MonoBehaviour
{
    public GameObject endRun;
    [SerializeField] private Light spotLight;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            endRun.SetActive(true);
            spotLight.enabled = false;
        }
    }
}
