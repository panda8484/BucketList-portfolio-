using UnityEngine;

public class PopUP : MonoBehaviour
{
    public GameObject popUpScreen;  // Inspector 창에서 연결할 2D 오브젝트

    // 버튼 토글 상태에 따라 호출되는 메서드
    public void PopUpControl()
    {
        // popUpScreen 오브젝트의 활성화 상태를 토글합니다.
        popUpScreen.SetActive(!popUpScreen.activeSelf);

        // popUpScreen 오브젝트의 모든 하위 오브젝트를 가져옵니다.
        foreach (Transform child in popUpScreen.transform)
        {
            // 각 하위 오브젝트의 활성화 상태를 popUpScreen과 동일하게 설정합니다.
            child.gameObject.SetActive(popUpScreen.activeSelf);
        }

        if (popUpScreen.activeSelf)
        {
            Debug.Log("팝업 활성화");
        }
        else
        {
            Debug.Log("팝업 비활성화");
        }
    }
}