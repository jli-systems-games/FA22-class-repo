using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace godzillabanana
{
    public class CraftManager : MonoBehaviour
    {

        private Unicode currentUnicorn;
        public Image customCursor;
        public Slot[] craftingSlots;


        public void OnMouseDownItem(Unicode item)
        {
            if(currentUnicorn == null)
            {
                currentUnicorn = item;
                customCursor.gameObject.SetActive(true);
                customCursor.sprite = currentUnicorn.GetComponent<Image>().sprite;
                customCursor.color = currentUnicorn.GetComponent<Image>().color;
            }

        }
       

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonUp(0)) {
                if (currentUnicorn != null)
                {
                    customCursor.gameObject.SetActive(false);
                    Slot nearestSlot = null;
                    float shortestDistance = float.MaxValue;


                    foreach (Slot slot in craftingSlots)
                    {
                       float dist =  Vector2.Distance(Input.mousePosition, slot.transform.position);
                        if (dist < shortestDistance)
                        {
                            shortestDistance = dist;
                            nearestSlot = slot;
                        }
                    }
                    nearestSlot.gameObject.SetActive(true);
                    nearestSlot.GetComponent<Image>().sprite = currentUnicorn.GetComponent<Image>().sprite;
                    nearestSlot.GetComponent<Image>().color = currentUnicorn.GetComponent<Image>().color;
                    nearestSlot.item = currentUnicorn;
                    currentUnicorn = null;
                }

            }
        }
    }
}