using UnityEngine;

public class FindAllBucketRoomButtons : MonoBehaviour
{
    void Start()
    {
        // BucketRoomButton ��ũ��Ʈ�� �ο��� ��� ������Ʈ ã��
        BucketRoomButton[] buttons = FindObjectsOfType<BucketRoomButton>();

        // ã�� ������Ʈ�鿡 ���� ���� ���
        foreach (BucketRoomButton button in buttons)
        {
            Debug.Log("Found a BucketRoomButton on GameObject: " + button.gameObject.name);
        }
    }
}
