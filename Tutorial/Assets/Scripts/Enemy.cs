using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
     private void Start()
    {
        StartCoroutine(Logika());
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
        Score.score++; 
    }

    IEnumerator Logika()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            Destroy(gameObject);
            if (Score.score > 0)
            {
                Score.score--;
            }
        }
    }
}
