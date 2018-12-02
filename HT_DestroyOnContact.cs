
// Daniel Dabdoub , DIG3480 Final Project 

using UnityEngine;
using System.Collections;

public class HT_DestroyOnContact : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other) {
		Destroy (other.gameObject);
	}
}
