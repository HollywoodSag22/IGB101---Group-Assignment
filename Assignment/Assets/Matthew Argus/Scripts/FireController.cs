using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireController : MonoBehaviour
{
    GameManager gameManager;
    public GameObject[] fireObjects;
    public GameObject sunObject;
    public GameObject door;

    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.transform.tag == "Pickup")
        {
            if (gameManager.currentPickups <= 4)
            {
                fireObjects[gameManager.currentPickups - 1].SetActive(true);
            }
            
            if (gameManager.currentPickups == 5)
            {

                sunObject.SetActive(true);
                door.SetActive(false);
            }
        }
    }

}
