using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class timelineTrigger_heartbeat : MonoBehaviour
{
    public PlayableDirector timeline;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            timeline.Play();

            }
        }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timeline.Stop();
        }
    }
}
