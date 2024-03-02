using UnityEngine;
using System.Collections;

static public class GameInfo
{
	static public int score = 0;
	static public int bestScore = 0;
	static public bool accelerometerSteering = false;

	static public void SaveInformation()
	{
		PlayerPrefs.SetInt("bestscore", bestScore);
	}
	
	static public void LoadInformation()
	{
		bestScore = PlayerPrefs.GetInt("bestscore");
	}
}
