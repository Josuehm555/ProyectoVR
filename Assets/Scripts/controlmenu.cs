using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlmenu : MonoBehaviour
{
    // Start is called before the first frame update
    public bool activar;

    public void setanimar()
    {

        activar = true;
    }

    public void desabilitaranimacion()
    {
        activar = false;
    }

    public bool getanimar()

    {
        return activar;
    }
}
