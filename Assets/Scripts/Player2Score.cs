using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player2Score : MonoBehaviour
{



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Text>().text = "High score: " + Player.highScore.ToString();




    }
}
