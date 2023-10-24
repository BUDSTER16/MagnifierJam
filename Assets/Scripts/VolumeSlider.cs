using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Slider _slider;
    void Start()
    {
        _slider.onValueChanged.AddListener(delegate { onValueChange(); });
    }

    public void onValueChange()
    {
        AudioManager.instance.ChangeMasterVolume(_slider.value);
    }


}
