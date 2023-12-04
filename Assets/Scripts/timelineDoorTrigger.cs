using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class timelineDoorTrigger : MonoBehaviour
{
    public PlayableDirector timeline;
    public bool OneTimeTrigger = false;
    public CharacterController _character;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _character.enabled = false;
            StartCoroutine(PlayTimelineAndEnableCharacter());
        }
    }

    private IEnumerator PlayTimelineAndEnableCharacter()
    {
        timeline.Play();

        // Wait for the duration of the timeline
        yield return new WaitForSeconds((float)timeline.duration);

        // Turn on the character controller
        _character.enabled = true;

        // Optionally, destroy the trigger object if it's a one-time trigger
        if (OneTimeTrigger)
        {
            Destroy(gameObject);
        }
    }
}