using UnityEngine;
using System.Collections;

public class CarRespawn : MonoBehaviour {
	
	private int numOfLane=5;
	public GameObject[] lane;
	public float randomSpeed;
	
	
	void Start () {
		
		lane= new GameObject[numOfLane];
		for(int i=0;i<5;i++){
			lane[i]= GameObject.Find("CarRespawn"+(i+1).ToString());			
		}
			
	}
}


