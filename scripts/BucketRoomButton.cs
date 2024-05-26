//using UnityEngine;
//using UnityEngine.UI;
//using static Unity.Burst.Intrinsics.X86;

//public class BucketRoomButton: MonoBehaviour
//{
//    public GameObject messengerScreen; // Inspector에서 연결할 MessengerScreen 오브젝트
//    public Transform messengerScreenpos; // Inspector에서 연결할 MessengerScreen 오브젝트
//    public ScrollRect step1; // Inspector에서 연결할 step1 ScrollRect

//    public void Start()
//    {
//        // 버튼 클릭 리스너 등록
//        Button button = GameObject.Find("RoomButton1").GetComponent<Button>();
//        button.onClick.AddListener(OnClickButton);
//        Debug.Log("start script");

//    }

//    public void OnClickButton()
//    {
//        // step1의 RectTransform 컴포넌트 가져오기
//        RectTransform step1RectTransform = step1.GetComponent<RectTransform>();
//        Debug.Log("컴포너트 가져오기");


//        // messengerScreen의 RectTransform 컴포넌트 가져오기
//        RectTransform messengerScreenRectTransform = messengerScreenpos.GetComponent<RectTransform>();
//        Debug.Log("메신저 위치 가져오기");

//        // messengerScreen과 같은 위치로 step1 이동
//        step1RectTransform.anchoredPosition = messengerScreenRectTransform.anchoredPosition;
//        Debug.Log("move");
//    }

//}

using UnityEngine;
using UnityEngine.UI;

public class BucketRoomButton : MonoBehaviour
{
    public GameObject messengerScreen; // Inspector에서 연결할 MessengerScreen 오브젝트
    public ScrollRect step1; // Inspector에서 연결할 step1 ScrollRect

    public void Start()
    {
        // 버튼 클릭 리스너 등록
        Button button = GameObject.Find("RoomButton1").GetComponent<Button>();
        button.onClick.AddListener(OnClickButton);
        Debug.Log("start script");

    }

    public void OnClickButton()
    {
        // step1의 RectTransform 컴포넌트 가져오기
        RectTransform step1RectTransform = step1.GetComponent<RectTransform>();
        Debug.Log("컴포너트 가져오기");


        // messengerScreen의 RectTransform 컴포넌트 가져오기
        RectTransform messengerScreenRectTransform = messengerScreen.GetComponent<RectTransform>();
        Debug.Log("메신저 위치 가져오기");

        // messengerScreen과 같은 위치로 step1 이동
        step1RectTransform.anchoredPosition = messengerScreenRectTransform.anchoredPosition;
        Debug.Log("move");
    }
}
