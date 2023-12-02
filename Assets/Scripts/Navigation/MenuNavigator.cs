using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuNavigator : MonoBehaviour
{
    public Image panel;
    public List<Sprite> sprites;

    public void ChangeMenuBackground(int index)
    {
        panel.sprite = sprites[index];
    }
}
