using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //variables
    GameObject p;

    //methods
    void Start()
    {
        p = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        Move();
        Debug.Log("ham position " + p.transform.position + " camera position " + transform.position);
    }

    //update methods
    private void Move()
    {
        Vector3 offset = new Vector3(p.transform.position.x, p.transform.position.y+1f, -10f);
        transform.position = offset;
    }
}
