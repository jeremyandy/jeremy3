using UnityEngine;
using System.Collections;

public class InputMovement : MonoBehaviour {
	
	private float movementSpeed= 4;
	public float enemySpeed;
	public float laneSpeed;
	public float scoreMultiplier;
	public float motorSpeed;
	Transform myTransform;
	public float iPx;
	private float moveThreshold= .2f;
	
	void Start(){
		
	}
	
	void Update () {
		iPx = iPhoneInput.acceleration.x;	
		myTransform= transform;
		//float horizontalSpeed = Input.GetAxis("Horizontal") * Time.deltaTime * -movementSpeed;
		if(iPx>.2f){
			float horizontalSpeed = iPx * Time.deltaTime * movementSpeed;
			myTransform.Translate(-horizontalSpeed, 0, 0);
		}
		else if(iPx<-.2f){
			float horizontalSpeed = iPx * Time.deltaTime * -movementSpeed;
			myTransform.Translate(horizontalSpeed, 0, 0);

		}
		myTransform.position= new Vector3(Mathf.Clamp(myTransform.position.x, -4f, 4.3f),myTransform.position.y,myTransform.position.z);

		
		if(Input.GetKey(KeyCode.W)){
			enemySpeed= StaticVar.enemySpeedFast;
			laneSpeed= StaticVar.laneSpeedFast;
			scoreMultiplier= StaticVar.scoreMultiplyFast;
			motorSpeed= StaticVar.motorSpeedFast;
		}
		else{
			enemySpeed= StaticVar.enemySpeedSlow;
			laneSpeed= StaticVar.laneSpeedSlow;
			scoreMultiplier= StaticVar.scoreMultiplySlow;
			motorSpeed= StaticVar.motorSpeedSlow;
		}		
		
	}	
}
