using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOnLights : MonoBehaviour {

	public Light lightL, lightL2;

	void Start() {
		lightL.enabled = false;
		lightL2.enabled = false;
	}

	void OnTriggerEnter (Collider myTrigger) {
		if(myTrigger.gameObject.name == "FPSController"){
			lightL.enabled = !lightL.enabled;
			lightL2.enabled = !lightL2.enabled;
		}
	}

	void OnTriggerExit (Collider myTrigger) {
		if(myTrigger.gameObject.name == "FPSController"){
			lightL.enabled = !lightL.enabled;
			lightL2.enabled = !lightL2.enabled;
		}
	}
}
