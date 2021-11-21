using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNat : MonoBehaviour
{


    public GameObject Player;
    private bool triggerActive = false;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = false;
        }
    }

    private void Update()
    {
        if (triggerActive = true && Input.GetKeyUp(KeyCode.Return))
        {
            Player.transform.position = new Vector3(2.57f, -3.196578f, 0f);

        }
    }
}
