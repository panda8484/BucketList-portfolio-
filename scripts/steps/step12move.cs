

//using UnityEngine;
//using UnityEngine.UI;
//using System.Collections;
//using UnityEditor;
////using UnityEditor.Experimental.GraphView;
//using static Unity.Burst.Intrinsics.X86;
//using System.Collections.Generic;

//public class step12move : MonoBehaviour
//{
//    // box1���� box?������ GameObject �迭
//    public GameObject[] boxes;
//    public GameObject selection;
//    public GameObject step9;
//    public GameObject step10;
//    public GameObject step11;
//    public GameObject step12;
//    public GameObject step13;
//    public GameObject panel;


//    void Start()
//    {
//        // Start �޼��忡�� ��� box GameObject�� display�� Ȱ��ȭ�մϴ�.
//        StartCoroutine(ActivateAllBoxes());

//        selection.SetActive(false);

//    }



//    // �迭 ��ü�� ���� SetActive�� ȣ���ؼ� box ��Ȱ��ȭ
//    void SetActiveAllBoxes(bool isActive)
//    {
//        foreach (var box in boxes)
//        {
//            box.SetActive(isActive);
//        }
//    }


//    IEnumerator ActivateAllBoxes()
//    {
//        // �迭�� �ִ� ��� box GameObject�� display�� Ȱ��ȭ�մϴ�.
//        for (int i = 0; i < boxes.Length; i++)
//        {
//            // �ش� index�� box GameObject�� ������
//            GameObject box = boxes[i];

//            // ��ٸ���
//            yield return new WaitForSeconds(1f);

//            // box�� display�� Ȱ��ȭ
//            box.SetActive(true);

//        }


//        yield return new WaitForSeconds(2f);

//        // selection Ȱ��ȭ
//        selection.SetActive(true);

//    }


//}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEditor;
//using UnityEditor.Experimental.GraphView;
using static Unity.Burst.Intrinsics.X86;

public class step12move : MonoBehaviour
{
    // box1���� box?������ GameObject �迭
    public GameObject[] boxes;
    public GameObject selection;
    public Button Button1;
    public GameObject step12;
    public GameObject step15;
    public GameObject panel;

    void Start()
    {
        // Start �޼��忡�� ��� box GameObject�� display�� Ȱ��ȭ�մϴ�.
        StartCoroutine(ActivateAllBoxes());

        // ��ư Ŭ�� ������ ���
        Button1.onClick.AddListener(() => OnButtonClick1(Button1.gameObject));

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
        // step5 ��Ȱ��ȭ
        step12.SetActive(false);

        // step7 Ȱ��ȭ
        step15.SetActive(true);

        // step7�� RectTransform ������Ʈ�� ��������
        RectTransform step15Rect = step15.GetComponent<RectTransform>();

        // step7�� anchoredPosition�� (0, 0)���� ����
        step15Rect.anchoredPosition = Vector2.zero;

    }

}


