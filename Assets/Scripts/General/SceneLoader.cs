﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public void loadSceneByIndex(int number) {
        SceneManager.LoadScene(number, LoadSceneMode.Single);
    }

    public void loadSceneByName(string name) {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene(name, LoadSceneMode.Single);
    }
}
