using UnityEngine;

public class enemyControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void capture()
    {
        Debug.Log(this.transform.position +" enemy : capture");

    }

    public void cancle()
    {
        //본래 모습으로 돌아가기.
    }

    public void fight()
    {
        //싸워용
    }

    public void win()
    {
        //데리고 사라짐
    }


}
