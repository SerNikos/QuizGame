using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    
    //This is the play button
    private Button button;

    private void Awake()
    {
        //Make Singleton because we need GameManager to be in all of our scenes
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }

    }


    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("play").GetComponent<Button>();
        button.onClick.AddListener(() => ChangeScene());
        
    }

    void ChangeScene()
    {
        //this goes to scene2
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
