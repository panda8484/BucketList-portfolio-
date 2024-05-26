using UnityEngine;
using UnityEngine.UI;


public class MoveObjectOnButtonClick : MonoBehaviour
{

    public GameObject moveObject;    // inspector���� moveObject �г��� �ο�
    public Button clickButton;       // inspector���� Ŭ���� ��ư�� ����
    private Vector3 originalPosition; // moveObject�� original ��ġ ��ǥ�� ������ ����
    private Vector3 specificPosition; // Ŭ���� ��ư�� ��ġ ��ǥ�� ������ ����

    void Start()
    {
        if (moveObject != null)
        {
            originalPosition = moveObject.transform.position; // �ʱ⿡ moveObject�� ���� ��ġ�� ����
        }

        if (clickButton != null)
        {
            // Ŭ���� ��ư�� ��ġ�� �������� x���� 150�� ���� ��ǥ�� specificPosition�� ����
            float newX = clickButton.transform.position.x + 150f;
            specificPosition = new Vector3(newX, clickButton.transform.position.y, clickButton.transform.position.z);

            clickButton.onClick.AddListener(ButtonClickHandler); // ��ư Ŭ�� ������ ���
        }
    }

    void ButtonClickHandler()
    {
        if (moveObject != null)
        {
            // moveObject�� ���� ��ġ�� originalPosition�� �ִ��� Ȯ��
            if (Vector3.Distance(moveObject.transform.position, originalPosition) < 0.01f)
            {
                // originalPosition���� x���� 150�� ���� ��ǥ�� �̵�
                moveObject.transform.position = new Vector3(specificPosition.x, clickButton.transform.position.y, clickButton.transform.position.z);
            }
            else
            {
                // 
                moveObject.transform.position = originalPosition;
            }
        }
    }
}

