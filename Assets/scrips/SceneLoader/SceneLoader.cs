using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneLoader : MonoBehaviour
{
    public Animator transition;
    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;
    public float transitionTime = 1f;
    PlayerSavePos playerPosData;

    



     void Start()
    {
        playerPosData = FindObjectOfType<PlayerSavePos>();

    }

    public void SaveGame()
    {
        playerPosData.PlayerPosSave();
    }
    public void QuitGame()
    {
        PlayerPrefs.SetInt("SavedScene", SceneManager.GetActiveScene().buildIndex);
    }
    public void NewGame()
    {
        PlayerPrefs.DeleteKey("p_x");
        PlayerPrefs.DeleteKey("p_y");
        PlayerPrefs.DeleteKey("TimeToLoad");
        PlayerPrefs.DeleteKey("Saved");

    }
    public void LoadGame()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("SavedScene"));
        playerPosData.PlayerPosSave();
    }
    public void LoadLevel (int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
        playerPosData.PlayerPosSave();
    }
    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        loadingScreen.SetActive(true);
        transition.SetTrigger("start");
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            progressText.text = progress * 100f + "%";
            Debug.Log(progress);
            yield return WaitForSeconds(transitionTime);
        }
    }

    private object WaitForSeconds(float transitionTime)
    {
        throw new NotImplementedException();
    }

    /*public void LoadNextScene()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex +1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }*/
}
