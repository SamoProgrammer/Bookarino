using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BookNavigator : MonoBehaviour
{
    public List<GameObject> pages;
    public string questionSceneName;
    private int currentPage = 1;

    public void NavigatePage(bool next)
    {
        int lastPage = pages.Count;
        if (currentPage + 1 > lastPage && next)
        {
            SceneManager.LoadScene(questionSceneName);
        }
        else if (currentPage - 1 <= 0 && !next)
        {
        }
        else if (next)
        {
            currentPage += 1;
            foreach (var page in pages)
            {
                page.SetActive(false);
            }


            pages[currentPage - 1].SetActive(true);
        }
        else if (!next)
        {
            currentPage -= 1;
            foreach (var page in pages)
            {
                page.SetActive(false);
            }

            pages[currentPage - 1].SetActive(true);
        }
    }
}