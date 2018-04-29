using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryByContact : MonoBehaviour {

	public GameObject asteroidExplosion;
	public GameObject playerExplosion;

	private GameController gameController;
	public int gameScore; 

	void Start() {
		GameObject gameControllerObject = GameObject.FindWithTag("GameController");
		if(gameControllerObject != null){
			gameController = gameControllerObject.GetComponent<GameController>();
		}
	}

    void OnTriggerEnter(Collider other) {

		if(other.tag == "Boundary"){
			return;
		}
        
		Instantiate(asteroidExplosion, transform.position, transform.rotation);

		if(other.tag == "Player"){

		Instantiate(playerExplosion, transform.position, transform.rotation);

		}

		gameController.addScore(10);

        Destroy(other.gameObject);
		Destroy(gameObject);


    }
}
