﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveinfo {

	public static void saveallinfo() {
		PlayerPrefs.SetInt ("coins", (Death.total_score +  PlayerPrefs.GetInt ("coins")));
		PlayerPrefs.SetFloat ("hp", PlayerHealth.currenthp);
		Debug.Log ("Saved /coins: " + Death.totals);
		Debug.Log ("Saved /hp: " + PlayerHealth.currenthp);
	}


}
