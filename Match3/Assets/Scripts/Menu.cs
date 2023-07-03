using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartLevel(int level)
    {
        if (level == 1)
        {
            SceneManager.LoadScene("full");
        }
        else if (level == 2)
        {
            SceneManager.LoadScene("10x5");
        }
        else if (level == 3)
        {
            SceneManager.LoadScene("cutted");
        }
        else if (level == 4)
        {
            SceneManager.LoadScene("12x7");
        }
        else if (level == 0)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
