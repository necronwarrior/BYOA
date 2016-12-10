using UnityEngine;
using System.IO;
using System.Collections;

public class FileRead : MonoBehaviour {

	public string[,] cardlist;
	string filepath = "Assets/Resources/Cards.txt";

	public static FileRead use = null;

	void Awake()
	{
		if (use)
		{
			Debug.LogWarning("Only one instance of the FileRead script in a scene is allowed");
			return;
		}
		use = this;
	}

	// Use this for initialization
	void Start () {
		string[] filelines = File.ReadAllLines (filepath);
		cardlist = new string[filelines.Length,5];

		for (int i =0;i< filelines.Length;i++)
		{
			string[] parts = filelines [i].Split('/');
			cardlist[i, 0] = parts [0];
			cardlist[i, 1] = parts [1];
			cardlist[i, 2] = parts [2];
			cardlist[i, 3] = parts [3];
			cardlist[i, 4] = parts [4];
		}
	}
	
	public string[] CardFind(string CardName)
	{
		string[] currentcard = new string[5];
		for (int i=0;i<cardlist.GetLength(0);i++)
		{
			if(cardlist[i,0] == CardName)
			{
				currentcard [0] =cardlist [i, 0];
				currentcard [1] = cardlist [i, 1]; 
				currentcard [2] =cardlist[i, 2]; 
				currentcard [3] =cardlist[i, 3]; 
				currentcard [4] =cardlist[i, 4]; 
				break;
			}
		}
		return currentcard;
	}
}
