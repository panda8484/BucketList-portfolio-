using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Dialogue4month12_
{
    [TextArea]
    public string dialogueText; // �ʵ� �̸��� dialogueText�� ����
    public int characterIndex; // ĳ���� �ε���
}

public class panda12 : MonoBehaviour
{
    public Image Dialogue_box;
    public Image[] characterImages; // ĳ���� �̹��� �迭
    public Text Dialogue_text;
    public Button SelectBox5;
    public GameObject Dialogue4Manager12;
    public GameObject Dialogue4Manager14;

    private float re;
    private bool IsDialogue = false;
    private int count = 0;

    public Dialogue4month1_[] dialogues;

    void Start()
    {
        // ĳ���� �̹������� �ʱ�ȭ�մϴ�.
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
            Dialogue_box.gameObject.SetActive(true);
            Dialogue_text.gameObject.SetActive(true);
            ShowCharacterImages(dialogues[count].characterIndex); // ù ��° ��ȭ�� �ش��ϴ� ĳ���� �̹����� Ȱ��ȭ�մϴ�.
            count = 0;
            IsDialogue = true;
            NextDialogue();
        }
    }

    public void NextDialogue()
    {
        // ���⸦ �ݿ��Ͽ� ��� �ؽ�Ʈ�� �����մϴ�.
        Dialogue_text.text = dialogues[count].dialogueText.Replace("\\n", "\n");
        ShowCharacterImages(dialogues[count].characterIndex); // �ش� ��ȭ�� �ش��ϴ� ĳ���� �̹����� Ȱ��ȭ�մϴ�.
        count++;
    }

    public void EndDialogue()
    {
        Dialogue_box.gameObject.SetActive(false);
        Dialogue_text.gameObject.SetActive(false);
        IsDialogue = false;

        SelectBox5.onClick.AddListener(DialogueSelect14);
    }

    private void DialogueSelect14()
    {
        SelectBox5.gameObject.SetActive(false);
        Dialogue4Manager14.gameObject.SetActive(true);
        Dialogue4Manager12.gameObject.SetActive(false);
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
                    SelectBox5.gameObject.SetActive(true);
                }
            }
        }
    }

    // �ش� �ε����� �ش��ϴ� ĳ���� �̹����� Ȱ��ȭ�ϰ� �������� ��Ȱ��ȭ�մϴ�.
    private void ShowCharacterImages(int index)
    {
        for (int i = 0; i < characterImages.Length; i++)
        {
            characterImages[i].gameObject.SetActive(i == index);
        }
    }
}
