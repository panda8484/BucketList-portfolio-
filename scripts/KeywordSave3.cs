using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeywordSave3 : MonoBehaviour
{
    public Dictionary<string, int> keywordCollection = new Dictionary<string, int>(); // Ű���� �÷���
    public GameObject MemoKeyword3;

    public void Keyword3ButtonClicked(Button button)
    {
        // Ŭ���� ��ư�� �ؽ�Ʈ ��������
        Text buttonText = button.GetComponentInChildren<Text>();
        if (buttonText != null)
        {
            string keyword = buttonText.text;
            // Ű���� �÷��ǿ� ���� �߰�
            if (!keywordCollection.ContainsKey(keyword))
            {
                keywordCollection[keyword] = 3; // 3�� ����
                Debug.Log("Keyword: " + keyword + ", Value: " + keywordCollection[keyword]);
                MemoKeyword3.SetActive(true);
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
