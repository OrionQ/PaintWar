using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static int PlayerScore1 = 0;
	public static int PlayerScore2 = 0;

	public GUISkin layout;

	GameObject particleSystem1;
	GameObject particleSystem2;

	// Use this for initialization
	void Start () {
		particleSystem1 = GameObject.FindGameObjectWithTag ("Shooter1");
		particleSystem2 = GameObject.FindGameObjectWithTag ("Shooter2");
	}

	public static void Score(string wallID, string shooter) {
		if (wallID == "Spikes1" && shooter == "pCylinder5") {
			PlayerScore2++;
		} else if (wallID == "Spikes2" && shooter == "pCylinder6"){
			PlayerScore1++;
		}
	}

	void OnGUI() {
		GUI.skin = layout;
		GUI.Label (new Rect (Screen.width / 2 - 200 - 20, 20, 150, 100), "" + PlayerScore1 + "%");
		GUI.Label (new Rect (Screen.width / 2 + 200 + 20, 20, 150, 100), "" + PlayerScore2 + "%");

		if (GUI.Button (new Rect (Screen.width / 2 - 60, 35, 120, 53), "RESTART")) {
			PlayerScore1 = 0;
			PlayerScore2 = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 1f;
        }

        if (PlayerScore1 == 100) {
			GUI.Label (new Rect (Screen.width / 2 - 200, 200, 2000, 1000), "PLAYER ONE WINS!");
            Time.timeScale = 0f;

        }
        else if (PlayerScore2 == 100) {
			GUI.Label (new Rect (Screen.width / 2 - 200, 200, 2000, 1000), "PLAYER TWO WINS!");
            Time.timeScale = 0f;
        }
	}

}
