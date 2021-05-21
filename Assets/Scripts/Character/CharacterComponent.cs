using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev.Character
{
    /// <summary>
    /// キャラクタコンポーネント基底クラス
    /// </summary>
    public abstract class CharacterComponent
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CharacterComponent()
        {
        }

        /// <summary>
        /// Update
        /// </summary>
        public virtual void OnUpdate() { }

        /// <summary>
        /// FixedUpdate
        /// </summary>
        public virtual void OnFixedUpdate() { }
    }
}
