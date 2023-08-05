using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMreset : MonoBehaviour
{
    public GameObject bgmManager;
    // Start is called before the first frame update
    void Start()
    {
         DontDestroyOnLoad(bgmManager);
    }

    // Update is called once per frame
    void Update()
    {
        // SceneManager�̖��O���^�C�g���̏ꍇ��ScoreManager��j��
        if (SceneManager.GetActiveScene().name == "mainscenes")
        {
            Destroy(gameObject);
        }
    }
}
