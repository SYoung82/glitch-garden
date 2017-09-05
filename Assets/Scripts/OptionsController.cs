using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {
	public Slider volumeSlider;
	public Slider difficultySlider;
	public LevelManager levelManager;
	private MusicManager musicManager;

	void Start() {
		musicManager = GameObject.FindObjectOfType<MusicManager>();
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
		difficultySlider.value = PlayerPrefsManager.GetDifficulty();
	}

	void Update() {
		musicManager.ChangeVolume(volumeSlider.value);
	}

	public void SaveAndExit() {
		PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
		PlayerPrefsManager.SetDifficulty(difficultySlider.value);
		levelManager.LoadLevel("01a Start");
	}

	public void ExitWithoutSave() {
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
		difficultySlider.value = PlayerPrefsManager.GetDifficulty();
		levelManager.LoadLevel("01a Start");
	}

	public void Defaults() {
		PlayerPrefsManager.SetMasterVolume(0.5f);
		PlayerPrefsManager.SetDifficulty(2f);
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
		difficultySlider.value = PlayerPrefsManager.GetDifficulty();
	}
}
