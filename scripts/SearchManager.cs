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
//        // �ʱ�ȭ�� �ܾ�� square ������Ʈ�� �߰��մϴ�.
//        AddKeywordPanelPair("��Ŷ����Ʈ", ResultPanel1);
//        AddKeywordPanelPair("���ɳ���", ResultPanel2);
//        AddKeywordPanelPair("����", ResultPanel3);
//        AddKeywordPanelPair("�����", ResultPanel4);
//        AddKeywordPanelPair("����", ResultPanel5);

//        // ��ư Ŭ�� ������ ���
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
//                Debug.Log("�� : keywordCollection[keyword] �� ���ο� �г���?");
//                MovePanelToOldPosition(oldObject);
//                Debug.Log(oldObject);
//                Debug.Log("�� : 2��° ȸ�� oldobject�� ����");
//                Debug.Log(keywordCollection[keyword]);
//                Debug.Log("�� : keywordCollection[keyword]�� ����?");
//                MovePanelToSpecificPosition(keywordCollection[keyword]);
//                oldObject = keywordCollection[keyword];
//                oldPosition = GetCenterPosition(oldObject);
//                Debug.Log(oldPosition);
//                Debug.Log(oldObject);
//                Debug.Log("��: ���ο� oldposition, oldObject ����");

//            }

//            else
//            {
//                oldObject = keywordCollection[keyword];
//                oldPosition = GetCenterPosition(oldObject);
//                Debug.Log(oldPosition);
//                Debug.Log(oldObject);
//                Debug.Log("���� 2��: �õ� ������, ������Ʈ");
//                Debug.Log(keywordCollection[keyword]);
//                Debug.Log("�� : ùȸ�� keywordCollection[keyword] �� ������Ʈ");
//                MovePanelToSpecificPosition(keywordCollection[keyword]);
//            }
//        }
//    }

//    Vector2 GetCenterPosition(GameObject panel)
//    {
//        // SearchScreen�� �ڽ����� �г� �̵�
//        panel.transform.SetParent(SearchScreen, false);

//        float centerX = SearchScreen.rect.width * 0.5f;
//        float centerY = SearchScreen.rect.height * 0.5f;

//        RectTransform panelTransform = panel.GetComponent<RectTransform>();
//        return new Vector2(centerX, centerY);
//        Debug.Log("�� : old panel�� �߾Ӱ��� ����?");

//        // resultPanel�� ResultPanels�� �ڽ� ��ҷ� �̵���ŵ�ϴ�.
//        panel.transform.SetParent(resultPanelsParent);
//    }

//    void MovePanelToOldPosition(GameObject panel)
//    {
//        RectTransform panelTransform = panel.GetComponent<RectTransform>();
//        panelTransform.anchoredPosition = oldPosition;
//        Debug.Log(panelTransform.anchoredPosition);
//        Debug.Log(oldPosition);
//        Debug.Log("old�� ���� ��ǥ�� �ű�");
//    }

//    void MovePanelToSpecificPosition(GameObject panel)
//    {
//        // SearchScreen�� �ڽ����� �г� �̵�
//        panel.transform.SetParent(SearchScreen, false);

//        float centerX = SearchScreen.rect.width * 0.5f;
//        float centerY = SearchScreen.rect.height * 0.5f;

//        RectTransform panelTransform = panel.GetComponent<RectTransform>();
//        panelTransform.anchoredPosition = new Vector2(centerX, centerY);
//        Debug.Log(panelTransform.anchoredPosition);
//        Debug.Log("�� : Ư�� ��ǥ�� �ű�");
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
    public GameObject prefab1; // Inspector���� ������ ������
    public GameObject prefab2; // Inspector���� ������ ������
    public GameObject prefab3; // Inspector���� ������ ������
    public GameObject searchScreen; // SearchScreen ������Ʈ
    public Button SearchButton;

    private Vector3 originalPosition; // moveObject�� original ��ġ ��ǥ�� ������ ����
    private Vector3 specificPosition; // Ŭ���� ��ư�� ��ġ ��ǥ�� ������ ����

    public Text searchKeyword;
    public Dictionary<string, GameObject> keywordCollection = new Dictionary<string, GameObject>();

    private GameObject resultPrefab; // resultPrefab ���� ����

    void Start()
    {
        // �ʱ�ȭ�� �ܾ�� square ������Ʈ�� �߰��մϴ�.
        AddKeywordPanelPair("��Ŷ����Ʈ", prefab1);
        AddKeywordPanelPair("����", prefab3);
        AddKeywordPanelPair("���ɳ���", prefab2);
        //AddKeywordPanelPair("�����", prefab4);
        //ddKeywordPanelPair("����", prefab5);
        Debug.Log("start");


        // ��ư Ŭ�� ������ ���
        //Button searchButton = GameObject.Find("SearchButton").GetComponent<Button>();
        SearchButton.onClick.AddListener(CheckAndMovePanel);


    }


    void CheckAndMovePanel()
    {
        string keyword = searchKeyword.text.Trim();

        if (keywordCollection.ContainsKey(keyword))
        {
            GameObject resultPrefab = keywordCollection[keyword]; 
            resultPrefab.transform.position = searchScreen.transform.position; // ��ġ�� searchScreen�� ��ġ�� ����

            Debug.Log("�˻�ȭ�� �̵�");
        }


    }
    void AddKeywordPanelPair(string keyword, GameObject prefab)
    {
        keywordCollection[keyword] = prefab;
    }

}





