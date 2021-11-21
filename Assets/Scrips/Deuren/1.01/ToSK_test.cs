using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToSK_test : MonoBehaviour
{

    private bool triggerActive = false;
    public GameObject Player;
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
        if (triggerActive = true && Input.GetKeyDown(KeyCode.Return))
        {
            Player.transform.position = new Vector3(3.97f, -16.5f, 0f);
        }
    }
}