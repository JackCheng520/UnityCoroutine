using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

// ================================
//* 功能描述：JCoroutineTest  
//* 创 建 者：chenghaixiao
//* 创建日期：2016/8/31 16:24:40
// ================================
namespace Assets.JackCheng.Coroutine
{
    public class JCoroutineTest : MonoBehaviour
    {

        JCoroutineMgr corMgr = new JCoroutineMgr();
        void Start() {
            corMgr.StartCoroutine(Wait());

            StartCoroutine(SystemWait());
        }

        IEnumerator Wait() 
        {
            Debug.Log("--- wait start --- :" + Time.time);

            yield return new JWaitForSeconds(5);

            Debug.Log("--- wait end ---:"+Time.time);
        }

        IEnumerator SystemWait() {
            Debug.Log("--- SystemWait start --- :" + Time.time);

            yield return new WaitForSeconds(5);

            Debug.Log("--- SystemWait end ---:" + Time.time);
        }

        void LateUpdate() 
        {
            corMgr.Update();
        }
    }
}
