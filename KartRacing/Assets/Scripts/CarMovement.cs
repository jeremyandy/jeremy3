using UnityEngine;
using System.Collections;

public class CarMovement : MonoBehaviour {
	
	public float normalSpeed=2;
	public float buttonSpeed;
	public GameObject player;
	InputMovement inputMovement;
	CarRespawn carRespawn;
	public float[] lane;

	
	void Start(){
		
		normalSpeed=2;	
		inputMovement= GameObject.FindGameObjectWithTag("Player").GetComponent<InputMovement>();
		carRespawn= GameObject.FindGameObjectWithTag("CarRespawn").GetComponent<CarRespawn>();
		lane= new float[5];
		for(int i=0; i<5;i++){
			lane[i]= carRespawn.lane[i].transform.position.x;		
		}
		ChangeCarPos();
		
	}
	
	void Update(){
		normalSpeed+=Time.deltaTime*.02f;
		transform.Translate(0,0, normalSpeed* inputMovement.enemySpeed*  Time.deltaTime);	

	}
	

	IEnumerator delayRespawn(float delayTime){
		yield return new WaitForSeconds(delayTime);
		float randomPosZ= Random.Range(0.1f,10.1f);
		transform.position= new Vector3(transform.position.x, transform.position.y, transform.position.z+randomPosZ);	
	}
	
	void OnTriggerEnter(Collider other) {
		
		if(other.gameObject.tag=="CarRespawn"){
			ChangeCarPos();
		}
		//car to car collision
		if(other.gameObject.tag=="Car"){
			float delayTime= Random.Range (0.1f,1.0f);
			StartCoroutine(delayRespawn(delayTime));
		}

    }
	
	
	public void ChangeCarPos(){
			
			int randomPos= Random.Range (0,5);
			float randomPosZ= Random.Range (5.1f,10.1f);;
		
			switch(randomPos){
				case 0:
					transform.position= new Vector3(lane[0], 1, randomPosZ);
					break;
				case 1:
					transform.position= new Vector3(lane[1], 1, randomPosZ);
					break;
				case 2:
					transform.position= new Vector3(lane[2], 1, randomPosZ);
					break;
				case 3:
					transform.position= new Vector3(lane[3], 1, randomPosZ);
					break;
				case 4:
					transform.position= new Vector3(lane[4], 1, randomPosZ);
					break;	
				default:		
					break;
			}
			
	}
}
