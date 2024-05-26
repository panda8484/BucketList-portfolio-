using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeywordSave2: MonoBehaviour
{
    public Dictionary<string, int> keywordCollection = new Dictionary<string, int>(); // Ű���� �÷���
    public GameObject MemoKeyword2;

    public void Keyword2ButtonClicked(Button button)
    {
        // Ŭ���� ��ư�� �ؽ�Ʈ ��������
        Text buttonText = button.GetComponentInChildren<Text>();
        if (buttonText != null)
        {
            string keyword = buttonText.text;
            // Ű���� �÷��ǿ� ���� �߰�
            if (!keywordCollection.ContainsKey(keyword))
            {
                keywordCollection[keyword] = 2; // 1�� ����
                Debug.Log("Keyword: " + keyword + ", Value: " + keywordCollection[keyword]);
                MemoKeyword2.SetActive(true);

                // ��ư �ؽ�Ʈ ������ �ʷϻ����� ����
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
