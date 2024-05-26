using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenetomonth4: MonoBehaviour
{
    // 넘어갈 씬의 이름
    public string sceneName = "month4";

    // 버튼 클릭 시 호출되는 함수
    public void ChangeScene()
    {
        // sceneName에 지정된 씬으로 이동
        SceneManager.LoadScene(sceneName);
    }
}

