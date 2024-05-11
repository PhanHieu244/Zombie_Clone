using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ChuongCustom
{
    public abstract class AButton : MonoBehaviour
    {
        [SerializeField] private Button button;

#if UNITY_EDITOR
        private void OnValidate()
        {
            button = GetComponent<Button>();
        }
#endif

        private void Start()
        {
            SetListener(OnClickButton);
            OnStart();
        }

        public void SetListener(UnityAction action)
        {
            button.onClick.AddListener(action);
        }
        
        private void OnDestroy()
        {
            button.onClick.RemoveAllListeners();
        }

        protected abstract void OnClickButton();
        protected abstract void OnStart();
    }
}