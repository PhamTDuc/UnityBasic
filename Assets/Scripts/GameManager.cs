using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	private bool is_running = true;
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

    public void EndGame()
    {
    	if(is_running)
    	{
    		is_running = false;
    		Debug.Log("Game Over!!!");
    		Invoke("Restart", restartDelay);
    	}
    }

    private void Restart()
    {
    	// SceneManager.LoadScene("SampleScene");
    	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public bool isRunning()
    {
    	return is_running;
    }
}
