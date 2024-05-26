using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEditor;
//using UnityEditor.Experimental.GraphView;
using static Unity.Burst.Intrinsics.X86;

public class step4move : MonoBehaviour
{
    // box1부터 box?까지의 GameObject 배열
    public GameObject[] boxes;
    public GameObject selection;
    public Button Button1;
    public Button Button2;
    //public Button Button3;
    public GameObject step4;
    public GameObject step5;
    public GameObject step6;
    public GameObject panel;

    void Start()
    {
        // Start 메서드에서 모든 box GameObject의 display를 활성화합니다.
        StartCoroutine(ActivateAllBoxes());

        // 버튼 클릭 리스너 등록
        Button1.onClick.AddListener(() => OnButtonClick1(Button1.gameObject));
        Button2.onClick.AddListener(() => OnButtonClick2(Button2.gameObject));

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
        // step4 비활성화
        step4.SetActive(false);

        // step5 활성화
        step5.SetActive(true);

        // step5의 RectTransform 컴포넌트를 가져오기
        RectTransform step7Rect = step5.GetComponent<RectTransform>();

        // step5의 anchoredPosition을 (0, 0)으로 설정
        step7Rect.anchoredPosition = Vector2.zero;

    }

    public void OnButtonClick2(GameObject selectedButton)
    {
        // step4 비활성화
        step4.SetActive(false);

        // step6 활성화
        step6.SetActive(true);

        // step8의 RectTransform 컴포넌트를 가져오기
        RectTransform step8Rect = step6.GetComponent<RectTransform>();

        // step6의 anchoredPosition을 (0, 0)으로 설정
        step8Rect.anchoredPosition = Vector2.zero;

    }

}
