using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mulai : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Quit Game");
        }
        
    }
    public void kembaliKeMenu() {
        SceneManager.LoadScene("Main");
    }
    
	    public void MulaiPermainan() {
	        SceneManager.LoadScene("Game");
	    }

        public void KeluarPermainan()
        {
            Application.Quit();
            Debug.Log("Permainan Keluar");
        }
  
	   


}
