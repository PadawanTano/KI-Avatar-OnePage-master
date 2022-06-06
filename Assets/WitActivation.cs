using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Voice;


public class WitActivation : MonoBehaviour
{
    private AppVoiceExperience _voiceExperience;
     private void OnValidate()
     {
         if (!_voiceExperience) _voiceExperience = GetComponent<AppVoiceExperience>();
     }

     private void Start()
     {
         _voiceExperience = GetComponent<AppVoiceExperience>();
     }

     private void Update()
     {
         if (OVRInput.Get(OVRInput.Button.One))
         {
             Debug.Log("*** Pressed A ***");
             ActivateWit();
         }
     }

     /// <summary>
     /// Activates Wit i.e. start listening to the user.
     /// </summary>
     public void ActivateWit()
     {
         _voiceExperience.Activate();
     }
}
