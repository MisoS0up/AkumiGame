using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class itemSlot : MonoBehaviour, IDropHandler
{
    public int id;
    public void OnDrop(PointerEventData eventData)
    {
        
        if(eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.GetComponent<DragDrop>().id == id)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                Debug.Log("ID_PLACED_CORRECTLY  ~~");
                GameObject.Find("checker").GetComponent<ifCompleteChecker>().AddPoints();
              
                
            }
            else
            {
                eventData.pointerDrag.GetComponent<DragDrop>().ResetPuzzlePos();
                Debug.Log("ID_PLACED_INCORRECTLY");
            
            }
            
        }
    }

 


}
