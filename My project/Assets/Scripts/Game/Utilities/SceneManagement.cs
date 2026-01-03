using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    public void MainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
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

}
