using UnityEngine;

public class CursorChanger : MonoBehaviour
{
    public Texture2D cursorTexture; // ����� Ŀ�� �ؽ���
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    void Start()
    {
        // ���� �ÿ� ���콺 Ŀ�� ����� ����
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    // �ٸ� ������ ȣ���Ͽ� ���콺 Ŀ���� ������ �� �ִ� �޼���
    public void ChangeCursor()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    // �⺻ ���콺 Ŀ���� �����ϴ� �޼���
    public void ResetCursor()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
}
