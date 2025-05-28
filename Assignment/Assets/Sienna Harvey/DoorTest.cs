using UnityEngine;

public class DoorTest : MonoBehaviour
{
    public Animation animation;

    // Use this for initialization
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
            animation.Play();
    }

}
