//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class KeywordSave : MonoBehaviour
//{
//    public Button keyword1; // keyword1 ������Ʈ
//    public Button keyword2; // keyword2 ������Ʈ
//    public Button keyword3; // keyword3 ������Ʈ
//    public GameObject MemoKeyword1;
//    public GameObject MemoKeyword2;
//    public GameObject MemoKeyword3;

//    private Dictionary<string, int> keywordCollection = new Dictionary<string, int>(); // Ű���� �÷���

//    void Start()
//    {
//        // "keyword1" ��ư�� ���� Ŭ�� �̺�Ʈ �����ʸ� �߰��մϴ�.
//        keyword1.onClick.AddListener(() => KeywordButtonClicked(keyword1));
//        keyword2.onClick.AddListener(() => KeywordButtonClicked(keyword2));
//        keyword3.onClick.AddListener(() => KeywordButtonClicked(keyword3));
//    }

//    // ��ư Ŭ�� �̺�Ʈ ó��
//    public void KeywordButtonClicked(Button clickedButton)
//    {

//        // ��ư ������ �ʷϻ����� ����
//        ChangeButtonColor(Color.green);

//        // Ŭ���� ��ư�� �ڽ� ������Ʈ�� �ִ� �ؽ�Ʈ ��������
//        Text buttonText = clickedButton.GetComponentInChildren<Text>();

//        // Ŭ���� ��ư�� �ؽ�Ʈ�� ���� Ű���� �÷��ǿ� ���� �߰�
//        if (buttonText.text == "���ɳ���")
//        {
//            AddToKeywordCollection("���ɳ���", 1);
//            MemoKeyword2.SetActive(true);
//            Debug.Log("1");
//            Debug.Log(buttonText.text);
//        }
//        else if (buttonText.text == "����")
//        {
//            AddToKeywordCollection("����", 2);
//            MemoKeyword2.SetActive(true);
//            Debug.Log("2");
//        }
//        else if (buttonText.text == "ȥ�⵵")
//        {
//            AddToKeywordCollection("ȥ�⵵", 3);
//            MemoKeyword3.SetActive(true);
//            Debug.Log("3");
//        }
//    }

//    // ��ư�� ������ �����ϴ� �Լ�
//    void ChangeButtonColor(Color color)
//    {
//        GetComponentInChildren<Text>().color = color;
//    }

//    // Ű���� �÷��ǿ� ���� �߰��ϴ� �Լ�
//    void AddToKeywordCollection(string keyword, int value)
//    {
//        if (!keywordCollection.ContainsKey(keyword))
//        {
//            keywordCollection[keyword] = value;
//            Debug.Log(keywordCollection);
//        }
//    }
//}

//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class KeywordSave: MonoBehaviour
//{
//    public Dictionary<string, int> keywordCollection = new Dictionary<string, int>(); // Ű���� �÷���
//    public GameObject MemoKeyword1;

//    public void Keyword1ButtonClicked(Button button)
//    {
//        // Ŭ���� ��ư�� �ؽ�Ʈ ��������
//        Text buttonText = button.GetComponentInChildren<Text>();
//        if (buttonText != null)
//        {
//            string keyword = buttonText.text;
//            // Ű���� �÷��ǿ� ���� �߰�
//            if (!keywordCollection.ContainsKey(keyword))
//            {
//                keywordCollection[keyword] = 1; // 1�� ����
//                Debug.Log("Keyword: " + keyword + ", Value: " + keywordCollection[keyword]);
//                MemoKeyword1.SetActive(true);

//                // ��ư �ؽ�Ʈ ������ �ʷϻ����� ����
//                buttonText.color = Color.green;
//            }
//            else
//            {
//                Debug.Log("Keyword '" + keyword + "' already exists in collection.");
//            }
//        }
//        else
//        {
//            Debug.LogWarning("Button text component not found!");
//        }
//    }
//}

using UnityEngine;
using UnityEngine.UI; // UI ������Ʈ�� ����ϱ� ���� �ʿ�

public class KeywordSave: MonoBehaviour
{
    public Button yourButton; // Ŭ���� ��ư
    public Button targetButton; // Ȱ��ȭ�� ��ư

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(ActivateTargetButton); // Ŭ�� �̺�Ʈ�� �Լ� �߰�
    }

    void ActivateTargetButton()
    {
        Text buttonText = yourButton.GetComponentInChildren<Text>();
        targetButton.gameObject.SetActive(true); // ��� ��ư Ȱ��ȭ
        buttonText.color = Color.green;
    }
}
