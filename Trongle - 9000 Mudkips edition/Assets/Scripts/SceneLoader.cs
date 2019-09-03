using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [Header("Name of the scene this object needs to load.")]
    [SerializeField]
    private string SceneName;

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneName);
    }
}
