//using UnityEngine;
//using UnityEngine.UI;
//using System.Collections.Generic;

//public class SearchManager : MonoBehaviour
//{
//    public Text searchKeyword;
//    public RectTransform SearchScreen;
//    public Dictionary<string, GameObject> keywordCollection = new Dictionary<string, GameObject>();
//    private Vector2 specificPosition;
//    private GameObject oldObject;
//    private Vector2 oldPosition;
//    public GameObject ResultPanel1;
//    public GameObject ResultPanel2;
//    public GameObject ResultPanel3;
//    public GameObject ResultPanel4;
//    public GameObject ResultPanel5;
//    public Transform resultPanelsParent;

//    void Start()
//    {
//        // 초기화할 단어와 square 오브젝트를 추가합니다.
//        AddKeywordPanelPair("버킷리스트", ResultPanel1);
//        AddKeywordPanelPair("벚꽃놀이", ResultPanel2);
//        AddKeywordPanelPair("날씨", ResultPanel3);
//        AddKeywordPanelPair("토요일", ResultPanel4);
//        AddKeywordPanelPair("인파", ResultPanel5);

//        // 버튼 클릭 리스너 등록
//        Button searchButton = GameObject.Find("SearchButton").GetComponent<Button>();
//        searchButton.onClick.AddListener(CheckAndMovePanel);
//    }

//    void CheckAndMovePanel()
//    {
//        string keyword = searchKeyword.text.Trim();

//        if (keywordCollection.ContainsKey(keyword))
//        {
//            if (oldObject != null)
//            {
//                Debug.Log(keywordCollection[keyword]);
//                Debug.Log("위 : keywordCollection[keyword] 즉 새로운 패널은?");
//                MovePanelToOldPosition(oldObject);
//                Debug.Log(oldObject);
//                Debug.Log("위 : 2번째 회차 oldobject가 뭐니");
//                Debug.Log(keywordCollection[keyword]);
//                Debug.Log("위 : keywordCollection[keyword]가 뭐니?");
//                MovePanelToSpecificPosition(keywordCollection[keyword]);
//                oldObject = keywordCollection[keyword];
//                oldPosition = GetCenterPosition(oldObject);
//                Debug.Log(oldPosition);
//                Debug.Log(oldObject);
//                Debug.Log("위: 새로운 oldposition, oldObject 뭐니");

//            }

//            else
//            {
//                oldObject = keywordCollection[keyword];
//                oldPosition = GetCenterPosition(oldObject);
//                Debug.Log(oldPosition);
//                Debug.Log(oldObject);
//                Debug.Log("위의 2개: 올드 포지션, 오브젝트");
//                Debug.Log(keywordCollection[keyword]);
//                Debug.Log("위 : 첫회차 keywordCollection[keyword] 즉 오브젝트");
//                MovePanelToSpecificPosition(keywordCollection[keyword]);
//            }
//        }
//    }

//    Vector2 GetCenterPosition(GameObject panel)
//    {
//        // SearchScreen의 자식으로 패널 이동
//        panel.transform.SetParent(SearchScreen, false);

//        float centerX = SearchScreen.rect.width * 0.5f;
//        float centerY = SearchScreen.rect.height * 0.5f;

//        RectTransform panelTransform = panel.GetComponent<RectTransform>();
//        return new Vector2(centerX, centerY);
//        Debug.Log("위 : old panel의 중앙값이 뭐니?");

//        // resultPanel을 ResultPanels의 자식 요소로 이동시킵니다.
//        panel.transform.SetParent(resultPanelsParent);
//    }

//    void MovePanelToOldPosition(GameObject panel)
//    {
//        RectTransform panelTransform = panel.GetComponent<RectTransform>();
//        panelTransform.anchoredPosition = oldPosition;
//        Debug.Log(panelTransform.anchoredPosition);
//        Debug.Log(oldPosition);
//        Debug.Log("old를 원래 좌표로 옮김");
//    }

//    void MovePanelToSpecificPosition(GameObject panel)
//    {
//        // SearchScreen의 자식으로 패널 이동
//        panel.transform.SetParent(SearchScreen, false);

//        float centerX = SearchScreen.rect.width * 0.5f;
//        float centerY = SearchScreen.rect.height * 0.5f;

//        RectTransform panelTransform = panel.GetComponent<RectTransform>();
//        panelTransform.anchoredPosition = new Vector2(centerX, centerY);
//        Debug.Log(panelTransform.anchoredPosition);
//        Debug.Log("위 : 특별 좌표로 옮김");
//    }

//    void AddKeywordPanelPair(string keyword, GameObject panel)
//    {
//        keywordCollection[keyword] = panel;
//    }
//}


//-------------------------------------------------------------------------------------------------------------------------


using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Device;

public class SearchManager : MonoBehaviour
{
    public GameObject prefab1; // Inspector에서 설정할 프리팹
    public GameObject prefab2; // Inspector에서 설정할 프리팹
    public GameObject prefab3; // Inspector에서 설정할 프리팹
    public GameObject searchScreen; // SearchScreen 오브젝트
    public Button SearchButton;

    private Vector3 originalPosition; // moveObject의 original 위치 좌표를 저장할 변수
    private Vector3 specificPosition; // 클릭할 버튼의 위치 좌표를 저장할 변수

    public Text searchKeyword;
    public Dictionary<string, GameObject> keywordCollection = new Dictionary<string, GameObject>();

    private GameObject resultPrefab; // resultPrefab 변수 선언

    void Start()
    {
        // 초기화할 단어와 square 오브젝트를 추가합니다.
        AddKeywordPanelPair("버킷리스트", prefab1);
        AddKeywordPanelPair("날씨", prefab3);
        AddKeywordPanelPair("벚꽃놀이", prefab2);
        //AddKeywordPanelPair("토요일", prefab4);
        //ddKeywordPanelPair("인파", prefab5);
        Debug.Log("start");


        // 버튼 클릭 리스너 등록
        //Button searchButton = GameObject.Find("SearchButton").GetComponent<Button>();
        SearchButton.onClick.AddListener(CheckAndMovePanel);


    }


    void CheckAndMovePanel()
    {
        string keyword = searchKeyword.text.Trim();

        if (keywordCollection.ContainsKey(keyword))
        {
            GameObject resultPrefab = keywordCollection[keyword]; 
            resultPrefab.transform.position = searchScreen.transform.position; // 위치를 searchScreen의 위치로 설정

            Debug.Log("검색화면 이동");
        }


    }
    void AddKeywordPanelPair(string keyword, GameObject prefab)
    {
        keywordCollection[keyword] = prefab;
    }

}





