using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //static Score _instance = new Score();
    //public static Score Instance => _instance;
    //private Score() { }
    //�Q�[���Ɉ�����ǂ�������Q�Ƃł��邪�A�ŏ�����Ō�܂ł��鑶�݁AMonoBehaviour�͌p�����Ȃ��Ŏg��
    //�~�^���C���񃁃�

    /// <summary>�ʂ̂Ƃ��납��ł��Q�Ƃł���悤�ɂ���</summary>
    public static int tempCoinNum;
    public Text Scoretext;

    //public void AddScore(int score)
    //{
    //    tempCoinNum += score;
    //}
    //public int GetScore ()
    //{
    //    return tempCoinNum;
    //}������̂���

    // Update is called once per frame
    void Update()
    {
        Scoretext.text = "Score:" + tempCoinNum;
    }
}