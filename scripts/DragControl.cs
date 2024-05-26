using UnityEngine;
using UnityEngine.EventSystems;

public class DragControl : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    private RectTransform squareRectTransform; // Rename variable to represent the square
    private Vector3 offset;

    private void Start()
    {
        // Square�� RectTransform ������Ʈ�� ������
        squareRectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // ���콺 ���� ��ư�� Ŭ���� ���
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            // ���� ���콺 ��ġ���� Square�� ���� ��ǥ���� �������� ���
            offset = squareRectTransform.position - (Vector3)eventData.position;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        // ���콺 ���� ��ư�� ������ �ִ� ����
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            // Square�� ���ο� ��ġ�� ���콺 ��ġ�� ���� ����
            squareRectTransform.position = (Vector3)eventData.position + offset;
        }
    }
}
