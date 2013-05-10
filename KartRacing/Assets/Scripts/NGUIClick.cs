using UnityEngine;
using System.Collections;

public class NGUIClick : MonoBehaviour {

	void OnClick(){
		
		switch(GameState.gameScreen){
			
			case GameScreen.MainMenu:
				
				GameState.gameScreen= GameScreen.MainGame;
				Application.LoadLevel("Game");
				break;
			
			case GameScreen.MainGame:
				
				GameState.gameScreen= GameScreen.GameOver;
				Application.LoadLevel("GameOver");
				break;
			
			case GameScreen.GameOver:
				
				GameState.gameScreen= GameScreen.MainMenu;
				Application.LoadLevel("MainMenu");
				break;
		}
		
		
	}
}
