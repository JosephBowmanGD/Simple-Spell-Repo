using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public void playgamesport()
    {
        SceneManager.LoadScene("sportgamescene");
    }

    public void playgamespace()
    {
        SceneManager.LoadScene("spacegamescene");
    }

    public void playgamegarden()
    {
        SceneManager.LoadScene("gardengamescene");
    }


    public void playgamefooddrinks()
    {
        SceneManager.LoadScene("fooddrinkgamescene");
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
