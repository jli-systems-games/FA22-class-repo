using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace godzillabanana{

public class Unicode : MonoBehaviour, IEndDragHandler, IDragHandler
{
        [SerializeField] private Canvas canvas;
        public Transform rectTransform;
        public CanvasGroup canvasgroup;
    public bool isClicked;
    public int poop;
    // Start is called before the first frame update
    void Start()
    {
            rectTransform = GetComponent<RectTransform>();
            canvasgroup = GetComponent<CanvasGroup>();
        }

    // Update is called once per frame
    void Update()
    {
        poop += 1;
    }


        public void OnDrag(PointerEventData eventData)
        {

        //rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
        public void OnEndDrag(PointerEventData eventData)
        {

        }
}
}
