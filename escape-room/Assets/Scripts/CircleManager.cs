using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleManager : MonoBehaviour {
    

        int i = 5;
        int[] order = { 2, 1, 3, 1, 4 };
        bool opened = false;
        private Quaternion DoorOpen;
        private Quaternion DoorClosed;

	
	// Update is called once per frame
	void Update () 
	{
		if (i == 5)
		{
			opened = true;
            GameObject Door = GameObject.Find("Kitchen Door");
            DoorOpen = Door.transform.rotation = Quaternion.Euler(0, -90, 0);
            DoorClosed = Door.transform.rotation;

            Door.transform.rotation = Quaternion.Lerp(DoorClosed, DoorOpen, Time.deltaTime * 1);
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
