using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public TextMeshProUGUI text;
    public void Update()
    {
      text.text = "Score: " + score;  

    }   
}
