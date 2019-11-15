using UnityEngine;

public class LoadOnClick : MonoBehaviour {

    public void LoadScene(int level)
    {
        Debug.Log(level);
        Application.LoadLevel(level);
    }
}