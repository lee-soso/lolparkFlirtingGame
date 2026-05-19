using UnityEngine;
using UnityEngine.EventSystems;

public class targetControl : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    ResourceControl resourceControl;
    [SerializeField] GameObject aim;
    [SerializeField] float gage = 0;

    private bool isPressed = false;
    private bool isBattle = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resourceControl = GameObject.Find("BasicResource").GetComponent<ResourceControl>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gage >= 1)
        {
            Debug.Log("It's yours.");
            Destroy(this.gameObject);
        }
        if (isPressed) 
        {
            resourceControl.useResourceOneTick();
            gage += 0.5f / Application.targetFrameRate;
        }
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (isBattle)
        {
            resourceControl.useResourceOneClick();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (isBattle == false)
        {
            Debug.Log("has Click");
            isPressed = true;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (isBattle == false)
        {
            Debug.Log("end of Click");
            isPressed = false;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        aim.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        aim.SetActive(false);
    }

    private bool isGageMax()
    {
        if(gage > 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}