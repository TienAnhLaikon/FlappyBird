using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
public void PlayButton()
    {
        SceneManager.LoadScene(1); // 0 is main menu and 1 is the game
    }
}
