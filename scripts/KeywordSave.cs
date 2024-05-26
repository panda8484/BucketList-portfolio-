//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class KeywordSave : MonoBehaviour
//{
//    public Button keyword1; // keyword1 오브젝트
//    public Button keyword2; // keyword2 오브젝트
//    public Button keyword3; // keyword3 오브젝트
//    public GameObject MemoKeyword1;
//    public GameObject MemoKeyword2;
//    public GameObject MemoKeyword3;

//    private Dictionary<string, int> keywordCollection = new Dictionary<string, int>(); // 키워드 컬렉션

//    void Start()
//    {
//        // "keyword1" 버튼에 대한 클릭 이벤트 리스너를 추가합니다.
//        keyword1.onClick.AddListener(() => KeywordButtonClicked(keyword1));
//        keyword2.onClick.AddListener(() => KeywordButtonClicked(keyword2));
//        keyword3.onClick.AddListener(() => KeywordButtonClicked(keyword3));
//    }

//    // 버튼 클릭 이벤트 처리
//    public void KeywordButtonClicked(Button clickedButton)
//    {

//        // 버튼 색상을 초록색으로 변경
//        ChangeButtonColor(Color.green);

//        // 클릭된 버튼의 자식 오브젝트에 있는 텍스트 가져오기
//        Text buttonText = clickedButton.GetComponentInChildren<Text>();

//        // 클릭된 버튼의 텍스트에 따라 키워드 컬렉션에 값을 추가
//        if (buttonText.text == "벚꽃놀이")
//        {
//            AddToKeywordCollection("벚꽃놀이", 1);
//            MemoKeyword2.SetActive(true);
//            Debug.Log("1");
//            Debug.Log(buttonText.text);
//        }
//        else if (buttonText.text == "날씨")
//        {
//            AddToKeywordCollection("날씨", 2);
//            MemoKeyword2.SetActive(true);
//            Debug.Log("2");
//        }
//        else if (buttonText.text == "혼잡도")
//        {
//            AddToKeywordCollection("혼잡도", 3);
//            MemoKeyword3.SetActive(true);
//            Debug.Log("3");
//        }
//    }

//    // 버튼의 색상을 변경하는 함수
//    void ChangeButtonColor(Color color)
//    {
//        GetComponentInChildren<Text>().color = color;
//    }

//    // 키워드 컬렉션에 값을 추가하는 함수
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
//    public Dictionary<string, int> keywordCollection = new Dictionary<string, int>(); // 키워드 컬렉션
//    public GameObject MemoKeyword1;

//    public void Keyword1ButtonClicked(Button button)
//    {
//        // 클릭된 버튼의 텍스트 가져오기
//        Text buttonText = button.GetComponentInChildren<Text>();
//        if (buttonText != null)
//        {
//            string keyword = buttonText.text;
//            // 키워드 컬렉션에 값을 추가
//            if (!keywordCollection.ContainsKey(keyword))
//            {
//                keywordCollection[keyword] = 1; // 1로 설정
//                Debug.Log("Keyword: " + keyword + ", Value: " + keywordCollection[keyword]);
//                MemoKeyword1.SetActive(true);

//                // 버튼 텍스트 색상을 초록색으로 변경
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
using UnityEngine.UI; // UI 컴포넌트를 사용하기 위해 필요

public class KeywordSave: MonoBehaviour
{
    public Button yourButton; // 클릭할 버튼
    public Button targetButton; // 활성화할 버튼

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(ActivateTargetButton); // 클릭 이벤트에 함수 추가
    }

    void ActivateTargetButton()
    {
        Text buttonText = yourButton.GetComponentInChildren<Text>();
        targetButton.gameObject.SetActive(true); // 대상 버튼 활성화
        buttonText.color = Color.green;
    }
}
