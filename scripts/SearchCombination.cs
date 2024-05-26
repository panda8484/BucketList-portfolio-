using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchCombination: MonoBehaviour
{
    public Text searchKeyword;  // Unity Inspector에서 검색 키워드 텍스트(Text 컴포넌트) 할당

    void OnEnable()
    {
        // 모든 버튼에 대한 클릭 이벤트에 함수를 할당
        Button[] buttons = GetComponentsInChildren<Button>(true); // true 매개변수는 비활성화된 오브젝트도 포함하도록 합니다.
        foreach (Button button in buttons)
        {
            // 이미 할당된 리스너가 있는지 확인하고, 없으면 새로 추가
            if (!button.onClick.GetPersistentEventCount().Equals(0)) continue;

            button.onClick.AddListener(() => ButtonClick(button));
        }
    }


    void ButtonClick(Button clickedButton)
    {
        Text buttonText = clickedButton.GetComponentInChildren<Text>();
        bool isBold = buttonText.fontStyle == FontStyle.Bold;

        // 버튼이 클릭되었을 때 폰트 스타일을 Bold로 변경하거나 원래 스타일로 변경
        buttonText.fontStyle = isBold ? FontStyle.Normal : FontStyle.Bold;

        // 키워드 갱신
        UpdateKeyword(buttonText, !isBold);
    }

    void UpdateKeyword(Text buttonText, bool addKeyword)
    {
        if (addKeyword)
        {
            // 검색 키워드에 중복된 단어가 없도록 처리
            if (!searchKeyword.text.Contains(buttonText.text))
            {
                searchKeyword.text += buttonText.text + " ";
            }
        }
        else
        {
            // 버튼의 텍스트를 제거
            searchKeyword.text = searchKeyword.text.Replace(buttonText.text + " ", "");
        }
    }
}
