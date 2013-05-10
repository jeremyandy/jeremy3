using UnityEngine;
using System.Collections;

public class GameOverGUI : MonoBehaviour {
	GameObject bloodEffect;
	//GameObject retryButtonGO;
	GameObject backButtonGO;
	GameObject gameOverLabelGO;
	
	void Start () {
		bloodEffect= GameObject.Find ("BloodEffect");
		//retryButtonGO= GameObject.Find ("RetryButton");
		backButtonGO= GameObject.Find ("BackButton");
		gameOverLabelGO= GameObject.Find ("GameOverLabel");
		
		iTween.FadeTo(bloodEffect, .5f,2.0f);
		//iTween.ShakePosition(retryButtonGO, new Vector3(.1f, .1f, 0), 2);
		iTween.ShakePosition(backButtonGO, new Vector3(.1f, .1f, 0), 2);
		iTween.ScaleTo(gameOverLabelGO, new Vector3(56,56,1),2);
	}
	
	void Update () {
	
	}
}
