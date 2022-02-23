using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggle : MonoBehaviour {

	public GameObject dzelzsCap;

	public void dzelzsCapAttelosana(bool vertiba){
		dzelzsCap.SetActive (vertiba);
	}

}
