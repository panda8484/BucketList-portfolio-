using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrologueMusic : MonoBehaviour
{

    public AudioClip runningSound; // Inspector���� Prologue ������ ����� ���� ������ �Ҵ�
    public AudioClip thunderSound; // Inspector���� Prologue ������ ����� ���� ������ �Ҵ�
    private AudioSource audioSource; // �Ҹ��� ����ϱ� ���� AudioSource ������Ʈ
    public int count = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // AudioSource ������Ʈ�� �ʱ�ȭ

        // �ش� ��ȭ�� �Ҹ��� ���
        if (count == 2)
        {
            // thunderSound�� ����մϴ�.
            AudioClip musicClip = Resources.Load<AudioClip>("thunderSound");
            audioSource.clip = musicClip;
            audioSource.Play();
            Debug.Log(audioSource.clip);
        }

        // �ش� ��ȭ�� �Ҹ��� ���
        //if (count == 3)
        //{
        //    AudioClip musicClip = Resources.Load<AudioClip>("runningSound");
        //    audioSource.clip = musicClip;
        //    audioSource.Play();
        //}
    }
}
