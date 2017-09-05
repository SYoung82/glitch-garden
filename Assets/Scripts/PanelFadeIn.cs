using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelFadeIn : MonoBehaviour {
	public float fadeInTime;
	private Image fadePanel;

	void Start () {
		fadePanel = GameObject.Find("Fade Panel").GetComponent<Image>();
		fadePanel.CrossFadeAlpha(0f, fadeInTime, false);
	}
}
