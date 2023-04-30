using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trans_Scene : MonoBehaviour
{
    public Animator transition;
    public int sceneNumber;
    public float transitionTime = 1f;
    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            LoadALevel();
        }
    }

    public void LoadALevel()
    {
        StartCoroutine(LoadLevel(sceneNumber));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("LoadScene");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }

}
