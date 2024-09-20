using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;
namespace TwoPm.TooltipDemo {
    public class TextPanelViewController : MonoBehaviour
    {
        public Text TextTitle;
        public Text TextDesc;
        public UnityEngine.UI.Image Image;

        public string Label
        {
            get
            {
                return TextTitle.text;
            }

            set
            {
                TextTitle.text = value;
            }
        }
        public string LabelDesc
        {
            get
            {
                return TextDesc.text;
            }

            set
            {
                TextDesc.text = value;
            }
        }

        public float Padding = 10f;

        public bool Center = false;
        private Vector2 _initialPosition;
        private Vector2 _initialSize;


        // Start is called before the first frame update
        void Start() {
            Assert.IsNotNull(TextTitle);
            Assert.IsNotNull(Image);

            //initialPosition = (transform as RectTransform).anchoredPosition;
           // _initialSize = Image.rectTransform.sizeDelta - Vector2.right * Padding;
        }

        // Update is called once per frame
        void Update() {
            /* Image.rectTransform.sizeDelta = new Vector2(Text.preferredWidth + Padding, 30);

             if (Center) {
                 var sizeDiff = Image.rectTransform.sizeDelta - _initialSize;
                 (transform as RectTransform).anchoredPosition = _initialPosition - new Vector2(sizeDiff.x / 2f, 0);
             }*/
        }
    }
}