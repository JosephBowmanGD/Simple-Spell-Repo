using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucontroller : MonoBehaviour


{
    public string sportscene;
    public string spacescene;
    public string gardenscene;
    public string fooddrinkscene;



    // Start is called before the first frame update
    public void playgamesport()
    {
        SceneManager.LoadScene(sportscene);
    }

    public void playgamespace()
    {
        SceneManager.LoadScene(spacescene);
    }

    public void playgamegarden()
    {
        SceneManager.LoadScene(gardenscene);
    }


    public void playgamefooddrinks()
    {
        SceneManager.LoadScene(fooddrinkscene);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
