using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	static public int score;
	public InputMovement inputMovement;
	static public int lives= 3;
	NGUI nGUI;
	bool isGameOver= false;
	
	void Start(){
		score=0;
		inputMovement= GameObject.FindGameObjectWithTag("Player").GetComponent<InputMovement>();
		nGUI= GameObject.FindGameObjectWithTag("MainCamera").GetComponent<NGUI>();
		lives= 3;
	}
	
	void Update(){
		score+=(int)inputMovement.scoreMultiplier;	
		if(lives<=0 && !isGameOver){
			GameOver();	
		}
		
	}
	
	public void livesUpdate(){
		lives-=1;
	}
	
	public void GameOver(){
		//if(score>StaticVar.hiScore)
			//StaticVar.hiScore=score;
		//print (StaticVar.hiScore);
		GameState.gameScreen= GameScreen.GameOver;
		nGUI.GameOver();
		isGameOver= true;
		
	}
}
