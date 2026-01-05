using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public GameObject PauseMenu;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        if (PauseMenu.activeSelf)
        {
            Time.timeScale = 1f;
            PauseMenu.SetActive(false);
        }
        else
        {
            Time.timeScale = 0f;
            PauseMenu.SetActive(true);
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Tutorial_1_Movement()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void Tutorial_2_Juggle()
    {
        SceneManager.LoadSceneAsync(3);
    }

    public void Tutorial_3_OneBreak()
    {
        SceneManager.LoadSceneAsync(4);
    }

    public void Tutorial_4_EdgeBreaks()
    {
        SceneManager.LoadSceneAsync(5);
    }

    public void Tutorial_5_3ToBreak()
    {
        SceneManager.LoadSceneAsync(6);
    }

    public void Tutorial_6_TwhoHitOneBreak()
    {
        SceneManager.LoadSceneAsync(7);
    }

    public void Tutorial_7_Unbreakable()
    {
        SceneManager.LoadSceneAsync(8);
    }

    public void Tutorial_8_FarFromUs()
    {
        SceneManager.LoadSceneAsync(9);
    }
    
    public void Settings()
    {
        SceneManager.LoadSceneAsync(10);
    }

    public void Level_1()
    {
        SceneManager.LoadSceneAsync(11);
    }
    
    public void Level_2()
    {
        SceneManager.LoadSceneAsync(12);
    }
    
    public void Level_3()
    {
        SceneManager.LoadSceneAsync(13);
    }
    
    public void Level_4()
    {
        SceneManager.LoadSceneAsync(14);
    }
    
    public void Level_5()
    {
        SceneManager.LoadSceneAsync(15);
    }
    
    public void Level_6()
    {
        SceneManager.LoadSceneAsync(16);
    }
    
    public void Level_7()
    {
        SceneManager.LoadSceneAsync(17);
    }
    
    public void Level_8()
    {
        SceneManager.LoadSceneAsync(18);
    }
    
    public void Level_9()
    {
        SceneManager.LoadSceneAsync(19);
    }
    
    public void Level_10()
    {
        SceneManager.LoadSceneAsync(20);
    }

}
