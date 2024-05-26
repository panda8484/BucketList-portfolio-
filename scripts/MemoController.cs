using UnityEngine;

public class ButtonClickHandler : MonoBehaviour
{
    // Inspector���� memoscreen�� ��ǥ�� �������ּ���.
    public Transform memoscreen;

    // Inspector���� button1 ��ư�� �������ּ���.
    public GameObject button1;
    public GameObject button2;

    // Inspector���� screen1 �̹����� �������ּ���.
    public GameObject screen1;
    public GameObject screen2;

    private Vector3 defaultPosition = new Vector3(3062f, 478f, 0f);

    private void Start()
    {
        // button1 ��ư�� Ŭ�� �̺�Ʈ�� �߰��մϴ�.
        button1.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(OnButton1Click);
        // button2 ��ư�� Ŭ�� �̺�Ʈ�� �߰��մϴ�.
        button2.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(OnButton2Click);
    }

    private void OnButton1Click()
    {

        screen2.transform.position = defaultPosition;
        Debug.Log("go back2");

        // screen1 �̹����� memoscreen ��ǥ�� �̵���ŵ�ϴ�.
        Vector3 newPosition = memoscreen.position;
        newPosition.y -= 28f; // y ���� -30���� ����
        screen1.transform.position = newPosition;

    }

    private void OnButton2Click()
    {
        screen1.transform.position = defaultPosition;
        Debug.Log("go back1");


        // screen2 �̹����� memoscreen ��ǥ�� �̵���ŵ�ϴ�.
        Vector3 newPosition = memoscreen.position;
        newPosition.y -= 28f; // y ���� -30���� ����
        screen2.transform.position = newPosition;

    }

    //private void Update()
    //{
    //    // ��ư�� Ŭ������ ���� �� �⺻ ��ġ�� �̵��մϴ�.
    //    if (!button1.GetComponent<UnityEngine.UI.Button>().interactable)
    //    {
    //        screen1.transform.position = defaultPosition;
    //        Debug.Log("go back1");
    //    }

    //    // ��ư�� Ŭ������ ���� �� �⺻ ��ġ�� �̵��մϴ�.
    //    if (!button2.GetComponent<UnityEngine.UI.Button>().interactable)
    //    {
    //        screen2.transform.position = defaultPosition;
    //        Debug.Log("go back2");
    //    }
    //}
}