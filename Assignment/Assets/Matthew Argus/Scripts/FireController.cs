using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireController : MonoBehaviour
{
    GameManager gameManager;
    public GameObject[] fireObjects;
    public GameObject sunObject;

    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.transform.tag == "Pickup")
        {
            fireObjects[gameManager.currentPickups -1].SetActive(true);
            if (gameManager.currentPickups == 4)
            {
                sunObject.SetActive(true);
            }
        }
    }

}
