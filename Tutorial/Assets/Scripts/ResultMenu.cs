using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultMenu : MonoBehaviour
{
    public void lvl1()
    {
        SceneManager.LoadScene(1);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
        Score.score = 0;
    } 
     
    public void Lvl2()
    {
       SceneManager.LoadScene(2);
    }
    public void Lvl3()
    {
       SceneManager.LoadScene(3);
    }

}
