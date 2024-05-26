using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEditor;
//using UnityEditor.Experimental.GraphView;
using static Unity.Burst.Intrinsics.X86;
using UnityEngine.Device;

public class step1move : MonoBehaviour
{
    // box1���� box?������ GameObject �迭
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

    private bool roomButton1Clicked = false; // RoomButton1 Ŭ�� ���¸� �����ϴ� ����


    void Start()
    {
        StartCoroutine(ActivateAllBoxes());
        Debug.Log("start");

        // RoomButton1 Ŭ�� ������ ���
        GameObject roomButton1 = GameObject.Find("RoomButton1"); // RoomButton1 ã��
        if (roomButton1 != null)
        {
            roomButton1.GetComponent<Button>().onClick.AddListener(() => roomButton1Clicked = true); // Ŭ�� �� roomButton1Clicked�� true�� ����
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

            if (i == 17) // i�� 17�� �� ������ ���
            {
                yield return new WaitUntil(() => roomButton1Clicked == true); // roomButton1Clicked�� true�� �� ������ ���
            }
        }
        yield return new WaitForSeconds(2f);
        selection.SetActive(true);
    }


    // ��ư Ŭ�� �� ȣ��� �޼���
    public void OnButtonClick1(GameObject selectedButton)
    {
        // step1 ��Ȱ��ȭ
        step1.SetActive(false);

        // step2 Ȱ��ȭ
        step2.SetActive(true);



        //// step2 �̹����� memoscreen ��ǥ�� �̵���ŵ�ϴ�.
        //Vector3 newPosition = Messengerscreen.position;
        //step2.transform.position = newPosition;

        // step2�� RectTransform ������Ʈ�� ��������
        RectTransform step2Rect = step2.GetComponent<RectTransform>();

        // step2�� anchoredPosition�� (0, 0)���� ����
        step2Rect.anchoredPosition = Vector2.zero;

        step2manager.SetActive(true);
    }

    public void OnButtonClick2(GameObject selectedButton)
    {
        // step1 ��Ȱ��ȭ
        step1.SetActive(false);

        // step3 Ȱ��ȭ
        step3.SetActive(true);

        //// step2 �̹����� memoscreen ��ǥ�� �̵���ŵ�ϴ�.
        //Vector3 newPosition = Messengerscreen.position;
        //step3.transform.position = newPosition;

        // step3�� RectTransform ������Ʈ�� ��������
        RectTransform step3Rect = step3.GetComponent<RectTransform>();

        // step3�� anchoredPosition�� (0, 0)���� ����
        step3Rect.anchoredPosition = Vector2.zero;

        step3manager.SetActive(true);
    }

}
