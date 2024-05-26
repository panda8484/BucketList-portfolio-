using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Dialogue4month10_
{
    [TextArea]
    public string dialogueText; // 필드 이름을 dialogueText로 변경
    public int characterIndex; // 캐릭터 인덱스
}

public class panda10 : MonoBehaviour
{
    public Image Dialogue_box;
    public Image[] characterImages; // 캐릭터 이미지 배열
    public Text Dialogue_text;
    public Button select1;
    public Button select2;
    public Button select3;
    public GameObject SelectBox2;
    public GameObject Dialogue4Manager10;
    public GameObject Dialogue4Manager3;
    public GameObject Dialogue4Manager4;
    public GameObject Dialogue4Manager5;

    private float re;
    private bool IsDialogue = false;
    private int count = 0;

    public Dialogue4month1_[] dialogues;

    void Start()
    {
        // 캐릭터 이미지들을 초기화합니다.
        foreach (var image in characterImages)
        {
            image.gameObject.SetActive(false);
        }

        if (SelectBox2 != null)
        {
            SelectBox2.gameObject.SetActive(false);
        }
        re = 1;

        StartDialogue();
    }

    public void StartDialogue()
    {
        if (re == 1)
        {
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
        count++;
    }

    public void EndDialogue()
    {
        Dialogue_box.gameObject.SetActive(false);
        Dialogue_text.gameObject.SetActive(false);
        IsDialogue = false;


        select1.onClick.AddListener(DialogueSelect3);
        select2.onClick.AddListener(DialogueSelect4);
        select3.onClick.AddListener(DialogueSelect5);


    }

    private void DialogueSelect3()
    {
        SelectBox2.gameObject.SetActive(false);
        Dialogue4Manager3.gameObject.SetActive(true);
        Dialogue4Manager10.gameObject.SetActive(false);
    }

    private void DialogueSelect4()
    {
        SelectBox2.gameObject.SetActive(false);
        Dialogue4Manager4.gameObject.SetActive(true);
        Dialogue4Manager10.gameObject.SetActive(false);
    }

    private void DialogueSelect5()
    {
        SelectBox2.gameObject.SetActive(false);
        Dialogue4Manager5.gameObject.SetActive(true);
        Dialogue4Manager10.gameObject.SetActive(false);
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
                    SelectBox2.gameObject.SetActive(true);
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