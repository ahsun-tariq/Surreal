using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


/*
 * Script is used to control a timer for timed quests
 * Author: Ahsun Tariq
 * Date: 5/02/2018
 * Version: 1.0
 */
public class Timer : MonoBehaviour {

    //Set timer to 180 seconds
    public float TimerTime = 180 ;


    public Text TimerText;

    //this scene will be reloaded if timer runs out
    private string level = "scene3";

	
	void Start () {
        
        TimerText.text = "180";
       
	}

    // Update is called once per frame
    void Update() {

      
        if (staffScript.QuestCompleted == false)
        {
            //Decrement time
            TimerTime -= Time.deltaTime;

            //Convert to string and display on UI text element
            TimerText.text = "Time Remaining: " + TimerTime.ToString("f0");

            //If timer runs out and quest (find magic staff) 
            //has not been completed then restart the level
            //Quest completion is checked by checking static
            //boolean variable of the class
            if (TimerTime < 1) {

            {
                TimerText.text = "Time Remaining: " + TimerTime.ToString("f0");
                Application.LoadLevel(level);
            }

            }
        }

        else
        {   //if player has completed the quest
            //display you won!
            
                TimerText.text = "You won!";
           
        }

        
	}
}
