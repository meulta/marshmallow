using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreHandler : MonoBehaviour {
	public Text scoretext;
	float points = 0;
	public bool isGameOver = false;
	public Transform playerObject;
	float timeToReset = 5.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		scoretext.text = "SCORE: " + points.ToString ("0");
		if (!isGameOver) {
			points += Time.deltaTime;
		}

		if (playerObject == null) {
			isGameOver = true;
			timeToReset += Time.deltaTime;
		}

		if (timeToReset > 10.0f)
        {
            points = 0;
            isGameOver = false;
            SceneManager.LoadScene(sceneName: "LEVEL 1");
        }
	}
}
