using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmallInfoDisplay : MonoBehaviour
{
   [SerializeField] private Text ObjectNameText;
   [SerializeField] private Image ObjectSpriteImage;//Each Truck will have own UI Sprite (eventually)
   [SerializeField] private Button CloseButton;

   private GameController gc;
   
   void Start()
   {
      gc = FindObjectOfType<GameController>();
   }

   public void SetObjectName(string name)
   {
      ObjectNameText.text = name;
   }

   public void SetObjectSprite(Sprite sprite)
   {
      ObjectSpriteImage.sprite = sprite;
   }

   public void Close()
   {
      Destroy(this.gameObject);
   }
}
