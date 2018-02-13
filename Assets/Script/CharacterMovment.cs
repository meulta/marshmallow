using UnityEngine;
using System.Collections;

public class CharacterMovment : MonoBehaviour {
	public float speed = 5.0f;
	public bool isGameOver = false;

	void OnCollisionEnter(Collision other)
	{
		Debug.Log (other.gameObject.tag);
		if (other.gameObject.tag == "Enemy") {
			Destroy (this.gameObject);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * -1 * Time.deltaTime * speed/2.0f;
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * -1.0f * speed);
        }
    }
}
