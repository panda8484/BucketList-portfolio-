

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEditor;
//using UnityEditor.Experimental.GraphView;
using static Unity.Burst.Intrinsics.X86;
using System.Collections.Generic;

public class step9move : MonoBehaviour
{
    // box1부터 box?까지의 GameObject 배열
    public GameObject[] boxes;
    public GameObject selection;
    public GameObject step9;
    public GameObject step10;
    public GameObject step11;
    public GameObject step12;
    public GameObject step13;
    public GameObject panel;

    public Text searchKeyword;
    public Dictionary<string, GameObject> keywordCollection = new Dictionary<string, GameObject>();
    public Button searchButton;

    void Start()
    {
        // Start 메서드에서 모든 box GameObject의 display를 활성화합니다.
        StartCoroutine(ActivateAllBoxes());

        selection.SetActive(false);

        // 인스펙터 창에서 할당된 버튼에 클릭 리스너 등록
        searchButton.onClick.AddListener(CheckAndMovePanel);
    }


    public void CheckAndMovePanel()
    {
        string keyword = searchKeyword.text.Trim();



        // keyword가 "토요일"과 "인파"을 모두 포함하는지 확인
        if (keyword.Contains("토요일") && keyword.Contains("인파"))
        {
            Debug.Log("9");
            // step14 비활성화
            step9.SetActive(false);

            // step7 활성화
            step9.SetActive(true);

            // step7의 RectTransform 컴포넌트를 가져오기
            RectTransform step9Rect = step9.GetComponent<RectTransform>();

            // step7의 anchoredPosition을 (0, 0)으로 설정
            step9Rect.anchoredPosition = Vector2.zero;

        }


        if (keyword.Contains("맑음") && !(keyword.Contains("토요일")))
        {
            Debug.Log("10");
            // step14 비활성화
            step9.SetActive(false);

            // step7 활성화
            step10.SetActive(true);

            // step7의 RectTransform 컴포넌트를 가져오기
            RectTransform step10Rect = step10.GetComponent<RectTransform>();

            // step7의 anchoredPosition을 (0, 0)으로 설정
            step10Rect.anchoredPosition = Vector2.zero;
        }

        if (keyword.Contains("맑음") && !(keyword.Contains("일요일")))
        {
            Debug.Log("10");
            // step14 비활성화
            step9.SetActive(false);

            // step7 활성화
            step10.SetActive(true);

            // step7의 RectTransform 컴포넌트를 가져오기
            RectTransform step10Rect = step10.GetComponent<RectTransform>();

            // step7의 anchoredPosition을 (0, 0)으로 설정
            step10Rect.anchoredPosition = Vector2.zero;
        }

        if (keyword.Contains("비") && !(keyword.Contains("토요일")))
        {
            Debug.Log("10");
            // step14 비활성화
            step9.SetActive(false);

            // step7 활성화
            step10.SetActive(true);

            // step7의 RectTransform 컴포넌트를 가져오기
            RectTransform step10Rect = step10.GetComponent<RectTransform>();

            // step7의 anchoredPosition을 (0, 0)으로 설정
            step10Rect.anchoredPosition = Vector2.zero;
        }

        if (keyword.Contains("비") && !(keyword.Contains("일요일")))
        {
            Debug.Log("10");
            // step14 비활성화
            step9.SetActive(false);

            // step7 활성화
            step10.SetActive(true);

            // step7의 RectTransform 컴포넌트를 가져오기
            RectTransform step10Rect = step10.GetComponent<RectTransform>();

            // step7의 anchoredPosition을 (0, 0)으로 설정
            step10Rect.anchoredPosition = Vector2.zero;
        }

        if (keyword.Contains("토요일") && keyword.Contains("비"))
        {
            Debug.Log("11");
            // step14 비활성화
            step9.SetActive(false);

            // step7 활성화
            step11.SetActive(true);

            // step7의 RectTransform 컴포넌트를 가져오기
            RectTransform step11Rect = step11.GetComponent<RectTransform>();

            // step7의 anchoredPosition을 (0, 0)으로 설정
            step11Rect.anchoredPosition = Vector2.zero;
        }

        if (keyword.Contains("일요일") && keyword.Contains("맑음"))
        {
            Debug.Log("11");
            // step14 비활성화
            step9.SetActive(false);

            // step7 활성화
            step11.SetActive(true);

            // step7의 RectTransform 컴포넌트를 가져오기
            RectTransform step11Rect = step11.GetComponent<RectTransform>();

            // step7의 anchoredPosition을 (0, 0)으로 설정
            step11Rect.anchoredPosition = Vector2.zero;
        }


        if (keyword.Contains("토요일") && keyword.Contains("맑음"))
        {
            Debug.Log("12");
            // step14 비활성화
            step9.SetActive(false);

            // step7 활성화
            step12.SetActive(true);

            // step7의 RectTransform 컴포넌트를 가져오기
            RectTransform step12Rect = step12.GetComponent<RectTransform>();

            // step7의 anchoredPosition을 (0, 0)으로 설정
            step12Rect.anchoredPosition = Vector2.zero;
        }

        if (keyword.Contains("일요일") && keyword.Contains("비"))
        {
            Debug.Log("13");
            // step14 비활성화
            step9.SetActive(false);

            // step7 활성화
            step13.SetActive(true);

            // step7의 RectTransform 컴포넌트를 가져오기
            RectTransform step13Rect = step13.GetComponent<RectTransform>();

            // step7의 anchoredPosition을 (0, 0)으로 설정
            step13Rect.anchoredPosition = Vector2.zero;
        }

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

}
