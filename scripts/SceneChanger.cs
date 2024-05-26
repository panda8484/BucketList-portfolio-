using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneChanger : MonoBehaviour
{
    // Inspector â���� ������ �� �̸�
    [SerializeField]
    // ��ȯ�� ���� �⺻���� ���Ƿ� ����
    private string targetSceneName = "mainscreen";

    // �ڵ����� ��ȯ�� �ð� (��)
    public float autoTransitionTime = 2f;

    void Start()
    {
        // Start �޼��忡�� ������ �ð��� ���� �Ŀ� ��ȯ�ϴ� �ڷ�ƾ ����
        StartCoroutine(AutoTransition());
    }

    IEnumerator AutoTransition()
    {
        // autoTransitionTime ��ŭ ��ٸ� �Ŀ�
        yield return new WaitForSeconds(autoTransitionTime);

        // targetSceneName�� ������ ������ ��ȯ
        SceneManager.LoadScene(targetSceneName);
    }
}
