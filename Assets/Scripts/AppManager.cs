using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class AppManager : MonoBehaviour
{
public void MyQuit()
    {
		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		#else
			Application.Quit();
		#endif
	}

public void CargarLevel0()
    {

		SceneManager.LoadScene(2);

    }


}

