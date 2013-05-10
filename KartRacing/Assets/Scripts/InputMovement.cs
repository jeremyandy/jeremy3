using UnityEngine;
using System.Collections;

public class InputMovement : MonoBehaviour {
	
	private float movementSpeed= 4;
	public float enemySpeed;
	public float laneSpeed;
	public float scoreMultiplier;
	public float motorSpeed;
	
	void Update () {
		
		float horizontalSpeed = Input.GetAxis("Horizontal") * Time.deltaTime * -movementSpeed;
		transform.Translate(horizontalSpeed, 0, 0);
		transform.position= new Vector3(Mathf.Clamp(transform.position.x, -4.8f, 5.1f),transform.position.y,transform.position.z);
		
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
