using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class ViveInput : MonoBehaviour
{

    
    public SteamVR_Action_Single squeezeAction;
    public SteamVR_Action_Vector2 touchPadAction;
    // Update is called once per frame
    void Update()
    {

        //Menu button true/false
        if (SteamVR_Actions._default.Menu.GetStateDown(SteamVR_Input_Sources.Any))
        {
            print("Menu down");
        }
        //Teleport button true/false
        if (SteamVR_Actions._default.Teleport.GetStateDown(SteamVR_Input_Sources.Any))
        {
            print("Teleport down");
            //Toucpad location
            Vector2 touchPadValue = touchPadAction.GetAxis(SteamVR_Input_Sources.Any);
            if (touchPadValue != Vector2.zero)
            {
                print(touchPadValue);
            }

        }
        //Trigger button true/false
        if (SteamVR_Actions._default.GrabPinch.GetStateDown(SteamVR_Input_Sources.Any))
        {
            print("Trigger down");
            //Triggerbutton Strength
            float triggervalue = squeezeAction.GetAxis(SteamVR_Input_Sources.Any);
            if (triggervalue >= 0.0f)
            {
                print(triggervalue);
            }
        }


        

        
    }
}
