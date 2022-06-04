using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevel : MonoBehaviour
{
    private Scene _scene;

    private void Awake()
    {
        _scene = SceneManager.GetActiveScene();   //caching
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(_scene.buildIndex + 1);
            //SceneManager.LoadScene(SceneIndex);
        }
    }

    public void StartLevel()
    {
        SceneManager.LoadScene(_scene.buildIndex + 1);
    }

    public void Options()
    {
        SceneManager.LoadScene(_scene.buildIndex + 6);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(_scene.buildIndex - 6);
    }
    //public void TryAgain()
    //{
    //    SceneManager.LoadScene(_scene.buildIndex - 5);
    //}
    //public void PlayAgain()
    //{
    //    SceneManager.LoadScene(_scene.buildIndex - 4);
    //}
}
