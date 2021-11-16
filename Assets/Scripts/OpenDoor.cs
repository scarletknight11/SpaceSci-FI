using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    [SerializeField] private string doorOpen = "Doorrightopen";
    [SerializeField] private string doorClose = "DoorClose2";


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(!openTrigger)
            {
                myDoor.Play(doorOpen, 0, 1.0f);
                this.gameObject.SetActive(false);
            }

            else if (closeTrigger)
            {
                myDoor.Play(doorClose, 0, 1.0f);
                this.gameObject.SetActive(false);
            }
        } 
    }

}
