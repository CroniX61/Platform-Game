using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class menuController : MonoBehaviour {

    public Button Play;
    public Button Quit;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       
	}
    public void Play_Game()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit_Game()
    {
        Application.Quit();
    }
}
