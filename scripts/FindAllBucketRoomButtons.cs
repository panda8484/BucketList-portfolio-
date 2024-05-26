using UnityEngine;

public class FindAllBucketRoomButtons : MonoBehaviour
{
    void Start()
    {
        // BucketRoomButton 스크립트가 부여된 모든 오브젝트 찾기
        BucketRoomButton[] buttons = FindObjectsOfType<BucketRoomButton>();

        // 찾은 오브젝트들에 대한 정보 출력
        foreach (BucketRoomButton button in buttons)
        {
            Debug.Log("Found a BucketRoomButton on GameObject: " + button.gameObject.name);
        }
    }
}
