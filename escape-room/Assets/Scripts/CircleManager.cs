using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleManager : MonoBehaviour {
    

        int i = 5;
        int[] order = { 3, 1, 3, 1, 4 };
        bool opened = false;
        private Quaternion DoorOpen;
        private Quaternion DoorClosed;

    private static CircleManager instance = null;
    public static CircleManager SharedInstance
    {
        get
        {
            if (instance == null)
            {
                instance = new CircleManager();
            }
            return instance;
        }
    }



    // Update is called once per frame
    void Update () 
	{
		if (i == 1)
		{
			opened = true;
            GameObject Door = GameObject.Find("Kitchen Door");
            Door.transform.Translate(0, 10, 0);
            Debug.Log("door opened!");
            ++i;
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
