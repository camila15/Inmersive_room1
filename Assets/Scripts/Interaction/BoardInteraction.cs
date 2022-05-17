
using VRC.SDKBase;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class BoardInteraction : MonoBehaviour
{
    [SerializeField] VideoPlayer video;
    [SerializeField] BoxCollider player;
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")) video.Play();
        
    }
}
