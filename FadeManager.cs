﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeManager : MonoBehaviour
{
    public Image fadeImage;
    public Image artifactImage;
    public float fadeSpeed;
    public bool fading;

    private void Awake() {
        fadeImage.transform.localScale = new Vector2(Screen.width, Screen.height);
        StartCoroutine(Fade(Color.black, fadeImage));
    }

    public IEnumerator Fade(Color color, Image image) {
        fading = true;
        yield return FadeIn(color, image);
        yield return new WaitForSeconds(0.5f);
        yield return FadeOut(image);
        fading = false;
    }

    public IEnumerator FadeIn(Color color, Image image) {
        while(fading) {
            fadeImage.color = Color.Lerp(image.color, color, fadeSpeed * Time.deltaTime);
            if (fadeImage.color.a >= 0.95f) {
                fadeImage.color = Color.black;
                yield break;
            }

            yield return null;
        }
    }

    public IEnumerator FadeOut(Image image) {
        while (fading) {
            fadeImage.color = Color.Lerp(image.color, Color.clear, fadeSpeed * Time.deltaTime);
            if (fadeImage.color.a <= 0.05f) {
                fadeImage.color = Color.clear;
                yield break;
            }

            yield return null;
        }
    }
}
