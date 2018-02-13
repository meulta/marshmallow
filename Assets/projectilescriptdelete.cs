using UnityEngine;
using System.Collections;

public class projectilescriptdelete : MonoBehaviour {

    public float KillTime;

	// Use this for initialization
	void Start () {
        Invoke("Kill", KillTime);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Kill()
    {
        Destroy(gameObject);
    }
}
