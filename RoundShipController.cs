using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 
/// ROUND SHIP LEVEL CONTROLLER
/// 
/// This script will make the hamster wheel hub level
/// rotate using A and D while the player stays
/// in place. Nothing complicated.
/// 
/// In addition, it will rotate the background at a slow
/// speed.
/// 
/// 
/// </summary>
public class RoundShipController : MonoBehaviour
{
    //variables
    //
    public float speed;
    //level object is the round ship hub
    GameObject level;
    //background object is the space background object
    GameObject background;

    //methods
    //
    void Update()
    {
        LevelControl();
        BackgroundRotate();
    }

    //at frame 1, the bg and level objects are found
    void Start()
    {
        level = GameObject.FindGameObjectWithTag("Level");
        background = GameObject.FindGameObjectWithTag("Background");
    }


    //Input Axis changes rotate the level
    void LevelControl()
    {
        //both of these if statements will simply rotate a parent object (the hub level)
        if (Input.GetAxis("Horizontal")>0.5)
        {
            level.transform.Rotate(new Vector3(0f, 0f, -speed));
        }
        else if (Input.GetAxis("Horizontal")<-0.5)
        {
            level.transform.Rotate(new Vector3(0f, 0f, speed));
        }
    }

    //Ambient background rotation due to moving ship :)
    void BackgroundRotate()
    {
        background.transform.Rotate(new Vector3(0f, 0f, 0.01f));
    }
}
