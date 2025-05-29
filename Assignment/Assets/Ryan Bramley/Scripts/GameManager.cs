using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        LevelCompleteCheck();
    }

    private void LevelCompleteCheck(){
        if (currentPickups >= maxPickups)
            levelComplete = true;
        else
            levelComplete = false;
    }

}
