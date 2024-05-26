using UnityEngine;

public class ButtonClickHandler : MonoBehaviour
{
    // Inspector에서 memoscreen의 좌표를 지정해주세요.
    public Transform memoscreen;

    // Inspector에서 button1 버튼을 연결해주세요.
    public GameObject button1;
    public GameObject button2;

    // Inspector에서 screen1 이미지를 연결해주세요.
    public GameObject screen1;
    public GameObject screen2;

    private Vector3 defaultPosition = new Vector3(3062f, 478f, 0f);

    private void Start()
    {
        // button1 버튼에 클릭 이벤트를 추가합니다.
        button1.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(OnButton1Click);
        // button2 버튼에 클릭 이벤트를 추가합니다.
        button2.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(OnButton2Click);
    }

    private void OnButton1Click()
    {

        screen2.transform.position = defaultPosition;
        Debug.Log("go back2");

        // screen1 이미지를 memoscreen 좌표로 이동시킵니다.
        Vector3 newPosition = memoscreen.position;
        newPosition.y -= 28f; // y 값을 -30으로 수정
        screen1.transform.position = newPosition;

    }

    private void OnButton2Click()
    {
        screen1.transform.position = defaultPosition;
        Debug.Log("go back1");


        // screen2 이미지를 memoscreen 좌표로 이동시킵니다.
        Vector3 newPosition = memoscreen.position;
        newPosition.y -= 28f; // y 값을 -30으로 수정
        screen2.transform.position = newPosition;

    }

    //private void Update()
    //{
    //    // 버튼이 클릭되지 않을 때 기본 위치로 이동합니다.
    //    if (!button1.GetComponent<UnityEngine.UI.Button>().interactable)
    //    {
    //        screen1.transform.position = defaultPosition;
    //        Debug.Log("go back1");
    //    }

    //    // 버튼이 클릭되지 않을 때 기본 위치로 이동합니다.
    //    if (!button2.GetComponent<UnityEngine.UI.Button>().interactable)
    //    {
    //        screen2.transform.position = defaultPosition;
    //        Debug.Log("go back2");
    //    }
    //}
}