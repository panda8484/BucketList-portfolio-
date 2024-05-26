using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Dialogue5month_
{
    [TextArea]
    public string dialogueText; // 필드 이름을 dialogueText로 변경
}

public class month5Intro: MonoBehaviour
{
    public Image Dialogue_box;
    public Text Dialogue_text;

    private float re;
    private bool IsDialogue = false;
    private int count = 0;

    public Dialogue4month1_[] dialogues;

    void Start()
    {
        
        re = 1;
        StartDialogue();
    }

    public void StartDialogue()
    {
        if (re == 1)
        {
            Dialogue_box.gameObject.SetActive(true);
            Dialogue_text.gameObject.SetActive(true);
            count = 0;
            IsDialogue = true;
            NextDialogue();
        }
    }

    public void NextDialogue()
    {
        // 띄어쓰기를 반영하여 대사 텍스트를 설정합니다.
        Dialogue_text.text = dialogues[count].dialogueText.Replace("\\n", "\n");
        count++;
    }

    public void EndDialogue()
    {
        Dialogue_box.gameObject.SetActive(false);
        Dialogue_text.gameObject.SetActive(false);
        IsDialogue = false;

    }


    public void Update()
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
                }
            }
        }
    }
}
