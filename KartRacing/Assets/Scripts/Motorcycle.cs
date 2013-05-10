using UnityEngine;
using System.Collections;

public class Motorcycle : MonoBehaviour {
	
	float normalSpeed= 1;
	public float[] lane;
	InputMovement inputMovement;
	CarRespawn carRespawn;
	Collision collision;
	
	void Start () {
		normalSpeed=1;
		carRespawn= GameObject.FindGameObjectWithTag("CarRespawn").GetComponent<CarRespawn>();
		inputMovement= GameObject.FindGameObjectWithTag("Player").GetComponent<InputMovement>();
		collision= GameObject.FindGameObjectWithTag("Player").GetComponent<Collision>();
		
		
		lane= new float[5];
		for(int i=0; i<5;i++){
			lane[i]= carRespawn.lane[i].transform.position.x;		
		}
		ChangeMotorcyclePos();
	}
	
	void Update () {
		normalSpeed+=Time.deltaTime*.01f;;
		transform.Translate (0,0,-normalSpeed* inputMovement.motorSpeed*Time.deltaTime);
		
		if(transform.position.z>10){
			ChangeMotorcyclePos();
		}
		
	}
	
	public void ChangeMotorcyclePos(){
			
			int randomPos= Random.Range (0,5);
			float randomPosZ= -35;
		
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
	
	void OnTriggerEnter(Collider other){
		
		if(other.gameObject.tag=="Car"){
			other.GetComponent<CarMovement>().ChangeCarPos();
			StartCoroutine(collision.explosionTime(.5f, transform.position));
		}
		
		if(other.gameObject.tag=="Player"){
			ChangeMotorcyclePos();
		}
		
	}
}
