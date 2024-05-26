using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneChanger : MonoBehaviour
{
    // Inspector 창에서 지정할 씬 이름
    [SerializeField]
    // 전환할 씬의 기본값을 임의로 설정
    private string targetSceneName = "mainscreen";

    // 자동으로 전환될 시간 (초)
    public float autoTransitionTime = 2f;

    void Start()
    {
        // Start 메서드에서 지정된 시간이 지난 후에 전환하는 코루틴 시작
        StartCoroutine(AutoTransition());
    }

    IEnumerator AutoTransition()
    {
        // autoTransitionTime 만큼 기다린 후에
        yield return new WaitForSeconds(autoTransitionTime);

        // targetSceneName에 지정된 씬으로 전환
        SceneManager.LoadScene(targetSceneName);
    }
}
