using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public void SaveLevelScore(int levelNumber, int levelScore)
    {
        PlayerPrefs.SetInt(levelNumber.ToString(), levelScore);
    }
    public int GetLevelScore(int levelNumber)
    {
        return PlayerPrefs.GetInt(levelNumber.ToString());
    }
}
