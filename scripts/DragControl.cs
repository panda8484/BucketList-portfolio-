using UnityEngine;
using UnityEngine.EventSystems;

public class DragControl : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    private RectTransform squareRectTransform; // Rename variable to represent the square
    private Vector3 offset;

    private void Start()
    {
        // Square의 RectTransform 컴포넌트를 가져옴
        squareRectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // 마우스 왼쪽 버튼이 클릭된 경우
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            // 현재 마우스 위치에서 Square의 로컬 좌표로의 오프셋을 계산
            offset = squareRectTransform.position - (Vector3)eventData.position;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        // 마우스 왼쪽 버튼을 누르고 있는 동안
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            // Square의 새로운 위치를 마우스 위치에 따라 설정
            squareRectTransform.position = (Vector3)eventData.position + offset;
        }
    }
}
