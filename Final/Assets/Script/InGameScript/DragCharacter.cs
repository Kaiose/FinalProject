using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
 
public class DragCharacter : MonoBehaviour , ISelectHandler, IPointerClickHandler, IDeselectHandler{

    [SerializeField] 
    private GameObject SelectEffect;

    public static HashSet<DragCharacter> allMySelectables = new HashSet<DragCharacter>();
    public static HashSet<DragCharacter> currentlySelected = new HashSet<DragCharacter>();

    Renderer myRenderer;

    [SerializeField]
    Material unselectedMaterial;
    [SerializeField]
    Material selectedMaterial;
    void Awake()
    {
        allMySelectables.Add(this);
        myRenderer = GetComponent<Renderer>();
    }

    //private void OnMouseDrag()
    //{
    //    GameObject obj = GameObject.Instantiate(SelectEffect);
    //    obj.transform.parent = transform;
    //}
    public void OnPointerClick(PointerEventData eventData)
    {
        print("Click");
        OnSelect(eventData); ;
    }

    public void OnSelect(BaseEventData eventData)
    {

        DeselectAll(eventData);
        currentlySelected.Add(this);
        SelectEffect.SetActive(true);
        GameObject obj = GameObject.Instantiate(SelectEffect);
           obj.transform.parent = transform;
    }


    public void OnDeselect(BaseEventData eventData)
    {
        SelectEffect.SetActive(false);
    }

    public static void DeselectAll(BaseEventData eventData)
    {
        foreach(DragCharacter selectable in currentlySelected)
        {
            selectable.OnDeselect(eventData);
        }
        currentlySelected.Clear();

    }
}
