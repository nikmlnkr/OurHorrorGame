using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    public bool canCollect = false;
    public bool isCollected;

    void Update()
    {
        if (canCollect && !isCollected)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                isCollected = true;
                UIManager.Instance.SetPromptText("");
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canCollect = true;
            UIManager.Instance.SetPromptText("Press 'E' to take the key");
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canCollect = false;
            UIManager.Instance.SetPromptText("");
        }
    }
}
