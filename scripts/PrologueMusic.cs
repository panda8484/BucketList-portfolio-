using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrologueMusic : MonoBehaviour
{

    public AudioClip runningSound; // Inspector에서 Prologue 씬에서 재생할 음악 파일을 할당
    public AudioClip thunderSound; // Inspector에서 Prologue 씬에서 재생할 음악 파일을 할당
    private AudioSource audioSource; // 소리를 재생하기 위한 AudioSource 컴포넌트
    public int count = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // AudioSource 컴포넌트를 초기화

        // 해당 대화의 소리를 재생
        if (count == 2)
        {
            // thunderSound를 재생합니다.
            AudioClip musicClip = Resources.Load<AudioClip>("thunderSound");
            audioSource.clip = musicClip;
            audioSource.Play();
            Debug.Log(audioSource.clip);
        }

        // 해당 대화의 소리를 재생
        //if (count == 3)
        //{
        //    AudioClip musicClip = Resources.Load<AudioClip>("runningSound");
        //    audioSource.clip = musicClip;
        //    audioSource.Play();
        //}
    }
}
