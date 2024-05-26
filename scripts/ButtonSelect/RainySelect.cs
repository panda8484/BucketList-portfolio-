

using UnityEngine;
using UnityEngine.UI;

public class RainySelect : MonoBehaviour
{
    public Button myButton; // Inspector���� �Ҵ�
    public Button[] targetButtons; // Inspector���� ���� sundayselectButton �Ҵ�
    public GameObject wordlight;
    void Start()
    {
        myButton.onClick.AddListener(SetInteractableTrue);
    }

    void SetInteractableTrue()
    {
        wordlight.gameObject.SetActive(true);
        foreach (var button in targetButtons) // ��� sundayselectButton�� Ȱ��ȭ
        {
            if (button != null)
            {
                button.interactable = true;
            }
        }
    }
}