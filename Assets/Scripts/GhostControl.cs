using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostControl : MonoBehaviour
{
    public bool playerEntered;
    public float speed = 1;

    public float upperLimit;

    void Update()
    {
        if(playerEntered)
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
            if (transform.position.y > upperLimit)
                Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            playerEntered = true;
            SoundManager.Instance.PlaySound(SoundManager.Instance.ghostEntry);
        }
    }
}
