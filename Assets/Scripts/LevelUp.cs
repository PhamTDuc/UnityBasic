using UnityEngine;

public class LevelUp : MonoBehaviour
{
    private GameManager gameManager;
    void Start()
    {
    	gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    void OnTriggerEnter()
    {
    	gameManager.LevelUp();
    }
}
