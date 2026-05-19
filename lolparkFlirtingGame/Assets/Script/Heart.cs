using UnityEngine;
using UnityEngine.EventSystems;

public class Heart : MonoBehaviour, IPointerClickHandler
{
    ResourceControl resourceControl;
    [SerializeField] GameObject aim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resourceControl = GameObject.Find("BasicResource").GetComponent<ResourceControl>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("has Click");
        resourceControl.getResourse();
    }
}
