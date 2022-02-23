using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirsrakstaIzvade : MonoBehaviour {

	public string vards;
	public string gadi;
	public GameObject ievadeVards;
	public GameObject ievadeGadi;
	public GameObject tekstaAttelosana;

	public void uzglabaTekstu(){
		vards = ievadeVards.GetComponent<Text> ().text;
		gadi = ievadeGadi.GetComponent<Text> ().text;
		tekstaAttelosana.GetComponent<Text> ().text = "Varonim ir " + gadi+" gadi un vińu sauc "+vards+ "!";

	}
}