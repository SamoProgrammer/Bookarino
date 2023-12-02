using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnswerController : MonoBehaviour
{
    public List<Button> buttons;
    
    
    public void ValidateAnswer(string numbers)
    {
        int userAnswer = int.Parse(numbers.Split(" ")[0]);
        Debug.Log(userAnswer);
        int correctAnswerIndex = int.Parse(numbers.Split(" ")[1]);
        Debug.Log(correctAnswerIndex);
        if (userAnswer == correctAnswerIndex)
        {
            buttons[correctAnswerIndex].image.color = Color.green;
        }
        else
        {
            buttons[correctAnswerIndex].image.color = Color.green;
            buttons[userAnswer].image.color = Color.red;
        }

        foreach (var button in buttons)
        {
            button.interactable = false;
        }

        StartCoroutine(Waiter());
    }
    
    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(2);
    
        SceneManager.LoadScene("Scenes/Levels/LevelMenuScene");
    }
    
}