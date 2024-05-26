using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEditor;
//using UnityEditor.Experimental.GraphView;
using static Unity.Burst.Intrinsics.X86;

public class step2move : MonoBehaviour
{
    // box1���� box?������ GameObject �迭
    public GameObject[] boxes;
    public GameObject selection;
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public GameObject step2;
    public GameObject step4;
    public GameObject step5;
    public GameObject step6;
    public GameObject panel;
    public GameObject step4manager;
    public GameObject step5manager;
    public GameObject step6manager;

    void Start()
    {
        // Start �޼��忡�� ��� box GameObject�� display�� Ȱ��ȭ�մϴ�.
        StartCoroutine(ActivateAllBoxes());

        // ��ư Ŭ�� ������ ���
        Button1.onClick.AddListener(() => OnButtonClick1(Button1.gameObject));
        Button2.onClick.AddListener(() => OnButtonClick2(Button2.gameObject));
        Button3.onClick.AddListener(() => OnButtonClick3(Button3.gameObject));

        selection.SetActive(false);
    }

    // �迭 ��ü�� ���� SetActive�� ȣ���ؼ� box ��Ȱ��ȭ
    void SetActiveAllBoxes(bool isActive)
    {
        foreach (var box in boxes)
        {
            box.SetActive(isActive);
        }
    }

    IEnumerator ActivateAllBoxes()
    {
        // �迭�� �ִ� ��� box GameObject�� display�� Ȱ��ȭ�մϴ�.
        for (int i = 0; i < boxes.Length; i++)
        {
            // �ش� index�� box GameObject�� ������
            GameObject box = boxes[i];

            // ��ٸ���
            yield return new WaitForSeconds(1f);

            // box�� display�� Ȱ��ȭ
            box.SetActive(true);
        }

        yield return new WaitForSeconds(2f);

        // selection Ȱ��ȭ
        selection.SetActive(true);

    }
    // ��ư Ŭ�� �� ȣ��� �޼���
    public void OnButtonClick1(GameObject selectedButton)
    {
        // step2 ��Ȱ��ȭ
        step2.SetActive(false);

        // step4 Ȱ��ȭ
        step4.SetActive(true);

        // step4�� RectTransform ������Ʈ�� ��������
        RectTransform step4Rect = step4.GetComponent<RectTransform>();

        // step4�� anchoredPosition�� (0, 0)���� ����
        step4Rect.anchoredPosition = Vector2.zero;

        step4manager.SetActive(true);

    }

    public void OnButtonClick2(GameObject selectedButton)
    {
        // step2 ��Ȱ��ȭ
        step2.SetActive(false);

        // step5 Ȱ��ȭ
        step5.SetActive(true);

        // step5�� RectTransform ������Ʈ�� ��������
        RectTransform step5Rect = step5.GetComponent<RectTransform>();

        // step5�� anchoredPosition�� (0, 0)���� ����
        step5Rect.anchoredPosition = Vector2.zero;

        step5manager.SetActive(true);

    }

    public void OnButtonClick3(GameObject selectedButton)
    {
        // step2 ��Ȱ��ȭ
        step2.SetActive(false);

        // step6 Ȱ��ȭ
        step6.SetActive(true);

        // step6�� RectTransform ������Ʈ�� ��������
        RectTransform step6Rect = step6.GetComponent<RectTransform>();

        // step6�� anchoredPosition�� (0, 0)���� ����
        step6Rect.anchoredPosition = Vector2.zero;

        step6manager.SetActive(true);

    }

}
