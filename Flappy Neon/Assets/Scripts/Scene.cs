using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene : MonoBehaviour
{

    public GameObject musicOff;
    public GameObject soundOff;



    private void Start()
    {


        if (PlayerPrefs.GetString("music") == "No" && SceneManager.GetActiveScene().buildIndex == 0)
            musicOff.SetActive(true);
        else if(SceneManager.GetActiveScene().buildIndex == 0)
            GameObject.FindGameObjectWithTag("soundtrack").GetComponent<MusicClass>().PlayMusic();

        if (PlayerPrefs.GetString("sound") == "No" && SceneManager.GetActiveScene().buildIndex == 0)
            soundOff.SetActive(true);

    


    }
    public void Restartlevel()

    {
        if (PlayerPrefs.GetString("sound") == "Yes")
            GetComponent<AudioSource>().Play();

        SceneManager.LoadScene(1);
    }

    public void LoadYoutube()
    {
        if (PlayerPrefs.GetString("sound") == "Yes")
            GetComponent<AudioSource>().Play();
        Application.OpenURL("https://www.youtube.com/channel/UCbaKHp8FCfmidHy8GoBM7nQ");
    }

    public void ChangeScene(int numberScene)
    {
        if (PlayerPrefs.GetString("sound") == "Yes")
            GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(numberScene);
    }

    public void Exit()
    {
        if (PlayerPrefs.GetString("sound") == "Yes")
            GetComponent<AudioSource>().Play();
            
        Application.Quit();
    }

    public void Home() 
    {
        if (PlayerPrefs.GetString("sound") == "Yes")
            GetComponent<AudioSource>().Play();
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void MusicWork() 
    {
        if (PlayerPrefs.GetString("music") == "No")
        {
            GameObject.FindGameObjectWithTag("soundtrack").GetComponent<MusicClass>().PlayMusic();
            PlayerPrefs.SetString("music", "Yes");
            musicOff.SetActive(false);
        }
        else
        {
            GameObject.FindGameObjectWithTag("soundtrack").GetComponent<MusicClass>().StopMusic();
            PlayerPrefs.SetString("music", "No");
            musicOff.SetActive(true);



        }
    }
    public void SoundWork()
    {
        if (PlayerPrefs.GetString("sound") == "No")
        {
            GetComponent<AudioSource>().Play();
            PlayerPrefs.SetString("sound", "Yes");
            soundOff.SetActive(false);
        }
        else
        {
            PlayerPrefs.SetString("sound", "No");
            soundOff.SetActive(true);



        }
    }
}
