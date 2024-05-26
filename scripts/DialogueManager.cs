using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


[System.Serializable]
public class Dialogue_
{
    [TextArea]
    public string dialogueText; // 필드 이름을 dialogueText로 변경
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
    public Dialogue_[] dialogues; // dialogue 배열의 이름을 dialogues로 변경
    public Dialogue_[] names;

    void Start()
    {
        startButton.gameObject.SetActive(true); // 시작 시에는 활성화

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
            Dialogue_cg.gameObject.SetActive(true);

            count = 0;
            IsDialogue = true;
            NextDialogue();
        }

    }

    public void NextDialogue()
    {
        Dialogue_name.text = names[count].dialogueText; // 필드 이름 변경 반영
        Dialogue_text.text = dialogues[count].dialogueText; // 필드 이름 변경 반영
        Dialogue_cg.sprite = dialogues[count].cg.GetComponent<Image>().sprite; // cg의 GameObject에서 Sprite를 가져와 할당
        count++;

    }
    public void EndDialogue()
    {
        Dialogue_name.gameObject.SetActive(false);
        Dialogue_box.gameObject.SetActive(false);
        Dialogue_text.gameObject.SetActive(false);
        Dialogue_cg.gameObject.SetActive(false);
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
}

