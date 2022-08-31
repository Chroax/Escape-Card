using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
public class DropHint : MonoBehaviour, IDropHandler
{
    [SerializeField] private TextMeshProUGUI hintText;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            Debug.Log("AHAHAHAAHAHAH");
            CardDetailSO cardDetail = eventData.pointerDrag.GetComponent<Card>().cardDetail;
            this.GetComponent<Image>().sprite= cardDetail.cardSprite;
            
            hintText.text = cardDetail.cardHint;
        }
    }
}
