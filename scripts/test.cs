using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class test : MonoBehaviour
{

    public Image backgroundImage; // 배경 이미지
    
    public Image fadeout;


    void Start()
    {
        StartFadeCoroutine();
    }


    public void StartFadeCoroutine()
    {
        StartCoroutine(FadeCoroutine());
    }

    IEnumerator FadeCoroutine()
    {
        fadeout.gameObject.SetActive(true);
        float fadeCount = 0;
        while (fadeCount < 1.0f)
        {
            fadeCount += 0.01f;
            yield return new WaitForSeconds(0.03f);
            fadeout.color = new Color(0, 0, 0, fadeCount);
            Debug.Log("페이드아웃");
        }
    }
}
