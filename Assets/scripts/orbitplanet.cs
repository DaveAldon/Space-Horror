using UnityEngine;
 
 public class orbitplanet : MonoBehaviour {
     
     public GameObject planet;
     public Transform center;
     public Vector3 axis = Vector3.forward;
     public Vector3 desiredPosition;
     public float radius;
     public float radiusSpeed;
     public float rotationSpeed;
 
     void Start () {
         transform.position = (transform.position - center.position).normalized * radius + center.position;
     }
     
     void Update () {
         transform.RotateAround (center.position, axis, rotationSpeed * Time.deltaTime);
         desiredPosition = (transform.position - center.position).normalized * radius + center.position;
         transform.position = Vector3.MoveTowards(transform.position, desiredPosition, Time.deltaTime * radiusSpeed);
     }
 }
