using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ItemGet : MonoBehaviour
{
    /// <summary>�A�C�e������������ɖ���ʉ�</summary>
    [Tooltip("�A�C�e������������ɖ炷���ʉ�")]
    [SerializeField] AudioClip _sound = default;
    bool isGet;             // �l���ς݃t���O

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Debug.Log("������");
            if (_sound)
            {
                AudioSource.PlayClipAtPoint(_sound, Camera.main.transform.position);
            }
            Score.tempCoinNum++;//Player���ڐG�����ꍇ���Z���遁������ɂ��Score�X�N���v�g�ɂ����f�ł���
            // �v���C���[���ڐG�Ŋl������
            if (!isGet)
            {
                isGet = true;
            }
            Destroy(gameObject);

        }

    }
}