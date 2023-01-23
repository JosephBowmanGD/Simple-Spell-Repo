using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public void playgame()
    {
        SceneManager.LoadScene("gameScene");
    }

    public void options()
    {
        SceneManager.LoadScene("optionsScene");
    }

    public void inventory()
    {
        SceneManager.LoadScene("InventoryScene");
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
