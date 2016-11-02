using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// ================================
//* 功能描述：JCoroutineMgr  
//* 创 建 者：chenghaixiao
//* 创建日期：2016/8/31 16:02:52
// ================================
namespace Assets.JackCheng.Coroutine
{
    public class JCoroutineMgr
    {

        public List<System.Collections.IEnumerator> listEnumerator = new List<System.Collections.IEnumerator>();
        private List<int> listIdx = new List<int>();

        public void Update() {
            for (int i = 0; i < listEnumerator.Count; i++) {
                
                if (listEnumerator[i].Current is JCoroutineYieldInstruction) 
                {
                    JCoroutineYieldInstruction cor = listEnumerator[i].Current as JCoroutineYieldInstruction;

                    if (!cor.IsDone()) {
                        continue;
                    }
                }

                if (!listEnumerator[i].MoveNext()) 
                {
                    listIdx.Add(i);
                    continue;
                }
            }

            if (listIdx.Count > 0)
            {
                for (int i = 0; i < listIdx.Count; i++)
                {
                    listEnumerator.RemoveAt(listIdx[i]);
                }
                listIdx.Clear();
            }
        }



        public void StartCoroutine(System.Collections.IEnumerator cor)
        {
            listEnumerator.Add(cor);
        }

    }
}
