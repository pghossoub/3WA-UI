using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefManager : MonoBehaviour
{
    public string m_settingName;

    private float _floatValue;

    private Slider _slider;
    private Toggle _toggle;

    private void OnEnable()
    {
        //_slider = GetComponent<Slider>();
        LoadPrefs();
    }

    public void LoadPrefs()
    {
        if (PlayerPrefs.HasKey(m_settingName))
        {
            if (gameObject.CompareTag("Slider"))
            {
                _slider = GetComponent<Slider>();
                _floatValue = PlayerPrefs.GetFloat(m_settingName);
                _slider.value = _floatValue;
            }
            else if (gameObject.CompareTag("Toggle"))
            {
                _toggle = GetComponent<Toggle>();
                _toggle.isOn = PlayerPrefs.GetInt(m_settingName) == 1 ? true : false;

            }
        }
    }

    public void SavePrefs()
    {
        if (gameObject.CompareTag("Slider"))
        {
            _slider = GetComponent<Slider>();
            _floatValue = _slider.value;
            PlayerPrefs.SetFloat(m_settingName, _floatValue);
        }

        else if (gameObject.CompareTag("Toggle"))
        {
            _toggle = GetComponent<Toggle>();
            PlayerPrefs.SetInt(m_settingName, _toggle.isOn ? 1 : 0);
        }
    }
}
