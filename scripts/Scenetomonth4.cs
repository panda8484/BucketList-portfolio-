using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenetomonth4: MonoBehaviour
{
    // �Ѿ ���� �̸�
    public string sceneName = "month4";

    // ��ư Ŭ�� �� ȣ��Ǵ� �Լ�
    public void ChangeScene()
    {
        // sceneName�� ������ ������ �̵�
        SceneManager.LoadScene(sceneName);
    }
}

