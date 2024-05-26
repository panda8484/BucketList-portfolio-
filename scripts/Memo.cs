//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class Memo: MonoBehaviour
//{
//    public Text searchKeyword;  // Unity Inspector���� �˻� Ű���� �ؽ�Ʈ(Text ������Ʈ) �Ҵ�
//    private Text buttonText;     // Ŭ���� ��ư�� �ؽ�Ʈ�� ������ ����
//    private bool isBold = false;

//    void Start()
//    {
//        // ��ũ��Ʈ���� ��� ��ư�� ���� Ŭ�� �̺�Ʈ�� �Լ��� �Ҵ�
//        Button[] buttons = GetComponentsInChildren<Button>();
//        foreach (Button button in buttons)
//        {
//            button.onClick.AddListener(() => ButtonClick(button));
//        }
//    }

//    void ButtonClick(Button clickedButton)
//    {
//        // ���� Ŭ���� ��ư�� �ؽ�Ʈ ��������
//        buttonText = clickedButton.GetComponentInChildren<Text>();

//        // ��ư�� Ŭ���Ǿ��� �� ��Ʈ ��Ÿ���� Bold�� �����ϰų� ���� ��Ÿ�Ϸ� ����
//        isBold = !isBold;
//        buttonText.fontStyle = isBold ? FontStyle.Bold : FontStyle.Normal;

//        // Ű���� ����
//        UpdateKeyword();
//    }

//    void UpdateKeyword()
//    {
//        if (isBold)
//        {

//            // �˻� Ű���忡 �ߺ��� �ܾ ������ ó��
//            string[] words = searchKeyword.text.Trim().Split(' ');
//            if (words.Length <= 1)
//            {
//                if (!searchKeyword.text.Contains(buttonText.text))
//                {
//                    searchKeyword.text += buttonText.text + " ";
//                }
//            }
//        }
//        else
//        {
//            // ��ư�� �ؽ�Ʈ�� ����
//            searchKeyword.text = searchKeyword.text.Replace(buttonText.text + " ", "");
//        }

//    }
//}

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class Memo : MonoBehaviour
{
    public Text searchKeyword;  // Unity Inspector���� �˻� Ű���� �ؽ�Ʈ(Text ������Ʈ) �Ҵ�
    private Text buttonText;     // Ŭ���� ��ư�� �ؽ�Ʈ�� ������ ����
    public UnityEngine.UI.Button button1;
    public UnityEngine.UI.Button button2;
    public UnityEngine.UI.Button button3;
    public UnityEngine.UI.Button button4;
    public UnityEngine.UI.Button button5;
    public UnityEngine.UI.Button button6;
    private bool isBold = false;



    void Start()
    {
        button1.onClick.AddListener(() => ButtonClick(button1));
        button2.onClick.AddListener(() => ButtonClick(button2));
        button3.onClick.AddListener(() => ButtonClick(button3));
        button4.onClick.AddListener(() => ButtonClick(button4));
        button5.onClick.AddListener(() => ButtonClick(button5));
        button6.onClick.AddListener(() => ButtonClick(button6));

    }

    void ButtonClick(Button clickedButton)
    {
        //clickedButton.transform.Find("checkMark").gameObject.SetActive(true);
        // ���� Ŭ���� ��ư�� �ؽ�Ʈ ��������
        buttonText = clickedButton.GetComponentInChildren<Text>();

        // ��ư�� Ŭ���Ǿ��� �� ��Ʈ ��Ÿ���� Bold�� �����ϰų� ���� ��Ÿ�Ϸ� ����
        isBold = !isBold;
        buttonText.fontStyle = isBold ? FontStyle.Bold : FontStyle.Normal;
        Debug.Log("��ư Ŭ����");
        // Ű���� ����
        UpdateKeyword();
    }

    void UpdateKeyword()
    {
        if (isBold)
        {
            Debug.Log("������Ʈ");
            // �˻� Ű���忡 �ߺ��� �ܾ ������ ó��
            string[] words = searchKeyword.text.Trim().Split(' ');
            if (words.Length <= 1)
            {
                if (!searchKeyword.text.Contains(buttonText.text))
                {
                    searchKeyword.text += buttonText.text + " ";
                }
            }
        }
        else
        {
            // ��ư�� �ؽ�Ʈ�� ����
            searchKeyword.text = searchKeyword.text.Replace(buttonText.text + " ", "");
            Debug.Log("�ؽ�Ʈ ����");
        }
    }
}




//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class Memo : MonoBehaviour
//{
//    public Text searchKeyword;  // Unity Inspector���� �˻� Ű���� �ؽ�Ʈ(Text ������Ʈ) �Ҵ�

//    void OnEnable()
//    {
//        // ��� ��ư�� ���� Ŭ�� �̺�Ʈ�� �Լ��� �Ҵ�
//        Button[] buttons = GetComponentsInChildren<Button>(true); // true �Ű������� ��Ȱ��ȭ�� ������Ʈ�� �����ϵ��� �մϴ�.
//        foreach (Button button in buttons)
//        {
//            // �̹� �Ҵ�� �����ʰ� �ִ��� Ȯ���ϰ�, ������ ���� �߰�
//            if (!button.onClick.GetPersistentEventCount().Equals(0)) continue;

//            button.onClick.AddListener(() => ButtonClick(button));
//        }
//    }

//    //void OnDisable()
//    //{
//    //    // ��ư�� �̺�Ʈ ������ ���� (������)
//    //    Button[] buttons = GetComponentsInChildren<Button>(true);
//    //    foreach (Button button in buttons)
//    //    {
//    //        button.onClick.RemoveAllListeners();
//    //    }
//    //}

//    void ButtonClick(Button clickedButton)
//    {
//        Text buttonText = clickedButton.GetComponentInChildren<Text>();
//        bool isBold = buttonText.fontStyle == FontStyle.Bold;

//        // ��ư�� Ŭ���Ǿ��� �� ��Ʈ ��Ÿ���� Bold�� �����ϰų� ���� ��Ÿ�Ϸ� ����
//        buttonText.fontStyle = isBold ? FontStyle.Normal : FontStyle.Bold;

//        // Ű���� ����
//        UpdateKeyword(buttonText, !isBold);
//    }

//    void UpdateKeyword(Text buttonText, bool addKeyword)
//    {
//        if (addKeyword)
//        {
//            // �˻� Ű���忡 �ߺ��� �ܾ ������ ó��
//            if (!searchKeyword.text.Contains(buttonText.text))
//            {
//                searchKeyword.text += buttonText.text + " ";
//            }
//        }
//        else
//        {
//            // ��ư�� �ؽ�Ʈ�� ����
//            searchKeyword.text = searchKeyword.text.Replace(buttonText.text + " ", "");
//        }
//    }
//}