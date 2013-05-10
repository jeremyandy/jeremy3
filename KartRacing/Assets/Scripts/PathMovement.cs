using UnityEngine;
using System.Collections;

public class PathMovement : MonoBehaviour {
	
	private float pathMovement;
	public float posEnd;
	public float posStart=0;
	public float normalSpeed=1;
	InputMovement inputMovement;
	
	void Start () {
		normalSpeed=1;
		inputMovement= GameObject.FindGameObjectWithTag("Player").GetComponent<InputMovement>();
		
	}
	
	void Update () {
		normalSpeed+=Time.deltaTime*.01f;
		transform.Translate(0,0,normalSpeed* -inputMovement.laneSpeed* Time.deltaTime);
		if(transform.position.z < posEnd){
			transform.position= new Vector3(0,0,posStart);	
		}
	}
}
