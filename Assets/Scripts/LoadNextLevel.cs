using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
   

    public void LoadLevel()
    {
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    	// Debug.Log("Load New Level");
    }
}
