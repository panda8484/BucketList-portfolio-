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
    public string dialogueText; // �ʵ� �̸��� dialogueText�� ����
    public int backgroundIndex; // ĳ���� �ε���


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
    public Image[] backgroundImages; // ĳ���� �̹��� �迭


    public AudioClip thunderSound; // �߰��� ����� Ŭ�� ����
    public AudioClip runningSound; // �߰��� ����� Ŭ�� ����
    private AudioSource audioSource; // AudioSource ������Ʈ ������ ������ ����
    private AudioSource audioSource2; // AudioSource ������Ʈ ������ ������ ����


    void Start()
    {


        startButton.gameObject.SetActive(true); // ���� �ÿ��� Ȱ��ȭ
        audioSource = GetComponent<AudioSource>(); // AudioSource ������Ʈ�� �ʱ�ȭ
        audioSource2 = GetComponent<AudioSource>(); // AudioSource ������Ʈ�� �ʱ�ȭ

        foreach (var image in backgroundImages)
        {
            image.gameObject.SetActive(false);
        }

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
            ShowCharacterImages(dialogues[count].backgroundIndex); // ù ��° ��ȭ�� �ش��ϴ� ĳ���� �̹����� Ȱ��ȭ�մϴ�.

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
            Dialogue_name.text = names[count].dialogueText; // �ʵ� �̸� ���� �ݿ�
            Dialogue_text.text = dialogues[count].dialogueText; // �ʵ� �̸� ���� �ݿ�
            ShowCharacterImages(dialogues[count].backgroundIndex); // �ش� ��ȭ�� �ش��ϴ� ĳ���� �̹����� Ȱ��ȭ�մϴ�.

            count++;
            Debug.Log("next dialogue");


            // Ư�� ��ȭ �������� ����� Ŭ�� ���
            if (count == 2)
            {

                audioSource.PlayOneShot(thunderSound, 1.0f); // thunderSound ���
            }

            // Ư�� ��ȭ �������� ����� Ŭ�� ���
            if (count == 3)
            {

                audioSource.PlayOneShot(runningSound, 1.5f); // runningSound ���
            }
        }

    }
    public void EndDialogue()
    {
        Dialogue_name.gameObject.SetActive(false);
        Dialogue_box.gameObject.SetActive(false);
        Dialogue_text.gameObject.SetActive(false);
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

    // �ش� �ε����� �ش��ϴ� ĳ���� �̹����� Ȱ��ȭ�ϰ� �������� ��Ȱ��ȭ�մϴ�.
    private void ShowCharacterImages(int index)
    {
        for (int i = 0; i < backgroundImages.Length; i++)
        {
            backgroundImages[i].gameObject.SetActive(i == index);
        }
    }

}

