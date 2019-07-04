using UnityEngine.SceneManagement;
using UnityEngine;

public class WinTrigger : MonoBehaviour {

	// Use this for initialization
	[SerializeField] string nextLevelName;

	void OnTriggerEnter(Collider col){
		if (col.CompareTag ("Player")) {
			SceneManager.LoadScene (nextLevelName);
		}
	}
}
