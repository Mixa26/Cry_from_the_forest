using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Slider slider;
    public AudioSource menuMusic;

    private void Start()
    {
        menuMusic.GetComponent<AudioSource>().Play();    
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ChangeSensitivity()
    {
        PlayerPrefs.SetFloat("sensitivity", slider.value);
    }
}
