using UnityEngine;

public class skyboxRotater : MonoBehaviour {

	private Vector3 rotationValue; 
	private float turnValue = 0.0f; 
	private float turnVal { 
		get { return turnValue; } 
		set { turnValue = value; 
		if (turnValue >= 360f) turnValue = 0.0f; } 
	}

void FixedUpdate() {
	
}

 void LateUpdate ()
 {
     turnVal += Time.deltaTime;
     rotationValue = new Vector3 (Camera.main.transform.rotation.eulerAngles.x, 
	 							  Camera.main.transform.rotation.eulerAngles.y + turnVal, 
								  Camera.main.transform.rotation.eulerAngles.z);
     transform.rotation = Quaternion.Euler (rotationValue);
	 
 }
}
