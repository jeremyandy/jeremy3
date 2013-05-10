using UnityEngine;
using System.Collections;

public class MainMenuGUI : MonoBehaviour {
	
	GameObject startButtonGO;
	GameObject titleTextGO;
	GameObject quitButtonGO;
	GameObject img1GO;
	GameObject img2GO;
	
	IEnumerator Start () {
		
		startButtonGO= GameObject.Find ("StartGameButton");
		titleTextGO= GameObject.Find ("TitleLabel");
		quitButtonGO= GameObject.Find ("QuitGameButton");
		img1GO= GameObject.Find ("CarImg1");
		img2GO= GameObject.Find ("CarImg2");
		
		quitButtonGO.collider.enabled= false;
		startButtonGO.collider.enabled= false;
		
		iTween.MoveTo (img1GO, new Vector3(12.623f,0,-.277f), 5);
		iTween.FadeTo(img1GO, .2f, 3.0f);

		yield return new WaitForSeconds(1);
		
		iTween.MoveTo (img2GO, new Vector3(18.5f,0,.2f), 5);
		iTween.FadeTo(img2GO, .2f, 3.0f);
		
		yield return new WaitForSeconds(1);
		
		iTween.MoveTo (titleTextGO, iTween.Hash("position", new Vector3(-1,143,0), "islocal", true, "time", 1));
		iTween.MoveTo (startButtonGO, iTween.Hash("position", new Vector3(-1,-34,0), "islocal", true, "time", 2f));
		iTween.MoveTo (quitButtonGO, iTween.Hash("position", new Vector3(-1,-138,0), "islocal", true, "time", 3f));
		
		yield return new WaitForSeconds(2);

		quitButtonGO.collider.enabled= true;
		startButtonGO.collider.enabled= true;
		
	}
	
}
