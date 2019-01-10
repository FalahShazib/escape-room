using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleManager : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int i = 0;
		int[] order = {2, 1, 3, 1, 4};
		bool opened = false;
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (i == 5)
		{
			opened = true;
		}	
	}

	public void BluePressed() 
	{
		if (!opened) 
		{ 
			if (order[i] == 1) 
			{
				++i;
			}
			else 
			{
				i = 0;
			}
		}
	}

	public void YellowPressed() 
	{
		if (!opened) 
		{ 
			if (order[i] == 2) 
			{
				++i;
			}
			else 
			{
				i = 0;
			}
		}
	}

	public void GreenPressed() 
	{
		if (!opened) 
		{ 
			if (order[i] == 3) 
			{
				++i;
			}
			else 
			{
				i = 0;
			}
		}
	}

	public void OrangePressed() 
	{
		if (!opened) 
		{ 
			if (order[i] == 4) 
			{
				++i;
			}
			else 
			{
				i = 0;
			}
		}
	}
}
