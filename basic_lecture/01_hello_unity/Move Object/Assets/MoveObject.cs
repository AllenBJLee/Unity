using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    Vector3 m_vecTarget = new Vector3( 5, 0.25f, 0 );

    RigidBody rigid;

    private void Start() {
        
    }

    void Update( )
    {
        /// 01
        /// 키 입력으로 이동
        Vector3 vecMoveWithKeypad = new Vector3( Input.GetAxis("Horizontal"), 
                                        Input.GetAxis("Vertical"),
                                        0 );

        /// 02
        /// 목표 지점으로 이동
        //transform.position = Vector3.MoveTowards( transform.position ,m_vecTarget, 1f );

        /// 03
        /// 목표 지점으로 스무스 하게 이동 (미끄러지든 감속 이동)
        // Vector3 velo = Vector3.zero;
        // transform.position = Vector3.SmoothDamp( transform.position, m_vecTarget, ref velo, 0.3f );

        /// 04
        /// Lerp (선형 보간 이동)
        // transform.position = Vector3.Lerp( transform.position, m_vecTarget, 0.05f );

        /// 05
        /// Slerp (선형 포물선 보간 이동)
        // transform.position = Vector3.Slerp( transform.position, m_vecTarget, 0.05f );
    }
}
