using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;


    public class BlueCircleInteraction : VRTK_InteractableObject
{
    

    public override void StartUsing(VRTK_InteractUse usingObject)
    {
        base.StartUsing(usingObject);
        CircleManager.SharedInstance.BluePressed();
    }

    protected void Start()
    {
        
    }
    
}
