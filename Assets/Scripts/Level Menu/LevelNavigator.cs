using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelNavigator : MonoBehaviour
{
    public void NavigateToLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
