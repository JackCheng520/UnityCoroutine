using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

// ================================
//* 功能描述：JWaitForSeconds  
//* 创 建 者：chenghaixiao
//* 创建日期：2016/8/31 16:04:16
// ================================
namespace Assets.JackCheng.Coroutine
{
    public class JWaitForSeconds :JCoroutineYieldInstruction
    {
        private float fStartTime;

        private float fDuration;

        public JWaitForSeconds(float t) {
            fDuration = t;
            fStartTime = -1;
        }

        public override bool IsDone()
        {
            if (fStartTime < 0)
                fStartTime = Time.time;

            Debug.Log(" -- isdone -- ");
            return (Time.time - fStartTime) >= fDuration;
        }
    }
}
