using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class timelineHeartTrigger : MonoBehaviour
{
    public PlayableDirector timeline;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            timeline.Play();
        }
    }
}