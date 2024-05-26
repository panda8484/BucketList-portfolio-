using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchCombination: MonoBehaviour
{
    public Text searchKeyword;  // Unity Inspector���� �˻� Ű���� �ؽ�Ʈ(Text ������Ʈ) �Ҵ�

    void OnEnable()
    {
        // ��� ��ư�� ���� Ŭ�� �̺�Ʈ�� �Լ��� �Ҵ�
        Button[] buttons = GetComponentsInChildren<Button>(true); // true �Ű������� ��Ȱ��ȭ�� ������Ʈ�� �����ϵ��� �մϴ�.
        foreach (Button button in buttons)
        {
            // �̹� �Ҵ�� �����ʰ� �ִ��� Ȯ���ϰ�, ������ ���� �߰�
            if (!button.onClick.GetPersistentEventCount().Equals(0)) continue;

            button.onClick.AddListener(() => ButtonClick(button));
        }
    }


    void ButtonClick(Button clickedButton)
    {
        Text buttonText = clickedButton.GetComponentInChildren<Text>();
        bool isBold = buttonText.fontStyle == FontStyle.Bold;

        // ��ư�� Ŭ���Ǿ��� �� ��Ʈ ��Ÿ���� Bold�� �����ϰų� ���� ��Ÿ�Ϸ� ����
        buttonText.fontStyle = isBold ? FontStyle.Normal : FontStyle.Bold;

        // Ű���� ����
        UpdateKeyword(buttonText, !isBold);
    }

    void UpdateKeyword(Text buttonText, bool addKeyword)
    {
        if (addKeyword)
        {
            // �˻� Ű���忡 �ߺ��� �ܾ ������ ó��
            if (!searchKeyword.text.Contains(buttonText.text))
            {
                searchKeyword.text += buttonText.text + " ";
            }
        }
        else
        {
            // ��ư�� �ؽ�Ʈ�� ����
            searchKeyword.text = searchKeyword.text.Replace(buttonText.text + " ", "");
        }
    }
}
