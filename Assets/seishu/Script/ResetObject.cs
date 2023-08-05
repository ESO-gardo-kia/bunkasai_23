using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ���Z�b�g�������^�C�~���O�� ResetEmptyObject �I�u�W�F�N�g���擾
        ScoreManager sm = FindObjectOfType<ScoreManager>();
        // ResetEmptyObject �����������ꍇ�Ƀ��Z�b�g���������s
        if (sm != null)
        {
            sm.ResetObjectTransform();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
