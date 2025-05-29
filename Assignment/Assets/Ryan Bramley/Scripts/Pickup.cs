using UnityEngine;

public class Pickup : MonoBehaviour
{
    GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        // Debug checks
        if (gameManager == null)
        {
            Debug.LogError("GameManager not found! Make sure GameObject has 'GameManager' tag.");
        }
        else
        {
            Debug.Log("GameManager connected successfully!");
        }
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider otherObject)
    {
        Debug.Log("Something entered trigger: " + otherObject.name + " with tag: " + otherObject.tag);

        if (otherObject.transform.tag == "Player")
        {
            Debug.Log("Player detected!");
            gameManager.currentPickups += 1;
            Debug.Log("Pickups now: " + gameManager.currentPickups);
            Destroy(this.gameObject);
        }
    }
}