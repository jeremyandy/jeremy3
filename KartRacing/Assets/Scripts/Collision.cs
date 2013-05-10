using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {
	
	public GameObject explosion;
	GameManager gameManager;
	public GameObject soundExplosion;
	GameObject mainCamera;
	
	void Start(){
		gameManager= GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
		explosion= GameObject.FindGameObjectWithTag ("Explosion");
		explosion.particleEmitter.emit = false;
		mainCamera= GameObject.Find ("Main Camera");
		soundExplosion= GameObject.FindGameObjectWithTag("SoundExplosion");
	}
	
	void OnTriggerEnter(Collider other){
		
		if(other.gameObject.tag=="Car"){
			gameManager.livesUpdate();
			StartCoroutine (explosionTime(explosion.particleEmitter.maxEnergy, transform.position));
			soundExplosion.transform.position= mainCamera.transform.position;
			soundExplosion.audio.Play();
			StartCoroutine(blinkEffect());
			
		}
		
		if(other.gameObject.tag=="Motorcycle"){
			gameManager.livesUpdate();
			soundExplosion.transform.position= mainCamera.transform.position;
			soundExplosion.audio.Play();
			StartCoroutine (explosionTime(explosion.particleEmitter.maxEnergy, transform.position));
			StartCoroutine(blinkEffect());
		}
	}
	
	public IEnumerator explosionTime(float time, Vector3 pos){
		explosion.transform.position= pos;
		explosion.particleEmitter.emit = true;
		yield return new WaitForSeconds(time);
		explosion.particleEmitter.emit = false;
	}
	
	IEnumerator blinkEffect(){
		collider.enabled = false;
		for(float i=0; i<3; i+=.1f){
			if(renderer.enabled)
				renderer.enabled= false;
			else 
				renderer.enabled= true;
			yield return new WaitForSeconds(.1f);
		}
		renderer.enabled= true;
		collider.enabled = true;
	}
	
}
