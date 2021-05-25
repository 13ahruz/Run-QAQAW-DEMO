using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassScore : MonoBehaviour

    
{
   
    public static int myScore = 0;
    

    



    private void Awake()
    {
        
        
     }



    
    void Start()
    {


        
        


        








}

    
    void Update()
    {
        GetComponent<Text>().text = myScore.ToString();
    }


    public static void ScoreUp()
    {
        myScore++;
    }

}
