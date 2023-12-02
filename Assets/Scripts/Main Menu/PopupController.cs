using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PopupController : MonoBehaviour
{
   public GameObject popup;
   public void ChangePopupState()
   {
      if (popup.activeInHierarchy)
      {
         popup.SetActive(false);         
      }
      else
      {
         popup.SetActive(true);
      }
   }
}
