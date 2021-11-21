using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ToSK : MonoBehaviour
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
        if (triggerActive=true && Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Scheikunde");
            Debug.Log("Next");
            Player.transform.position = new Vector3(2.9f, 4.019197f, 0f);
        }
    }

}