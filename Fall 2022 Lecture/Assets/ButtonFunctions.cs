using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void GoToInstructions()
    {
        SceneManager.LoadScene("instructions");

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("menu");
    }
}
