using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucontroller : MonoBehaviour
{

    // Start is called before the first frame update

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void playgamesport()
    {
        SceneManager.LoadScene(8);
    }

    public void playgamespace()
    {
        SceneManager.LoadScene(7);
    }

    public void playgamegarden()
    {
        SceneManager.LoadScene(6);
    }


    public void playgamefooddrinks()
    {
        SceneManager.LoadScene(5);
    }

    public void playgamefooddrinks2()
    {
        SceneManager.LoadScene(1);
    }

    public void playgamefooddrinks3()
    {
        SceneManager.LoadScene(10);
    }

    public void playgamefooddrinks4()
    {
        SceneManager.LoadScene(9);
    }

    public void playgamenature2()
    {
        SceneManager.LoadScene(12);
    }

    public void playgamenature3()
    {
        SceneManager.LoadScene(2);
    }

    public void playgamenature4()
    {
        SceneManager.LoadScene(11);
    }

    public void playgamespace2()
    {
        SceneManager.LoadScene(3);
    }

    public void playgamespace3()
    {
        SceneManager.LoadScene(14);
    }

    public void playgamespace4()
    {
        SceneManager.LoadScene(13);
    }

    public void playgamesport2()
    {
        SceneManager.LoadScene(4);
    }

    public void playgamesport3()
    {
        SceneManager.LoadScene(16);
    }

    public void playgamesport4()
    {
        SceneManager.LoadScene(15);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
