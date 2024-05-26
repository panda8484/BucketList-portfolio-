using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


[System.Serializable]
public class Dialogue_
{
    [TextArea]
    public string dialogueText; // �ʵ� �̸��� dialogueText�� ����
    public GameObject cg;
}
public class DialogueManager : MonoBehaviour
{
    public Image Dialogue_box;
    public Image Dialogue_cg;
    public Text Dialogue_text;
    public Text Dialogue_name;
    public Button startButton;
    public Button nextSceneButton;
    private float re;

    private bool IsDialogue = false;
    private int count = 0;
    public Dialogue_[] dialogues; // dialogue �迭�� �̸��� dialogues�� ����
    public Dialogue_[] names;

    void Start()
    {
        startButton.gameObject.SetActive(true); // ���� �ÿ��� Ȱ��ȭ

        // �߰��� �κ�: ��ư Ŭ�� �� �̺�Ʈ �ڵ鷯 ���
        if (nextSceneButton != null)
        {
            nextSceneButton.onClick.AddListener(NextSceneOnClick);
            nextSceneButton.gameObject.SetActive(false); // ���� �ÿ��� ��Ȱ��ȭ
        }
        re = 1;
    }

    public void StartDialogue()
    {
        if (re == 1)
        {
            startButton.gameObject.SetActive(false); // ���� �ÿ��� ��Ȱ��ȭ
            Dialogue_box.gameObject.SetActive(true);
            Dialogue_text.gameObject.SetActive(true);
            Dialogue_name.gameObject.SetActive(true);
            Dialogue_cg.gameObject.SetActive(true);

            count = 0;
            IsDialogue = true;
            NextDialogue();
        }

    }

    public void NextDialogue()
    {
        Dialogue_name.text = names[count].dialogueText; // �ʵ� �̸� ���� �ݿ�
        Dialogue_text.text = dialogues[count].dialogueText; // �ʵ� �̸� ���� �ݿ�
        Dialogue_cg.sprite = dialogues[count].cg.GetComponent<Image>().sprite; // cg�� GameObject���� Sprite�� ������ �Ҵ�
        count++;

    }
    public void EndDialogue()
    {
        Dialogue_name.gameObject.SetActive(false);
        Dialogue_box.gameObject.SetActive(false);
        Dialogue_text.gameObject.SetActive(false);
        Dialogue_cg.gameObject.SetActive(false);
        IsDialogue = false;

        // �߰��� �κ�: ��ȭ�� ����Ǹ� ��ư Ȱ��ȭ
        if (nextSceneButton != null)
        {
            nextSceneButton.gameObject.SetActive(true);
        }
    }
    private void NextSceneOnClick()
    {
        // �߰��� �κ�: ��ư�� Ŭ���Ǹ� ������ ������ ��ȯ
        SceneManager.LoadScene("MainScene"); // "YourTargetSceneName"�� ��� ���� �̸����� �����ؾ� �մϴ�.
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
}

