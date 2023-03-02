using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MainMenuUI
{
    public class LevelPanel : MonoBehaviour
    {
        [SerializeField] private List<Button> _buttons;

        private List<TMP_Text> _texts = new List<TMP_Text>();

        private void Start()
        {
            for (int i = 0; i < _buttons.Count; i++)
            {
                int number = i + 1;
                _buttons[i].gameObject.GetComponentInChildren<TMP_Text>().text = number.ToString();
            }
        }
    }
}