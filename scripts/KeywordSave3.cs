using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeywordSave3 : MonoBehaviour
{
    public Dictionary<string, int> keywordCollection = new Dictionary<string, int>(); // 키워드 컬렉션
    public GameObject MemoKeyword3;

    public void Keyword3ButtonClicked(Button button)
    {
        // 클릭된 버튼의 텍스트 가져오기
        Text buttonText = button.GetComponentInChildren<Text>();
        if (buttonText != null)
        {
            string keyword = buttonText.text;
            // 키워드 컬렉션에 값을 추가
            if (!keywordCollection.ContainsKey(keyword))
            {
                keywordCollection[keyword] = 3; // 3로 설정
                Debug.Log("Keyword: " + keyword + ", Value: " + keywordCollection[keyword]);
                MemoKeyword3.SetActive(true);
                // 버튼 텍스트 색상을 초록색으로 변경
                buttonText.color = Color.green;
                

            }
            else
            {
                Debug.Log("Keyword '" + keyword + "' already exists in collection.");
            }
        }
        else
        {
            Debug.LogWarning("Button text component not found!");
        }

    }
}
