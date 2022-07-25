using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public Image playButtonImage;
    public Sprite playButtonImageToSet;

    public Text progressToShow;

    void Start()
    {
        playButtonImage.sprite = playButtonImageToSet;
    }

    public void PlayGame()
    {
        StartCoroutine(PlayGameAsync());
    }

    IEnumerator PlayGameAsync()
    {
        AsyncOperation loadMyScene = SceneManager.LoadSceneAsync("Show");

        while(!loadMyScene.isDone)
        {
            Debug.Log("Game progress: " + loadMyScene.progress.ToString() + "%");
            progressToShow.text = loadMyScene.progress.ToString() + "%";
            yield return null;
        }
    }

    float GetMyNewValue()
    {
        return 0.1f;
    }

    void EmptyFunction()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
