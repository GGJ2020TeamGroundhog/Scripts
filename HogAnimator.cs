using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 
/// THIS SCRIPT IS USED FOR
/// Controlling the Groundhog Animator's 
/// walking state and idle state with
/// horizontal axis input
/// 
/// </summary>
public class HogAnimator : MonoBehaviour
{
    //variables
    private Animator anim;

    //Methods
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }
    void Update()
    {
        WalkingInput();
    }

    void WalkingInput()
    {
        //For the purposes of this animator, left direction = -1.0 and right direction = 1.0
        //These bool and float values were defined within the animator as assets
        //If you need the animations, I'll just send the .unity file.
        if (Input.GetAxis("Horizontal")!=0)
        {
            anim.SetBool("walking", true);
            anim.SetFloat("direction", Input.GetAxis("Horizontal"));
        }
        else
        {
            anim.SetBool("walking", false);
        }
    }
}
