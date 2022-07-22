using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject doorObject;

    public bool canOpen = false;
    public bool isLocked = false;
    public KeyController keyObject;

    //doorObject.SetActive(false) opens the door
    //doorObject.SetActive(true) closes the door
    void Update()
    {
        if(canOpen && !isLocked)
        {
            if(Input.GetKeyDown(KeyCode.O))
            {
                if(doorObject.activeSelf)
                {
                    doorObject.SetActive(false);
                    SoundManager.Instance.PlaySound(SoundManager.Instance.doorOpen);
                }
                else
                {
                    doorObject.SetActive(true);
                    SoundManager.Instance.PlaySound(SoundManager.Instance.doorClose);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            canOpen = true;
            if (isLocked)
            {
                if (keyObject.isCollected)
                {
                    isLocked = false;
                    UIManager.Instance.SetPromptText("Press 'O' to open or close the door");
                }
                else
                {
                    UIManager.Instance.SetPromptText("Find key to unlock this door");
                }
            }
            else
            {
                UIManager.Instance.SetPromptText("Press 'O' to open or close the door");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canOpen = false;
            UIManager.Instance.SetPromptText("");
        }
    }
}
