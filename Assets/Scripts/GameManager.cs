using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	bool isGameRestarted = false;

	public void EndGame () {
		if (!isGameRestarted) {
			isGameRestarted = true;
			Invoke("Restart", 1f);
		}
	}

	public void Restart () {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
