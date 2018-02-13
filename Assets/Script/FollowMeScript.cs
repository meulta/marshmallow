using UnityEngine;
using System.Collections;

public class FollowMeScript : MonoBehaviour {
    public Transform target;
    public float speed = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (target != null) {
			this.transform.LookAt (new Vector3 (target.position.x, this.transform.position.y, target.position.z));
			this.transform.position += this.transform.forward * Time.deltaTime * speed;
		}
	}

	void OnCollisionEnter(Collision other)
	{
		Debug.Log (other.gameObject.tag);
		if (other.gameObject.tag == "Projectile") {
			Destroy (this.gameObject);
		}
	}
		
}
