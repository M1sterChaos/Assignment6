using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;

    private string CurrentLevelName = string.Empty;

    #region
    public static GameManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            Debug.LogError("Trying to instance a second GameManager");
        }
    }
    #endregion

    public void LoadLevel(string name)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive);

        if(ao == null)
        {
            Debug.LogError("GameManager unable to load level " + name);
            return;
        }
        CurrentLevelName = name;
    }
    public void UnloadLevel(string name)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(name);

        if (ao == null)
        {
            Debug.LogError("GameManager unable to unload level " + name);
            return;
        }
        CurrentLevelName = name;
    }

    public void GamePause()
    {
        Time.timeScale = 0f;
    }
    public void UnPause()
    {
        Time.timeScale = 1f;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            GamePause();
        }
    }
}

