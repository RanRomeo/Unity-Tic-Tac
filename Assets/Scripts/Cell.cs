using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{


    public Text mLabel1;
    public Button mButton;
    public Main mMain;


    public void Fill()
    {
        mButton.interactable = false;

        mLabel1.text = mMain.GetTurnCharacter();

        mMain.Switch();

    }


}
