using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class YellowCircleInteraction : VRTK_InteractableObject
{
    public override void StartUsing(VRTK_InteractUse usingObject)
    {
        base.StartUsing(usingObject);
        CircleManager.SharedInstance.YellowPressed();
    }

    protected void Start()
    {

    }
}
