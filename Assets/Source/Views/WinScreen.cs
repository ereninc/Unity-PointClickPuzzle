using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScreen : ScreenElement
{
    public void NextLevel() 
    {
        Animator.Play("Outro", 0, 0);
    }
}
