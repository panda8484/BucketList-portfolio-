using UnityEngine;
using UnityEngine.UI;


public class MoveObjectOnButtonClick : MonoBehaviour
{

    public GameObject moveObject;    // inspector에서 moveObject 패널을 부여
    public Button clickButton;       // inspector에서 클릭할 버튼을 지정
    private Vector3 originalPosition; // moveObject의 original 위치 좌표를 저장할 변수
    private Vector3 specificPosition; // 클릭할 버튼의 위치 좌표를 저장할 변수

    void Start()
    {
        if (moveObject != null)
        {
            originalPosition = moveObject.transform.position; // 초기에 moveObject의 현재 위치를 저장
        }

        if (clickButton != null)
        {
            // 클릭할 버튼의 위치를 기준으로 x값에 150을 더한 좌표를 specificPosition에 저장
            float newX = clickButton.transform.position.x + 150f;
            specificPosition = new Vector3(newX, clickButton.transform.position.y, clickButton.transform.position.z);

            clickButton.onClick.AddListener(ButtonClickHandler); // 버튼 클릭 리스너 등록
        }
    }

    void ButtonClickHandler()
    {
        if (moveObject != null)
        {
            // moveObject의 현재 위치가 originalPosition에 있는지 확인
            if (Vector3.Distance(moveObject.transform.position, originalPosition) < 0.01f)
            {
                // originalPosition에서 x값에 150을 더한 좌표로 이동
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

