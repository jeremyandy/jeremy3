using UnityEngine;
using System.Collections;

public class NGUI : MonoBehaviour {
	
	UILabel scoreLabel;
	UILabel lifeLabel;
	//UILabel hiScoreLabel;

	GameObject gameOverBG;
	
	

	void Start () {
				
		scoreLabel= GameObject.Find ("ScoreptsLabel").GetComponent<UILabel>();
		lifeLabel= GameObject.Find ("LifeptsLabel").GetComponent<UILabel>();
		//hiScoreLabel= GameObject.Find ("HiScoreptsLabel").GetComponent<UILabel>();
		gameOverBG= GameObject.Find ("GameOverBG");
		//hiScoreLabel.text = StaticVar.hiScore.ToString();
	}
	
	
	void Update () {
		scoreLabel.text = GameManager.score.ToString();
		lifeLabel.text = GameManager.lives.ToString();
	}
	
	public void GameOver(){
		StartCoroutine(GameOverDelay());
	}
	
	IEnumerator GameOverDelay(){
		yield return new WaitForSeconds(1.0f);
		iTween.MoveTo(gameOverBG, new Vector3(0,-5.5f,-1), 1.0f);
		yield return new WaitForSeconds(1f);
		Application.LoadLevel("GameOver");
		
	}
}
