using UnityEngine;
using System.Collections;
using UnityEngine.UI; // UI 관련 네임스페이스 추가

public class IntroEventController : MonoBehaviour
{
    public GameObject alarmParent; // IntroEvent의 자식 오브젝트들을 가지고 있는 부모 오브젝트
    public GameObject iconSearchButton; // Iconsearch 버튼
    public GameObject iconSNSButton; // iconSNS 버튼
    public Image backgroundImage; // 배경 이미지
    public GameObject month4bucketButton; // month4bucket 버튼
    public Sprite pandaImage; // panda 이미지 스프라이트
    public GameObject checkmark;

    void Start()
    {

        month4bucketButton.GetComponent<Button>().onClick.AddListener(StartEvent);
    }

    // 이벤트 시작 메서드
    void StartEvent()
    {
        checkmark.gameObject.SetActive(true);
        StartCoroutine(ActivateAlarms());
    }

    IEnumerator ActivateAlarms()
    {

        //yield return new WaitForSeconds(5f); // MainScene이 시작된 후 5초 대기

        // IntroEvent의 자식 오브젝트들을 하나씩 활성화
        foreach (Transform child in alarmParent.transform)
        {
            child.gameObject.SetActive(true);
            yield return new WaitForSeconds(1.2f); // 1.2초 대기
        }

        // 모든 alarm 오브젝트를 다시 비활성화
        foreach (Transform child in alarmParent.transform)
        {
            child.gameObject.SetActive(false);
        }

        // Iconsearch와 iconSNS 버튼 활성화
        if (iconSearchButton != null)
        {
            iconSearchButton.SetActive(true);
        }
        if (iconSNSButton != null)
        {
            iconSNSButton.SetActive(true);
        }

        // 배경 이미지를 panda 이미지로 변경
        if (backgroundImage != null && pandaImage != null)
        {
            backgroundImage.sprite = pandaImage;
            // 배경 이미지의 color를 하얀색으로 변경
            backgroundImage.color = Color.white;
        }

        // month4bucketButton의 Button 컴포넌트 가져오기
        Button buttonComponent = month4bucketButton.GetComponent<Button>();

        // 버튼의 인터렉션을 비활성화
        buttonComponent.interactable = false;
    }
}


