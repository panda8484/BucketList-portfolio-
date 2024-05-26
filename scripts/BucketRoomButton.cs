//using UnityEngine;
//using UnityEngine.UI;
//using static Unity.Burst.Intrinsics.X86;

//public class BucketRoomButton: MonoBehaviour
//{
//    public GameObject messengerScreen; // Inspector���� ������ MessengerScreen ������Ʈ
//    public Transform messengerScreenpos; // Inspector���� ������ MessengerScreen ������Ʈ
//    public ScrollRect step1; // Inspector���� ������ step1 ScrollRect

//    public void Start()
//    {
//        // ��ư Ŭ�� ������ ���
//        Button button = GameObject.Find("RoomButton1").GetComponent<Button>();
//        button.onClick.AddListener(OnClickButton);
//        Debug.Log("start script");

//    }

//    public void OnClickButton()
//    {
//        // step1�� RectTransform ������Ʈ ��������
//        RectTransform step1RectTransform = step1.GetComponent<RectTransform>();
//        Debug.Log("������Ʈ ��������");


//        // messengerScreen�� RectTransform ������Ʈ ��������
//        RectTransform messengerScreenRectTransform = messengerScreenpos.GetComponent<RectTransform>();
//        Debug.Log("�޽��� ��ġ ��������");

//        // messengerScreen�� ���� ��ġ�� step1 �̵�
//        step1RectTransform.anchoredPosition = messengerScreenRectTransform.anchoredPosition;
//        Debug.Log("move");
//    }

//}

using UnityEngine;
using UnityEngine.UI;

public class BucketRoomButton : MonoBehaviour
{
    public GameObject messengerScreen; // Inspector���� ������ MessengerScreen ������Ʈ
    public ScrollRect step1; // Inspector���� ������ step1 ScrollRect

    public void Start()
    {
        // ��ư Ŭ�� ������ ���
        Button button = GameObject.Find("RoomButton1").GetComponent<Button>();
        button.onClick.AddListener(OnClickButton);
        Debug.Log("start script");

    }

    public void OnClickButton()
    {
        // step1�� RectTransform ������Ʈ ��������
        RectTransform step1RectTransform = step1.GetComponent<RectTransform>();
        Debug.Log("������Ʈ ��������");


        // messengerScreen�� RectTransform ������Ʈ ��������
        RectTransform messengerScreenRectTransform = messengerScreen.GetComponent<RectTransform>();
        Debug.Log("�޽��� ��ġ ��������");

        // messengerScreen�� ���� ��ġ�� step1 �̵�
        step1RectTransform.anchoredPosition = messengerScreenRectTransform.anchoredPosition;
        Debug.Log("move");
    }
}
