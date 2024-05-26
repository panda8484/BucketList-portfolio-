
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Dialogue4month14_
{
    [TextArea]
    public string dialogueText; // 필드 이름을 dialogueText로 변경
    public int characterIndex; // 캐릭터 인덱스
}

public class panda14 : MonoBehaviour
{
    public Image Dialogue_box;
    public Image[] characterImages; // 캐릭터 이미지 배열
    public Text Dialogue_text;
    public Button startButton;
    public Button nextSceneButton;
    public GameObject SelectBox5;

    public Image backgroundImage; // 배경 이미지
    public Sprite AIimage; // panda 이미지 스프라이트
    public Sprite lastImage;
    public GameObject image1;
    public GameObject image2;
    public Image fadeout;
    //public GameObject step22;
    public AudioClip walkingSound; // 추가된 오디오 클립 변수
    public AudioClip peopleSound; // 추가된 오디오 클립 변수
    private AudioSource audioSource; // AudioSource 컴포넌트 참조를 저장할 변수
    private AudioSource audioSource2; // AudioSource 컴포넌트 참조를 저장할 변수

    private float re;
    private bool IsDialogue = false;
    private int count = 0;

    public Dialogue4month1_[] dialogues;

    public static int step22Number = 2;

    void Start()
    {

        audioSource = GetComponent<AudioSource>(); // AudioSource 컴포넌트를 초기화
        audioSource2 = GetComponent<AudioSource>();

        startButton.gameObject.SetActive(true);
        // 캐릭터 이미지들을 초기화합니다.
        foreach (var image in characterImages)
        {
            image.gameObject.SetActive(false);
        }

        if (SelectBox5 != null)
        {
            SelectBox5.gameObject.SetActive(false);
        }
        re = 1;
        StartDialogue();
    }

    public void StartDialogue()
    {
        if (re == 1)
        {
            startButton.gameObject.SetActive(false);
            Dialogue_box.gameObject.SetActive(true);
            Dialogue_text.gameObject.SetActive(true);
            ShowCharacterImages(dialogues[count].characterIndex); // 첫 번째 대화에 해당하는 캐릭터 이미지를 활성화합니다.
            count = 0;
            IsDialogue = true;
            NextDialogue();
        }
    }

    public void NextDialogue()
    {
        // 띄어쓰기를 반영하여 대사 텍스트를 설정합니다.
        Dialogue_text.text = dialogues[count].dialogueText.Replace("\\n", "\n");
        ShowCharacterImages(dialogues[count].characterIndex); // 해당 대화에 해당하는 캐릭터 이미지를 활성화합니다.
        if (count == 2)
        {
            StartCoroutine(part2());
        }
        if (count == 3)
        {
            backgroundImage.sprite = AIimage;
        }
        if (count == 10)
        {
            StartCoroutine(playphoto());

        }
        if (count == 30)
        {
            backgroundImage.sprite = lastImage;
        }
        count++;
    }

    IEnumerator part2()
    {
        fadeout.gameObject.SetActive(true);
        audioSource.PlayOneShot(walkingSound, 1.0f); // runningSound 재생
        audioSource2.PlayOneShot(peopleSound, 1.0f); // runningSound 재생
        yield return new WaitForSeconds(5f); // Wait for 5 seconds
        audioSource2.Stop(); // Stop playing the sound
        audioSource.Stop(); // Stop playing the sound
        fadeout.gameObject.SetActive(false);
    }

    IEnumerator playphoto()
    {
        image1.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        Debug.Log("사진 번쩍");
        image1.SetActive(false);
        image2.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        Debug.Log("사진 번쩍");
        image2.SetActive(false);
    }


    public void EndDialogue()
    {
        Dialogue_box.gameObject.SetActive(false);
        Dialogue_text.gameObject.SetActive(false);
        IsDialogue = false;
        //nextSceneButton.gameObject.SetActive(true);
        SelectBox5.gameObject.SetActive(false);
        //nextSceneButton.onClick.AddListener(StartFadeCoroutine);
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
            yield return new WaitForSeconds(0.01f);
            fadeout.color = new Color(0, 0, 0, fadeCount);
            Debug.Log("페이드아웃");
        }
        LoadMainScreen();
    }

    // nextSceneButton이 클릭되면 호출되는 함수
    public void LoadMainScreen()
    {
        //step22.SetActive(true);
        Debug.Log("씬 전환 실행");
        SceneManager.LoadScene("MainScene");
        
    }
    private void Update()
    {
        if (IsDialogue)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (count < dialogues.Length)
                {
                    NextDialogue();
                }
                else
                {
                    re = 2;
                    EndDialogue();
                    SelectBox5.gameObject.SetActive(false);
                }
            }
        }
    }

    // 해당 인덱스에 해당하는 캐릭터 이미지를 활성화하고 나머지는 비활성화합니다.
    private void ShowCharacterImages(int index)
    {
        for (int i = 0; i < characterImages.Length; i++)
        {
            characterImages[i].gameObject.SetActive(i == index);
        }
    }
}
