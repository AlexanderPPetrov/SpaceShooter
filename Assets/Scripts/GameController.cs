using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public GameObject asteroid;
	public Vector3 spawnValues;
	public int asteroidCount;

	public float startWait;
	public float spawnWait;
	public float waveWait;

	public Text scoreBoard; 

	private int score;

	void Start () {
		StartCoroutine(SpawnWaves());
		score = 0;
	}

	IEnumerator SpawnWaves () {

		yield return new WaitForSeconds(startWait);

		while(true){
			for(int i = 0; i < asteroidCount; i++){
				Vector3 spawnPosition = new Vector3(
					Random.Range(-spawnValues.x, spawnValues.x),
					spawnValues.y,
					spawnValues.z
				);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate(asteroid, spawnPosition, spawnRotation);

				yield return new WaitForSeconds(spawnWait);
			}
			yield return new WaitForSeconds(waveWait);
		}

		
	}

	public void addScore(int newScore){
		score += newScore;
		updateScore();
	}
	void updateScore () {
		scoreBoard.text = "Score: " + score;
	}

}
