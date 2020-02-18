using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeMixer : MonoBehaviour
{
    public AudioMixer m_mixer;
    public string m_exposedParameter;

    private Slider _slider;


    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    public void ChangeVolume()
    {
        if (_slider == null)
            _slider = GetComponent<Slider>();

        m_mixer.SetFloat(m_exposedParameter, _slider.value);
    }
}
