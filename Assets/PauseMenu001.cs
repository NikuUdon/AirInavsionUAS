﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu001 : MonoBehaviour {

	public static bool GameisPaused = false;
	public GameObject pauseMenuUI;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (GameisPaused) {
				Resume();
			} else {
				Pause();
			}
		}
	}

	public void Resume ()
	{
		pauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
		GameisPaused = false;
	}

	void Pause()
	{
		pauseMenuUI.SetActive (true);
		Time.timeScale = 0f;
		GameisPaused = true;
	}

	public void LoadMenu()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene ("MainMenu");
	}

	public void Saver()
	{
		PlayerPrefs.SetInt ("currentscenesave", Application.loadedLevel);
	}

	public void Loader()
	{
		Application.LoadLevel(PlayerPrefs.GetInt("currentscenesave"));
	}

	public void QUitGame()
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit(); 
		#endif
	}
}
