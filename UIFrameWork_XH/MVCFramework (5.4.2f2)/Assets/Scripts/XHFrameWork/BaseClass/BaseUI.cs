using UnityEngine;
using System.Collections;


namespace XHFrameWork
{
    public class BaseUI : MonoBehaviour
    {
        #region
        private GameObject _cacheGameObject;
        public GameObject CacheGameObject
        {
            get
            {
                if (_cacheGameObject == null)
                {
                    _cacheGameObject = this.gameObject;
                }
                return _cacheGameObject;
            }
        }

        private Transform _cacheTransform;
        public Transform CacheTransform
        {
            get
            {
                if (_cacheTransform == null)
                {
                    _cacheTransform = this.transform;
                }
                return _cacheTransform;
            }
        }
        #endregion

        protected EnumObjectState _state = EnumObjectState.None;


        public event StateChangeEvent StateChanged;

        public EnumObjectState State
        {
            protected get
            {
                return this._state;
            }
            set
            {
                EnumObjectState oldState = this._state;
                this._state = value;
                if (StateChanged != null)
                {
                    StateChanged(this, this._state, oldState);
                }
            }
        }


    }
}
