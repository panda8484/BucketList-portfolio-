using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEditor;
//using UnityEditor.Experimental.GraphView;
using static Unity.Burst.Intrinsics.X86;

public class step18move : MonoBehaviour
{
    // box1부터 box?까지의 GameObject 배열
    public GameObject[] boxes;
    public GameObject selection;
    public Button Button1;
    public Button Button2;
    public GameObject step18;
    public GameObject step20;
    public GameObject step21;
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
        // step6 비활성화
        step18.SetActive(false);

        // step7 활성화
        step20.SetActive(true);

        // step7의 RectTransform 컴포넌트를 가져오기
        RectTransform step20Rect = step20.GetComponent<RectTransform>();

        // step7의 anchoredPosition을 (0, 0)으로 설정
        step20Rect.anchoredPosition = Vector2.zero;

    }

    public void OnButtonClick2(GameObject selectedButton)
    {
        // step6 비활성화
        step18.SetActive(false);

        // step8 활성화
        step21.SetActive(true);

        // step8의 RectTransform 컴포넌트를 가져오기
        RectTransform step21Rect = step21.GetComponent<RectTransform>();

        // step8의 anchoredPosition을 (0, 0)으로 설정
        step21Rect.anchoredPosition = Vector2.zero;

    }

}
