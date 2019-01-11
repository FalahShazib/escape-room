﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class OrangeCircleInteraction : VRTK_InteractableObject
{
    public override void StartUsing(VRTK_InteractUse usingObject)
    {
        base.StartUsing(usingObject);
        CircleManager.SharedInstance.OrangePressed();
    }

    protected void Start()
    {

    }
}
