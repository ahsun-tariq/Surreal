using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine;
/*
 * Script is used to display an initial quest
 * Author: Ahsun Tariq
 * Date: 5/02/2018
 * Version: 1.0
 */
public class TextScript : MonoBehaviour {

    public Text myText;
   

	
	void Start () {
        myText.text = "Objective: Find the wizard's magic staff";
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    
}
