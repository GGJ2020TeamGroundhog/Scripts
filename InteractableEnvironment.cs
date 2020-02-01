using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableEnvironment : Interactables
{
    public string roomName;
    public GameObject room;
    public Image fadeImage;

    public override void Interact(string name) {
        StartCoroutine(GameObject.FindGameObjectWithTag("FadeManager").GetComponent<FadeManager>().Fade(Color.black, fadeImage));
        Camera.main.transform.position = room.transform.position;
    }
}
