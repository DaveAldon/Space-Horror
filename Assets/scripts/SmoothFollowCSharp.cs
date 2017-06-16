using UnityEngine;
 using System.Collections;
 
 // Place the script in the Camera-Control group in the component menu
 [AddComponentMenu("Camera-Control/Smooth Follow CSharp")]
 
 public class SmoothFollowCSharp : MonoBehaviour
 {
    public Transform target;
    public int moveSpeed;
    public int rotationSpeed;
    public int speed;
    public int distance;

    void Start() 
    {
        //target = GameObject.Find("Michael").transform;
    }

/*
    void FixedUpdate() {
        Vector3 direction = target.position - transform.position;
        Quaternion toRotation = Quaternion.FromToRotation(transform.up, direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, speed * Time.time);
    }*/

    void Update() 
    {    
        if (target != null) 
        {
            var dist = Vector3.Distance(transform.position, target.transform.position);
 
            if (dist > distance) {
            //Vector3 dir = target.position - transform.position;
            transform.position += (target.position - transform.position).normalized 
                * moveSpeed * Time.deltaTime;
            }
            transform.LookAt(target);
        }
        //GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

   
}