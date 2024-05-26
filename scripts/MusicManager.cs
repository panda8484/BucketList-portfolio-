using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public AudioClip prologueMusic; // Inspector에서 Prologue 씬에서 재생할 음악 파일을 할당
    public string Scenename;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // 씬이 로드될 때 호출되는 이벤트 리스너 등록
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Prologue 씬에 따라 음악을 변경하거나 재생
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