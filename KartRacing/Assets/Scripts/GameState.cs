using UnityEngine;
using System.Collections;

public enum GameScreen{
	MainMenu,
	MainGame,
	GameOver
}

public class GameState: MonoBehaviour{
	
	NGUIClick _nGUIClick;
	public GameObject gameButton;	
	public static GameScreen gameScreen= GameScreen.MainMenu;
	#region
	//public Transform[] enemyCar;
	//public Transform player;
	//public Transform carDetector;
	//public Transform carRespawnObj;
	//public Transform road1;
	//public Transform road2;
	//public Transform gameManager;
	//public Transform explosion;
	//public Transform motorcycle;
	//public Transform soundExplosion;
	#endregion
	void Awake () {
		//gameScreen= GameScreen.MainGame;
		
		switch(gameScreen){
			case GameScreen.MainMenu:
				ButtonFunction ("StartGameButton");
				Transform backgroundIMG= Instantiate(Resources.Load("BackgroundImage", typeof(Transform))) as Transform;
				Transform carImg1= Instantiate(Resources.Load("CarImg1", typeof(Transform))) as Transform;
				Transform carImg2= Instantiate(Resources.Load("CarImg2", typeof(Transform))) as Transform;
				break;
			
			case GameScreen.MainGame:
				int numOfEnemyCar= 7;

				ButtonFunction ("GameOverButton");
				Transform explosion= Instantiate(Resources.Load("Explosion", typeof(Transform))) as Transform;
				Transform road1= Instantiate(Resources.Load("Road1", typeof(Transform))) as Transform;
				Transform road2= Instantiate(Resources.Load("Road2", typeof(Transform))) as Transform;
				Transform player= Instantiate(Resources.Load("Player", typeof(Transform))) as Transform; 	
				Transform carRespawnObj= Instantiate(Resources.Load("CarRespawn", typeof(Transform))) as Transform;
				Transform carDetector= Instantiate(Resources.Load("CarDetector", typeof(Transform))) as Transform;
				Transform gameManager= Instantiate(Resources.Load("GameManager", typeof(Transform))) as Transform;
				Transform soundExplosion= Instantiate(Resources.Load("SoundExplosion", typeof(Transform))) as Transform;

				Transform[] enemyCar= new Transform[numOfEnemyCar];
			
				for(int i=0;i<numOfEnemyCar;i++){				
					enemyCar[i]= Instantiate(Resources.Load("CarObstacle", typeof(Transform))) as Transform;
				}
				Transform motorcycle= Instantiate(Resources.Load("Motorcycle", typeof(Transform))) as Transform;
				break;
			
			case GameScreen.GameOver:
				ButtonFunction ("BackButton");
				break;
		}
	}	
	
	void ButtonFunction(string buttonName){
		gameButton= GameObject.Find(buttonName);
		if(gameButton!= null)
			gameButton.AddComponent<NGUIClick>();
	}
}
