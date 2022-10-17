using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	public void PlayGame () {
		SceneManager.LoadScene ("Level1");
	}

	public void ExitGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
	}

} // MainMenuController