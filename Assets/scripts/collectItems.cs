using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectItems : MonoBehaviour {
    public static int count;
	// Use this for initialization
	void Start () {
        count = 0;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 90 * Time.deltaTime, 0);
		
	}


    private void OnTriggerEnter(Collider item)
    {
        //Check tag if collider is player
        if (item.gameObject.tag == "Player")
        {
            //Display text message that quest has been completed.
            //item.GetComponent<TextScript>().myText.text = "Completed! ";
            //Set quest completion variable to true
            count++;
            Debug.Log(count);
            //Remove object
            Destroy(gameObject);



        }
    }

}
