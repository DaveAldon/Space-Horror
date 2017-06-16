using UnityEngine;

public class OpenDorr : MonoBehaviour {

	public Transform door;
	public Transform walkway;
	bool steppedIn = false;
	bool open = false;
	
	private float turnValue = 0.0f; 
	private float turnVal { 
		get { return turnValue; } 
		set { turnValue = value; 
		if (turnValue >= 11f) steppedIn = false; } 
	}

	private float moveValue = 0.0f; 
	private float moveVal { 
		get { return moveValue; } 
		set { moveValue = value; 
		if (moveValue >= 3f) open = false; } 
	}

	void OnTriggerEnter (Collider myTrigger) {
 		if(myTrigger.gameObject.name == "FPSController"){
			door.GetComponent<doorAnim>().triggerDoor();
			
			//steppedIn = true; 
			//open = true;
		}
	}

	void OnTriggerExit (Collider myTrigger) {
 		if(myTrigger.gameObject.name == "FPSController"){
			door.GetComponent<doorAnim>().triggerDoor();
			
			//steppedIn = false; 
			//open = false;
		}
	}

	void Update() {
		if(steppedIn) OpenDoor();
		if(open) MoveWalkway();

	}

	void MoveWalkway() {
		moveVal += Time.deltaTime * 0.01f;

		Vector3 temp;
			 temp.x = walkway.transform.position.x + moveVal;
			 temp.y = walkway.transform.position.y;
			 temp.z = walkway.transform.position.z;
 			 walkway.transform.position = temp;
	}

	void OpenDoor() {
		turnVal += Time.deltaTime * 0.07f;

		Vector3 temp;
			 temp.x = door.transform.position.x;
			 temp.y = door.transform.position.y;
			 temp.z = door.transform.position.z - turnVal;
 			 door.transform.position = temp;
	}
}