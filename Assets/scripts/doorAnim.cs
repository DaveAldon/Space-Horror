using UnityEngine;
using System.Collections;

public class doorAnim : MonoBehaviour {

	public float lengthOfAnim;
	public AnimationState anim;
	public string animName = "Open Door Up";
	bool open = false;
	float animTime;

	public void Start() {
		anim = GetComponent<Animation>()[animName];
		lengthOfAnim = anim.length;
	}

	public void triggerDoor() {
		open = !open;
		if(open) playOpen();
		else playClose();
	}

	public void playOpen() {
		GetComponent<AudioSource>().Play();
		anim.speed = 1;
		GetComponent<Animation>().Play(animName);
		StartCoroutine(StopSound());
	}

	public void playClose() {
		GetComponent<AudioSource>().Play();
		anim.speed = -1;
		if(anim.time > 0) anim.time = anim.time;
		else anim.time = lengthOfAnim;
		GetComponent<Animation>().Play(animName);
		StartCoroutine(StopSound());
	}

	IEnumerator StopSound() {
            yield return new WaitForSeconds(lengthOfAnim);
			GetComponent<AudioSource>().Stop();
	}
}
