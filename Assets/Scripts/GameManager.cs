using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public float restartDelay = 1.0f;
    public GameObject levelCompleteUI;

    void Start()
    {
        levelCompleteUI.SetActive(false);
    }

	public void LevelUp()
	{
        levelCompleteUI.SetActive(true);
	}

    public void RestartLevel()
    {	
        Debug.Log("Game Over!!!");
    	Invoke("Restart", restartDelay);
    }

    private void Restart()
    {
    	// SceneManager.LoadScene("SampleScene");
    	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
