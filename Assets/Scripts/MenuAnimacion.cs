using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnimacion : MonoBehaviour
{
    // Start is called before the first frame update

    Animator miCompAnimacion;
    private bool m_animar;
    public GameObject controlmenu;

    void Start()
    {
        miCompAnimacion = gameObject.GetComponent<Animator>();
        m_animar = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_animar)
            CargarAnimacion();
        else
            DetenerAnimacion();


    }

    void CargarAnimacion()
    {

        miCompAnimacion.SetBool("activomenu", true);
    }

    void DetenerAnimacion()
    {
        miCompAnimacion.SetBool("activomenu", false);
    }

    public void setanimar()
    {

        m_animar = true;    
    }

    public void desabilitaranimacion()
    {
        m_animar = false;  
    }

}
