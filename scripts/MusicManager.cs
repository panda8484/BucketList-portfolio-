using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public AudioClip prologueMusic; // Inspector���� Prologue ������ ����� ���� ������ �Ҵ�
    public string Scenename;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // ���� �ε�� �� ȣ��Ǵ� �̺�Ʈ ������ ���
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Prologue ���� ���� ������ �����ϰų� ���
        if (scene.name == Scenename)
        {
            PlayMusic(prologueMusic);
        }
        else
        {
            StopMusic();
        }
    }

    void PlayMusic(AudioClip musicClip)
    {
        if (audioSource != null && musicClip != null)
        {
            audioSource.clip = musicClip;
            audioSource.Play();
        }
    }

    void StopMusic()
    {
        if (audioSource != null)
        {
            audioSource.Stop();
        }
    }
}