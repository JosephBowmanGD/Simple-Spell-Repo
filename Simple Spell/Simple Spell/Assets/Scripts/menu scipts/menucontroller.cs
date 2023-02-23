using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucontroller : MonoBehaviour


{
    public string sportsscene;
    public string spacescene;
    public string gardenscene;
    public string fooddrinkscene;



    // Start is called before the first frame update

    public void GoToMainMenu()
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

    public void playgamefooddrinksgrade2()
    {
        SceneManager.LoadScene(1);
    }

    public void playgamefooddrinksgrade3()
    {
        SceneManager.LoadScene(9);
    }

    public void playgamefooddrinksgrade4()
    {
        SceneManager.LoadScene(10);
    }

    public void playgamenaturegrade2()
    {
        SceneManager.LoadScene(11);
    }

    public void playgamenaturegrade3()
    {
        SceneManager.LoadScene(2);
    }

    public void playgamenaturegrade4()
    {
        SceneManager.LoadScene(12);
    }

    public void playgamespacegrade2()
    {
        SceneManager.LoadScene(3);
    }

    public void playgamespacegrade3()
    {
        SceneManager.LoadScene(14);
    }

    public void playgamespacegrade4()
    {
        SceneManager.LoadScene(13);
    }

    public void playgamesportgrade2()
    {
        SceneManager.LoadScene(4);
    }

    public void playgamesportgrade3()
    {
        SceneManager.LoadScene(15);
    }

    public void playgamesportgrade4()
    {
        SceneManager.LoadScene(16);
    }







    public void exitGame()
    {
        Application.Quit();
    }
}
