using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    public ParticleSystem m_particle;
    private Camera _mainCamera;

    private void Start()
    {
        _mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }
    public void SpawnParticles(Transform tr_Button)
    {
        //Debug.Log("Particles!!");
        Vector3 mousePosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        //Debug.Log(mousePosition);
        //Instantiate(m_particle, tr_Button);
        Instantiate(m_particle, mousePosition, Quaternion.identity);
    }
}
