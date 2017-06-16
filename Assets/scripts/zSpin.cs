using UnityEngine;

public class zSpin : MonoBehaviour {

	public int speed;

	void FixedUpdate () {
		transform.Rotate(0,0,speed * Time.deltaTime);
	}
}
