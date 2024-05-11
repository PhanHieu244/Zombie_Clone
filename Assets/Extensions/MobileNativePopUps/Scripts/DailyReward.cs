using System;
using UnityEngine;

namespace GameController
{
    public class DailyReward : MonoBehaviour
    {
        public readonly DateTime Milestone = new (2020, 4, 24);
        [SerializeField] private int amount = 2;

        private void Awake()
        {
            var date = DateTime.UtcNow.Subtract(Milestone).Days;
            var save = PlayerPrefs.GetInt("dailyrewards", -1);
            gameObject.SetActive(date != save);
            if (date != save)
            {
                PlayerPrefs.SetInt("dailyrewards", date);
            }
        }


        public void ClaimReward()
        {
            Master.Stats.Gem += 2;
            gameObject.SetActive(false);
        }
    }
}