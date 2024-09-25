using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    int intCurrentSceneIndex;
    int intLastSceneIndex;

    private void Awake()
    {
        intCurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        intLastSceneIndex = SceneManager.sceneCountInBuildSettings;
    }

    private void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "End")
        {
            LoadNextScene();
        }
    }
    void LoadNextScene()
    {
        intCurrentSceneIndex++;
        Debug.Log(intCurrentSceneIndex);
        Debug.Log(intLastSceneIndex);
        if (intCurrentSceneIndex < intLastSceneIndex)
        {
            SceneManager.LoadScene(intCurrentSceneIndex);
        }
        else
        {
            intCurrentSceneIndex = 0;
            SceneManager.LoadScene(intCurrentSceneIndex);
        }
    }
}
