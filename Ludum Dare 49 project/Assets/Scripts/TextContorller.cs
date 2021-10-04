using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextContorller : MonoBehaviour
{
    [SerializeField] private TMP_Text _textField;
    private ReactionController _reactionController;

    private void Start()
    {
        _textField = GetComponent<TMP_Text>();
        _reactionController.OnNucleeExploded += _reactionController_OnNucleeExploded;
    }

    private void _reactionController_OnNucleeExploded(object sender, ReactionController.OnNucleeExplodedEventArgs e)
    {
        _textField.text = e.Score.ToString();
    }
}
