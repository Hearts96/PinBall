using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class ScoreRegulater : MonoBehaviour
{
    Material myMaterial;

    private int largeStar = 20;
    private int smallStar = 10;
    private int largeCloud = 40;
    private int smallCloud = 30;

    private GameObject scoreText;

    private int score;　

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    void OnCollisionEnter(Collision other)
    {
        //OnColiisionEnter関数の引数から衝突した相手の情報を取得
        string tag =  other.gameObject.tag;

        //if文を使って当たった物によっての条件を書いていく
        if (tag == "LargeStarTag")
        {
            score += this.largeStar;
        }
        else if (tag == "SmallStarTag")
        {
            score += this.smallStar;
        }
        else if (tag == "LargeCloudTag")
        {
            score += this.largeCloud;
        }
        else if (tag == "SmallCloudTag")
        {
            score += this.smallCloud;
        }

        //ScoreTextに点数を表示
        this.scoreText.GetComponent<Text>().text = "Score" + score;


    }
}
