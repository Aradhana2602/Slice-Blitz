
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        // Get the current active scene
        Scene currentScene = SceneManager.GetActiveScene();

        // Calculate the index of the next scene in the build settings
        int nextSceneIndex = currentScene.buildIndex + 1;

        // Check if the next scene index is within the valid range
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            // Load the next scene based on the build index
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            // Handle the case where there is no next scene (end of build index)
            Debug.LogWarning("No next scene available. End of build index.");
        }
    }
}
