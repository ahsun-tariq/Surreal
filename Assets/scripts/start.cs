using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {

    string scene = "scene3";
		
        public void startGame() {
        SceneManager.LoadScene(scene);
            



        }
	
	    public void exitGame()
    {

        Application.Quit();
    }
}
