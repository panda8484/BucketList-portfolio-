

using UnityEngine;
using UnityEngine.UI;

public class RainySelect : MonoBehaviour
{
    public Button myButton; // Inspector에서 할당
    public Button[] targetButtons; // Inspector에서 여러 sundayselectButton 할당
    public GameObject wordlight;
    void Start()
    {
        myButton.onClick.AddListener(SetInteractableTrue);
    }

    void SetInteractableTrue()
    {
        wordlight.gameObject.SetActive(true);
        foreach (var button in targetButtons) // 모든 sundayselectButton을 활성화
        {
            if (button != null)
            {
                button.interactable = true;
            }
        }
    }
}