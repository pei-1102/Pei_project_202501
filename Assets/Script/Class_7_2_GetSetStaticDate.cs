﻿using UnityEngine;
namespace KID

{
    /// <summary>
    /// 練習取得與設定靜態資料
    /// </summary>
    public class Class_7_2_GetSetStaticDate : MonoBehaviour
    {
        // 取得非靜態資料
        // 1. 先定義要獲得資料類別的變數
        // 2. 透過變數取得非靜態資料
        public Class_7_2_Static class_7_2;

        private void Awake()
        {
            Debug.Log($"<color=#f3d>非靜態成員:{class_7_2.inventoryWater}</color>");
            // 取得靜態資料(成員)
            // 類別名稱.靜態成員
            Debug.Log($"<color=#f3d>靜態成員:{Class_7_2_Static.inventoryProp}</color>");
            // 呼叫非靜態方法
            class_7_2.Punch();

            // 類別名稱.靜態成員
            // 取得靜態變數
            Debug.Log($"<color=#fff>靜態成員:{Class_7_2_Static.inventoryProp}</color>");
            // 取得靜態屬性
            Debug.Log($"<color=#f3d>靜態成員:{Class_7_2_Static.skillSecond}</color>");
            // 呼叫靜態方法
            Class_7_2_Static.Kick();
        }

        public Class_7_2_Slime slimeGreen, slimeRed;

        private void Start()
        {
            slimeGreen.hp -= 10;
            Debug.Log($"<color=#3f3>綠史萊姆 HP:{slimeGreen.hp}</color>");
            slimeRed.hp -= 10;
            Debug.Log($"<color=#3f3>紅史萊姆 HP:{slimeRed.hp}</color>");

            // 靜態成員
            // 靜態成員沒辦法透過個體存取
            // slimeGreen.moveSpeed = 3.5f
            Class_7_2_Slime.moveSepeed = 3.5f;
            Debug.Log($"<color=#3f3>史萊姆移動速度:{Class_7_2_Slime.moveSepeed}</color>");
        }
    }
}
