using TMPro;
using UnityEngine;

namespace Utils
{
    public class ValueToText : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;

        public void SetText(float value)
        {
            _text.text = value.ToString("0.00");
        }
    }
}
