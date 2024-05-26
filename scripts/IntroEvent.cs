using UnityEngine;
using System.Collections;
using UnityEngine.UI; // UI ���� ���ӽ����̽� �߰�

public class IntroEventController : MonoBehaviour
{
    public GameObject alarmParent; // IntroEvent�� �ڽ� ������Ʈ���� ������ �ִ� �θ� ������Ʈ
    public GameObject iconSearchButton; // Iconsearch ��ư
    public GameObject iconSNSButton; // iconSNS ��ư
    public Image backgroundImage; // ��� �̹���
    public GameObject month4bucketButton; // month4bucket ��ư
    public Sprite pandaImage; // panda �̹��� ��������Ʈ
    public GameObject checkmark;

    void Start()
    {

        month4bucketButton.GetComponent<Button>().onClick.AddListener(StartEvent);
    }

    // �̺�Ʈ ���� �޼���
    void StartEvent()
    {
        checkmark.gameObject.SetActive(true);
        StartCoroutine(ActivateAlarms());
    }

    IEnumerator ActivateAlarms()
    {

        //yield return new WaitForSeconds(5f); // MainScene�� ���۵� �� 5�� ���

        // IntroEvent�� �ڽ� ������Ʈ���� �ϳ��� Ȱ��ȭ
        foreach (Transform child in alarmParent.transform)
        {
            child.gameObject.SetActive(true);
            yield return new WaitForSeconds(1.2f); // 1.2�� ���
        }

        // ��� alarm ������Ʈ�� �ٽ� ��Ȱ��ȭ
        foreach (Transform child in alarmParent.transform)
        {
            child.gameObject.SetActive(false);
        }

        // Iconsearch�� iconSNS ��ư Ȱ��ȭ
        if (iconSearchButton != null)
        {
            iconSearchButton.SetActive(true);
        }
        if (iconSNSButton != null)
        {
            iconSNSButton.SetActive(true);
        }

        // ��� �̹����� panda �̹����� ����
        if (backgroundImage != null && pandaImage != null)
        {
            backgroundImage.sprite = pandaImage;
            // ��� �̹����� color�� �Ͼ������ ����
            backgroundImage.color = Color.white;
        }

        // month4bucketButton�� Button ������Ʈ ��������
        Button buttonComponent = month4bucketButton.GetComponent<Button>();

        // ��ư�� ���ͷ����� ��Ȱ��ȭ
        buttonComponent.interactable = false;
    }
}


