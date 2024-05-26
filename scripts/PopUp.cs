using UnityEngine;

public class PopUP : MonoBehaviour
{
    public GameObject popUpScreen;  // Inspector â���� ������ 2D ������Ʈ

    // ��ư ��� ���¿� ���� ȣ��Ǵ� �޼���
    public void PopUpControl()
    {
        // popUpScreen ������Ʈ�� Ȱ��ȭ ���¸� ����մϴ�.
        popUpScreen.SetActive(!popUpScreen.activeSelf);

        // popUpScreen ������Ʈ�� ��� ���� ������Ʈ�� �����ɴϴ�.
        foreach (Transform child in popUpScreen.transform)
        {
            // �� ���� ������Ʈ�� Ȱ��ȭ ���¸� popUpScreen�� �����ϰ� �����մϴ�.
            child.gameObject.SetActive(popUpScreen.activeSelf);
        }

        if (popUpScreen.activeSelf)
        {
            Debug.Log("�˾� Ȱ��ȭ");
        }
        else
        {
            Debug.Log("�˾� ��Ȱ��ȭ");
        }
    }
}