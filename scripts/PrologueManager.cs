using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.Collections.LowLevel.Unsafe;


[System.Serializable]
public class Dialogue2_
{
    [TextArea]
    public string dialogueText; // 필드 이름을 dialogueText로 변경
    public int backgroundIndex; // 캐릭터 인덱스


}
public class PrologueManager : MonoBehaviour
{
    public Image Dialogue_box;
    public Image Dialogue_cg;
    public Text Dialogue_text;
    public Text Dialogue_name;
    public Button startButton;
    public Button nextSceneButton;
    private float re;
    private bool IsDialogue = false;
    public int count = 0;
    public Dialogue2_[] dialogues;
    public Dialogue2_[] names;
    public Image[] backgroundImages; // 캐릭터 이미지 배열


    public AudioClip thunderSound; // 추가된 오디오 클립 변수
    public AudioClip runningSound; // 추가된 오디오 클립 변수
    private AudioSource audioSource; // AudioSource 컴포넌트 참조를 저장할 변수
    private AudioSource audioSource2; // AudioSource 컴포넌트 참조를 저장할 변수


    void Start()
    {


        startButton.gameObject.SetActive(true); // 시작 시에는 활성화
        audioSource = GetComponent<AudioSource>(); // AudioSource 컴포넌트를 초기화
        audioSource2 = GetComponent<AudioSource>(); // AudioSource 컴포넌트를 초기화

        foreach (var image in backgroundImages)
        {
            image.gameObject.SetActive(false);
        }

        // 추가된 부분: 버튼 클릭 시 이벤트 핸들러 등록
        if (nextSceneButton != null)
        {
            nextSceneButton.onClick.AddListener(NextSceneOnClick);
            nextSceneButton.gameObject.SetActive(false); // 시작 시에는 비활성화
        }
        re = 1;
    }

    public void StartDialogue()
    {
        if (re == 1)
        {
            startButton.gameObject.SetActive(false); // 시작 시에는 비활성화
            Dialogue_box.gameObject.SetActive(true);
            Dialogue_text.gameObject.SetActive(true);
            Dialogue_name.gameObject.SetActive(true);
            ShowCharacterImages(dialogues[count].backgroundIndex); // 첫 번째 대화에 해당하는 캐릭터 이미지를 활성화합니다.

            count = 0;
            IsDialogue = true;
            NextDialogue();
            Debug.Log("start dialogue");
        }

    }

    public void NextDialogue()
    {

        if (count < dialogues.Length)
        {
            Dialogue_name.text = names[count].dialogueText; // 필드 이름 변경 반영
            Dialogue_text.text = dialogues[count].dialogueText; // 필드 이름 변경 반영
            ShowCharacterImages(dialogues[count].backgroundIndex); // 해당 대화에 해당하는 캐릭터 이미지를 활성화합니다.

            count++;
            Debug.Log("next dialogue");


            // 특정 대화 순번에서 오디오 클립 재생
            if (count == 2)
            {

                audioSource.PlayOneShot(thunderSound, 1.0f); // thunderSound 재생
            }

            // 특정 대화 순번에서 오디오 클립 재생
            if (count == 3)
            {

                audioSource.PlayOneShot(runningSound, 1.5f); // runningSound 재생
            }
        }

    }
    public void EndDialogue()
    {
        Dialogue_name.gameObject.SetActive(false);
        Dialogue_box.gameObject.SetActive(false);
        Dialogue_text.gameObject.SetActive(false);
        IsDialogue = false;

        // 추가된 부분: 대화가 종료되면 버튼 활성화
        if (nextSceneButton != null)
        {
            nextSceneButton.gameObject.SetActive(true);
        }
    }
    private void NextSceneOnClick()
    {
        // 추가된 부분: 버튼이 클릭되면 지정된 씬으로 전환
        SceneManager.LoadScene("MainScene"); // "YourTargetSceneName"은 대상 씬의 이름으로 변경해야 합니다.
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
                    nextSceneButton.gameObject.SetActive(true);
                }
            }
        }
    }

    // 해당 인덱스에 해당하는 캐릭터 이미지를 활성화하고 나머지는 비활성화합니다.
    private void ShowCharacterImages(int index)
    {
        for (int i = 0; i < backgroundImages.Length; i++)
        {
            backgroundImages[i].gameObject.SetActive(i == index);
        }
    }

}

