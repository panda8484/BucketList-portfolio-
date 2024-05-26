

//using UnityEngine;
//using UnityEngine.UI;
//using System.Collections;
//using UnityEditor;
////using UnityEditor.Experimental.GraphView;
//using static Unity.Burst.Intrinsics.X86;
//using System.Collections.Generic;

//public class step12move : MonoBehaviour
//{
//    // box1부터 box?까지의 GameObject 배열
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
//        // Start 메서드에서 모든 box GameObject의 display를 활성화합니다.
//        StartCoroutine(ActivateAllBoxes());

//        selection.SetActive(false);

//    }



//    // 배열 전체에 대해 SetActive를 호출해서 box 비활성화
//    void SetActiveAllBoxes(bool isActive)
//    {
//        foreach (var box in boxes)
//        {
//            box.SetActive(isActive);
//        }
//    }


//    IEnumerator ActivateAllBoxes()
//    {
//        // 배열에 있는 모든 box GameObject의 display를 활성화합니다.
//        for (int i = 0; i < boxes.Length; i++)
//        {
//            // 해당 index의 box GameObject를 가져옴
//            GameObject box = boxes[i];

//            // 기다리기
//            yield return new WaitForSeconds(1f);

//            // box의 display를 활성화
//            box.SetActive(true);

//        }


//        yield return new WaitForSeconds(2f);

//        // selection 활성화
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
    // box1부터 box?까지의 GameObject 배열
    public GameObject[] boxes;
    public GameObject selection;
    public Button Button1;
    public GameObject step12;
    public GameObject step15;
    public GameObject panel;

    void Start()
    {
        // Start 메서드에서 모든 box GameObject의 display를 활성화합니다.
        StartCoroutine(ActivateAllBoxes());

        // 버튼 클릭 리스너 등록
        Button1.onClick.AddListener(() => OnButtonClick1(Button1.gameObject));

        selection.SetActive(false);
    }

    // 배열 전체에 대해 SetActive를 호출해서 box 비활성화
    void SetActiveAllBoxes(bool isActive)
    {
        foreach (var box in boxes)
        {
            box.SetActive(isActive);
        }
    }

    IEnumerator ActivateAllBoxes()
    {
        // 배열에 있는 모든 box GameObject의 display를 활성화합니다.
        for (int i = 0; i < boxes.Length; i++)
        {
            // 해당 index의 box GameObject를 가져옴
            GameObject box = boxes[i];

            // 기다리기
            yield return new WaitForSeconds(1f);

            // box의 display를 활성화
            box.SetActive(true);

        }


        yield return new WaitForSeconds(2f);

        // selection 활성화
        selection.SetActive(true);

    }


    // 버튼 클릭 시 호출될 메서드
    public void OnButtonClick1(GameObject selectedButton)
    {
        // step5 비활성화
        step12.SetActive(false);

        // step7 활성화
        step15.SetActive(true);

        // step7의 RectTransform 컴포넌트를 가져오기
        RectTransform step15Rect = step15.GetComponent<RectTransform>();

        // step7의 anchoredPosition을 (0, 0)으로 설정
        step15Rect.anchoredPosition = Vector2.zero;

    }

}


