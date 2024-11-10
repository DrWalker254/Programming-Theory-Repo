using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//### INHERITANCE
public class MoveTank : Vehicle
{
    //#### POLYMORPHISM
    void Start()
    {
        Speed = 20.0f;
        TurnSpeed = 15.0f;
    }

}
