using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEditor;
//using UnityEditor.Experimental.GraphView;
using static Unity.Burst.Intrinsics.X86;
using UnityEngine.Device;

public class step1move : MonoBehaviour
{
    // box1부터 box?까지의 GameObject 배열
    public GameObject[] boxes;
    public GameObject selection;
    public Button Button1;
    public Button Button2;
    public GameObject step1;
    public GameObject step2;
    public GameObject step3;
    public GameObject scrollview;
    public GameObject step2manager;
    public GameObject step3manager;
    public Transform Messengerscreen;

    private bool roomButton1Clicked = false; // RoomButton1 클릭 상태를 추적하는 변수


    void Start()
    {
        StartCoroutine(ActivateAllBoxes());
        Debug.Log("start");

        // RoomButton1 클릭 리스너 등록
        GameObject roomButton1 = GameObject.Find("RoomButton1"); // RoomButton1 찾기
        if (roomButton1 != null)
        {
            roomButton1.GetComponent<Button>().onClick.AddListener(() => roomButton1Clicked = true); // 클릭 시 roomButton1Clicked를 true로 설정
        }

        Button1.onClick.AddListener(() => OnButtonClick1(Button1.gameObject));
        Button2.onClick.AddListener(() => OnButtonClick2(Button2.gameObject));
        selection.SetActive(false);
    }




    IEnumerator ActivateAllBoxes()
    {
        for (int i = 0; i < boxes.Length; i++)
        {
            GameObject box = boxes[i];
            yield return new WaitForSeconds(1f);
            box.SetActive(true);

            if (i == 17) // i가 17이 될 때까지 대기
            {
                yield return new WaitUntil(() => roomButton1Clicked == true); // roomButton1Clicked가 true가 될 때까지 대기
            }
        }
        yield return new WaitForSeconds(2f);
        selection.SetActive(true);
    }


    // 버튼 클릭 시 호출될 메서드
    public void OnButtonClick1(GameObject selectedButton)
    {
        // step1 비활성화
        step1.SetActive(false);

        // step2 활성화
        step2.SetActive(true);



        //// step2 이미지를 memoscreen 좌표로 이동시킵니다.
        //Vector3 newPosition = Messengerscreen.position;
        //step2.transform.position = newPosition;

        // step2의 RectTransform 컴포넌트를 가져오기
        RectTransform step2Rect = step2.GetComponent<RectTransform>();

        // step2의 anchoredPosition을 (0, 0)으로 설정
        step2Rect.anchoredPosition = Vector2.zero;

        step2manager.SetActive(true);
    }

    public void OnButtonClick2(GameObject selectedButton)
    {
        // step1 비활성화
        step1.SetActive(false);

        // step3 활성화
        step3.SetActive(true);

        //// step2 이미지를 memoscreen 좌표로 이동시킵니다.
        //Vector3 newPosition = Messengerscreen.position;
        //step3.transform.position = newPosition;

        // step3의 RectTransform 컴포넌트를 가져오기
        RectTransform step3Rect = step3.GetComponent<RectTransform>();

        // step3의 anchoredPosition을 (0, 0)으로 설정
        step3Rect.anchoredPosition = Vector2.zero;

        step3manager.SetActive(true);
    }

}
