﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeluIzvele : MonoBehaviour {

	public GameObject mainigaisAttels;
	public GameObject minecraft;
	public Sprite[]atteluMasivs;

	public void izkritosais(int skaitlis){
	
		if(skaitlis == 0){
			mainigaisAttels.GetComponent<Image> ().sprite = atteluMasivs [0];
	
		}if(skaitlis == 1){
			mainigaisAttels.GetComponent<Image> ().sprite = atteluMasivs [1];
		}

}
}
