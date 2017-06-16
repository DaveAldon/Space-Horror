using UnityEngine;
using System.Collections;

public class pedistalControl : MonoBehaviour {

	public GameObject pedistal;
	public float lengthOfAnim;
	public AnimationState anim;
	public string animName = "RisePed";
	bool open = false;
	float animTime;
	bool stateOpening = false;

	public void Start() {
		anim = pedistal.GetComponent<Animation>()[animName];
		lengthOfAnim = anim.length;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) { // if left button pressed...
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, 1f)) {
				GetComponent<Animation>().Play("PushButton");
				if(!stateOpening) triggerPed();
			}
		}
	}

	public void triggerPed() {
		open = !open;
		if(open) playOpen();
		else playClose();
	}

	public void playOpen() {
		pedistal.GetComponent<AudioSource>().Play();
		anim.speed = 1;
		pedistal.GetComponent<Animation>().Play(animName);
		StartCoroutine(WaitForAnim());
	}

	public void playClose() {
		pedistal.GetComponent<AudioSource>().Play();
		anim.speed = -1;
		if(anim.time > 0) anim.time = anim.time;
		else anim.time = lengthOfAnim;
		pedistal.GetComponent<Animation>().Play(animName);
		StartCoroutine(WaitForAnim());
	}
	
	IEnumerator WaitForAnim() {
			stateOpening = true;
            yield return new WaitForSeconds(lengthOfAnim);
			pedistal.GetComponent<AudioSource>().Stop();
			stateOpening = false;
	}
}
