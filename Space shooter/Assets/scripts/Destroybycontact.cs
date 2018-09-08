using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroybycontact : MonoBehaviour {
	public GameObject explosion;
	public GameObject player;
	public int ScoreValue;
	private GameConstroller gameController;
	void Start()
	{
		GameObject gamecontrollerobject = GameObject.FindWithTag ("GameController");
		if (gamecontrollerobject != null) {
			gameController = gamecontrollerobject.GetComponent<GameConstroller> ();
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Boundary")
			return;
		Instantiate (explosion, transform.position, transform.rotation);
		if(other.tag=="Player")
			
			Instantiate (player, other.transform.position,other.transform.rotation);
		gameController.AddScore (ScoreValue);
		Destroy (other.gameObject);
		Destroy (gameObject);
		

}
}
