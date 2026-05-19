using UnityEditor.SceneTemplate;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    private const float limitTime = 120;
    [SerializeField] private float time = 0;

    [SerializeField] Image clockImage;
    private GameSenceManager gameSenceManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameSenceManager = GameObject.Find("gameSenceManager").GetComponent<GameSenceManager>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        clockImage.fillAmount = time / limitTime;
        if(time < limitTime)
        {
            gameSenceManager.EndingLoad();
        }
    }
}
