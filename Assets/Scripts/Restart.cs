using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {


	void Update () {
        if (Input.GetKeyDown(KeyCode.R)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKeyDown(KeyCode.M)) {
            SceneManager.LoadScene("Main");
        }
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
	}
}
