using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLogic : MonoBehaviour {

	public GameObject menuPanel;
	public GameObject howToPanel;
	public GameObject creditsPanel;

	// Use this for initialization
	void Start () {
		menuPanel.SetActive(true);
		howToPanel.SetActive(false);
		creditsPanel.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartGameClicked(){
		Application.LoadLevel(0);

	}

	public void HowToClicked(){
		howToPanel.SetActive(true);
		menuPanel.SetActive(false);
		creditsPanel.SetActive(false);
	}

	public void CreditsClicked(){
		creditsPanel.SetActive(true);
		menuPanel.SetActive(false);
		howToPanel.SetActive(false);
	}

	public void QuitGameClick(){
		Application.Quit();
	}

	public void BackToMenuClicked(){
		menuPanel.SetActive(true);
		howToPanel.SetActive(false);
		creditsPanel.SetActive(false);
	}
}
