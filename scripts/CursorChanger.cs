using UnityEngine;

public class CursorChanger : MonoBehaviour
{
    public Texture2D cursorTexture; // 사용할 커서 텍스쳐
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    void Start()
    {
        // 시작 시에 마우스 커서 모양을 변경
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    // 다른 곳에서 호출하여 마우스 커서를 변경할 수 있는 메서드
    public void ChangeCursor()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    // 기본 마우스 커서로 변경하는 메서드
    public void ResetCursor()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
}
