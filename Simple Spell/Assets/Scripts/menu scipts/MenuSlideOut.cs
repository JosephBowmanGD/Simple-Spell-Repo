using UnityEngine;
using UnityEngine.UI;

public class MenuSlideOut : MonoBehaviour
{
    [Header("Space Between Meny Items")]
    [SerializeField] Vector2 space;

    public Image buttonImage1;
    public Image buttonImage2;

    Button mainButton;
    MenuSlideItems[] menuItems;
    bool isExpanded = false;
    bool isEnabled = false;

    Vector2 mainButtonPosition;
    int itemCount;

    // Start is called before the first frame update
    void Start()
    {
        itemCount = transform.childCount - 1;
        menuItems = new MenuSlideItems[itemCount];
        for (int i = 0; i < itemCount; i++)
        {
            menuItems[i] = transform.GetChild(i + 1).GetComponent<MenuSlideItems>();
        }

        mainButton = transform.GetChild(0).GetComponent<Button>();
        mainButton.onClick.AddListener(ToggleMenu);
        mainButton.onClick.AddListener(ToggleImage);
        mainButton.transform.SetAsLastSibling();
        mainButtonPosition = mainButton.transform.position;

        ResetPositions();
    }

    void ResetPositions()
    {
        for (int i = 0; i < itemCount; i++)
        {
            menuItems[i].trans.position = mainButtonPosition;
        }
    }

    void ToggleMenu()
    {
        isExpanded = !isExpanded;

        if (isExpanded)
        {
            for (int i = 0; i < itemCount; i++)
            {
                menuItems[i].trans.position = mainButtonPosition + space * (i + 1);
            }
        }
        else
        {
            for (int i = 0; i < itemCount; i++)
            {
                menuItems[i].trans.position = mainButtonPosition;
            }
        }
    }
    void ToggleImage()
    {
        isEnabled = !isEnabled;

        if (isEnabled)
        {
            buttonImage1.enabled = true;
            buttonImage2.enabled = true;
        }
        else
        {
            buttonImage1.enabled = false;
            buttonImage2.enabled = false;
        }
    }

    private void OnDestroy()
    {
        mainButton.onClick.RemoveListener(ToggleMenu);
    }
}
