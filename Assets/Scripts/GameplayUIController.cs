using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayUIController : MonoBehaviour
{

    public void RestartGame() {
        //SceneManager.LoadScene("Gameplay");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PassScore.myScore = 0;
    }

    public void HomeButton() {
        SceneManager.LoadScene("MainMenu");
        PassScore.myScore = 0;
    }

}
