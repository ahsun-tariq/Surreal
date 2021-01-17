using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Script is used to collect items
 * (a magical staff in this case)
 * and also determines quest completion
 * Author: Ahsun Tariq
 * Date: 5/02/2018  
 * Version: 1.0
 * 
 * 
 */
public class staffScript : MonoBehaviour {

    //Boolean variable to find if quest has been completed.
    //Static so that we may access it anywhere without instantiating the class
    public static bool QuestCompleted = false;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		 
	}

    private void OnTriggerEnter(Collider item)
    {
        //Check tag if collider is player
        if (item.gameObject.tag == "Player") {
            //Display text message that quest has been completed.
            //item.GetComponent<TextScript>().myText.text = "Completed! ";
            //Set quest completion variable to true
            QuestCompleted = true;
            //Remove object
            Destroy(gameObject);
            

            
        }
    }
}
