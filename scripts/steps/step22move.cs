//using UnityEngine;
//using UnityEngine.UI;
//using System.Collections;
//using UnityEditor;
////using UnityEditor.Experimental.GraphView;
//using static Unity.Burst.Intrinsics.X86;

//public class step22move : MonoBehaviour
//{
//    // box1부터 box?까지의 GameObject 배열
//    public GameObject[] boxes;
//    public Button StartButton;
//    public GameObject step22;
//    public GameObject panel;
//    public GameObject selection;


//    void Start()
//    {
//        // startButton에 클릭 이벤트 리스너 추가
//        if (StartButton != null)
//        {
//            StartButton.onClick.AddListener(StartCoroutine(ActivateAllBoxes()));
//        }



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

//        panel.gameObject.SetActive(true);
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

public class step22move : MonoBehaviour
{
    public GameObject[] boxes; // box1부터 box?까지의 GameObject 배열
    public Button StartButton; // Start 버튼
    //public GameObject step22; // Step 22 게임 오브젝트
    public GameObject panel; // 패널 게임 오브젝트
    public GameObject selection; // 선택 게임 오브젝트
    public Image backgroundImage; // 배경 이미지
    public Sprite pandaImage; // panda 이미지 스프라이트

    public void Start()
    {
        backgroundImage.sprite = pandaImage;
        // 배경 이미지의 color를 하얀색으로 변경
        backgroundImage.color = Color.white;
        StartButton.onClick.AddListener(() => StartCoroutine(ActivateAllBoxesCoroutine()));
    }

    // 모든 box를 활성화/비활성화하는 메서드
    void SetActiveAllBoxes(bool isActive)
    {
        foreach (var box in boxes)
        {
            box.SetActive(isActive);
        }
    }

    // 모든 box를 순차적으로 활성화하는 코루틴
    IEnumerator ActivateAllBoxesCoroutine()
    {
        //step22.SetActive(true);

        // boxes 배열에 있는 모든 box를 순차적으로 활성화합니다.
        for (int i = 0; i < boxes.Length; i++)
        {
            yield return new WaitForSeconds(1f); // 1초 대기
            boxes[i].SetActive(true); // box 활성화
        }

        yield return new WaitForSeconds(2f); // 모든 box가 활성화된 후 추가로 2초 대기

        selection.SetActive(true); // selection 활성화
    }
}
