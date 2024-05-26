//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class Memo: MonoBehaviour
//{
//    public Text searchKeyword;  // Unity Inspector에서 검색 키워드 텍스트(Text 컴포넌트) 할당
//    private Text buttonText;     // 클릭된 버튼의 텍스트를 저장할 변수
//    private bool isBold = false;

//    void Start()
//    {
//        // 스크립트에서 모든 버튼에 대한 클릭 이벤트에 함수를 할당
//        Button[] buttons = GetComponentsInChildren<Button>();
//        foreach (Button button in buttons)
//        {
//            button.onClick.AddListener(() => ButtonClick(button));
//        }
//    }

//    void ButtonClick(Button clickedButton)
//    {
//        // 현재 클릭된 버튼의 텍스트 가져오기
//        buttonText = clickedButton.GetComponentInChildren<Text>();

//        // 버튼이 클릭되었을 때 폰트 스타일을 Bold로 변경하거나 원래 스타일로 변경
//        isBold = !isBold;
//        buttonText.fontStyle = isBold ? FontStyle.Bold : FontStyle.Normal;

//        // 키워드 갱신
//        UpdateKeyword();
//    }

//    void UpdateKeyword()
//    {
//        if (isBold)
//        {

//            // 검색 키워드에 중복된 단어가 없도록 처리
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
//            // 버튼의 텍스트를 제거
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
    public Text searchKeyword;  // Unity Inspector에서 검색 키워드 텍스트(Text 컴포넌트) 할당
    private Text buttonText;     // 클릭된 버튼의 텍스트를 저장할 변수
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
        // 현재 클릭된 버튼의 텍스트 가져오기
        buttonText = clickedButton.GetComponentInChildren<Text>();

        // 버튼이 클릭되었을 때 폰트 스타일을 Bold로 변경하거나 원래 스타일로 변경
        isBold = !isBold;
        buttonText.fontStyle = isBold ? FontStyle.Bold : FontStyle.Normal;
        Debug.Log("버튼 클릭됨");
        // 키워드 갱신
        UpdateKeyword();
    }

    void UpdateKeyword()
    {
        if (isBold)
        {
            Debug.Log("업데이트");
            // 검색 키워드에 중복된 단어가 없도록 처리
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
            // 버튼의 텍스트를 제거
            searchKeyword.text = searchKeyword.text.Replace(buttonText.text + " ", "");
            Debug.Log("텍스트 제거");
        }
    }
}




//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class Memo : MonoBehaviour
//{
//    public Text searchKeyword;  // Unity Inspector에서 검색 키워드 텍스트(Text 컴포넌트) 할당

//    void OnEnable()
//    {
//        // 모든 버튼에 대한 클릭 이벤트에 함수를 할당
//        Button[] buttons = GetComponentsInChildren<Button>(true); // true 매개변수는 비활성화된 오브젝트도 포함하도록 합니다.
//        foreach (Button button in buttons)
//        {
//            // 이미 할당된 리스너가 있는지 확인하고, 없으면 새로 추가
//            if (!button.onClick.GetPersistentEventCount().Equals(0)) continue;

//            button.onClick.AddListener(() => ButtonClick(button));
//        }
//    }

//    //void OnDisable()
//    //{
//    //    // 버튼의 이벤트 리스너 제거 (선택적)
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

//        // 버튼이 클릭되었을 때 폰트 스타일을 Bold로 변경하거나 원래 스타일로 변경
//        buttonText.fontStyle = isBold ? FontStyle.Normal : FontStyle.Bold;

//        // 키워드 갱신
//        UpdateKeyword(buttonText, !isBold);
//    }

//    void UpdateKeyword(Text buttonText, bool addKeyword)
//    {
//        if (addKeyword)
//        {
//            // 검색 키워드에 중복된 단어가 없도록 처리
//            if (!searchKeyword.text.Contains(buttonText.text))
//            {
//                searchKeyword.text += buttonText.text + " ";
//            }
//        }
//        else
//        {
//            // 버튼의 텍스트를 제거
//            searchKeyword.text = searchKeyword.text.Replace(buttonText.text + " ", "");
//        }
//    }
//}