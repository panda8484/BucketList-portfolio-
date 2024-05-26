//using UnityEngine;
//using UnityEngine.UI;
//using System.Collections;
//using UnityEditor;
////using UnityEditor.Experimental.GraphView;
//using static Unity.Burst.Intrinsics.X86;

//public class step22move : MonoBehaviour
//{
//    // box1���� box?������ GameObject �迭
//    public GameObject[] boxes;
//    public Button StartButton;
//    public GameObject step22;
//    public GameObject panel;
//    public GameObject selection;


//    void Start()
//    {
//        // startButton�� Ŭ�� �̺�Ʈ ������ �߰�
//        if (StartButton != null)
//        {
//            StartButton.onClick.AddListener(StartCoroutine(ActivateAllBoxes()));
//        }



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

//        panel.gameObject.SetActive(true);
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

public class step22move : MonoBehaviour
{
    public GameObject[] boxes; // box1���� box?������ GameObject �迭
    public Button StartButton; // Start ��ư
    //public GameObject step22; // Step 22 ���� ������Ʈ
    public GameObject panel; // �г� ���� ������Ʈ
    public GameObject selection; // ���� ���� ������Ʈ
    public Image backgroundImage; // ��� �̹���
    public Sprite pandaImage; // panda �̹��� ��������Ʈ

    public void Start()
    {
        backgroundImage.sprite = pandaImage;
        // ��� �̹����� color�� �Ͼ������ ����
        backgroundImage.color = Color.white;
        StartButton.onClick.AddListener(() => StartCoroutine(ActivateAllBoxesCoroutine()));
    }

    // ��� box�� Ȱ��ȭ/��Ȱ��ȭ�ϴ� �޼���
    void SetActiveAllBoxes(bool isActive)
    {
        foreach (var box in boxes)
        {
            box.SetActive(isActive);
        }
    }

    // ��� box�� ���������� Ȱ��ȭ�ϴ� �ڷ�ƾ
    IEnumerator ActivateAllBoxesCoroutine()
    {
        //step22.SetActive(true);

        // boxes �迭�� �ִ� ��� box�� ���������� Ȱ��ȭ�մϴ�.
        for (int i = 0; i < boxes.Length; i++)
        {
            yield return new WaitForSeconds(1f); // 1�� ���
            boxes[i].SetActive(true); // box Ȱ��ȭ
        }

        yield return new WaitForSeconds(2f); // ��� box�� Ȱ��ȭ�� �� �߰��� 2�� ���

        selection.SetActive(true); // selection Ȱ��ȭ
    }
}
