using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeywordSave2: MonoBehaviour
{
    public Dictionary<string, int> keywordCollection = new Dictionary<string, int>(); // 키워드 컬렉션
    public GameObject MemoKeyword2;

    public void Keyword2ButtonClicked(Button button)
    {
        // 클릭된 버튼의 텍스트 가져오기
        Text buttonText = button.GetComponentInChildren<Text>();
        if (buttonText != null)
        {
            string keyword = buttonText.text;
            // 키워드 컬렉션에 값을 추가
            if (!keywordCollection.ContainsKey(keyword))
            {
                keywordCollection[keyword] = 2; // 1로 설정
                Debug.Log("Keyword: " + keyword + ", Value: " + keywordCollection[keyword]);
                MemoKeyword2.SetActive(true);

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
