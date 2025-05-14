using UnityEngine;
using UnityEngine.UIElements;

public class itSpins : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float spinSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }
}
