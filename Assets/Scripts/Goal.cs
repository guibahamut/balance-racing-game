using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D colInfo)
    {
        if (colInfo.CompareTag("Player"))
        {
            Debug.Log("GAME WON! :D");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
