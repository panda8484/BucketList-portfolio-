
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Dialogue4month14_
{
    [TextArea]
    public string dialogueText; // �ʵ� �̸��� dialogueText�� ����
    public int characterIndex; // ĳ���� �ε���
}

public class panda14 : MonoBehaviour
{
    public Image Dialogue_box;
    public Image[] characterImages; // ĳ���� �̹��� �迭
    public Text Dialogue_text;
    public Button startButton;
    public Button nextSceneButton;
    public GameObject SelectBox5;

    public Image backgroundImage; // ��� �̹���
    public Sprite AIimage; // panda �̹��� ��������Ʈ
    public Sprite lastImage;
    public GameObject image1;
    public GameObject image2;
    public Image fadeout;
    //public GameObject step22;
    public AudioClip walkingSound; // �߰��� ����� Ŭ�� ����
    public AudioClip peopleSound; // �߰��� ����� Ŭ�� ����
    private AudioSource audioSource; // AudioSource ������Ʈ ������ ������ ����
    private AudioSource audioSource2; // AudioSource ������Ʈ ������ ������ ����

    private float re;
    private bool IsDialogue = false;
    private int count = 0;

    public Dialogue4month1_[] dialogues;

    public static int step22Number = 2;

    void Start()
    {

        audioSource = GetComponent<AudioSource>(); // AudioSource ������Ʈ�� �ʱ�ȭ
        audioSource2 = GetComponent<AudioSource>();

        startButton.gameObject.SetActive(true);
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
            startButton.gameObject.SetActive(false);
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
        audioSource.PlayOneShot(walkingSound, 1.0f); // runningSound ���
        audioSource2.PlayOneShot(peopleSound, 1.0f); // runningSound ���
        yield return new WaitForSeconds(5f); // Wait for 5 seconds
        audioSource2.Stop(); // Stop playing the sound
        audioSource.Stop(); // Stop playing the sound
        fadeout.gameObject.SetActive(false);
    }

    IEnumerator playphoto()
    {
        image1.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        Debug.Log("���� ��½");
        image1.SetActive(false);
        image2.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        Debug.Log("���� ��½");
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
            Debug.Log("���̵�ƿ�");
        }
        LoadMainScreen();
    }

    // nextSceneButton�� Ŭ���Ǹ� ȣ��Ǵ� �Լ�
    public void LoadMainScreen()
    {
        //step22.SetActive(true);
        Debug.Log("�� ��ȯ ����");
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

    // �ش� �ε����� �ش��ϴ� ĳ���� �̹����� Ȱ��ȭ�ϰ� �������� ��Ȱ��ȭ�մϴ�.
    private void ShowCharacterImages(int index)
    {
        for (int i = 0; i < characterImages.Length; i++)
        {
            characterImages[i].gameObject.SetActive(i == index);
        }
    }
}
