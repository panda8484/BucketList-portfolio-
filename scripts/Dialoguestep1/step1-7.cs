//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.SceneManagement;

//[System.Serializable]
//public class Dialogue4month1_
//{
//    [TextArea]
//    public string dialogueText; // �ʵ� �̸��� dialogueText�� ����
//    public int characterIndex; // ĳ���� �ε���
//}

//public class Dialogue4to7 : MonoBehaviour
//{
//    public Image Dialogue_box;
//    public Image[] characterImages; // ĳ���� �̹��� �迭
//    public Text Dialogue_text;
//    public Button startButton;
//    public Button nextSceneButton;

//    private float re;
//    private bool IsDialogue = false;
//    private int count = 0;

//    public Dialogue4month1_[] dialogues;

//    void Start()
//    {
//        startButton.gameObject.SetActive(true);
//        // ĳ���� �̹������� �ʱ�ȭ�մϴ�.
//        foreach (var image in characterImages)
//        {
//            image.gameObject.SetActive(false);
//        }

//        if (nextSceneButton != null)
//        {
//            nextSceneButton.onClick.AddListener(NextSceneOnClick);
//            nextSceneButton.gameObject.SetActive(false);
//        }
//        re = 1;
//    }

//    public void StartDialogue()
//    {
//        if (re == 1)
//        {
//            startButton.gameObject.SetActive(false);
//            Dialogue_box.gameObject.SetActive(true);
//            Dialogue_text.gameObject.SetActive(true);
//            ShowCharacterImages(dialogues[count].characterIndex); // ù ��° ��ȭ�� �ش��ϴ� ĳ���� �̹����� Ȱ��ȭ�մϴ�.
//            count = 0;
//            IsDialogue = true;
//            NextDialogue();
//        }

//    }

//    public void NextDialogue()
//    {
//        // ���⸦ �ݿ��Ͽ� ��� �ؽ�Ʈ�� �����մϴ�.
//        Dialogue_text.text = dialogues[count].dialogueText.Replace("\\n", "\n");
//        ShowCharacterImages(dialogues[count].characterIndex); // �ش� ��ȭ�� �ش��ϴ� ĳ���� �̹����� Ȱ��ȭ�մϴ�.
//        count++;
//    }

//    public void EndDialogue()
//    {
//        Dialogue_box.gameObject.SetActive(false);
//        Dialogue_text.gameObject.SetActive(false);
//        IsDialogue = false;

//        if (nextSceneButton != null)
//        {
//        }
//    }

//    private void DialogueSelect1()
//    {
//        SceneManager.LoadScene("MainScene");
//    }

//    private void Update()
//    {
//        if (IsDialogue)
//        {
//            if (Input.GetKeyDown(KeyCode.Space))
//            {
//                if (count < dialogues.Length)
//                {
//                    NextDialogue();
//                }
//                else
//                {
//                    re = 2;
//                    EndDialogue();
//                    nextSceneButton.gameObject.SetActive(true);
//                }
//            }
//        }
//    }

//    // �ش� �ε����� �ش��ϴ� ĳ���� �̹����� Ȱ��ȭ�ϰ� �������� ��Ȱ��ȭ�մϴ�.
//    private void ShowCharacterImages(int index)
//    {
//        for (int i = 0; i < characterImages.Length; i++)
//        {
//            characterImages[i].gameObject.SetActive(i == index);
//        }
//    }
//}
